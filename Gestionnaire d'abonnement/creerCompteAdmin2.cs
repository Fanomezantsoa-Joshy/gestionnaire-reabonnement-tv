using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VariableGlobale;
using Data;

namespace Gestionnaire_d_abonnement
{
    public partial class creerCompteAdmin2 : UserControl
    {
        public creerCompteAdmin2()
        {
            InitializeComponent();
            nouveauMdp.Text = VariableCreerCompteAdmin.NouveauMdp;
            confirmerMdp.Text = VariableCreerCompteAdmin.ConfirmerMdp;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            VariableCreerCompteAdmin.NouveauMdp = nouveauMdp.Text;
            VariableCreerCompteAdmin.ConfirmerMdp = confirmerMdp.Text;

            panelPrincipale.Controls.Clear();
            creerCompteAdmin1 fenetre = new creerCompteAdmin1();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }

        private void btnCréer_Click(object sender, EventArgs e)
        {
            string NomAdmin = VariableCreerCompteAdmin.NomAdmin;
            string Nom = VariableCreerCompteAdmin.Nom;
            string Prenoms = VariableCreerCompteAdmin.Prenoms;
            DateTime Naissance = VariableCreerCompteAdmin.Naissance;
            String NouveauMdp = nouveauMdp.Text;
            String ConfirmerMdp = confirmerMdp.Text;

            if (NouveauMdp == "")
            {
                MessageBox.Show("Veuillez saisir le nouveau mot de passe !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nouveauMdp.Focus();
                return;
            }
            if (ConfirmerMdp == "")
            {
                MessageBox.Show("Veuillez confirmer le nouveau mot de passe!", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                confirmerMdp.Focus();
                return;
            }
            if (NouveauMdp != ConfirmerMdp)
            {
                MessageBox.Show("Les mots de passe que vous avez saisi sont différents !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                confirmerMdp.Focus();
                return;
            }

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();

                string query = @"insert into administrateur values (@1, @2, @3, @4, @5)";
                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", NomAdmin);
                    cmd.Parameters.AddWithValue("@2", Nom);
                    cmd.Parameters.AddWithValue("@3", Prenoms);
                    cmd.Parameters.AddWithValue("@4", Naissance);
                    cmd.Parameters.AddWithValue("@5", ConfirmerMdp);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Le nom d'administrateur que vous avez saisi est déjà utiliser !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        panelPrincipale.Controls.Clear();
                        creerCompteAdmin1 fen = new creerCompteAdmin1();
                        fen.Dock = DockStyle.Fill;
                        panelPrincipale.Controls.Add(fen);
                        return;
                    }

                    string insertionHistorique = @"insert into historiqueadmin (dateaction, nomadmin, action) values (curdate(), @1, @2)";
                    using (var cmdHistorique = new MySqlCommand(insertionHistorique, dbcon))
                    {
                        cmdHistorique.Parameters.AddWithValue("@1", NomAdmin);
                        cmdHistorique.Parameters.AddWithValue("@2", "Création d'un compte administrateur | Nom : " + NomAdmin);

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
            }

            VariableCreerCompteAdmin.NomAdmin = "";
            VariableCreerCompteAdmin.Nom = "";
            VariableCreerCompteAdmin.Prenoms = "";
            VariableCreerCompteAdmin.Naissance = VariableCreerCompteAdmin.DateMaximal;
            VariableCreerCompteAdmin.NouveauMdp = "";
            VariableCreerCompteAdmin.ConfirmerMdp = "";

            MessageBox.Show("Création du compte administrateur réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panelPrincipale.Controls.Clear();
            ConnexionAdmin fenetre = new ConnexionAdmin();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            VariableCreerCompteAdmin.NomAdmin = "";
            VariableCreerCompteAdmin.Nom = "";
            VariableCreerCompteAdmin.Prenoms = "";
            VariableCreerCompteAdmin.Naissance = VariableCreerCompteAdmin.DateMaximal;
            VariableCreerCompteAdmin.NouveauMdp = "";
            VariableCreerCompteAdmin.ConfirmerMdp = "";

            panelPrincipale.Controls.Clear();
            ConnexionAdmin fenetre = new ConnexionAdmin();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }

    }
}
