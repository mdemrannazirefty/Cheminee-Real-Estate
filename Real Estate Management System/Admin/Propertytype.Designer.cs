namespace Real_Estate_Management_System.Admin
{
    partial class Propertytype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Propertytype));
            buttonback = new Button();
            buttonx = new Button();
            buttonptdelete = new Button();
            dataGridViewptinfo = new DataGridView();
            buttonptadd = new Button();
            textBoxptdescription = new TextBox();
            label12 = new Label();
            textBoxpttypename = new TextBox();
            label11 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            buttonptshowall = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewptinfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.Orange;
            buttonback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonback.ForeColor = Color.FromArgb(64, 64, 64);
            buttonback.Location = new Point(12, 12);
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
            buttonx.Location = new Point(1240, 12);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 83;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // buttonptdelete
            // 
            buttonptdelete.BackColor = Color.Moccasin;
            buttonptdelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonptdelete.Location = new Point(41, 634);
            buttonptdelete.Name = "buttonptdelete";
            buttonptdelete.Size = new Size(145, 29);
            buttonptdelete.TabIndex = 112;
            buttonptdelete.Text = "Delete";
            buttonptdelete.UseVisualStyleBackColor = false;
            buttonptdelete.Click += buttonptdelete_Click;
            // 
            // dataGridViewptinfo
            // 
            dataGridViewptinfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewptinfo.Location = new Point(41, 317);
            dataGridViewptinfo.Name = "dataGridViewptinfo";
            dataGridViewptinfo.RowHeadersWidth = 51;
            dataGridViewptinfo.Size = new Size(501, 302);
            dataGridViewptinfo.TabIndex = 110;
            dataGridViewptinfo.CellContentClick += dataGridViewptinfo_CellContentClick;
            // 
            // buttonptadd
            // 
            buttonptadd.BackColor = Color.Moccasin;
            buttonptadd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonptadd.Location = new Point(162, 263);
            buttonptadd.Name = "buttonptadd";
            buttonptadd.Size = new Size(185, 29);
            buttonptadd.TabIndex = 105;
            buttonptadd.Text = "Add";
            buttonptadd.UseVisualStyleBackColor = false;
            buttonptadd.Click += buttonptadd_Click;
            // 
            // textBoxptdescription
            // 
            textBoxptdescription.Location = new Point(162, 177);
            textBoxptdescription.Multiline = true;
            textBoxptdescription.Name = "textBoxptdescription";
            textBoxptdescription.Size = new Size(380, 71);
            textBoxptdescription.TabIndex = 104;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(41, 184);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 103;
            label12.Text = "Description:";
            // 
            // textBoxpttypename
            // 
            textBoxpttypename.Location = new Point(162, 133);
            textBoxpttypename.Name = "textBoxpttypename";
            textBoxpttypename.Size = new Size(380, 27);
            textBoxpttypename.TabIndex = 102;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(41, 139);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 100;
            label11.Text = "Type Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(-2, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 10);
            panel2.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(481, 25);
            label1.Name = "label1";
            label1.Size = new Size(222, 38);
            label1.TabIndex = 86;
            label1.Text = "[Property Type]";
            // 
            // buttonptshowall
            // 
            buttonptshowall.BackColor = Color.Moccasin;
            buttonptshowall.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonptshowall.Location = new Point(353, 263);
            buttonptshowall.Name = "buttonptshowall";
            buttonptshowall.Size = new Size(189, 29);
            buttonptshowall.TabIndex = 114;
            buttonptshowall.Text = "Show All Property Type";
            buttonptshowall.UseVisualStyleBackColor = false;
            buttonptshowall.Click += buttonptshowall_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(776, 196);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(395, 373);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 154;
            pictureBox2.TabStop = false;
            // 
            // Propertytype
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(buttonptshowall);
            Controls.Add(buttonptdelete);
            Controls.Add(dataGridViewptinfo);
            Controls.Add(buttonptadd);
            Controls.Add(textBoxptdescription);
            Controls.Add(label12);
            Controls.Add(textBoxpttypename);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(buttonback);
            Controls.Add(buttonx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Propertytype";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Propertytype_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewptinfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonback;
        private Button buttonx;
        private Button buttonptdelete;
        private DataGridView dataGridViewptinfo;
        private Button buttonptadd;
        private TextBox textBoxptdescription;
        private Label label12;
        private TextBox textBoxpttypename;
        private Label label11;
        private Panel panel2;
        private Label label1;
        private Button buttonptshowall;
        private PictureBox pictureBox2;
    }
}