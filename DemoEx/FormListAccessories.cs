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
    public partial class FormListAccessories : Form
    {
        private int currentIndex = 0;
        private List<The_product> fabrics;

        public FormListAccessories()
        {
            InitializeComponent();
            LoadFabrics();
        }
        private void LoadFabrics()
        {
            using (var context = new PractikaZachotEntities())
            {
                fabrics = context.The_product.ToList();
            }
            ShowFabric(currentIndex);
        }
        private void ShowFabric(int index)
        {
            if (index >= 0 && index < fabrics.Count)
            {
                var fabric = fabrics[index];
                textBoxArticle.Text = fabric.Article_of_product.ToString();
                textBoxName.Text = fabric.Name;
                textBoxWidth.Text = fabric.Width.ToString();
                textBoxLength.Text = fabric.Length.ToString();
                textBoxCount.Text = fabric.Count.ToString();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.Show();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < fabrics.Count - 1)
            {
                currentIndex++;
                ShowFabric(currentIndex);
            }
        }

        private void FormListAccessoriesAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
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
                currentFabric.Article_of_product = int.Parse(textBoxArticle.Text);
                currentFabric.Name = textBoxName.Text;
                currentFabric.Width = int.Parse(textBoxWidth.Text);
                currentFabric.Length = int.Parse(textBoxLength.Text);
                currentFabric.Count = int.Parse(textBoxCount.Text);

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
            FormListAccessoriesAdd formListAccessories = new FormListAccessoriesAdd();
            formListAccessories.ShowDialog();
            LoadFabrics();
        }
    }
}
