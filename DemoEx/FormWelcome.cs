using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void OpenSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            signUp.Show();
            this.Hide();
        }

        private void OpenSignIn_Click(object sender, EventArgs e)
        {
            FormSignIn signIn = new FormSignIn();
            signIn.Show();
            this.Hide();
        }
    }
}
