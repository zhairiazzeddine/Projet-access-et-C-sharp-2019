namespace Projet_access_103
{
    partial class Fsituation_Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nopération = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAnnée = new System.Windows.Forms.Label();
            this.Tannée = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Ltotal_entré = new System.Windows.Forms.Label();
            this.Ltotal_sortie = new System.Windows.Forms.Label();
            this.Ltotal_Valeur = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Nopération,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(26, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(904, 398);
            this.dataGridView1.TabIndex = 79;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "libellé_mois";
            this.Column5.HeaderText = "Mois";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Nopération
            // 
            this.Nopération.DataPropertyName = "produit";
            this.Nopération.HeaderText = "Produit";
            this.Nopération.Name = "Nopération";
            this.Nopération.ReadOnly = true;
            this.Nopération.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sorties";
            this.Column2.HeaderText = "Qté Sortie";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "entrés";
            this.Column3.HeaderText = "Qté Entrée";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "écart";
            this.Column4.HeaderText = "Ecart";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "valeur";
            this.Column1.HeaderText = "Valeur";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // LAnnée
            // 
            this.LAnnée.AutoSize = true;
            this.LAnnée.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAnnée.Location = new System.Drawing.Point(109, 31);
            this.LAnnée.Name = "LAnnée";
            this.LAnnée.Size = new System.Drawing.Size(67, 24);
            this.LAnnée.TabIndex = 81;
            this.LAnnée.Text = "Année";
            this.LAnnée.Click += new System.EventHandler(this.LAnnée_Click);
            // 
            // Tannée
            // 
            this.Tannée.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tannée.Location = new System.Drawing.Point(198, 24);
            this.Tannée.Mask = "0000";
            this.Tannée.Name = "Tannée";
            this.Tannée.Size = new System.Drawing.Size(83, 35);
            this.Tannée.TabIndex = 0;
            this.Tannée.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Tannée_MaskInputRejected);
            this.Tannée.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tannée_KeyPress);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(606, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 58);
            this.button4.TabIndex = 109;
            this.button4.Text = "Imprimer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Ltotal_entré
            // 
            this.Ltotal_entré.AutoSize = true;
            this.Ltotal_entré.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltotal_entré.Location = new System.Drawing.Point(59, 504);
            this.Ltotal_entré.Name = "Ltotal_entré";
            this.Ltotal_entré.Size = new System.Drawing.Size(110, 24);
            this.Ltotal_entré.TabIndex = 110;
            this.Ltotal_entré.Text = "Total Entrés";
            // 
            // Ltotal_sortie
            // 
            this.Ltotal_sortie.AutoSize = true;
            this.Ltotal_sortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltotal_sortie.Location = new System.Drawing.Point(353, 504);
            this.Ltotal_sortie.Name = "Ltotal_sortie";
            this.Ltotal_sortie.Size = new System.Drawing.Size(113, 24);
            this.Ltotal_sortie.TabIndex = 111;
            this.Ltotal_sortie.Text = "Total Sorties";
            this.Ltotal_sortie.Click += new System.EventHandler(this.Ltotal_sortie_Click);
            // 
            // Ltotal_Valeur
            // 
            this.Ltotal_Valeur.AutoSize = true;
            this.Ltotal_Valeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltotal_Valeur.Location = new System.Drawing.Point(602, 504);
            this.Ltotal_Valeur.Name = "Ltotal_Valeur";
            this.Ltotal_Valeur.Size = new System.Drawing.Size(111, 24);
            this.Ltotal_Valeur.TabIndex = 112;
            this.Ltotal_Valeur.Text = "Total Valeur";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(829, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 47);
            this.button5.TabIndex = 113;
            this.button5.Text = "Fermer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Fsituation_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1006, 584);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Ltotal_Valeur);
            this.Controls.Add(this.Ltotal_sortie);
            this.Controls.Add(this.Ltotal_entré);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Tannée);
            this.Controls.Add(this.LAnnée);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fsituation_Stock";
            this.Text = "Feditions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fsituation_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LAnnée;
        private System.Windows.Forms.MaskedTextBox Tannée;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Ltotal_entré;
        private System.Windows.Forms.Label Ltotal_sortie;
        private System.Windows.Forms.Label Ltotal_Valeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nopération;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button5;
    }
}