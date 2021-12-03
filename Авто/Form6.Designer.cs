
namespace Авто
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.итоговая_АттестацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автошколаDataSet = new Авто.АвтошколаDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.экзаменBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ученикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.инструктораBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.итоговая_АттестацияTableAdapter = new Авто.АвтошколаDataSetTableAdapters.Итоговая_АттестацияTableAdapter();
            this.tableAdapterManager = new Авто.АвтошколаDataSetTableAdapters.TableAdapterManager();
            this.автомобилиTableAdapter = new Авто.АвтошколаDataSetTableAdapters.АвтомобилиTableAdapter();
            this.инструктораTableAdapter = new Авто.АвтошколаDataSetTableAdapters.ИнструктораTableAdapter();
            this.ученикиTableAdapter = new Авто.АвтошколаDataSetTableAdapters.УченикиTableAdapter();
            this.экзаменTableAdapter = new Авто.АвтошколаDataSetTableAdapters.ЭкзаменTableAdapter();
            this.инструктораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.итог_сдачиCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.итоговая_АттестацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автошколаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.инструктораBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.инструктораBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.итог_сдачиCheckBox);
            this.panel1.Controls.Add(this.датаDateTimePicker);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 265);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.итоговая_АттестацияBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(91, 118);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.датаDateTimePicker.TabIndex = 14;
            // 
            // итоговая_АттестацияBindingSource
            // 
            this.итоговая_АттестацияBindingSource.DataMember = "Итоговая_Аттестация";
            this.итоговая_АттестацияBindingSource.DataSource = this.автошколаDataSet;
            // 
            // автошколаDataSet
            // 
            this.автошколаDataSet.DataSetName = "АвтошколаDataSet";
            this.автошколаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Вид_экзамена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ученик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Итоги сдачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Инструктор";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Авто";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Код";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.итоговая_АттестацияBindingSource, "Вид_экзамена", true));
            this.comboBox4.DataSource = this.экзаменBindingSource;
            this.comboBox4.DisplayMember = "Вид_сдачи";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(91, 171);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.ValueMember = "Код";
            // 
            // экзаменBindingSource
            // 
            this.экзаменBindingSource.DataMember = "Экзамен";
            this.экзаменBindingSource.DataSource = this.автошколаDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.итоговая_АттестацияBindingSource, "Ученик", true));
            this.comboBox3.DataSource = this.ученикиBindingSource;
            this.comboBox3.DisplayMember = "Фамилия";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(91, 144);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "Код";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ученикиBindingSource
            // 
            this.ученикиBindingSource.DataMember = "Ученики";
            this.ученикиBindingSource.DataSource = this.автошколаDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.итоговая_АттестацияBindingSource, "Инструктор", true));
            this.comboBox2.DataSource = this.инструктораBindingSource1;
            this.comboBox2.DisplayMember = "Фамилия";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "Код";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // инструктораBindingSource1
            // 
            this.инструктораBindingSource1.DataMember = "Инструктора";
            this.инструктораBindingSource1.DataSource = this.автошколаDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.итоговая_АттестацияBindingSource, "Авто", true));
            this.comboBox1.DataSource = this.автомобилиBindingSource;
            this.comboBox1.DisplayMember = "Марка_машины";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Код";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.автошколаDataSet;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.итоговая_АттестацияBindingSource, "Код", true));
            this.textBox1.Location = new System.Drawing.Point(91, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // итоговая_АттестацияTableAdapter
            // 
            this.итоговая_АттестацияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Авто.АвтошколаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = this.автомобилиTableAdapter;
            this.tableAdapterManager.ИнструктораTableAdapter = this.инструктораTableAdapter;
            this.tableAdapterManager.Итоговая_АттестацияTableAdapter = this.итоговая_АттестацияTableAdapter;
            this.tableAdapterManager.УченикиTableAdapter = this.ученикиTableAdapter;
            this.tableAdapterManager.ЭкзаменTableAdapter = this.экзаменTableAdapter;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // инструктораTableAdapter
            // 
            this.инструктораTableAdapter.ClearBeforeFill = true;
            // 
            // ученикиTableAdapter
            // 
            this.ученикиTableAdapter.ClearBeforeFill = true;
            // 
            // экзаменTableAdapter
            // 
            this.экзаменTableAdapter.ClearBeforeFill = true;
            // 
            // инструктораBindingSource
            // 
            this.инструктораBindingSource.DataMember = "Инструктора";
            this.инструктораBindingSource.DataSource = this.автошколаDataSet;
            // 
            // итог_сдачиCheckBox
            // 
            this.итог_сдачиCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.итоговая_АттестацияBindingSource, "Итог_сдачи", true));
            this.итог_сдачиCheckBox.Location = new System.Drawing.Point(137, 92);
            this.итог_сдачиCheckBox.Name = "итог_сдачиCheckBox";
            this.итог_сдачиCheckBox.Size = new System.Drawing.Size(17, 24);
            this.итог_сдачиCheckBox.TabIndex = 15;
            this.итог_сдачиCheckBox.UseVisualStyleBackColor = true;
            this.итог_сдачиCheckBox.CheckedChanged += new System.EventHandler(this.итог_сдачиCheckBox_CheckedChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(283, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Добавление и редактирование";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.итоговая_АттестацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автошколаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.инструктораBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.инструктораBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private АвтошколаDataSet автошколаDataSet;
        private System.Windows.Forms.BindingSource итоговая_АттестацияBindingSource;
        private АвтошколаDataSetTableAdapters.Итоговая_АттестацияTableAdapter итоговая_АттестацияTableAdapter;
        private АвтошколаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private АвтошколаDataSetTableAdapters.ИнструктораTableAdapter инструктораTableAdapter;
        private System.Windows.Forms.BindingSource инструктораBindingSource;
        private АвтошколаDataSetTableAdapters.УченикиTableAdapter ученикиTableAdapter;
        private System.Windows.Forms.BindingSource ученикиBindingSource;
        private АвтошколаDataSetTableAdapters.ЭкзаменTableAdapter экзаменTableAdapter;
        private System.Windows.Forms.BindingSource экзаменBindingSource;
        private АвтошколаDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private System.Windows.Forms.BindingSource инструктораBindingSource1;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.CheckBox итог_сдачиCheckBox;
    }
}