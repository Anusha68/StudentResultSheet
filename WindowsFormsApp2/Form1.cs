using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int num1, num2, num3, num4, num5, Total, Average;

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Student Name: " +textBox1.Text+ 
                " Student No: " + textBox2.Text +
                " Total: " + label13.Text +
                " Average: " + label14.Text;
            string title = "Student Result Report!";
            MessageBox.Show(message, title);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToInt32(textBox3.Text);
            if (num1 >= 75)
            {
                label15.Text = "A";
            }
            else if (num1 >= 65 && num1 <75)
            {
                label15.Text = "B";
            }
            else if (num1 >= 55 && num1 <65)
            {
                label15.Text = "C";
            }
            else if (num1 >= 35 && num1 <55)
            {
                label15.Text = "S";
            }
            else if (num1 < 35)
            {
                label15.Text = "F";
            }

            num2 = Convert.ToInt32(textBox4.Text);

            if (num2 >= 75)
            {
                label16.Text = "A";
            }
            else if (num2 >= 65 && num2 <75)
            {
                label16.Text = "B";
            }
            else if (num2 >= 55 && num2 <65)
            {
                label16.Text = "C";
            }
            else if (num2 >= 35 && num2 <55)
            {
                label16.Text = "S";
            }
            else if (num2 < 35)
            {
                label16.Text = "F";
            }

            num3 = Convert.ToInt32(textBox5.Text);
            
            if (num3 >= 75)
            {
                label17.Text = "A";
            }
            else if (num3 >= 65 && num3 <75)
            {
                label17.Text = "B";
            }
            else if (num3 >= 55 && num3 <65)
            {
                label17.Text = "C";
            }
            else if (num3 >= 35 && num3 <55)
            {
                label17.Text = "S";
            }
            else if (num3 < 35)
            {
                label17.Text = "F";
            }

            num4 = Convert.ToInt32(textBox6.Text);
            
            if (num4 >= 75)
            {
                label18.Text = "A";
            }
            else if (num4 >= 65 && num4 <75)
            {
                label18.Text = "B";
            }
            else if (num4 >= 55 && num4 <65)
            {
                label18.Text = "C";
            }
            else if (num4 >= 35 && num4 <55)
            {
                label18.Text = "S";
            }
            else if (num4 < 35)
            {
                label18.Text = "F";
            }

            num5 = Convert.ToInt32(textBox7.Text);
            if (num5 >= 75)
            {
                label19.Text = "A";
            }
            else if (num5 >= 65 && num5 <75)
            {
                label19.Text = "B";
            }
            else if (num5 >= 55 && num5 <65)
            {
                label19.Text = "C";
            }
            else if (num5 >= 35 && num5 <55)
            {
                label19.Text = "S";
            }
            else if (num5 < 35 )
            {
                label19.Text = "F";
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            num1 = Convert.ToInt32(textBox3.Text);
            num2 = Convert.ToInt32(textBox4.Text);
            num3 = Convert.ToInt32(textBox5.Text);
            num4 = Convert.ToInt32(textBox6.Text);
            num5 = Convert.ToInt32(textBox7.Text);


            Total = num1 + num2 + num3 + num4 + num5;
            label13.Text = Total.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Average = Total / 5;
            label14.Text = Average.ToString();
        }
    }
}
