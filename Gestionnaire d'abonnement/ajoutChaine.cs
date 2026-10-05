using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Data;

namespace Gestionnaire_d_abonnement
{
    public partial class ajoutChaine : UserControl
    {

        public event EventHandler AfficherListe;
        public ajoutChaine()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string Numero = numero.Value.ToString();
            String Nom = nom.Text;
            String Categorie = categorie.Text;

            if (Nom == "")
            {
                MessageBox.Show("Veuillez saisir le nom de la chaîne !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numero.Focus();
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

                string query = @"insert into chaine values (@1, @2, @3, @4)";
                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    DateTime DateCreation = DateTime.Now;
                    cmd.Parameters.AddWithValue("@1", Numero);
                    cmd.Parameters.AddWithValue("@2", Nom);
                    cmd.Parameters.AddWithValue("@3", Categorie);
                    cmd.Parameters.AddWithValue("@4", DateCreation);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Le numéro de chaîne que vous avez saisi est déjà utiliser !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        numero.Focus();
                        return;
                    }
                    dbcon.Close();

                }
            }

            MessageBox.Show("Ajout d'une chaîne réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AfficherListe?.Invoke(this, EventArgs.Empty);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            AfficherListe?.Invoke(this, EventArgs.Empty);
        }
    }
}
