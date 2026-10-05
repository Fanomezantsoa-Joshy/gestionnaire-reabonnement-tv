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
    public partial class ConnexionAdmin : UserControl
    {
        public ConnexionAdmin()
        {
            InitializeComponent();
            VariableCreerCompteAdmin.NomAdmin = "";
            VariableCreerCompteAdmin.Nom = "";
            VariableCreerCompteAdmin.Prenoms = "";
            VariableCreerCompteAdmin.Naissance = VariableCreerCompteAdmin.DateMaximal;
            VariableCreerCompteAdmin.NouveauMdp = "";
            VariableCreerCompteAdmin.ConfirmerMdp = "";
            nomAdmin.Focus();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            String NomAdmin = nomAdmin.Text;
            String Mdp = mdp.Text;

            if (NomAdmin == "")
            {
                MessageBox.Show("Veuillez saisir votre nom d'administrateur !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nomAdmin.Focus();
                return;
            }

            if (Mdp == "")
            {
                MessageBox.Show("Veuillez saisir votre mot de passe !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mdp.Focus();
                return;
            }

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();
                string query = @"select count(*) from administrateur where nomadmin = @1";

                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", NomAdmin);
                    long nbr1 = (long)cmd.ExecuteScalar();

                    if (nbr1 > 0)
                    {
                        string query2 = @"select count(*) from administrateur where nomadmin = @1 and mdp = @2";
                        var cmd2 = new MySqlCommand(query2, dbcon);
                        cmd2.Parameters.AddWithValue("@1", NomAdmin);
                        cmd2.Parameters.AddWithValue("@2", Mdp);
                        long nbr2 = (long)cmd2.ExecuteScalar();

                        if (nbr2 > 0)
                        {
                            panelPrincipale.Controls.Clear();
                            interfacePrincipale fen = new interfacePrincipale();
                            fen.Dock = DockStyle.Fill;
                            panelPrincipale.Controls.Add(fen);
                        }
                        else
                        {
                            MessageBox.Show("Le mot de passe que vous avez saisi est incorrecte !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mdp.Focus();
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Le nom d'administrateur que vous avez saisi est incorrecte !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nomAdmin.Focus();
                        return;
                    }

                    VariableCreerCompteAdmin.AdminConnecter = NomAdmin;
                    dbcon.Close();
                }
            }




            panelPrincipale.Controls.Clear();
            interfacePrincipale fenetre = new interfacePrincipale();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }

        private void btnMdpOublier_Click(object sender, EventArgs e)
        {
            panelPrincipale.Controls.Clear();
            mdpOublier1 fenetre = new mdpOublier1();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            panelPrincipale.Controls.Clear();
            creerCompteAdmin1 fenetre = new creerCompteAdmin1();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }
    }
}
