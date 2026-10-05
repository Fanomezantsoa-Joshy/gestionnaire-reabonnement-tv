using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VariableGlobale;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Data;

namespace Gestionnaire_d_abonnement
{
    public partial class Abonnement4 : UserControl
    {
        public Abonnement4()
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
            nom.Text = VariableAbonnement.Nom;
            adresse.Text = VariableAbonnement.Adresse;
            designation.Text = "Abonnement " + VariableAbonnement.nomOffre;
            prixUnitaire.Text = VariableAbonnement.prixUnitaireOffre;
            quantite.Text = VariableAbonnement.quantite.ToString();
            montant.Text = (Convert.ToDecimal(VariableAbonnement.prixUnitaireOffre) * VariableAbonnement.quantite).ToString();
            montantTotal.Text = montant.Text;
            total.Text = montant.Text;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            Abonnement3 fenetre = new Abonnement3();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();

                int codeAbonnement;

                string recCodeAbonnement = @"select codeabonnement from abonnement order by codeabonnement desc limit 1";
                using (var cmdRecCodeAbonnement = new MySqlCommand(recCodeAbonnement, dbcon))
                {

                    try
                    {
                        codeAbonnement = Convert.ToInt32(cmdRecCodeAbonnement.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Impossible de recupérer le code de l'abonnement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string query1 = @"update abonnement set statut = 'Renouvelé' where statut = 'En cours' and clientcode = @1";
                using (var cmd1 = new MySqlCommand(query1, dbcon))
                {
                    cmd1.Parameters.AddWithValue("@1", VariableAbonnement.codeClient);

                    try
                    {
                        cmd1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Impossible de changer le statut des ancien abonnements : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                string query = @"insert into abonnement (codeabonnement ,clientcode, cartedecodeurcode, offrecode, datedebut, datefin, statut, modepaiement) values (@0 ,@1, @2, @3, @4, @5, @6, @7)";
                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@0", codeAbonnement + 1);
                    cmd.Parameters.AddWithValue("@1", VariableAbonnement.codeClient);
                    cmd.Parameters.AddWithValue("@2", VariableAbonnement.codeCarteDecodeur);
                    cmd.Parameters.AddWithValue("@3", VariableAbonnement.codeNouveauOffre);
                    cmd.Parameters.AddWithValue("@4", DateTime.Now);
                    cmd.Parameters.AddWithValue("@5", VariableAbonnement.nouveauFinAbonnement);
                    cmd.Parameters.AddWithValue("@6", "En cours");
                    cmd.Parameters.AddWithValue("@7", VariableAbonnement.modeDePaiement);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Impossible d'effectuer l'insertion de l'abonnement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dbcon.Close();

                }
            }

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();

                string query = @"insert into facture (numerofacture, montant, date, statut, codeclient) values (@1, @2, @3, @4, @5)";
                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", numFacture.Text);
                    cmd.Parameters.AddWithValue("@2", VariableAbonnement.montantEnEspece);
                    cmd.Parameters.AddWithValue("@3", DateTime.Now);
                    cmd.Parameters.AddWithValue("@4", "Payé");
                    cmd.Parameters.AddWithValue("@5", VariableAbonnement.codeClient);

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
                    cmdHistorique.Parameters.AddWithValue("@2", "Achat offre : " + VariableAbonnement.codeNouveauOffre + " | Code client : " + VariableAbonnement.codeClient + " | Facture N°: " + numFacture.Text);
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
                dbcon.Close();
            }

            MessageBox.Show("Réabonnement réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
