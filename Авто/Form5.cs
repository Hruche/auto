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
    public partial class Form5 : Form
    {
        private object итоговая_АттестацияTableAdapter;

        public Form5()
        {
            InitializeComponent();
        }

        private void экзаменBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.экзаменBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.автошколаDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Экзамен". При необходимости она может быть перемещена или удалена.
            this.экзаменTableAdapter.Fill(this.автошколаDataSet.Экзамен);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameField;
            NameField = "Вид_сдачи";
            int Index;
            Index = экзаменBindingSource.Find(NameField, textBox1.Text);
            if (Index > -1) экзаменBindingSource.Position = Index;
            else MessageBox.Show("Поиск завершён. Образец не найден");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.экзаменTableAdapter.Fill(this.автошколаDataSet.Экзамен);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String NameField;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "Вид_сдачи"; break;
                case 1:
                    NameField = "Ученик"; break;
                default:
                    NameField = "Вид_сдачи"; break;
            }
            экзаменBindingSource.Filter = NameField + " like '" + textBox3.Text + "%'";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
             this.экзаменTableAdapter.UpdateQuery(textBox5.Text, textBox4.Text);
            int Row = экзаменDataGridView.CurrentCell.RowIndex;
            int Column = экзаменDataGridView.CurrentCell.ColumnIndex;
            this.экзаменTableAdapter.Fill(this.автошколаDataSet.Экзамен);
            экзаменDataGridView.CurrentCell = экзаменDataGridView[Column, Row];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
