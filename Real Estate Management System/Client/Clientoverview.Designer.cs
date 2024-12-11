namespace Real_Estate_Management_System.Client
{
    partial class Clientoverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientoverview));
            pictureBox2 = new PictureBox();
            button6 = new Button();
            buttonx = new Button();
            button5 = new Button();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonpdelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(728, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(453, 453);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 8F);
            button6.Location = new Point(90, 285);
            button6.Name = "button6";
            button6.Size = new Size(120, 40);
            button6.TabIndex = 30;
            button6.Text = "Property Image";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1241, 14);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 29;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F);
            button5.Location = new Point(90, 431);
            button5.Name = "button5";
            button5.Size = new Size(120, 40);
            button5.TabIndex = 28;
            button5.Text = "Reset Password";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(90, 358);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 26;
            button3.Text = "Submit Issue";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(90, 212);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 25;
            button1.Text = "Client Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(238, 76);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 24;
            label1.Text = "[Client] Signed as,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // buttonpdelete
            // 
            buttonpdelete.BackColor = Color.Moccasin;
            buttonpdelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonpdelete.Location = new Point(1151, 70);
            buttonpdelete.Name = "buttonpdelete";
            buttonpdelete.Size = new Size(90, 29);
            buttonpdelete.TabIndex = 130;
            buttonpdelete.Text = "Log Out";
            buttonpdelete.UseVisualStyleBackColor = false;
            buttonpdelete.Click += buttonpdelete_Click;
            // 
            // Clientoverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(buttonpdelete);
            Controls.Add(pictureBox2);
            Controls.Add(button6);
            Controls.Add(buttonx);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Clientoverview";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button button6;
        private Button buttonx;
        private Button button5;
        private Button button3;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonpdelete;
    }
}