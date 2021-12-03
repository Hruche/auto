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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.автошколаDataSet.Автомобили);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Экзамен". При необходимости она может быть перемещена или удалена.
            this.экзаменTableAdapter.Fill(this.автошколаDataSet.Экзамен);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Ученики". При необходимости она может быть перемещена или удалена.
            this.ученикиTableAdapter.Fill(this.автошколаDataSet.Ученики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Инструктора". При необходимости она может быть перемещена или удалена.
            this.инструктораTableAdapter.Fill(this.автошколаDataSet.Инструктора);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автошколаDataSet.Итоговая_Аттестация". При необходимости она может быть перемещена или удалена.
            this.итоговая_АттестацияTableAdapter.Fill(this.автошколаDataSet.Итоговая_Аттестация);


            if (data.mode == 1)
                итоговая_АттестацияBindingSource.AddNew();
            if (data.mode == 2)
            {
                int pos = итоговая_АттестацияBindingSource.Find("Код", data.kod);
                итоговая_АттестацияBindingSource.Position = pos;
            }
            if (data.mode == 3)
            {
                int pos = итоговая_АттестацияBindingSource.Find("Код", data.kod);
                итоговая_АттестацияBindingSource.Position = pos;
                panel1.Enabled=false;
            }               
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.итоговая_АттестацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.автошколаDataSet);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void итог_сдачиCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
