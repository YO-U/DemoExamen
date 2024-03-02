using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;

            using (var context = new PractikaZachotEntities())
            {
                // Поиск пользователя в базе данных по логину и паролю
                var user = context.User.FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    // Определение роли пользователя
                    switch (user.Role)
                    {
                        case "Заказчики":
                            // Открыть форму для заказчиков
                            FormCustomer formForCustomers = new FormCustomer();
                            formForCustomers.Show();
                            break;
                        case "Кладовщики":
                            // Открыть форму для кладовщиков
                            FormStorekeepers formForStorekeepers = new FormStorekeepers();
                            formForStorekeepers.Show();
                            break;
                        case "Менеджеры":
                            // Открыть форму для менеджеров
                            FormManagers formForManagers = new FormManagers();
                            formForManagers.Show();
                            break;
                        case "Дирекция":
                            // Открыть форму для дирекции
                            FormDirectorate formForDirectorate = new FormDirectorate();
                            formForDirectorate.Show();
                            break;
                        default:
                            MessageBox.Show("Неизвестная роль пользователя");
                            break;
                    }

                    // Закрыть текущую форму
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином и паролем не найден.");
                }
            }
        }


        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.Show();
            this.Close();
        }
    }
}
