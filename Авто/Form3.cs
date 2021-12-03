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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void инструктораBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.инструктораBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.автошколаDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Инструктора". При необходимости она может быть перемещена или удалена.
            this.инструктораTableAdapter.Fill(this.автошколаDataSet.Инструктора);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameField;
            NameField = "Фамилия";
            int Index;
            Index = инструктораBindingSource.Find(NameField, textBox1.Text);
            if (Index > -1) инструктораBindingSource.Position = Index;
            else MessageBox.Show("Поиск завершён. Образец не найден");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String NameField;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "Имя"; break;
                case 1:
                    NameField = "Отчество"; break;
                default:
                    NameField = "Имя"; break;
            }
            инструктораBindingSource.Filter = NameField + " like '" + textBox3.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            инструктораBindingSource.Filter = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.инструктораTableAdapter.ТолькоК(this.автошколаDataSet.Инструктора);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.инструктораTableAdapter.Fill(this.автошколаDataSet.Инструктора);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.инструктораTableAdapter.UpdateQuery(textBox5.Text, textBox4.Text);
            int Row = инструктораDataGridView.CurrentCell.RowIndex;
            int Column = инструктораDataGridView.CurrentCell.ColumnIndex;
            this.инструктораTableAdapter.Fill(this.автошколаDataSet.Инструктора);
            инструктораDataGridView.CurrentCell = инструктораDataGridView[Column, Row];
        }
    }
}
