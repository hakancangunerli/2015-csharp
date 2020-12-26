using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sayi3, sayi4 ;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sayi3 = Convert.ToDouble(textBox3.Text);
            sayi4 = Convert.ToDouble(textBox4.Text);
            double son = (((double)(sayi1 * sayi3) / 100) + (sayi2*sayi4)/100);
              
            label3.Text = son.ToString();
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
