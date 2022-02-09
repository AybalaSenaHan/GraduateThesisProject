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
    public partial class DetailSearch : Form
    {
        void clear()
        {
            CmbUniversityName.Text = " ";
            CmbInstituteName.Text = " ";
            CmbLanguage.Text = " ";
            CmbType.Text = " ";
            TxtAbstract.Text = " ";
            TxtAuthor.Text = " ";
            TxtNumberOfPages.Text = " ";
            CmbSubject.Text = " ";
            TxtSupervisor.Text = " ";
            TxtCoSupervisor.Text = "";
            TxtTitle.Text = " ";
            TxtYear.Text = " ";
            DtpSubmissionDate.Value = DateTime.Now;
        }



        public DetailSearch()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-7DEH5NV\\MSSQLSERVER02;Initial Catalog=Term_Project;Integrated Security=True");


        private void button3_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            
            connect.Open();
            SqlCommand _command = new SqlCommand("SELECT * FROM Thesis " +
            "WHERE(TypeID = (SELECT TypeID FROM Type WHERE TypeName = @p1) and LanguageID = (SELECT LanguageID FROM Language WHERE LanguageName = @p2) and UniversityID = (SELECT UniversityID FROM University WHERE UniversityName = @p3) and InstituteID = (SELECT InstituteID FROM Institute WHERE InstituteName = @p4) and Title = @p5 and Abstract = @p6 and NumberOfPages = @p7 and SubmissionDate = @p8 and Year = @p9 and SubjectID = (SELECT SubjectID FROM Subject WHERE SubjectName = @p10) and SupervisorID = (SELECT SupervisorID FROM Supervisor WHERE SupervisorName = @p11 and CoSupervisorName = @p12) and AuthorID = (SELECT AuthorID FROM Author WHERE AuthorName = @p13) and Keyword = @p14) ", connect);
                _command.Parameters.AddWithValue("@p1", CmbType.Text);
                _command.Parameters.AddWithValue("@p2", CmbLanguage.Text);
                _command.Parameters.AddWithValue("@p3", CmbUniversityName.Text);
                _command.Parameters.AddWithValue("@p4", CmbInstituteName.Text);
                _command.Parameters.AddWithValue("@p5", TxtTitle.Text);
                _command.Parameters.AddWithValue("@p6", TxtAbstract.Text);
                _command.Parameters.AddWithValue("@p7", TxtNumberOfPages.Text);
                _command.Parameters.AddWithValue("@p8", DtpSubmissionDate.Value);
                _command.Parameters.AddWithValue("@p9", TxtYear.Text);
                _command.Parameters.AddWithValue("@p10", CmbSubject.Text);
                _command.Parameters.AddWithValue("@p11", TxtSupervisor.Text);
                _command.Parameters.AddWithValue("@p12", TxtCoSupervisor.Text);
                _command.Parameters.AddWithValue("@p13", TxtAuthor.Text);
                _command.Parameters.AddWithValue("@p14", TxtKeyword.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(_command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
            MessageBox.Show("Found");         
        }

        private void DetailSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'term_ProjectDataSet3.Thesis' table. You can move, or remove it, as needed.
            this.thesisTableAdapter.Fill(this.term_ProjectDataSet3.Thesis);
            //UniversityName
            connect.Open();
            SqlCommand command = new SqlCommand("Select  UniversityName From University", connect);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                CmbUniversityName.Items.Add(dr[0]);

            }
            connect.Close();
            //Institute Name
            connect.Open();
            SqlCommand command2 = new SqlCommand("Select  InstituteName From Institute", connect);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {

                CmbInstituteName.Items.Add(dr2[0]);

            }
            connect.Close();
            //Type 
            connect.Open();
            SqlCommand command3 = new SqlCommand("Select TypeName From Type", connect);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                CmbType.Items.Add(dr3[0]);
            }
            connect.Close();
            //Language 
            connect.Open();
            SqlCommand command4 = new SqlCommand("Select LanguageName From Language", connect);
            SqlDataReader dr4 = command4.ExecuteReader();
            while (dr4.Read())
            {
                CmbLanguage.Items.Add(dr4[0]);

            }
            connect.Close();
            //Subject
            connect.Open();
            SqlCommand command5 = new SqlCommand("Select SubjectName From Subject", connect);
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                CmbSubject.Items.Add(dr5[0]);

            }
            connect.Close();




        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
