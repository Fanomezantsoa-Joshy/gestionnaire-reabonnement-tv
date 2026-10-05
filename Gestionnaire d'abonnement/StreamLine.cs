using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_d_abonnement
{
    public partial class StreamLine : Form
    {
        public StreamLine()
        {
            InitializeComponent();

            DateTime date = DateTime.Now;
            DateTime date2 = DateTime.MaxValue;

            panelPrincipale.Controls.Clear();
            ConnexionAdmin fenetre = new ConnexionAdmin();
            fenetre.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(fenetre);
        }
    }
}
