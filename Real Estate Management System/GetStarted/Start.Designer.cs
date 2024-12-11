namespace Real_Estate_Management_System.GetStarted
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            buttonx = new Button();
            buttoncontribution = new Button();
            buttongetstarted = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonx
            // 
            buttonx.BackColor = Color.Orange;
            buttonx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonx.ForeColor = Color.FromArgb(64, 64, 64);
            buttonx.Location = new Point(1240, 12);
            buttonx.Name = "buttonx";
            buttonx.Size = new Size(30, 30);
            buttonx.TabIndex = 0;
            buttonx.Text = "x";
            buttonx.UseVisualStyleBackColor = false;
            buttonx.Click += buttonexit_Click;
            // 
            // buttoncontribution
            // 
            buttoncontribution.BackColor = Color.Turquoise;
            buttoncontribution.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoncontribution.Location = new Point(594, 461);
            buttoncontribution.Name = "buttoncontribution";
            buttoncontribution.Size = new Size(106, 29);
            buttoncontribution.TabIndex = 1;
            buttoncontribution.Text = "Contribution";
            buttoncontribution.UseVisualStyleBackColor = false;
            buttoncontribution.Click += button2_Click;
            // 
            // buttongetstarted
            // 
            buttongetstarted.BackColor = Color.Moccasin;
            buttongetstarted.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttongetstarted.Location = new Point(594, 413);
            buttongetstarted.Name = "buttongetstarted";
            buttongetstarted.Size = new Size(106, 36);
            buttongetstarted.TabIndex = 2;
            buttongetstarted.Text = "Get Started";
            buttongetstarted.UseVisualStyleBackColor = false;
            buttongetstarted.Click += buttongetstarted_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(191, 234);
            label1.Name = "label1";
            label1.Size = new Size(957, 60);
            label1.TabIndex = 3;
            label1.Text = "Welcomr To Real Estate Management System";
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 703);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(buttongetstarted);
            Controls.Add(buttoncontribution);
            Controls.Add(buttonx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonx;
        private Button buttoncontribution;
        private Button buttongetstarted;
        private Label label1;
    }
}