using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) & !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                double number = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);
                double result = number + number2;
                label3.Text = $"Результат: {textBox1.Text + "+" + textBox2.Text + "=" + result}";
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) & !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                double number = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);
                double result = number - number2;
                label3.Text = $"Результат: {textBox1.Text+"-"+textBox2.Text+"="+result}";
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) & !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                double number = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);
                double result = number * number2;
                label3.Text = $"Результат: {textBox1.Text + "*" + textBox2.Text + "=" + result}";
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) & !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                double number = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);
                if(number2 != 0)
                {
                    double result = number / number2;
                    label3.Text = $"Результат: {textBox1.Text + "/" + textBox2.Text + "=" + result}";
                }
                else
                {
                    label3.Text = $"Результат: {textBox1.Text + "/" + textBox2.Text + "=" + 0}";
                }
                
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
           
    }

}
