using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            MessageBox.Show("Son iki gün","Matematik Sınavı",
               MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
           
        }
    }
}
