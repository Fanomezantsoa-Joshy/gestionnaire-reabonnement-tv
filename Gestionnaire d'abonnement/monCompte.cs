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
    public partial class monCompte : UserControl
    {
        public event EventHandler AfficherLogin;

        public monCompte()
        {
            InitializeComponent();
            afficherInformation();
        }

        void afficherInformation()
        {
            string NomAdmin = VariableCreerCompteAdmin.AdminConnecter;

            using (var dbcon = new MySqlConnection("Server=localhost;Database=streamlinedb;Uid=root;Pwd=;"))
            {
                dbcon.Open();
                string query = @"select * from administrateur where nomadmin = @1";

                using (var cmd = new MySqlCommand(query, dbcon))
                {
                    cmd.Parameters.AddWithValue("@1", NomAdmin);
                    DataTable tableau = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tableau);

                    VariableCreerCompteAdmin.Nom = tableau.Rows[0]["nom"].ToString();
                    VariableCreerCompteAdmin.Prenoms = tableau.Rows[0]["prenoms"].ToString();
                    VariableCreerCompteAdmin.Naissance = Convert.ToDateTime(tableau.Rows[0]["naissance"]);
                }

                dbcon.Close();
            }
            nomAdmin.Text = NomAdmin;
            nom.Text = VariableCreerCompteAdmin.Nom;
            prenoms.Text = VariableCreerCompteAdmin.Prenoms;
            naissance.Text = VariableCreerCompteAdmin.Naissance.ToShortDateString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            modMonCompte fenetre = new modMonCompte();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnChangerMdp_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            changerMdp fenetre = new changerMdp();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment supprimer votre compte ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "delete from administrateur where nomadmin = @1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@1", VariableCreerCompteAdmin.AdminConnecter);
                    cmd.ExecuteNonQuery();
                }
            }

            AfficherLogin?.Invoke(this, EventArgs.Empty);


            MessageBox.Show("Votre compte a été supprimer !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
