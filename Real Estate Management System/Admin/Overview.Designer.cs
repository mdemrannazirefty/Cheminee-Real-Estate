namespace Real_Estate_Management_System.Forms
{
    partial class Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            buttonx = new Button();
            button7 = new Button();
            button3 = new Button();
            buttonadministrator = new Button();
            buttonpdelete = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(242, 79);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 2;
            label1.Text = "[Admin] Signed as,";
            // 
            // button1
            // 
            button1.Location = new Point(89, 287);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 3;
            button1.Text = "Owner";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(89, 338);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 4;
            button2.Text = "Client";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(89, 389);
            button4.Name = "button4";
            button4.Size = new Size(120, 40);
            button4.TabIndex = 6;
            button4.Text = "Property";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F);
            button5.Location = new Point(89, 440);
            button5.Name = "button5";
            button5.Size = new Size(120, 40);
            button5.TabIndex = 7;
            button5.Text = "Property-Type";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1240, 14);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 8;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // button7
            // 
            button7.Location = new Point(89, 236);
            button7.Name = "button7";
            button7.Size = new Size(120, 40);
            button7.TabIndex = 12;
            button7.Text = "Employee";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(89, 491);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 5;
            button3.Text = "View Issue";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonadministrator
            // 
            buttonadministrator.Location = new Point(89, 185);
            buttonadministrator.Name = "buttonadministrator";
            buttonadministrator.Size = new Size(120, 40);
            buttonadministrator.TabIndex = 13;
            buttonadministrator.Text = "Administrator";
            buttonadministrator.UseVisualStyleBackColor = true;
            buttonadministrator.Click += buttonadministrator_Click;
            // 
            // buttonpdelete
            // 
            buttonpdelete.BackColor = Color.Moccasin;
            buttonpdelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonpdelete.Location = new Point(1147, 70);
            buttonpdelete.Name = "buttonpdelete";
            buttonpdelete.Size = new Size(90, 29);
            buttonpdelete.TabIndex = 129;
            buttonpdelete.Text = "Log Out";
            buttonpdelete.UseVisualStyleBackColor = false;
            buttonpdelete.Click += buttonpdelete_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(720, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(453, 453);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 130;
            pictureBox2.TabStop = false;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(buttonpdelete);
            Controls.Add(buttonadministrator);
            Controls.Add(button7);
            Controls.Add(buttonx);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Overview";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Overview_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button buttonx;
        private Button button7;
        private Button button3;
        private Button buttonadministrator;
        private Button buttonpdelete;
        private PictureBox pictureBox2;
    }
}