using Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VariableGlobale;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestionnaire_d_abonnement
{
    public partial class listeOffre : UserControl
    {
        public listeOffre()
        {
            InitializeComponent();
            afficherListeOffre();
        }

        void afficherListeOffre()
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "select Nom, Prix, Duree, Description from offre";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauOffre.AutoGenerateColumns = true;
                        tableauOffre.DataSource = dt;
                    }
                }
            }

        }


        private void tableauOffre_SelectionChanged(object sender, EventArgs e)
        {
            string nomOffre;
            if (tableauOffre.CurrentRow != null && tableauOffre.CurrentRow.Selected)
            {
                nomOffre = tableauOffre.CurrentRow.Cells["Nom"].Value.ToString();

                using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
                {
                    conn.Open();

                    string query = "select nom as Nom from chaine where codechaine in (select codechaine from offrechaine where codeoffre = (select codeoffre from offre where nom = @Nom))";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nomOffre);

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            try
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                tableauChaine.AutoGenerateColumns = true;
                                tableauChaine.DataSource = dt;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }

                }
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment supprimer cette offre ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string Nom;
            if (tableauOffre.CurrentRow != null)
            {
                Nom = tableauOffre.CurrentRow.Cells["Nom"].Value.ToString();
            }

            else
            {
                MessageBox.Show("Veuillez selectionner une offre!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int codeOffre;

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();
                string query = @"select codeoffre from offre where nom = @1";

                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", Nom);

                    codeOffre = Convert.ToInt32(cmd.ExecuteScalar());

                    string query2 = @"delete from offrechaine where codeoffre = @1";

                    using (var cmd2 = new MySqlCommand(query2, dbcon))
                    {
                        cmd2.Parameters.AddWithValue("@1", codeOffre);
                        cmd2.ExecuteNonQuery();

                        string query3 = @"delete from offre where codeoffre = @1";

                        using (var cmd3 = new MySqlCommand(query3, dbcon))
                        {
                            cmd3.Parameters.AddWithValue("@1", codeOffre);
                            cmd3.ExecuteNonQuery();
                        }
                    }

                    dbcon.Close();
                }
            }

            afficherListeOffre();
            MessageBox.Show("Suppression de l'offre réussi !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (tableauOffre.CurrentRow != null)
            {
                VariableModOffre.Nom = tableauOffre.CurrentRow.Cells["Nom"].Value.ToString();
                VariableModOffre.Tarif = tableauOffre.CurrentRow.Cells["Prix"].Value.ToString();
                VariableModOffre.Duree = tableauOffre.CurrentRow.Cells["Duree"].Value.ToString();
                VariableModOffre.Description = tableauOffre.CurrentRow.Cells["Description"].Value.ToString();
            }

            else
            {
                MessageBox.Show("Veuillez selectionner un client !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            panelContenu.Controls.Clear();
            modOffre fenetre = new modOffre();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            nouveauOffre fenetre = new nouveauOffre();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }
    }
}

