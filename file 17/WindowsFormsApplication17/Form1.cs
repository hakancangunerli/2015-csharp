using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "kırmızı" || textBox1.Text == "Kırmızı" || textBox1.Text == "red" || textBox1.Text == "Kirmizi" || textBox1.Text == "kirmizi")
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Purple;
            }

        }

    }
}

