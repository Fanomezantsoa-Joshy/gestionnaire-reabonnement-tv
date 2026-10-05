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
    public partial class nouveauClient2 : UserControl
    {
        public nouveauClient2()
        {
            InitializeComponent();

            montant.Text = VariableNouveauClient.Montant.ToString() + " Ariary";


            try
            {
                if (VariableNouveauClient.ModeDePaiement == "En espece")
                {
                    panelPaiement.Controls.Clear();
                    enEspece fenetre = new enEspece();
                    fenetre.Dock = DockStyle.Fill;
                    panelPaiement.Controls.Add(fenetre);
                }
                if (VariableNouveauClient.ModeDePaiement == "Mobile money")
                {
                    panelPaiement.Controls.Clear();
                    mobileMonaie fenetre = new mobileMonaie();
                    fenetre.Dock = DockStyle.Fill;
                    panelPaiement.Controls.Add(fenetre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onload abonnement 2 (Choix de mode de paiement) : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {

            if (VariableNouveauClient.ModeDePaiement == "En espece")
            {
                if (VariableNouveauClient.MontantEnEspece < VariableNouveauClient.Montant)
                {
                    MessageBox.Show("Le montant que vous avez saisi est inférieur au prix !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (VariableNouveauClient.MontantEnEspece == -1)
                {
                    MessageBox.Show("Veuillez saisir la somme à payer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                panelContenu.Controls.Clear();
                nouveauClient3 fen = new nouveauClient3();
                fen.Dock = DockStyle.Fill;
                panelContenu.Controls.Add(fen);
            }

            else if (VariableNouveauClient.ModeDePaiement == "Mobile Money")
            {
                if (VariableNouveauClient.mobileMoney != "OK")
                {
                    MessageBox.Show("Veuillez choisir une opérateur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                panelContenu.Controls.Clear();
                nouveauClient3 fen = new nouveauClient3();
                fen.Dock = DockStyle.Fill;
                panelContenu.Controls.Add(fen);
            }
            else
            {
                MessageBox.Show("Veuillez effetuer le paiement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            nouveauClient fenetre = new nouveauClient();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
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

        private void btnEnespece_Click(object sender, EventArgs e)
        {
            if (VariableNouveauClient.ModeDePaiement != "En espece")
            {
                try
                {
                    panelPaiement.Controls.Clear();
                    enEspece fenetre = new enEspece();
                    fenetre.Dock = DockStyle.Fill;
                    panelPaiement.Controls.Add(fenetre);
                    VariableNouveauClient.ModeDePaiement = "En espece";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Affichage en espece " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnMobileMonaie_Click(object sender, EventArgs e)
        {
            if (VariableNouveauClient.ModeDePaiement != "Mobile Money")
            {
                try
                {
                    panelPaiement.Controls.Clear();
                    mobileMonaie fenetre = new mobileMonaie();
                    fenetre.Dock = DockStyle.Fill;
                    panelPaiement.Controls.Add(fenetre);
                    VariableNouveauClient.ModeDePaiement = "Mobile Money";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Affichage Mobile money :" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
    }
}
