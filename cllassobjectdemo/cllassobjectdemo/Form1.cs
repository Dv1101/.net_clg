using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cllassobjectdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Employee
        {
            int empid;
            string name;
            int salary;
            int bonus;
            public void totalsalary(int sal,int bonus)
            {
                MessageBox.Show("The total salary is " + (sal + bonus));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            int sal = Convert.ToInt16(textBox1.Text);
            int bonus = Convert.ToInt16(textBox2.Text);
            ee.totalsalary(sal, bonus);

        }
    }
}
