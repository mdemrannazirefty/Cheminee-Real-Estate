namespace Real_Estate_Management_System.Admin
{
    partial class Adminviewissue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminviewissue));
            textBoxasearch = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            buttonback = new Button();
            buttonx = new Button();
            dataGridViewaissudata = new DataGridView();
            buttonaissueresolveall = new Button();
            buttonaissuessearch = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewaissudata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxasearch
            // 
            textBoxasearch.Location = new Point(187, 182);
            textBoxasearch.Name = "textBoxasearch";
            textBoxasearch.Size = new Size(271, 27);
            textBoxasearch.TabIndex = 145;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(107, 183);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 143;
            label2.Text = "Issue ID:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(-3, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 10);
            panel2.TabIndex = 142;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(575, 30);
            label1.Name = "label1";
            label1.Size = new Size(130, 38);
            label1.TabIndex = 141;
            label1.Text = "[ Issues ]";
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.Orange;
            buttonback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonback.ForeColor = Color.FromArgb(64, 64, 64);
            buttonback.Location = new Point(11, 15);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(30, 30);
            buttonback.TabIndex = 140;
            buttonback.Text = "⇐";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1239, 15);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 139;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // dataGridViewaissudata
            // 
            dataGridViewaissudata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewaissudata.Location = new Point(107, 229);
            dataGridViewaissudata.Name = "dataGridViewaissudata";
            dataGridViewaissudata.RowHeadersWidth = 51;
            dataGridViewaissudata.Size = new Size(598, 343);
            dataGridViewaissudata.TabIndex = 149;
            dataGridViewaissudata.CellContentClick += dataGridViewaissudata_CellContentClick;
            // 
            // buttonaissueresolveall
            // 
            buttonaissueresolveall.BackColor = Color.Moccasin;
            buttonaissueresolveall.Location = new Point(107, 589);
            buttonaissueresolveall.Name = "buttonaissueresolveall";
            buttonaissueresolveall.Size = new Size(155, 29);
            buttonaissueresolveall.TabIndex = 150;
            buttonaissueresolveall.Text = "Resolve All";
            buttonaissueresolveall.UseVisualStyleBackColor = false;
            buttonaissueresolveall.Click += buttonaissueresolveall_Click;
            // 
            // buttonaissuessearch
            // 
            buttonaissuessearch.BackColor = Color.Moccasin;
            buttonaissuessearch.Location = new Point(470, 181);
            buttonaissuessearch.Name = "buttonaissuessearch";
            buttonaissuessearch.Size = new Size(122, 29);
            buttonaissuessearch.TabIndex = 152;
            buttonaissuessearch.Text = "Search";
            buttonaissuessearch.UseVisualStyleBackColor = false;
            buttonaissuessearch.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(840, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(395, 373);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 153;
            pictureBox2.TabStop = false;
            // 
            // Adminviewissue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(buttonaissuessearch);
            Controls.Add(buttonaissueresolveall);
            Controls.Add(dataGridViewaissudata);
            Controls.Add(textBoxasearch);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(buttonback);
            Controls.Add(buttonx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Adminviewissue";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewaissudata).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxasearch;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button buttonback;
        private Button buttonx;
        private DataGridView dataGridViewaissudata;
        private Button buttonaissueresolveall;
        private Button buttonaissuessearch;
        private PictureBox pictureBox2;
    }
}