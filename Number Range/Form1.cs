using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Range
{
    public partial class Form1 : Form
    {

        int startNum, lastNum, x; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            startNum = Convert.ToInt32(textBox1.Text);
            lastNum = Convert.ToInt32(textBox2.Text);
            for (x = startNum; x <= lastNum; x = x + 1)
            {
                outputLabel.Text += " " + x; 
            }
        }
    }
}
