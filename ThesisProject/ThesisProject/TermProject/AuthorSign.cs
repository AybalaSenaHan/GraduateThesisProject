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


namespace TermProject
{
    public partial class AuthorSign : Form
    {
        public AuthorSign()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-7DEH5NV\\MSSQLSERVER02;Initial Catalog=Term_Project;Integrated Security=True");

        private void BtnAddAuthorSign_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Insert Into Author  (AuthorName) values (@p1)", connect);
            command.Parameters.AddWithValue("@p1", TxtAuthorSign.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Added");
        }

        private void BtnAddSupervisorSign_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Insert Into Supervisor  (SupervisorName,CoSupervisorName) values (@p1,@p2)", connect);
            command.Parameters.AddWithValue("@p1", TxtSupervisorSign.Text);
            command.Parameters.AddWithValue("@p2", TxtCoSupervisorSign.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Added");        
        }
        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            AuthorInterface authorInterface = new AuthorInterface();
            authorInterface.Show();
            this.Hide();
        }

        private void BtnBackAuthorSign_Click(object sender, EventArgs e)
        {
            PreAuthorInterface preAuthorInterface = new PreAuthorInterface();
            preAuthorInterface.Show();
            this.Hide();
        }
    }
}
