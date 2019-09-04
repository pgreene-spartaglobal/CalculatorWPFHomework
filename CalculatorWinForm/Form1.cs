using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int val1 = Int32.Parse(textBox1.Text);
            int val2 = Int32.Parse(textBox2.Text);
            int result = val1 + val2;
            MessageBox.Show(result.ToString());
        }
    }
}
