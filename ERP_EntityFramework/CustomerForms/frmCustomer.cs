using ERP_EntityFramework_Business.Services;

namespace ERP_EntityFramework_UI
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerService _customerService;

        public frmCustomer(ICustomerService customerService)
        {
            InitializeComponent();

            _customerService = customerService;

            GetCustomers();
        }

        void GetCustomers()
        {
            var customers = _customerService.ListAll();
            grdCustomer.DataSource = customers;
        }
    }
}