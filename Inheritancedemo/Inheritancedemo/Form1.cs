using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritancedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Father
        {
            public void Car()
            {
                MessageBox.Show("maruthi car");
            }
        }
        class son :Father
        {
            public void MBCar()
            {
                MessageBox.Show("mercedes benz car");
            }
        }// implementing multi level inhieritance ...
        class grandson:son//,Father if i put i will get error becauce C# dont support multiple inheritance
        {// if  u remove son and keep father it is okay hierchical inheritance is allowed in C#
            public void BMWCar()
            {
                MessageBox.Show("BMW car");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            grandson gson = new grandson();
            gson.BMWCar();
            gson.Car();
            gson.MBCar();
            Father fobj = new Father();
            fobj.Car();
          //  fobj.MBCar();// error because base class object cannot call subb class function 
            // sub class can call all base class functionalities 
        }
    }
}
