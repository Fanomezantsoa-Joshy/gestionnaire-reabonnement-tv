namespace Gestionnaire_d_abonnement
{
    partial class Orange
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
            panelQrCode = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label1 = new Label();
            panelQrCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelQrCode
            // 
            panelQrCode.BackColor = Color.FromArgb(224, 231, 255);
            panelQrCode.ColumnCount = 3;
            panelQrCode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panelQrCode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panelQrCode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panelQrCode.Controls.Add(pictureBox1, 1, 1);
            panelQrCode.Controls.Add(label11, 1, 0);
            panelQrCode.Controls.Add(tableLayoutPanel1, 0, 1);
            panelQrCode.Controls.Add(tableLayoutPanel2, 2, 1);
            panelQrCode.Dock = DockStyle.Fill;
            panelQrCode.Location = new Point(0, 0);
            panelQrCode.Margin = new Padding(0);
            panelQrCode.Name = "panelQrCode";
            panelQrCode.RowCount = 2;
            panelQrCode.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panelQrCode.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            panelQrCode.Size = new Size(600, 200);
            panelQrCode.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Orange;
            pictureBox1.Location = new Point(225, 45);
            pictureBox1.MaximumSize = new Size(150, 150);
            pictureBox1.MinimumSize = new Size(150, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Trebuchet MS", 14F);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(235, 8);
            label11.Name = "label11";
            label11.Size = new Size(129, 24);
            label11.TabIndex = 8;
            label11.Text = "Orange Money";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 40);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(180, 160);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 14F);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(128, 24);
            label2.TabIndex = 9;
            label2.Text = "032 12 345 67";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 14F);
            label5.Location = new Point(46, 14);
            label5.Name = "label5";
            label5.Size = new Size(88, 24);
            label5.TabIndex = 1;
            label5.Text = "Numéro :";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(420, 40);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(180, 160);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 14F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(37, 67);
            label3.Name = "label3";
            label3.Size = new Size(106, 24);
            label3.TabIndex = 10;
            label3.Text = "StreamLine";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14F);
            label1.Location = new Point(59, 14);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 1;
            label1.Text = "Nom :";
            // 
            // Orange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelQrCode);
            Margin = new Padding(0);
            Name = "Orange";
            Size = new Size(600, 200);
            panelQrCode.ResumeLayout(false);
            panelQrCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panelQrCode;
        private PictureBox pictureBox1;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label1;
    }
}
