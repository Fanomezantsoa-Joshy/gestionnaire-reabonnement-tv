using Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VariableGlobale;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestionnaire_d_abonnement
{
    public partial class listeClient : UserControl
    {
        public listeClient()
        {
            InitializeComponent();
            afficherListeClient();
        }

        void afficherListeClient()
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "select client.Nom, client.Prenom, client.Adresse, client.Email, cartedecodeur.numerounique as Décodeur from client, cartedecodeur where client.cartedecodeurcode = cartedecodeur.codecarte";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauClient.AutoGenerateColumns = true;
                        tableauClient.DataSource = dt;
                    }
                }
            }

        }


        private void btnNouveau_Click(object sender, EventArgs e)
        {
            VariableNouveauClient.Menu = "client";
            panelContenu.Controls.Clear();
            nouveauClient fenetre = new nouveauClient();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (tableauClient.CurrentRow != null)
            {
                VariableModClient.Nom = tableauClient.CurrentRow.Cells["Nom"].Value.ToString();
                VariableModClient.Prenoms = tableauClient.CurrentRow.Cells["Prenom"].Value.ToString();
                VariableModClient.Adresse = tableauClient.CurrentRow.Cells["Adresse"].Value.ToString();
                VariableModClient.Email = tableauClient.CurrentRow.Cells["Email"].Value.ToString();
                VariableModClient.CarteDecodeur = tableauClient.CurrentRow.Cells["Décodeur"].Value.ToString();
            }

            else
            {
                MessageBox.Show("Veuillez selectionner un client !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            panelContenu.Controls.Clear();
            modClient fenetre = new modClient();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string Email;
            string NumeroDecodeur;

            MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tableauClient.CurrentRow != null)
            {
                Email = tableauClient.CurrentRow.Cells["Email"].Value.ToString();
                NumeroDecodeur = tableauClient.CurrentRow.Cells["Décodeur"].Value.ToString();
            }

            else
            {
                MessageBox.Show("Veuillez selectionner un client !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "delete from client where email = @1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@1", Email);
                    cmd.ExecuteNonQuery();

                    string query2 = "update cartedecodeur set etat = 'Non Actif' where numerounique = @1";

                    using (var cmd2 = new MySqlCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@1", NumeroDecodeur);
                        cmd2.ExecuteNonQuery();

                    }
                }

                afficherListeClient();
                MessageBox.Show("Suppression du client réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rechercheClient_TextChanged(object sender, EventArgs e)
        {

            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query =
                  "select client.Nom, client.Prenom, client.Adresse, client.Email, cartedecodeur.numerounique as Décodeur " +
                  "from client, cartedecodeur where client.cartedecodeurcode = cartedecodeur.codecarte " +
                  "and (client.Nom like @search or client.Prenom like @search or client.Email like @search or cartedecodeur.numerounique like @search)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + rechercheClient.Text + "%");

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauClient.AutoGenerateColumns = true;
                        tableauClient.DataSource = dt;
                    }
                }
            }
        }
    }

}
