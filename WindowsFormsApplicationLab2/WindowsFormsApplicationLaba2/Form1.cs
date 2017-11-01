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
        Color color;
        Color dopColor;
        int weight;
        int price;
        int hardness;

        private Stone inter;
        public Form1()
        {
            InitializeComponent();
            color = Color.White;
            dopColor = Color.Yellow;
            weight = 15;
            price = 5000;
            hardness = 10;
            buttonSelectColor.BackColor = color;
            buttonSelectDopColor.BackColor = dopColor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                buttonSelectColor.BackColor = color;
            }
        }

        private void buttonSelectDopColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                buttonSelectDopColor.BackColor = dopColor;
            }
        }

        private bool checkFields()
        {
            if (!int.TryParse(textBoxWeight.Text, out weight))
            {
                return false;
            }
            if (!int.TryParse(textBoxPrice.Text, out price))
            {
                return false;
            }
            if (!int.TryParse(textBoxHardness.Text, out hardness))
            {
                return false;
            }
            return true;
        }

        private void buttonSetAdamant_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Adamant(weight, price, hardness, color);
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawStone(gr);
                pictureBox.Image = bmp;
            }
        }

        private void buttonSetDiamond_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Diamond(weight, price,hardness,color, checkBoxFacet.Checked,  dopColor);
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawStone(gr);
                pictureBox.Image = bmp;
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
    }
}
