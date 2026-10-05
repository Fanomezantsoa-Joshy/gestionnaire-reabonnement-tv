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
    public partial class mobileMonaie : UserControl
    {
        public mobileMonaie()
        {
            InitializeComponent();
        }

        private void btnYas_Click(object sender, EventArgs e)
        {
            try
            {
                VariableAbonnement.mobileMoney = "OK";
                VariableNouveauClient.mobileMoney = "OK";
                panelQrCode.Controls.Clear();
                Mvola fenetre = new Mvola();
                fenetre.Dock = DockStyle.Fill;
                panelQrCode.Controls.Add(fenetre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Affichage Yas : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            try
            {
                VariableAbonnement.mobileMoney = "OK";
                VariableNouveauClient.mobileMoney = "OK";
                panelQrCode.Controls.Clear();
                Orange fenetre = new Orange();
                fenetre.Dock = DockStyle.Fill;
                panelQrCode.Controls.Add(fenetre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Affichage Orange: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnAirtel_Click(object sender, EventArgs e)
        {
            try
            {

                VariableAbonnement.mobileMoney = "OK";
                VariableNouveauClient.mobileMoney = "OK";
                panelQrCode.Controls.Clear();
                Airtel fenetre = new Airtel();
                fenetre.Dock = DockStyle.Fill;
                panelQrCode.Controls.Add(fenetre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Affichage Airtel : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
