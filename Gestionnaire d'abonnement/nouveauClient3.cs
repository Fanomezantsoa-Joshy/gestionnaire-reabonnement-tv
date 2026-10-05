using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Data;
using VariableGlobale;

namespace Gestionnaire_d_abonnement
{
    public partial class nouveauClient3 : UserControl
    {
        public nouveauClient3()
        {
            InitializeComponent();
            afficherFacture();
        }

        void afficherFacture()
        {
            string numeroFacture = "STREAM-FACT-";
            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();


                string query = @"select codefacture from facture order by codefacture desc limit 1";

                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    numeroFacture = numeroFacture + (Convert.ToInt32(cmd.ExecuteScalar()) + 1).ToString();
                    dbcon.Close();
                }

            }
            numFacture.Text = numeroFacture;
            dateFacture.Text = DateTime.Now.ToString();
            nom.Text = VariableNouveauClient.Nom;
            adresse.Text = VariableNouveauClient.Adresse;
            designation.Text = "Achat d'un décodeur";
            prixUnitaire.Text = VariableNouveauClient.Montant.ToString();
            quantite.Text = "1";
            montant.Text = prixUnitaire.Text;
            montantTotal.Text = prixUnitaire.Text;
            total.Text = montant.Text;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            String Nom = VariableNouveauClient.Nom;
            String Prenoms = VariableNouveauClient.Prenoms;
            String NumDecodeur = VariableNouveauClient.NumeroDecodeur;
            String Adresse = VariableNouveauClient.Adresse;
            String Email = VariableNouveauClient.Email;

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();


                string query1 = @"select codecarte from cartedecodeur where numerounique = @1";
                string query2 = @"select codeutilisateur from client order by codeutilisateur desc limit 1";

                using (var cmd1 = new MySqlCommand(query1, dbcon))
                {
                    cmd1.Parameters.AddWithValue("@1", NumDecodeur);

                    int codecarte = Convert.ToInt32(cmd1.ExecuteScalar());

                    using (var cmd2 = new MySqlCommand(query2, dbcon))
                    {
                        int codeutilisateur = Convert.ToInt32(cmd2.ExecuteScalar()) + 1;

                        string query3 = @"insert into client (nom, prenom, adresse, email, cartedecodeurcode, codeutilisateur) values (@1, @2, @3, @4, @5, @6)";
                        using (var cmd3 = new MySqlCommand(query3, dbcon))
                        {
                            cmd3.Parameters.AddWithValue("@1", Nom);
                            cmd3.Parameters.AddWithValue("@2", Prenoms);
                            cmd3.Parameters.AddWithValue("@3", Adresse);
                            cmd3.Parameters.AddWithValue("@4", Email);
                            cmd3.Parameters.AddWithValue("@5", codecarte);
                            cmd3.Parameters.AddWithValue("@6", codeutilisateur);
                            try
                            {
                                cmd3.ExecuteNonQuery();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("L'adresse email que vous avez saisi est déjà utiliser !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string query4 = @"update cartedecodeur set etat = 'Actif' where codecarte = @1";

                            using (var cmd4 = new MySqlCommand(query4, dbcon))
                            {
                                cmd4.Parameters.AddWithValue("@1", codecarte);

                                try
                                {
                                    cmd4.ExecuteNonQuery();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Impossible de changer l'etat du carte decodeur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                        }

                        int codeClient;
                        string recuperationCodeClient = @"select codeclient from client where cartedecodeurcode = @1";
                        using (var cmdRecCodeCli = new MySqlCommand(recuperationCodeClient, dbcon))
                        {
                            cmdRecCodeCli.Parameters.AddWithValue("@1", codecarte);

                            try
                            {
                                codeClient = Convert.ToInt32(cmdRecCodeCli.ExecuteScalar());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Impossible de récupérer le code client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string query = @"insert into facture (numerofacture, montant, date, statut, codeclient) values (@1, @2, @3, @4, @5)";
                        using (var cmd = new MySqlCommand(query, dbcon))
                        {
                            cmd.Parameters.AddWithValue("@1", numFacture.Text);
                            cmd.Parameters.AddWithValue("@2", montant.Text);
                            cmd.Parameters.AddWithValue("@3", DateTime.Now);
                            cmd.Parameters.AddWithValue("@4", "Payé");
                            cmd.Parameters.AddWithValue("@5", codeClient);

                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Impossible d'inserer le facture : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string insertionHistorique = @"insert into historiqueadmin (dateaction, nomadmin, action) values (curdate(), @1, @2)";
                        using (var cmdHistorique = new MySqlCommand(insertionHistorique, dbcon))
                        {
                            cmdHistorique.Parameters.AddWithValue("@1", VariableCreerCompteAdmin.AdminConnecter);
                            cmdHistorique.Parameters.AddWithValue("@2", "Achat d'un décodeur. | Numéro : " + NumDecodeur + " | Code client : " + codeClient);
                            try
                            {
                                cmdHistorique.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Impossible d'inserer l'historique : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }

                    }

                    dbcon.Close();
                }
            }

            VariableNouveauClient.Nom = "";
            VariableNouveauClient.Prenoms = "";
            VariableNouveauClient.Adresse = "";
            VariableNouveauClient.Email = "";
            VariableNouveauClient.NumeroDecodeur = "";
            VariableNouveauClient.MontantEnEspece = -1;
            VariableNouveauClient.mobileMoney = "";

            MessageBox.Show("Ajout d'un client réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panelContenu.Controls.Clear();
            listeClient fenetre = new listeClient();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            nouveauClient2 fenetre = new nouveauClient2();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            VariableNouveauClient.Nom = "";
            VariableNouveauClient.Prenoms = "";
            VariableNouveauClient.Adresse = "";
            VariableNouveauClient.Email = "";
            VariableNouveauClient.NumeroDecodeur = "";
            VariableNouveauClient.MontantEnEspece = -1;
            VariableNouveauClient.mobileMoney = "";

            panelContenu.Controls.Clear();
            listeClient fenetre = new listeClient();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }
    }
}
