namespace Gestionnaire_d_abonnement
{
    partial class Abonnement1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            tableLayoutPanel15 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnSuivant = new Guna.UI2.WinForms.Guna2Button();
            btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableauClient = new DataGridView();
            tableLayoutPanel10 = new TableLayoutPanel();
            label5 = new Label();
            rechercheClient = new Guna.UI2.WinForms.Guna2TextBox();
            panelContenu = new Panel();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableauClient).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            panelContenu.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Trebuchet MS", 16F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(800, 60);
            label3.TabIndex = 17;
            label3.Text = "Abonnement";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Controls.Add(label3, 0, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(0, 0);
            tableLayoutPanel15.Margin = new Padding(0);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel15.Size = new Size(800, 60);
            tableLayoutPanel15.TabIndex = 16;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel15, 0, 0);
            tableLayoutPanel6.Controls.Add(label1, 0, 2);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 0, 4);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel9, 0, 3);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 6;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel6.Size = new Size(800, 600);
            tableLayoutPanel6.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(0, 78);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(800, 30);
            label1.TabIndex = 20;
            label1.Text = "Choix du client :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 7;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            tableLayoutPanel8.Controls.Add(btnSuivant, 5, 0);
            tableLayoutPanel8.Controls.Add(btnAnnuler, 3, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tableLayoutPanel8.ForeColor = Color.White;
            tableLayoutPanel8.Location = new Point(0, 516);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(800, 54);
            tableLayoutPanel8.TabIndex = 22;
            // 
            // btnSuivant
            // 
            btnSuivant.BorderColor = Color.White;
            btnSuivant.BorderRadius = 10;
            btnSuivant.BorderThickness = 2;
            btnSuivant.CustomizableEdges = customizableEdges1;
            btnSuivant.DisabledState.BorderColor = Color.DarkGray;
            btnSuivant.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSuivant.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSuivant.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSuivant.Dock = DockStyle.Fill;
            btnSuivant.FillColor = Color.MediumSeaGreen;
            btnSuivant.Font = new Font("Trebuchet MS", 12F);
            btnSuivant.ForeColor = Color.White;
            btnSuivant.Location = new Point(659, 3);
            btnSuivant.Name = "btnSuivant";
            btnSuivant.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSuivant.Size = new Size(114, 48);
            btnSuivant.TabIndex = 4;
            btnSuivant.Text = "Suivant";
            btnSuivant.Click += btnSuivant_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BorderColor = Color.White;
            btnAnnuler.BorderRadius = 10;
            btnAnnuler.BorderThickness = 2;
            btnAnnuler.CustomizableEdges = customizableEdges3;
            btnAnnuler.DisabledState.BorderColor = Color.DarkGray;
            btnAnnuler.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAnnuler.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAnnuler.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAnnuler.Dock = DockStyle.Fill;
            btnAnnuler.FillColor = Color.DimGray;
            btnAnnuler.Font = new Font("Trebuchet MS", 12F);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(499, 3);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAnnuler.Size = new Size(114, 48);
            btnAnnuler.TabIndex = 5;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.Controls.Add(tableauClient, 1, 2);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 1, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 108);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 78F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel9.Size = new Size(800, 408);
            tableLayoutPanel9.TabIndex = 21;
            tableLayoutPanel9.Paint += tableLayoutPanel9_Paint;
            // 
            // tableauClient
            // 
            tableauClient.AllowUserToAddRows = false;
            tableauClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableauClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tableauClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableauClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableauClient.BackgroundColor = Color.FromArgb(224, 231, 255);
            tableauClient.BorderStyle = BorderStyle.Fixed3D;
            tableauClient.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            tableauClient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 12F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableauClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tableauClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tableauClient.DefaultCellStyle = dataGridViewCellStyle3;
            tableauClient.Dock = DockStyle.Fill;
            tableauClient.EnableHeadersVisualStyles = false;
            tableauClient.GridColor = Color.FromArgb(209, 213, 219);
            tableauClient.Location = new Point(83, 71);
            tableauClient.MultiSelect = false;
            tableauClient.Name = "tableauClient";
            tableauClient.ReadOnly = true;
            tableauClient.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tableauClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tableauClient.RowHeadersVisible = false;
            tableauClient.RowHeadersWidth = 100;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            tableauClient.RowsDefaultCellStyle = dataGridViewCellStyle5;
            tableauClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableauClient.Size = new Size(634, 312);
            tableauClient.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 5;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.58632F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.87946F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.04058F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.8514967F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6421375F));
            tableLayoutPanel10.Controls.Add(label5, 3, 0);
            tableLayoutPanel10.Controls.Add(rechercheClient, 4, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(83, 31);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(634, 34);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(444, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 34);
            label5.TabIndex = 9;
            label5.Text = "Rechercher :";
            // 
            // rechercheClient
            // 
            rechercheClient.BorderColor = Color.FromArgb(209, 213, 219);
            rechercheClient.BorderRadius = 10;
            rechercheClient.BorderThickness = 2;
            rechercheClient.CustomizableEdges = customizableEdges5;
            rechercheClient.DefaultText = "";
            rechercheClient.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            rechercheClient.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            rechercheClient.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            rechercheClient.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            rechercheClient.Dock = DockStyle.Fill;
            rechercheClient.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            rechercheClient.Font = new Font("Georgia", 12F);
            rechercheClient.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            rechercheClient.Location = new Point(511, 4);
            rechercheClient.Margin = new Padding(4);
            rechercheClient.MaximumSize = new Size(0, 30);
            rechercheClient.MinimumSize = new Size(0, 35);
            rechercheClient.Name = "rechercheClient";
            rechercheClient.PlaceholderText = "";
            rechercheClient.SelectedText = "";
            rechercheClient.ShadowDecoration.CustomizableEdges = customizableEdges6;
            rechercheClient.Size = new Size(119, 35);
            rechercheClient.TabIndex = 11;
            // 
            // panelContenu
            // 
            panelContenu.Controls.Add(tableLayoutPanel6);
            panelContenu.Dock = DockStyle.Fill;
            panelContenu.Location = new Point(0, 0);
            panelContenu.Name = "panelContenu";
            panelContenu.Size = new Size(800, 600);
            panelContenu.TabIndex = 1;
            // 
            // Abonnement1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenu);
            Margin = new Padding(0);
            Name = "Abonnement1";
            Size = new Size(800, 600);
            Load += selectionLigne_Click;
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableauClient).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            panelContenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private TableLayoutPanel tableLayoutPanel15;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panelContenu;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel8;
        private Guna.UI2.WinForms.Guna2Button btnSuivant;
        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
        private DataGridView tableauClient;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox rechercheClient;
    }
}
