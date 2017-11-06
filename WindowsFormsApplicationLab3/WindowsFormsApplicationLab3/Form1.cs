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
            parking = new Parking();
            Draw();

        }

       private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr, pictureBoxParking.Width, pictureBoxParking.Height);
            pictureBoxParking.Image = bmp;
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
            if (maskedTextBox1.Text != "")
            {
                var car = parking.GetStoneInShowcase(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBoxpictureBoxTakeStone.Width, pictureBoxpictureBoxTakeStone.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.setPosition(5, 5);
                car.drawStone(gr);
                pictureBoxpictureBoxTakeStone.Image = bmp;
                Draw();
            }
        }

    }
}
