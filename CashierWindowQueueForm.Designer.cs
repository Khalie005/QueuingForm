namespace QueuingForm
{
    partial class CashierWindowQueueForm
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
            btnRefresh = new Button();
            btnNext = new Button();
            listCashierQueue = new ListView();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(12, 13);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 31);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ActiveCaptionText;
            btnNext.Location = new Point(12, 47);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(105, 31);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // listCashierQueue
            // 
            listCashierQueue.BackColor = Color.Ivory;
            listCashierQueue.Location = new Point(130, 12);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(303, 426);
            listCashierQueue.TabIndex = 2;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(449, 450);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier Window Queue Form";
            Load += CashierWindowQueueForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnNext;
        private ListView listCashierQueue;
    }
}