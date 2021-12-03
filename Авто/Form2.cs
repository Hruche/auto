using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Авто
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void автомобилиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автомобилиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.автошколаDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.автошколаDataSet.Автомобили);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameField;
            NameField = "Марка_машины";
            int Index;
            Index = автомобилиBindingSource.Find(NameField, textBox1.Text);
            if (Index > -1) автомобилиBindingSource.Position = Index;
            else MessageBox.Show("Поиск завершён. Образец не найден");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String NameField;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "Марка_машины"; break;
                case 1:
                    NameField = "Модель"; break;
                default:
                    NameField = "Марка_машины"; break;
            }
            автомобилиBindingSource.Filter = NameField + " like '" + textBox3.Text + "%'";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.Filter = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NameField;
            NameField = "Модель";
            int Index;
            Index = автомобилиBindingSource.Find(NameField, textBox2.Text);
            if (Index > -1) автомобилиBindingSource.Position = Index;
            else MessageBox.Show("Поиск завершён. Образец не найден");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.автомобилиTableAdapter.ТолькоК(this.автошколаDataSet.Автомобили);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.автомобилиTableAdapter.Fill(this.автошколаDataSet.Автомобили);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.автомобилиTableAdapter.UpdateQuery(textBox5.Text, textBox4.Text);
            int Row = автомобилиDataGridView.CurrentCell.RowIndex;
            int Column = автомобилиDataGridView.CurrentCell.ColumnIndex;
            this.автомобилиTableAdapter.Fill(this.автошколаDataSet.Автомобили);
            автомобилиDataGridView.CurrentCell = автомобилиDataGridView[Column, Row];
        }
    }
}
