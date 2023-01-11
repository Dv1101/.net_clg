using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace datasetdemo2
{    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
SqlConnection cnn=new SqlConnection("data source=DV-ASUS-TUF;initial catalog=sixb20;"+
    "Integrated Security=true;");
        SqlDataAdapter ad1;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataRow dr;
        int rn;// this is the row number where u are pointing
        private void Form1_Load(object sender, EventArgs e)
        {
            ad1 = new SqlDataAdapter("select * from student", cnn);
            ad1.Fill(ds, "ss");
            dt = ds.Tables["ss"];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rn = 0;// first row i want to go
            dr = dt.Rows[rn];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            rn = rn + 1;
            if(rn <=dt.Rows.Count-1)//rows are there to iterate 
            {
                dr = dt.Rows[rn];
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
            }
            else
            {
                rn = rn - 1;// reached last row tell that u cannot move forward
                MessageBox.Show("end of record reached");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            rn = rn - 1;
            if (rn >=0)//rows are there to iterate backwards 
            {
                dr = dt.Rows[rn];
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
            }
            else
            {
                rn = rn + 1;// reached first row
                MessageBox.Show("Begining of record reached");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            rn = dt.Rows.Count - 1;// u are at last row now 
            dr = dt.Rows[rn];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
        }
    }
}
