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
    public partial class creerCompteAdmin1 : UserControl
    {
        public creerCompteAdmin1()
        {
            InitializeComponent();

            naissance.MaxDate = VariableCreerCompteAdmin.DateMaximal;

            nomAdmin.Text = VariableCreerCompteAdmin.NomAdmin;
            nom.Text = VariableCreerCompteAdmin.Nom;
            prenoms.Text = VariableCreerCompteAdmin.Prenoms;
            naissance.Value = VariableCreerCompteAdmin.Naissance;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            String NomAdmin = nomAdmin.Text;
            String Nom = nom.Text;
            String Prenoms = prenoms.Text;
            DateTime Naissance = naissance.Value;

            if (NomAdmin == "")
            {
                MessageBox.Show("Veuillez saisir le nom d'administrateur que vous allez utiliser !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nomAdmin.Focus();
                return;
            }
            if (Nom == "")
            {
                MessageBox.Show("Veuillez saisir votre nom !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nom.Focus();
                return;
            }
            if (Prenoms == "")
            {
                MessageBox.Show("Veuillez saisir votre prénoms !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prenoms.Focus();
                return;
            }

            VariableCreerCompteAdmin.NomAdmin = NomAdmin;
            VariableCreerCompteAdmin.Nom = Nom;
            VariableCreerCompteAdmin.Prenoms = Prenoms;
            VariableCreerCompteAdmin.Naissance = Naissance;

            panelPrincipale.Controls.Clear();
            creerCompteAdmin2 fenetre = new creerCompteAdmin2();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            VariableCreerCompteAdmin.NomAdmin = "";
            VariableCreerCompteAdmin.Nom = "";
            VariableCreerCompteAdmin.Prenoms = "";
            VariableCreerCompteAdmin.Naissance = VariableCreerCompteAdmin.DateMaximal;
            VariableCreerCompteAdmin.NouveauMdp = "";
            VariableCreerCompteAdmin.ConfirmerMdp = "";

            panelPrincipale.Controls.Clear();
            ConnexionAdmin fenetre = new ConnexionAdmin();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }
    }
}
