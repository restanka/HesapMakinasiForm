using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTopla_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb1.Text);
            double sayi2 = Convert.ToDouble(tb2.Text);

            double sonuc = sayi1 + sayi2;

            tbSonuc.Text = sonuc.ToString();
        }

        private void btCıkar_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb1.Text);
            double sayi2 = Convert.ToDouble(tb2.Text);

            double sonuc = sayi1 - sayi2;
            tbSonuc.Text = sonuc.ToString();
        }
        private void btUs_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb1.Text);
            double sayi2 = Convert.ToDouble(tb2.Text);
            
            double sonuc = Math.Pow(sayi1, sayi2);
            tbSonuc.Text = sonuc.ToString();
        }

        private void btCarp_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb1.Text);
            double sayi2 = Convert.ToDouble(tb2.Text);

            double sonuc = sayi1 * sayi2;
            tbSonuc.Text = sonuc.ToString();
        }
        private void btYuzde_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb1.Text);
            double sayi2 = Convert.ToDouble(tb2.Text);

            double sonuc = sayi1 % sayi2;
            tbSonuc.Text = sonuc.ToString();
        }

        private void btBol_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb1.Text);
            double sayi2 = Convert.ToDouble(tb2.Text);

            if (sayi2 != 0 )
            {
                double sonuc = sayi1 / sayi2;
                tbSonuc.Text = sonuc.ToString();
            }

            else
            {
                MessageBox.Show("Sıfıra Bölünemez....");
            }
        }

        private void btTemizle_Click(object sender, EventArgs e)
        {
            tbSonuc.Text = "";
            tb1.Text = "";
            tb2.Text = "";
        }

        
    }
}
