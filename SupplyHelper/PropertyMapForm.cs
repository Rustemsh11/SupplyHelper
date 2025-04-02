using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyHelper
{
    public partial class PropertyMapForm : Form
    {
        public PropertyMapForm(List<(string, string)> semPropValues)
        {
            InitializeComponent();
            foreach (var item in semPropValues)
            {
                semPropGrid.Rows.Add(item.Item1, item.Item2);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private List<(int, string)> choosedPropData = new List<(int, string)>();

        private void button1_Click(object sender, EventArgs e)
        {

            var selectedProps = semPropGrid.SelectedRows;

            for (int i = 0; i < selectedProps.Count; i++)
            {
                choosenPropsList.Items.Add(selectedProps[i].Cells["Name"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choosenPropsList.Items.RemoveAt(choosenPropsList.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = choosenPropsList.SelectedIndex;
            if (index < choosenPropsList.Items.Count - 1 && index >= 0) // Проверяем, что элемент не последний
            {
                object item = choosenPropsList.Items[index];
                choosenPropsList.Items.RemoveAt(index);
                choosenPropsList.Items.Insert(index + 1, item);
                choosenPropsList.SelectedIndex = index + 1; // Сохраняем выделение
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = choosenPropsList.SelectedIndex;
            if (index > 0) // Проверяем, что элемент не первый
            {
                object item = choosenPropsList.Items[index];
                choosenPropsList.Items.RemoveAt(index);
                choosenPropsList.Items.Insert(index - 1, item);
                choosenPropsList.SelectedIndex = index - 1; // Сохраняем выделение
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder props = new StringBuilder();
            foreach (var item in choosenPropsList.Items)
            {
                props.AppendLine(item.ToString());
            }
            MessageBox.Show(props.ToString(), "Свойства элемента", MessageBoxButtons.OK);
        }

        private void addNewPropButton_Click(object sender, EventArgs e)
        {
            bool isOnlySemName = false;
            if (string.IsNullOrEmpty(newPropNameTextBox.Text))
            {
                isOnlySemName = true;
            }


        }
    }
}
