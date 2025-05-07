using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarihiolaylarveritabanı
{
    public partial class olayekle : Form
    {
        public olayekle()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string olayIsmi = textBox1.Text.Trim();
            string olayIcerigi = textBox2.Text.Trim();

            // Olay ismi ve içerik boş değilse ana veri yapısına ekliyoruz
            if (!string.IsNullOrEmpty(olayIsmi) && !string.IsNullOrEmpty(olayIcerigi))
            {
                // Ana veri yapısına yeni olay ekleyelim
                if (!TarihselOlaylar.tarihveri.olayIcerikleri.ContainsKey(olayIsmi))
                {
                    TarihselOlaylar.tarihveri.olayIsimleri.Add(olayIsmi);
                    TarihselOlaylar.tarihveri.olayIcerikleri.Add(olayIsmi, olayIcerigi);

                    MessageBox.Show("Tarihsel olay başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formu temizleyelim
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Bu tarihsel olay zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Olay ismi ve içeriği boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void olayekle_Load(object sender, EventArgs e)
        {

        }
    }
}
