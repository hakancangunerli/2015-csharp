using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
           
      }

        private void button14_Click(object sender, EventArgs e)
        {
            case "+": 
                    inputBox.Text = (val + Double.Parse(inputBox.Text)).ToString();
            break; 
                case "-": 
                    inputBox.Text = (val - Double.Parse(inputBox.Text)).ToString();
            break; 
                case "*": 
                    inputBox.Text = (val * Double.Parse(inputBox.Text)).ToString();
            break; 
                case "/": 
                    inputBox.Text = (val / Double.Parse(inputBox.Text)).ToString();
            break;
        }
    }
}
