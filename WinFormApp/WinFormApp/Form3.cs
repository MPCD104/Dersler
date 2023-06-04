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
    public partial class Form3 : Form
    {
        List<string> list = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            int randomSayi = random.Next(list.Count);
            btnShow.Text = list[randomSayi];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
            textBox1.Clear();
        }
    }
}
