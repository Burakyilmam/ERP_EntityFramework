using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_UI.Functions;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ERP_EntityFramework_UI
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerService _customerService;

        public frmCustomer(ICustomerService customerService)
        {
            InitializeComponent();
            InitEvents();

            _customerService = customerService;

            GetCustomers();
        }

        private void InitEvents()
        {
            grdvCustomer.KeyDown += GrdvCustomer_KeyDown;
        }

        private void GrdvCustomer_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                grdvCustomer.GetFirstRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.End)
            {
                grdvCustomer.GetLastRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.M)
            {
                grdvCustomer.GetMiddleRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.PageUp)
            {
                grdvCustomer.GetPreviousRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                grdvCustomer.GetNextRow();
                e.Handled = true;
            }
        }

        public Customer GetSelectedCustomer()
        {
            return Generic.GetSelected<Customer>(grdvCustomer);
        }

        public void GetCustomers()
        {
            var customers = _customerService.ListAll();

            grdCustomer.DataSource = customers;
        }

        public void DeleteCustomer()
        {
            Generic.DeleteSelected<Customer>(grdvCustomer, customer => _customerService.Delete(customer));

            GetCustomers();
        }

        public void ExportToExcel()
        {
            Generic.ExportToFile(grdvCustomer, "Excel Dosyaları|*.xlsx");
        }

        public void ExportToPdf()
        {
            Generic.ExportToFile(grdvCustomer, "PDF Dosyaları|*.pdf");
        }

        public void ExportToHTML()
        {
            Generic.ExportToFile(grdvCustomer, "HTML Dosyaları|*.html");
        }

        public void Print()
        {
            Generic.Print(grdvCustomer);
        }
    }
}