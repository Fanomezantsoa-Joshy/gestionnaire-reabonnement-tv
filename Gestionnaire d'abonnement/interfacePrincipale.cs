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
    public partial class interfacePrincipale : UserControl
    {
        public interfacePrincipale()
        {
            InitializeComponent();
            btnSeDeconnecter.Controls.Clear();
            listeClient fenetre = new listeClient();
            fenetre.Dock = DockStyle.Fill;
            btnSeDeconnecter.Controls.Add(fenetre);
            MAJAbonnement();
        }

        void MAJAbonnement()
        {
            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();

                string query = @"update abonnement set statut = 'Expiré' where datefin < curdate()";

                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.ExecuteNonQuery();
                }

                dbcon.Close();
            }
        }



        private void btnMonCompte_Click(object sender, EventArgs e)
        {
            btnSeDeconnecter.Controls.Clear();
            monCompte fenetre = new monCompte();
            fenetre.Dock = DockStyle.Fill;

            fenetre.AfficherLogin += afficherLogin;

            btnSeDeconnecter.Controls.Add(fenetre);
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            btnSeDeconnecter.Controls.Clear();
            Historique fenetre = new Historique();
            fenetre.Dock = DockStyle.Fill;
            btnSeDeconnecter.Controls.Add(fenetre);
        }


        private void afficherLogin(object sender, EventArgs e)
        {
            panelPrincipale.Controls.Clear();
            ConnexionAdmin fenetre = new ConnexionAdmin();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }

        private void menuClients_Click(object sender, EventArgs e)
        {
            btnSeDeconnecter.Controls.Clear();
            listeClient fenetre = new listeClient();
            fenetre.Dock = DockStyle.Fill;
            btnSeDeconnecter.Controls.Add(fenetre);
        }

        private void menuChaine_Click(object sender, EventArgs e)
        {
            btnSeDeconnecter.Controls.Clear();
            listeChaine fenetre = new listeChaine();
            fenetre.Dock = DockStyle.Fill;
            btnSeDeconnecter.Controls.Add(fenetre);
        }

        private void menuOffre_Click(object sender, EventArgs e)
        {
            btnSeDeconnecter.Controls.Clear();
            listeOffre fenetre = new listeOffre();
            fenetre.Dock = DockStyle.Fill;
            btnSeDeconnecter.Controls.Add(fenetre);
        }

        private void menuAbonnement_Click(object sender, EventArgs e)
        {
            VariableNouveauClient.Menu = "abonnement";
            btnSeDeconnecter.Controls.Clear();
            Abonnement1 fenetre = new Abonnement1();
            fenetre.Dock = DockStyle.Fill;
            btnSeDeconnecter.Controls.Add(fenetre);
        }

        private void menuSeDeconnecter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment vous déconnecter !", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            panelPrincipale.Controls.Clear();
            ConnexionAdmin fenetre = new ConnexionAdmin();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }
    }
}
