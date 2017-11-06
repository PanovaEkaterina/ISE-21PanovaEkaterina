namespace WindowsFormsApplicationLab3
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
            this.buttonSetAdamant = new System.Windows.Forms.Button();
            this.buttonSetDiamond = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAnnulment = new System.Windows.Forms.Button();
            this.panelStone = new System.Windows.Forms.Panel();
            this.pictureBoxStone = new System.Windows.Forms.PictureBox();
            this.buttonDopColor = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.groupBoxStone = new System.Windows.Forms.GroupBox();
            this.panelColorBlack = new System.Windows.Forms.Panel();
            this.panelColorWhite = new System.Windows.Forms.Panel();
            this.panelColorRed = new System.Windows.Forms.Panel();
            this.panelColorYellow = new System.Windows.Forms.Panel();
            this.panelColorBlue = new System.Windows.Forms.Panel();
            this.panelColorGray = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelStone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStone)).BeginInit();
            this.groupBoxStone.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSetAdamant
            // 
            this.buttonSetAdamant.AllowDrop = true;
            this.buttonSetAdamant.Location = new System.Drawing.Point(14, 19);
            this.buttonSetAdamant.Name = "buttonSetAdamant";
            this.buttonSetAdamant.Size = new System.Drawing.Size(128, 51);
            this.buttonSetAdamant.TabIndex = 0;
            this.buttonSetAdamant.Text = "Adamant";
            this.buttonSetAdamant.UseVisualStyleBackColor = true;
            this.buttonSetAdamant.Click += new System.EventHandler(this.buttonSetAdamant_Click);
            this.buttonSetAdamant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAdamant_MouseDown);
            // 
            // buttonSetDiamond
            // 
            this.buttonSetDiamond.Location = new System.Drawing.Point(14, 76);
            this.buttonSetDiamond.Name = "buttonSetDiamond";
            this.buttonSetDiamond.Size = new System.Drawing.Size(128, 51);
            this.buttonSetDiamond.TabIndex = 1;
            this.buttonSetDiamond.Text = "Diamond";
            this.buttonSetDiamond.UseVisualStyleBackColor = true;
            this.buttonSetDiamond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDiamond_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 178);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAnnulment
            // 
            this.buttonAnnulment.Location = new System.Drawing.Point(126, 207);
            this.buttonAnnulment.Name = "buttonAnnulment";
            this.buttonAnnulment.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnulment.TabIndex = 3;
            this.buttonAnnulment.Text = "Отмена";
            this.buttonAnnulment.UseVisualStyleBackColor = true;
            // 
            // panelStone
            // 
            this.panelStone.AllowDrop = true;
            this.panelStone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStone.Controls.Add(this.pictureBoxStone);
            this.panelStone.Controls.Add(this.buttonDopColor);
            this.panelStone.Controls.Add(this.buttonColor);
            this.panelStone.Location = new System.Drawing.Point(230, 12);
            this.panelStone.Name = "panelStone";
            this.panelStone.Size = new System.Drawing.Size(178, 246);
            this.panelStone.TabIndex = 4;
            this.panelStone.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelStone_DragDrop);
            this.panelStone.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelStone_DragEnter);
            // 
            // pictureBoxStone
            // 
            this.pictureBoxStone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStone.Location = new System.Drawing.Point(17, 12);
            this.pictureBoxStone.Name = "pictureBoxStone";
            this.pictureBoxStone.Size = new System.Drawing.Size(150, 114);
            this.pictureBoxStone.TabIndex = 3;
            this.pictureBoxStone.TabStop = false;
            this.pictureBoxStone.Click += new System.EventHandler(this.pictureBoxStone_Click);
            // 
            // buttonDopColor
            // 
            this.buttonDopColor.AllowDrop = true;
            this.buttonDopColor.Location = new System.Drawing.Point(21, 194);
            this.buttonDopColor.Name = "buttonDopColor";
            this.buttonDopColor.Size = new System.Drawing.Size(138, 36);
            this.buttonDopColor.TabIndex = 2;
            this.buttonDopColor.Text = "Доп. цвет";
            this.buttonDopColor.UseVisualStyleBackColor = true;
            this.buttonDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.buttonDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonColor
            // 
            this.buttonColor.AllowDrop = true;
            this.buttonColor.Location = new System.Drawing.Point(21, 152);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(138, 36);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Основной цвет";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.buttonColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxStone
            // 
            this.groupBoxStone.Controls.Add(this.buttonSetAdamant);
            this.groupBoxStone.Controls.Add(this.buttonSetDiamond);
            this.groupBoxStone.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStone.Name = "groupBoxStone";
            this.groupBoxStone.Size = new System.Drawing.Size(189, 145);
            this.groupBoxStone.TabIndex = 6;
            this.groupBoxStone.TabStop = false;
            this.groupBoxStone.Text = "Тип камня";
            // 
            // panelColorBlack
            // 
            this.panelColorBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlack.Location = new System.Drawing.Point(92, 11);
            this.panelColorBlack.Name = "panelColorBlack";
            this.panelColorBlack.Size = new System.Drawing.Size(40, 48);
            this.panelColorBlack.TabIndex = 0;
            // 
            // panelColorWhite
            // 
            this.panelColorWhite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorWhite.Location = new System.Drawing.Point(14, 74);
            this.panelColorWhite.Name = "panelColorWhite";
            this.panelColorWhite.Size = new System.Drawing.Size(40, 48);
            this.panelColorWhite.TabIndex = 1;
            // 
            // panelColorRed
            // 
            this.panelColorRed.BackColor = System.Drawing.Color.Red;
            this.panelColorRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorRed.Location = new System.Drawing.Point(92, 74);
            this.panelColorRed.Name = "panelColorRed";
            this.panelColorRed.Size = new System.Drawing.Size(40, 48);
            this.panelColorRed.TabIndex = 2;
            // 
            // panelColorYellow
            // 
            this.panelColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelColorYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorYellow.Location = new System.Drawing.Point(14, 139);
            this.panelColorYellow.Name = "panelColorYellow";
            this.panelColorYellow.Size = new System.Drawing.Size(40, 48);
            this.panelColorYellow.TabIndex = 3;
            // 
            // panelColorBlue
            // 
            this.panelColorBlue.BackColor = System.Drawing.Color.Blue;
            this.panelColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlue.Location = new System.Drawing.Point(14, 11);
            this.panelColorBlue.Name = "panelColorBlue";
            this.panelColorBlue.Size = new System.Drawing.Size(40, 48);
            this.panelColorBlue.TabIndex = 4;
            // 
            // panelColorGray
            // 
            this.panelColorGray.BackColor = System.Drawing.Color.Gray;
            this.panelColorGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorGray.Location = new System.Drawing.Point(92, 139);
            this.panelColorGray.Name = "panelColorGray";
            this.panelColorGray.Size = new System.Drawing.Size(40, 48);
            this.panelColorGray.TabIndex = 5;
            // 
            // panelColor
            // 
            this.panelColor.AllowDrop = true;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Controls.Add(this.panelColorBlue);
            this.panelColor.Controls.Add(this.panelColorGray);
            this.panelColor.Controls.Add(this.panelColorBlack);
            this.panelColor.Controls.Add(this.panelColorYellow);
            this.panelColor.Controls.Add(this.panelColorWhite);
            this.panelColor.Controls.Add(this.panelColorRed);
            this.panelColor.Location = new System.Drawing.Point(448, 13);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(150, 244);
            this.panelColor.TabIndex = 7;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 328);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.groupBoxStone);
            this.Controls.Add(this.buttonAnnulment);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelStone);
            this.Name = "Form2";
            this.Text = "Form2";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelStone_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelStone_DragEnter);
            this.panelStone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStone)).EndInit();
            this.groupBoxStone.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetAdamant;
        private System.Windows.Forms.Button buttonSetDiamond;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAnnulment;
        private System.Windows.Forms.Panel panelStone;
        private System.Windows.Forms.Button buttonDopColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.GroupBox groupBoxStone;
        private System.Windows.Forms.PictureBox pictureBoxStone;
        private System.Windows.Forms.Panel panelColorBlack;
        private System.Windows.Forms.Panel panelColorWhite;
        private System.Windows.Forms.Panel panelColorRed;
        private System.Windows.Forms.Panel panelColorYellow;
        private System.Windows.Forms.Panel panelColorBlue;
        private System.Windows.Forms.Panel panelColorGray;
        private System.Windows.Forms.Panel panelColor;
    }
}