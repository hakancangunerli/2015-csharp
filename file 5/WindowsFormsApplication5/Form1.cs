using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         label1.Text = "click here to learn the name of the character";
                
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "doge";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "griezmann";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "vidanjör";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
