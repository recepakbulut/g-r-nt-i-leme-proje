namespace nesne_takibi_3x3_led
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.baglan = new System.Windows.Forms.Button();
            this.bagkes = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdiobtnTekCisimTakibi = new System.Windows.Forms.RadioButton();
            this.rdbtnElleBelirleme = new System.Windows.Forms.RadioButton();
            this.rdiobtnYesil = new System.Windows.Forms.RadioButton();
            this.rdiobtnKirmizi = new System.Windows.Forms.RadioButton();
            this.rdiobtnMavi = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdiobtnCokCisimTakibi = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chkKoordinatiGoster = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.chkboxMesafeOlcer = new System.Windows.Forms.CheckBox();
            this.chkboxMesafeKordinati = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 490);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(969, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool
            // 
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(86, 22);
            this.tool.Text = "toolStripLabel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 276);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 270);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(591, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 276);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 270);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Durdur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // baglan
            // 
            this.baglan.Location = new System.Drawing.Point(18, 19);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(75, 23);
            this.baglan.TabIndex = 7;
            this.baglan.Text = "Bağlan";
            this.baglan.UseVisualStyleBackColor = true;
            this.baglan.Click += new System.EventHandler(this.baglan_Click);
            // 
            // bagkes
            // 
            this.bagkes.Location = new System.Drawing.Point(18, 48);
            this.bagkes.Name = "bagkes";
            this.bagkes.Size = new System.Drawing.Size(75, 23);
            this.bagkes.TabIndex = 8;
            this.bagkes.Text = "Bağlantı Kes";
            this.bagkes.UseVisualStyleBackColor = true;
            this.bagkes.Click += new System.EventHandler(this.bagkes_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(405, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(414, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kamerayı";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.comboBox2.Location = new System.Drawing.Point(422, 253);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baglan);
            this.groupBox2.Controls.Add(this.bagkes);
            this.groupBox2.Location = new System.Drawing.Point(431, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 77);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "arduinoyu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 468);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "0";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(525, 311);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 165);
            this.trackBar3.TabIndex = 41;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(492, 311);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 165);
            this.trackBar2.TabIndex = 40;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(459, 311);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 165);
            this.trackBar1.TabIndex = 39;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 26);
            this.label3.TabIndex = 45;
            this.label3.Text = "R\r\n255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 26);
            this.label4.TabIndex = 46;
            this.label4.Text = "G\r\n255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 26);
            this.label5.TabIndex = 47;
            this.label5.Text = "B\r\n255\r\n";
            // 
            // rdiobtnTekCisimTakibi
            // 
            this.rdiobtnTekCisimTakibi.AutoSize = true;
            this.rdiobtnTekCisimTakibi.Location = new System.Drawing.Point(606, 366);
            this.rdiobtnTekCisimTakibi.Name = "rdiobtnTekCisimTakibi";
            this.rdiobtnTekCisimTakibi.Size = new System.Drawing.Size(103, 17);
            this.rdiobtnTekCisimTakibi.TabIndex = 48;
            this.rdiobtnTekCisimTakibi.TabStop = true;
            this.rdiobtnTekCisimTakibi.Text = "Tek Cisim Takibi";
            this.rdiobtnTekCisimTakibi.UseVisualStyleBackColor = true;
            // 
            // rdbtnElleBelirleme
            // 
            this.rdbtnElleBelirleme.AutoSize = true;
            this.rdbtnElleBelirleme.Location = new System.Drawing.Point(8, 88);
            this.rdbtnElleBelirleme.Name = "rdbtnElleBelirleme";
            this.rdbtnElleBelirleme.Size = new System.Drawing.Size(87, 17);
            this.rdbtnElleBelirleme.TabIndex = 24;
            this.rdbtnElleBelirleme.TabStop = true;
            this.rdbtnElleBelirleme.Text = "Elle Belirleme";
            this.rdbtnElleBelirleme.UseVisualStyleBackColor = true;
            // 
            // rdiobtnYesil
            // 
            this.rdiobtnYesil.AutoSize = true;
            this.rdiobtnYesil.Location = new System.Drawing.Point(8, 42);
            this.rdiobtnYesil.Name = "rdiobtnYesil";
            this.rdiobtnYesil.Size = new System.Drawing.Size(64, 17);
            this.rdiobtnYesil.TabIndex = 8;
            this.rdiobtnYesil.TabStop = true;
            this.rdiobtnYesil.Text = "Yeşil (G)";
            this.rdiobtnYesil.UseVisualStyleBackColor = true;
            // 
            // rdiobtnKirmizi
            // 
            this.rdiobtnKirmizi.AutoSize = true;
            this.rdiobtnKirmizi.Location = new System.Drawing.Point(8, 19);
            this.rdiobtnKirmizi.Name = "rdiobtnKirmizi";
            this.rdiobtnKirmizi.Size = new System.Drawing.Size(68, 17);
            this.rdiobtnKirmizi.TabIndex = 6;
            this.rdiobtnKirmizi.TabStop = true;
            this.rdiobtnKirmizi.Text = "Kırmızı(R)";
            this.rdiobtnKirmizi.UseVisualStyleBackColor = true;
            // 
            // rdiobtnMavi
            // 
            this.rdiobtnMavi.AutoSize = true;
            this.rdiobtnMavi.Location = new System.Drawing.Point(8, 65);
            this.rdiobtnMavi.Name = "rdiobtnMavi";
            this.rdiobtnMavi.Size = new System.Drawing.Size(64, 17);
            this.rdiobtnMavi.TabIndex = 7;
            this.rdiobtnMavi.TabStop = true;
            this.rdiobtnMavi.Text = "Mavi (B)";
            this.rdiobtnMavi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnElleBelirleme);
            this.groupBox3.Controls.Add(this.rdiobtnYesil);
            this.groupBox3.Controls.Add(this.rdiobtnKirmizi);
            this.groupBox3.Controls.Add(this.rdiobtnMavi);
            this.groupBox3.Location = new System.Drawing.Point(347, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(93, 114);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Renkler";
            // 
            // rdiobtnCokCisimTakibi
            // 
            this.rdiobtnCokCisimTakibi.AutoSize = true;
            this.rdiobtnCokCisimTakibi.Location = new System.Drawing.Point(606, 389);
            this.rdiobtnCokCisimTakibi.Name = "rdiobtnCokCisimTakibi";
            this.rdiobtnCokCisimTakibi.Size = new System.Drawing.Size(111, 17);
            this.rdiobtnCokCisimTakibi.TabIndex = 50;
            this.rdiobtnCokCisimTakibi.TabStop = true;
            this.rdiobtnCokCisimTakibi.Text = "Çoklu Cisim Takibi";
            this.rdiobtnCokCisimTakibi.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(803, 389);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 63);
            this.richTextBox1.TabIndex = 51;
            this.richTextBox1.Text = "";
            // 
            // chkKoordinatiGoster
            // 
            this.chkKoordinatiGoster.AutoSize = true;
            this.chkKoordinatiGoster.Location = new System.Drawing.Point(803, 366);
            this.chkKoordinatiGoster.Name = "chkKoordinatiGoster";
            this.chkKoordinatiGoster.Size = new System.Drawing.Size(118, 17);
            this.chkKoordinatiGoster.TabIndex = 52;
            this.chkKoordinatiGoster.Text = "Koordinatları Göster";
            this.chkKoordinatiGoster.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(15, 356);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 53;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(162, 356);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 96);
            this.richTextBox3.TabIndex = 54;
            this.richTextBox3.Text = "";
            // 
            // chkboxMesafeOlcer
            // 
            this.chkboxMesafeOlcer.AutoSize = true;
            this.chkboxMesafeOlcer.Location = new System.Drawing.Point(15, 333);
            this.chkboxMesafeOlcer.Name = "chkboxMesafeOlcer";
            this.chkboxMesafeOlcer.Size = new System.Drawing.Size(86, 17);
            this.chkboxMesafeOlcer.TabIndex = 55;
            this.chkboxMesafeOlcer.Text = "mesafe ölçer";
            this.chkboxMesafeOlcer.UseVisualStyleBackColor = true;
            // 
            // chkboxMesafeKordinati
            // 
            this.chkboxMesafeKordinati.AutoSize = true;
            this.chkboxMesafeKordinati.Location = new System.Drawing.Point(176, 333);
            this.chkboxMesafeKordinati.Name = "chkboxMesafeKordinati";
            this.chkboxMesafeKordinati.Size = new System.Drawing.Size(109, 17);
            this.chkboxMesafeKordinati.TabIndex = 56;
            this.chkboxMesafeKordinati.Text = "mesafe koordinatı";
            this.chkboxMesafeKordinati.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 515);
            this.Controls.Add(this.chkboxMesafeKordinati);
            this.Controls.Add(this.chkboxMesafeOlcer);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.chkKoordinatiGoster);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rdiobtnCokCisimTakibi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rdiobtnTekCisimTakibi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tool;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button baglan;
        private System.Windows.Forms.Button bagkes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdiobtnTekCisimTakibi;
        private System.Windows.Forms.RadioButton rdbtnElleBelirleme;
        private System.Windows.Forms.RadioButton rdiobtnYesil;
        private System.Windows.Forms.RadioButton rdiobtnKirmizi;
        private System.Windows.Forms.RadioButton rdiobtnMavi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdiobtnCokCisimTakibi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chkKoordinatiGoster;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.CheckBox chkboxMesafeOlcer;
        private System.Windows.Forms.CheckBox chkboxMesafeKordinati;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

