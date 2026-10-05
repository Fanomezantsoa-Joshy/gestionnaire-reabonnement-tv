using Data;
using Microsoft.VisualBasic;
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
    public partial class Abonnement1 : UserControl
    {
        public Abonnement1()
        {
            InitializeComponent();
            afficherListeClient();

            /* if (VariableAbonnement.ligneClient >= 0)
             {
                 tableauClient.Rows[VariableAbonnement.ligneClient].Selected = true;
             }
             else 
             {
                 tableauClient.Rows[0].Selected = true;
             }*/
        }

        void afficherListeClient()
        {
            var dbCon = DBConnection.Instance();

            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "select client.Nom, client.Prenom, client.Adresse, client.Email, cartedecodeur.numerounique as Décodeur from client, cartedecodeur where client.cartedecodeurcode = cartedecodeur.codecarte";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauClient.AutoGenerateColumns = true;
                        tableauClient.DataSource = dt;
                    }
                }
            }
        }

        void informations()
        {
            string Email = VariableAbonnement.Email;
            int codeClient;
            int codeCarte;
            DateTime dateDebut;
            DateTime dateFin;

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();
                string query = @"select codeclient from client where email = @1";

                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", Email);
                    codeClient = Convert.ToInt32(cmd.ExecuteScalar());

                    string query2 = @"select codecarte from cartedecodeur where numerounique = @1";

                    using (var cmd2 = new MySqlCommand(query2, dbcon))
                    {
                        cmd2.Parameters.AddWithValue("@1", VariableAbonnement.NumeroDecodeur);
                        codeCarte = Convert.ToInt32(cmd2.ExecuteScalar());

                        string verification = @"select count(*) from abonnement where clientcode = @1";

                        using (var cmdVerification = new MySqlCommand(verification, dbcon))
                        {
                            cmdVerification.Parameters.AddWithValue("@1", codeClient);
                            int ligne = Convert.ToInt32(cmdVerification.ExecuteScalar());

                            if (ligne > 0)
                            {
                                string recuperationCodeAbonnement = @"select codeabonnement from abonnement where clientcode = @1";

                                using (var cmdRecuperationCodeAbonnement = new MySqlCommand(recuperationCodeAbonnement, dbcon))
                                {
                                    cmdRecuperationCodeAbonnement.Parameters.AddWithValue("@1", codeClient);
                                    try
                                    {
                                        VariableAbonnement.codeAbonnement = Convert.ToInt32(cmdRecuperationCodeAbonnement.ExecuteScalar());
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Impossible de récuperer le code de l'abonnement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }

                                string query3 = @"select datedebut from abonnement where clientcode = @1 order by datefin desc limit 1";

                                using (var cmd3 = new MySqlCommand(query3, dbcon))
                                {
                                    cmd3.Parameters.AddWithValue("@1", codeClient);
                                    dateDebut = Convert.ToDateTime(cmd3.ExecuteScalar());
                                }

                                string query4 = @"select dateFin from abonnement where clientcode = @1 order by datefin desc limit 1";

                                using (var cmd4 = new MySqlCommand(query4, dbcon))
                                {
                                    cmd4.Parameters.AddWithValue("@1", codeClient);
                                    dateFin = Convert.ToDateTime(cmd4.ExecuteScalar());

                                }

                                string query5 = @"select offrecode from abonnement where clientcode = @1 order by datefin desc limit 1";
                                int codeOffre;
                                using (var cmd5 = new MySqlCommand(query5, dbcon))
                                {
                                    cmd5.Parameters.AddWithValue("@1", codeClient);
                                    codeOffre = Convert.ToInt32(cmd5.ExecuteScalar());
                                }

                                string query6 = @"select nom from offre where codeoffre = @1";
                                string nomOffre;

                                using (var cmd6 = new MySqlCommand(query6, dbcon))
                                {
                                    cmd6.Parameters.AddWithValue("@1", codeOffre);
                                    nomOffre = Convert.ToString(cmd6.ExecuteScalar());
                                }

                                VariableAbonnement.dateDebut = dateDebut;
                                VariableAbonnement.dateFin = dateFin;
                                VariableAbonnement.offreActuel = nomOffre;

                                TimeSpan intervale = dateFin - DateTime.Now;

                                VariableAbonnement.jourRestant = Convert.ToInt32(intervale.TotalDays);
                            }
                            else
                            {
                                VariableAbonnement.offreActuel = "Aucun";
                                VariableAbonnement.jourRestant = 0;
                            }
                        }
                    }

                    dbcon.Close();
                }
            }
            VariableAbonnement.codeCarteDecodeur = codeCarte;
            VariableAbonnement.codeClient = codeClient;
        }


        private void selectionLigne_Click(object sender, EventArgs e)
        {
            tableauClient.FirstDisplayedScrollingRowIndex = VariableAbonnement.ligneClient;
            tableauClient.Rows[VariableAbonnement.ligneClient].Selected = true;
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }


        private void selectionLigne_Changed(object sender, EventArgs e)
        {
            VariableAbonnement.ligneClient = Convert.ToInt32(tableauClient.CurrentRow.Index);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (tableauClient.CurrentRow != null)
            {
                VariableAbonnement.Nom = tableauClient.CurrentRow.Cells["Nom"].Value.ToString();
                VariableAbonnement.Prenoms = tableauClient.CurrentRow.Cells["Prenom"].Value.ToString();
                VariableAbonnement.Adresse = tableauClient.CurrentRow.Cells["Adresse"].Value.ToString();
                VariableAbonnement.Email = tableauClient.CurrentRow.Cells["Email"].Value.ToString();
                VariableAbonnement.NumeroDecodeur = tableauClient.CurrentRow.Cells["Décodeur"].Value.ToString();
            }

            else
            {
                MessageBox.Show("Veuillez selectionner un client !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            informations();

            panelContenu.Controls.Clear();
            Abonnement2 fenetre = new Abonnement2();
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

        private void rechercheClient_TextChanged(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query =
                  "select client.Nom, client.Prenom, client.Adresse, client.Email, cartedecodeur.numerounique as Décodeur " +
                  "from client, cartedecodeur where client.cartedecodeurcode = cartedecodeur.codecarte " +
                  "and (client.Nom like @search or client.Prenom like @search or client.Email like @search or cartedecodeur.numerounique like @search)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + rechercheClient.Text + "%");

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauClient.AutoGenerateColumns = true;
                        tableauClient.DataSource = dt;
                    }
                }
            }
        }
    }
}
