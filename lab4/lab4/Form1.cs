using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class jointaccount
        {
            static int balance = 10000;
            public void withdraw(int amt)
            {
                balance = balance - amt;
            
                if(balance<=-40000)
                {
                    MessageBox.Show("Suicide" + balance);
                }
                else
                {
                    MessageBox.Show("The current account balance is " + balance);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            jointaccount obj = new jointaccount();
            obj.withdraw(Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jointaccount obj = new jointaccount();
            obj.withdraw(Convert.ToInt32(textBox1.Text));
        }
    }
}
