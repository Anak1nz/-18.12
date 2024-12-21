using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Работа_за_18._12
{
    public partial class Form1 : Form
    {
        private string[] route1Times = { "08:00", "12:00", "16:00", "20:00" };
        private string[] route2Times = { "09:00", "13:00", "17:00", "21:00" };
        private string[] route3Times = { "10:00", "14:00", "18:00" };
        private string[] route4Times = { "11:00", "12:00", "15:00" };
        private string[] route5Times = { "15:00", "17:00", "21:00" };
        private decimal totalAmount = 0;
        private decimal previousValue1 = 0; // хранит значения кол-во взрослых
        private decimal previousValue2 = 0; // хранит значение кол-во детей
        private decimal RadioButtonSum = 0; // хранит значение радиокнопки 

        public Form1()
        {
            InitializeComponent();
            ComboBoxes();
        }

        private void ComboBoxes()
        {
            comboBox1.Items.Add("Москва - Питер");
            comboBox1.Items.Add("Питер - Москва");
            comboBox1.Items.Add("Краснодар - Екатеринбург");
            comboBox1.Items.Add("Екатеринбург - Краснодар");
            comboBox1.Items.Add("Сочи - Мурманск");
            comboBox1.Items.Add("Мурманск - Сочи");
            comboBox1.Items.Add("Владивосток - Москва");
            comboBox1.Items.Add("Москва - Владивосток");
            comboBox1.Items.Add("Новосибирск - Екатеринбург");
            comboBox1.Items.Add("Екатеринбург - Новосибирск");
            comboBox1.SelectedIndex = 0;

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            UpdateTimeComboBox();

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTimeComboBox();
        }
        private void UpdateTimeComboBox()
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.AddRange(route1Times);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.AddRange(route2Times);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.AddRange(route3Times);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.AddRange(route4Times);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Items.AddRange(route5Times);
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                comboBox2.Items.AddRange(route4Times);
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                comboBox2.Items.AddRange(route5Times);
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                comboBox2.Items.AddRange(route4Times);
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                comboBox2.Items.AddRange(route2Times);
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                comboBox2.Items.AddRange (route1Times);
            }

         
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            if (clickedButton.BackColor == Color.Lime)
            {
                clickedButton.BackColor = Color.Red;
            }
            else
                clickedButton.BackColor = Color.Lime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click += Button_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click += Button_Click;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Click += Button_Click;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Click += Button_Click;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Click += Button_Click;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Click += Button_Click;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Click += Button_Click;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button9.Click += Button_Click;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Click += Button_Click;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Click += Button_Click;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Click += Button_Click;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Click += Button_Click;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Click += Button_Click;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Click += Button_Click;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Click += Button_Click;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Click += Button_Click;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal change = numericUpDown1.Value - previousValue1;

           
            if (change > 0)
            {
                totalAmount += change * 1000;
            }
           
            else if (change < 0)
            {
                totalAmount += change * 1000;  
            }

            
            previousValue1 = numericUpDown1.Value; // обновление предыдущего значения
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            decimal change = numericUpDown2.Value - previousValue2;

            // Если значение увеличилось
            if (change > 0)
            {
                totalAmount += change * 900;
            }
            // Если значение уменьшилось
            else if (change < 0)
            {
                totalAmount += change * 900;  
            }

            // Обновляем предыдущее значение
            previousValue2 = numericUpDown2.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = !checkBox1.Checked;
                totalAmount *= 1.02m; // Увеличиваем на 2%
            }
            else
            {
                checkBox2.Enabled = true;
                totalAmount /= 1.02m; // Возвращаем назад, если чекбокс не выбран
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = !checkBox2.Checked;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Конечная стоимость билета {totalAmount}");
        }
      

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                //  убираем сумму, добавленную предыдущими радиокнопками
                totalAmount -= RadioButtonSum;
                // Добавляем сумму для radioButton2
                RadioButtonSum = 500;
                totalAmount += RadioButtonSum;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                totalAmount -= RadioButtonSum;
                RadioButtonSum = 1000;
                totalAmount += RadioButtonSum;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                totalAmount -= RadioButtonSum;
                RadioButtonSum = 1500;
                totalAmount += RadioButtonSum;
            }
        }
  
    }
    
}
