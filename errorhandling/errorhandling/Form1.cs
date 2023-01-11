using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace errorhandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { // here run time error exception is passed in catch block
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();

            }
            catch (DivideByZeroException ee)// here my message and ee message of system is shown
            {
                MessageBox.Show("dont enter zero as divisor:" + ee.Message);
            }
            catch(FormatException ee)
            {
                MessageBox.Show("dont enter characters and special symbols" + ee.Message);
            }// when aabove two catch blocks cannot handle error base class Exception will take 
            catch (Exception ee) // care 
            {
                MessageBox.Show("Some general error :" + ee.Message);
            }
            finally
            {
                MessageBox.Show(" I am still alive ..");// this will execute in both cases
            } // whether exception comes or not ...

        }
        class AxisBank :ApplicationException // user defined exception creating
        {
            public AxisBank(string message):base(message)// what message u write in constructor 
            { // that will shown and thrown
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {  try
            {
                int age = Convert.ToInt32(textBox4.Text);
                if (age < 18)
                {// here i am creating object using new and that only throwing it
         AxisBank ae = new AxisBank("AxisbankException:Cannot open account age is below 18");
                    throw ae;
                }
                else
                {
                    MessageBox.Show("welcome to the bank");
                }
            }
            catch (AxisBank ae)
            {
                MessageBox.Show(ae.Message);// here same message of constructor will come 
            }
           

        }
    }
}
