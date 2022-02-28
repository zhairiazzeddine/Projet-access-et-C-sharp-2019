namespace Projet_access_103
{
    partial class Fvente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nopération = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bmodifier = new System.Windows.Forms.Button();
            this.Bajout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lnvente = new System.Windows.Forms.Label();
            this.Tdate = new System.Windows.Forms.MaskedTextBox();
            this.Tclient = new System.Windows.Forms.ComboBox();
            this.Tdate1 = new System.Windows.Forms.MaskedTextBox();
            this.Tdate2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(964, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 47);
            this.button3.TabIndex = 82;
            this.button3.Text = "Fermer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 29);
            this.label4.TabIndex = 80;
            this.label4.Text = "Rechercher par dates Du";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(683, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 47);
            this.button2.TabIndex = 79;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nopération,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Location = new System.Drawing.Point(111, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 237);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Nopération
            // 
            this.Nopération.DataPropertyName = "Nvente";
            this.Nopération.HeaderText = "Nvente";
            this.Nopération.Name = "Nopération";
            this.Nopération.ReadOnly = true;
            this.Nopération.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "date_vente";
            dataGridViewCellStyle8.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "code_client";
            this.Column2.HeaderText = "Code Client";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Bmodifier
            // 
            this.Bmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmodifier.Location = new System.Drawing.Point(683, 59);
            this.Bmodifier.Name = "Bmodifier";
            this.Bmodifier.Size = new System.Drawing.Size(134, 47);
            this.Bmodifier.TabIndex = 77;
            this.Bmodifier.Text = "Modifier";
            this.Bmodifier.UseVisualStyleBackColor = true;
            this.Bmodifier.Click += new System.EventHandler(this.Bmodifier_Click);
            // 
            // Bajout
            // 
            this.Bajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bajout.Location = new System.Drawing.Point(683, 6);
            this.Bajout.Name = "Bajout";
            this.Bajout.Size = new System.Drawing.Size(134, 47);
            this.Bajout.TabIndex = 76;
            this.Bajout.Text = "Ajout";
            this.Bajout.UseVisualStyleBackColor = true;
            this.Bajout.Click += new System.EventHandler(this.Bajout_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(546, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 75;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 73;
            this.label3.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 71;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nvente";
            // 
            // Lnvente
            // 
            this.Lnvente.AutoSize = true;
            this.Lnvente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnvente.Location = new System.Drawing.Point(209, 21);
            this.Lnvente.Name = "Lnvente";
            this.Lnvente.Size = new System.Drawing.Size(79, 29);
            this.Lnvente.TabIndex = 83;
            this.Lnvente.Text = "...........";
            // 
            // Tdate
            // 
            this.Tdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tdate.Location = new System.Drawing.Point(214, 62);
            this.Tdate.Mask = "00/00/0000";
            this.Tdate.Name = "Tdate";
            this.Tdate.Size = new System.Drawing.Size(100, 26);
            this.Tdate.TabIndex = 84;
            this.Tdate.ValidatingType = typeof(System.DateTime);
            // 
            // Tclient
            // 
            this.Tclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tclient.FormattingEnabled = true;
            this.Tclient.Location = new System.Drawing.Point(214, 112);
            this.Tclient.Name = "Tclient";
            this.Tclient.Size = new System.Drawing.Size(139, 32);
            this.Tclient.TabIndex = 85;
            this.Tclient.SelectedIndexChanged += new System.EventHandler(this.Tclient_SelectedIndexChanged);
            // 
            // Tdate1
            // 
            this.Tdate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tdate1.Location = new System.Drawing.Point(392, 200);
            this.Tdate1.Mask = "00/00/0000";
            this.Tdate1.Name = "Tdate1";
            this.Tdate1.Size = new System.Drawing.Size(100, 26);
            this.Tdate1.TabIndex = 86;
            this.Tdate1.ValidatingType = typeof(System.DateTime);
            this.Tdate1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tdate1_KeyPress);
            // 
            // Tdate2
            // 
            this.Tdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tdate2.Location = new System.Drawing.Point(558, 200);
            this.Tdate2.Mask = "00/00/0000";
            this.Tdate2.Name = "Tdate2";
            this.Tdate2.Size = new System.Drawing.Size(100, 26);
            this.Tdate2.TabIndex = 87;
            this.Tdate2.ValidatingType = typeof(System.DateTime);
            this.Tdate2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tdate2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 29);
            this.label5.TabIndex = 88;
            this.label5.Text = "Au";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(698, 200);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 29);
            this.checkBox1.TabIndex = 89;
            this.checkBox1.Text = "Tous";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(886, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 69);
            this.button4.TabIndex = 90;
            this.button4.Text = "Ajout des Produits à la vente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Fvente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1306, 515);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tdate2);
            this.Controls.Add(this.Tdate1);
            this.Controls.Add(this.Tclient);
            this.Controls.Add(this.Tdate);
            this.Controls.Add(this.Lnvente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bmodifier);
            this.Controls.Add(this.Bajout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fvente";
            this.Text = "Fvente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fvente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bmodifier;
        private System.Windows.Forms.Button Bajout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lnvente;
        private System.Windows.Forms.MaskedTextBox Tdate;
        private System.Windows.Forms.ComboBox Tclient;
        private System.Windows.Forms.MaskedTextBox Tdate1;
        private System.Windows.Forms.MaskedTextBox Tdate2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nopération;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
    }
}