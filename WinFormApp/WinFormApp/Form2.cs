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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textSayi1.Text);
            int sayi2 = Convert.ToInt32(textSayi2.Text);
            int toplam = sayi1 + sayi2;
            MessageBox.Show(toplam.ToString());
        }
    }
}
