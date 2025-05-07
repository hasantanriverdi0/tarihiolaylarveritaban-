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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            olayekle olayekle = new olayekle();
            olayekle.Show();
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            olayoku olayoku = new olayoku();
            olayoku.Show();
            this.Close();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
