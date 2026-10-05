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
    public partial class nouveauOffre : UserControl
    {
        public nouveauOffre()
        {
            InitializeComponent();
            afficherListeChaine();
        }

        void afficherListeChaine()
        {
            var dbCon = DBConnection.Instance();

            using (var dbcon = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                dbcon.Open();
                string query = "select CodeChaine as Numéro, Nom from chaine";
                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listeChaine.Items.Add(
                                new KeyValuePair<int, string>(
                                    reader.GetInt32(0),
                                    reader.GetString(1)
                                )
                            );
                        }
                    }
                }
            }
            listeChaine.DisplayMember = "Value";
            listeChaine.ValueMember = "Key";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string Nom = nom.Text;
            string Tarif = tarif.Text;
            string Delai = delai.Value.ToString();
            string Description = description.Text;

            if (Nom == "")
            {
                MessageBox.Show("Veuillez saisir le nom de l'offre !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nom.Focus();
                return;
            }
            if (Tarif == "")
            {
                MessageBox.Show("Veuillez saisir le tarif de l'offre !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tarif.Focus();
                return;
            }
            if (Description == "")
            {
                MessageBox.Show("Veuillez saisir la déscription de l'offre !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                description.Focus();
                return;
            }

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();

                string insertionOffre = @"INSERT INTO Offre (Nom, Prix, Duree, Description) VALUES (@Nom, @Prix, @Duree, @Description)";

                int codeOffre;

                using (var cmd1 = new MySqlCommand(insertionOffre, dbcon))
                {
                    cmd1.Parameters.AddWithValue("@Nom", Nom);
                    cmd1.Parameters.AddWithValue("@Prix", decimal.Parse(Tarif));
                    cmd1.Parameters.AddWithValue("@Duree", int.Parse(Delai));
                    cmd1.Parameters.AddWithValue("@Description", Description);

                    try
                    {
                        cmd1.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Insertion de l'offre impossible : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string recuperationCodeOffre = @"select codeoffre from offre where nom = @nom";

                    using (var cmd2 = new MySqlCommand(recuperationCodeOffre, dbcon))
                    {
                        cmd2.Parameters.AddWithValue("@Nom", Nom);

                        try
                        {
                            codeOffre = Convert.ToInt32(cmd2.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Impossible de recuperer le code de l'offre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        foreach (KeyValuePair<int, string> item in listeChaine.CheckedItems)
                        {
                            string insertionRelation = "INSERT INTO OffreChaine (CodeOffre, CodeChaine) VALUES (@CodeOffre, @CodeChaine)";
                            using (var cmd3 = new MySqlCommand(insertionRelation, dbcon))
                            {
                                cmd3.Parameters.AddWithValue("@CodeOffre", codeOffre);
                                cmd3.Parameters.AddWithValue("@CodeChaine", item.Key);
                                try
                                {
                                    cmd3.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Impossible de lier l'offre et les chaines : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        string insertionHistorique = @"insert into historiqueadmin (dateaction, nomadmin, action) values (curdate(), @1, @2)";
                        using (var cmdHistorique = new MySqlCommand(insertionHistorique, dbcon))
                        {
                            cmdHistorique.Parameters.AddWithValue("@1", VariableCreerCompteAdmin.AdminConnecter);
                            cmdHistorique.Parameters.AddWithValue("@2", "Création d'un nouveau offre : | Nom : " + nom);
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
                }

                dbcon.Close();
            }

            MessageBox.Show("Création d'une offre réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panelContenu.Controls.Clear();
            listeOffre fenetre = new listeOffre();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            listeOffre fenetre = new listeOffre();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }
    }
}
