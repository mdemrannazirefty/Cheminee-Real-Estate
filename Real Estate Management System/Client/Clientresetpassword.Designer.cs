namespace Real_Estate_Management_System.Client
{
    partial class Clientresetpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientresetpassword));
            buttonrpupdate = new Button();
            label2 = new Label();
            textBoxrpusername = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            buttonback = new Button();
            buttonx = new Button();
            label3 = new Label();
            textBoxrpcurrentpassword = new TextBox();
            label4 = new Label();
            textBoxrpnewpassword = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonrpupdate
            // 
            buttonrpupdate.BackColor = Color.Moccasin;
            buttonrpupdate.Location = new Point(192, 313);
            buttonrpupdate.Name = "buttonrpupdate";
            buttonrpupdate.Size = new Size(94, 29);
            buttonrpupdate.TabIndex = 127;
            buttonrpupdate.Text = "Update";
            buttonrpupdate.UseVisualStyleBackColor = false;
            buttonrpupdate.Click += buttonrpupdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 160);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 125;
            label2.Text = "Enter Username:";
            // 
            // textBoxrpusername
            // 
            textBoxrpusername.Location = new Point(192, 159);
            textBoxrpusername.Name = "textBoxrpusername";
            textBoxrpusername.Size = new Size(251, 27);
            textBoxrpusername.TabIndex = 123;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(-2, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 10);
            panel2.TabIndex = 122;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(481, 26);
            label1.Name = "label1";
            label1.Size = new Size(237, 38);
            label1.TabIndex = 121;
            label1.Text = "[Reset Password]";
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.Orange;
            buttonback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonback.ForeColor = Color.FromArgb(64, 64, 64);
            buttonback.Location = new Point(12, 13);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(30, 30);
            buttonback.TabIndex = 120;
            buttonback.Text = "⇐";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1240, 13);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 119;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 212);
            label3.Name = "label3";
            label3.Size = new Size(147, 23);
            label3.TabIndex = 130;
            label3.Text = "Current Password:";
            // 
            // textBoxrpcurrentpassword
            // 
            textBoxrpcurrentpassword.Location = new Point(192, 211);
            textBoxrpcurrentpassword.Name = "textBoxrpcurrentpassword";
            textBoxrpcurrentpassword.Size = new Size(251, 27);
            textBoxrpcurrentpassword.TabIndex = 129;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 261);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 132;
            label4.Text = "New Password:";
            // 
            // textBoxrpnewpassword
            // 
            textBoxrpnewpassword.Location = new Point(192, 260);
            textBoxrpnewpassword.Name = "textBoxrpnewpassword";
            textBoxrpnewpassword.Size = new Size(251, 27);
            textBoxrpnewpassword.TabIndex = 131;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(714, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(453, 453);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 133;
            pictureBox2.TabStop = false;
            // 
            // Clientresetpassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(textBoxrpnewpassword);
            Controls.Add(label3);
            Controls.Add(textBoxrpcurrentpassword);
            Controls.Add(buttonrpupdate);
            Controls.Add(label2);
            Controls.Add(textBoxrpusername);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(buttonback);
            Controls.Add(buttonx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Clientresetpassword";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Clientresetpassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonrpupdate;
        private Label label2;
        //private Button button1;
        private TextBox textBoxrpusername;
        private Panel panel2;
        private Label label1;
        private Button buttonback;
        private Button buttonx;
        private Label label3;
        private TextBox textBoxrpcurrentpassword;
        private Label label4;
        private TextBox textBoxrpnewpassword;
        private PictureBox pictureBox2;
    }
}