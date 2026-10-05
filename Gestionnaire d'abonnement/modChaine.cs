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
    public partial class modChaine : UserControl
    {
        public event EventHandler AfficherListe;

        public modChaine()
        {
            InitializeComponent();
            numero.Text = VariableModChaine.Numero.ToString();
            categorie.Text = VariableModChaine.Categorie;
            nom.Text = VariableModChaine.Nom;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            String Nom = nom.Text;
            String Categorie = categorie.Text;

            if (Nom == "")
            {
                MessageBox.Show("Veuillez saisir le nom de la chaîne !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nom.Focus();
                return;
            }
            if (Categorie == "")
            {
                MessageBox.Show("Veuillez saisir la catégorie de la chaine !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categorie.Focus();
                return;
            }

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();

                string query = @"update chaine set nom = @1, categorie = @2, date = @3 where codechaine = @4";
                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    DateTime DateCreation = DateTime.Now;
                    cmd.Parameters.AddWithValue("@1", Nom);
                    cmd.Parameters.AddWithValue("@2", Categorie);
                    cmd.Parameters.AddWithValue("@3", DateCreation);
                    cmd.Parameters.AddWithValue("@4", VariableModChaine.Numero);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Modification impossible ! : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string insertionHistorique = @"insert into historiqueadmin (dateaction, nomadmin, action) values (curdate(), @1, @2)";
                    using (var cmdHistorique = new MySqlCommand(insertionHistorique, dbcon))
                    {
                        cmdHistorique.Parameters.AddWithValue("@1", VariableCreerCompteAdmin.AdminConnecter);
                        cmdHistorique.Parameters.AddWithValue("@2", "Modification des informations d'une chaîne. | Chaîne N° : " + VariableModChaine.Numero);
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

            MessageBox.Show("Modification des informations du chaîne réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AfficherListe?.Invoke(this, EventArgs.Empty);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            AfficherListe?.Invoke(this, EventArgs.Empty);
        }
    }
}
