namespace _2024_12_10_S
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            rtbadat = new RichTextBox();
            dgadat = new DataGridView();
            nev = new DataGridViewTextBoxColumn();
            osztaly = new DataGridViewTextBoxColumn();
            hanyadika = new DataGridViewTextBoxColumn();
            igazol = new DataGridViewTextBoxColumn();
            nemigaz = new DataGridViewTextBoxColumn();
            osszhiany = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbosszhiany = new Label();
            lboraszam = new Label();
            lblegtobbhiany = new Label();
            label10 = new Label();
            rtbtanulo = new RichTextBox();
            btmentes = new Button();
            tbnev = new TextBox();
            tbosztaly = new TextBox();
            tbigazolt = new TextBox();
            tbnemigazolt = new TextBox();
            cbhany = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgadat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Adatok";
            // 
            // rtbadat
            // 
            rtbadat.Location = new Point(19, 67);
            rtbadat.Name = "rtbadat";
            rtbadat.Size = new Size(681, 221);
            rtbadat.TabIndex = 1;
            rtbadat.Text = "";
            // 
            // dgadat
            // 
            dgadat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgadat.Columns.AddRange(new DataGridViewColumn[] { nev, osztaly, hanyadika, igazol, nemigaz, osszhiany });
            dgadat.Location = new Point(19, 294);
            dgadat.Name = "dgadat";
            dgadat.Size = new Size(681, 241);
            dgadat.TabIndex = 2;
            dgadat.CellContentClick += dgadat_CellContentClick;
            // 
            // nev
            // 
            nev.HeaderText = "Név";
            nev.Name = "nev";
            nev.ReadOnly = true;
            // 
            // osztaly
            // 
            osztaly.HeaderText = "Osztály";
            osztaly.Name = "osztaly";
            osztaly.ReadOnly = true;
            // 
            // hanyadika
            // 
            hanyadika.HeaderText = "Hányadika";
            hanyadika.Name = "hanyadika";
            hanyadika.ReadOnly = true;
            // 
            // igazol
            // 
            igazol.HeaderText = "Igazolt";
            igazol.Name = "igazol";
            igazol.ReadOnly = true;
            // 
            // nemigaz
            // 
            nemigaz.HeaderText = "Nem Igazolt";
            nemigaz.Name = "nemigaz";
            nemigaz.ReadOnly = true;
            // 
            // osszhiany
            // 
            osszhiany.HeaderText = "Összes hiányzás";
            osszhiany.Name = "osszhiany";
            osszhiany.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(725, 82);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Név:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(725, 123);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Osztály:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(725, 176);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Hányadikán:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(725, 216);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 6;
            label5.Text = "Igazolt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(722, 255);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 7;
            label6.Text = "Nem igazolt:";
            // 
            // lbosszhiany
            // 
            lbosszhiany.AutoSize = true;
            lbosszhiany.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbosszhiany.Location = new Point(725, 312);
            lbosszhiany.Name = "lbosszhiany";
            lbosszhiany.Size = new Size(166, 15);
            lbosszhiany.TabIndex = 8;
            lbosszhiany.Text = "Összes hiányzás adott napon:";
            // 
            // lboraszam
            // 
            lboraszam.AutoSize = true;
            lboraszam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lboraszam.Location = new Point(725, 450);
            lboraszam.Name = "lboraszam";
            lboraszam.Size = new Size(74, 15);
            lboraszam.TabIndex = 9;
            lboraszam.Text = "Órák száma:";
            lboraszam.Click += lboraszam_Click;
            // 
            // lblegtobbhiany
            // 
            lblegtobbhiany.AutoSize = true;
            lblegtobbhiany.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblegtobbhiany.ForeColor = Color.Red;
            lblegtobbhiany.Location = new Point(722, 374);
            lblegtobbhiany.Name = "lblegtobbhiany";
            lblegtobbhiany.Size = new Size(167, 25);
            lblegtobbhiany.TabIndex = 10;
            lblegtobbhiany.Text = "Legtöbb hiányzás";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(964, 384);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 11;
            label10.Text = "Tanulók:";
            // 
            // rtbtanulo
            // 
            rtbtanulo.Location = new Point(964, 417);
            rtbtanulo.Name = "rtbtanulo";
            rtbtanulo.Size = new Size(149, 96);
            rtbtanulo.TabIndex = 12;
            rtbtanulo.Text = "";
            rtbtanulo.TextChanged += richTextBox2_TextChanged;
            // 
            // btmentes
            // 
            btmentes.Location = new Point(999, 58);
            btmentes.Name = "btmentes";
            btmentes.Size = new Size(114, 173);
            btmentes.TabIndex = 13;
            btmentes.Text = "Mentés";
            btmentes.UseVisualStyleBackColor = true;
            // 
            // tbnev
            // 
            tbnev.Location = new Point(764, 82);
            tbnev.Name = "tbnev";
            tbnev.Size = new Size(100, 23);
            tbnev.TabIndex = 14;
            // 
            // tbosztaly
            // 
            tbosztaly.Location = new Point(791, 123);
            tbosztaly.Name = "tbosztaly";
            tbosztaly.Size = new Size(100, 23);
            tbosztaly.TabIndex = 15;
            // 
            // tbigazolt
            // 
            tbigazolt.Location = new Point(818, 213);
            tbigazolt.Name = "tbigazolt";
            tbigazolt.Size = new Size(100, 23);
            tbigazolt.TabIndex = 16;
            // 
            // tbnemigazolt
            // 
            tbnemigazolt.Location = new Point(818, 252);
            tbnemigazolt.Name = "tbnemigazolt";
            tbnemigazolt.Size = new Size(100, 23);
            tbnemigazolt.TabIndex = 17;
            // 
            // cbhany
            // 
            cbhany.FormattingEnabled = true;
            cbhany.Location = new Point(818, 168);
            cbhany.Name = "cbhany";
            cbhany.Size = new Size(121, 23);
            cbhany.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 530);
            Controls.Add(cbhany);
            Controls.Add(tbnemigazolt);
            Controls.Add(tbigazolt);
            Controls.Add(tbosztaly);
            Controls.Add(tbnev);
            Controls.Add(btmentes);
            Controls.Add(rtbtanulo);
            Controls.Add(label10);
            Controls.Add(lblegtobbhiany);
            Controls.Add(lboraszam);
            Controls.Add(lbosszhiany);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgadat);
            Controls.Add(rtbadat);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgadat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbadat;
        private DataGridView dgadat;
        private DataGridViewTextBoxColumn nev;
        private DataGridViewTextBoxColumn osztaly;
        private DataGridViewTextBoxColumn hanyadika;
        private DataGridViewTextBoxColumn igazol;
        private DataGridViewTextBoxColumn nemigaz;
        private DataGridViewTextBoxColumn osszhiany;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbosszhiany;
        private Label lboraszam;
        private Label lblegtobbhiany;
        private Label label10;
        private RichTextBox rtbtanulo;
        private Button btmentes;
        private TextBox tbnev;
        private TextBox tbosztaly;
        private TextBox tbigazolt;
        private TextBox tbnemigazolt;
        private ComboBox cbhany;
    }
}
