using Data;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VariableGlobale;

namespace Gestionnaire_d_abonnement
{
    public partial class nouveauClient : UserControl
    {
        public nouveauClient()
        {
            InitializeComponent();
            afficherListeDecodeur();

            try
            {
                nom.Text = VariableNouveauClient.Nom;
                prenoms.Text = VariableNouveauClient.Prenoms;
                email.Text = VariableNouveauClient.Email;
                adresse.Text = VariableNouveauClient.Adresse;
                numeroDecodeur.Text = VariableNouveauClient.NumeroDecodeur.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onload nouveau client 1 : (affectation des variables) : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        void afficherListeDecodeur()
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "select numerounique as Décodeur from cartedecodeur where etat = 'non actif'";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauCarteDecodeur.AutoGenerateColumns = true;
                        tableauCarteDecodeur.DataSource = dt;
                    }
                }
                conn.Close();

            }

        }

        private void selectionLigne_Click(object sender, EventArgs e)
        {
            tableauCarteDecodeur.FirstDisplayedScrollingRowIndex = VariableNouveauClient.ligneDecodeur;
            tableauCarteDecodeur.Rows[VariableNouveauClient.ligneDecodeur].Selected = true;
        }




        private void rechercheDecodeur_TextChanged(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                string query = "select numerounique as Décodeur from cartedecodeur where etat = 'non actif'" +
                    "and numerounique like @1";
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@1", "%" + rechercheDecodeur.Text + "%");
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauCarteDecodeur.AutoGenerateColumns = true;
                        tableauCarteDecodeur.DataSource = dt;
                    }
                }
                conn.Close();

            }
        }


        private void tableauCarteDecodeur_SelectionChanged(object sender, EventArgs e)
        {
            if (tableauCarteDecodeur.CurrentRow != null && tableauCarteDecodeur.CurrentRow.Selected)
            {
                numeroDecodeur.Text = tableauCarteDecodeur.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                numeroDecodeur.Text = "";
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            VariableNouveauClient.Nom = "";
            VariableNouveauClient.Prenoms = "";
            VariableNouveauClient.Adresse = "";
            VariableNouveauClient.Email = "";
            VariableNouveauClient.NumeroDecodeur = "";
            VariableNouveauClient.MontantEnEspece = -1;
            VariableNouveauClient.mobileMoney = "";

            panelContenu.Controls.Clear();
            listeClient fenetre = new listeClient();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            String Nom = nom.Text;
            String Prenoms = prenoms.Text;
            String NumDecodeur = numeroDecodeur.Text;
            String Adresse = adresse.Text.ToString();
            String Email = email.Text;

            if (Nom == "")
            {
                MessageBox.Show("Veuillez saisir le nom du client !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nom.Focus();
                return;
            }
            if (Prenoms == "")
            {
                MessageBox.Show("Veuillez saisir le prénoms du client !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prenoms.Focus();
                return;
            }
            if (Email == "")
            {
                MessageBox.Show("Veuillez saisir l'adresse email du client !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email.Focus();
                return;
            }
            if (Adresse == "")
            {
                MessageBox.Show("Veuillez saisir l'adresse du client !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                adresse.Focus();
                return;
            }
            if (NumDecodeur == "")
            {
                MessageBox.Show("Veuillez choisir une numéro de décodeur !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numeroDecodeur.Focus();
                return;
            }

            VariableNouveauClient.ligneDecodeur = tableauCarteDecodeur.CurrentRow.Index;
            VariableNouveauClient.Nom = Nom;
            VariableNouveauClient.Prenoms = Prenoms;
            VariableNouveauClient.Adresse = Adresse;
            VariableNouveauClient.Email = Email;
            VariableNouveauClient.NumeroDecodeur = NumDecodeur;

            panelContenu.Controls.Clear();
            nouveauClient2 fenetre = new nouveauClient2();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

    }
}
