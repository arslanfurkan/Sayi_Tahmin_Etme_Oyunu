namespace SayıBulmacaOyunu163301012
{
    partial class FormMain
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
            this.panelKayit = new System.Windows.Forms.Panel();
            this.comboBoxSkorlar = new System.Windows.Forms.ComboBox();
            this.checkBoxSkorlariGoster = new System.Windows.Forms.CheckBox();
            this.buttonKaydetVeOyna = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHakSayisi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBasamakSayisi = new System.Windows.Forms.NumericUpDown();
            this.radioButtonTekrarsiz = new System.Windows.Forms.RadioButton();
            this.radioButtonTekrarli = new System.Windows.Forms.RadioButton();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.panelOyun = new System.Windows.Forms.Panel();
            this.labelKalanSure = new System.Windows.Forms.Label();
            this.labelKalanHak = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTahminEt = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.panelBilgilendirme = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHakSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBasamakSayisi)).BeginInit();
            this.panelOyun.SuspendLayout();
            this.panelBilgilendirme.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKayit
            // 
            this.panelKayit.BackColor = System.Drawing.Color.PaleGreen;
            this.panelKayit.Controls.Add(this.comboBoxSkorlar);
            this.panelKayit.Controls.Add(this.checkBoxSkorlariGoster);
            this.panelKayit.Controls.Add(this.buttonKaydetVeOyna);
            this.panelKayit.Controls.Add(this.label5);
            this.panelKayit.Controls.Add(this.label4);
            this.panelKayit.Controls.Add(this.label1);
            this.panelKayit.Controls.Add(this.label3);
            this.panelKayit.Controls.Add(this.label2);
            this.panelKayit.Controls.Add(this.numericUpDownHakSayisi);
            this.panelKayit.Controls.Add(this.numericUpDownBasamakSayisi);
            this.panelKayit.Controls.Add(this.radioButtonTekrarsiz);
            this.panelKayit.Controls.Add(this.radioButtonTekrarli);
            this.panelKayit.Controls.Add(this.textBoxKullaniciAdi);
            this.panelKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelKayit.Location = new System.Drawing.Point(12, 12);
            this.panelKayit.Name = "panelKayit";
            this.panelKayit.Size = new System.Drawing.Size(507, 167);
            this.panelKayit.TabIndex = 0;
            // 
            // comboBoxSkorlar
            // 
            this.comboBoxSkorlar.FormattingEnabled = true;
            this.comboBoxSkorlar.Location = new System.Drawing.Point(349, 30);
            this.comboBoxSkorlar.Name = "comboBoxSkorlar";
            this.comboBoxSkorlar.Size = new System.Drawing.Size(137, 24);
            this.comboBoxSkorlar.TabIndex = 6;
            this.comboBoxSkorlar.Visible = false;
            // 
            // checkBoxSkorlariGoster
            // 
            this.checkBoxSkorlariGoster.AutoSize = true;
            this.checkBoxSkorlariGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSkorlariGoster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxSkorlariGoster.Location = new System.Drawing.Point(349, 3);
            this.checkBoxSkorlariGoster.Name = "checkBoxSkorlariGoster";
            this.checkBoxSkorlariGoster.Size = new System.Drawing.Size(137, 21);
            this.checkBoxSkorlariGoster.TabIndex = 5;
            this.checkBoxSkorlariGoster.Text = "Skorları göster";
            this.checkBoxSkorlariGoster.UseVisualStyleBackColor = true;
            this.checkBoxSkorlariGoster.CheckedChanged += new System.EventHandler(this.checkBoxSkorlariGoster_CheckedChanged);
            // 
            // buttonKaydetVeOyna
            // 
            this.buttonKaydetVeOyna.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonKaydetVeOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydetVeOyna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKaydetVeOyna.Location = new System.Drawing.Point(364, 98);
            this.buttonKaydetVeOyna.Name = "buttonKaydetVeOyna";
            this.buttonKaydetVeOyna.Size = new System.Drawing.Size(99, 57);
            this.buttonKaydetVeOyna.TabIndex = 4;
            this.buttonKaydetVeOyna.Text = "Kaydet ve Oyna";
            this.buttonKaydetVeOyna.UseVisualStyleBackColor = false;
            this.buttonKaydetVeOyna.Click += new System.EventHandler(this.buttonKaydetVeOyna_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Basamak Sayisi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hak sayisi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kayıt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sayıdaki  rakamlar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanici Adi :";
            // 
            // numericUpDownHakSayisi
            // 
            this.numericUpDownHakSayisi.Location = new System.Drawing.Point(175, 105);
            this.numericUpDownHakSayisi.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownHakSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHakSayisi.Name = "numericUpDownHakSayisi";
            this.numericUpDownHakSayisi.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownHakSayisi.TabIndex = 2;
            this.numericUpDownHakSayisi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownBasamakSayisi
            // 
            this.numericUpDownBasamakSayisi.Location = new System.Drawing.Point(175, 133);
            this.numericUpDownBasamakSayisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBasamakSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBasamakSayisi.Name = "numericUpDownBasamakSayisi";
            this.numericUpDownBasamakSayisi.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownBasamakSayisi.TabIndex = 3;
            this.numericUpDownBasamakSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // radioButtonTekrarsiz
            // 
            this.radioButtonTekrarsiz.AutoSize = true;
            this.radioButtonTekrarsiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonTekrarsiz.Location = new System.Drawing.Point(175, 78);
            this.radioButtonTekrarsiz.Name = "radioButtonTekrarsiz";
            this.radioButtonTekrarsiz.Size = new System.Drawing.Size(97, 21);
            this.radioButtonTekrarsiz.TabIndex = 1;
            this.radioButtonTekrarsiz.Text = "Tekrarsız";
            this.radioButtonTekrarsiz.UseVisualStyleBackColor = true;
            // 
            // radioButtonTekrarli
            // 
            this.radioButtonTekrarli.AutoSize = true;
            this.radioButtonTekrarli.Checked = true;
            this.radioButtonTekrarli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonTekrarli.Location = new System.Drawing.Point(175, 51);
            this.radioButtonTekrarli.Name = "radioButtonTekrarli";
            this.radioButtonTekrarli.Size = new System.Drawing.Size(85, 21);
            this.radioButtonTekrarli.TabIndex = 1;
            this.radioButtonTekrarli.TabStop = true;
            this.radioButtonTekrarli.Text = "Tekrarlı";
            this.radioButtonTekrarli.UseVisualStyleBackColor = true;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(175, 23);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.textBoxKullaniciAdi.TabIndex = 0;
            this.textBoxKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_onlyLetters);
            // 
            // panelOyun
            // 
            this.panelOyun.BackColor = System.Drawing.Color.PaleGreen;
            this.panelOyun.Controls.Add(this.labelKalanSure);
            this.panelOyun.Controls.Add(this.labelKalanHak);
            this.panelOyun.Controls.Add(this.label6);
            this.panelOyun.Controls.Add(this.buttonTahminEt);
            this.panelOyun.Controls.Add(this.textBox9);
            this.panelOyun.Controls.Add(this.textBox8);
            this.panelOyun.Controls.Add(this.textBox7);
            this.panelOyun.Controls.Add(this.textBox6);
            this.panelOyun.Controls.Add(this.textBox5);
            this.panelOyun.Controls.Add(this.textBox4);
            this.panelOyun.Controls.Add(this.textBox3);
            this.panelOyun.Controls.Add(this.textBox2);
            this.panelOyun.Controls.Add(this.textBox1);
            this.panelOyun.Controls.Add(this.textBox0);
            this.panelOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelOyun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOyun.Location = new System.Drawing.Point(12, 12);
            this.panelOyun.Name = "panelOyun";
            this.panelOyun.Size = new System.Drawing.Size(507, 167);
            this.panelOyun.TabIndex = 0;
            this.panelOyun.Visible = false;
            // 
            // labelKalanSure
            // 
            this.labelKalanSure.AutoSize = true;
            this.labelKalanSure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelKalanSure.Location = new System.Drawing.Point(17, 48);
            this.labelKalanSure.Name = "labelKalanSure";
            this.labelKalanSure.Size = new System.Drawing.Size(93, 17);
            this.labelKalanSure.TabIndex = 5;
            this.labelKalanSure.Text = "Kalan Süre:";
            // 
            // labelKalanHak
            // 
            this.labelKalanHak.AutoSize = true;
            this.labelKalanHak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelKalanHak.Location = new System.Drawing.Point(17, 21);
            this.labelKalanHak.Name = "labelKalanHak";
            this.labelKalanHak.Size = new System.Drawing.Size(125, 17);
            this.labelKalanHak.TabIndex = 5;
            this.labelKalanHak.Text = "Kalan Hakkınız: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Chocolate;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(17, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Oyun";
            // 
            // buttonTahminEt
            // 
            this.buttonTahminEt.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonTahminEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTahminEt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTahminEt.Location = new System.Drawing.Point(352, 114);
            this.buttonTahminEt.Name = "buttonTahminEt";
            this.buttonTahminEt.Size = new System.Drawing.Size(135, 50);
            this.buttonTahminEt.TabIndex = 4;
            this.buttonTahminEt.Text = "Tahmin Et";
            this.buttonTahminEt.UseVisualStyleBackColor = false;
            this.buttonTahminEt.Click += new System.EventHandler(this.buttonTahminEt_Click);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox9.Location = new System.Drawing.Point(104, 81);
            this.textBox9.MaxLength = 1;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(33, 30);
            this.textBox9.TabIndex = 0;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.Visible = false;
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(143, 81);
            this.textBox8.MaxLength = 1;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(33, 30);
            this.textBox8.TabIndex = 0;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.Visible = false;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(182, 81);
            this.textBox7.MaxLength = 1;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(33, 30);
            this.textBox7.TabIndex = 0;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.Visible = false;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(221, 81);
            this.textBox6.MaxLength = 1;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(33, 30);
            this.textBox6.TabIndex = 0;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.Visible = false;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(260, 81);
            this.textBox5.MaxLength = 1;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(33, 30);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Visible = false;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(299, 81);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(33, 30);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Visible = false;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(338, 81);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 30);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Visible = false;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(377, 81);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 30);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(416, 81);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // textBox0
            // 
            this.textBox0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox0.Location = new System.Drawing.Point(455, 81);
            this.textBox0.MaxLength = 1;
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(32, 30);
            this.textBox0.TabIndex = 0;
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_onlyNumbers);
            // 
            // panelBilgilendirme
            // 
            this.panelBilgilendirme.BackColor = System.Drawing.Color.PaleGreen;
            this.panelBilgilendirme.Controls.Add(this.label7);
            this.panelBilgilendirme.Controls.Add(this.textBox13);
            this.panelBilgilendirme.Controls.Add(this.label10);
            this.panelBilgilendirme.Controls.Add(this.label9);
            this.panelBilgilendirme.Controls.Add(this.label8);
            this.panelBilgilendirme.Controls.Add(this.textBox12);
            this.panelBilgilendirme.Controls.Add(this.textBox11);
            this.panelBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelBilgilendirme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBilgilendirme.Location = new System.Drawing.Point(12, 185);
            this.panelBilgilendirme.Name = "panelBilgilendirme";
            this.panelBilgilendirme.Size = new System.Drawing.Size(507, 167);
            this.panelBilgilendirme.TabIndex = 0;
            this.panelBilgilendirme.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Chocolate;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bilgilendirme";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.Yellow;
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(25, 106);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(131, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sayı bulunmamakta.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(131, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sayı var ve yanlış yerde.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(131, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sayı var ve doğru yerde.";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.Red;
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(25, 78);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 0;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Blue;
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(25, 50);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(525, 358);
            this.Controls.Add(this.panelBilgilendirme);
            this.Controls.Add(this.panelOyun);
            this.Controls.Add(this.panelKayit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(546, 405);
            this.MinimumSize = new System.Drawing.Size(543, 231);
            this.Name = "FormMain";
            this.Text = "Sayı Bulmaca ";
            this.panelKayit.ResumeLayout(false);
            this.panelKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHakSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBasamakSayisi)).EndInit();
            this.panelOyun.ResumeLayout(false);
            this.panelOyun.PerformLayout();
            this.panelBilgilendirme.ResumeLayout(false);
            this.panelBilgilendirme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKayit;
        private System.Windows.Forms.RadioButton radioButtonTekrarsiz;
        private System.Windows.Forms.RadioButton radioButtonTekrarli;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHakSayisi;
        private System.Windows.Forms.NumericUpDown numericUpDownBasamakSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKaydetVeOyna;
        private System.Windows.Forms.Panel panelOyun;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Label labelKalanSure;
        private System.Windows.Forms.Label labelKalanHak;
        private System.Windows.Forms.Button buttonTahminEt;
        private System.Windows.Forms.Panel panelBilgilendirme;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxSkorlar;
        private System.Windows.Forms.CheckBox checkBoxSkorlariGoster;
    }
}

