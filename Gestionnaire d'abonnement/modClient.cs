using Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VariableGlobale;

namespace Gestionnaire_d_abonnement
{
    public partial class modClient : UserControl
    {
        public modClient()
        {
            InitializeComponent();
            afficherListeDecodeur();
            nom.Text = VariableModClient.Nom;
            prenoms.Text = VariableModClient.Prenoms;
            adresse.Text = VariableModClient.Adresse;
            email.Text = VariableModClient.Email;
        }

        void afficherListeDecodeur()
        {
            var dbCon = DBConnection.Instance();

            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "select numerounique as Décodeur from cartedecodeur where etat = 'non actif' or numerounique = @1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@1", VariableModClient.CarteDecodeur);
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauCarteDecodeur.AutoGenerateColumns = true;
                        tableauCarteDecodeur.DataSource = dt;
                    }
                }
            }

        }


        private void tableauCarteDecodeur_SelectionChanged(object sender, EventArgs e)
        {
            if (tableauCarteDecodeur.CurrentRow != null)
            {
                numeroDecodeur.Text = tableauCarteDecodeur.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void selectionLigne_Click(object sender, EventArgs e)
        {
            string numeroDecodeur = VariableModClient.CarteDecodeur;
            int ligneNumero = -1;

            foreach (DataGridViewRow ligne in tableauCarteDecodeur.Rows)
            {
                if (ligne.Cells["Décodeur"].Value.ToString() == numeroDecodeur)
                {
                    ligneNumero = ligne.Index;
                }
            }

            tableauCarteDecodeur.FirstDisplayedScrollingRowIndex = ligneNumero;
            tableauCarteDecodeur.Rows[ligneNumero].Selected = true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            String Nom = nom.Text;
            String Prenoms = prenoms.Text;
            String NumDecodeur = numeroDecodeur.Text;
            String Adresse = adresse.Text;
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
                adresse.Focus();
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

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();


                string query1 = @"select codecarte from cartedecodeur where numerounique = @1";
                string clientActuel = VariableModClient.Nom;

                using (var cmd1 = new MySqlCommand(query1, dbcon))
                {
                    cmd1.Parameters.AddWithValue("@1", NumDecodeur);

                    int codecarte = Convert.ToInt32(cmd1.ExecuteScalar());

                    string query3 = @"update client set nom = @1, prenom = @2, adresse = @3, email = @4, cartedecodeurcode = @5 where nom = @6";
                    using (var cmd3 = new MySqlCommand(query3, dbcon))
                    {
                        cmd3.Parameters.AddWithValue("@1", Nom);
                        cmd3.Parameters.AddWithValue("@2", Prenoms);
                        cmd3.Parameters.AddWithValue("@3", Adresse);
                        cmd3.Parameters.AddWithValue("@4", Email);
                        cmd3.Parameters.AddWithValue("@5", codecarte);
                        cmd3.Parameters.AddWithValue("@6", clientActuel);

                        try
                        {
                            cmd3.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("L'adresse email que vous avez saisi est déjà utiliser ! : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            email.Focus();
                            return;
                        }

                        string ancienDecodeur = VariableModClient.CarteDecodeur;

                        if (ancienDecodeur != NumDecodeur)
                        {
                            string query4 = @"update cartedecodeur set etat = 'Non Actif' where numerounique = @1";

                            using (var cmd4 = new MySqlCommand(query4, dbcon))
                            {
                                cmd4.Parameters.AddWithValue("@1", ancienDecodeur);

                                try
                                {
                                    cmd4.ExecuteNonQuery();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Impossible de changer l'etat du nouveau carte decodeur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                string query5 = @"update cartedecodeur set etat = 'Actif' where numerounique = @1";

                                using (var cmd5 = new MySqlCommand(query5, dbcon))
                                {
                                    cmd5.Parameters.AddWithValue("@1", NumDecodeur);

                                    try
                                    {
                                        cmd5.ExecuteNonQuery();
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Impossible de changer l'etat de l'ancien carte decodeur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                }
                            }

                        }

                        string insertionHistorique = @"insert into historiqueadmin (dateaction, nomadmin, action) values (curdate(), @1, @2)";
                        using (var cmdHistorique = new MySqlCommand(insertionHistorique, dbcon))
                        {
                            cmdHistorique.Parameters.AddWithValue("@1", VariableCreerCompteAdmin.AdminConnecter);
                            cmdHistorique.Parameters.AddWithValue("@2", "Modification des informations du client. | Nom du client : " + clientActuel);
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
                    }

                    dbcon.Close();
                }
            }

            MessageBox.Show("Modification des informations du client réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panelContenu.Controls.Clear();
            listeClient fenetre = new listeClient();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            listeClient fenetre = new listeClient();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

    }
}
