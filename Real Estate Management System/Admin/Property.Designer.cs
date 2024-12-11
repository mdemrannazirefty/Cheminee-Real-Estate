namespace Real_Estate_Management_System.Admin
{
    partial class Property
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Property));
            buttonback = new Button();
            buttonx = new Button();
            buttonpphotobrowse = new Button();
            textBoxpaddress = new TextBox();
            label12 = new Label();
            label11 = new Label();
            textBoxpowneruname = new TextBox();
            textBoxpsize = new TextBox();
            textBoxpprice = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            comboBoxpropertytype = new ComboBox();
            numericUpDownpbedroom = new NumericUpDown();
            numericUpDownpwashroom = new NumericUpDown();
            checkBoxpparking = new CheckBox();
            checkBoxppool = new CheckBox();
            buttonpviewall = new Button();
            dataGridViewviewp = new DataGridView();
            buttonpdelete = new Button();
            label7 = new Label();
            pictureBoxpphotoview = new PictureBox();
            buttonpadd = new Button();
            textBoxsearch = new TextBox();
            buttonsearch = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownpbedroom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownpwashroom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewviewp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxpphotoview).BeginInit();
            SuspendLayout();
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.Orange;
            buttonback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonback.ForeColor = Color.FromArgb(64, 64, 64);
            buttonback.Location = new Point(12, 23);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(30, 30);
            buttonback.TabIndex = 84;
            buttonback.Text = "⇐";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1240, 23);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 83;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // buttonpphotobrowse
            // 
            buttonpphotobrowse.BackColor = Color.White;
            buttonpphotobrowse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonpphotobrowse.Location = new Point(205, 514);
            buttonpphotobrowse.Name = "buttonpphotobrowse";
            buttonpphotobrowse.Size = new Size(87, 29);
            buttonpphotobrowse.TabIndex = 105;
            buttonpphotobrowse.Text = "Browse";
            buttonpphotobrowse.UseVisualStyleBackColor = false;
            buttonpphotobrowse.Click += buttonpphotobrowse_Click;
            // 
            // textBoxpaddress
            // 
            textBoxpaddress.Location = new Point(205, 306);
            textBoxpaddress.Multiline = true;
            textBoxpaddress.Name = "textBoxpaddress";
            textBoxpaddress.Size = new Size(323, 53);
            textBoxpaddress.TabIndex = 104;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(84, 313);
            label12.Name = "label12";
            label12.Size = new Size(74, 23);
            label12.TabIndex = 103;
            label12.Text = "Address:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(84, 482);
            label11.Name = "label11";
            label11.Size = new Size(47, 23);
            label11.TabIndex = 100;
            label11.Text = "Pool:";
            // 
            // textBoxpowneruname
            // 
            textBoxpowneruname.Location = new Point(205, 200);
            textBoxpowneruname.Name = "textBoxpowneruname";
            textBoxpowneruname.Size = new Size(323, 27);
            textBoxpowneruname.TabIndex = 99;
            // 
            // textBoxpsize
            // 
            textBoxpsize.Location = new Point(205, 234);
            textBoxpsize.Name = "textBoxpsize";
            textBoxpsize.Size = new Size(323, 27);
            textBoxpsize.TabIndex = 98;
            // 
            // textBoxpprice
            // 
            textBoxpprice.Location = new Point(205, 269);
            textBoxpprice.Name = "textBoxpprice";
            textBoxpprice.Size = new Size(323, 27);
            textBoxpprice.TabIndex = 97;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(84, 450);
            label9.Name = "label9";
            label9.Size = new Size(70, 23);
            label9.TabIndex = 95;
            label9.Text = "Parking:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(84, 408);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 94;
            label8.Text = "Washroom:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(84, 374);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 93;
            label6.Text = "Bedroom:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(84, 269);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 92;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(84, 234);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 91;
            label4.Text = "Size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 201);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 90;
            label3.Text = "Owner Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 165);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 88;
            label2.Text = "Property Type:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(-6, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 10);
            panel2.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(561, 30);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 86;
            label1.Text = "[Property]";
            // 
            // comboBoxpropertytype
            // 
            comboBoxpropertytype.FormattingEnabled = true;
            comboBoxpropertytype.Location = new Point(205, 160);
            comboBoxpropertytype.Name = "comboBoxpropertytype";
            comboBoxpropertytype.Size = new Size(151, 28);
            comboBoxpropertytype.TabIndex = 116;
            // 
            // numericUpDownpbedroom
            // 
            numericUpDownpbedroom.Location = new Point(206, 369);
            numericUpDownpbedroom.Name = "numericUpDownpbedroom";
            numericUpDownpbedroom.Size = new Size(150, 27);
            numericUpDownpbedroom.TabIndex = 118;
            // 
            // numericUpDownpwashroom
            // 
            numericUpDownpwashroom.Location = new Point(206, 404);
            numericUpDownpwashroom.Name = "numericUpDownpwashroom";
            numericUpDownpwashroom.Size = new Size(150, 27);
            numericUpDownpwashroom.TabIndex = 119;
            // 
            // checkBoxpparking
            // 
            checkBoxpparking.AutoSize = true;
            checkBoxpparking.Location = new Point(206, 451);
            checkBoxpparking.Margin = new Padding(0);
            checkBoxpparking.Name = "checkBoxpparking";
            checkBoxpparking.Size = new Size(18, 17);
            checkBoxpparking.TabIndex = 120;
            checkBoxpparking.UseVisualStyleBackColor = true;
            // 
            // checkBoxppool
            // 
            checkBoxppool.AutoSize = true;
            checkBoxppool.Location = new Point(206, 487);
            checkBoxppool.Margin = new Padding(0);
            checkBoxppool.Name = "checkBoxppool";
            checkBoxppool.Size = new Size(18, 17);
            checkBoxppool.TabIndex = 121;
            checkBoxppool.UseVisualStyleBackColor = true;
            // 
            // buttonpviewall
            // 
            buttonpviewall.BackColor = Color.Moccasin;
            buttonpviewall.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonpviewall.Location = new Point(615, 162);
            buttonpviewall.Name = "buttonpviewall";
            buttonpviewall.Size = new Size(635, 29);
            buttonpviewall.TabIndex = 127;
            buttonpviewall.Text = "View All Property";
            buttonpviewall.UseVisualStyleBackColor = false;
            buttonpviewall.Click += buttonpviewall_Click;
            // 
            // dataGridViewviewp
            // 
            dataGridViewviewp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewviewp.Location = new Point(615, 198);
            dataGridViewviewp.Name = "dataGridViewviewp";
            dataGridViewviewp.RowHeadersWidth = 51;
            dataGridViewviewp.Size = new Size(637, 345);
            dataGridViewviewp.TabIndex = 122;
            dataGridViewviewp.CellContentClick += dataGridViewviewp_CellContentClick;
            // 
            // buttonpdelete
            // 
            buttonpdelete.BackColor = Color.Moccasin;
            buttonpdelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonpdelete.Location = new Point(615, 555);
            buttonpdelete.Name = "buttonpdelete";
            buttonpdelete.Size = new Size(145, 29);
            buttonpdelete.TabIndex = 128;
            buttonpdelete.Text = "Delete";
            buttonpdelete.UseVisualStyleBackColor = false;
            buttonpdelete.Click += buttonpdelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(85, 514);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 129;
            label7.Text = "Add Photo:";
            // 
            // pictureBoxpphotoview
            // 
            pictureBoxpphotoview.Location = new Point(298, 451);
            pictureBoxpphotoview.Name = "pictureBoxpphotoview";
            pictureBoxpphotoview.Size = new Size(140, 133);
            pictureBoxpphotoview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxpphotoview.TabIndex = 130;
            pictureBoxpphotoview.TabStop = false;
            pictureBoxpphotoview.Click += pictureBoxpphotoview_Click;
            // 
            // buttonpadd
            // 
            buttonpadd.BackColor = Color.Moccasin;
            buttonpadd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonpadd.Location = new Point(205, 603);
            buttonpadd.Name = "buttonpadd";
            buttonpadd.Size = new Size(323, 29);
            buttonpadd.TabIndex = 131;
            buttonpadd.Text = "Add";
            buttonpadd.UseVisualStyleBackColor = false;
            buttonpadd.Click += buttonpadd_Click;
            // 
            // textBoxsearch
            // 
            textBoxsearch.Location = new Point(677, 127);
            textBoxsearch.Name = "textBoxsearch";
            textBoxsearch.Size = new Size(422, 27);
            textBoxsearch.TabIndex = 132;
            // 
            // buttonsearch
            // 
            buttonsearch.BackColor = Color.Moccasin;
            buttonsearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonsearch.Location = new Point(1105, 127);
            buttonsearch.Name = "buttonsearch";
            buttonsearch.Size = new Size(143, 29);
            buttonsearch.TabIndex = 133;
            buttonsearch.Text = "Search";
            buttonsearch.UseVisualStyleBackColor = false;
            buttonsearch.Click += buttonsearch_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(615, 128);
            label10.Name = "label10";
            label10.Size = new Size(56, 23);
            label10.TabIndex = 134;
            label10.Text = "Value:";
            // 
            // Property
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(buttonsearch);
            Controls.Add(textBoxsearch);
            Controls.Add(buttonpadd);
            Controls.Add(pictureBoxpphotoview);
            Controls.Add(label7);
            Controls.Add(buttonpdelete);
            Controls.Add(buttonpviewall);
            Controls.Add(dataGridViewviewp);
            Controls.Add(checkBoxppool);
            Controls.Add(checkBoxpparking);
            Controls.Add(numericUpDownpwashroom);
            Controls.Add(numericUpDownpbedroom);
            Controls.Add(comboBoxpropertytype);
            Controls.Add(buttonpphotobrowse);
            Controls.Add(textBoxpaddress);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBoxpowneruname);
            Controls.Add(textBoxpsize);
            Controls.Add(textBoxpprice);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(buttonback);
            Controls.Add(buttonx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Property";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Property_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownpbedroom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownpwashroom).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewviewp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxpphotoview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonback;
        private Button buttonx;
        private Button buttonpphotobrowse;
        private TextBox textBoxpaddress;
        private Label label12;
        private Label label11;
        private TextBox textBoxpowneruname;
        private TextBox textBoxpsize;
        private TextBox textBoxpprice;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private ComboBox comboBoxpropertytype;
        private NumericUpDown numericUpDownpbedroom;
        private NumericUpDown numericUpDownpwashroom;
        private CheckBox checkBoxpparking;
        private CheckBox checkBoxppool;
        private Button buttonpviewall;
        private DataGridView dataGridViewviewp;
        private Button buttonpdelete;
        private Label label7;
        private PictureBox pictureBoxpphotoview;
        private Button buttonpadd;
        private TextBox textBoxsearch;
        private Button buttonsearch;
        private Label label10;
    }
}