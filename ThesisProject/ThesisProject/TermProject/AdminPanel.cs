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
    public partial class AdminPanel : Form
    {
        void clear()
        {
            TxtInstituteName.Text = " ";
            TxtLanguage.Text = " ";
            TxtSubject.Text = " ";
            TxtType.Text = " ";
            TxtUniversityName.Text = " ";
        }

        public AdminPanel()
        {
            InitializeComponent();
        }

        

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-7DEH5NV\\MSSQLSERVER02;Initial Catalog=Term_Project;Integrated Security=True");

        private void BtnAddUni_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Insert Into University  (UniversityName) values (@p1)",connect);
            command.Parameters.AddWithValue("@p1", TxtUniversityName.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Added");
        }

        private void BtnAddInstitute_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Insert Into Institute  (InstituteName) values (@p1)", connect);
            command.Parameters.AddWithValue("@p1", TxtInstituteName.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Added");
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Insert Into Type  (TypeName) values (@p1)", connect);
            command.Parameters.AddWithValue("@p1", TxtType.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Added");

        }

        private void BtnAddLanguage_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Insert Into Language  (LanguageName) values (@p1)", connect);
            command.Parameters.AddWithValue("@p1", TxtLanguage.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Added");
        }

        private void BtnDeleteUni_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete From University where UniversityName = @p1 " , connect);
            command.Parameters.AddWithValue("@p1", TxtUniversityName.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Deleted");

        }

        private void BtnDeleteInstitute_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete From Institute where InstituteName = @p1 ", connect);
            command.Parameters.AddWithValue("@p1", TxtInstituteName.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Deleted");
        }

        private void BtnDeleteType_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete From Type where TypeName = @p1 ", connect);
            command.Parameters.AddWithValue("@p1", TxtType.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Deleted");
        }

        private void BtnDeleteLanguage_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete From Language where LanguageName = @p1 ", connect);
            command.Parameters.AddWithValue("@p1",TxtLanguage.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Deleted");
        }

        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Insert Into Subject  (SubjectName) values (@p1)", connect);
            command.Parameters.AddWithValue("@p1", TxtSubject.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Added");
        }

        private void BtnDeleteSubject_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete From Subject where SubjectName = @p1 ", connect);
            command.Parameters.AddWithValue("@p1", TxtSubject.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Deleted");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnBackAdminPanel_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void BtnUpdateUniversityName_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Update University Set UniversityName = @p1 where UniversityName = @p2 " , connect);
            command.Parameters.AddWithValue("@p1",TxtUpdateUniversityName.Text);
            command.Parameters.AddWithValue("@p2", TxtUniversityName.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Updated");
        }

        private void BtnUpdateInstituteName_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Update Institute Set InstituteName = @p1 where InstituteName = @p2 ", connect);
            command.Parameters.AddWithValue("@p1", TxtUpdateInstituteName.Text);
            command.Parameters.AddWithValue("@p2", TxtInstituteName.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Updated");
        }

        private void BtnUpdateType_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Update Type Set TypeName = @p1 where TypeName = @p2 ", connect);
            command.Parameters.AddWithValue("@p1", TxtUpdateType.Text);
            command.Parameters.AddWithValue("@p2", TxtType.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Updated");
        }

        private void BtnUpdateLanguage_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Update Language Set LanguageName = @p1 where LanguageName = @p2 ", connect);
            command.Parameters.AddWithValue("@p1", TxtUpdateLanguage.Text);
            command.Parameters.AddWithValue("@p2", TxtLanguage.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Updated");
        }

        private void BtnUpdateSubject_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Update Subject Set SubjectName = @p1 where SubjectName = @p2 ", connect);
            command.Parameters.AddWithValue("@p1", TxtUpdateSubject.Text);
            command.Parameters.AddWithValue("@p2", TxtSubject.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Updated");
        }
    }
}
