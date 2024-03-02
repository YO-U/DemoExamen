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
    public partial class FormListProductAdd : Form
    {
        public FormListProductAdd()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxColour.Text) ||
                string.IsNullOrWhiteSpace(textBoxPicture.Text) ||
                string.IsNullOrWhiteSpace(textBoxImage.Text) ||
                string.IsNullOrWhiteSpace(textBoxComposition.Text) ||
               string.IsNullOrWhiteSpace(textBoxName.Text) ||
               string.IsNullOrWhiteSpace(textBoxWidth.Text) ||
               string.IsNullOrWhiteSpace(textBoxLength.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            int width, length, price;

            if (!int.TryParse(textBoxWidth.Text, out width) ||
                !int.TryParse(textBoxLength.Text, out length) ||
                !int.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }

            using (var context = new PractikaZachotEntities())
            {
                int nextId = (int)(context.Cloth.Any() ? context.Cloth.Max(f => f.Article_of_cloth) + 1 : 1);

                var newFabric = new Cloth()
                {
                    
                    Article_of_cloth = nextId,
                    Name = textBoxName.Text,
                    Colour = textBoxName.Text,
                    Picture = textBoxPicture.Text,
                    Image = textBoxImage.Text,
                    Composition = textBoxComposition.Text,
                    Width = width,
                    Length = length,
                    Price = price
                };
                context.Cloth.Add(newFabric);
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
