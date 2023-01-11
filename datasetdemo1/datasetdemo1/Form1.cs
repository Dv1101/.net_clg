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
namespace datasetdemo1
{    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
SqlConnection cnn=new SqlConnection (@"data source=DV-ASUS-TUF;initial catalog=sixb20;"+
    "Integrated Security=true;");
        SqlDataAdapter ad1;
        SqlDataAdapter ad2;
        DataSet ds = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            ad1 = new SqlDataAdapter("select * from student", cnn);
            ad2 = new SqlDataAdapter("select * from course", cnn);
            ad1.Fill(ds, "ss");
            ad2.Fill(ds, "cc");
            dataGrid1.DataSource = ds;
        }
    }
}
