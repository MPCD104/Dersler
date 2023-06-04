using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmbIslem.Items.Add("+");
            cmbIslem.Items.Add("-");
            cmbIslem.Items.Add("*");
            cmbIslem.Items.Add("/");
            txtSonuc.Enabled = false;

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            float sonuc = 0;
            switch (cmbIslem.SelectedItem)
            {
                case "+": sonuc = sayi1 + sayi2; break;
                case "-": sonuc = sayi1 - sayi2; break;
                case "*": sonuc = sayi1 * sayi2; break;
                case "/": sonuc = sayi1 / sayi2; break;
                default:
                    break;
            }

            txtSonuc.Text = sonuc.ToString();
        }
    }
}
