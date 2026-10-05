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
    public partial class changerMdp : UserControl
    {
        public changerMdp()
        {
            InitializeComponent();
            ancienMdp.Focus();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            String AncienMdp = ancienMdp.Text;
            String NouveauMdp = nouveauMdp.Text;
            String ConfirmerMdp = confirmerMdp.Text;
            String NomAdmin = VariableCreerCompteAdmin.AdminConnecter;

            if (AncienMdp == "")
            {
                MessageBox.Show("Veuillez saisir l'ancien mot de passe !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ancienMdp.Focus();
                return;
            }
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
                string query = @"select count(*) from administrateur where nomadmin = @1 and mdp = @2";

                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", NomAdmin);
                    cmd.Parameters.AddWithValue("@2", AncienMdp);

                    long nbr = (long)cmd.ExecuteScalar();

                    if (nbr > 0)
                    {
                        string query2 = @"update administrateur set mdp = @1 where nomadmin = @2";
                        var cmd2 = new MySqlCommand(query2, dbcon);
                        cmd2.Parameters.AddWithValue("@1", NouveauMdp);
                        cmd2.Parameters.AddWithValue("@2", NomAdmin);
                        cmd2.ExecuteNonQuery();
                    }

                    else
                    {
                        MessageBox.Show("L'ancien mot de passe est incorrecte. Impossible de faire le changement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ancienMdp.Focus();
                        return;
                    }

                    string insertionHistorique = @"insert into historiqueadmin (dateaction, nomadmin, action) values (curdate(), @1, @2)";
                    using (var cmdHistorique = new MySqlCommand(insertionHistorique, dbcon))
                    {
                        cmdHistorique.Parameters.AddWithValue("@1", VariableCreerCompteAdmin.AdminConnecter);
                        cmdHistorique.Parameters.AddWithValue("@2", "Changement du mot de passe");
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

            MessageBox.Show("Mot de passe changer aver succés !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
