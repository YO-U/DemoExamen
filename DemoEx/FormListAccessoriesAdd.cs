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
    public partial class FormListAccessoriesAdd : Form
    {
        public FormListAccessoriesAdd()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(textBoxArticle.Text) ||
                string.IsNullOrWhiteSpace(textBoxName.Text) ||
              string.IsNullOrWhiteSpace(textBoxWidth.Text) ||
              string.IsNullOrWhiteSpace(textBoxLength.Text) ||
              string.IsNullOrWhiteSpace(textBoxCount.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            int width, length, count, article;

            if (!int.TryParse(textBoxWidth.Text, out width) ||
                !int.TryParse(textBoxLength.Text, out length) ||
                !int.TryParse(textBoxCount.Text, out count) ||
                !int.TryParse(textBoxArticle.Text, out article))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }

            using (var context = new PractikaZachotEntities())
            {
                int nextId = (int)(context.The_product.Any() ? context.The_product.Max(f => f.ID_Product) + 1 : 1);

                var newFabric = new The_product()
                {
                    ID_Product = nextId,
                    Article_of_product = article,
                    Name = textBoxName.Text,
                    Width = width,
                    Length = length,
                    Count = count
                };
                context.The_product.Add(newFabric);
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
