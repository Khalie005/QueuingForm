namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
