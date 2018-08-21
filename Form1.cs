using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dierenpark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        double total = 0;
        int echtpaar = 61;
        int gezinMetEenKind = 71;
        int gezinMetTweeKinderen = 82;
        int persoonlijk = 30;
        int elkKindExtra = 11;
        int echtpaar65 = 65;
        int persoonlijk65 = 26;

        // leeftijd berekenen//

        DateTime date = DateTime.Now;
        DateTime age;

        public int CalculateAge(DateTime birthDate)
        {
            return new DateTime(DateTime.Now.Subtract(birthDate).Ticks).Year;
        }

        public int CalculateAge2(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now < birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          

            /*DateTime van = dateTimePicker1.Value;
            DateTime naar = DateTime.Now;
            TimeSpan Lft = van - naar;
            double dagen = Lft.TotalDays;
            textBox3.Text = (dagen / 365).ToString("0");*/


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                                           
                       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_berekenen_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            total = 0;
            int age = CalculateAge(dateTimePicker2.Value.Date);
            lbl_leeftijd.Text = Convert.ToString(age) + " jaar";

            if (!Empty(textBox1)) total += Convert.ToDouble(textBox1.Text) * echtpaar;
            if (!Empty(textBox2)) total += Convert.ToDouble(textBox2.Text) * gezinMetEenKind;
            if (!Empty(textBox3)) total += Convert.ToDouble(textBox3.Text) * gezinMetTweeKinderen;
            if (!Empty(textBox4)) total += Convert.ToDouble(textBox4.Text) * persoonlijk;
            if (!Empty(textBox5)) total += Convert.ToDouble(textBox5.Text) * elkKindExtra;
            if (!Empty(textBox6)) total += Convert.ToDouble(textBox6.Text) * persoonlijk65;
            if (!Empty(textBox8)) total += Convert.ToDouble(textBox8.Text) * echtpaar65;
            textBox7.Text = Convert.ToString(total);
        }

        private bool Empty(TextBox textbox)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


       