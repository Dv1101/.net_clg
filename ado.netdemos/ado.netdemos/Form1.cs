using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;// ado.net namesapce ...
namespace ado.netdemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"data source=DV-ASUS-TUF;initial catalog=sixb20;"
+"Integrated Security=true;");
        SqlCommand cmd;
        SqlDataReader dr;
        private void button2_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd = new SqlCommand("insert into student values("
                + Convert.ToInt16(textBox1.Text) + ",'" + textBox2.Text + "')", cnn);
           int noofrowsinserted=cmd.ExecuteNonQuery();
            if(noofrowsinserted >0)
            {
                MessageBox.Show("student inserted");
            }
            else
            {
                MessageBox.Show("student not inserted");
            }
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd = new SqlCommand("update student set studname='"
                + textBox2.Text + "' where studid=" + Convert.ToInt16(textBox1.Text), cnn);
            int noofrowsupdated=cmd.ExecuteNonQuery();
            if(noofrowsupdated>0)
            {
                MessageBox.Show("student updated");
            }
            else
            {
                MessageBox.Show("studnet not updated");
            }
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)// dlete button code ...
        {
            cnn.Open();
            cmd = new SqlCommand("delete from student where studid="
                + Convert.ToInt16(textBox1.Text), cnn);
           int noofrowsdeleted=cmd.ExecuteNonQuery();
            if(noofrowsdeleted>0)
            {
                MessageBox.Show("student deleted");
            }
            else
            {
                MessageBox.Show("student not deleted");
            }
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)// display all  code ..
        {
            cnn.Open();
            cmd = new SqlCommand("select * from student", cnn);
           dr=cmd.ExecuteReader();// when select is theee use executereader
            while(dr.Read())// dr is datareader class 
            {
                MessageBox.Show(dr[0].ToString() + " --" + dr[1].ToString());
            }
            cnn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.Open();
            cmd = new SqlCommand("select studid from student", cnn);
           dr= cmd.ExecuteReader();
            comboBox1.Refresh();
            while(dr.Read())
            {
                this.comboBox1.Items.Add(dr[0].ToString());
            }
            cnn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Open();
            cmd = new SqlCommand("select * from student where studid="
                + Convert.ToInt16(comboBox1.Text), cnn);
           dr= cmd.ExecuteReader();
            dr.Read();
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            cnn.Close();
        }
    }
}
