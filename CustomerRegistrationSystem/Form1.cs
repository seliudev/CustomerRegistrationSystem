namespace CustomerRegistrationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgrwCustomers.DataSource = customerManager.GetAllCustomers();
            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerId = Convert.ToInt32(tbxCustomerId.Text);
            customer.FirstName = tbxCustomerFirstName.Text;
            customer.LastName = tbxCustomerLastName.Text;
            customer.Email = tbxCustomerEmail.Text;
            customer.City = tbxCustomerCity.Text;

            customerManager.Add(customer);

            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetAllCustomers();
            MessageBox.Show("A new customer is added to the system.");
        }
    }
}
