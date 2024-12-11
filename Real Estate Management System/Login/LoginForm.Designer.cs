namespace Real_Estate_Management_System.Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxlgnusername = new TextBox();
            textBoxlgnpassword = new TextBox();
            checkBoxlgnshowpassword = new CheckBox();
            buttonlogin = new Button();
            button2 = new Button();
            buttonx = new Button();
            label4 = new Label();
            label5 = new Label();
            buttonsignup = new Button();
            comboBoxloginas = new ComboBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(909, 112);
            label1.Name = "label1";
            label1.Size = new Size(98, 41);
            label1.TabIndex = 0;
            label1.Text = "LogIn";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Moccasin;
            label2.Location = new Point(812, 306);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 1;
            label2.Text = "User Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Moccasin;
            label3.Location = new Point(812, 352);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // textBoxlgnusername
            // 
            textBoxlgnusername.Location = new Point(920, 303);
            textBoxlgnusername.Name = "textBoxlgnusername";
            textBoxlgnusername.Size = new Size(153, 27);
            textBoxlgnusername.TabIndex = 3;
            // 
            // textBoxlgnpassword
            // 
            textBoxlgnpassword.Location = new Point(920, 349);
            textBoxlgnpassword.Name = "textBoxlgnpassword";
            textBoxlgnpassword.Size = new Size(153, 27);
            textBoxlgnpassword.TabIndex = 4;
            // 
            // checkBoxlgnshowpassword
            // 
            checkBoxlgnshowpassword.AutoSize = true;
            checkBoxlgnshowpassword.Location = new Point(1079, 353);
            checkBoxlgnshowpassword.Name = "checkBoxlgnshowpassword";
            checkBoxlgnshowpassword.Size = new Size(132, 24);
            checkBoxlgnshowpassword.TabIndex = 5;
            checkBoxlgnshowpassword.Text = "Show Password";
            checkBoxlgnshowpassword.UseVisualStyleBackColor = true;
            checkBoxlgnshowpassword.CheckedChanged += checkBoxlgnshowpassword_CheckedChanged;
            // 
            // buttonlogin
            // 
            buttonlogin.BackColor = Color.Moccasin;
            buttonlogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonlogin.ForeColor = Color.Black;
            buttonlogin.Location = new Point(823, 417);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(250, 29);
            buttonlogin.TabIndex = 6;
            buttonlogin.Text = "Login";
            buttonlogin.UseVisualStyleBackColor = false;
            buttonlogin.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HotTrack;
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(920, 382);
            button2.Name = "button2";
            button2.Size = new Size(132, 29);
            button2.TabIndex = 7;
            button2.Text = "ForgetPassword";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1244, 12);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 8;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(887, 153);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 10;
            label4.Text = "Let's get started";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(823, 459);
            label5.Name = "label5";
            label5.Size = new Size(166, 20);
            label5.TabIndex = 11;
            label5.Text = "Don't Have an account?";
            // 
            // buttonsignup
            // 
            buttonsignup.BackColor = Color.Transparent;
            buttonsignup.FlatStyle = FlatStyle.Popup;
            buttonsignup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsignup.ForeColor = SystemColors.HotTrack;
            buttonsignup.ImageAlign = ContentAlignment.TopLeft;
            buttonsignup.Location = new Point(992, 453);
            buttonsignup.Name = "buttonsignup";
            buttonsignup.Size = new Size(78, 29);
            buttonsignup.TabIndex = 12;
            buttonsignup.Text = "Signup";
            buttonsignup.TextAlign = ContentAlignment.TopLeft;
            buttonsignup.UseVisualStyleBackColor = false;
            buttonsignup.Click += button1_Click_1;
            // 
            // comboBoxloginas
            // 
            comboBoxloginas.FormattingEnabled = true;
            comboBoxloginas.Location = new Point(920, 259);
            comboBoxloginas.Name = "comboBoxloginas";
            comboBoxloginas.Size = new Size(81, 28);
            comboBoxloginas.TabIndex = 13;
            comboBoxloginas.SelectedIndexChanged += comboBoxloginas_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Moccasin;
            label6.Location = new Point(812, 263);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 14;
            label6.Text = "Login as:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(126, 112);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(453, 453);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 133;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(comboBoxloginas);
            Controls.Add(buttonsignup);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonx);
            Controls.Add(button2);
            Controls.Add(buttonlogin);
            Controls.Add(checkBoxlgnshowpassword);
            Controls.Add(textBoxlgnpassword);
            Controls.Add(textBoxlgnusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ScrollBar;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxlgnusername;
        private TextBox textBoxlgnpassword;
        private CheckBox checkBoxlgnshowpassword;
        private Button buttonlogin;
        private Button button2;
        private Button buttonx;
        private Label label4;
        private Label label5;
        private Button buttonsignup;
        private ComboBox comboBoxloginas;
        private Label label6;
        private PictureBox pictureBox2;
    }
}