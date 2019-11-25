namespace WFA191125
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKonyvek = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMegjelens = new System.Windows.Forms.TextBox();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.tbSzerzo = new System.Windows.Forms.TextBox();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.btnHozzaadas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCim = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSzerzo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKolcs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKolcsonzes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonyvek)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKonyvek
            // 
            this.dgvKonyvek.AllowUserToAddRows = false;
            this.dgvKonyvek.AllowUserToDeleteRows = false;
            this.dgvKonyvek.AllowUserToResizeColumns = false;
            this.dgvKonyvek.AllowUserToResizeRows = false;
            this.dgvKonyvek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKonyvek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKonyvek.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKonyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonyvek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKonyvek.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKonyvek.Location = new System.Drawing.Point(12, 12);
            this.dgvKonyvek.Name = "dgvKonyvek";
            this.dgvKonyvek.RowHeadersVisible = false;
            this.dgvKonyvek.RowHeadersWidth = 51;
            this.dgvKonyvek.RowTemplate.Height = 24;
            this.dgvKonyvek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonyvek.Size = new System.Drawing.Size(1182, 328);
            this.dgvKonyvek.TabIndex = 0;
            this.dgvKonyvek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonyvek_CellClick);
            this.dgvKonyvek.SelectionChanged += new System.EventHandler(this.dgvKonyvek_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "ISBN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Szerző";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 120F;
            this.Column3.HeaderText = "Cím";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "Megjelenés";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMegjelens);
            this.groupBox1.Controls.Add(this.tbCim);
            this.groupBox1.Controls.Add(this.tbSzerzo);
            this.groupBox1.Controls.Add(this.tbIsbn);
            this.groupBox1.Controls.Add(this.btnHozzaadas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új konyv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "megjelenés:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "cím:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "szerző:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISBN:";
            // 
            // tbMegjelens
            // 
            this.tbMegjelens.Location = new System.Drawing.Point(241, 192);
            this.tbMegjelens.Name = "tbMegjelens";
            this.tbMegjelens.Size = new System.Drawing.Size(269, 30);
            this.tbMegjelens.TabIndex = 3;
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(241, 142);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(269, 30);
            this.tbCim.TabIndex = 3;
            // 
            // tbSzerzo
            // 
            this.tbSzerzo.Location = new System.Drawing.Point(241, 92);
            this.tbSzerzo.Name = "tbSzerzo";
            this.tbSzerzo.Size = new System.Drawing.Size(269, 30);
            this.tbSzerzo.TabIndex = 3;
            // 
            // tbIsbn
            // 
            this.tbIsbn.Location = new System.Drawing.Point(241, 42);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(269, 30);
            this.tbIsbn.TabIndex = 3;
            // 
            // btnHozzaadas
            // 
            this.btnHozzaadas.Location = new System.Drawing.Point(6, 265);
            this.btnHozzaadas.Name = "btnHozzaadas";
            this.btnHozzaadas.Size = new System.Drawing.Size(538, 55);
            this.btnHozzaadas.TabIndex = 2;
            this.btnHozzaadas.Text = "Hozzáadás";
            this.btnHozzaadas.UseVisualStyleBackColor = true;
            this.btnHozzaadas.Click += new System.EventHandler(this.btnHozzaadas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblSzerzo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblKolcs);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblIsbn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(644, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiválasztott könyv adatai:";
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.Location = new System.Drawing.Point(298, 145);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(45, 25);
            this.lblCim.TabIndex = 0;
            this.lblCim.Text = "###";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "cím:";
            // 
            // lblSzerzo
            // 
            this.lblSzerzo.AutoSize = true;
            this.lblSzerzo.Location = new System.Drawing.Point(298, 95);
            this.lblSzerzo.Name = "lblSzerzo";
            this.lblSzerzo.Size = new System.Drawing.Size(45, 25);
            this.lblSzerzo.TabIndex = 0;
            this.lblSzerzo.Text = "###";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "szerző:";
            // 
            // lblKolcs
            // 
            this.lblKolcs.AutoSize = true;
            this.lblKolcs.Location = new System.Drawing.Point(298, 195);
            this.lblKolcs.Name = "lblKolcs";
            this.lblKolcs.Size = new System.Drawing.Size(45, 25);
            this.lblKolcs.TabIndex = 0;
            this.lblKolcs.Text = "###";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ki van köcsönözve?";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(298, 45);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(45, 25);
            this.lblIsbn.TabIndex = 0;
            this.lblIsbn.Text = "###";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // btnKolcsonzes
            // 
            this.btnKolcsonzes.Enabled = false;
            this.btnKolcsonzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolcsonzes.Location = new System.Drawing.Point(644, 633);
            this.btnKolcsonzes.Name = "btnKolcsonzes";
            this.btnKolcsonzes.Size = new System.Drawing.Size(550, 55);
            this.btnKolcsonzes.TabIndex = 2;
            this.btnKolcsonzes.Text = "Kiválasztott könyv kikölcsönzése";
            this.btnKolcsonzes.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKolcsonzes);
            this.Controls.Add(this.dgvKonyvek);
            this.Name = "FrmMain";
            this.Text = "Kionyvtarprogram minimal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonyvek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKonyvek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.Button btnHozzaadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSzerzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKolcs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Button btnKolcsonzes;
        private System.Windows.Forms.TextBox tbMegjelens;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.TextBox tbSzerzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

