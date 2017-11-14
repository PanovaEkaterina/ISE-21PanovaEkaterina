namespace WindowsFormsApplicationLaba2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxStone = new System.Windows.Forms.GroupBox();
            this.buttonDiamond = new System.Windows.Forms.Button();
            this.buttonAdamant = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAnnulment = new System.Windows.Forms.Button();
            this.panelStone = new System.Windows.Forms.Panel();
            this.buttonDopColor = new System.Windows.Forms.Button();
            this.buttonBaseColor = new System.Windows.Forms.Button();
            this.pictureBoxStone = new System.Windows.Forms.PictureBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelColorBlue = new System.Windows.Forms.Panel();
            this.panelColorGrey = new System.Windows.Forms.Panel();
            this.panelColorRed = new System.Windows.Forms.Panel();
            this.panelColorYellow = new System.Windows.Forms.Panel();
            this.panelColorWhite = new System.Windows.Forms.Panel();
            this.panelColorBlack = new System.Windows.Forms.Panel();
            this.groupBoxStone.SuspendLayout();
            this.panelStone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStone)).BeginInit();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStone
            // 
            this.groupBoxStone.Controls.Add(this.buttonDiamond);
            this.groupBoxStone.Controls.Add(this.buttonAdamant);
            this.groupBoxStone.Location = new System.Drawing.Point(14, 16);
            this.groupBoxStone.Name = "groupBoxStone";
            this.groupBoxStone.Size = new System.Drawing.Size(160, 159);
            this.groupBoxStone.TabIndex = 0;
            this.groupBoxStone.TabStop = false;
            this.groupBoxStone.Text = "Тип камня";
            // 
            // buttonDiamond
            // 
            this.buttonDiamond.AllowDrop = true;
            this.buttonDiamond.Location = new System.Drawing.Point(21, 87);
            this.buttonDiamond.Name = "buttonDiamond";
            this.buttonDiamond.Size = new System.Drawing.Size(102, 41);
            this.buttonDiamond.TabIndex = 1;
            this.buttonDiamond.Text = "Diamond";
            this.buttonDiamond.UseVisualStyleBackColor = true;
            this.buttonDiamond.Click += new System.EventHandler(this.buttonDiamond_Click);
            this.buttonDiamond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDiamond_MouseDown);
            // 
            // buttonAdamant
            // 
            this.buttonAdamant.AllowDrop = true;
            this.buttonAdamant.Location = new System.Drawing.Point(21, 29);
            this.buttonAdamant.Name = "buttonAdamant";
            this.buttonAdamant.Size = new System.Drawing.Size(102, 41);
            this.buttonAdamant.TabIndex = 0;
            this.buttonAdamant.Text = "Adamant";
            this.buttonAdamant.UseVisualStyleBackColor = true;
            this.buttonAdamant.Click += new System.EventHandler(this.labelAdamant_Click);
            this.buttonAdamant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAdamant_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 192);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(72, 22);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAnnulment
            // 
            this.buttonAnnulment.Location = new System.Drawing.Point(101, 221);
            this.buttonAnnulment.Name = "buttonAnnulment";
            this.buttonAnnulment.Size = new System.Drawing.Size(72, 21);
            this.buttonAnnulment.TabIndex = 2;
            this.buttonAnnulment.Text = "Отмена";
            this.buttonAnnulment.UseVisualStyleBackColor = true;
            this.buttonAnnulment.Click += new System.EventHandler(this.buttonAnnulment_Click);
            // 
            // panelStone
            // 
            this.panelStone.AllowDrop = true;
            this.panelStone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStone.Controls.Add(this.buttonDopColor);
            this.panelStone.Controls.Add(this.buttonBaseColor);
            this.panelStone.Controls.Add(this.pictureBoxStone);
            this.panelStone.Location = new System.Drawing.Point(230, 20);
            this.panelStone.Name = "panelStone";
            this.panelStone.Size = new System.Drawing.Size(244, 292);
            this.panelStone.TabIndex = 3;
            this.panelStone.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelStone_DragDrop);
            this.panelStone.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelStone_DragEnter);
            this.panelStone.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStone_Paint);
            // 
            // buttonDopColor
            // 
            this.buttonDopColor.AllowDrop = true;
            this.buttonDopColor.Location = new System.Drawing.Point(44, 229);
            this.buttonDopColor.Name = "buttonDopColor";
            this.buttonDopColor.Size = new System.Drawing.Size(162, 41);
            this.buttonDopColor.TabIndex = 2;
            this.buttonDopColor.Text = "Доп цвет";
            this.buttonDopColor.UseVisualStyleBackColor = true;
            this.buttonDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.buttonDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonBaseColor
            // 
            this.buttonBaseColor.AllowDrop = true;
            this.buttonBaseColor.Location = new System.Drawing.Point(42, 172);
            this.buttonBaseColor.Name = "buttonBaseColor";
            this.buttonBaseColor.Size = new System.Drawing.Size(165, 39);
            this.buttonBaseColor.TabIndex = 1;
            this.buttonBaseColor.Text = "Основной цвет";
            this.buttonBaseColor.UseVisualStyleBackColor = true;
            this.buttonBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.buttonBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBoxStone
            // 
            this.pictureBoxStone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStone.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxStone.Name = "pictureBoxStone";
            this.pictureBoxStone.Size = new System.Drawing.Size(236, 163);
            this.pictureBoxStone.TabIndex = 0;
            this.pictureBoxStone.TabStop = false;
            this.pictureBoxStone.Click += new System.EventHandler(this.pictureBoxStone_Click);
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.panelColorBlue);
            this.panelColor.Controls.Add(this.panelColorGrey);
            this.panelColor.Controls.Add(this.panelColorRed);
            this.panelColor.Controls.Add(this.panelColorYellow);
            this.panelColor.Controls.Add(this.panelColorWhite);
            this.panelColor.Controls.Add(this.panelColorBlack);
            this.panelColor.Location = new System.Drawing.Point(506, 21);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(182, 290);
            this.panelColor.TabIndex = 4;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColorBlue
            // 
            this.panelColorBlue.AllowDrop = true;
            this.panelColorBlue.BackColor = System.Drawing.Color.Blue;
            this.panelColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlue.Location = new System.Drawing.Point(108, 181);
            this.panelColorBlue.Name = "panelColorBlue";
            this.panelColorBlue.Size = new System.Drawing.Size(45, 55);
            this.panelColorBlue.TabIndex = 5;
            // 
            // panelColorGrey
            // 
            this.panelColorGrey.AllowDrop = true;
            this.panelColorGrey.BackColor = System.Drawing.Color.Gray;
            this.panelColorGrey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorGrey.Location = new System.Drawing.Point(16, 181);
            this.panelColorGrey.Name = "panelColorGrey";
            this.panelColorGrey.Size = new System.Drawing.Size(45, 55);
            this.panelColorGrey.TabIndex = 4;
            // 
            // panelColorRed
            // 
            this.panelColorRed.AllowDrop = true;
            this.panelColorRed.BackColor = System.Drawing.Color.Red;
            this.panelColorRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorRed.Location = new System.Drawing.Point(108, 99);
            this.panelColorRed.Name = "panelColorRed";
            this.panelColorRed.Size = new System.Drawing.Size(45, 55);
            this.panelColorRed.TabIndex = 3;
            // 
            // panelColorYellow
            // 
            this.panelColorYellow.AllowDrop = true;
            this.panelColorYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelColorYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorYellow.Location = new System.Drawing.Point(16, 99);
            this.panelColorYellow.Name = "panelColorYellow";
            this.panelColorYellow.Size = new System.Drawing.Size(45, 55);
            this.panelColorYellow.TabIndex = 2;
            // 
            // panelColorWhite
            // 
            this.panelColorWhite.AllowDrop = true;
            this.panelColorWhite.BackColor = System.Drawing.Color.White;
            this.panelColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorWhite.Location = new System.Drawing.Point(108, 18);
            this.panelColorWhite.Name = "panelColorWhite";
            this.panelColorWhite.Size = new System.Drawing.Size(45, 55);
            this.panelColorWhite.TabIndex = 1;
            // 
            // panelColorBlack
            // 
            this.panelColorBlack.AllowDrop = true;
            this.panelColorBlack.BackColor = System.Drawing.Color.Black;
            this.panelColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlack.Location = new System.Drawing.Point(16, 18);
            this.panelColorBlack.Name = "panelColorBlack";
            this.panelColorBlack.Size = new System.Drawing.Size(45, 55);
            this.panelColorBlack.TabIndex = 0;
            this.panelColorBlack.Paint += new System.Windows.Forms.PaintEventHandler(this.panelColorBlack_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 360);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelStone);
            this.Controls.Add(this.buttonAnnulment);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxStone);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBoxStone.ResumeLayout(false);
            this.panelStone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStone)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStone;
        private System.Windows.Forms.Button buttonDiamond;
        private System.Windows.Forms.Button buttonAdamant;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAnnulment;
        private System.Windows.Forms.Panel panelStone;
        private System.Windows.Forms.PictureBox pictureBoxStone;
        private System.Windows.Forms.Button buttonBaseColor;
        private System.Windows.Forms.Button buttonDopColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelColorBlack;
        private System.Windows.Forms.Panel panelColorBlue;
        private System.Windows.Forms.Panel panelColorGrey;
        private System.Windows.Forms.Panel panelColorRed;
        private System.Windows.Forms.Panel panelColorYellow;
        private System.Windows.Forms.Panel panelColorWhite;
    }
}