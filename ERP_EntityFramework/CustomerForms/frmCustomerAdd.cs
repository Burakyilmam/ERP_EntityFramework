using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.Design;
using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_Entities.Enums;
using System;
using System.Windows.Forms;

namespace ERP_EntityFramework_UI.CustomerForms
{
    public partial class frmCustomerAdd : XtraForm
    {
        private readonly ICustomerService _customerService;
        private Customer _customer;
        public frmCustomerAdd(ICustomerService service, Customer customer = null)
        {
            InitializeComponent();

            _customerService = service;
            _customer = customer;

            InitEvents();
            InitCustomerType();

            if (_customer != null)
            {
                customerBindingSource.DataSource = _customer;
            }
        }

        private void InitEvents()
        {
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void InitCustomerType()
        {
            edCustomerType.Properties.Items.Clear();

            edCustomerType.Properties.Items.Add(new ImageComboBoxItem("Bireysel", CustomerType.Person));

            edCustomerType.Properties.Items.Add(new ImageComboBoxItem("Kurumsal", CustomerType.Company));
        }

        void Save()
        {
            if (string.IsNullOrWhiteSpace(edName.Text) || string.IsNullOrWhiteSpace(edSurname.Text))
            {
                MessageBox.Show("Ad Soyad boş olamaz.");
                return;
            }

            if (edCustomerType.EditValue == null)
            {
                MessageBox.Show("Müşteri tipi seçiniz.");
                return;
            }

            if (_customer == null)
            {
                Customer newCustomer = new Customer
                {
                    Name = edName.EditValue.ToString(),
                    Surname = edSurname.EditValue.ToString(),
                    DateOfBirth = (DateTime)edDateOfBirth.EditValue,
                    Notes = edNotes.EditValue.ToString(),
                    TaxNumber = edTaxNumber.EditValue.ToString(),
                    CreateDate = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    CompanyName = edCompanyName.Text,
                    CustomerCode = edCustomerCode.Text,
                    CustomerType = (CustomerType)edCustomerType.EditValue,
                    IsActive = true,
                };

                _customerService.Add(newCustomer);

                MessageBox.Show("Yeni Müşteri oluşturuldu.");
            }
            else
            {
                _customer.Name = edName.EditValue.ToString();
                _customer.Surname = edSurname.EditValue.ToString();
                _customer.DateOfBirth = (DateTime)edDateOfBirth.EditValue;
                _customer.Notes = edNotes.EditValue.ToString();
                _customer.TaxNumber = edTaxNumber.EditValue.ToString();
                _customer.CompanyName = edCompanyName.EditValue.ToString();
                _customer.CustomerCode = edCustomerCode.EditValue.ToString();
                _customer.CustomerType = (CustomerType)edCustomerType.EditValue;
                _customer.UpdateDate = DateTime.Now;
                _customer.UpdatedBy = Statics.User.Username;

                _customerService.Update(_customer);

                MessageBox.Show("Müşteri bilgileri güncellendi.");
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}