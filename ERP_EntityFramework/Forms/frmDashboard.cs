using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_EntityFramework_UI
{
    public partial class frmDashboard : XtraForm
    {
        public frmDashboard()
        {
            InitializeComponent();

            lblWelcome.Text = $"{GetGreeting()}, {Statics.User?.Username}";
            lblToday.Text = $"Bugün: {DateTime.Now.ToString("dd MMMM yyyy dddd")}";
        }

        private string GetGreeting()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 05 && hour < 12) return "Günaydın";

            if (hour >= 12 && hour < 18) return "Tünaydın";

            if (hour >= 18 && hour < 23) return "İyi akşamlar";

            return "İyi geceler";
        }
    }
}