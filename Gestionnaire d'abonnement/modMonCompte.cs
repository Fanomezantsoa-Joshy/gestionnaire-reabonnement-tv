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
    public partial class modMonCompte : UserControl
    {
        public modMonCompte()
        {
            InitializeComponent();
            nomAdmin.Focus();
            naissance.MaxDate = VariableCreerCompteAdmin.DateMaximal;
            nomAdmin.Text = VariableCreerCompteAdmin.AdminConnecter;
            nom.Text = VariableCreerCompteAdmin.Nom;
            prenoms.Text = VariableCreerCompteAdmin.Prenoms;
            naissance.Value = VariableCreerCompteAdmin.Naissance;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string AdminConnecter = VariableCreerCompteAdmin.AdminConnecter;
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

                string query = @"update administrateur set nomadmin = @1, nom = @2, prenoms = @3, naissance = @4 where nomadmin = @5";
                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", NomAdmin);
                    cmd.Parameters.AddWithValue("@2", Nom);
                    cmd.Parameters.AddWithValue("@3", Prenoms);
                    cmd.Parameters.AddWithValue("@4", Naissance);
                    cmd.Parameters.AddWithValue("@5", AdminConnecter);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Le nom d'administrateur que vous avez saisi est déjà utiliser !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string insertionHistorique = @"insert into historiqueadmin (dateaction, nomadmin, action) values (curdate(), @1, @2)";
                    using (var cmdHistorique = new MySqlCommand(insertionHistorique, dbcon))
                    {
                        cmdHistorique.Parameters.AddWithValue("@1", VariableCreerCompteAdmin.AdminConnecter);
                        cmdHistorique.Parameters.AddWithValue("@2", "Modifictaion des informations du compte administrateur");
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

            VariableCreerCompteAdmin.AdminConnecter = NomAdmin;
            MessageBox.Show("Modification des informations du compte réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panelContenu.Controls.Clear();
            monCompte fenetre = new monCompte();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            monCompte fenetre = new monCompte();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }
    }
}
