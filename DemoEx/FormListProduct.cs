using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class FormListProduct : Form
    {
        private int currentIndex = 0;
        private List<Cloth> fabrics;
        public FormListProduct()
        {
            InitializeComponent();
            LoadFabrics();
        }
         private void LoadFabrics()
        {
            using (var context = new PractikaZachotEntities())
            {
                fabrics = context.Cloth.ToList();
            }
            ShowFabric(currentIndex);
        }
        private void ShowFabric(int index)
        {
            if (index >= 0 && index < fabrics.Count)
            {
                var fabric = fabrics[index];
                textBoxPicture.Text = fabric.Picture;
                textBoxColour.Text = fabric.Colour;
                textBoxImage.Text = fabric.Image;
                textBoxComposition.Text = fabric.Composition;
                textBoxName.Text = fabric.Name;
                textBoxWidth.Text = fabric.Width.ToString();
                textBoxLength.Text = fabric.Length.ToString();
                textBoxPrice.Text = fabric.Price.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormListProduct_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowFabric(currentIndex);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < fabrics.Count)
            {
                var currentFabric = fabrics[currentIndex];
                currentFabric.Picture = textBoxPicture.Text;
                currentFabric.Colour =  textBoxColour.Text;
                currentFabric.Image = textBoxImage.Text;
                currentFabric.Composition = textBoxComposition.Text;
                currentFabric.Name = textBoxName.Text;
                currentFabric.Width = int.Parse(textBoxWidth.Text);
                currentFabric.Length = int.Parse(textBoxLength.Text);
                currentFabric.Price = int.Parse(textBoxPrice.Text);

                using (var context = new PractikaZachotEntities())
                {
                    context.Entry(currentFabric).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < fabrics.Count)
            {
                var currentFabric = fabrics[currentIndex];

                using (var context = new PractikaZachotEntities())
                {
                    context.Entry(currentFabric).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                fabrics.RemoveAt(currentIndex);
                if (currentIndex >= fabrics.Count)
                    currentIndex--;
                ShowFabric(currentIndex);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormListProductAdd formListAccessories = new FormListProductAdd();
            formListAccessories.ShowDialog();
            LoadFabrics();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < fabrics.Count - 1)
            {
                currentIndex++;
                ShowFabric(currentIndex);
            }
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.Show();
            this.Close();
        }
    }
}
