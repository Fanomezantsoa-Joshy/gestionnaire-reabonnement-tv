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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestionnaire_d_abonnement
{
    public partial class modOffre : UserControl
    {
        public modOffre()
        {
            InitializeComponent();
            afficherListeChaine();
            nom.Text = VariableModOffre.Nom;
            tarif.Text = VariableModOffre.Tarif;
            delai.Text = VariableModOffre.Duree;
            description.Text = VariableModOffre.Description;
        }

        void afficherListeChaine()
        {

            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "select CodeChaine as Numéro, Nom from chaine";

                using (var cmd = new MySqlCommand(query, conn))
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

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string Nom = nom.Text;
            string Tarif = tarif.Text;
            string Delai = delai.Text;
            string Description = description.Text;

            if (Nom == "")
            {
                MessageBox.Show("Veuillez saisir le nom de l'offre !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tarif.Focus();
                return;
            }
            if (Tarif == "")
            {
                MessageBox.Show("Veuillez saisir le tarif de l'offre !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tarif.Focus();
                return;
            }
            if (Delai == "")
            {
                MessageBox.Show("Veuillez saisir le délai de validité de l'offre !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                delai.Focus();
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

                string modOffre = @"update Offre set nom = @1, prix = @2, duree = @3, description = @4 where nom = @5";

                int codeOffre;

                using (var cmd10 = new MySqlCommand(modOffre, dbcon))
                {
                    cmd10.Parameters.AddWithValue("@1", Nom);
                    cmd10.Parameters.AddWithValue("@2", decimal.Parse(Tarif));
                    cmd10.Parameters.AddWithValue("@3", int.Parse(Delai));
                    cmd10.Parameters.AddWithValue("@4", Description);
                    cmd10.Parameters.AddWithValue("@5", VariableModOffre.Nom);

                    try
                    {
                        cmd10.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Impossible de modifier les informations de l'offre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        string suppression = "delete from offrechaine where codeoffre = @1";

                        using (var cmd5 = new MySqlCommand(suppression, dbcon))
                        {
                            cmd5.Parameters.AddWithValue("@1", codeOffre);

                            try
                            {
                                cmd5.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Modification des chaines composants impossible : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

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

                    }

                    string insertionHistorique = @"insert into historiqueadmin (dateaction, nomadmin, action) values (curdate(), @1, @2)";
                    using (var cmdHistorique = new MySqlCommand(insertionHistorique, dbcon))
                    {
                        cmdHistorique.Parameters.AddWithValue("@1", VariableCreerCompteAdmin.AdminConnecter);
                        cmdHistorique.Parameters.AddWithValue("@2", "Modification des informations d'une offre. | Numéro de l'offre : " + codeOffre);
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


            MessageBox.Show("Modification des informations de l'offre réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
