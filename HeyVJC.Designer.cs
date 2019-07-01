namespace HeyVJoyController
{
    partial class HeyVJC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeyVJC));
            this.guncelle = new System.Windows.Forms.Timer(this.components);
            this.aygitKimlik = new System.Windows.Forms.TextBox();
            this.etiket1 = new System.Windows.Forms.Label();
            this.aygitaBaglan = new System.Windows.Forms.Button();
            this.baglanti1 = new System.Windows.Forms.GroupBox();
            this.vJoyDurum = new System.Windows.Forms.Label();
            this.etiket2 = new System.Windows.Forms.Label();
            this.arduino = new System.Windows.Forms.GroupBox();
            this.girdiCihazi = new System.Windows.Forms.ComboBox();
            this.arduinoGirisler = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.arduinoDurum = new System.Windows.Forms.Label();
            this.arduinoHiz = new System.Windows.Forms.TextBox();
            this.etiket4 = new System.Windows.Forms.Label();
            this.etiket3 = new System.Windows.Forms.Label();
            this.arduinoBaglan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EgriPanel = new System.Windows.Forms.Panel();
            this.seciliNoktaDeger = new System.Windows.Forms.Label();
            this.maxNDegerAzalt = new System.Windows.Forms.Button();
            this.maxNDegerArtir = new System.Windows.Forms.Button();
            this.egridenCik = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.noktaAzalt = new System.Windows.Forms.Button();
            this.noktaArtir = new System.Windows.Forms.Button();
            this.direksiyonYeniDeger = new System.Windows.Forms.Label();
            this.direksiyonYuzdesi = new System.Windows.Forms.Label();
            this.EgriDuzenle = new System.Windows.Forms.Button();
            this.zMax = new System.Windows.Forms.TextBox();
            this.yMax = new System.Windows.Forms.TextBox();
            this.xMax = new System.Windows.Forms.TextBox();
            this.zMin = new System.Windows.Forms.TextBox();
            this.yMin = new System.Windows.Forms.TextBox();
            this.xMin = new System.Windows.Forms.TextBox();
            this.xEksen = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.zEksen = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.yEksen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noktaToplam = new System.Windows.Forms.TextBox();
            this.egriliXekseni = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.aktifButonNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arduinoCihaz = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.butonDegistir_Panel = new System.Windows.Forms.Panel();
            this.btnBasiliTuttur = new System.Windows.Forms.CheckBox();
            this.basildiysaButon = new System.Windows.Forms.TextBox();
            this.degistirButon = new System.Windows.Forms.TextBox();
            this.iptalBtn_Buton = new System.Windows.Forms.Button();
            this.degistirBtn_Buton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.butonlar = new System.Windows.Forms.TreeView();
            this.butonlariSifirla = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.girdiler = new System.Windows.Forms.GroupBox();
            this.ayarYukle = new System.Windows.Forms.Button();
            this.ayarKaydet = new System.Windows.Forms.Button();
            this.ayarSifirla = new System.Windows.Forms.Button();
            this.dosyaAdi = new System.Windows.Forms.Label();
            this.baglanti1.SuspendLayout();
            this.arduino.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EgriPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.butonDegistir_Panel.SuspendLayout();
            this.girdiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // guncelle
            // 
            this.guncelle.Enabled = true;
            this.guncelle.Interval = 2;
            this.guncelle.Tick += new System.EventHandler(this.Guncelle_Tick);
            // 
            // aygitKimlik
            // 
            this.aygitKimlik.BackColor = System.Drawing.Color.White;
            this.aygitKimlik.Location = new System.Drawing.Point(121, 20);
            this.aygitKimlik.MaxLength = 2;
            this.aygitKimlik.Name = "aygitKimlik";
            this.aygitKimlik.Size = new System.Drawing.Size(75, 26);
            this.aygitKimlik.TabIndex = 0;
            this.aygitKimlik.Text = "1";
            this.aygitKimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SayiGiris_KeyPress);
            // 
            // etiket1
            // 
            this.etiket1.AutoSize = true;
            this.etiket1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.etiket1.Location = new System.Drawing.Point(12, 25);
            this.etiket1.Name = "etiket1";
            this.etiket1.Size = new System.Drawing.Size(63, 16);
            this.etiket1.TabIndex = 1;
            this.etiket1.Text = "Aygit (id):";
            // 
            // aygitaBaglan
            // 
            this.aygitaBaglan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.aygitaBaglan.Location = new System.Drawing.Point(121, 50);
            this.aygitaBaglan.Name = "aygitaBaglan";
            this.aygitaBaglan.Size = new System.Drawing.Size(75, 38);
            this.aygitaBaglan.TabIndex = 2;
            this.aygitaBaglan.Text = "Baslat";
            this.aygitaBaglan.UseVisualStyleBackColor = false;
            this.aygitaBaglan.Click += new System.EventHandler(this.AygitaBaglan_Click);
            // 
            // baglanti1
            // 
            this.baglanti1.Controls.Add(this.aygitKimlik);
            this.baglanti1.Controls.Add(this.vJoyDurum);
            this.baglanti1.Controls.Add(this.etiket1);
            this.baglanti1.Controls.Add(this.aygitaBaglan);
            this.baglanti1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.baglanti1.ForeColor = System.Drawing.Color.White;
            this.baglanti1.Location = new System.Drawing.Point(12, 12);
            this.baglanti1.Name = "baglanti1";
            this.baglanti1.Size = new System.Drawing.Size(208, 93);
            this.baglanti1.TabIndex = 3;
            this.baglanti1.TabStop = false;
            this.baglanti1.Text = "Baglanti";
            // 
            // vJoyDurum
            // 
            this.vJoyDurum.BackColor = System.Drawing.Color.White;
            this.vJoyDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.vJoyDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.vJoyDurum.Location = new System.Drawing.Point(15, 50);
            this.vJoyDurum.Name = "vJoyDurum";
            this.vJoyDurum.Size = new System.Drawing.Size(100, 38);
            this.vJoyDurum.TabIndex = 1;
            this.vJoyDurum.Text = "---";
            this.vJoyDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // etiket2
            // 
            this.etiket2.AutoSize = true;
            this.etiket2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic);
            this.etiket2.ForeColor = System.Drawing.Color.White;
            this.etiket2.Location = new System.Drawing.Point(9, 375);
            this.etiket2.Name = "etiket2";
            this.etiket2.Size = new System.Drawing.Size(190, 16);
            this.etiket2.TabIndex = 1;
            this.etiket2.Text = "Developed by Halil Emre Yildiz.";
            // 
            // arduino
            // 
            this.arduino.Controls.Add(this.girdiCihazi);
            this.arduino.Controls.Add(this.arduinoGirisler);
            this.arduino.Controls.Add(this.label10);
            this.arduino.Controls.Add(this.arduinoDurum);
            this.arduino.Controls.Add(this.arduinoHiz);
            this.arduino.Controls.Add(this.etiket4);
            this.arduino.Controls.Add(this.etiket3);
            this.arduino.Controls.Add(this.arduinoBaglan);
            this.arduino.Enabled = false;
            this.arduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.arduino.ForeColor = System.Drawing.Color.White;
            this.arduino.Location = new System.Drawing.Point(12, 106);
            this.arduino.Name = "arduino";
            this.arduino.Size = new System.Drawing.Size(208, 162);
            this.arduino.TabIndex = 3;
            this.arduino.TabStop = false;
            this.arduino.Text = "Arduino Kontrol";
            // 
            // girdiCihazi
            // 
            this.girdiCihazi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.girdiCihazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.girdiCihazi.FormattingEnabled = true;
            this.girdiCihazi.Items.AddRange(new object[] {
            "Hey Direksiyon"});
            this.girdiCihazi.Location = new System.Drawing.Point(63, 89);
            this.girdiCihazi.Name = "girdiCihazi";
            this.girdiCihazi.Size = new System.Drawing.Size(133, 24);
            this.girdiCihazi.TabIndex = 5;
            // 
            // arduinoGirisler
            // 
            this.arduinoGirisler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arduinoGirisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.arduinoGirisler.FormattingEnabled = true;
            this.arduinoGirisler.Location = new System.Drawing.Point(121, 57);
            this.arduinoGirisler.Name = "arduinoGirisler";
            this.arduinoGirisler.Size = new System.Drawing.Size(75, 26);
            this.arduinoGirisler.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cihaz:";
            // 
            // arduinoDurum
            // 
            this.arduinoDurum.BackColor = System.Drawing.Color.White;
            this.arduinoDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.arduinoDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.arduinoDurum.Location = new System.Drawing.Point(15, 119);
            this.arduinoDurum.Name = "arduinoDurum";
            this.arduinoDurum.Size = new System.Drawing.Size(100, 38);
            this.arduinoDurum.TabIndex = 1;
            this.arduinoDurum.Text = "---";
            this.arduinoDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arduinoHiz
            // 
            this.arduinoHiz.BackColor = System.Drawing.Color.White;
            this.arduinoHiz.Location = new System.Drawing.Point(121, 25);
            this.arduinoHiz.MaxLength = 10;
            this.arduinoHiz.Name = "arduinoHiz";
            this.arduinoHiz.Size = new System.Drawing.Size(75, 26);
            this.arduinoHiz.TabIndex = 0;
            this.arduinoHiz.Text = "9600";
            // 
            // etiket4
            // 
            this.etiket4.AutoSize = true;
            this.etiket4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.etiket4.ForeColor = System.Drawing.Color.White;
            this.etiket4.Location = new System.Drawing.Point(12, 62);
            this.etiket4.Name = "etiket4";
            this.etiket4.Size = new System.Drawing.Size(73, 16);
            this.etiket4.TabIndex = 1;
            this.etiket4.Text = "Giris (Port):";
            // 
            // etiket3
            // 
            this.etiket3.AutoSize = true;
            this.etiket3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.etiket3.ForeColor = System.Drawing.Color.White;
            this.etiket3.Location = new System.Drawing.Point(12, 31);
            this.etiket3.Name = "etiket3";
            this.etiket3.Size = new System.Drawing.Size(109, 16);
            this.etiket3.TabIndex = 1;
            this.etiket3.Text = "Hiz (BoundRate):";
            // 
            // arduinoBaglan
            // 
            this.arduinoBaglan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.arduinoBaglan.Location = new System.Drawing.Point(121, 119);
            this.arduinoBaglan.Name = "arduinoBaglan";
            this.arduinoBaglan.Size = new System.Drawing.Size(75, 38);
            this.arduinoBaglan.TabIndex = 2;
            this.arduinoBaglan.Text = "Baslat";
            this.arduinoBaglan.UseVisualStyleBackColor = false;
            this.arduinoBaglan.Click += new System.EventHandler(this.ArduinoBaglan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EgriPanel);
            this.panel1.Controls.Add(this.EgriDuzenle);
            this.panel1.Controls.Add(this.zMax);
            this.panel1.Controls.Add(this.yMax);
            this.panel1.Controls.Add(this.xMax);
            this.panel1.Controls.Add(this.zMin);
            this.panel1.Controls.Add(this.yMin);
            this.panel1.Controls.Add(this.xMin);
            this.panel1.Controls.Add(this.xEksen);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.zEksen);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.yEksen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.noktaToplam);
            this.panel1.Controls.Add(this.egriliXekseni);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(13, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 164);
            this.panel1.TabIndex = 4;
            // 
            // EgriPanel
            // 
            this.EgriPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EgriPanel.Controls.Add(this.seciliNoktaDeger);
            this.EgriPanel.Controls.Add(this.maxNDegerAzalt);
            this.EgriPanel.Controls.Add(this.maxNDegerArtir);
            this.EgriPanel.Controls.Add(this.egridenCik);
            this.EgriPanel.Controls.Add(this.label6);
            this.EgriPanel.Controls.Add(this.noktaAzalt);
            this.EgriPanel.Controls.Add(this.noktaArtir);
            this.EgriPanel.Controls.Add(this.direksiyonYeniDeger);
            this.EgriPanel.Controls.Add(this.direksiyonYuzdesi);
            this.EgriPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EgriPanel.Location = new System.Drawing.Point(0, 6);
            this.EgriPanel.Name = "EgriPanel";
            this.EgriPanel.Size = new System.Drawing.Size(303, 158);
            this.EgriPanel.TabIndex = 5;
            this.EgriPanel.Visible = false;
            this.EgriPanel.VisibleChanged += new System.EventHandler(this.EgriPanel_VisibleChanged);
            this.EgriPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EgriPanel_Paint);
            this.EgriPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EgriPanel_MouseDown);
            this.EgriPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EgriPanel_MouseMove);
            this.EgriPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EgriPanel_MouseUp);
            // 
            // seciliNoktaDeger
            // 
            this.seciliNoktaDeger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.seciliNoktaDeger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seciliNoktaDeger.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.seciliNoktaDeger.ForeColor = System.Drawing.Color.Black;
            this.seciliNoktaDeger.Location = new System.Drawing.Point(62, 139);
            this.seciliNoktaDeger.Name = "seciliNoktaDeger";
            this.seciliNoktaDeger.Size = new System.Drawing.Size(28, 15);
            this.seciliNoktaDeger.TabIndex = 10;
            this.seciliNoktaDeger.Text = "1";
            this.seciliNoktaDeger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seciliNoktaDeger.DoubleClick += new System.EventHandler(this.SeciliNoktaDeger_DoubleClick);
            // 
            // maxNDegerAzalt
            // 
            this.maxNDegerAzalt.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.maxNDegerAzalt.Location = new System.Drawing.Point(51, 139);
            this.maxNDegerAzalt.Name = "maxNDegerAzalt";
            this.maxNDegerAzalt.Size = new System.Drawing.Size(10, 17);
            this.maxNDegerAzalt.TabIndex = 9;
            this.maxNDegerAzalt.Text = "v";
            this.maxNDegerAzalt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maxNDegerAzalt.UseVisualStyleBackColor = true;
            this.maxNDegerAzalt.Click += new System.EventHandler(this.MaxNDegerAzalt_Click);
            // 
            // maxNDegerArtir
            // 
            this.maxNDegerArtir.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.maxNDegerArtir.Location = new System.Drawing.Point(41, 139);
            this.maxNDegerArtir.Name = "maxNDegerArtir";
            this.maxNDegerArtir.Size = new System.Drawing.Size(10, 17);
            this.maxNDegerArtir.TabIndex = 8;
            this.maxNDegerArtir.Text = "^";
            this.maxNDegerArtir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maxNDegerArtir.UseVisualStyleBackColor = true;
            this.maxNDegerArtir.Click += new System.EventHandler(this.MaxNDegerArtir_Click);
            // 
            // egridenCik
            // 
            this.egridenCik.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.egridenCik.Location = new System.Drawing.Point(1, 139);
            this.egridenCik.Name = "egridenCik";
            this.egridenCik.Size = new System.Drawing.Size(17, 17);
            this.egridenCik.TabIndex = 7;
            this.egridenCik.Text = "x";
            this.egridenCik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.egridenCik.UseVisualStyleBackColor = true;
            this.egridenCik.Click += new System.EventHandler(this.EgriPaneliKapat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(169, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Developed by @Jahn_Star";
            // 
            // noktaAzalt
            // 
            this.noktaAzalt.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.noktaAzalt.Location = new System.Drawing.Point(21, 139);
            this.noktaAzalt.Name = "noktaAzalt";
            this.noktaAzalt.Size = new System.Drawing.Size(10, 17);
            this.noktaAzalt.TabIndex = 6;
            this.noktaAzalt.Text = "<";
            this.noktaAzalt.UseVisualStyleBackColor = true;
            this.noktaAzalt.Click += new System.EventHandler(this.NoktaAzalt_Click);
            // 
            // noktaArtir
            // 
            this.noktaArtir.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.noktaArtir.Location = new System.Drawing.Point(31, 139);
            this.noktaArtir.Name = "noktaArtir";
            this.noktaArtir.Size = new System.Drawing.Size(10, 17);
            this.noktaArtir.TabIndex = 5;
            this.noktaArtir.Text = ">";
            this.noktaArtir.UseVisualStyleBackColor = true;
            this.noktaArtir.Click += new System.EventHandler(this.NoktaArtir_Click);
            // 
            // direksiyonYeniDeger
            // 
            this.direksiyonYeniDeger.BackColor = System.Drawing.Color.SkyBlue;
            this.direksiyonYeniDeger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.direksiyonYeniDeger.Font = new System.Drawing.Font("Arial", 8F);
            this.direksiyonYeniDeger.Location = new System.Drawing.Point(28, 0);
            this.direksiyonYeniDeger.Name = "direksiyonYeniDeger";
            this.direksiyonYeniDeger.Size = new System.Drawing.Size(30, 15);
            this.direksiyonYeniDeger.TabIndex = 4;
            this.direksiyonYeniDeger.Text = "1.00";
            this.direksiyonYeniDeger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // direksiyonYuzdesi
            // 
            this.direksiyonYuzdesi.BackColor = System.Drawing.Color.LawnGreen;
            this.direksiyonYuzdesi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.direksiyonYuzdesi.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.direksiyonYuzdesi.ForeColor = System.Drawing.Color.Black;
            this.direksiyonYuzdesi.Location = new System.Drawing.Point(0, 0);
            this.direksiyonYuzdesi.Name = "direksiyonYuzdesi";
            this.direksiyonYuzdesi.Size = new System.Drawing.Size(28, 15);
            this.direksiyonYuzdesi.TabIndex = 2;
            this.direksiyonYuzdesi.Text = "%00";
            this.direksiyonYuzdesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EgriDuzenle
            // 
            this.EgriDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.EgriDuzenle.Location = new System.Drawing.Point(120, 30);
            this.EgriDuzenle.Name = "EgriDuzenle";
            this.EgriDuzenle.Size = new System.Drawing.Size(122, 23);
            this.EgriDuzenle.TabIndex = 2;
            this.EgriDuzenle.Text = "Egri Modu";
            this.EgriDuzenle.UseVisualStyleBackColor = true;
            this.EgriDuzenle.Click += new System.EventHandler(this.EgriDuzenle_Click);
            // 
            // zMax
            // 
            this.zMax.BackColor = System.Drawing.Color.White;
            this.zMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.zMax.Location = new System.Drawing.Point(252, 128);
            this.zMax.MaxLength = 5;
            this.zMax.Name = "zMax";
            this.zMax.Size = new System.Drawing.Size(40, 23);
            this.zMax.TabIndex = 0;
            this.zMax.Text = "1024";
            this.zMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SayiGiris_KeyPress);
            // 
            // yMax
            // 
            this.yMax.BackColor = System.Drawing.Color.White;
            this.yMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.yMax.Location = new System.Drawing.Point(252, 103);
            this.yMax.MaxLength = 5;
            this.yMax.Name = "yMax";
            this.yMax.Size = new System.Drawing.Size(40, 23);
            this.yMax.TabIndex = 0;
            this.yMax.Text = "1024";
            this.yMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SayiGiris_KeyPress);
            // 
            // xMax
            // 
            this.xMax.BackColor = System.Drawing.Color.White;
            this.xMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xMax.Location = new System.Drawing.Point(252, 59);
            this.xMax.MaxLength = 5;
            this.xMax.Name = "xMax";
            this.xMax.Size = new System.Drawing.Size(40, 23);
            this.xMax.TabIndex = 0;
            this.xMax.Text = "1024";
            this.xMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SayiGiris_KeyPress);
            // 
            // zMin
            // 
            this.zMin.BackColor = System.Drawing.Color.White;
            this.zMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.zMin.Location = new System.Drawing.Point(159, 128);
            this.zMin.MaxLength = 5;
            this.zMin.Name = "zMin";
            this.zMin.Size = new System.Drawing.Size(40, 23);
            this.zMin.TabIndex = 0;
            this.zMin.Text = "0";
            this.zMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SayiGiris_KeyPress);
            // 
            // yMin
            // 
            this.yMin.BackColor = System.Drawing.Color.White;
            this.yMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.yMin.Location = new System.Drawing.Point(159, 103);
            this.yMin.MaxLength = 5;
            this.yMin.Name = "yMin";
            this.yMin.Size = new System.Drawing.Size(40, 23);
            this.yMin.TabIndex = 0;
            this.yMin.Text = "0";
            this.yMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SayiGiris_KeyPress);
            // 
            // xMin
            // 
            this.xMin.BackColor = System.Drawing.Color.White;
            this.xMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xMin.Location = new System.Drawing.Point(159, 59);
            this.xMin.MaxLength = 5;
            this.xMin.Name = "xMin";
            this.xMin.Size = new System.Drawing.Size(40, 23);
            this.xMin.TabIndex = 0;
            this.xMin.Text = "0";
            this.xMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SayiGiris_KeyPress);
            // 
            // xEksen
            // 
            this.xEksen.AutoSize = true;
            this.xEksen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.xEksen.Location = new System.Drawing.Point(29, 59);
            this.xEksen.Name = "xEksen";
            this.xEksen.Size = new System.Drawing.Size(16, 17);
            this.xEksen.TabIndex = 2;
            this.xEksen.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(10, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gaz, Fren ve Debriyaj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Direksiyon";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(117, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Min:";
            // 
            // zEksen
            // 
            this.zEksen.AutoSize = true;
            this.zEksen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zEksen.Location = new System.Drawing.Point(29, 131);
            this.zEksen.Name = "zEksen";
            this.zEksen.Size = new System.Drawing.Size(16, 17);
            this.zEksen.TabIndex = 1;
            this.zEksen.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(117, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Min:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(205, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(10, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Z:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(205, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Max:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(117, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Min:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(205, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Max:";
            // 
            // yEksen
            // 
            this.yEksen.AutoSize = true;
            this.yEksen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yEksen.Location = new System.Drawing.Point(29, 106);
            this.yEksen.Name = "yEksen";
            this.yEksen.Size = new System.Drawing.Size(16, 17);
            this.yEksen.TabIndex = 1;
            this.yEksen.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X: ";
            // 
            // noktaToplam
            // 
            this.noktaToplam.BackColor = System.Drawing.Color.White;
            this.noktaToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.noktaToplam.Location = new System.Drawing.Point(252, 30);
            this.noktaToplam.MaxLength = 5;
            this.noktaToplam.Name = "noktaToplam";
            this.noktaToplam.Size = new System.Drawing.Size(40, 23);
            this.noktaToplam.TabIndex = 6;
            this.noktaToplam.Text = "2";
            // 
            // egriliXekseni
            // 
            this.egriliXekseni.AutoSize = true;
            this.egriliXekseni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.egriliXekseni.Location = new System.Drawing.Point(54, 33);
            this.egriliXekseni.Name = "egriliXekseni";
            this.egriliXekseni.Size = new System.Drawing.Size(16, 17);
            this.egriliXekseni.TabIndex = 8;
            this.egriliXekseni.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(10, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Egri X: ";
            // 
            // aktifButonNum
            // 
            this.aktifButonNum.AutoSize = true;
            this.aktifButonNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.aktifButonNum.Location = new System.Drawing.Point(129, 8);
            this.aktifButonNum.Name = "aktifButonNum";
            this.aktifButonNum.Size = new System.Drawing.Size(17, 19);
            this.aktifButonNum.TabIndex = 1;
            this.aktifButonNum.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktif Vites (Buton):";
            // 
            // arduinoCihaz
            // 
            this.arduinoCihaz.ReadTimeout = 1000;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.butonDegistir_Panel);
            this.panel2.Controls.Add(this.butonlar);
            this.panel2.Controls.Add(this.butonlariSifirla);
            this.panel2.Controls.Add(this.aktifButonNum);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 182);
            this.panel2.TabIndex = 4;
            // 
            // butonDegistir_Panel
            // 
            this.butonDegistir_Panel.BackColor = System.Drawing.Color.White;
            this.butonDegistir_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.butonDegistir_Panel.Controls.Add(this.btnBasiliTuttur);
            this.butonDegistir_Panel.Controls.Add(this.basildiysaButon);
            this.butonDegistir_Panel.Controls.Add(this.degistirButon);
            this.butonDegistir_Panel.Controls.Add(this.iptalBtn_Buton);
            this.butonDegistir_Panel.Controls.Add(this.degistirBtn_Buton);
            this.butonDegistir_Panel.Controls.Add(this.label14);
            this.butonDegistir_Panel.Controls.Add(this.label12);
            this.butonDegistir_Panel.Location = new System.Drawing.Point(21, 61);
            this.butonDegistir_Panel.Name = "butonDegistir_Panel";
            this.butonDegistir_Panel.Size = new System.Drawing.Size(255, 100);
            this.butonDegistir_Panel.TabIndex = 3;
            this.butonDegistir_Panel.Visible = false;
            // 
            // btnBasiliTuttur
            // 
            this.btnBasiliTuttur.AutoSize = true;
            this.btnBasiliTuttur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBasiliTuttur.Location = new System.Drawing.Point(145, 37);
            this.btnBasiliTuttur.Name = "btnBasiliTuttur";
            this.btnBasiliTuttur.Size = new System.Drawing.Size(96, 20);
            this.btnBasiliTuttur.TabIndex = 2;
            this.btnBasiliTuttur.Text = "Basili Tuttur";
            this.btnBasiliTuttur.UseVisualStyleBackColor = true;
            // 
            // basildiysaButon
            // 
            this.basildiysaButon.BackColor = System.Drawing.Color.White;
            this.basildiysaButon.Enabled = false;
            this.basildiysaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.basildiysaButon.Location = new System.Drawing.Point(10, 9);
            this.basildiysaButon.MaxLength = 2;
            this.basildiysaButon.Name = "basildiysaButon";
            this.basildiysaButon.Size = new System.Drawing.Size(59, 22);
            this.basildiysaButon.TabIndex = 0;
            this.basildiysaButon.Text = "0";
            this.basildiysaButon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SayiGiris_KeyPress);
            // 
            // degistirButon
            // 
            this.degistirButon.BackColor = System.Drawing.Color.White;
            this.degistirButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.degistirButon.Location = new System.Drawing.Point(10, 35);
            this.degistirButon.MaxLength = 2;
            this.degistirButon.Name = "degistirButon";
            this.degistirButon.Size = new System.Drawing.Size(59, 22);
            this.degistirButon.TabIndex = 0;
            this.degistirButon.Text = "0";
            this.degistirButon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButonSayiGiris_KeyPress);
            // 
            // iptalBtn_Buton
            // 
            this.iptalBtn_Buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.iptalBtn_Buton.Location = new System.Drawing.Point(127, 65);
            this.iptalBtn_Buton.Name = "iptalBtn_Buton";
            this.iptalBtn_Buton.Size = new System.Drawing.Size(114, 26);
            this.iptalBtn_Buton.TabIndex = 0;
            this.iptalBtn_Buton.Text = "Iptal";
            this.iptalBtn_Buton.UseVisualStyleBackColor = true;
            this.iptalBtn_Buton.Click += new System.EventHandler(this.IptalBtn_BtnPnl_Click);
            // 
            // degistirBtn_Buton
            // 
            this.degistirBtn_Buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.degistirBtn_Buton.Location = new System.Drawing.Point(10, 65);
            this.degistirBtn_Buton.Name = "degistirBtn_Buton";
            this.degistirBtn_Buton.Size = new System.Drawing.Size(114, 26);
            this.degistirBtn_Buton.TabIndex = 0;
            this.degistirBtn_Buton.Text = "Degistir";
            this.degistirBtn_Buton.UseVisualStyleBackColor = true;
            this.degistirBtn_Buton.Click += new System.EventHandler(this.DegistirBtn_BtnPnl_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.Location = new System.Drawing.Point(75, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = ": Donustur";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(75, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = ": Basildiysa";
            // 
            // butonlar
            // 
            this.butonlar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butonlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.butonlar.Location = new System.Drawing.Point(12, 50);
            this.butonlar.Name = "butonlar";
            this.butonlar.Size = new System.Drawing.Size(280, 120);
            this.butonlar.TabIndex = 2;
            this.butonlar.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Butonlar_NodeMouseDoubleClick);
            // 
            // butonlariSifirla
            // 
            this.butonlariSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.butonlariSifirla.Location = new System.Drawing.Point(239, 21);
            this.butonlariSifirla.Name = "butonlariSifirla";
            this.butonlariSifirla.Size = new System.Drawing.Size(53, 23);
            this.butonlariSifirla.TabIndex = 0;
            this.butonlariSifirla.Text = "Sifirla";
            this.butonlariSifirla.UseVisualStyleBackColor = true;
            this.butonlariSifirla.Click += new System.EventHandler(this.Sifirla_BtnPnl_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(9, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kullanilabilir Vites (Butonlar):";
            // 
            // girdiler
            // 
            this.girdiler.Controls.Add(this.panel2);
            this.girdiler.Controls.Add(this.panel1);
            this.girdiler.Enabled = false;
            this.girdiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.girdiler.Location = new System.Drawing.Point(226, 12);
            this.girdiler.Name = "girdiler";
            this.girdiler.Size = new System.Drawing.Size(329, 378);
            this.girdiler.TabIndex = 3;
            this.girdiler.TabStop = false;
            this.girdiler.Text = "Girdiler";
            // 
            // ayarYukle
            // 
            this.ayarYukle.BackColor = System.Drawing.Color.White;
            this.ayarYukle.Enabled = false;
            this.ayarYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ayarYukle.Location = new System.Drawing.Point(12, 306);
            this.ayarYukle.Name = "ayarYukle";
            this.ayarYukle.Size = new System.Drawing.Size(102, 36);
            this.ayarYukle.TabIndex = 4;
            this.ayarYukle.Text = "Ac";
            this.ayarYukle.UseVisualStyleBackColor = false;
            this.ayarYukle.Click += new System.EventHandler(this.AyarYukle_Click);
            // 
            // ayarKaydet
            // 
            this.ayarKaydet.BackColor = System.Drawing.Color.White;
            this.ayarKaydet.Enabled = false;
            this.ayarKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ayarKaydet.Location = new System.Drawing.Point(118, 306);
            this.ayarKaydet.Name = "ayarKaydet";
            this.ayarKaydet.Size = new System.Drawing.Size(102, 36);
            this.ayarKaydet.TabIndex = 5;
            this.ayarKaydet.Text = "Kaydet";
            this.ayarKaydet.UseVisualStyleBackColor = false;
            this.ayarKaydet.Click += new System.EventHandler(this.AyarKaydet_Click);
            // 
            // ayarSifirla
            // 
            this.ayarSifirla.BackColor = System.Drawing.Color.White;
            this.ayarSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ayarSifirla.Location = new System.Drawing.Point(12, 346);
            this.ayarSifirla.Name = "ayarSifirla";
            this.ayarSifirla.Size = new System.Drawing.Size(208, 26);
            this.ayarSifirla.TabIndex = 6;
            this.ayarSifirla.Text = "Sifirla / Yeniden Baslat";
            this.ayarSifirla.UseVisualStyleBackColor = false;
            this.ayarSifirla.Click += new System.EventHandler(this.AyarSifirla_Click);
            // 
            // dosyaAdi
            // 
            this.dosyaAdi.BackColor = System.Drawing.Color.White;
            this.dosyaAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dosyaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosyaAdi.Location = new System.Drawing.Point(12, 275);
            this.dosyaAdi.Name = "dosyaAdi";
            this.dosyaAdi.Size = new System.Drawing.Size(208, 26);
            this.dosyaAdi.TabIndex = 7;
            this.dosyaAdi.Text = "-Hazir Ayar-";
            this.dosyaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeyVJC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(566, 399);
            this.Controls.Add(this.dosyaAdi);
            this.Controls.Add(this.ayarSifirla);
            this.Controls.Add(this.ayarKaydet);
            this.Controls.Add(this.ayarYukle);
            this.Controls.Add(this.girdiler);
            this.Controls.Add(this.arduino);
            this.Controls.Add(this.baglanti1);
            this.Controls.Add(this.etiket2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeyVJC";
            this.Tag = "";
            this.Text = "Hey Virtual Joy - Feeder v1.9.1";
            this.Load += new System.EventHandler(this.HeyVJC_Load);
            this.baglanti1.ResumeLayout(false);
            this.baglanti1.PerformLayout();
            this.arduino.ResumeLayout(false);
            this.arduino.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EgriPanel.ResumeLayout(false);
            this.EgriPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.butonDegistir_Panel.ResumeLayout(false);
            this.butonDegistir_Panel.PerformLayout();
            this.girdiler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer guncelle;
        private System.Windows.Forms.TextBox aygitKimlik;
        private System.Windows.Forms.Label etiket1;
        private System.Windows.Forms.Button aygitaBaglan;
        private System.Windows.Forms.GroupBox baglanti1;
        private System.Windows.Forms.Label etiket2;
        private System.Windows.Forms.GroupBox arduino;
        private System.Windows.Forms.TextBox arduinoHiz;
        private System.Windows.Forms.Label etiket3;
        private System.Windows.Forms.Button arduinoBaglan;
        private System.IO.Ports.SerialPort arduinoCihaz;
        private System.Windows.Forms.ComboBox arduinoGirisler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zEksen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label yEksen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xEksen;
        private System.Windows.Forms.Label aktifButonNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView butonlar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel butonDegistir_Panel;
        private System.Windows.Forms.Button iptalBtn_Buton;
        private System.Windows.Forms.Button degistirBtn_Buton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox degistirButon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox basildiysaButon;
        private System.Windows.Forms.Button butonlariSifirla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox girdiler;
        private System.Windows.Forms.Label vJoyDurum;
        private System.Windows.Forms.Label arduinoDurum;
        private System.Windows.Forms.ComboBox girdiCihazi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox zMax;
        private System.Windows.Forms.TextBox yMax;
        private System.Windows.Forms.TextBox xMax;
        private System.Windows.Forms.TextBox zMin;
        private System.Windows.Forms.TextBox yMin;
        private System.Windows.Forms.TextBox xMin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button EgriDuzenle;
        private System.Windows.Forms.Panel EgriPanel;
        private System.Windows.Forms.Label direksiyonYuzdesi;
        private System.Windows.Forms.Label direksiyonYeniDeger;
        private System.Windows.Forms.Button noktaAzalt;
        private System.Windows.Forms.Button noktaArtir;
        private System.Windows.Forms.TextBox noktaToplam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label egriliXekseni;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button egridenCik;
        private System.Windows.Forms.Button maxNDegerArtir;
        private System.Windows.Forms.Button maxNDegerAzalt;
        private System.Windows.Forms.Button ayarYukle;
        private System.Windows.Forms.Button ayarKaydet;
        private System.Windows.Forms.Button ayarSifirla;
        private System.Windows.Forms.Label seciliNoktaDeger;
        private System.Windows.Forms.CheckBox btnBasiliTuttur;
        private System.Windows.Forms.Label dosyaAdi;
        private System.Windows.Forms.Label etiket4;
    }
}

