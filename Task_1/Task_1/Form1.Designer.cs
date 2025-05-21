namespace Task_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewPicture = new System.Windows.Forms.Button();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 300);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnNewPicture
            // 
            this.btnNewPicture.Location = new System.Drawing.Point(830, 30);
            this.btnNewPicture.Name = "btnNewPicture";
            this.btnNewPicture.Size = new System.Drawing.Size(150, 40);
            this.btnNewPicture.TabIndex = 1;
            this.btnNewPicture.Text = "Нова картинка";
            this.btnNewPicture.UseVisualStyleBackColor = true;
            this.btnNewPicture.Click += new System.EventHandler(this.btnNewPicture_Click);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(830, 100);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(75, 21);
            this.radioButtonRed.TabIndex = 2;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Червоний";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.ForeColor = System.Drawing.Color.Green;
            this.radioButtonGreen.Location = new System.Drawing.Point(830, 130);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(76, 21);
            this.radioButtonGreen.TabIndex = 3;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Зелений";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonBlue.Location = new System.Drawing.Point(830, 160);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(63, 21);
            this.radioButtonBlue.TabIndex = 4;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Синій";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.ForeColor = System.Drawing.Color.Black;
            this.radioButtonBlack.Location = new System.Drawing.Point(830, 190);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(71, 21);
            this.radioButtonBlack.TabIndex = 5;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Чорний";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            this.radioButtonBlack.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1000, 340);
            this.Controls.Add(this.radioButtonBlack);
            this.Controls.Add(this.radioButtonBlue);
            this.Controls.Add(this.radioButtonGreen);
            this.Controls.Add(this.radioButtonRed);
            this.Controls.Add(this.btnNewPicture);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lab 7 - Малювання";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewPicture;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonBlack;
    }
}
