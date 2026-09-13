namespace QueuingForm
{
    partial class ServingForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblNowServing = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 31);
            label1.Name = "label1";
            label1.Size = new Size(225, 46);
            label1.TabIndex = 0;
            label1.Text = "*Now Serving";
            // 
            // lblNowServing
            // 
            lblNowServing.AutoSize = true;
            lblNowServing.Font = new Font("Nirmala UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNowServing.Location = new Point(81, 80);
            lblNowServing.Name = "lblNowServing";
            lblNowServing.Size = new Size(400, 106);
            lblNowServing.TabIndex = 1;
            lblNowServing.Text = "P - 10000";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ServingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(543, 273);
            Controls.Add(lblNowServing);
            Controls.Add(label1);
            Name = "ServingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServingForm";
            Load += ServingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNowServing;
        private System.Windows.Forms.Timer timer1;
    }
}