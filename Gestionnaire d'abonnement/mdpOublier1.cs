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
    public partial class mdpOublier1 : UserControl
    {
        public mdpOublier1()
        {
            InitializeComponent();

            naissance.MaxDate = VariableCreerCompteAdmin.DateMaximal;

            nomAdmin.Text = VariableCreerCompteAdmin.NomAdmin;
            nom.Text = VariableCreerCompteAdmin.Nom;
            prenoms.Text = VariableCreerCompteAdmin.Prenoms;
            naissance.Value = VariableCreerCompteAdmin.Naissance;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            String NomAdmin = nomAdmin.Text;
            String Nom = nom.Text;
            String Prenoms = prenoms.Text;
            DateTime Naissance = naissance.Value;

            if (NomAdmin == "")
            {
                MessageBox.Show("Veuillez saisir votre nom d'administrateur !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nomAdmin.Focus();
                return;
            }
            if (Nom == "")
            {
                MessageBox.Show("Veuillez saisir votre nom !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nom.Focus();
                return;
            }
            if (Prenoms == "")
            {
                MessageBox.Show("Veuillez saisir votre prénoms !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prenoms.Focus();
                return;
            }

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();
                string query = @"select count(*) from administrateur where nomadmin = @1 and nom = @2 and prenoms = @3 and naissance = @4";

                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", NomAdmin);
                    cmd.Parameters.AddWithValue("@2", Nom);
                    cmd.Parameters.AddWithValue("@3", Prenoms);
                    cmd.Parameters.AddWithValue("@4", Naissance);
                    long nbr = (long)cmd.ExecuteScalar();

                    if (nbr > 0)
                    {
                        panelPrincipale.Controls.Clear();
                        mdpOublier2 fenetre = new mdpOublier2();
                        fenetre.Dock = DockStyle.Fill;
                        panelPrincipale.Controls.Add(fenetre);
                    }

                    else
                    {
                        MessageBox.Show("Les informations que vous avez saisi est incorrecte. Impossible de faire la récupération !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nomAdmin.Focus();
                        return;
                    }

                    dbcon.Close();
                }
            }

            VariableCreerCompteAdmin.NomAdmin = NomAdmin;
            VariableCreerCompteAdmin.Nom = Nom;
            VariableCreerCompteAdmin.Prenoms = Prenoms;
            VariableCreerCompteAdmin.Naissance = Naissance;
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
