namespace Real_Estate_Management_System.Employee
{
    partial class Employeeemployeedetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employeeemployeedetails));
            buttonback = new Button();
            button4 = new Button();
            textBoxreusersearch = new TextBox();
            label13 = new Label();
            button2 = new Button();
            dataGridViewremployee = new DataGridView();
            comboBoxrestate = new ComboBox();
            dateTimePickerredob = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButtonregender = new RadioButton();
            button1 = new Button();
            textBoxreaddress = new TextBox();
            label12 = new Label();
            textBoxrephone = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBoxrelname = new TextBox();
            textBoxreusername = new TextBox();
            textBoxreemail = new TextBox();
            textBoxrepassword = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxrefname = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            buttonx = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewremployee).BeginInit();
            SuspendLayout();
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.Orange;
            buttonback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonback.ForeColor = Color.FromArgb(64, 64, 64);
            buttonback.Location = new Point(12, 17);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(30, 30);
            buttonback.TabIndex = 146;
            buttonback.Text = "⇐";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Moccasin;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1098, 126);
            button4.Name = "button4";
            button4.Size = new Size(143, 29);
            button4.TabIndex = 145;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBoxreusersearch
            // 
            textBoxreusersearch.Location = new Point(711, 126);
            textBoxreusersearch.Name = "textBoxreusersearch";
            textBoxreusersearch.Size = new Size(381, 27);
            textBoxreusersearch.TabIndex = 144;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(609, 130);
            label13.Name = "label13";
            label13.Size = new Size(102, 23);
            label13.TabIndex = 143;
            label13.Text = "User Name:";
            // 
            // button2
            // 
            button2.BackColor = Color.Moccasin;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(606, 603);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 141;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridViewremployee
            // 
            dataGridViewremployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewremployee.Location = new Point(606, 163);
            dataGridViewremployee.Name = "dataGridViewremployee";
            dataGridViewremployee.RowHeadersWidth = 51;
            dataGridViewremployee.Size = new Size(637, 419);
            dataGridViewremployee.TabIndex = 140;
            dataGridViewremployee.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxrestate
            // 
            comboBoxrestate.FormattingEnabled = true;
            comboBoxrestate.Location = new Point(193, 438);
            comboBoxrestate.Name = "comboBoxrestate";
            comboBoxrestate.Size = new Size(164, 28);
            comboBoxrestate.TabIndex = 139;
            // 
            // dateTimePickerredob
            // 
            dateTimePickerredob.Location = new Point(193, 371);
            dateTimePickerredob.Name = "dateTimePickerredob";
            dateTimePickerredob.Size = new Size(250, 27);
            dateTimePickerredob.TabIndex = 138;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(279, 340);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 137;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButtonregender
            // 
            radioButtonregender.AutoSize = true;
            radioButtonregender.ForeColor = Color.White;
            radioButtonregender.Location = new Point(193, 340);
            radioButtonregender.Name = "radioButtonregender";
            radioButtonregender.Size = new Size(63, 24);
            radioButtonregender.TabIndex = 136;
            radioButtonregender.TabStop = true;
            radioButtonregender.Text = "Male";
            radioButtonregender.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(193, 566);
            button1.Name = "button1";
            button1.Size = new Size(323, 29);
            button1.TabIndex = 135;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxreaddress
            // 
            textBoxreaddress.Location = new Point(193, 472);
            textBoxreaddress.Multiline = true;
            textBoxreaddress.Name = "textBoxreaddress";
            textBoxreaddress.Size = new Size(323, 71);
            textBoxreaddress.TabIndex = 134;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(72, 479);
            label12.Name = "label12";
            label12.Size = new Size(74, 23);
            label12.TabIndex = 133;
            label12.Text = "Address:";
            // 
            // textBoxrephone
            // 
            textBoxrephone.Location = new Point(193, 405);
            textBoxrephone.Name = "textBoxrephone";
            textBoxrephone.Size = new Size(323, 27);
            textBoxrephone.TabIndex = 132;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(72, 446);
            label10.Name = "label10";
            label10.Size = new Size(52, 23);
            label10.TabIndex = 131;
            label10.Text = "State:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(72, 411);
            label11.Name = "label11";
            label11.Size = new Size(63, 23);
            label11.TabIndex = 130;
            label11.Text = "Phone:";
            // 
            // textBoxrelname
            // 
            textBoxrelname.Location = new Point(193, 202);
            textBoxrelname.Name = "textBoxrelname";
            textBoxrelname.Size = new Size(323, 27);
            textBoxrelname.TabIndex = 129;
            // 
            // textBoxreusername
            // 
            textBoxreusername.Location = new Point(193, 236);
            textBoxreusername.Name = "textBoxreusername";
            textBoxreusername.Size = new Size(323, 27);
            textBoxreusername.TabIndex = 128;
            // 
            // textBoxreemail
            // 
            textBoxreemail.Location = new Point(193, 271);
            textBoxreemail.Name = "textBoxreemail";
            textBoxreemail.Size = new Size(323, 27);
            textBoxreemail.TabIndex = 127;
            // 
            // textBoxrepassword
            // 
            textBoxrepassword.Location = new Point(193, 306);
            textBoxrepassword.Name = "textBoxrepassword";
            textBoxrepassword.Size = new Size(323, 27);
            textBoxrepassword.TabIndex = 126;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(72, 379);
            label9.Name = "label9";
            label9.Size = new Size(114, 23);
            label9.TabIndex = 125;
            label9.Text = "Date Of Birth:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(72, 342);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 124;
            label8.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(72, 307);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 123;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(72, 271);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 122;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 236);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 121;
            label4.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 199);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 120;
            label3.Text = "Last Name:";
            // 
            // textBoxrefname
            // 
            textBoxrefname.Location = new Point(193, 167);
            textBoxrefname.Name = "textBoxrefname";
            textBoxrefname.Size = new Size(323, 27);
            textBoxrefname.TabIndex = 119;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(72, 167);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 118;
            label2.Text = "First Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(-2, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 10);
            panel2.TabIndex = 117;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(559, 24);
            label1.Name = "label1";
            label1.Size = new Size(165, 38);
            label1.TabIndex = 116;
            label1.Text = "[Employee]";
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1240, 17);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 115;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // Employeeemployeedetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(buttonback);
            Controls.Add(button4);
            Controls.Add(textBoxreusersearch);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(dataGridViewremployee);
            Controls.Add(comboBoxrestate);
            Controls.Add(dateTimePickerredob);
            Controls.Add(radioButton2);
            Controls.Add(radioButtonregender);
            Controls.Add(button1);
            Controls.Add(textBoxreaddress);
            Controls.Add(label12);
            Controls.Add(textBoxrephone);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(textBoxrelname);
            Controls.Add(textBoxreusername);
            Controls.Add(textBoxreemail);
            Controls.Add(textBoxrepassword);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxrefname);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(buttonx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Employeeemployeedetails";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewremployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonback;
        private Button button4;
        private TextBox textBoxreusersearch;
        private Label label13;
        private Button button2;
        private DataGridView dataGridViewremployee;
        private ComboBox comboBoxrestate;
        private DateTimePicker dateTimePickerredob;
        private RadioButton radioButton2;
        private RadioButton radioButtonregender;
        private Button button1;
        private TextBox textBoxreaddress;
        private Label label12;
        private TextBox textBoxrephone;
        private Label label10;
        private Label label11;
        private TextBox textBoxrelname;
        private TextBox textBoxreusername;
        private TextBox textBoxreemail;
        private TextBox textBoxrepassword;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxrefname;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button buttonx;
    }
}