namespace Projet_access_103
{
    partial class Fproduit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nopération = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bmodifier = new System.Windows.Forms.Button();
            this.Bajout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Tstock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tpu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tdesignation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Rdésignation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rprix1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Rprix2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Lvaleur = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nopération,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(79, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(609, 237);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Nopération
            // 
            this.Nopération.DataPropertyName = "Désignation";
            this.Nopération.HeaderText = "Désignation";
            this.Nopération.Name = "Nopération";
            this.Nopération.ReadOnly = true;
            this.Nopération.Width = 300;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PU";
            dataGridViewCellStyle5.Format = "### ### ###.##";
            dataGridViewCellStyle5.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "PU";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Stock";
            this.Column2.HeaderText = "Stock";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Bmodifier
            // 
            this.Bmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmodifier.Location = new System.Drawing.Point(601, 67);
            this.Bmodifier.Name = "Bmodifier";
            this.Bmodifier.Size = new System.Drawing.Size(134, 47);
            this.Bmodifier.TabIndex = 38;
            this.Bmodifier.Text = "Modifier";
            this.Bmodifier.UseVisualStyleBackColor = true;
            this.Bmodifier.Click += new System.EventHandler(this.Bmodifier_Click);
            // 
            // Bajout
            // 
            this.Bajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bajout.Location = new System.Drawing.Point(601, 14);
            this.Bajout.Name = "Bajout";
            this.Bajout.Size = new System.Drawing.Size(134, 47);
            this.Bajout.TabIndex = 37;
            this.Bajout.Text = "Ajout";
            this.Bajout.UseVisualStyleBackColor = true;
            this.Bajout.Click += new System.EventHandler(this.Bajout_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(466, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 36;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tstock
            // 
            this.Tstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tstock.Location = new System.Drawing.Point(199, 96);
            this.Tstock.Name = "Tstock";
            this.Tstock.Size = new System.Drawing.Size(103, 35);
            this.Tstock.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Stock";
            // 
            // Tpu
            // 
            this.Tpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tpu.Location = new System.Drawing.Point(199, 55);
            this.Tpu.Name = "Tpu";
            this.Tpu.Size = new System.Drawing.Size(103, 35);
            this.Tpu.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "PU";
            // 
            // Tdesignation
            // 
            this.Tdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tdesignation.Location = new System.Drawing.Point(199, 14);
            this.Tdesignation.Name = "Tdesignation";
            this.Tdesignation.Size = new System.Drawing.Size(236, 35);
            this.Tdesignation.TabIndex = 31;
            this.Tdesignation.Leave += new System.EventHandler(this.Tdesignation_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Désignation";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(601, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 47);
            this.button2.TabIndex = 40;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rdésignation
            // 
            this.Rdésignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdésignation.Location = new System.Drawing.Point(340, 202);
            this.Rdésignation.Name = "Rdésignation";
            this.Rdésignation.Size = new System.Drawing.Size(176, 35);
            this.Rdésignation.TabIndex = 42;
            this.Rdésignation.TextChanged += new System.EventHandler(this.Rdésignation_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "Rechercher par désignation";
            // 
            // Rprix1
            // 
            this.Rprix1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rprix1.Location = new System.Drawing.Point(302, 243);
            this.Rprix1.Name = "Rprix1";
            this.Rprix1.Size = new System.Drawing.Size(73, 35);
            this.Rprix1.TabIndex = 44;
            this.Rprix1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rprix1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Rechercher par prix Du";
            // 
            // Rprix2
            // 
            this.Rprix2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rprix2.Location = new System.Drawing.Point(428, 243);
            this.Rprix2.Name = "Rprix2";
            this.Rprix2.Size = new System.Drawing.Size(73, 35);
            this.Rprix2.TabIndex = 46;
            this.Rprix2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rprix2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Au";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(934, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 47);
            this.button3.TabIndex = 47;
            this.button3.Text = "Fermer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lvaleur
            // 
            this.Lvaleur.AutoSize = true;
            this.Lvaleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lvaleur.Location = new System.Drawing.Point(88, 563);
            this.Lvaleur.Name = "Lvaleur";
            this.Lvaleur.Size = new System.Drawing.Size(181, 29);
            this.Lvaleur.TabIndex = 48;
            this.Lvaleur.Text = "Valeur du Stock";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(755, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 47);
            this.button4.TabIndex = 49;
            this.button4.Text = "Aperçu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Fproduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1073, 639);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Lvaleur);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Rprix2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Rprix1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rdésignation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bmodifier);
            this.Controls.Add(this.Bajout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tstock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tdesignation);
            this.Controls.Add(this.label1);
            this.Name = "Fproduit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fproduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bmodifier;
        private System.Windows.Forms.Button Bajout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tstock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tpu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tdesignation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Rdésignation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Rprix1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Rprix2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Lvaleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nopération;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button4;
    }
}