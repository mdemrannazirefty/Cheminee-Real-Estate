namespace Real_Estate_Management_System.Owner
{
    partial class Ownerviewproposal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ownerviewproposal));
            buttonback = new Button();
            buttonreject = new Button();
            panel2 = new Panel();
            label1 = new Label();
            buttonx = new Button();
            dataGridViewviewproposal = new DataGridView();
            buttonaccept = new Button();
            buttonsubmit = new Button();
            textBoxpropertyid = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewviewproposal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.Orange;
            buttonback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonback.ForeColor = Color.FromArgb(64, 64, 64);
            buttonback.Location = new Point(11, 14);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(30, 30);
            buttonback.TabIndex = 187;
            buttonback.Text = "⇐";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // buttonreject
            // 
            buttonreject.BackColor = Color.Moccasin;
            buttonreject.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonreject.Location = new Point(638, 584);
            buttonreject.Name = "buttonreject";
            buttonreject.Size = new Size(111, 29);
            buttonreject.TabIndex = 186;
            buttonreject.Text = "Reject";
            buttonreject.UseVisualStyleBackColor = false;
            buttonreject.Click += buttonreject_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(-5, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 10);
            panel2.TabIndex = 175;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(527, 16);
            label1.Name = "label1";
            label1.Size = new Size(223, 38);
            label1.TabIndex = 174;
            label1.Text = "[View Proposal]";
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1239, 14);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 173;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // dataGridViewviewproposal
            // 
            dataGridViewviewproposal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewviewproposal.Location = new Point(23, 171);
            dataGridViewviewproposal.Name = "dataGridViewviewproposal";
            dataGridViewviewproposal.RowHeadersWidth = 51;
            dataGridViewviewproposal.Size = new Size(726, 397);
            dataGridViewviewproposal.TabIndex = 191;
            dataGridViewviewproposal.CellContentClick += dataGridViewviewproposal_CellContentClick;
            // 
            // buttonaccept
            // 
            buttonaccept.BackColor = Color.Moccasin;
            buttonaccept.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonaccept.Location = new Point(23, 584);
            buttonaccept.Name = "buttonaccept";
            buttonaccept.Size = new Size(111, 29);
            buttonaccept.TabIndex = 192;
            buttonaccept.Text = "Accept";
            buttonaccept.UseVisualStyleBackColor = false;
            buttonaccept.Click += buttonaccept_Click;
            // 
            // buttonsubmit
            // 
            buttonsubmit.BackColor = Color.Moccasin;
            buttonsubmit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonsubmit.Location = new Point(638, 118);
            buttonsubmit.Name = "buttonsubmit";
            buttonsubmit.Size = new Size(111, 27);
            buttonsubmit.TabIndex = 193;
            buttonsubmit.Text = "Next";
            buttonsubmit.UseVisualStyleBackColor = false;
            buttonsubmit.Click += buttonsubmit_Click;
            // 
            // textBoxpropertyid
            // 
            textBoxpropertyid.Location = new Point(182, 119);
            textBoxpropertyid.Name = "textBoxpropertyid";
            textBoxpropertyid.Size = new Size(450, 27);
            textBoxpropertyid.TabIndex = 194;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 122);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 195;
            label2.Text = "Enter Your PropertyID:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(837, 171);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(395, 399);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 196;
            pictureBox2.TabStop = false;
            // 
            // Ownerviewproposal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(textBoxpropertyid);
            Controls.Add(buttonsubmit);
            Controls.Add(buttonaccept);
            Controls.Add(dataGridViewviewproposal);
            Controls.Add(buttonback);
            Controls.Add(buttonreject);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(buttonx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Ownerviewproposal";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewviewproposal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonback;
        private Button buttonreject;
        private Panel panel2;
        private Label label1;
        private Button buttonx;
        private DataGridView dataGridViewviewproposal;
        private Button buttonaccept;
        private Button buttonsubmit;
        private TextBox textBoxpropertyid;
        private Label label2;
        private PictureBox pictureBox2;
    }
}