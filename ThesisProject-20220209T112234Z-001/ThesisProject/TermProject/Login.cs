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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-7DEH5NV\\MSSQLSERVER02;Initial Catalog=Term_Project;Integrated Security=True");
        private void BtnLogin_Click(object sender, EventArgs e)
        {
           
            connect.Open(); 
            SqlCommand command = new SqlCommand("Select * From Login where Username = @p1 and Password = @p2  ",connect);
            command.Parameters.AddWithValue("@p1", TxtUsername.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password or username!!!");

            }
            connect.Close();
                    
        }

        private void BtnBackLogin_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}
