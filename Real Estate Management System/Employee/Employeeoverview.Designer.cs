namespace Real_Estate_Management_System.Employee
{
    partial class Employeeoverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employeeoverview));
            button2 = new Button();
            buttonx = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            buttonpdelete = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(90, 183);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 33;
            button2.Text = "Employee Details";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1241, 16);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 30;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F);
            button5.Location = new Point(90, 523);
            button5.Name = "button5";
            button5.Size = new Size(120, 40);
            button5.TabIndex = 29;
            button5.Text = "Reset Password";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(90, 387);
            button4.Name = "button4";
            button4.Size = new Size(120, 40);
            button4.TabIndex = 28;
            button4.Text = "Property";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(90, 455);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 27;
            button3.Text = "View Issue";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(90, 251);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 26;
            button1.Text = "Owner Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(238, 78);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 25;
            label1.Text = "[Employee] Signed as,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(90, 319);
            button7.Name = "button7";
            button7.Size = new Size(120, 40);
            button7.TabIndex = 34;
            button7.Text = "Client Details";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // buttonpdelete
            // 
            buttonpdelete.BackColor = Color.Moccasin;
            buttonpdelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonpdelete.Location = new Point(1148, 72);
            buttonpdelete.Name = "buttonpdelete";
            buttonpdelete.Size = new Size(90, 29);
            buttonpdelete.TabIndex = 130;
            buttonpdelete.Text = "Log Out";
            buttonpdelete.UseVisualStyleBackColor = false;
            buttonpdelete.Click += buttonpdelete_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(723, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(453, 453);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 131;
            pictureBox2.TabStop = false;
            // 
            // Employeeoverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(buttonpdelete);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(buttonx);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Employeeoverview";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button buttonx;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button7;
        private Button buttonpdelete;
        private PictureBox pictureBox2;
    }
}