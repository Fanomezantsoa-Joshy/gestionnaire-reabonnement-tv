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
    public partial class enEspece : UserControl
    {
        public enEspece()
        {
            InitializeComponent();
        }

        private void changement(object sender, EventArgs e)
        {
            try
            {
                if (VariableNouveauClient.Menu == "abonnement")
                {
                    if (montant.Text == "")
                    {
                        VariableAbonnement.montantEnEspece = -1;
                    }
                    else
                    {
                        VariableAbonnement.montantEnEspece = Convert.ToDecimal(montant.Text);
                    }
                }

                if (VariableNouveauClient.Menu == "client")
                {
                    if (montant.Text == "")
                    {
                        VariableNouveauClient.MontantEnEspece = -1;
                    }
                    else
                    {
                        VariableNouveauClient.MontantEnEspece = Convert.ToDecimal(montant.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("En espece : (affectation du prix en espece)" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

        private void fonction_Demarrage(object sender, EventArgs e)
        {
            try
            {
                if (VariableNouveauClient.Menu == "abonnement")
                {
                    if (VariableAbonnement.montantEnEspece != -1)
                    {
                        montant.Text = VariableAbonnement.montantEnEspece.ToString();
                    }
                }

                if (VariableNouveauClient.Menu == "client")
                {
                    if (VariableNouveauClient.MontantEnEspece != -1)
                    {
                        montant.Text = VariableNouveauClient.MontantEnEspece.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onload en espece (affichage automatique du montant en espece) : : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
