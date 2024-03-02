using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DemoEx
{
    public partial class FormListFabricsAdd : Form
    {
        public FormListFabricsAdd()
        {
            InitializeComponent();
        }

        private void textBoxRoll_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRoll.Text) ||
                string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxWidth.Text) ||
                string.IsNullOrWhiteSpace(textBoxLength.Text) ||
                string.IsNullOrWhiteSpace(textBoxCount.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            int width, length, count;

            if (!int.TryParse(textBoxWidth.Text, out width) ||
                !int.TryParse(textBoxLength.Text, out length) ||
                !int.TryParse(textBoxCount.Text, out count))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }

            using (var context = new PractikaZachotEntities())
            {
                int nextId = (int)(context.Fabric_warehouse.Any() ? context.Fabric_warehouse.Max(f => f.Article_of_cloth) + 1 : 1);
                int nextId1 = (int)(context.Fabric_warehouse.Any() ? context.Fabric_warehouse.Max(f => f.id_fabric) + 1 : 1);

                var newFabric = new Fabric_warehouse()
                {
                    id_fabric = nextId1,
                    Article_of_cloth = nextId,
                    Roll = textBoxRoll.Text,
                    Name = textBoxName.Text,
                    Width = width,
                    Length = length,
                    Count = count
                };
                context.Fabric_warehouse.Add(newFabric);
                context.SaveChanges();
            }
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}