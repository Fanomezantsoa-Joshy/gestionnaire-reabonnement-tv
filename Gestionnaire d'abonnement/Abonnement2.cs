using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Data;
using VariableGlobale;

namespace Gestionnaire_d_abonnement
{
    public partial class Abonnement2 : UserControl
    {
        public Abonnement2()
        {
            InitializeComponent();
            afficherListeOffre();

            offreActuel.Text = VariableAbonnement.offreActuel;
            jourRestant.Text = VariableAbonnement.jourRestant.ToString();
            quantite.Value = VariableAbonnement.quantite;

            /*if (VariableAbonnement.ligneOffre >= 0)
            {
                tableauOffre.Rows[VariableAbonnement.ligneOffre].Selected = true;

            }
            else 
            {
                tableauOffre.Rows[0].Selected = true;
            }*/
        }

        void afficherListeOffre()
        {
            var dbCon = DBConnection.Instance();

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


        private void selectionLigne_Click(object sender, EventArgs e)
        {
            tableauOffre.FirstDisplayedScrollingRowIndex = VariableAbonnement.ligneOffre;
            tableauOffre.Rows[VariableAbonnement.ligneOffre].Selected = true;
        }

        private void selectionLigne_Changed(object sender, EventArgs e)
        {
            string nomOffre = tableauOffre.CurrentRow.Cells["Nom"].Value.ToString();
            if (offreActuel.Text != nomOffre)
            {
                jourRestant.Text = "0";
            }
            else
            {
                jourRestant.Text = VariableAbonnement.jourRestant.ToString();
            }
            VariableAbonnement.ligneOffre = tableauOffre.CurrentRow.Index;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            VariableAbonnement.ligneOffre = tableauOffre.CurrentRow.Index;
            panelContenu.Controls.Clear();
            Abonnement1 fenetre = new Abonnement1();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (tableauOffre.CurrentRow != null)
            {
                string nomOffre = tableauOffre.CurrentRow.Cells["Nom"].Value.ToString();
                VariableAbonnement.delaiOffre = Convert.ToInt32(tableauOffre.CurrentRow.Cells["Duree"].Value);
                VariableAbonnement.quantite = Convert.ToInt32(quantite.Value);
                VariableAbonnement.prixOffre = Convert.ToDecimal(tableauOffre.CurrentRow.Cells["Prix"].Value) * VariableAbonnement.quantite;
                VariableAbonnement.prixUnitaireOffre = tableauOffre.CurrentRow.Cells["Prix"].Value.ToString();


                if (offreActuel.Text.ToString() == nomOffre)
                {
                    VariableAbonnement.nouveauDelaiOffre = VariableAbonnement.jourRestant + (VariableAbonnement.delaiOffre * Convert.ToInt32(quantite.Value));
                }
                else
                {
                    VariableAbonnement.nouveauDelaiOffre = VariableAbonnement.delaiOffre * Convert.ToInt32(quantite.Value);
                }

                string query = @"select codeoffre from offre where nom = @1";

                using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
                {
                    dbcon.Open();
                    using (var cmd = new MySqlCommand(query, dbcon))
                    {
                        cmd.Parameters.AddWithValue("@1", nomOffre);

                        try
                        {
                            VariableAbonnement.codeNouveauOffre = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    dbcon.Close();
                }
                VariableAbonnement.nomOffre = nomOffre;
                VariableAbonnement.nouveauFinAbonnement = DateTime.Now.AddDays(VariableAbonnement.nouveauDelaiOffre);
            }

            else
            {
                MessageBox.Show("Veuillez selectionner une offre !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            panelContenu.Controls.Clear();
            Abonnement3 fenetre = new Abonnement3();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            VariableAbonnement.ligneClient = 0;
            VariableAbonnement.ligneOffre = 0;
            VariableAbonnement.quantite = 1;
            VariableAbonnement.mobileMoney = "";
            VariableAbonnement.modeDePaiement = "";
            VariableAbonnement.montantEnEspece = -1;

            panelContenu.Controls.Clear();
            Abonnement1 fenetre = new Abonnement1();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

    }

}
