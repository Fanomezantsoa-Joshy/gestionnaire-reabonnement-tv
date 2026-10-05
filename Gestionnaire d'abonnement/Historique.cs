using Data;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_d_abonnement
{
    public partial class Historique : UserControl
    {
        public Historique()
        {
            InitializeComponent();
            afficherHistorique();
        }

        void afficherHistorique()
        {

            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "select NomAdmin as Administrateur, DateAction as Date, Action from historiqueadmin";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauHistorique.AutoGenerateColumns = true;
                        tableauHistorique.DataSource = dt;
                    }
                }
            }

        }

        private void rechercheHistorique_ValueChanged(object sender, EventArgs e)
        {

            using (var conn = new MySqlConnection("Server=localhost;Database=StreamLineDB;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "select NomAdmin as Administrateur, DateAction as Date, Action from historiqueadmin" +
                    " WHERE DateAction = @1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@1", rechercheHistorique.Value.Date);
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tableauHistorique.AutoGenerateColumns = true;
                        tableauHistorique.DataSource = dt;
                    }
                }
            }
        }
    }
}
