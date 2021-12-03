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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ученикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ученикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.автошколаDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Ученики". При необходимости она может быть перемещена или удалена.
            this.ученикиTableAdapter.Fill(this.автошколаDataSet.Ученики);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameField;
            NameField = "Фамилия";
            int Index;
            Index = ученикиBindingSource.Find(NameField, textBox1.Text);
            if (Index > -1) ученикиBindingSource.Position = Index;
            else MessageBox.Show("Поиск завершён. Образец не найден");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ученикиBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String NameField;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "Преподаватель"; break;
                case 1:
                    NameField = "Фамилия"; break;
                default:
                    NameField = "Преподаватель"; break;
            }
            ученикиBindingSource.Filter = NameField + " like '" + textBox3.Text + "%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NameField;
            NameField = "Преподаватель";
            int Index;
            Index = ученикиBindingSource.Find(NameField, textBox2.Text);
            if (Index > -1) ученикиBindingSource.Position = Index;
            else MessageBox.Show("Поиск завершён. Образец не найден");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ученикиTableAdapter.ТолькоД(this.автошколаDataSet.Ученики);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ученикиBindingSource.Filter = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.ученикиTableAdapter.UpdateQuery(textBox5.Text, textBox4.Text);
            int Row = ученикиDataGridView.CurrentCell.RowIndex;
            int Column = ученикиDataGridView.CurrentCell.ColumnIndex;
            this.ученикиTableAdapter.Fill(this.автошколаDataSet.Ученики);
            ученикиDataGridView.CurrentCell = ученикиDataGridView[Column, Row];
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.ученикиTableAdapter.Fill(this.автошколаDataSet.Ученики);
        }
    }
}
