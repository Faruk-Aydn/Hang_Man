using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hang_Man
{
    public partial class Form1 : Form
    {
        int hataSayisi = 0; // Çöp adamın aşamaları için hata sayacı
        int skor = 0; // Skor sayacı
        List<string> sehirler = new List<string> { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };

        string secilenSehir;
        char[] gizliKelime;
        List<char> kullanilanHarfler = new List<char>();

        public Form1()
        {
            InitializeComponent();
            OyunBaslat();
            this.BackColor = Color.LightBlue; // Arka plan rengini değiştir
        }

        private void Form_Load(object sender, EventArgs e)
        {
            OyunBaslat();
        }

        private void OyunBaslat()
        {
            Random rand = new Random();
            secilenSehir = sehirler[rand.Next(sehirler.Count)].ToUpper();
            gizliKelime = new string('_', secilenSehir.Length).ToCharArray();
            hataSayisi = 0;
            skor = 0; // Skoru sıfırla
            kullanilanHarfler.Clear();
            lblYanlisHarfler.Text = "Yanlış Harfler: ";
            lblSkor.Text = $"Skor: {skor}";
            GosterKelime();
            this.Invalidate();
        }

        private void GosterKelime()
        {
            lblKelime.Text = string.Join(" ", gizliKelime);
            lblKelime.Font = new Font("Arial", 24, FontStyle.Bold); // Fontu güncelle
            lblKelime.ForeColor = Color.DarkBlue; // Yazı rengini değiştir
        }

        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            string girilenHarf = txtHarf.Text.ToUpper();

            if (girilenHarf.Length == 1 && !kullanilanHarfler.Contains(girilenHarf[0]))
            {
                kullanilanHarfler.Add(girilenHarf[0]);

                if (secilenSehir.Contains(girilenHarf))
                {
                    for (int i = 0; i < secilenSehir.Length; i++)
                    {
                        if (secilenSehir[i] == girilenHarf[0])
                        {
                            gizliKelime[i] = girilenHarf[0];
                        }
                    }
                    skor += 10; // Doğru tahmin için skor arttır
                    GosterKelime();
                }
                else
                {
                    hataSayisi++;
                    lblYanlisHarfler.Text += girilenHarf + " "; // Yanlış harfi göster
                    this.Invalidate(); // Formu yeniden çiz (çöp adamı güncelle)
                }

                txtHarf.Clear();

                if (!gizliKelime.Contains('_'))
                {
                    MessageBox.Show("Tebrikler! Şehri doğru tahmin ettiniz.");
                    skor += 50; // Oyunu kazanma skoru
                    OyunBaslat();
                }
                else if (hataSayisi == 7)
                {
                    MessageBox.Show($"Kaybettiniz! Doğru şehir: {secilenSehir}");
                    OyunBaslat();
                }
                lblSkor.Text = $"Skor: {skor}";
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen kalem = new Pen(Color.Black, 2);

            // Çöp adamın direği, sadece hata sayısı 1 veya daha fazlaysa çizilecek
            if (hataSayisi > 0)
            {
                g.DrawLine(kalem, 50, 50, 50, 250); // Dikey çizgi
                g.DrawLine(kalem, 50, 50, 150, 50); // Yatay çizgi
                g.DrawLine(kalem, 150, 50, 150, 100); // Kanca
            }

            // Çöp adamın her aşamasını sırayla çizeceğiz
            if (hataSayisi > 1)
            {
                // Baş (çember)
                g.DrawEllipse(kalem, 125, 100, 50, 50);
            }
            if (hataSayisi > 2)
            {
                // Gövde (dik çizgi)
                g.DrawLine(kalem, 150, 150, 150, 250);
            }
            if (hataSayisi > 3)
            {
                // Sağ kol
                g.DrawLine(kalem, 150, 180, 200, 130);
            }
            if (hataSayisi > 4)
            {
                // Sol kol
                g.DrawLine(kalem, 150, 180, 100, 130);
            }
            if (hataSayisi > 5)
            {
                // Sağ bacak
                g.DrawLine(kalem, 150, 250, 200, 300);
            }
            if (hataSayisi > 6)
            {
                // Sol bacak
                g.DrawLine(kalem, 150, 250, 100, 300);
            }
        }
    }
}
