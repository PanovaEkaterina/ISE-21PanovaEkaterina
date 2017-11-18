using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationLaba2
{
    public partial class Form1 : Form
    {
        Parking parking;
        Form2 form;

        public Form1()
        {
            InitializeComponent();
            parking = new Parking(5);
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
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr);
                pictureBox.Image = bmp;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetAdamant_Click(object sender, EventArgs e)
        {
            form = new Form2();
            form.AddEvent(AddStone);
            form.Show();
        }

        public void AddStone(Stone stone)
        {
            if (stone != null)
            {
                int place = parking.PutStoneInShowcase(stone);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место:" + place);
                }
                else MessageBox.Show("Машину не удалось поставить");
            }
        }

        private void buttonSetDiamond_Click(object sender, EventArgs e)
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

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHardness_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFacet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();

                if (maskedTextBox.Text != "")
                {
                    Stone stone = parking.GetStoneInShowcase(Convert.ToInt32(maskedTextBox.Text));
                    if (stone != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeStone.Width, pictureBoxTakeStone.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        stone.setPosition(5, 5);
                        stone.drawStone(gr);
                        pictureBoxTakeStone.Image = bmp;
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

        private void buttonDown_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
