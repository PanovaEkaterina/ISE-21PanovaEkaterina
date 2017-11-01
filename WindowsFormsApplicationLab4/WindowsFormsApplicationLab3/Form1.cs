using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationLab3
{
    public partial class Form1 : Form
    {
        Parking parking;

        public Form1()
        {
            InitializeComponent();
            parking = new Parking(5);
            //заполнение listBox
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }
        /// <summary>
        /// Перемещаемся на нижний уровень парковки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUp_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var stone = new Adamant(100, 4, 1, dialog.Color);
                int place = parking.PutStoneInShowcase(stone);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }

        }

        private void buttonsetDiamond_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var stone = new Diamond(100, 4, 1, dialog.Color, true, dialog.Color);
                    int place = parking.PutStoneInShowcase(stone);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }

        }

        private void buttonTakeStone_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();

                if (maskedTextBox1.Text != "")
                {
                    Stone stone = parking.GetStoneInShowcase(Convert.ToInt32(maskedTextBox1.Text));
                    if (stone != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxpictureBoxTakeStone.Width, pictureBoxpictureBoxTakeStone.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        stone.setPosition(5, 5);
                        stone.drawStone(gr);
                        pictureBoxpictureBoxTakeStone.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Извинте, на этом месте нет машины");
                    }

                }
            }
        }

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

       
    }
}
