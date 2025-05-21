namespace Task_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog1.ShowColor = true;

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // pictureBox1
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // timer1
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(620, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 40);
            this.btnStart.Text = "Почати";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // btnFont
            this.btnFont.Location = new System.Drawing.Point(620, 70);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(120, 40);
            this.btnFont.Text = "Змінити шрифт";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(760, 330);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Графік y = sin(x)/x";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
