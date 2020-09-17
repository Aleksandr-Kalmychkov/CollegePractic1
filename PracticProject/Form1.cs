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



        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "AutoYear";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "KitID";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "ColorID";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "SalonID";
            textBox5.Visible = true;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Visible = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Visible = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Visible = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Visible = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Visible = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Visible = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Visible = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Visible = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Visible = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Visible = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Visible = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Visible = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Visible = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Visible = false;
        }

        private void акцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = акцииBindingSource;
            TabN = 2;
            label1.Visible = true;
            label1.Text = "SaleID";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "SalePercent";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "SaleName";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "SaleStart";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "SaleEnd";
            textBox5.Visible = true;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Visible = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Visible = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Visible = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Visible = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Visible = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Visible = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Visible = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Visible = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Visible = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Visible = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Visible = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Visible = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Visible = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Visible = false;
        }

        private void TSMn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Авторы проекта:\nКалмычков Александр\nЛитинская Дарья\n\nГруппа:\n9ИСП-33-18\n\nТема:\nИнформационная система автосалона", "Информация");
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = должностьBindingSource;
            TabN = 3;
            label1.Visible = true;
            label1.Text = "PostID";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "PostName";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "MinObrazov";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "Oklad";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "PostPercent";
            textBox5.Visible = true;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Visible = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Visible = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Visible = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Visible = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Visible = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Visible = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Visible = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Visible = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Visible = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Visible = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Visible = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Visible = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Visible = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Visible = false;
        }

        private void комплектацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = комплектацияBindingSource;
            TabN = 4;
            label1.Visible = true;
            label1.Text = "KitID";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "ModelName";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "KitName";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "KitCost";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "SeatMaterial";
            textBox5.Visible = true;
            label6.Visible = true;
            label6.Text = "SalonMaterial";
            textBox6.Visible = true;
            label7.Visible = true;
            label7.Text = "SeatColor";
            textBox7.Visible = true;
            label8.Visible = true;
            label8.Text = "SalonColor";
            textBox8.Visible = true;
            label9.Visible = true;
            label9.Text = "AutoWindow";
            textBox9.Visible = true;
            label10.Visible = true;
            label10.Text = "SunRoof";
            textBox10.Visible = true;
            label11.Visible = true;
            label11.Text = "Cruise";
            textBox11.Visible = true;
            label12.Visible = true;
            label12.Text = "Multimedia";
            textBox12.Visible = true;
            label13.Visible = true;
            label13.Text = "AudioMaker";
            textBox13.Visible = true;
            label14.Visible = true;
            label14.Text = "Parking";
            textBox14.Visible = true;
            label15.Visible = true;
            label15.Text = "BackCam";
            textBox15.Visible = true;
            label16.Visible = true;
            label16.Text = "AutoMirror";
            textBox16.Visible = true;
            label17.Visible = true;
            label17.Text = "ESeat";
            textBox17.Visible = true;
            label18.Visible = true;
            label18.Text = "ClimatZone";
            textBox18.Visible = true;
            label19.Visible = true;
            label19.Text = "Keyless";
            textBox19.Visible = true;
            label20.Visible = true;
            label20.Text = "ETrunc";
            textBox20.Visible = true;
        }

        private void модельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = модельBindingSource;
            TabN = 5;
            label1.Visible = true;
            label1.Text = "ModelName";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "ModelCost";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "EngineVolume";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "EngineHP";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "EngineTorque";
            textBox5.Visible = true;
            label6.Visible = true;
            label6.Text = "EngineType";
            textBox6.Visible = true;
            label7.Visible = true;
            label7.Text = "TransmissionType";
            textBox7.Visible = true;
            label8.Visible = true;
            label8.Text = "WheelDrive";
            textBox8.Visible = true;
            label9.Visible = true;
            label9.Text = "FuelType";
            textBox9.Visible = true;
            label10.Visible = true;
            label10.Text = "FuelRate";
            textBox10.Visible = true;
            label11.Visible = true;
            label11.Text = "PlaceCount";
            textBox11.Visible = true;
            label12.Visible = true;
            label12.Text = "WheelBase";
            textBox12.Visible = true;
            label13.Visible = true;
            label13.Text = "BodyWidth";
            textBox13.Visible = true;
            label14.Visible = true;
            label14.Text = "BodyLength";
            textBox14.Visible = true;
            label15.Visible = true;
            label15.Text = "EqMass";
            textBox15.Visible = true;
            label16.Visible = true;
            label16.Text = "FullMass";
            textBox16.Visible = true;
            label17.Visible = true;
            label17.Text = "WheelSize";
            textBox17.Visible = true;
            label18.Visible = true;
            label18.Text = "BodyType";
            textBox18.Visible = true;
            label19.Visible = true;
            label19.Text = "DoorCount";
            textBox19.Visible = true;
            label20.Visible = true;
            label20.Text = "TruncVolume";
            textBox20.Visible = true;
        }

        private void паспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = паспортBindingSource;
            TabN = 6;
            label1.Visible = true;
            label1.Text = "Passport";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "Surname";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Name";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "MidName";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "Birthday";
            textBox5.Visible = true;
            label6.Visible = true;
            label6.Text = "BirthPlace";
            textBox6.Visible = true;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Visible = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Visible = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Visible = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Visible = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Visible = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Visible = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Visible = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Visible = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Visible = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Visible = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Visible = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Visible = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Visible = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Visible = false;
        }

        private void салонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = салонBindingSource;
            TabN = 7;
            label1.Visible = true;
            label1.Text = "SalonID";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "City";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Adress";
            textBox3.Visible = true;
            label4.Visible = false;
            label4.Text = "";
            textBox4.Visible = false;
            label5.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Visible = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Visible = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Visible = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Visible = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Visible = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Visible = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Visible = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Visible = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Visible = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Visible = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Visible = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Visible = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Visible = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Visible = false;
        }

        private void сделкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = сделкаBindingSource;
            TabN = 8;
            label1.Visible = true;
            label1.Text = "SellID";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "SotrID";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Passport";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "Cost";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "SaleID";
            textBox5.Visible = true;
            label6.Visible = true;
            label6.Text = "SalonID";
            textBox6.Visible = true;
            label7.Visible = true;
            label7.Text = "VIN";
            textBox7.Visible = true;
            label8.Visible = true;
            label8.Text = "SellDate";
            textBox8.Visible = true;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Visible = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Visible = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Visible = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Visible = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Visible = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Visible = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Visible = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Visible = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Visible = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Visible = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Visible = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Visible = false;
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = сотрудникBindingSource;
            TabN = 9;
            label1.Visible = true;
            label1.Text = "SotrID";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "PostID";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "SalonID";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "Passport";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "Stage";
            textBox5.Visible = true;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Visible = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Visible = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Visible = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Visible = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Visible = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Visible = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Visible = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Visible = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Visible = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Visible = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Visible = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Visible = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Visible = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Visible = false;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = цветBindingSource;
            TabN = 10;
            label1.Visible = true;
            label1.Text = "ColorID";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "ColorName";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "ColorType";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "ColorCost";
            textBox4.Visible = true;
            label5.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            label6.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            label7.Visible = false;
            label7.Text = "";
            textBox7.Visible = false;
            label8.Visible = false;
            label8.Text = "";
            textBox8.Visible = false;
            label9.Visible = false;
            label9.Text = "";
            textBox9.Visible = false;
            label10.Visible = false;
            label10.Text = "";
            textBox10.Visible = false;
            label11.Visible = false;
            label11.Text = "";
            textBox11.Visible = false;
            label12.Visible = false;
            label12.Text = "";
            textBox12.Visible = false;
            label13.Visible = false;
            label13.Text = "";
            textBox13.Visible = false;
            label14.Visible = false;
            label14.Text = "";
            textBox14.Visible = false;
            label15.Visible = false;
            label15.Text = "";
            textBox15.Visible = false;
            label16.Visible = false;
            label16.Text = "";
            textBox16.Visible = false;
            label17.Visible = false;
            label17.Text = "";
            textBox17.Visible = false;
            label18.Visible = false;
            label18.Text = "";
            textBox18.Visible = false;
            label19.Visible = false;
            label19.Text = "";
            textBox19.Visible = false;
            label20.Visible = false;
            label20.Text = "";
            textBox20.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
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
                        автомобильTableAdapter.Update(информационная_система_автосалонаDataSet.Автомобиль);
                        информационная_система_автосалонаDataSet.Автомобиль.AcceptChanges();
                        dataGridView1.Refresh();
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
                        акцииTableAdapter.Update(информационная_система_автосалонаDataSet.Акции);
                        информационная_система_автосалонаDataSet.Акции.AcceptChanges();
                        dataGridView1.Refresh();
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
                        должностьTableAdapter.Update(информационная_система_автосалонаDataSet.Должность);
                        информационная_система_автосалонаDataSet.Должность.AcceptChanges();
                        dataGridView1.Refresh();
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
                        комплектацияTableAdapter.Update(информационная_система_автосалонаDataSet.Комплектация);
                        информационная_система_автосалонаDataSet.Комплектация.AcceptChanges();
                        dataGridView1.Refresh();
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
                        модельTableAdapter.Update(информационная_система_автосалонаDataSet.Модель);
                        информационная_система_автосалонаDataSet.Модель.AcceptChanges();
                        dataGridView1.Refresh();
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
                        паспортTableAdapter.Update(информационная_система_автосалонаDataSet.Паспорт);
                        информационная_система_автосалонаDataSet.Паспорт.AcceptChanges();
                        dataGridView1.Refresh();
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
                    break;

                case 7:
                    try
                    {
                        DataRow nRow = информационная_система_автосалонаDataSet.Салон.NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        информационная_система_автосалонаDataSet.Салон.Rows.Add(nRow);
                        салонTableAdapter.Update(информационная_система_автосалонаDataSet.Салон);
                        информационная_система_автосалонаDataSet.Салон.AcceptChanges();
                        dataGridView1.Refresh();
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
                        сделкаTableAdapter.Update(информационная_система_автосалонаDataSet.Сделка);
                        информационная_система_автосалонаDataSet.Сделка.AcceptChanges();
                        dataGridView1.Refresh();
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
                        сотрудникTableAdapter.Update(информационная_система_автосалонаDataSet.Сотрудник);
                        информационная_система_автосалонаDataSet.Сотрудник.AcceptChanges();
                        dataGridView1.Refresh();
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
                        цветTableAdapter.Update(информационная_система_автосалонаDataSet.Цвет);
                        информационная_система_автосалонаDataSet.Цвет.AcceptChanges();
                        dataGridView1.Refresh();
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
                    break;
                default:
                    break;
            }
        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
