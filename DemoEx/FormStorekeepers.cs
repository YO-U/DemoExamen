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
    public partial class FormStorekeepers : Form
    {
        public FormStorekeepers()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListFabrics formListFabrics = new FormListFabrics();
            formListFabrics.Show();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListAccessories formListAccessories = new FormListAccessories();
            formListAccessories.Show();

        }
    }
}
