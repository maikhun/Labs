using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Lab8
{
    public partial class Form1 : Form
    {
        string str = string.Empty;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "monkey.mp3";
            player.controls.stop();
            timer1.Interval = 1000; //интервал в 1 секунду
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox2.SelectedItem != null)
                {
                    if (comboBox3.SelectedItem != null)
                    {
                        if (button1.Enabled)
                        {
                                timer1.Start();
                        }
                    } else
                    {
                        MessageBox.Show("Бесконечно? О_о");
                    }
                } else
                {
                    MessageBox.Show("Выберите количество ломтиков");
                }
                
            } else
            {
                MessageBox.Show("Вы перепутали кота с хлебом....");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PrepareFood.Increment(1); //каждую секунду добавляем 1
            if (PrepareFood.Value == PrepareFood.Maximum) //как только достигнет максимума
            {
                timer1.Stop(); //останавливаем таймер
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                player.controls.play();
                if (MessageBox.Show($"{comboBox1.SelectedItem} хлеб поджарился!\n" +
                    $"Степень прожарки: {str}\n" +
                    $"Количество ломтиков: {comboBox2.SelectedItem}", "SmartТостер") == DialogResult.OK)
                {
                    player.controls.stop();
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                str = "не прожаренный";
                PrepareFood.Maximum = 10; //10 cекунд
            } else if (comboBox3.SelectedIndex == 1)
            {
                str = "нормальная прожарка";
                PrepareFood.Maximum = 30; //30 cекунд
            } else if (comboBox3.SelectedIndex == 2)
            {
                str = "идеально прожаренный";
                PrepareFood.Maximum = 40; //40 cекунд
            } else if (comboBox3.SelectedIndex == 3)
            {
                str = "пережаренный";
                PrepareFood.Maximum = 60; //60 cекунд
            }
        }
    }
}
