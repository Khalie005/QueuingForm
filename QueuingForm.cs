namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
       
            CashierWindowQueueForm cashierWindowQueueForm = new CashierWindowQueueForm();
            cashierWindowQueueForm.Show();

            ServingForm servingForm = new ServingForm();
            servingForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
