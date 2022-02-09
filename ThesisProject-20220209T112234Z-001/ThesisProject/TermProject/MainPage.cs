using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAdminPanel_Click(object sender, EventArgs e)
        {
            Login logIn = new Login();
            logIn.Show();
            this.Hide();
        }

        private void BtnAuthorInterface_Click(object sender, EventArgs e)
        {
            PreAuthorInterface preAuthorInterface = new PreAuthorInterface();
            preAuthorInterface.Show();
            this.Hide();
        }

        private void BtnDetailSearch_Click(object sender, EventArgs e)
        {
            DetailSearch detailSearch = new DetailSearch();
            detailSearch.Show();
            this.Hide();
        }
    }
}
ö