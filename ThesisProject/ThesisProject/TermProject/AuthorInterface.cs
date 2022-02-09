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
    public partial class AuthorInterface : Form
    {
        void clear()
        {
            CmbUniversityNameAuthor.Text = " ";
            CmbInstituteNameAuthor.Text = " ";
            CmbLanguageAuthor.Text = " ";
            CmbTypeAuthor.Text = " ";
            TxtAbstractAuthor.Text = " ";
            TxtAuthorAuthor.Text = " ";
            TxtNumberofPagesAuthor.Text = " ";
            CmbSubjectAuthor.Text = " ";
            TxtSupervisorAuthor.Text = " ";
            TxtTitleAuthor.Text = " ";
            MskYear.Text = " ";
            DtpSubmissionDateAuthor.Value = DateTime.Now;
        }


        public AuthorInterface()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-7DEH5NV\\MSSQLSERVER02;Initial Catalog=Term_Project;Integrated Security=True");

        private void AuthorInterface_Load(object sender, EventArgs e)
        {
            //UniversityName
            connect.Open();
            SqlCommand command = new SqlCommand("Select  UniversityName From University", connect);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                CmbUniversityNameAuthor.Items.Add(dr[0]);

            }
            connect.Close();
            //Institute Name
            connect.Open();
            SqlCommand command2 = new SqlCommand("Select  InstituteName From Institute", connect);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {

                CmbInstituteNameAuthor.Items.Add(dr2[0]);

            }
            connect.Close();
            //Type 
            connect.Open();
            SqlCommand command3 = new SqlCommand("Select TypeName From Type",connect);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                CmbTypeAuthor.Items.Add(dr3[0]);
            }
            connect.Close();
            //Language 
            connect.Open();
            SqlCommand command4 = new SqlCommand("Select LanguageName From Language", connect);
            SqlDataReader dr4 = command4.ExecuteReader();
            while (dr4.Read())
            {
                CmbLanguageAuthor.Items.Add(dr4[0]);

            }
            connect.Close();
            //Subject
            connect.Open();
            SqlCommand command5 = new SqlCommand("Select SubjectName From Subject", connect);
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                CmbSubjectAuthor.Items.Add(dr5[0]);

            }
            connect.Close();




        }

        private void BtnClearAuthorI_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnAddAuthorI_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand _command = new SqlCommand("Insert Into Thesis (TypeID,LanguageID,UniversityID,InstituteID,Title,Abstract,NumberOfPages,SubmissionDate,Year,SubjectID,SupervisorID,AuthorID,Keyword)" +
                "VALUES" +
                "((SELECT TypeID FROM Type WHERE TypeName = @p1),(SELECT LanguageID FROM Language WHERE LanguageName = @p2), (SELECT UniversityID FROM University WHERE UniversityName = @p3)," +
                "(SELECT InstituteID FROM Institute WHERE InstituteName = @p4), @p5,@p6,@p7,@p8,@p9 , (SELECT SubjectID FROM Subject WHERE SubjectName = @p10) ," +
                " (SELECT SupervisorID FROM Supervisor WHERE SupervisorName = @p11 and CoSupervisorName = @p12),(SELECT AuthorID FROM Author WHERE AuthorName = @p13),@p14)", connect);
            _command.Parameters.AddWithValue("@p1", CmbTypeAuthor.Text);
            _command.Parameters.AddWithValue("@p2", CmbLanguageAuthor.Text);
            _command.Parameters.AddWithValue("@p3", CmbUniversityNameAuthor.Text);
            _command.Parameters.AddWithValue("@p4", CmbInstituteNameAuthor.Text);
            _command.Parameters.AddWithValue("@p5", TxtTitleAuthor.Text);
            _command.Parameters.AddWithValue("@p6", TxtAbstractAuthor.Text);
            _command.Parameters.AddWithValue("@p7", TxtNumberofPagesAuthor.Text);
            _command.Parameters.AddWithValue("@p8", DtpSubmissionDateAuthor.Value);
            _command.Parameters.AddWithValue("@p9", MskYear.Text);
            _command.Parameters.AddWithValue("@p10", CmbSubjectAuthor.Text);
            _command.Parameters.AddWithValue("@p11", TxtSupervisorAuthor.Text);
            _command.Parameters.AddWithValue("@p12", TxtCoSupervisor.Text);
            _command.Parameters.AddWithValue("@p13", TxtAuthorAuthor.Text);
            _command.Parameters.AddWithValue("@p14", TxtKeyword.Text);
            _command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Added");
        }

        private void BtnBackAuthorInterface_Click(object sender, EventArgs e)
        {
            PreAuthorInterface preAuthorInterface = new PreAuthorInterface();
            preAuthorInterface.Show();
            this.Hide();
        }
    }
}
