namespace Real_Estate_Management_System.Employee
{
    partial class Employeeviewissue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employeeviewissue));
            buttonesearch = new Button();
            buttoneresolveall = new Button();
            dataGridVieweissues = new DataGridView();
            textBoxesearch = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            buttonback = new Button();
            buttonx = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridVieweissues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonesearch
            // 
            buttonesearch.BackColor = Color.Moccasin;
            buttonesearch.Location = new Point(446, 177);
            buttonesearch.Name = "buttonesearch";
            buttonesearch.Size = new Size(122, 29);
            buttonesearch.TabIndex = 164;
            buttonesearch.Text = "Search";
            buttonesearch.UseVisualStyleBackColor = false;
            buttonesearch.Click += buttonesearch_Click;
            // 
            // buttoneresolveall
            // 
            buttoneresolveall.BackColor = Color.Moccasin;
            buttoneresolveall.Location = new Point(108, 590);
            buttoneresolveall.Name = "buttoneresolveall";
            buttoneresolveall.Size = new Size(155, 29);
            buttoneresolveall.TabIndex = 163;
            buttoneresolveall.Text = "Resolve All";
            buttoneresolveall.UseVisualStyleBackColor = false;
            buttoneresolveall.Click += buttoneresolveall_Click;
            // 
            // dataGridVieweissues
            // 
            dataGridVieweissues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVieweissues.Location = new Point(108, 228);
            dataGridVieweissues.Name = "dataGridVieweissues";
            dataGridVieweissues.RowHeadersWidth = 51;
            dataGridVieweissues.Size = new Size(598, 343);
            dataGridVieweissues.TabIndex = 161;
            dataGridVieweissues.CellContentClick += dataGridVieweissues_CellContentClick;
            // 
            // textBoxesearch
            // 
            textBoxesearch.Location = new Point(188, 178);
            textBoxesearch.Name = "textBoxesearch";
            textBoxesearch.Size = new Size(246, 27);
            textBoxesearch.TabIndex = 158;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(108, 182);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 157;
            label2.Text = "Issue ID:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(-2, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 10);
            panel2.TabIndex = 156;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(576, 29);
            label1.Name = "label1";
            label1.Size = new Size(130, 38);
            label1.TabIndex = 155;
            label1.Text = "[ Issues ]";
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.Orange;
            buttonback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonback.ForeColor = Color.FromArgb(64, 64, 64);
            buttonback.Location = new Point(12, 14);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(30, 30);
            buttonback.TabIndex = 154;
            buttonback.Text = "⇐";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1240, 14);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 153;
            buttonx.Text = "X";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonx_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(757, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(453, 453);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 165;
            pictureBox2.TabStop = false;
            // 
            // Employeeviewissue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(buttonesearch);
            Controls.Add(buttoneresolveall);
            Controls.Add(dataGridVieweissues);
            Controls.Add(textBoxesearch);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(buttonback);
            Controls.Add(buttonx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Employeeviewissue";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridVieweissues).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonesearch;
        private Button buttoneresolveall;
        private DataGridView dataGridVieweissues;
        private TextBox textBoxesearch;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button buttonback;
        private Button buttonx;
        private PictureBox pictureBox2;
    }
}