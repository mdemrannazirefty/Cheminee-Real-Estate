namespace Real_Estate_Management_System.Owner
{
    partial class Ownercopyid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ownercopyid));
            richTextBoxpropertyid = new RichTextBox();
            buttondone = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBoxpropertyid
            // 
            richTextBoxpropertyid.Location = new Point(21, 52);
            richTextBoxpropertyid.Name = "richTextBoxpropertyid";
            richTextBoxpropertyid.Size = new Size(291, 120);
            richTextBoxpropertyid.TabIndex = 0;
            richTextBoxpropertyid.Text = "";
            richTextBoxpropertyid.TextChanged += richTextBoxpropertyid_TextChanged;
            // 
            // buttondone
            // 
            buttondone.BackColor = Color.Moccasin;
            buttondone.Location = new Point(119, 188);
            buttondone.Name = "buttondone";
            buttondone.Size = new Size(94, 29);
            buttondone.TabIndex = 1;
            buttondone.Text = "Done";
            buttondone.UseVisualStyleBackColor = false;
            buttondone.Click += buttondone_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 13);
            label1.Name = "label1";
            label1.Size = new Size(189, 23);
            label1.TabIndex = 2;
            label1.Text = "Copy Your Property ID";
            // 
            // Ownercopyid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(335, 243);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(buttondone);
            Controls.Add(richTextBoxpropertyid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Ownercopyid";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Ownercopyid_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxpropertyid;
        private Button buttondone;
        private Label label1;
    }
}