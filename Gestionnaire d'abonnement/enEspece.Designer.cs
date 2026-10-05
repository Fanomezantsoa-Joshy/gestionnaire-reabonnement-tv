namespace Gestionnaire_d_abonnement
{
    partial class enEspece
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelPaiement = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label8 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            montant = new Guna.UI2.WinForms.Guna2TextBox();
            label9 = new Label();
            panelPaiement.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // panelPaiement
            // 
            panelPaiement.Controls.Add(tableLayoutPanel3);
            panelPaiement.Dock = DockStyle.Fill;
            panelPaiement.Location = new Point(0, 0);
            panelPaiement.Margin = new Padding(0);
            panelPaiement.Name = "panelPaiement";
            panelPaiement.Size = new Size(600, 210);
            panelPaiement.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.ControlLight;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(600, 210);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(224, 231, 255);
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.Controls.Add(label8, 1, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 1, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(600, 210);
            tableLayoutPanel5.TabIndex = 4;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(63, 64);
            label8.Name = "label8";
            label8.Size = new Size(97, 27);
            label8.TabIndex = 1;
            label8.Text = "Somme :";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.Controls.Add(montant, 0, 0);
            tableLayoutPanel7.Controls.Add(label9, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Font = new Font("Trebuchet MS", 12F);
            tableLayoutPanel7.Location = new Point(60, 104);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(480, 52);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // montant
            // 
            montant.BorderColor = Color.FromArgb(209, 213, 219);
            montant.BorderRadius = 10;
            montant.BorderThickness = 2;
            montant.CustomizableEdges = customizableEdges5;
            montant.DefaultText = "";
            montant.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            montant.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            montant.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            montant.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            montant.Dock = DockStyle.Fill;
            montant.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            montant.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            montant.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            montant.Location = new Point(6, 6);
            montant.Margin = new Padding(6);
            montant.MaximumSize = new Size(0, 40);
            montant.MinimumSize = new Size(0, 40);
            montant.Name = "montant";
            montant.PlaceholderText = "Somme payé en Ariary";
            montant.SelectedText = "";
            montant.ShadowDecoration.CustomizableEdges = customizableEdges6;
            montant.Size = new Size(324, 40);
            montant.TabIndex = 7;
            montant.TextAlign = HorizontalAlignment.Center;
            montant.TextChanged += changement;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(224, 231, 255);
            label9.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Orange;
            label9.Location = new Point(372, 12);
            label9.Name = "label9";
            label9.Size = new Size(71, 27);
            label9.TabIndex = 6;
            label9.Text = "Ariary";
            // 
            // enEspece
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelPaiement);
            Name = "enEspece";
            Size = new Size(600, 210);
            Load += fonction_Demarrage;
            panelPaiement.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPaiement;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label9;
        private Guna.UI2.WinForms.Guna2TextBox montant;
    }
}
