using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Windows.UI
{
    public partial class Form1 : Form
    {
        SqlConnection Connection=null;
        SqlCommand Command=null;
        String ConnectionString = "Data Source=LAPTOP-VV1OR89D\\SQLEXPRESS;Initial Catalog=IMSDb;Integrated Security=True;Encrypt=False;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchData(ConnectionString);
        }
        private void FetchData(string ConnectionStrng)
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            Command = new SqlCommand("Select * from Role", Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridFetchData.DataSource = dt;

        }

    }
}
