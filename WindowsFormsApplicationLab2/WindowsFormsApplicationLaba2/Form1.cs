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

        public Form1()
        {
            InitializeComponent();
            parking = new Parking();
            Draw();

        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr, pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bmp;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetAdamant_Click(object sender, EventArgs e)
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
            if (maskedTextBox.Text != "")
            {
                var car = parking.GetStoneInShowcase(Convert.ToInt32(maskedTextBox.Text));

                Bitmap bmp = new Bitmap(pictureBoxTakeStone.Width, pictureBoxTakeStone.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.setPosition(5, 5);
                car.drawStone(gr);
                pictureBoxTakeStone.Image = bmp;
                Draw();
            }
        }
    }
}
