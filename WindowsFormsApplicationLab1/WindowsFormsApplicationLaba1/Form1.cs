using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationLaba1
{
    public partial class Formkitchen : System.Windows.Forms.Form
    {
        private Egg[] eggs;

        private Sugar sugar;

        private Flour flour;

        private Dough d;

        private Apple[] apples;

        private WaterTap waterTap;

        private Knife knife;

        private Pan pan;

        private Stove stove;

        public Formkitchen()
        {
            InitializeComponent();
        }

        private void Formkitchen_Load_1(object sender, EventArgs e)
        {
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
            d = new Dough();
            sugar = new Sugar();
            flour = new Flour();
        }

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                waterTap.Open = true;
                radioButtonClose.Checked = false;
            }
        }

        private void radioButtonClose_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClose.Checked)
            {
                waterTap.Open = false;
            }
        }

        private void checkBox1_stove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_stove.Checked)
            {
                checkBox1.Checked = false;
                stove.State = true;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                stove.State = false;
            }
            
        }

        private void button_WaterTap_Apple_Click(object sender, EventArgs e)
        {
           
            if (numericUpDown_apple.Value > 0)
            {
                if (waterTap.Open)
                {
                    for (int i = 0; i < apples.Length; ++i)
                    {
                        apples[i].Dirty = false;
                    }
                    pan.Init(apples.Length);
                    numericUpDown_apple.Enabled = false;
                    radioButtonClose.Checked = true;
                    MessageBox.Show("Яблоки помыли, можно резать.", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Яблок то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_knife_egg_Click(object sender, EventArgs e)
        {      

            if (eggs == null)
            {
                MessageBox.Show("Яиц то нет, что разбивать собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (eggs.Length == 0)
            {
                MessageBox.Show("Яиц то нет, что разбивать собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < eggs.Length; i++)
            {
                eggs[i].Have_shell_egg = false;
            }

            for (int i = 0; i < eggs.Length; ++i)
            {
                knife.Cut_Egg(eggs[i]);
            }
            numericUpDown_egg.Enabled = false;
            MessageBox.Show("Яйца разбили.", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_knife_apple_Click(object sender, EventArgs e)
        {
            if (apples == null)
            {
                MessageBox.Show("Яблок то нет, что резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (apples.Length == 0)
            {
                MessageBox.Show("Яблок то нет, что резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < apples.Length; ++i)
            {
                if (apples[i].Dirty)
                {
                    MessageBox.Show("Яблоки грязные! Сначала помыть, затем резать!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }          

            for (int i = 0; i < apples.Length; i++)
            {
                knife.Cut_Apple(apples[i]);
            }

            MessageBox.Show("Яблоки нарезали.", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_dough_Click(object sender, EventArgs e)
        {
            if ((eggs != null) && (eggs.Length != 0))
            {
                for (int i = 0; i < eggs.Length; i++)
                {
                    if(eggs[i].Have_shell_egg == true)
                    {
                        MessageBox.Show("Яица не разбиты!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if ((eggs == null) || (!checkBox_egg.Checked))
            {
                MessageBox.Show("Нет яиц!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((eggs.Length == 0) || (!checkBox_egg.Checked))
            {
                MessageBox.Show("Нет яиц!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                for (int i = 0; i < eggs.Length; i++)
                {
                    d.AddEgg(eggs[i]);
                }
            }
                       
            if (!sugar.Count_Sugar)
            {
                MessageBox.Show("Добавьте сахар!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                sugar = new Sugar();
                d.AddSugar(sugar);
            }
            if (!flour.Count_Flour)
            {
                MessageBox.Show("Добавьте муку!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                flour = new Flour();
                d.AddFlour(flour);
            }            
            MessageBox.Show("Тесто замешано.", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button_dough.Enabled = false;
        }

        private void button_pan_apple_Click(object sender, EventArgs e)
        {
            if (apples==null)
            {
                MessageBox.Show("Яблок нет. Что выкладывать?", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (apples.Length == 0)
            {
                MessageBox.Show("Яблок нет. Что выкладывать?", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 0; i < apples.Length; i++)
            {
                if (apples[i].Have_skin_apple)
                {
                    MessageBox.Show("Cначала нужно нарезать яблоки, а затем выкладывать!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (!checkBox2.Checked)
            {
                MessageBox.Show("Выложите в форму яблоки!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < apples.Length; ++i)
                {
                    pan.AddApple(apples[i]);
                }
            }

                       
            for (int i = 0; i < eggs.Length; i++)
            {
                if (eggs[i].Have_shell_egg)
                {
                  MessageBox.Show("Сначала разбейте яица, затем замесите тесто!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } 
            
            if (!checkBox3.Checked)
            {
                MessageBox.Show(" Залейте тесто!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                pan.AddDough(d);
            }

            if ((checkBox3.Checked) && (checkBox2.Checked)) {
                MessageBox.Show("Можно ставить в духовку.", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_pan_apple.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sugar.Checked)
            {
                sugar.Count_Sugar = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_flour.Checked)
            {
                flour.Count_Flour = true;
            }
        }

        private void аа_Click(object sender, EventArgs e)
        {
            if (pan.IsReadyPan())
            {
                stove.Cook();
                MessageBox.Show("Готово! Можно вынимать.", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1_stove.Checked = false;
                checkBox1.Checked = true;
                button2.Enabled = true;
            }         
        }

        private void buttonGetPan_Click(object sender, EventArgs e)
        {
            if (stove.State)
            {
                if (!pan.Check())
                {
                    MessageBox.Show("Что ставить будем?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    stove.Pan = pan;
                    MessageBox.Show("Поставили в духовку!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonCook.Enabled = true;
                }
            }
            else MessageBox.Show("Включите духовку!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown_egg.Value == 0)
            {
                MessageBox.Show("Добавьте яица!", "Ингредиенты", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (numericUpDown_apple.Value == 0)
            {
                MessageBox.Show("Добавьте яблоки!", "Ингредиенты", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if ((numericUpDown_apple.Value > 0)&&(numericUpDown_egg.Value > 0))
            {
                MessageBox.Show("Ингредиенты добавлены.", "Ингредиенты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
            }


            apples = new Apple[Convert.ToInt32(numericUpDown_apple.Value)];
            for (int i = 0; i < apples.Length; i++)
            {
                apples[i] = new Apple();
            }

            eggs = new Egg[Convert.ToInt32(numericUpDown_egg.Value)];
            d.Init(eggs.Length);
            for (int i = 0; i < eggs.Length; i++)
            {
                eggs[i] = new Egg();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Приятного аппетита!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }


        private void button_pan_dough_Click(object sender, EventArgs e)
        {


        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown_apple_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_egg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_flour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_flour_Click(object sender, EventArgs e)
        {

        }

        private void label_apple_Click(object sender, EventArgs e)
        {

        }



        private void numericUpDown_egg_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_sugar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
