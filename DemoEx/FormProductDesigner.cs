using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DemoEx
{
    public partial class FormProductDesigner : Form
    {
        public FormProductDesigner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxWidth.Text) || string.IsNullOrWhiteSpace(textBoxHight.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            int width, hight;

            if (!int.TryParse(textBoxWidth.Text, out width) ||
                !int.TryParse(textBoxHight.Text, out hight))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }

            using (var context = new PractikaZachotEntities())
            {
                int nextId = (int)(context.Furniture_of_product.Any() ? context.Furniture_of_product.Max(f => f.ID_Product) + 1 : 1);

                var newFabric = new Furniture_of_product()
                {
                    id_FoP = nextId,
                    ID_Product = nextId,
                    Article_of_furniture = nextId,
                    Width = width,
                    Hight = hight,
                    Fabric = comboBoxFabric.Text,
                    Edging = comboBoxEdging.Text,
                    Hardware = comboBoxHardware.Text,
                    Placements = comboBoxPlacements.Text,
                    HardwareSizes = comboBoxHardwareSizes.Text
                    
                };
                context.Furniture_of_product.Add(newFabric);
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
