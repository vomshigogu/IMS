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
        SqlConnection Connection = null;
        SqlCommand Command = null;
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

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            string name = txtAddName.Text;
            string code = txtAddCode.Text;
            string createdBy = txtAddCreatedBy.Text;
            string createdOn = txtAddCreatedOn.Text;
            string modifiedBy = txtAddModifiedBy.Text;
            string modifiedOn = txtAddModifieddOn.Text;
            string isActive = txtAddIsActive.Text;

            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            Command = new SqlCommand("Insert into [dbo].[Role] (Name,Code,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,IsActive) values(@name,@code,@createdBy,@createdOn,@modifiedBy,@modifiedOn,@isActive)", Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@Name", name);
            Command.Parameters.AddWithValue("@code", code);
            Command.Parameters.AddWithValue("@createdBy", createdBy);
            Command.Parameters.AddWithValue("@createdOn", createdOn);
            Command.Parameters.AddWithValue("@modifiedBy", modifiedBy);
            Command.Parameters.AddWithValue("modifiedOn", modifiedOn);
            Command.Parameters.AddWithValue("@isActive", isActive);

            Command.ExecuteNonQuery();
            Connection.Close();

            string action = "Add";
            ClearRoleElemanets(action);

            FetchData(ConnectionString);

            MessageBox.Show("Successfully saved");

        }



        private void ClearRoleElemanets(string action)
        {
            if (action == "Add")
            {
                txtAddName.Text = "";
                txtAddCode.Text = "";
                txtAddCreatedBy.Text = "";
                txtAddCreatedOn.Text = "";
                txtAddModifiedBy.Text = "";
                txtAddModifieddOn.Text = "";
                txtAddIsActive.Text = "";


            }
            else if (action == "Update")
            {
                txtUpdateId.Text = "";
                txtUpdateName.Text = "";
                txtUpdateCreatedBy.Text = "";
                txtUpdateCreatedOn.Text = "";
                txtUpdateModifedBy.Text = "";
                txtUpdateModifiedOn.Text = "";
                txtIsActive.Text = "";

            }
            else if (action == "Delete")
                txtDeleteRoleById.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtUpdateId.Text);

            string name = txtUpdateName.Text;
            string createdBy  = txtUpdateCreatedBy.Text;
            string createdOn = txtUpdateCreatedOn.Text;
            string modifiedBy = txtUpdateModifedBy.Text;
            string modyfiedOn = txtUpdateModifiedOn.Text;
            string isActive = txtIsActive.Text;


            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            Command = new SqlCommand("Update Role set name=@Name,createdBy=@createdBy,@createdOn=createdOn,modifiedOn=@modifiedOn,isActive=@isActive where @id=id" ,Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@id", id);
            Command.Parameters.AddWithValue("@name",name);
            Command.Parameters.AddWithValue("@createdBy",createdBy);
            Command.Parameters.AddWithValue("@createdOn", createdOn);
            
            Command.Parameters.AddWithValue("@modifiedBy", modifiedBy);
            Command.Parameters.AddWithValue("@modifiedOn", modyfiedOn);
            Command.Parameters.AddWithValue("@isActive", isActive);
            Command.ExecuteNonQuery();
            Connection.Close();

            string action = "Update";
            ClearRoleElemanets(action);

            FetchData(ConnectionString);

            MessageBox.Show("Successfully updated");

        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDeleteRoleById.Text);

            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            Command = new SqlCommand("Delete from Role where id=@id", Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@id",id);
            Command.ExecuteNonQuery();
            Connection.Close();


            string action = "Delete";
            ClearRoleElemanets(action);


            FetchData(ConnectionString);

            MessageBox.Show("Deleted successfully");
        }
    }
}