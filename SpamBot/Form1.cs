using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpamBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text );
            SendKeys.Send("{ENTER}");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
