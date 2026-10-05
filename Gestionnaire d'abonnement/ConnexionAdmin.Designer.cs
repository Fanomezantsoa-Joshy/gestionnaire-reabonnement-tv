namespace Gestionnaire_d_abonnement
{
    partial class ConnexionAdmin
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tableLayoutPanel1 = new TableLayoutPanel();
            guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            nomAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            btnSeConnecter = new Guna.UI2.WinForms.Guna2Button();
            label11 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnMdpOublier = new Button();
            btnCreerCompte = new Guna.UI2.WinForms.Guna2Button();
            mdp = new Guna.UI2.WinForms.Guna2TextBox();
            panelPrincipale = new Panel();
            tableLayoutPanel1.SuspendLayout();
            guna2CustomGradientPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelPrincipale.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(guna2CustomGradientPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.BorderColor = Color.FromArgb(209, 213, 219);
            guna2CustomGradientPanel2.BorderRadius = 20;
            guna2CustomGradientPanel2.BorderThickness = 3;
            guna2CustomGradientPanel2.Controls.Add(tableLayoutPanel2);
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges9;
            guna2CustomGradientPanel2.Dock = DockStyle.Fill;
            guna2CustomGradientPanel2.Location = new Point(243, 93);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2CustomGradientPanel2.Size = new Size(314, 414);
            guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(224, 231, 255);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(nomAdmin, 1, 3);
            tableLayoutPanel2.Controls.Add(btnSeConnecter, 1, 8);
            tableLayoutPanel2.Controls.Add(label11, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 5);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 10);
            tableLayoutPanel2.Controls.Add(mdp, 1, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 13;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel2.Size = new Size(314, 414);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // nomAdmin
            // 
            nomAdmin.BorderColor = Color.FromArgb(209, 213, 219);
            nomAdmin.BorderRadius = 10;
            nomAdmin.BorderThickness = 2;
            nomAdmin.CustomizableEdges = customizableEdges1;
            nomAdmin.DefaultText = "";
            nomAdmin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nomAdmin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nomAdmin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nomAdmin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nomAdmin.Dock = DockStyle.Fill;
            nomAdmin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nomAdmin.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nomAdmin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nomAdmin.Location = new Point(35, 114);
            nomAdmin.Margin = new Padding(4);
            nomAdmin.MinimumSize = new Size(0, 32);
            nomAdmin.Name = "nomAdmin";
            nomAdmin.PlaceholderText = "Votre nom d'administrateur";
            nomAdmin.SelectedText = "";
            nomAdmin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            nomAdmin.Size = new Size(243, 33);
            nomAdmin.TabIndex = 17;
            // 
            // btnSeConnecter
            // 
            btnSeConnecter.BorderColor = Color.White;
            btnSeConnecter.BorderRadius = 20;
            btnSeConnecter.BorderThickness = 2;
            btnSeConnecter.CustomizableEdges = customizableEdges3;
            btnSeConnecter.DisabledState.BorderColor = Color.DarkGray;
            btnSeConnecter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSeConnecter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSeConnecter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSeConnecter.Dock = DockStyle.Fill;
            btnSeConnecter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSeConnecter.ForeColor = Color.White;
            btnSeConnecter.Location = new Point(34, 263);
            btnSeConnecter.Name = "btnSeConnecter";
            btnSeConnecter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSeConnecter.Size = new Size(245, 43);
            btnSeConnecter.TabIndex = 1;
            btnSeConnecter.Text = "Se connecter";
            btnSeConnecter.Click += btnSeConnecter_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F);
            label11.ForeColor = Color.LightSlateGray;
            label11.Location = new Point(34, 86);
            label11.Name = "label11";
            label11.Size = new Size(173, 22);
            label11.TabIndex = 8;
            label11.Text = "Nom d'administrateur :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(82, 15);
            label2.Name = "label2";
            label2.Size = new Size(149, 35);
            label2.TabIndex = 11;
            label2.Text = "Connexion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSlateGray;
            label1.Location = new Point(34, 171);
            label1.Name = "label1";
            label1.Size = new Size(113, 22);
            label1.TabIndex = 9;
            label1.Text = "Mot de passe :";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Controls.Add(btnMdpOublier, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCreerCompte, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel3.ForeColor = SystemColors.ControlLightLight;
            tableLayoutPanel3.Location = new Point(31, 337);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(251, 41);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // btnMdpOublier
            // 
            btnMdpOublier.BackColor = Color.Transparent;
            btnMdpOublier.Dock = DockStyle.Fill;
            btnMdpOublier.FlatAppearance.BorderSize = 0;
            btnMdpOublier.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 231, 255);
            btnMdpOublier.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 231, 255);
            btnMdpOublier.FlatStyle = FlatStyle.Flat;
            btnMdpOublier.Font = new Font("Trebuchet MS", 12F);
            btnMdpOublier.ForeColor = SystemColors.Highlight;
            btnMdpOublier.Location = new Point(3, 3);
            btnMdpOublier.Name = "btnMdpOublier";
            btnMdpOublier.Size = new Size(139, 35);
            btnMdpOublier.TabIndex = 4;
            btnMdpOublier.Text = "Mot de passe oubliée ?";
            btnMdpOublier.TextAlign = ContentAlignment.MiddleRight;
            btnMdpOublier.UseVisualStyleBackColor = false;
            btnMdpOublier.Click += btnMdpOublier_Click;
            // 
            // btnCreerCompte
            // 
            btnCreerCompte.BackColor = Color.Transparent;
            btnCreerCompte.BorderColor = Color.White;
            btnCreerCompte.BorderRadius = 8;
            btnCreerCompte.BorderThickness = 2;
            btnCreerCompte.CustomizableEdges = customizableEdges5;
            btnCreerCompte.DisabledState.BorderColor = Color.DarkGray;
            btnCreerCompte.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreerCompte.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreerCompte.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreerCompte.Dock = DockStyle.Fill;
            btnCreerCompte.FillColor = Color.MediumSeaGreen;
            btnCreerCompte.Font = new Font("Trebuchet MS", 12F);
            btnCreerCompte.ForeColor = Color.White;
            btnCreerCompte.Location = new Point(153, 3);
            btnCreerCompte.Name = "btnCreerCompte";
            btnCreerCompte.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCreerCompte.Size = new Size(95, 35);
            btnCreerCompte.TabIndex = 1;
            btnCreerCompte.Text = "Créer un compte";
            btnCreerCompte.Click += btnCreerCompte_Click;
            // 
            // mdp
            // 
            mdp.BorderColor = Color.FromArgb(209, 213, 219);
            mdp.BorderRadius = 10;
            mdp.BorderThickness = 2;
            mdp.CustomizableEdges = customizableEdges7;
            mdp.DefaultText = "";
            mdp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            mdp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            mdp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            mdp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            mdp.Dock = DockStyle.Fill;
            mdp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            mdp.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mdp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            mdp.Location = new Point(35, 199);
            mdp.Margin = new Padding(4);
            mdp.MinimumSize = new Size(0, 32);
            mdp.Name = "mdp";
            mdp.PlaceholderText = "Votre mot de passe";
            mdp.SelectedText = "";
            mdp.ShadowDecoration.CustomizableEdges = customizableEdges8;
            mdp.Size = new Size(243, 33);
            mdp.TabIndex = 19;
            mdp.UseSystemPasswordChar = true;
            // 
            // panelPrincipale
            // 
            panelPrincipale.Controls.Add(tableLayoutPanel1);
            panelPrincipale.Dock = DockStyle.Fill;
            panelPrincipale.Location = new Point(0, 0);
            panelPrincipale.Margin = new Padding(0);
            panelPrincipale.Name = "panelPrincipale";
            panelPrincipale.Size = new Size(800, 600);
            panelPrincipale.TabIndex = 2;
            // 
            // ConnexionAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelPrincipale);
            Margin = new Padding(0);
            Name = "ConnexionAdmin";
            Size = new Size(800, 600);
            tableLayoutPanel1.ResumeLayout(false);
            guna2CustomGradientPanel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panelPrincipale.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelPrincipale;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox nomAdmin;
        private Guna.UI2.WinForms.Guna2Button btnSeConnecter;
        private Label label11;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnMdpOublier;
        private Guna.UI2.WinForms.Guna2Button btnCreerCompte;
        private Guna.UI2.WinForms.Guna2TextBox mdp;
    }
}
