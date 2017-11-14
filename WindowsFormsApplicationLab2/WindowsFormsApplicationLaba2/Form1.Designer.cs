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
            this.buttonSetAdamant = new System.Windows.Forms.Button();
            this.buttonSetDiamond = new System.Windows.Forms.Button();
            this.buttonTake = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTakeStone = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeStone)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(13, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(704, 318);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // buttonSetAdamant
            // 
            this.buttonSetAdamant.Location = new System.Drawing.Point(723, 12);
            this.buttonSetAdamant.Name = "buttonSetAdamant";
            this.buttonSetAdamant.Size = new System.Drawing.Size(127, 24);
            this.buttonSetAdamant.TabIndex = 13;
            this.buttonSetAdamant.Text = "Добавить алмаз";
            this.buttonSetAdamant.UseVisualStyleBackColor = true;
            this.buttonSetAdamant.Click += new System.EventHandler(this.buttonSetAdamant_Click);
            // 
            // buttonSetDiamond
            // 
            this.buttonSetDiamond.Location = new System.Drawing.Point(723, 55);
            this.buttonSetDiamond.Name = "buttonSetDiamond";
            this.buttonSetDiamond.Size = new System.Drawing.Size(127, 24);
            this.buttonSetDiamond.TabIndex = 14;
            this.buttonSetDiamond.Text = "Добавить бриллиант";
            this.buttonSetDiamond.UseVisualStyleBackColor = true;
            this.buttonSetDiamond.Click += new System.EventHandler(this.buttonSetDiamond_Click);
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(723, 149);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(127, 24);
            this.buttonTake.TabIndex = 15;
            this.buttonTake.Text = "Забрать камень";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Место";
            // 
            // pictureBoxTakeStone
            // 
            this.pictureBoxTakeStone.Location = new System.Drawing.Point(727, 215);
            this.pictureBoxTakeStone.Name = "pictureBoxTakeStone";
            this.pictureBoxTakeStone.Size = new System.Drawing.Size(122, 114);
            this.pictureBoxTakeStone.TabIndex = 18;
            this.pictureBoxTakeStone.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(768, 189);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(49, 20);
            this.maskedTextBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 342);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.pictureBoxTakeStone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.buttonSetDiamond);
            this.Controls.Add(this.buttonSetAdamant);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeStone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonSetAdamant;
        private System.Windows.Forms.Button buttonSetDiamond;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTakeStone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
    }
}

