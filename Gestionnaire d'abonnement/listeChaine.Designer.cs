namespace Gestionnaire_d_abonnement
{
    partial class listeChaine
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelTeste = new Panel();
            panelContenu = new Panel();
            panel = new TableLayoutPanel();
            tableauChaine = new DataGridView();
            tableLayoutPanel10 = new TableLayoutPanel();
            label5 = new Label();
            rechercheChaine = new Guna.UI2.WinForms.Guna2TextBox();
            panelOption = new TableLayoutPanel();
            btnNouveau = new Guna.UI2.WinForms.Guna2Button();
            btnModifier = new Guna.UI2.WinForms.Guna2Button();
            btnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel15 = new TableLayoutPanel();
            label3 = new Label();
            panelForm = new Panel();
            panelTeste.SuspendLayout();
            panelContenu.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableauChaine).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            panelOption.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            SuspendLayout();
            // 
            // panelTeste
            // 
            panelTeste.Controls.Add(panelContenu);
            panelTeste.Controls.Add(tableLayoutPanel15);
            panelTeste.Controls.Add(panelForm);
            panelTeste.Dock = DockStyle.Fill;
            panelTeste.Location = new Point(0, 0);
            panelTeste.Margin = new Padding(0);
            panelTeste.Name = "panelTeste";
            panelTeste.Size = new Size(800, 600);
            panelTeste.TabIndex = 0;
            // 
            // panelContenu
            // 
            panelContenu.Controls.Add(panel);
            panelContenu.Controls.Add(panelOption);
            panelContenu.Dock = DockStyle.Top;
            panelContenu.Location = new Point(0, 60);
            panelContenu.Name = "panelContenu";
            panelContenu.Size = new Size(800, 411);
            panelContenu.TabIndex = 26;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.Control;
            panel.ColumnCount = 3;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panel.Controls.Add(tableauChaine, 1, 2);
            panel.Controls.Add(tableLayoutPanel10, 1, 1);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(0);
            panel.Name = "panel";
            panel.RowCount = 3;
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 83F));
            panel.Size = new Size(800, 311);
            panel.TabIndex = 20;
            // 
            // tableauChaine
            // 
            tableauChaine.AllowUserToAddRows = false;
            tableauChaine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableauChaine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tableauChaine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableauChaine.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableauChaine.BackgroundColor = Color.FromArgb(224, 231, 255);
            tableauChaine.BorderStyle = BorderStyle.Fixed3D;
            tableauChaine.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            tableauChaine.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 12F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableauChaine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tableauChaine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tableauChaine.DefaultCellStyle = dataGridViewCellStyle3;
            tableauChaine.Dock = DockStyle.Fill;
            tableauChaine.EnableHeadersVisualStyles = false;
            tableauChaine.GridColor = Color.FromArgb(209, 213, 219);
            tableauChaine.Location = new Point(83, 55);
            tableauChaine.MultiSelect = false;
            tableauChaine.Name = "tableauChaine";
            tableauChaine.ReadOnly = true;
            tableauChaine.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tableauChaine.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tableauChaine.RowHeadersVisible = false;
            tableauChaine.RowHeadersWidth = 100;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            tableauChaine.RowsDefaultCellStyle = dataGridViewCellStyle5;
            tableauChaine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableauChaine.Size = new Size(634, 253);
            tableauChaine.TabIndex = 3;
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
            tableLayoutPanel10.Controls.Add(rechercheChaine, 4, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(83, 18);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(634, 31);
            tableLayoutPanel10.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(444, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 31);
            label5.TabIndex = 9;
            label5.Text = "Rechercher :";
            // 
            // rechercheChaine
            // 
            rechercheChaine.BorderColor = Color.FromArgb(209, 213, 219);
            rechercheChaine.BorderRadius = 10;
            rechercheChaine.BorderThickness = 2;
            rechercheChaine.CustomizableEdges = customizableEdges1;
            rechercheChaine.DefaultText = "";
            rechercheChaine.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            rechercheChaine.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            rechercheChaine.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            rechercheChaine.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            rechercheChaine.Dock = DockStyle.Fill;
            rechercheChaine.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            rechercheChaine.Font = new Font("Georgia", 12F);
            rechercheChaine.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            rechercheChaine.Location = new Point(511, 4);
            rechercheChaine.Margin = new Padding(4);
            rechercheChaine.MaximumSize = new Size(0, 30);
            rechercheChaine.MinimumSize = new Size(0, 35);
            rechercheChaine.Name = "rechercheChaine";
            rechercheChaine.PlaceholderText = "";
            rechercheChaine.SelectedText = "";
            rechercheChaine.ShadowDecoration.CustomizableEdges = customizableEdges2;
            rechercheChaine.Size = new Size(119, 35);
            rechercheChaine.TabIndex = 11;
            // 
            // panelOption
            // 
            panelOption.AutoSize = true;
            panelOption.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelOption.ColumnCount = 7;
            panelOption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.217391F));
            panelOption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.043478F));
            panelOption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.217391F));
            panelOption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.043478F));
            panelOption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.217391F));
            panelOption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.043478F));
            panelOption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.217391F));
            panelOption.Controls.Add(btnNouveau, 5, 1);
            panelOption.Controls.Add(btnModifier, 3, 1);
            panelOption.Controls.Add(btnSupprimer, 1, 1);
            panelOption.Dock = DockStyle.Bottom;
            panelOption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelOption.ForeColor = Color.White;
            panelOption.Location = new Point(0, 311);
            panelOption.Margin = new Padding(0);
            panelOption.MinimumSize = new Size(0, 100);
            panelOption.Name = "panelOption";
            panelOption.RowCount = 3;
            panelOption.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panelOption.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            panelOption.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panelOption.Size = new Size(800, 100);
            panelOption.TabIndex = 19;
            // 
            // btnNouveau
            // 
            btnNouveau.BorderColor = Color.White;
            btnNouveau.BorderRadius = 10;
            btnNouveau.BorderThickness = 2;
            btnNouveau.CustomizableEdges = customizableEdges3;
            btnNouveau.DisabledState.BorderColor = Color.DarkGray;
            btnNouveau.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNouveau.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNouveau.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNouveau.Dock = DockStyle.Fill;
            btnNouveau.Font = new Font("Trebuchet MS", 12F);
            btnNouveau.ForeColor = Color.White;
            btnNouveau.Location = new Point(574, 23);
            btnNouveau.Name = "btnNouveau";
            btnNouveau.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNouveau.Size = new Size(98, 54);
            btnNouveau.TabIndex = 5;
            btnNouveau.Text = "Ajouter";
            btnNouveau.Click += btnNouveau_Click;
            // 
            // btnModifier
            // 
            btnModifier.BorderColor = Color.White;
            btnModifier.BorderRadius = 10;
            btnModifier.BorderThickness = 2;
            btnModifier.CustomizableEdges = customizableEdges5;
            btnModifier.DisabledState.BorderColor = Color.DarkGray;
            btnModifier.DisabledState.CustomBorderColor = Color.DarkGray;
            btnModifier.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnModifier.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnModifier.Dock = DockStyle.Fill;
            btnModifier.Font = new Font("Trebuchet MS", 12F);
            btnModifier.ForeColor = Color.White;
            btnModifier.Location = new Point(349, 23);
            btnModifier.Name = "btnModifier";
            btnModifier.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnModifier.Size = new Size(98, 54);
            btnModifier.TabIndex = 6;
            btnModifier.Text = "Modifier";
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BorderColor = Color.White;
            btnSupprimer.BorderRadius = 10;
            btnSupprimer.BorderThickness = 2;
            btnSupprimer.CustomizableEdges = customizableEdges7;
            btnSupprimer.DisabledState.BorderColor = Color.DarkGray;
            btnSupprimer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSupprimer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSupprimer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSupprimer.Dock = DockStyle.Fill;
            btnSupprimer.Font = new Font("Trebuchet MS", 12F);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.Location = new Point(124, 23);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSupprimer.Size = new Size(98, 54);
            btnSupprimer.TabIndex = 5;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Controls.Add(label3, 0, 0);
            tableLayoutPanel15.Dock = DockStyle.Top;
            tableLayoutPanel15.Location = new Point(0, 0);
            tableLayoutPanel15.Margin = new Padding(0);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel15.Size = new Size(800, 60);
            tableLayoutPanel15.TabIndex = 25;
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
            label3.Text = "Liste des chaines";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.Transparent;
            panelForm.Dock = DockStyle.Bottom;
            panelForm.Location = new Point(0, 403);
            panelForm.Margin = new Padding(0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(800, 197);
            panelForm.TabIndex = 27;
            // 
            // listeChaine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTeste);
            Margin = new Padding(0);
            Name = "listeChaine";
            Size = new Size(800, 600);
            panelTeste.ResumeLayout(false);
            panelContenu.ResumeLayout(false);
            panelContenu.PerformLayout();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableauChaine).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            panelOption.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTeste;
        private Panel panelContenu;
        private TableLayoutPanel panel;
        private TableLayoutPanel panelOption;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label3;
        private Panel panelForm;
        private Guna.UI2.WinForms.Guna2Button btnNouveau;
        private Guna.UI2.WinForms.Guna2Button btnModifier;
        private Guna.UI2.WinForms.Guna2Button btnSupprimer;
        private DataGridView tableauChaine;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox rechercheChaine;
    }
}
