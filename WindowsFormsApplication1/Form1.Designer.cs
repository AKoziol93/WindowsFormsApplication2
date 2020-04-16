namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnDane = new System.Windows.Forms.Button();
            this.rtxtDane = new System.Windows.Forms.RichTextBox();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.txtRodzajRAM = new System.Windows.Forms.TextBox();
            this.txtSizeRAM = new System.Windows.Forms.TextBox();
            this.txtPredkosc = new System.Windows.Forms.TextBox();
            this.txtProcesor = new System.Windows.Forms.TextBox();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.lblDane = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRodzajRAM = new System.Windows.Forms.Label();
            this.lblSizeRAM = new System.Windows.Forms.Label();
            this.lblPredkosc = new System.Windows.Forms.Label();
            this.lblProcesor = new System.Windows.Forms.Label();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltytol = new System.Windows.Forms.Label();
            this.gupOpis = new System.Windows.Forms.GroupBox();
            this.chbXP = new System.Windows.Forms.CheckBox();
            this.chbVista = new System.Windows.Forms.CheckBox();
            this.chbLinux = new System.Windows.Forms.CheckBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gupKomputer = new System.Windows.Forms.GroupBox();
            this.lblSystem3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.vscrDay = new System.Windows.Forms.VScrollBar();
            this.vscrMonth = new System.Windows.Forms.VScrollBar();
            this.vscrYear = new System.Windows.Forms.VScrollBar();
            this.lblday = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gupOpis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gupKomputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnClr);
            this.panel1.Controls.Add(this.btnDane);
            this.panel1.Controls.Add(this.rtxtDane);
            this.panel1.Controls.Add(this.txtEkran);
            this.panel1.Controls.Add(this.txtRodzajRAM);
            this.panel1.Controls.Add(this.txtSizeRAM);
            this.panel1.Controls.Add(this.txtPredkosc);
            this.panel1.Controls.Add(this.txtProcesor);
            this.panel1.Controls.Add(this.txtNazwa);
            this.panel1.Controls.Add(this.lblDane);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblRodzajRAM);
            this.panel1.Controls.Add(this.lblSizeRAM);
            this.panel1.Controls.Add(this.lblPredkosc);
            this.panel1.Controls.Add(this.lblProcesor);
            this.panel1.Controls.Add(this.lblNazwa);
            this.panel1.Location = new System.Drawing.Point(23, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 292);
            this.panel1.TabIndex = 0;
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(153, 251);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(129, 31);
            this.btnClr.TabIndex = 15;
            this.btnClr.Text = "Wyczysc Pola";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btnDane
            // 
            this.btnDane.Location = new System.Drawing.Point(6, 250);
            this.btnDane.Name = "btnDane";
            this.btnDane.Size = new System.Drawing.Size(87, 32);
            this.btnDane.TabIndex = 14;
            this.btnDane.Text = "Wyswietl";
            this.btnDane.UseVisualStyleBackColor = true;
            this.btnDane.Click += new System.EventHandler(this.btnDane_Click);
            // 
            // rtxtDane
            // 
            this.rtxtDane.Location = new System.Drawing.Point(6, 176);
            this.rtxtDane.Name = "rtxtDane";
            this.rtxtDane.Size = new System.Drawing.Size(275, 68);
            this.rtxtDane.TabIndex = 13;
            this.rtxtDane.Text = "";
            // 
            // txtEkran
            // 
            this.txtEkran.Location = new System.Drawing.Point(110, 131);
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(172, 20);
            this.txtEkran.TabIndex = 12;
            this.txtEkran.TextChanged += new System.EventHandler(this.txtEkran_TextChanged);
            // 
            // txtRodzajRAM
            // 
            this.txtRodzajRAM.Location = new System.Drawing.Point(110, 109);
            this.txtRodzajRAM.Name = "txtRodzajRAM";
            this.txtRodzajRAM.Size = new System.Drawing.Size(172, 20);
            this.txtRodzajRAM.TabIndex = 11;
            this.txtRodzajRAM.TextChanged += new System.EventHandler(this.txtRodzajRAM_TextChanged);
            // 
            // txtSizeRAM
            // 
            this.txtSizeRAM.Location = new System.Drawing.Point(110, 87);
            this.txtSizeRAM.Name = "txtSizeRAM";
            this.txtSizeRAM.Size = new System.Drawing.Size(172, 20);
            this.txtSizeRAM.TabIndex = 10;
            this.txtSizeRAM.TextChanged += new System.EventHandler(this.txtSizeRAM_TextChanged);
            // 
            // txtPredkosc
            // 
            this.txtPredkosc.Location = new System.Drawing.Point(110, 64);
            this.txtPredkosc.Name = "txtPredkosc";
            this.txtPredkosc.Size = new System.Drawing.Size(172, 20);
            this.txtPredkosc.TabIndex = 9;
            this.txtPredkosc.TextChanged += new System.EventHandler(this.txtPredkosc_TextChanged);
            // 
            // txtProcesor
            // 
            this.txtProcesor.Location = new System.Drawing.Point(110, 40);
            this.txtProcesor.Name = "txtProcesor";
            this.txtProcesor.Size = new System.Drawing.Size(172, 20);
            this.txtProcesor.TabIndex = 8;
            this.txtProcesor.TextChanged += new System.EventHandler(this.txtProcesor_TextChanged);
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(110, 17);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(172, 20);
            this.txtNazwa.TabIndex = 7;
            this.txtNazwa.TextChanged += new System.EventHandler(this.txtNazwa_TextChanged);
            // 
            // lblDane
            // 
            this.lblDane.AutoSize = true;
            this.lblDane.ForeColor = System.Drawing.Color.Blue;
            this.lblDane.Location = new System.Drawing.Point(7, 160);
            this.lblDane.Name = "lblDane";
            this.lblDane.Size = new System.Drawing.Size(86, 13);
            this.lblDane.TabIndex = 6;
            this.lblDane.Text = "Dane Adresowe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(3, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Przekoatna Ekranu:";
            // 
            // lblRodzajRAM
            // 
            this.lblRodzajRAM.AutoSize = true;
            this.lblRodzajRAM.ForeColor = System.Drawing.Color.Blue;
            this.lblRodzajRAM.Location = new System.Drawing.Point(3, 112);
            this.lblRodzajRAM.Name = "lblRodzajRAM";
            this.lblRodzajRAM.Size = new System.Drawing.Size(67, 13);
            this.lblRodzajRAM.TabIndex = 4;
            this.lblRodzajRAM.Text = "Rodzaj RAM";
            // 
            // lblSizeRAM
            // 
            this.lblSizeRAM.AutoSize = true;
            this.lblSizeRAM.ForeColor = System.Drawing.Color.Blue;
            this.lblSizeRAM.Location = new System.Drawing.Point(3, 90);
            this.lblSizeRAM.Name = "lblSizeRAM";
            this.lblSizeRAM.Size = new System.Drawing.Size(78, 13);
            this.lblSizeRAM.TabIndex = 3;
            this.lblSizeRAM.Text = "Wielkosc RAM";
            // 
            // lblPredkosc
            // 
            this.lblPredkosc.AutoSize = true;
            this.lblPredkosc.ForeColor = System.Drawing.Color.Blue;
            this.lblPredkosc.Location = new System.Drawing.Point(3, 67);
            this.lblPredkosc.Name = "lblPredkosc";
            this.lblPredkosc.Size = new System.Drawing.Size(74, 13);
            this.lblPredkosc.TabIndex = 2;
            this.lblPredkosc.Text = "Częstotliwosc:";
            // 
            // lblProcesor
            // 
            this.lblProcesor.AutoSize = true;
            this.lblProcesor.ForeColor = System.Drawing.Color.Blue;
            this.lblProcesor.Location = new System.Drawing.Point(3, 43);
            this.lblProcesor.Name = "lblProcesor";
            this.lblProcesor.Size = new System.Drawing.Size(52, 13);
            this.lblProcesor.TabIndex = 1;
            this.lblProcesor.Text = "Procesor:";
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.ForeColor = System.Drawing.Color.Blue;
            this.lblNazwa.Location = new System.Drawing.Point(3, 20);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(43, 13);
            this.lblNazwa.TabIndex = 0;
            this.lblNazwa.Text = "Nazwa:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lbltytol);
            this.panel2.Location = new System.Drawing.Point(285, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 23);
            this.panel2.TabIndex = 1;
            // 
            // lbltytol
            // 
            this.lbltytol.AutoSize = true;
            this.lbltytol.Location = new System.Drawing.Point(33, 5);
            this.lbltytol.Name = "lbltytol";
            this.lbltytol.Size = new System.Drawing.Size(105, 13);
            this.lbltytol.TabIndex = 0;
            this.lbltytol.Text = "Gielda Komputerowa";
            // 
            // gupOpis
            // 
            this.gupOpis.Controls.Add(this.chbXP);
            this.gupOpis.Controls.Add(this.chbVista);
            this.gupOpis.Controls.Add(this.chbLinux);
            this.gupOpis.Location = new System.Drawing.Point(23, 346);
            this.gupOpis.Name = "gupOpis";
            this.gupOpis.Size = new System.Drawing.Size(284, 39);
            this.gupOpis.TabIndex = 2;
            this.gupOpis.TabStop = false;
            this.gupOpis.Text = "System Operacyjny";
            // 
            // chbXP
            // 
            this.chbXP.AutoSize = true;
            this.chbXP.Location = new System.Drawing.Point(191, 11);
            this.chbXP.Name = "chbXP";
            this.chbXP.Size = new System.Drawing.Size(87, 17);
            this.chbXP.TabIndex = 2;
            this.chbXP.Text = "Windows XP";
            this.chbXP.UseVisualStyleBackColor = true;
            this.chbXP.CheckedChanged += new System.EventHandler(this.chbXP_CheckedChanged);
            // 
            // chbVista
            // 
            this.chbVista.AutoSize = true;
            this.chbVista.Location = new System.Drawing.Point(6, 11);
            this.chbVista.Name = "chbVista";
            this.chbVista.Size = new System.Drawing.Size(96, 17);
            this.chbVista.TabIndex = 1;
            this.chbVista.Text = "Windows Vista";
            this.chbVista.UseVisualStyleBackColor = true;
            this.chbVista.CheckedChanged += new System.EventHandler(this.chbVista_CheckedChanged);
            // 
            // chbLinux
            // 
            this.chbLinux.AutoSize = true;
            this.chbLinux.Location = new System.Drawing.Point(117, 11);
            this.chbLinux.Name = "chbLinux";
            this.chbLinux.Size = new System.Drawing.Size(51, 17);
            this.chbLinux.TabIndex = 0;
            this.chbLinux.Text = "Linux";
            this.chbLinux.UseVisualStyleBackColor = true;
            this.chbLinux.CheckedChanged += new System.EventHandler(this.chbLinux_CheckedChanged);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(23, 436);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(225, 42);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "Zamknij Program !";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 11);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // gupKomputer
            // 
            this.gupKomputer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gupKomputer.Controls.Add(this.lblSystem3);
            this.gupKomputer.Controls.Add(this.label5);
            this.gupKomputer.Controls.Add(this.label3);
            this.gupKomputer.Controls.Add(this.label7);
            this.gupKomputer.Controls.Add(this.label1);
            this.gupKomputer.Controls.Add(this.lbl5);
            this.gupKomputer.Controls.Add(this.lbl4);
            this.gupKomputer.Controls.Add(this.lbl3);
            this.gupKomputer.Controls.Add(this.lbl2);
            this.gupKomputer.Controls.Add(this.lbl1);
            this.gupKomputer.Location = new System.Drawing.Point(351, 117);
            this.gupKomputer.Name = "gupKomputer";
            this.gupKomputer.Size = new System.Drawing.Size(238, 185);
            this.gupKomputer.TabIndex = 5;
            this.gupKomputer.TabStop = false;
            this.gupKomputer.Text = "Opis Komputera";
            // 
            // lblSystem3
            // 
            this.lblSystem3.AutoSize = true;
            this.lblSystem3.Location = new System.Drawing.Point(119, 138);
            this.lblSystem3.Name = "lblSystem3";
            this.lblSystem3.Size = new System.Drawing.Size(0, 13);
            this.lblSystem3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 47);
            this.label7.MaximumSize = new System.Drawing.Size(100, 0);
            this.label7.MinimumSize = new System.Drawing.Size(100, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.ForeColor = System.Drawing.Color.Blue;
            this.lbl5.Location = new System.Drawing.Point(11, 138);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(97, 13);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "System Operacyjny";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.Blue;
            this.lbl4.Location = new System.Drawing.Point(11, 107);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(88, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Wielkosc Ekranu";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.Blue;
            this.lbl3.Location = new System.Drawing.Point(11, 78);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(42, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Pamiec";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.Blue;
            this.lbl2.Location = new System.Drawing.Point(11, 47);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(49, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Procesor";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Blue;
            this.lbl1.Location = new System.Drawing.Point(11, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nazwa";
            // 
            // vscrDay
            // 
            this.vscrDay.LargeChange = 1;
            this.vscrDay.Location = new System.Drawing.Point(385, 305);
            this.vscrDay.Maximum = 31;
            this.vscrDay.Minimum = 1;
            this.vscrDay.Name = "vscrDay";
            this.vscrDay.Size = new System.Drawing.Size(19, 105);
            this.vscrDay.TabIndex = 1;
            this.vscrDay.Value = 1;
            this.vscrDay.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vscrDay_Scroll);
            // 
            // vscrMonth
            // 
            this.vscrMonth.LargeChange = 1;
            this.vscrMonth.Location = new System.Drawing.Point(453, 305);
            this.vscrMonth.Maximum = 12;
            this.vscrMonth.Minimum = 1;
            this.vscrMonth.Name = "vscrMonth";
            this.vscrMonth.Size = new System.Drawing.Size(19, 105);
            this.vscrMonth.TabIndex = 1;
            this.vscrMonth.Value = 1;
            this.vscrMonth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vscrMonth_Scroll_1);
            // 
            // vscrYear
            // 
            this.vscrYear.LargeChange = 1;
            this.vscrYear.Location = new System.Drawing.Point(505, 305);
            this.vscrYear.Maximum = 2012;
            this.vscrYear.Minimum = 2000;
            this.vscrYear.Name = "vscrYear";
            this.vscrYear.Size = new System.Drawing.Size(19, 105);
            this.vscrYear.TabIndex = 1;
            this.vscrYear.Value = 2000;
            this.vscrYear.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vscrYear_Scroll);
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.BackColor = System.Drawing.Color.White;
            this.lblday.Location = new System.Drawing.Point(348, 357);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(34, 13);
            this.lblday.TabIndex = 12;
            this.lblday.Text = "Dzien";
            this.lblday.Click += new System.EventHandler(this.lblday_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(407, 357);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 13);
            this.lblMonth.TabIndex = 13;
            this.lblMonth.Text = "Miesiac";
            this.lblMonth.Click += new System.EventHandler(this.lblMonth_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(475, 358);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(27, 13);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Rok";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Items.AddRange(new object[] {
            "Przelew",
            "Karta",
            "Gotówka przy odbiorze",
            "Przesył pocztowy"});
            this.cmbBank.Location = new System.Drawing.Point(327, 422);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(138, 21);
            this.cmbBank.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.vscrYear);
            this.Controls.Add(this.vscrMonth);
            this.Controls.Add(this.vscrDay);
            this.Controls.Add(this.gupKomputer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.gupOpis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Girlda Komputerowa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gupOpis.ResumeLayout(false);
            this.gupOpis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gupKomputer.ResumeLayout(false);
            this.gupKomputer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxtDane;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.TextBox txtRodzajRAM;
        private System.Windows.Forms.TextBox txtSizeRAM;
        private System.Windows.Forms.TextBox txtPredkosc;
        private System.Windows.Forms.TextBox txtProcesor;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label lblDane;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRodzajRAM;
        private System.Windows.Forms.Label lblSizeRAM;
        private System.Windows.Forms.Label lblPredkosc;
        private System.Windows.Forms.Label lblProcesor;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltytol;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnDane;
        private System.Windows.Forms.GroupBox gupOpis;
        private System.Windows.Forms.CheckBox chbXP;
        private System.Windows.Forms.CheckBox chbVista;
        private System.Windows.Forms.CheckBox chbLinux;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gupKomputer;
        private System.Windows.Forms.Label lblSystem3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.VScrollBar vscrDay;
        private System.Windows.Forms.VScrollBar vscrMonth;
        private System.Windows.Forms.VScrollBar vscrYear;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbBank;
    }
}

