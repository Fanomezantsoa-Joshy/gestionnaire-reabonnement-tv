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
    public partial class mdpOublier2 : UserControl
    {
        public mdpOublier2()
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
            mdpOublier1 fenetre = new mdpOublier1();
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

        private void btnRécupérer_Click(object sender, EventArgs e)
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
                string query = @"update administrateur set mdp = @1 where nomadmin = @2";

                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", ConfirmerMdp);
                    cmd.Parameters.AddWithValue("@2", NomAdmin);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            MessageBox.Show("Récupération du compte administrateur réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panelPrincipale.Controls.Clear();
            ConnexionAdmin fenetre = new ConnexionAdmin();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }
    }
}
