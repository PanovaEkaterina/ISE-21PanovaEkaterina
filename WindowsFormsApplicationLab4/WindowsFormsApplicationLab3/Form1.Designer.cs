using System;
using System.Windows.Forms;

namespace WindowsFormsApplicationLab3
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.pictureBoxpictureBoxTakeStone = new System.Windows.Forms.PictureBox();
            this.buttonsetAdamant = new System.Windows.Forms.Button();
            this.buttonsetDiamond = new System.Windows.Forms.Button();
            this.groupBoxGetStone = new System.Windows.Forms.GroupBox();
            this.buttonTakeStone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpictureBoxTakeStone)).BeginInit();
            this.groupBoxGetStone.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxParking.Location = new System.Drawing.Point(6, 10);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(724, 396);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            this.pictureBoxParking.Click += new System.EventHandler(this.pictureBoxParking_Click);
            // 
            // pictureBoxpictureBoxTakeStone
            // 
            this.pictureBoxpictureBoxTakeStone.Location = new System.Drawing.Point(746, 7);
            this.pictureBoxpictureBoxTakeStone.Name = "pictureBoxpictureBoxTakeStone";
            this.pictureBoxpictureBoxTakeStone.Size = new System.Drawing.Size(155, 383);
            this.pictureBoxpictureBoxTakeStone.TabIndex = 1;
            this.pictureBoxpictureBoxTakeStone.TabStop = false;
            this.pictureBoxpictureBoxTakeStone.Click += new System.EventHandler(this.pictureBoxpictureBoxTakeStone_Click);
            // 
            // buttonsetAdamant
            // 
            this.buttonsetAdamant.Location = new System.Drawing.Point(772, 174);
            this.buttonsetAdamant.Name = "buttonsetAdamant";
            this.buttonsetAdamant.Size = new System.Drawing.Size(106, 37);
            this.buttonsetAdamant.TabIndex = 0;
            this.buttonsetAdamant.Text = "добавить алмаз";
            this.buttonsetAdamant.UseVisualStyleBackColor = true;
            this.buttonsetAdamant.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsetDiamond
            // 
            this.buttonsetDiamond.Location = new System.Drawing.Point(772, 217);
            this.buttonsetDiamond.Name = "buttonsetDiamond";
            this.buttonsetDiamond.Size = new System.Drawing.Size(106, 42);
            this.buttonsetDiamond.TabIndex = 2;
            this.buttonsetDiamond.Text = "добавить бриллиант ";
            this.buttonsetDiamond.UseVisualStyleBackColor = true;
            this.buttonsetDiamond.Click += new System.EventHandler(this.buttonsetDiamond_Click);
            // 
            // groupBoxGetStone
            // 
            this.groupBoxGetStone.Controls.Add(this.buttonTakeStone);
            this.groupBoxGetStone.Controls.Add(this.label1);
            this.groupBoxGetStone.Controls.Add(this.maskedTextBox1);
            this.groupBoxGetStone.Location = new System.Drawing.Point(763, 265);
            this.groupBoxGetStone.Name = "groupBoxGetStone";
            this.groupBoxGetStone.Size = new System.Drawing.Size(138, 131);
            this.groupBoxGetStone.TabIndex = 3;
            this.groupBoxGetStone.TabStop = false;
            this.groupBoxGetStone.Text = "Забрать камень";
            // 
            // buttonTakeStone
            // 
            this.buttonTakeStone.Location = new System.Drawing.Point(9, 42);
            this.buttonTakeStone.Name = "buttonTakeStone";
            this.buttonTakeStone.Size = new System.Drawing.Size(106, 41);
            this.buttonTakeStone.TabIndex = 2;
            this.buttonTakeStone.Text = "Забрать камень";
            this.buttonTakeStone.UseVisualStyleBackColor = true;
            this.buttonTakeStone.Click += new System.EventHandler(this.buttonTakeStone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Место:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(72, 16);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(763, 28);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(134, 82);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(763, 130);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(38, 19);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.Text = "<<";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(862, 130);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(35, 19);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = ">>";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 418);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxGetStone);
            this.Controls.Add(this.buttonsetDiamond);
            this.Controls.Add(this.buttonsetAdamant);
            this.Controls.Add(this.pictureBoxpictureBoxTakeStone);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpictureBoxTakeStone)).EndInit();
            this.groupBoxGetStone.ResumeLayout(false);
            this.groupBoxGetStone.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBoxParking_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBoxpictureBoxTakeStone_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.PictureBox pictureBoxpictureBoxTakeStone;
        private System.Windows.Forms.Button buttonsetAdamant;
        private System.Windows.Forms.Button buttonsetDiamond;
        private System.Windows.Forms.GroupBox groupBoxGetStone;
        private System.Windows.Forms.Button buttonTakeStone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private ListBox listBoxLevels;
        private Button buttonDown;
        private Button buttonUp;
    }
}