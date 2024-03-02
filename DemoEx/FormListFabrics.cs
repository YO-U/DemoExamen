using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class FormListFabrics : Form
    {
        //PractikaZachotEntities
        private int currentIndex = 0;
        private List<Fabric_warehouse> fabrics;

        public FormListFabrics()
        {
            InitializeComponent();
            LoadFabrics();
        }

        private void LoadFabrics()
        {
            using (var context = new PractikaZachotEntities())
            {
                fabrics = context.Fabric_warehouse.ToList();
            }
            ShowFabric(currentIndex);
        }

        private void ShowFabric(int index)
        {
            if (index >= 0 && index < fabrics.Count)
            {
                var fabric = fabrics[index];
                textBoxRoll.Text = fabric.Roll;
                textBoxName.Text = fabric.Name;
                textBoxWidth.Text = fabric.Width.ToString();
                textBoxLength.Text = fabric.Length.ToString();
                textBoxCount.Text = fabric.Count.ToString();
            }
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
                currentFabric.Roll = textBoxRoll.Text;
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
            FormListFabricsAdd formListFabricsAdd = new FormListFabricsAdd();
            formListFabricsAdd.ShowDialog(); 
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

        private void textBoxRoll_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
