using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypercubeSignin
{
    public partial class CheckIn : Form
    {
        private System.IO.StreamWriter _file;

        public CheckIn()
        {
            InitializeComponent();
            CenterToScreen();

            _file = new System.IO.StreamWriter(@"members.txt", true);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            DoSignIn();
        }

        private void DoSignIn()
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string email = textBoxEmail.Text;

            // ignore if firstname not put
            if ( firstName.Length == 0 )  return;
            if ( lastName.Length == 0 ) lastName = "NONE";
            if ( email.Length == 0) email = "NONE";

            // write out text
            string outText = String.Format( "First: {0}, Last: {1}, Email: {2}", firstName, lastName, email );
            _file.WriteLine(outText);
            _file.Flush();

            // clear name and focus
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxFirstName.Focus();
            
            // open diag box
            FormThankYou formThankYou = new FormThankYou();
            formThankYou.Visible = true;
            formThankYou.parentForm = this;
            formThankYou.SetName(firstName);
            this.Enabled = false;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
