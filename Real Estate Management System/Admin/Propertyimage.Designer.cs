namespace Real_Estate_Management_System.Admin
{
    partial class Propertyimage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Propertyimage));
            panel2 = new Panel();
            label1 = new Label();
            buttonback = new Button();
            buttonx = new Button();
            dataGridViewpropertytypeview = new DataGridView();
            dataGridViewpropertyalldetails = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBoxpropertyimageview = new PictureBox();
            button1 = new Button();
            buttonselect = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpropertytypeview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpropertyalldetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxpropertyimageview).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(-4, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 10);
            panel2.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(479, 29);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 90;
            label1.Text = "[Property Image]";
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.Orange;
            buttonback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonback.ForeColor = Color.FromArgb(64, 64, 64);
            buttonback.Location = new Point(10, 16);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(30, 30);
            buttonback.TabIndex = 89;
            buttonback.Text = "⇐";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1238, 16);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 88;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // dataGridViewpropertytypeview
            // 
            dataGridViewpropertytypeview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewpropertytypeview.Location = new Point(35, 156);
            dataGridViewpropertytypeview.Name = "dataGridViewpropertytypeview";
            dataGridViewpropertytypeview.RowHeadersWidth = 51;
            dataGridViewpropertytypeview.Size = new Size(315, 188);
            dataGridViewpropertytypeview.TabIndex = 92;
            dataGridViewpropertytypeview.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewpropertyalldetails
            // 
            dataGridViewpropertyalldetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewpropertyalldetails.Location = new Point(388, 156);
            dataGridViewpropertyalldetails.Name = "dataGridViewpropertyalldetails";
            dataGridViewpropertyalldetails.RowHeadersWidth = 51;
            dataGridViewpropertyalldetails.Size = new Size(849, 440);
            dataGridViewpropertyalldetails.TabIndex = 94;
            dataGridViewpropertyalldetails.CellContentClick += dataGridViewpropertyalldetails_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 130);
            label2.Name = "label2";
            label2.Size = new Size(176, 23);
            label2.TabIndex = 95;
            label2.Text = "Select Property Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 359);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 96;
            label3.Text = "Property View";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(713, 123);
            label4.Name = "label4";
            label4.Size = new Size(198, 23);
            label4.TabIndex = 97;
            label4.Text = "Select Property Details:";
            // 
            // pictureBoxpropertyimageview
            // 
            pictureBoxpropertyimageview.Location = new Point(35, 385);
            pictureBoxpropertyimageview.Name = "pictureBoxpropertyimageview";
            pictureBoxpropertyimageview.Size = new Size(315, 211);
            pictureBoxpropertyimageview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxpropertyimageview.TabIndex = 98;
            pictureBoxpropertyimageview.TabStop = false;
            pictureBoxpropertyimageview.Click += pictureBoxpropertyimageview_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(388, 615);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 99;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonselect
            // 
            buttonselect.BackColor = Color.Moccasin;
            buttonselect.ForeColor = Color.Black;
            buttonselect.Location = new Point(256, 124);
            buttonselect.Name = "buttonselect";
            buttonselect.Size = new Size(94, 29);
            buttonselect.TabIndex = 101;
            buttonselect.Text = "Select";
            buttonselect.UseVisualStyleBackColor = false;
            buttonselect.Click += buttonselect_Click;
            // 
            // Propertyimage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(buttonselect);
            Controls.Add(button1);
            Controls.Add(pictureBoxpropertyimageview);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewpropertyalldetails);
            Controls.Add(dataGridViewpropertytypeview);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(buttonback);
            Controls.Add(buttonx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Propertyimage";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Propertyimage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewpropertytypeview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpropertyalldetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxpropertyimageview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button buttonback;
        private Button buttonx;
        private DataGridView dataGridViewpropertytypeview;
        private DataGridView dataGridViewpropertyalldetails;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBoxpropertyimageview;
        private Button button1;
        private Button buttonselect;
    }
}