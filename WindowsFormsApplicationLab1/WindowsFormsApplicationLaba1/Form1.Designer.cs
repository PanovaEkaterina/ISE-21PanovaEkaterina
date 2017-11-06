namespace WindowsFormsApplicationLaba1
{
    partial class Formkitchen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_WaterTap_Apple = new System.Windows.Forms.Button();
            this.button_knife_egg = new System.Windows.Forms.Button();
            this.button_knife_apple = new System.Windows.Forms.Button();
            this.button_dough = new System.Windows.Forms.Button();
            this.label_egg = new System.Windows.Forms.Label();
            this.label_apple = new System.Windows.Forms.Label();
            this.numericUpDown_egg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_apple = new System.Windows.Forms.NumericUpDown();
            this.groupBox_products = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_WaterTap = new System.Windows.Forms.GroupBox();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.groupBox_knife = new System.Windows.Forms.GroupBox();
            this.groupBox_dough = new System.Windows.Forms.GroupBox();
            this.checkBox_egg = new System.Windows.Forms.CheckBox();
            this.checkBox_sugar = new System.Windows.Forms.CheckBox();
            this.checkBox_flour = new System.Windows.Forms.CheckBox();
            this.groupBox_pan = new System.Windows.Forms.GroupBox();
            this.button_pan_apple = new System.Windows.Forms.Button();
            this.groupBox_stove = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonCook = new System.Windows.Forms.Button();
            this.buttonAddPan = new System.Windows.Forms.Button();
            this.checkBox1_stove = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_apple)).BeginInit();
            this.groupBox_products.SuspendLayout();
            this.groupBox_WaterTap.SuspendLayout();
            this.groupBox_knife.SuspendLayout();
            this.groupBox_dough.SuspendLayout();
            this.groupBox_pan.SuspendLayout();
            this.groupBox_stove.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_WaterTap_Apple
            // 
            this.button_WaterTap_Apple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WaterTap_Apple.Location = new System.Drawing.Point(20, 74);
            this.button_WaterTap_Apple.Name = "button_WaterTap_Apple";
            this.button_WaterTap_Apple.Size = new System.Drawing.Size(114, 32);
            this.button_WaterTap_Apple.TabIndex = 3;
            this.button_WaterTap_Apple.Text = "Помыть яблоки";
            this.button_WaterTap_Apple.UseVisualStyleBackColor = true;
            this.button_WaterTap_Apple.Click += new System.EventHandler(this.button_WaterTap_Apple_Click);
            // 
            // button_knife_egg
            // 
            this.button_knife_egg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_knife_egg.Location = new System.Drawing.Point(22, 19);
            this.button_knife_egg.Name = "button_knife_egg";
            this.button_knife_egg.Size = new System.Drawing.Size(115, 23);
            this.button_knife_egg.TabIndex = 5;
            this.button_knife_egg.Text = "Разбить яйца";
            this.button_knife_egg.UseVisualStyleBackColor = true;
            this.button_knife_egg.Click += new System.EventHandler(this.button_knife_egg_Click);
            // 
            // button_knife_apple
            // 
            this.button_knife_apple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_knife_apple.Location = new System.Drawing.Point(22, 48);
            this.button_knife_apple.Name = "button_knife_apple";
            this.button_knife_apple.Size = new System.Drawing.Size(115, 23);
            this.button_knife_apple.TabIndex = 6;
            this.button_knife_apple.Text = "Порезать яблоки";
            this.button_knife_apple.UseVisualStyleBackColor = true;
            this.button_knife_apple.Click += new System.EventHandler(this.button_knife_apple_Click);
            // 
            // button_dough
            // 
            this.button_dough.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dough.Location = new System.Drawing.Point(6, 90);
            this.button_dough.Name = "button_dough";
            this.button_dough.Size = new System.Drawing.Size(112, 23);
            this.button_dough.TabIndex = 8;
            this.button_dough.Text = "Замесить тесто";
            this.button_dough.UseVisualStyleBackColor = true;
            this.button_dough.Click += new System.EventHandler(this.button_dough_Click);
            // 
            // label_egg
            // 
            this.label_egg.AutoSize = true;
            this.label_egg.Location = new System.Drawing.Point(6, 27);
            this.label_egg.Name = "label_egg";
            this.label_egg.Size = new System.Drawing.Size(33, 13);
            this.label_egg.TabIndex = 14;
            this.label_egg.Text = "Яйцо";
            // 
            // label_apple
            // 
            this.label_apple.AutoSize = true;
            this.label_apple.Location = new System.Drawing.Point(6, 64);
            this.label_apple.Name = "label_apple";
            this.label_apple.Size = new System.Drawing.Size(45, 13);
            this.label_apple.TabIndex = 17;
            this.label_apple.Text = "Яблоки";
            this.label_apple.Click += new System.EventHandler(this.label_apple_Click);
            // 
            // numericUpDown_egg
            // 
            this.numericUpDown_egg.Location = new System.Drawing.Point(55, 25);
            this.numericUpDown_egg.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_egg.Name = "numericUpDown_egg";
            this.numericUpDown_egg.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_egg.TabIndex = 18;
            this.numericUpDown_egg.ValueChanged += new System.EventHandler(this.numericUpDown_egg_ValueChanged);
            // 
            // numericUpDown_apple
            // 
            this.numericUpDown_apple.Location = new System.Drawing.Point(57, 63);
            this.numericUpDown_apple.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_apple.Name = "numericUpDown_apple";
            this.numericUpDown_apple.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_apple.TabIndex = 21;
            this.numericUpDown_apple.ValueChanged += new System.EventHandler(this.numericUpDown_apple_ValueChanged);
            // 
            // groupBox_products
            // 
            this.groupBox_products.Controls.Add(this.button1);
            this.groupBox_products.Controls.Add(this.label_egg);
            this.groupBox_products.Controls.Add(this.numericUpDown_apple);
            this.groupBox_products.Controls.Add(this.numericUpDown_egg);
            this.groupBox_products.Controls.Add(this.label_apple);
            this.groupBox_products.Location = new System.Drawing.Point(5, 13);
            this.groupBox_products.Name = "groupBox_products";
            this.groupBox_products.Size = new System.Drawing.Size(149, 112);
            this.groupBox_products.TabIndex = 22;
            this.groupBox_products.TabStop = false;
            this.groupBox_products.Text = "Ингредиенты";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 22);
            this.button1.TabIndex = 22;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_WaterTap
            // 
            this.groupBox_WaterTap.Controls.Add(this.radioButtonClose);
            this.groupBox_WaterTap.Controls.Add(this.radioButtonOpen);
            this.groupBox_WaterTap.Controls.Add(this.button_WaterTap_Apple);
            this.groupBox_WaterTap.Location = new System.Drawing.Point(160, 13);
            this.groupBox_WaterTap.Name = "groupBox_WaterTap";
            this.groupBox_WaterTap.Size = new System.Drawing.Size(158, 112);
            this.groupBox_WaterTap.TabIndex = 23;
            this.groupBox_WaterTap.TabStop = false;
            this.groupBox_WaterTap.Text = "Кран";
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Checked = true;
            this.radioButtonClose.Location = new System.Drawing.Point(8, 51);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(63, 17);
            this.radioButtonClose.TabIndex = 5;
            this.radioButtonClose.TabStop = true;
            this.radioButtonClose.Text = "Закрыт";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            this.radioButtonClose.CheckedChanged += new System.EventHandler(this.radioButtonClose_CheckedChanged);
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(8, 26);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(63, 17);
            this.radioButtonOpen.TabIndex = 4;
            this.radioButtonOpen.Text = "Открыт";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // groupBox_knife
            // 
            this.groupBox_knife.Controls.Add(this.button_knife_egg);
            this.groupBox_knife.Controls.Add(this.button_knife_apple);
            this.groupBox_knife.Location = new System.Drawing.Point(324, 13);
            this.groupBox_knife.Name = "groupBox_knife";
            this.groupBox_knife.Size = new System.Drawing.Size(162, 87);
            this.groupBox_knife.TabIndex = 24;
            this.groupBox_knife.TabStop = false;
            this.groupBox_knife.Text = "Нож";
            // 
            // groupBox_dough
            // 
            this.groupBox_dough.Controls.Add(this.checkBox_egg);
            this.groupBox_dough.Controls.Add(this.checkBox_sugar);
            this.groupBox_dough.Controls.Add(this.checkBox_flour);
            this.groupBox_dough.Controls.Add(this.button_dough);
            this.groupBox_dough.Location = new System.Drawing.Point(492, 12);
            this.groupBox_dough.Name = "groupBox_dough";
            this.groupBox_dough.Size = new System.Drawing.Size(133, 123);
            this.groupBox_dough.TabIndex = 25;
            this.groupBox_dough.TabStop = false;
            this.groupBox_dough.Text = "Тарелка";
            // 
            // checkBox_egg
            // 
            this.checkBox_egg.AutoSize = true;
            this.checkBox_egg.Location = new System.Drawing.Point(6, 19);
            this.checkBox_egg.Name = "checkBox_egg";
            this.checkBox_egg.Size = new System.Drawing.Size(52, 17);
            this.checkBox_egg.TabIndex = 10;
            this.checkBox_egg.Text = "Яйцо";
            this.checkBox_egg.UseVisualStyleBackColor = true;
            this.checkBox_egg.CheckedChanged += new System.EventHandler(this.checkBox_egg_CheckedChanged);
            // 
            // checkBox_sugar
            // 
            this.checkBox_sugar.AutoSize = true;
            this.checkBox_sugar.Location = new System.Drawing.Point(6, 42);
            this.checkBox_sugar.Name = "checkBox_sugar";
            this.checkBox_sugar.Size = new System.Drawing.Size(56, 17);
            this.checkBox_sugar.TabIndex = 11;
            this.checkBox_sugar.Text = "Сахар";
            this.checkBox_sugar.UseVisualStyleBackColor = true;
            this.checkBox_sugar.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox_flour
            // 
            this.checkBox_flour.AutoSize = true;
            this.checkBox_flour.Location = new System.Drawing.Point(6, 65);
            this.checkBox_flour.Name = "checkBox_flour";
            this.checkBox_flour.Size = new System.Drawing.Size(52, 17);
            this.checkBox_flour.TabIndex = 12;
            this.checkBox_flour.Text = "Мука";
            this.checkBox_flour.UseVisualStyleBackColor = true;
            this.checkBox_flour.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // groupBox_pan
            // 
            this.groupBox_pan.Controls.Add(this.checkBox3);
            this.groupBox_pan.Controls.Add(this.checkBox2);
            this.groupBox_pan.Controls.Add(this.button_pan_apple);
            this.groupBox_pan.Location = new System.Drawing.Point(15, 165);
            this.groupBox_pan.Name = "groupBox_pan";
            this.groupBox_pan.Size = new System.Drawing.Size(163, 117);
            this.groupBox_pan.TabIndex = 26;
            this.groupBox_pan.TabStop = false;
            this.groupBox_pan.Text = "Форма для выпечки";
            // 
            // button_pan_apple
            // 
            this.button_pan_apple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pan_apple.Location = new System.Drawing.Point(12, 68);
            this.button_pan_apple.Name = "button_pan_apple";
            this.button_pan_apple.Size = new System.Drawing.Size(116, 36);
            this.button_pan_apple.TabIndex = 1;
            this.button_pan_apple.Text = "Выложить в форму";
            this.button_pan_apple.UseVisualStyleBackColor = true;
            this.button_pan_apple.Click += new System.EventHandler(this.button_pan_apple_Click);
            // 
            // groupBox_stove
            // 
            this.groupBox_stove.Controls.Add(this.button2);
            this.groupBox_stove.Controls.Add(this.checkBox1);
            this.groupBox_stove.Controls.Add(this.buttonCook);
            this.groupBox_stove.Controls.Add(this.buttonAddPan);
            this.groupBox_stove.Controls.Add(this.checkBox1_stove);
            this.groupBox_stove.Location = new System.Drawing.Point(270, 146);
            this.groupBox_stove.Name = "groupBox_stove";
            this.groupBox_stove.Size = new System.Drawing.Size(174, 193);
            this.groupBox_stove.TabIndex = 27;
            this.groupBox_stove.TabStop = false;
            this.groupBox_stove.Text = "Духовка";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(24, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Вынуть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(96, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Выкл.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonCook
            // 
            this.buttonCook.Enabled = false;
            this.buttonCook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCook.Location = new System.Drawing.Point(24, 98);
            this.buttonCook.Name = "buttonCook";
            this.buttonCook.Size = new System.Drawing.Size(120, 41);
            this.buttonCook.TabIndex = 2;
            this.buttonCook.Text = "Готовить";
            this.buttonCook.UseVisualStyleBackColor = true;
            this.buttonCook.Click += new System.EventHandler(this.аа_Click);
            // 
            // buttonAddPan
            // 
            this.buttonAddPan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPan.Location = new System.Drawing.Point(24, 51);
            this.buttonAddPan.Name = "buttonAddPan";
            this.buttonAddPan.Size = new System.Drawing.Size(120, 41);
            this.buttonAddPan.TabIndex = 1;
            this.buttonAddPan.Text = "Поставить шарлотку в печь";
            this.buttonAddPan.UseVisualStyleBackColor = true;
            this.buttonAddPan.Click += new System.EventHandler(this.buttonGetPan_Click);
            // 
            // checkBox1_stove
            // 
            this.checkBox1_stove.AutoSize = true;
            this.checkBox1_stove.Location = new System.Drawing.Point(42, 28);
            this.checkBox1_stove.Name = "checkBox1_stove";
            this.checkBox1_stove.Size = new System.Drawing.Size(48, 17);
            this.checkBox1_stove.TabIndex = 0;
            this.checkBox1_stove.Text = "Вкл.";
            this.checkBox1_stove.UseVisualStyleBackColor = true;
            this.checkBox1_stove.CheckedChanged += new System.EventHandler(this.checkBox1_stove_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Выложить яблоки";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 45);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(93, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Залить тесто";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // Formkitchen
            // 
            this.ClientSize = new System.Drawing.Size(631, 339);
            this.Controls.Add(this.groupBox_stove);
            this.Controls.Add(this.groupBox_pan);
            this.Controls.Add(this.groupBox_dough);
            this.Controls.Add(this.groupBox_knife);
            this.Controls.Add(this.groupBox_WaterTap);
            this.Controls.Add(this.groupBox_products);
            this.HelpButton = true;
            this.Name = "Formkitchen";
            this.Text = "Кухня";
            this.Load += new System.EventHandler(this.Formkitchen_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_apple)).EndInit();
            this.groupBox_products.ResumeLayout(false);
            this.groupBox_products.PerformLayout();
            this.groupBox_WaterTap.ResumeLayout(false);
            this.groupBox_WaterTap.PerformLayout();
            this.groupBox_knife.ResumeLayout(false);
            this.groupBox_dough.ResumeLayout(false);
            this.groupBox_dough.PerformLayout();
            this.groupBox_pan.ResumeLayout(false);
            this.groupBox_pan.PerformLayout();
            this.groupBox_stove.ResumeLayout(false);
            this.groupBox_stove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_WaterTap_Apple;
        private System.Windows.Forms.Button button_knife_apple;
        private System.Windows.Forms.Button button_dough;
        private System.Windows.Forms.Button button_knife_egg;
        private System.Windows.Forms.Label label_egg;
        private System.Windows.Forms.Label label_apple;
        private System.Windows.Forms.NumericUpDown numericUpDown_egg;
        private System.Windows.Forms.NumericUpDown numericUpDown_apple;
        private System.Windows.Forms.GroupBox groupBox_products;
        private System.Windows.Forms.GroupBox groupBox_WaterTap;
        private System.Windows.Forms.GroupBox groupBox_knife;
        private System.Windows.Forms.GroupBox groupBox_dough;
        private System.Windows.Forms.GroupBox groupBox_pan;
        private System.Windows.Forms.Button button_pan_apple;
        private System.Windows.Forms.GroupBox groupBox_stove;
        private System.Windows.Forms.Button buttonAddPan;
        private System.Windows.Forms.CheckBox checkBox1_stove;
        private System.Windows.Forms.Button buttonCook;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox_egg;
        private System.Windows.Forms.CheckBox checkBox_sugar;
        private System.Windows.Forms.CheckBox checkBox_flour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

