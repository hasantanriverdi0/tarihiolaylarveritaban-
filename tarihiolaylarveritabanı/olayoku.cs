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
    public partial class olayoku : Form
    {
        public olayoku()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void olayoku_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = TarihselOlaylar.tarihveri.olayIsimleri;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenOlay = comboBox1.SelectedItem.ToString();

            // Seçilen olayın içeriğini textBox1'e yazdıralım
            if (TarihselOlaylar.tarihveri.olayIcerikleri.ContainsKey(secilenOlay))
            {
                // TextBox'a içeriği yazalım
                textBox1.Text = TarihselOlaylar.tarihveri.olayIcerikleri[secilenOlay];

                // TextBox'ın özelliklerini ayarlayalım
                textBox1.Multiline = true;       // Birden fazla satırda gösterim sağlanacak
                textBox1.ScrollBars = ScrollBars.Vertical; // Dikey kaydırma çubuğu ekleyelim
                textBox1.ReadOnly = true;        // Sadece okuma için
            }
        }
    }
}
