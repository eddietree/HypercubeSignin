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
    public partial class FormThankYou : Form
    {
        public CheckIn parentForm;

        public FormThankYou()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public void SetName( string name )
        {
            labelThankYou.Text = String.Format("Welcome, {0}!", name);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            parentForm.Enabled = true;
            this.Close();
        }
    }
}
