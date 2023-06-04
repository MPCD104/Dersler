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
    public partial class ListBoxOrnek : Form
    {
        public ListBoxOrnek()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbIsimler.Items.Add(txtIsim.Text);
            txtIsim.Clear();
        }

        private void lbIsimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Selam {lbIsimler.SelectedItem}");
        }
    }
}
