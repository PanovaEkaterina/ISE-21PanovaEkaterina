using NLog;
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

    public partial class Form2 : Form
    {
        private Logger log;
        Stone stone = null;
        public Stone getStone { get { return stone; } }

        private void DrawStone()
        {
            if (stone != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxStone.Width, pictureBoxStone.Height);
                Graphics gr = Graphics.FromImage(bmp);
                stone.setPosition(50, 50);
                stone.drawStone(gr);
                pictureBoxStone.Image = bmp;
            }
        }

        private event myDel eventAddStone;

        public void AddEvent(myDel ev)
        {
            if (eventAddStone == null)
            {
                eventAddStone = new myDel(ev);
            }
            else eventAddStone += ev;
        }

        public Form2()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
            panelColorBlack.MouseDown += panelColor_MouseDown;
            panelColorYellow.MouseDown += panelColor_MouseDown;
            panelColorWhite.MouseDown += panelColor_MouseDown;
            panelColorRed.MouseDown += panelColor_MouseDown;
            panelColorGrey.MouseDown += panelColor_MouseDown;
            panelColorBlue.MouseDown += panelColor_MouseDown;

            buttonAnnulment.Click += (object sender, EventArgs e) => { Close(); };
            
        }

        private void labelAdamant_MouseDown(object sender, MouseEventArgs e)
        {
            log.Info("Перемещение алмаза");
            buttonAdamant.DoDragDrop(buttonAdamant.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelAdamant_Click(object sender, EventArgs e)
        {

        }

        private void buttonDiamond_Click(object sender, EventArgs e)
        {

        }

        private void labelDiamond_MouseDown(object sender, MouseEventArgs e)
        {
            log.Info("Перемещение бриллианта");
            buttonDiamond.DoDragDrop(buttonDiamond.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            log.Info("Добавление камня");
            if (eventAddStone != null)
            {
                eventAddStone(stone);
            }
            Close();
        }

        private void buttonAnnulment_Click(object sender, EventArgs e)
        {

        }

        private void panelStone_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelStone_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Adamant":
                    stone = new Adamant(100, 4, 500, Color.Black);
                    break;
                case "Diamond":
                    stone = new Diamond(100, 4, 500, Color.Black, true, Color.Black);
                    break;
            }
            DrawStone();
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            log.Info("Выбор цвета:" + (Color)e.Data.GetData(typeof(Color)));
            if (stone != null)
            {
                stone.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawStone();
            }
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            log.Info("Выбор доп.цвета:" + (Color)e.Data.GetData(typeof(Color)));
            if (stone != null)
            {
                if (stone is Diamond)
                {
                    (stone as Diamond).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawStone();
                }
            }      
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelColorBlack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxStone_Click(object sender, EventArgs e)
        {

        }

        private void panelStone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBaseColor_Click(object sender, EventArgs e)
        {

        }
    }
    }
