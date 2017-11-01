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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTakeStone = new System.Windows.Forms.Button();
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
            this.pictureBoxParking.Size = new System.Drawing.Size(607, 339);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            this.pictureBoxParking.Click += new System.EventHandler(this.pictureBoxParking_Click);
            // 
            // pictureBoxpictureBoxTakeStone
            // 
            this.pictureBoxpictureBoxTakeStone.Location = new System.Drawing.Point(619, 10);
            this.pictureBoxpictureBoxTakeStone.Name = "pictureBoxpictureBoxTakeStone";
            this.pictureBoxpictureBoxTakeStone.Size = new System.Drawing.Size(155, 338);
            this.pictureBoxpictureBoxTakeStone.TabIndex = 1;
            this.pictureBoxpictureBoxTakeStone.TabStop = false;
            this.pictureBoxpictureBoxTakeStone.Click += new System.EventHandler(this.pictureBoxpictureBoxTakeStone_Click);
            // 
            // buttonsetAdamant
            // 
            this.buttonsetAdamant.Location = new System.Drawing.Point(644, 23);
            this.buttonsetAdamant.Name = "buttonsetAdamant";
            this.buttonsetAdamant.Size = new System.Drawing.Size(106, 37);
            this.buttonsetAdamant.TabIndex = 0;
            this.buttonsetAdamant.Text = "добавить алмаз";
            this.buttonsetAdamant.UseVisualStyleBackColor = true;
            this.buttonsetAdamant.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsetDiamond
            // 
            this.buttonsetDiamond.Location = new System.Drawing.Point(644, 76);
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
            this.groupBoxGetStone.Location = new System.Drawing.Point(628, 194);
            this.groupBoxGetStone.Name = "groupBoxGetStone";
            this.groupBoxGetStone.Size = new System.Drawing.Size(138, 137);
            this.groupBoxGetStone.TabIndex = 3;
            this.groupBoxGetStone.TabStop = false;
            this.groupBoxGetStone.Text = "Забрать камень";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(72, 25);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Место:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonTakeStone
            // 
            this.buttonTakeStone.Location = new System.Drawing.Point(16, 73);
            this.buttonTakeStone.Name = "buttonTakeStone";
            this.buttonTakeStone.Size = new System.Drawing.Size(106, 41);
            this.buttonTakeStone.TabIndex = 2;
            this.buttonTakeStone.Text = "Забрать камень";
            this.buttonTakeStone.UseVisualStyleBackColor = true;
            this.buttonTakeStone.Click += new System.EventHandler(this.buttonTakeStone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 365);
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
    }
}