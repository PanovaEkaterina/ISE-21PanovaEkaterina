namespace WindowsFormsApplicationLaba2
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelHardness = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.labelfacet = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.buttonSelectDopColor = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxHardness = new System.Windows.Forms.TextBox();
            this.checkBoxFacet = new System.Windows.Forms.CheckBox();
            this.buttonSetAdamant = new System.Windows.Forms.Button();
            this.buttonSetDiamond = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(13, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(826, 236);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(15, 271);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(26, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(15, 301);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            // 
            // labelHardness
            // 
            this.labelHardness.AutoSize = true;
            this.labelHardness.Location = new System.Drawing.Point(166, 271);
            this.labelHardness.Name = "labelHardness";
            this.labelHardness.Size = new System.Drawing.Size(61, 13);
            this.labelHardness.TabIndex = 3;
            this.labelHardness.Text = "Твердость";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(166, 301);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(32, 13);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Цвет";
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(220, 298);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(49, 19);
            this.buttonSelectColor.TabIndex = 5;
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // labelfacet
            // 
            this.labelfacet.AutoSize = true;
            this.labelfacet.Location = new System.Drawing.Point(330, 276);
            this.labelfacet.Name = "labelfacet";
            this.labelfacet.Size = new System.Drawing.Size(37, 13);
            this.labelfacet.TabIndex = 6;
            this.labelfacet.Text = "Грани";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AutoSize = true;
            this.labelDopColor.Location = new System.Drawing.Point(330, 304);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(32, 13);
            this.labelDopColor.TabIndex = 7;
            this.labelDopColor.Text = "Цвет";
            // 
            // buttonSelectDopColor
            // 
            this.buttonSelectDopColor.Location = new System.Drawing.Point(368, 301);
            this.buttonSelectDopColor.Name = "buttonSelectDopColor";
            this.buttonSelectDopColor.Size = new System.Drawing.Size(49, 19);
            this.buttonSelectDopColor.TabIndex = 8;
            this.buttonSelectDopColor.UseVisualStyleBackColor = true;
            this.buttonSelectDopColor.Click += new System.EventHandler(this.buttonSelectDopColor_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(60, 268);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(41, 20);
            this.textBoxWeight.TabIndex = 9;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(60, 300);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(41, 20);
            this.textBoxPrice.TabIndex = 10;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxHardness
            // 
            this.textBoxHardness.Location = new System.Drawing.Point(233, 268);
            this.textBoxHardness.Name = "textBoxHardness";
            this.textBoxHardness.Size = new System.Drawing.Size(41, 20);
            this.textBoxHardness.TabIndex = 11;
            this.textBoxHardness.TextChanged += new System.EventHandler(this.textBoxHardness_TextChanged);
            // 
            // checkBoxFacet
            // 
            this.checkBoxFacet.AutoSize = true;
            this.checkBoxFacet.Location = new System.Drawing.Point(373, 275);
            this.checkBoxFacet.Name = "checkBoxFacet";
            this.checkBoxFacet.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFacet.TabIndex = 12;
            this.checkBoxFacet.UseVisualStyleBackColor = true;
            this.checkBoxFacet.CheckedChanged += new System.EventHandler(this.checkBoxFacet_CheckedChanged);
            // 
            // buttonSetAdamant
            // 
            this.buttonSetAdamant.Location = new System.Drawing.Point(494, 274);
            this.buttonSetAdamant.Name = "buttonSetAdamant";
            this.buttonSetAdamant.Size = new System.Drawing.Size(127, 24);
            this.buttonSetAdamant.TabIndex = 13;
            this.buttonSetAdamant.Text = "Задать алмаз";
            this.buttonSetAdamant.UseVisualStyleBackColor = true;
            this.buttonSetAdamant.Click += new System.EventHandler(this.buttonSetAdamant_Click);
            // 
            // buttonSetDiamond
            // 
            this.buttonSetDiamond.Location = new System.Drawing.Point(494, 306);
            this.buttonSetDiamond.Name = "buttonSetDiamond";
            this.buttonSetDiamond.Size = new System.Drawing.Size(127, 24);
            this.buttonSetDiamond.TabIndex = 14;
            this.buttonSetDiamond.Text = "Задать бриллиант";
            this.buttonSetDiamond.UseVisualStyleBackColor = true;
            this.buttonSetDiamond.Click += new System.EventHandler(this.buttonSetDiamond_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 342);
            this.Controls.Add(this.buttonSetDiamond);
            this.Controls.Add(this.buttonSetAdamant);
            this.Controls.Add(this.checkBoxFacet);
            this.Controls.Add(this.textBoxHardness);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.buttonSelectDopColor);
            this.Controls.Add(this.labelDopColor);
            this.Controls.Add(this.labelfacet);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelHardness);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelHardness;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Label labelfacet;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Button buttonSelectDopColor;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxHardness;
        private System.Windows.Forms.CheckBox checkBoxFacet;
        private System.Windows.Forms.Button buttonSetAdamant;
        private System.Windows.Forms.Button buttonSetDiamond;
    }
}

