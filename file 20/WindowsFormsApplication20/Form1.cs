using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            Convert.ToDecimal = (textBox1.Text);
            Convert.ToDecimal = (textBox2.Text);
            textBox1.Text = a;
            textBox2.Text = b;
            button1 = (a + b);
      
        }
    }
}
