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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void итоговая_АттестацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.итоговая_АттестацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.автошколаDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Экзамен". При необходимости она может быть перемещена или удалена.
            this.экзаменTableAdapter.Fill(this.автошколаDataSet.Экзамен);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Ученики". При необходимости она может быть перемещена или удалена.
            this.ученикиTableAdapter.Fill(this.автошколаDataSet.Ученики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Инструктора". При необходимости она может быть перемещена или удалена.
            this.инструктораTableAdapter.Fill(this.автошколаDataSet.Инструктора);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.автошколаDataSet.Автомобили);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Итоговая_Аттестация". При необходимости она может быть перемещена или удалена.
            this.итоговая_АттестацияTableAdapter.Fill(this.автошколаDataSet.Итоговая_Аттестация);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void итоговая_АттестацияDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.итоговая_АттестацияTableAdapter.Fill(this.автошколаDataSet.Итоговая_Аттестация);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            data.kod = ((АвтошколаDataSet.Итоговая_АттестацияRow)((System.Data.DataRowView)итоговая_АттестацияBindingSource.Current).Row).Код;
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.итоговая_АттестацияTableAdapter.Fill(this.автошколаDataSet.Итоговая_Аттестация);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            data.mode = 3;
            data.kod = ((АвтошколаDataSet.Итоговая_АттестацияRow)((System.Data.DataRowView)итоговая_АттестацияBindingSource.Current).Row).Код;
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.итоговая_АттестацияTableAdapter.Fill(this.автошколаDataSet.Итоговая_Аттестация);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.инструктораTableAdapter.ТолькоК(this.автошколаDataSet.Инструктора);
        }
    }
}
