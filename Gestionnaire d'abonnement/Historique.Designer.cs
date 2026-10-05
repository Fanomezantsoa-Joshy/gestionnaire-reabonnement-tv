namespace Gestionnaire_d_abonnement
{
    partial class Historique
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label5 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            rechercheHistorique = new Guna.UI2.WinForms.Guna2DateTimePicker();
            tableLayoutPanel15 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableauHistorique = new DataGridView();
            panelContenu = new Panel();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableauHistorique).BeginInit();
            panelContenu.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Trebuchet MS", 12F);
            label5.Location = new Point(415, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 40);
            label5.TabIndex = 9;
            label5.Text = "Rechercher :";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));
            tableLayoutPanel10.Controls.Add(label5, 1, 0);
            tableLayoutPanel10.Controls.Add(rechercheHistorique, 2, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(83, 49);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(634, 40);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // rechercheHistorique
            // 
            rechercheHistorique.BorderColor = Color.FromArgb(209, 213, 219);
            rechercheHistorique.BorderRadius = 5;
            rechercheHistorique.BorderThickness = 1;
            rechercheHistorique.Checked = true;
            rechercheHistorique.CustomizableEdges = customizableEdges1;
            rechercheHistorique.Dock = DockStyle.Fill;
            rechercheHistorique.FillColor = Color.White;
            rechercheHistorique.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rechercheHistorique.Format = DateTimePickerFormat.Short;
            rechercheHistorique.Location = new Point(503, 3);
            rechercheHistorique.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            rechercheHistorique.MaximumSize = new Size(0, 35);
            rechercheHistorique.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            rechercheHistorique.MinimumSize = new Size(0, 35);
            rechercheHistorique.Name = "rechercheHistorique";
            rechercheHistorique.ShadowDecoration.CustomizableEdges = customizableEdges2;
            rechercheHistorique.Size = new Size(128, 35);
            rechercheHistorique.TabIndex = 10;
            rechercheHistorique.Value = new DateTime(2026, 10, 3, 21, 18, 12, 869);
            rechercheHistorique.ValueChanged += rechercheHistorique_ValueChanged;
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
            label3.TabIndex = 18;
            label3.Text = "Historiques";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel15, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel9, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 78F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel6.Size = new Size(800, 600);
            tableLayoutPanel6.TabIndex = 22;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 1, 1);
            tableLayoutPanel9.Controls.Add(tableauHistorique, 1, 2);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 60);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel9.Size = new Size(800, 468);
            tableLayoutPanel9.TabIndex = 17;
            // 
            // tableauHistorique
            // 
            tableauHistorique.AllowUserToAddRows = false;
            tableauHistorique.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableauHistorique.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tableauHistorique.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableauHistorique.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableauHistorique.BackgroundColor = Color.FromArgb(224, 231, 255);
            tableauHistorique.BorderStyle = BorderStyle.Fixed3D;
            tableauHistorique.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            tableauHistorique.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 12F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableauHistorique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tableauHistorique.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tableauHistorique.DefaultCellStyle = dataGridViewCellStyle3;
            tableauHistorique.Dock = DockStyle.Fill;
            tableauHistorique.EnableHeadersVisualStyles = false;
            tableauHistorique.GridColor = Color.FromArgb(209, 213, 219);
            tableauHistorique.Location = new Point(83, 95);
            tableauHistorique.MultiSelect = false;
            tableauHistorique.Name = "tableauHistorique";
            tableauHistorique.ReadOnly = true;
            tableauHistorique.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tableauHistorique.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tableauHistorique.RowHeadersVisible = false;
            tableauHistorique.RowHeadersWidth = 100;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            tableauHistorique.RowsDefaultCellStyle = dataGridViewCellStyle5;
            tableauHistorique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableauHistorique.Size = new Size(634, 345);
            tableauHistorique.TabIndex = 3;
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
            // Historique
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenu);
            Margin = new Padding(0);
            Name = "Historique";
            Size = new Size(800, 600);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableauHistorique).EndInit();
            panelContenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel15;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panelContenu;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker rechercheHistorique;
        private DataGridView tableauHistorique;
    }
}
