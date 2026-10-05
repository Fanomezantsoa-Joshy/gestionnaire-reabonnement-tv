using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VariableGlobale;
using Data;

namespace Gestionnaire_d_abonnement
{
    public partial class Abonnement3 : UserControl
    {
        public Abonnement3()
        {
            InitializeComponent();

            try
            {
                montant.Text = VariableAbonnement.prixOffre.ToString() + " Ariary";
                dateFin.Text = VariableAbonnement.nouveauFinAbonnement.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onload abonnement 3 : (affectation des variable) : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                if (VariableAbonnement.modeDePaiement == "En espece")
                {
                    panelPaiement.Controls.Clear();
                    enEspece fenetre = new enEspece();
                    fenetre.Dock = DockStyle.Fill;
                    panelPaiement.Controls.Add(fenetre);
                }
                if (VariableAbonnement.modeDePaiement == "Mobile money")
                {
                    panelPaiement.Controls.Clear();
                    mobileMonaie fenetre = new mobileMonaie();
                    fenetre.Dock = DockStyle.Fill;
                    panelPaiement.Controls.Add(fenetre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onload abonnement 3 : (affichage du mode de paiement) " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            Abonnement2 fenetre = new Abonnement2();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (VariableAbonnement.modeDePaiement == "En espece")
            {
                if (VariableAbonnement.montantEnEspece < VariableAbonnement.prixOffre)
                {
                    MessageBox.Show("Le montant que vous avez saisi est inférieur au prix !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (VariableAbonnement.montantEnEspece == -1)
                {
                    MessageBox.Show("Veuillez saisir la somme à payer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                panelContenu.Controls.Clear();
                Abonnement4 fen = new Abonnement4();
                fen.Dock = DockStyle.Fill;
                panelContenu.Controls.Add(fen);
            }
            else if (VariableAbonnement.modeDePaiement == "Mobile Money")
            {
                if (VariableAbonnement.mobileMoney != "OK")
                {
                    MessageBox.Show("Veuillez choisir une opérateur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                panelContenu.Controls.Clear();
                Abonnement4 fenetre = new Abonnement4();
                fenetre.Dock = DockStyle.Fill;
                panelContenu.Controls.Add(fenetre);
            }
            else
            {
                MessageBox.Show("Veuillez effetuer le paiement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEnespece_Click(object sender, EventArgs e)
        {
            if (VariableAbonnement.modeDePaiement != "En espece")
            {
                try
                {
                    panelPaiement.Controls.Clear();
                    enEspece fenetre = new enEspece();
                    fenetre.Dock = DockStyle.Fill;
                    panelPaiement.Controls.Add(fenetre);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Abonnement 3 (Affichage du fenetre mode de paiement en espece) : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VariableAbonnement.modeDePaiement = "En espece";

            }
        }

        private void btnMobileMonaie_Click(object sender, EventArgs e)
        {

            if (VariableAbonnement.modeDePaiement != "Mobile Money")
            {
                try
                {
                    panelPaiement.Controls.Clear();
                    mobileMonaie fenetre = new mobileMonaie();
                    fenetre.Dock = DockStyle.Fill;
                    panelPaiement.Controls.Add(fenetre);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Affichage du fenetre mobile money : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VariableAbonnement.modeDePaiement = "Mobile Money";

            }


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            VariableAbonnement.ligneClient = 0;
            VariableAbonnement.ligneOffre = 0;
            VariableAbonnement.quantite = 1;
            VariableAbonnement.mobileMoney = "";
            VariableAbonnement.modeDePaiement = "";
            VariableAbonnement.montantEnEspece = -1;

            panelContenu.Controls.Clear();
            Abonnement1 fenetre = new Abonnement1();
            fenetre.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(fenetre);
        }
    }
}
