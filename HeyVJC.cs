using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hey.Math;

using vJoyInterfaceWrap;
// Developed by Halil Emre Yildiz.
namespace HeyVJoyController
{
    public partial class HeyVJC : Form
    {
        bool vJoyAygitaBaglanildi;
        vJoy joystick;
        uint kimlik;
        uint toplamArduinoGiris;
        public HeyVJC()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(HeyVJC_MouseWheel);
        }
        private void HeyVJC_Load(object sender, EventArgs e)
        {
            // Arduino
            toplamArduinoGiris = (uint)SerialPort.GetPortNames().Length;
            foreach (string port in SerialPort.GetPortNames())
            {
                bool girisVar = false;
                foreach (string giris in arduinoGirisler.Items) if (port == giris) girisVar = true;
                if (!girisVar) arduinoGirisler.Items.Add(port);
            }

            if (girdiCihazi.Items.Count > 0) girdiCihazi.SelectedItem = girdiCihazi.Items[0];
        }
        int vjoyMaxAxis;
        private void AygitaBaglan_Click(object sender, EventArgs e)
        {
            if (toplamArduinoGiris > 0) arduinoGirisler.SelectedItem = arduinoGirisler.Items[0];
            kimlik = uint.Parse(aygitKimlik.Text);
            if (kimlik <= 0 || kimlik > 15)
            {
                HataGoster("Gecersiz vJoy aygit kimligi = " + kimlik);
                return;
            }

            joystick = new vJoy();

            if (joystick.vJoyEnabled())
            {
                VjdStat durum = joystick.GetVJDStatus(kimlik);

                if (durum != VjdStat.VJD_STAT_BUSY && durum != VjdStat.VJD_STAT_MISS)
                {
                    vJoyAygitaBaglanildi = true;
                    vJoyDurum.ForeColor = Color.Green;
                    vJoyDurum.Text = "Basarili";
                    arduino.Enabled = true;
                    ayarYukle.Enabled = ayarKaydet.Enabled = true; //yeni

                    long max = 0;
                    joystick.GetVJDAxisMax(kimlik, HID_USAGES.HID_USAGE_X, ref max);
                    vjoyMaxAxis = (int)max;
                }
                else if (durum == VjdStat.VJD_STAT_BUSY) HataGoster("vJoy aygitini (" + kimlik + ") başka bir besleyici kullaniyor");
                else if (durum == VjdStat.VJD_STAT_MISS) HataGoster("vJoy aygiti (" + kimlik + ") kurulu degil yada etkin degil");
                else HataGoster("vJoy aygitina (" + kimlik + ") erisilemiyor");
            }
            else HataGoster("vJoy surucusu etkin degil");
            // Butonlar
            degistirilenButonlar = new string[joystick.GetVJDButtonNumber(kimlik)];
            for (int i = 0; i < degistirilenButonlar.Length; i++)
            {
                degistirilenButonlar[i] = i+"";
                butonlar.Nodes.Add("Gercek Buton:" + i + " / Uygulanan Buton:" + i);
            }
        }
        private void HataGoster(string hataMesaji)
        {
            arduino.Enabled = false;
            vJoyDurum.ForeColor = Color.Red;
            vJoyDurum.Text = "Basarisiz";
            MessageBox.Show(hataMesaji, "vJoy Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private int oncekiButon;
        private void Guncelle_Tick(object sender, EventArgs e)
        {
            uint mevcutGirisler = (uint)SerialPort.GetPortNames().Length;
            if (toplamArduinoGiris != mevcutGirisler) // Port bul
            {
                arduinoBaglanildi = false;

                arduinoGirisler.Items.Clear();
                foreach (string port in SerialPort.GetPortNames())
                {
                    bool girisVar = false;
                    foreach (string giris in arduinoGirisler.Items) if (port == giris) girisVar = true;
                    if (!girisVar) arduinoGirisler.Items.Add(port);
                }
                toplamArduinoGiris = mevcutGirisler;
                if (toplamArduinoGiris > 0) arduinoGirisler.SelectedItem = arduinoGirisler.Items[0];
            }
            else if (arduinoBaglanildi && vJoyAygitaBaglanildi && joystick.AcquireVJD(kimlik))
            {
                try
                {
                    if (Form.ActiveForm == this) this.Refresh(); // Formu yenile

                    string alinanVeri = arduinoCihaz.ReadLine() + "";
                    if (alinanVeri.Contains("a")) // Deger atamalari
                    {
                        // Gaz,Fren
                        float yEkseni = int.Parse(alinanVeri.Split('c')[1].Split('+')[0]);
                        float zEkseni = int.Parse(alinanVeri.Split('c')[1].Split('+')[1].Split('*')[0]);

                        yEksen.Text = yEkseni + ""; // Saf Deger
                        EksenDonustur(ref yEkseni, yMax.Text, yMin.Text, vjoyMaxAxis);
                        //yEksen.Text = yEkseni + ""; // Islenmis Deger
                        Y = (int)yEkseni;

                        zEksen.Text = zEkseni + ""; // Saf Deger
                        EksenDonustur(ref zEkseni, zMax.Text, zMin.Text, vjoyMaxAxis);
                        //zEksen.Text = zEkseni + ""; // Islenmis Deger
                        Z = (int)zEkseni;

                        // Vites
                        string basilanButon = alinanVeri.Split('b')[1].Split('c')[0];
                        int butonBastir = basilanButon != "-" ? int.Parse(degistirilenButonlar[int.Parse(basilanButon)].Split(' ')[0]) : 0;

                        if (basilanButon != "-" && oncekiButon != butonBastir)
                        {
                            SetButton((uint)oncekiButon, false);
                            oncekiButon = int.Parse(basilanButon);
                        }
                        else SetButton((uint)butonBastir, false);
                        aktifButonNum.Text = butonBastir + "";

                        SetButton((uint)oncekiButon, basilanButon != "-" ? true : false); // onceki buton bastir yada birak
                        if (degistirilenButonlar[oncekiButon].Contains(" "))
                            SetButton((uint)oncekiButon, true); // onceki buton bastir yada birak


                        //// Direksiyon
                        alinanVeri = alinanVeri.Split('a')[1].Split('b')[0];
                        float xEkseni = int.Parse(alinanVeri);
                        xEksen.Text = xEkseni + ""; // Saf Deger

                        if (!egriModu)
                        {
                            //Vjoy
                            EksenDonustur(ref xEkseni, xMax.Text, xMin.Text, vjoyMaxAxis);
                            X = (int)xEkseni;
                        }
                        else
                        {
                            // Direksiyon Yeni Deger
                            float direksiyonX = float.Parse(xEksen.Text);
                            EksenDonustur(ref direksiyonX, xMax.Text, xMin.Text, EgriPanel.Size.Width);
 
                            for (int i = 0; i < noktalar.Count-1; i++)
                            {
                                if (noktalar[i].X < direksiyonX)
                                { 
                                    if (direksiyonX+1 < noktalar[i + 1].X)
                                    {
                                        //etiket2.Text = i + " ve " + (i + 1) + " arasinda";

                                        float noktaXNormali = direksiyonX;
                                        EksenDonustur(ref noktaXNormali, noktalar[i+1].X + "", noktalar[i].X + "", 1);

                                        float nokta1 = noktaDegerleri[i];
                                        float nokta2 = noktaDegerleri[i + 1];

                                        float egriOran;
                                        // Soldayken noktalari ters cevir
                                        int topNokta = noktalar.Count;
                                        if (i < topNokta / 2) nokta1 = dikeySkalaOrani - nokta1;
                                        if (i + 1 < topNokta / 2) nokta2 = dikeySkalaOrani - nokta2;
                                        if (topNokta % 2 == 0 && i == toplamNokta / 2 - 1 && noktaXNormali < 0.5)
                                        {
                                            nokta1 = dikeySkalaOrani - noktaDegerleri[i];
                                            //etiket2.Text = noktaXNormali + ""; // tam ortada nokta yoksa
                                        }

                                        egriOran = Vektor.Vektor1_DogrusalInterpolasyon(noktaXNormali, nokta1, nokta2);
                                        direksiyonYeniDeger.Text = egriOran.ToString("0.00");

                                        float yeniXeksen = egriOran * xEkseni;
                                        egriliXekseni.Text = yeniXeksen.ToString("000");
                                        //Vjoy
                                        EksenDonustur(ref yeniXeksen, xMax.Text, xMin.Text, vjoyMaxAxis);
                                        X = (int)yeniXeksen;
                                    }
                                }
                            }
                            if (seciliNokta>-1) seciliNoktaDeger.Text = noktaDegerleri[seciliNokta] + "";
                        }

                        arduinoCihaz.DiscardInBuffer();
                    }
                }
                catch (IOException) // Arduino baglanti kesildi
                {
                    arduinoBaglanildi = false;
                    arduinoDurum.Text = "Basarisiz";
                    arduinoDurum.ForeColor = Color.Red;
                    arduinoCihaz.Close();
                    girdiler.Enabled = false;
                }
                catch (UnauthorizedAccessException)
                {
                    guncelle.Stop();
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    if (Application.MessageLoop)
                        Application.Exit();
                    else
                        Environment.Exit(1);
                }
                catch (TimeoutException)
                {
                    guncelle.Stop();
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    if (Application.MessageLoop)
                        Application.Exit();
                    else
                        Environment.Exit(1);
                }
            }
        }
        private void EksenDonustur(ref float ilkDeger, string ilkPaydaMax, string ilkPaydaMin, float yeniPayda)
        {
            if (ilkPaydaMin.Length == 0 || ilkPaydaMin == "-") ilkPaydaMin = 0 + "";
            if (ilkPaydaMax.Length == 0 || ilkPaydaMax == "-") ilkPaydaMax = 1 + "";
            int max = int.Parse(ilkPaydaMax);
            int min = int.Parse(ilkPaydaMin);
            if (ilkDeger < min) ilkDeger = min;
            if (ilkDeger > max) ilkDeger = max;

            ilkDeger += min * -1;
            max += min * -1;
            ilkDeger = yeniPayda * ilkDeger / max;
        }
        public int X
        {
            get { return X; }
            set { joystick.SetAxis(value, kimlik, HID_USAGES.HID_USAGE_X); }
        }
        public int Y
        {
            get { return Y; }
            set { joystick.SetAxis(value, kimlik, HID_USAGES.HID_USAGE_Y); }
        }
        public int Z
        {
            get { return Z; }
            set { joystick.SetAxis(value, kimlik, HID_USAGES.HID_USAGE_Z); }
        }
        public int Rx
        {
            get { return Rx; }
            set { joystick.SetAxis(value, kimlik, HID_USAGES.HID_USAGE_RX); }
        }
        public int Ry
        {
            get { return Ry; }
            set { joystick.SetAxis(value, kimlik, HID_USAGES.HID_USAGE_RY); }
        }
        public int Rz
        {
            get { return Rz; }
            set { joystick.SetAxis(value, kimlik, HID_USAGES.HID_USAGE_RZ); }
        }
        public int Slider
        {
            get { return Slider; }
            set { joystick.SetAxis(value, kimlik, HID_USAGES.HID_USAGE_SL0); }
        }
        public int Dial
        {
            get { return Dial; }
            set { joystick.SetAxis(value, kimlik, HID_USAGES.HID_USAGE_SL1); }
        }
        public void SetButton(uint button, bool pressed)
        {
            //joystick.SetBtn(true, kimlik, 1);
            joystick.SetBtn(pressed, kimlik, button);
        }
        public void SetDigitalPov(uint pov, int direction)
        {
            joystick.SetDiscPov((int)direction, kimlik, pov);
        }
        public void SetAnalogPov(int pov, int value)
        {
            joystick.SetContPov(value, kimlik, (uint)pov + 1);
        }
        bool arduinoBaglanildi;
        private void ArduinoBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                if (girdiCihazi.SelectedItem == girdiCihazi.Items[0])
                {
                    arduinoCihaz.PortName = arduinoGirisler.Text;
                    arduinoCihaz.BaudRate = int.Parse(arduinoHiz.Text);
                    if (!arduinoCihaz.IsOpen)
                    {
                        arduinoCihaz.Open();

                        for (int i = 0; i < 50; i++) arduinoCihaz.WriteLine("+");
                        arduinoBaglanildi = true;
                        arduinoDurum.Text = "Basarili";
                        arduinoDurum.ForeColor = Color.Green;
                    }
                    girdiler.Enabled = true;
                }
                else throw new ArgumentException("Girdi cihazi secili degil", "Hata");
            }
            catch (Exception hata)
            {
                arduinoBaglanildi = false;
                arduinoDurum.Text = "Basarisiz";
                arduinoDurum.ForeColor = Color.Red;

                arduinoCihaz.Close();
                MessageBox.Show(hata.Message, "Arduino Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                girdiler.Enabled = false;
            }
        }
        private void SayiGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-' && e.KeyChar != (char)Keys.OemMinus) e.Handled = true;
        }
        private void Butonlar_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btnBasiliTuttur.Checked = false;
            degistirilenButon = e.Node;
            basildiysaButon.Text = degistirilenButon.Text.Split(':')[1].Split(' ')[0];
            degistirButon.Text = degistirilenButon.Text.Split(':')[2].Split(' ')[0];
            if (degistirilenButonlar[int.Parse(basildiysaButon.Text)].Split(' ').Length > 1) btnBasiliTuttur.Checked = true;
            butonDegistir_Panel.Visible = true;
        }
        private void IptalBtn_BtnPnl_Click(object sender, EventArgs e)
        {
            butonDegistir_Panel.Visible = false;
        }
        string[] degistirilenButonlar;
        TreeNode degistirilenButon;
        private void DegistirBtn_BtnPnl_Click(object sender, EventArgs e)
        {
            if (int.Parse(degistirButon.Text) < degistirilenButonlar.Length)
            {
                int vrsylnButon = int.Parse(basildiysaButon.Text);
                degistirilenButonlar[vrsylnButon] = degistirButon.Text;
                degistirilenButonlar[vrsylnButon] += btnBasiliTuttur.Checked ? " " : "";

                degistirilenButon.Text = degistirilenButon.Text.Split(':')[0] + ":" + degistirilenButon.Text.Split(':')[1] + ":" + degistirButon.Text;
                butonDegistir_Panel.Visible = false;
            }
            else HataGoster("Kullanilabilir max buton kimligi: " + (degistirilenButonlar.Length - 1));
        }
        private void ButonSayiGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.OemMinus) e.Handled = true;
        }
        private void Sifirla_BtnPnl_Click(object sender, EventArgs e)
        {
            butonlar.Nodes.Clear();
            for (int i = 0; i < degistirilenButonlar.Length; i++)
            {
                degistirilenButonlar[i] = i + "";
                butonlar.Nodes.Add("Gercek Buton:" + i + " / Uygulanan Buton:" + i);
            }
        }
        private void EgriDuzenle_Click(object sender, EventArgs e)
        {
            EgriPanel.Visible = true;
        }
        private bool egriModu;
        public int toplamNokta;
        public int vrsylnNoktaY;
        private void EgriPanel_VisibleChanged(object sender, EventArgs e) // Egri Nokta Ekle
        {
            if (toplamNokta < 1 && int.Parse(noktaToplam.Text) < 1) noktaToplam.Text = 1 + "";
            if (noktalar.Count == 0) EgriPanel_NoktalariOlustur(int.Parse(noktaToplam.Text));
            else noktaToplam.Text = noktalar.Count + "";
            noktaToplam.Enabled = false;
        }
        private void EgriPanel_NoktalariOlustur(int toplamNokta)
        {
            toplamNokta = toplamNokta > 0 && toplamNokta < 38 ? toplamNokta : 1;
            egriModu = true;
            this.toplamNokta = toplamNokta;
            noktalar.Clear();
            if (noktalar.Count == 0) for (int i = 0; i < toplamNokta; i++)
                {
                    vrsylnNoktaY = EgriPanel.Size.Height / 2; //- EgriPanel.Size.Height / dikeySkalaOrani;
                    noktalar.Add(new Point((EgriPanel.Size.Width / toplamNokta * i) + (EgriPanel.Size.Width / toplamNokta / 2), vrsylnNoktaY));
                }
            noktaDegerleri = new float[toplamNokta];
            noktalarToplamGenislik = noktalar[noktalar.Count - 1].X - noktalar[0].X;
            Refresh();
        }
        private void SeciliNoktaDeger_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                float degerDonustur;
                if (seciliNoktaDeger.Text.Contains("-")) degerDonustur = float.Parse(seciliNoktaDeger.Text.Split('-')[1]) * -1;
                else degerDonustur = float.Parse(seciliNoktaDeger.Text);
                degerDonustur = dikeySkalaOrani - degerDonustur;

                float yeniNoktaDeger = degerDonustur - noktaDegerEki + dikeySkalaOrani / 2;
                EksenDonustur(ref yeniNoktaDeger, dikeySkalaOrani + "", "0", EgriPanel.Size.Height);

                egriModu = true;
                for (int i = 0; i < noktalar.Count; i++) noktalar[i] = new Point(noktalar[i].X, (int)yeniNoktaDeger);

                vrsylnNoktaDegistir = true;
            }
            catch (Exception hata)
            {
                HataGoster(hata.Message);
            }
            Refresh();
        }
        private List<Point> noktalar = new List<Point>();
        private float[] noktaDegerleri = new float[] { };
        private int noktalarToplamGenislik;
        private int seciliNokta = -1;
        int dikeySkalaOrani = 2;
        private void EgriPanel_Paint(object sender, PaintEventArgs e)
        {
            if (Form.ActiveForm != this) return;
            Bitmap bitmap = new Bitmap(EgriPanel.Width, EgriPanel.Height);
            Graphics g = Graphics.FromImage(bitmap);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            //Cizgiler
            for (int i = 0; i < toplamNokta * 2 + 1; i++)
            {
                // Dikey Cizgiler
                int cizgiAralik = EgriPanel.Size.Width / toplamNokta / 2;
                Pen kalem = i == toplamNokta ? new Pen(Color.Black, 1.25f) : Pens.LightGray;

                g.DrawLine(kalem, cizgiAralik * i, EgriPanel.Size.Height, cizgiAralik * i, 0);

                // Yatay Cizgiler
                if (i < EgriPanel.Size.Height / cizgiAralik)
                {
                    kalem = (i == EgriPanel.Size.Height / cizgiAralik / 2) ? new Pen(Color.Black, 1.25f) : Pens.LightGray;
                    g.DrawLine(kalem, EgriPanel.Size.Width, cizgiAralik * i + (cizgiAralik / 2),
                        0, cizgiAralik * i + (cizgiAralik / 2));

                    if (i == EgriPanel.Size.Height / cizgiAralik - 1) // Direksiyon Degeri
                    {
                        int cizgiY = cizgiAralik * i + (cizgiAralik / 2) - 5;

                        float xEkseni = int.Parse(xEksen.Text);
                        EksenDonustur(ref xEkseni, xMax.Text, xMin.Text, noktalarToplamGenislik);

                        float pozX = xEkseni + (EgriPanel.Size.Width - (noktalarToplamGenislik)) / 2;
                        g.DrawRectangle(new Pen(Color.Red, 5), new Rectangle((int)(pozX - 1.5f), cizgiY - 3, 3, 2)); // Direksiyon Kare Deger

                        direksiyonYuzdesi.Location = new Point((int)(pozX - 15), cizgiY - 19); // Direksiyon Metin Konum
                        direksiyonYeniDeger.Location = new Point((int)(pozX - 16), cizgiY - 33); // Direksiyon Metin Konum
                    }
                }
                // Metin - Nokta Degerleri Belirleme
                if (i < toplamNokta)
                    using (Font metin = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        try
                        {
                            RectangleF rectF1 = new RectangleF(noktalar[i].X - 10, 1, 24, 10);
                            float yeniNoktaDeger = noktalar[i].Y;
                            EksenDonustur(ref yeniNoktaDeger, EgriPanel.Size.Height + "", "0", dikeySkalaOrani);
                            yeniNoktaDeger = ((yeniNoktaDeger - dikeySkalaOrani / 2) * -1) + noktaDegerEki;

                            noktaDegerleri[i] = yeniNoktaDeger;

                            if (vrsylnNoktaDegistir)
                            {
                                vrsylnNoktaDegeri = yeniNoktaDeger;
                                vrsylnNoktaDegistir = false;
                            }

                            if (yeniNoktaDeger != vrsylnNoktaDegeri)
                            {
                                //g.DrawRectangle(Pens.Black, Rectangle.Round(rectF1));
                                g.DrawString(yeniNoktaDeger.ToString("0.00"), metin, Brushes.Blue, rectF1);
                            }
                        }
                        catch { }
                    }
            }
            if (noktalar.Count > 0) g.DrawLine(Pens.Red, noktalar[0].X, noktalar[0].Y, 0, noktalar[0].Y);

            // Egriler
            if (noktalar.Count >= 2)
            {
                g.DrawCurve(Pens.Green, noktalar.ToArray());
                g.DrawLine(Pens.Red, noktalar[noktalar.Count - 1].X, noktalar[noktalar.Count - 1].Y,
                    EgriPanel.Size.Width, noktalar[noktalar.Count - 1].Y); // Bitis Cizgisi
            }

            // Noktalar
            for (int i = 0; i < noktalar.Count; i++)
            {
                if (seciliNokta == i) g.FillEllipse(Brushes.OrangeRed, noktalar[i].X - 4, noktalar[i].Y - 4, 8, 8);
                else g.FillEllipse(Brushes.Blue, noktalar[i].X - 3, noktalar[i].Y - 3, 6, 6);
            }

            // Metinler
            float xEkseniYuzdelik = int.Parse(xEksen.Text);
            EksenDonustur(ref xEkseniYuzdelik, xMax.Text, xMin.Text, 200);
            direksiyonYuzdesi.Text = (xEkseniYuzdelik - 100).ToString("0.0"); // yuzdelik deger
            base.OnPaint(e);

            Graphics ekranaCiz = EgriPanel.CreateGraphics();
            ekranaCiz.DrawImage(bitmap, new PointF(0.0f, 0.0f));
            ekranaCiz.SmoothingMode = SmoothingMode.AntiAlias;
        }
        private void EgriPanel_MouseDown(object sender, MouseEventArgs e)
        {
            fareOrtaTekerlek = false;
            seciliNokta = -1;

            for (int i = 0; i < noktalar.Count; i++)
            {
                Vektor nokta = new Vektor(noktalar[i].X, noktalar[i].Y,0);
                if (farePoz.x > nokta.x - 6 && farePoz.x < nokta.x + 6 && farePoz.y > nokta.y - 7 && farePoz.y < nokta.y + 7)
                {
                    if (seciliNokta == -1) seciliNokta = i;
                    return;
                }
            }

        }
        private Vektor farePoz;
        private float noktaDegerEki = 1; // Tum nokta degerleriyle toplar
        private bool fareOrtaTekerlek;
        private float vrsylnNoktaDegeri = 1;
        private bool vrsylnNoktaDegistir;
        private void EgriPanel_MouseMove(object sender, MouseEventArgs e)
        {
            farePoz = new Vektor(e.Location.X, e.Location.Y,0);

            if (fareOrtaTekerlek)
            {
                seciliNokta = -1;
                for (int i = 0; i < noktalar.Count; i++)
                {
                    Vektor nokta = new Vektor(noktalar[i].X, noktalar[i].Y, 0);
                    if (farePoz.x > nokta.x - 9 && farePoz.x < nokta.x + 9)
                    {
                        if (seciliNokta == -1) seciliNokta = i;
                        return;
                    }
                }
            }

            if (seciliNokta != -1) noktalar[seciliNokta] = new Point(noktalar[seciliNokta].X,
                (farePoz.y >= 0 && farePoz.y < EgriPanel.Size.Height) ? (fareOrtaTekerlek ? noktalar[seciliNokta].Y + (e.Delta / 100 * -1) : (int)farePoz.y) : vrsylnNoktaY);

            fareOrtaTekerlek = false;
        }
        private void EgriPanel_MouseUp(object sender, MouseEventArgs e)
        {
            seciliNokta = -1;
        }
        private void HeyVJC_MouseWheel(object sender, MouseEventArgs e)
        {
            fareOrtaTekerlek = true;

            if (seciliNokta != -1) noktalar[seciliNokta] = new Point(noktalar[seciliNokta].X,
                (farePoz.y >= 0 && farePoz.y < EgriPanel.Size.Height) ? noktalar[seciliNokta].Y + (e.Delta / 100 * -1) : vrsylnNoktaY);
        }
        private void NoktaAzalt_Click(object sender, EventArgs e)
        {
            noktaToplam.Text = noktalar.Count - 1 + "";
            EgriPanel_NoktalariOlustur(noktalar.Count - 1);
        }
        private void NoktaArtir_Click(object sender, EventArgs e)
        {
            noktaToplam.Text = noktalar.Count + 1 + "";
            EgriPanel_NoktalariOlustur(noktalar.Count+1);
        }
        private void EgriPaneliKapat_Click(object sender, EventArgs e)
        {
            EgriPanel.Visible = false;
        }
        private void MaxNDegerArtir_Click(object sender, EventArgs e)
        {
            dikeySkalaOrani++;
        }
        private void MaxNDegerAzalt_Click(object sender, EventArgs e)
        {
            if (dikeySkalaOrani - 1 > 1) dikeySkalaOrani--;
        }
        private async void AyarYukle_Click(object sender, EventArgs e)
        {
            guncelle.Stop();
            using (OpenFileDialog pencere = new OpenFileDialog() { Filter = "HeyVJoySave|*.heyjoy", ValidateNames = true, Multiselect = false })
            {
                if (pencere.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader oku = new StreamReader(pencere.FileName)) 
                    {
                        dosyaAdi.Text = pencere.FileName.Split('\\')[pencere.FileName.Split('\\').Length-1].Split('.')[0];
                        var sifreliVeri = Convert.FromBase64String(await oku.ReadToEndAsync());
                        string veri = System.Text.Encoding.UTF8.GetString(sifreliVeri);

                        if (veri.Contains("HeyVJoySet"))
                        {
                            veri = veri.Split('{')[1].Split('}')[0];
                            string[] textBoxAyarlari = veri.Split(';')[0].Split(',');
                            string[] egriNoktaAyarlari = veri.Split(';')[1].Split(',');
                            string[] butonAyarlari = veri.Split(';')[2].Split(',');

                            aygitKimlik.Text = textBoxAyarlari[0];
                            arduinoHiz.Text = textBoxAyarlari[1];
                            noktaToplam.Text = textBoxAyarlari[2];
                            dikeySkalaOrani = int.Parse(textBoxAyarlari[3]);
                            textBoxAyarlari[4] = textBoxAyarlari[4].Replace('.', ',');
                            vrsylnNoktaDegeri = float.Parse(textBoxAyarlari[4]);
                            xMin.Text = textBoxAyarlari[5];
                            xMax.Text = textBoxAyarlari[6];
                            yMin.Text = textBoxAyarlari[7];
                            yMax.Text = textBoxAyarlari[8];
                            zMin.Text = textBoxAyarlari[9];
                            zMax.Text = textBoxAyarlari[10];

                            EgriPanel_NoktalariOlustur(int.Parse(noktaToplam.Text));
                            for (int i = 0; i < noktalar.Count; i++)
                                noktalar[i] = new Point(noktalar[i].X, int.Parse(egriNoktaAyarlari[i]));
                            EgriPanel.Visible = true;

                            butonlar.Nodes.Clear();
                            for (int i = 0; i < degistirilenButonlar.Length; i++)
                            {
                                degistirilenButonlar[i] = butonAyarlari[i];
                                butonlar.Nodes.Add("Gercek Buton:" + i + " / Uygulanan Buton:" + butonAyarlari[i].Split(' ')[0]);
                            }
                            guncelle.Start();
                        }
                    }
                }
            }
        }
        private async void AyarKaydet_Click(object sender, EventArgs e)
        {
            string varsayilanNoktaDeger = vrsylnNoktaDegeri.ToString();
            varsayilanNoktaDeger = varsayilanNoktaDeger.Replace(',', '.');
            guncelle.Stop();
            using (SaveFileDialog pencere = new SaveFileDialog()
            { FileName = dosyaAdi.Text == "-Hazir Ayar-" ? "HazirAyar-HeyVJoy" : dosyaAdi.Text, Filter = "HeyVJoySave|*.heyjoy", ValidateNames = true})
            {
                if (pencere.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter yaz = new StreamWriter(pencere.FileName))
                    {
                        string veri = "HeyVJoySet{" + aygitKimlik.Text + "," + arduinoHiz.Text + "," +
                            (int.Parse(noktaToplam.Text) < 1 ? 1 + "": noktaToplam.Text) + "," + dikeySkalaOrani + "," + varsayilanNoktaDeger + "," +
                            xMin.Text + "," + xMax.Text + "," + yMin.Text + "," + yMax.Text + "," + zMin.Text + "," + zMax.Text + ";";
                        if(int.Parse(noktaToplam.Text) < 1 || noktalar.Count < 1)
                            for (int i = 0; i < (int.Parse(noktaToplam.Text) < 1 ? 1: int.Parse(noktaToplam.Text)); i++)
                            {
                                veri += EgriPanel.Size.Height / 2 + ",";
                            }
                        else foreach (Point nokta in noktalar) veri += nokta.Y + ",";
                        veri = veri.Remove(veri.Length - 1);
                        veri += ";";
                        foreach (string buton in degistirilenButonlar) veri += buton + ",";
                        veri = veri.Remove(veri.Length - 1);
                        veri += ";";
                        
                        var sifreliVeri = System.Text.Encoding.UTF8.GetBytes(veri + '}');
                        await Task.Run(() => yaz.WriteLineAsync(Convert.ToBase64String(sifreliVeri)));

                        dosyaAdi.Text = pencere.FileName.Split('\\')[pencere.FileName.Split('\\').Length - 1].Split('.')[0];
                        guncelle.Start();
                    }
                }
            }
        }
        private void AyarSifirla_Click(object sender, EventArgs e)
        {
            guncelle.Stop();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }
    }
}