using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticProject
{
    public partial class Form1 : Form
    {
        int TabN;
        public Form1()
        {
            InitializeComponent();
        }
        private void TSMn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Авторы проекта:\nКалмычков Александр\nЛитинская Дарья\n\nГруппа:\n9ИСП-33-18\n\nТема:\nИнформационная система автосалона", "Информация");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Цвет". При необходимости она может быть перемещена или удалена.
            this.цветTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Цвет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Сделка". При необходимости она может быть перемещена или удалена.
            this.сделкаTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Сделка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Салон". При необходимости она может быть перемещена или удалена.
            this.салонTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Салон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Паспорт". При необходимости она может быть перемещена или удалена.
            this.паспортTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Паспорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Модель". При необходимости она может быть перемещена или удалена.
            this.модельTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Модель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Комплектация". При необходимости она может быть перемещена или удалена.
            this.комплектацияTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Комплектация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Акции". При необходимости она может быть перемещена или удалена.
            this.акцииTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Акции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "информационная_система_автосалонаDataSet.Автомобиль". При необходимости она может быть перемещена или удалена.
            this.автомобильTableAdapter.Fill(this.информационная_система_автосалонаDataSet.Автомобиль);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = автомобильBindingSource;
            TabN = 1;
            label1.Visible = true;
            label1.Text = "VIN";
            textBox1.Enabled = true;
            label2.Visible = true;
            label2.Text = "AutoYear";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "KitID";
            textBox3.Enabled = true;
            label4.Visible = true;
            label4.Text = "ColorID";
            textBox4.Enabled = true;
            label5.Visible = true;
            label5.Text = "SalonID";
            textBox5.Enabled = true;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Enabled = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Enabled = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Enabled = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Enabled = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Enabled = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Enabled = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Enabled = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Enabled = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Enabled = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Enabled = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Enabled = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Enabled = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Enabled = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Enabled = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Enabled = false;
        }

        private void акцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = акцииBindingSource;
            TabN = 2;
            label1.Visible = true;
            label1.Text = "SaleID";
            textBox1.Enabled = true;
            label2.Visible = true;
            label2.Text = "SalePercent";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "SaleName";
            textBox3.Enabled = true;
            label4.Visible = true;
            label4.Text = "SaleStart";
            textBox4.Enabled = true;
            label5.Visible = true;
            label5.Text = "SaleEnd";
            textBox5.Enabled = true;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Enabled = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Enabled = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Enabled = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Enabled = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Enabled = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Enabled = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Enabled = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Enabled = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Enabled = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Enabled = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Enabled = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Enabled = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Enabled = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Enabled = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Enabled = false;
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = должностьBindingSource;
            TabN = 3;
            label1.Visible = true;
            label1.Text = "PostID";
            textBox1.Enabled = true;
            label2.Visible = true;
            label2.Text = "PostName";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "MinObrazov";
            textBox3.Enabled = true;
            label4.Visible = true;
            label4.Text = "Oklad";
            textBox4.Enabled = true;
            label5.Visible = true;
            label5.Text = "PostPercent";
            textBox5.Enabled = true;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Enabled = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Enabled = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Enabled = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Enabled = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Enabled = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Enabled = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Enabled = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Enabled = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Enabled = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Enabled = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Enabled = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Enabled = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Enabled = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Enabled = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Enabled = false;
        }

        private void комплектацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = комплектацияBindingSource;
            TabN = 4;
            label1.Visible = true;
            label1.Text = "KitID";
            textBox1.Enabled = true;
            label2.Visible = true;
            label2.Text = "ModelName";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "KitName";
            textBox3.Enabled = true;
            label4.Visible = true;
            label4.Text = "KitCost";
            textBox4.Enabled = true;
            label5.Visible = true;
            label5.Text = "SeatMaterial";
            textBox5.Enabled = true;
            label6.Visible = true;
            label6.Text = "SalonMaterial";
            textBox6.Enabled = true;
            label7.Visible = true;
            label7.Text = "SeatColor";
            textBox7.Enabled = true;
            label8.Visible = true;
            label8.Text = "SalonColor";
            textBox8.Enabled = true;
            label9.Visible = true;
            label9.Text = "AutoWindow";
            textBox9.Enabled = true;
            label10.Visible = true;
            label10.Text = "SunRoof";
            textBox10.Enabled = true;
            label11.Visible = true;
            label11.Text = "Cruise";
            textBox11.Enabled = true;
            label12.Visible = true;
            label12.Text = "Multimedia";
            textBox12.Enabled = true;
            label13.Visible = true;
            label13.Text = "AudioMaker";
            textBox13.Enabled = true;
            label14.Visible = true;
            label14.Text = "Parking";
            textBox14.Enabled = true;
            label15.Visible = true;
            label15.Text = "BackCam";
            textBox15.Enabled = true;
            label16.Visible = true;
            label16.Text = "AutoMirror";
            textBox16.Enabled = true;
            label17.Visible = true;
            label17.Text = "ESeat";
            textBox17.Enabled = true;
            label18.Visible = true;
            label18.Text = "ClimatZone";
            textBox18.Enabled = true;
            label19.Visible = true;
            label19.Text = "Keyless";
            textBox19.Enabled = true;
            label20.Visible = true;
            label20.Text = "ETrunc";
            textBox20.Enabled = true;
        }

        private void модельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = модельBindingSource;
            TabN = 5;
            label1.Visible = true;
            label1.Text = "ModelName";
            textBox1.Enabled = true;
            label2.Visible = true;
            label2.Text = "ModelCost";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "EngineVolume";
            textBox3.Enabled = true;
            label4.Visible = true;
            label4.Text = "EngineHP";
            textBox4.Enabled = true;
            label5.Visible = true;
            label5.Text = "EngineTorque";
            textBox5.Enabled = true;
            label6.Visible = true;
            label6.Text = "EngineType";
            textBox6.Enabled = true;
            label7.Visible = true;
            label7.Text = "TransmissionType";
            textBox7.Enabled = true;
            label8.Visible = true;
            label8.Text = "WheelDrive";
            textBox8.Enabled = true;
            label9.Visible = true;
            label9.Text = "FuelType";
            textBox9.Enabled = true;
            label10.Visible = true;
            label10.Text = "FuelRate";
            textBox10.Enabled = true;
            label11.Visible = true;
            label11.Text = "PlaceCount";
            textBox11.Enabled = true;
            label12.Visible = true;
            label12.Text = "WheelBase";
            textBox12.Enabled = true;
            label13.Visible = true;
            label13.Text = "BodyWidth";
            textBox13.Enabled = true;
            label14.Visible = true;
            label14.Text = "BodyLength";
            textBox14.Enabled = true;
            label15.Visible = true;
            label15.Text = "EqMass";
            textBox15.Enabled = true;
            label16.Visible = true;
            label16.Text = "FullMass";
            textBox16.Enabled = true;
            label17.Visible = true;
            label17.Text = "WheelSize";
            textBox17.Enabled = true;
            label18.Visible = true;
            label18.Text = "BodyType";
            textBox18.Enabled = true;
            label19.Visible = true;
            label19.Text = "DoorCount";
            textBox19.Enabled = true;
            label20.Visible = true;
            label20.Text = "TruncVolume";
            textBox20.Enabled = true;
        }

        private void паспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = паспортBindingSource;
            TabN = 6;
            label1.Visible = true;
            label1.Text = "Passport";
            textBox1.Enabled = true;
            label2.Visible = true;
            label2.Text = "Surname";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "Name";
            textBox3.Enabled = true;
            label4.Visible = true;
            label4.Text = "MidName";
            textBox4.Enabled = true;
            label5.Visible = true;
            label5.Text = "Birthday";
            textBox5.Enabled = true;
            label6.Visible = true;
            label6.Text = "BirthPlace";
            textBox6.Enabled = true;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Enabled = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Enabled = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Enabled = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Enabled = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Enabled = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Enabled = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Enabled = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Enabled = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Enabled = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Enabled = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Enabled = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Enabled = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Enabled = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Enabled = false;
        }

        private void салонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = салонBindingSource;
            TabN = 7;
            label1.Visible = true;
            label1.Text = "SalonID";
            textBox1.Enabled = true;
            label2.Visible = true;
            label2.Text = "City";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "Adress";
            textBox3.Enabled = true;
            label4.Visible = false;
            label4.Text = "";
            textBox4.Enabled = false;
            label5.Visible = false;
            label5.Text = "";
            textBox5.Enabled = false;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Enabled = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Enabled = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Enabled = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Enabled = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Enabled = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Enabled = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Enabled = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Enabled = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Enabled = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Enabled = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Enabled = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Enabled = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Enabled = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Enabled = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Enabled = false;
        }

        private void сделкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = сделкаBindingSource;
            TabN = 8;
            label1.Visible = true;
            label1.Text = "SellID";
            textBox1.Enabled = true;
            label2.Visible = true;
            label2.Text = "SotrID";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "Passport";
            textBox3.Enabled = true;
            label4.Visible = true;
            label4.Text = "Cost";
            textBox4.Enabled = true;
            label5.Visible = true;
            label5.Text = "SaleID";
            textBox5.Enabled = true;
            label6.Visible = true;
            label6.Text = "SalonID";
            textBox6.Enabled = true;
            label7.Visible = true;
            label7.Text = "VIN";
            textBox7.Enabled = true;
            label8.Visible = true;
            label8.Text = "SellDate";
            textBox8.Enabled = true;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Enabled = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Enabled = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Enabled = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Enabled = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Enabled = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Enabled = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Enabled = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Enabled = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Enabled = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Enabled = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Enabled = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Enabled = false;
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = сотрудникBindingSource;
            TabN = 9;
            label1.Visible = true;
            label1.Text = "SotrID";
            textBox1.Enabled = true;
            label2.Visible = true;
            label2.Text = "PostID";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "SalonID";
            textBox3.Enabled = true;
            label4.Visible = true;
            label4.Text = "Passport";
            textBox4.Enabled = true;
            label5.Visible = true;
            label5.Text = "Stage";
            textBox5.Enabled = true;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Enabled = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Enabled = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Enabled = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Enabled = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Enabled = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Enabled = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Enabled = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Enabled = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Enabled = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Enabled = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Enabled = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Enabled = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Enabled = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Enabled = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Enabled = false;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = цветBindingSource;
            TabN = 10;
            label1.Visible = true;
            label1.Text = "ColorID";
            textBox1.Visible = true;
            label2.Enabled = true;
            label2.Text = "ColorName";
            textBox2.Enabled = true;
            label3.Visible = true;
            label3.Text = "ColorType";
            textBox3.Enabled = true;
            label4.Visible = true;
            label4.Text = "ColorCost";
            textBox4.Enabled = true;
            label5.Visible = false;
            label5.Text = "";
            textBox5.Enabled = false;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Enabled = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Enabled = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Enabled = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Enabled = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Enabled = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Enabled = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Enabled = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Enabled = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Enabled = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Enabled = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Enabled = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Enabled = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Enabled = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Enabled = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Enabled = false;
        }

        private void btnAddClick(object sender, EventArgs e)
        {
            switch (TabN)
            {
                case 1:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Автомобиль.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        nRow[3] = textBox4.Text;
                        nRow[4] = textBox5.Text;
                        информационная_система_автосалонаDataSet.Автомобиль.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;

                case 2:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Акции.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        nRow[3] = textBox4.Text;
                        nRow[4] = textBox5.Text;
                        информационная_система_автосалонаDataSet.Акции.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;

                case 3:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Должность.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        nRow[3] = textBox4.Text;
                        nRow[4] = textBox5.Text;
                        информационная_система_автосалонаDataSet.Должность.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;

                case 4:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Комплектация.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        nRow[3] = textBox4.Text;
                        nRow[4] = textBox5.Text;
                        nRow[5] = textBox6.Text;
                        nRow[6] = textBox7.Text;
                        nRow[7] = textBox8.Text;
                        nRow[8] = textBox9.Text;
                        nRow[9] = textBox10.Text;
                        nRow[10] = textBox11.Text;
                        nRow[11] = textBox12.Text;
                        nRow[12] = textBox13.Text;
                        nRow[13] = textBox14.Text;
                        nRow[14] = textBox15.Text;
                        nRow[15] = textBox16.Text;
                        nRow[16] = textBox17.Text;
                        nRow[17] = textBox18.Text;
                        nRow[18] = textBox19.Text;
                        nRow[19] = textBox20.Text;
                        информационная_система_автосалонаDataSet.Комплектация.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;

                case 5:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Модель.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        nRow[3] = textBox4.Text;
                        nRow[4] = textBox5.Text;
                        nRow[5] = textBox6.Text;
                        nRow[6] = textBox7.Text;
                        nRow[7] = textBox8.Text;
                        nRow[8] = textBox9.Text;
                        nRow[9] = textBox10.Text;
                        nRow[10] = textBox11.Text;
                        nRow[11] = textBox12.Text;
                        nRow[12] = textBox13.Text;
                        nRow[13] = textBox14.Text;
                        nRow[14] = textBox15.Text;
                        nRow[15] = textBox16.Text;
                        nRow[16] = textBox17.Text;
                        nRow[17] = textBox18.Text;
                        nRow[18] = textBox19.Text;
                        nRow[19] = textBox20.Text;
                        информационная_система_автосалонаDataSet.Модель.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;

                case 6:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Паспорт.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        nRow[3] = textBox4.Text;
                        nRow[4] = textBox5.Text;
                        nRow[5] = textBox6.Text;
                        информационная_система_автосалонаDataSet.Паспорт.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;

                case 7:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Салон.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        информационная_система_автосалонаDataSet.Салон.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;

                case 8:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Сделка.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        nRow[3] = textBox4.Text;
                        nRow[4] = textBox5.Text;
                        nRow[5] = textBox6.Text;
                        nRow[6] = textBox7.Text;
                        nRow[7] = textBox8.Text;
                        информационная_система_автосалонаDataSet.Сделка.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;

                case 9:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Сотрудник.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        nRow[3] = textBox4.Text;
                        nRow[4] = textBox5.Text;
                        информационная_система_автосалонаDataSet.Сотрудник.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;

                case 10:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Цвет.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        nRow[3] = textBox4.Text;
                        nRow[4] = textBox5.Text;
                        информационная_система_автосалонаDataSet.Цвет.Rows.Add(nRow);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        информационная_система_автосалонаDataSet.RejectChanges();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnDelClick(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            SendKeys.Send("{DEL}");
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Сохранить изменения?", "Изменение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                try
                {
                    /*switch (TabN)
                    {
                        case 1:
                            автомобильTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        case 2:
                            акцииTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        case 3:
                            должностьTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        case 4:
                            комплектацияTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        case 5:
                            модельTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        case 6:
                            паспортTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        case 7:
                            салонTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        case 8:
                            сделкаTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        case 9:
                            сотрудникTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        case 10:
                            цветTableAdapter.Update(информационная_система_автосалонаDataSet);
                            break;
                        default:
                            break;
                    }*/
                    автомобильTableAdapter.Update(информационная_система_автосалонаDataSet);
                    акцииTableAdapter.Update(информационная_система_автосалонаDataSet);
                    должностьTableAdapter.Update(информационная_система_автосалонаDataSet);
                    комплектацияTableAdapter.Update(информационная_система_автосалонаDataSet);
                    модельTableAdapter.Update(информационная_система_автосалонаDataSet);
                    паспортTableAdapter.Update(информационная_система_автосалонаDataSet);
                    салонTableAdapter.Update(информационная_система_автосалонаDataSet);
                    сделкаTableAdapter.Update(информационная_система_автосалонаDataSet);
                    сотрудникTableAdapter.Update(информационная_система_автосалонаDataSet);
                    цветTableAdapter.Update(информационная_система_автосалонаDataSet);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Несовпадение с другими таблицами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    информационная_система_автосалонаDataSet.RejectChanges();
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    информационная_система_автосалонаDataSet.RejectChanges();
                }
                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("Несоответвие с ограничениями!\nВозможно, неуникальное значение первичного ключа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    информационная_система_автосалонаDataSet.RejectChanges();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить все изменения?", "Изменение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr != DialogResult.Cancel)
            {
                информационная_система_автосалонаDataSet.RejectChanges();
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == комплектацияBindingSource | dataGridView1.DataSource == модельBindingSource)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
        }
    }
}
