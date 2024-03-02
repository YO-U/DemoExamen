using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void Namee_TextChanged(object sender, EventArgs e)
        {
        }

        private void CreateUser_Click_1(object sender, EventArgs e)
        {
            string name = Namee.Text;
            string login = Login.Text;
            string password = Password.Text;
            string role = "";

            if (radioCustomer.Checked)
                role = "Заказчики";
            else if (radioStorekeepers.Checked)
                role = "Кладовщики";
            else if (radioManagers.Checked)
                role = "Менеджеры";
            else if (radioDirectorate.Checked)
                role = "Дирекция";

            if (IsPasswordValid(password))
            {
                using (var context = new PractikaZachotEntities())
                {
                    var user = new User
                    {
                        Name = name,
                        Login = login,
                        Password = password,
                        Role = role
                    };

                    context.User.Add(user);
                    context.SaveChanges();
                }
                FormSignIn signIn = new FormSignIn();
                signIn.Show();
                this.Close();
            }
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен быть больше 6 символов.");
                return false;
            }
                

            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Пароль должен содержать хотя бы 1 заглавную букву.");
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Пароль должен содержать хотя бы 1 цифру.");
                return false;
            }

            if (password.IndexOfAny("!@#$%^".ToCharArray()) == -1)
            {
                MessageBox.Show("Пароль должен содержать хотя бы один из этих символов !@#$%^ .");
                return false;
            }

            return true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.Show();
            this.Close();
        }
    }
}