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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestionnaire_d_abonnement
{
    public partial class listeChaine : UserControl
    {
        public listeChaine()
        {
            InitializeComponent();
            panelForm.Hide();
            panelContenu.Dock = DockStyle.Fill;
            afficherListeChaine();
        }

        void afficherListeChaine()
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "select CodeChaine as Numéro, Nom, Categorie, Date from chaine";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauChaine.AutoGenerateColumns = true;
                        tableauChaine.DataSource = dt;
                    }
                }
            }

        }

        private void afficherLaListe(object sender, EventArgs e)
        {
            panelTeste.Controls.Clear();
            listeChaine fenetre = new listeChaine();
            fenetre.Dock = DockStyle.Fill;

            panelTeste.Controls.Add(fenetre);

            panelForm.Hide();
            panelContenu.Dock = DockStyle.Fill;
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (tableauChaine.CurrentRow != null)
            {
                VariableModChaine.Numero = Convert.ToInt32(tableauChaine.CurrentRow.Cells["Numéro"].Value);
                VariableModChaine.Nom = tableauChaine.CurrentRow.Cells["Nom"].Value.ToString();
                VariableModChaine.Categorie = tableauChaine.CurrentRow.Cells["Categorie"].Value.ToString();
            }

            else
            {
                MessageBox.Show("Veuillez selectionner un client !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            panelForm.Show();
            panelContenu.Dock = DockStyle.Top;
            panelForm.Controls.Clear();
            modChaine fenetre = new modChaine();

            panelOption.Hide();
            fenetre.AfficherListe += afficherLaListe;

            fenetre.Dock = DockStyle.Fill;
            panelForm.Dock = DockStyle.Bottom;
            panelForm.Controls.Add(fenetre);
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            panelForm.Show();
            panelContenu.Dock = DockStyle.Top;

            panelForm.Controls.Clear();
            ajoutChaine fenetre = new ajoutChaine();

            panelOption.Hide();


            fenetre.AfficherListe += afficherLaListe;

            fenetre.Dock = DockStyle.Fill;
            panelForm.Dock = DockStyle.Bottom;
            panelForm.Controls.Add(fenetre);
        }



        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string Numero;
            MessageBox.Show("Voulez-vous vraiment supprimer ce chaîne ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tableauChaine.CurrentRow != null)
            {
                Numero = tableauChaine.CurrentRow.Cells["Numéro"].Value.ToString();
            }

            else
            {
                MessageBox.Show("Veuillez selectionner une chaîne !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "delete from offrechaine where codechaine = @1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@1", Numero);
                    cmd.ExecuteNonQuery();

                    string query2 = "delete from chaine where codechaine = @1";

                    using (var cmd2 = new MySqlCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@1", Numero);
                        cmd2.ExecuteNonQuery();

                    }
                }

                afficherListeChaine();
                MessageBox.Show("Suppression du chaîne réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void rechercheChaine_TextChanged(object sender, EventArgs e)
        {
            if (rechercheChaine.Text != null)
            {
                {
                    using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
                    {
                        conn.Open();

                        string query = "select CodeChaine as Numéro, Nom, Categorie, Date from chaine" +
                        " where Nom like @1 or Categorie like @1";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@1", "%" + rechercheChaine.Text + "%");

                            using (var adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                tableauChaine.AutoGenerateColumns = true;
                                tableauChaine.DataSource = dt;
                            }
                        }


                    }
                }
            }
        }
    }
}
