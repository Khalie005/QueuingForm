using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class ServingForm : Form
    {
        public ServingForm()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                lblNowServing.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                lblNowServing.Text = "P - -----";
            }
        }

        private void ServingForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
