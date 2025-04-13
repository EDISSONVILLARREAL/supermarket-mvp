using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };

        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowCustomerView;
        public event EventHandler ShowSupplierView;
        public event EventHandler ShowSaleView;
        public event EventHandler ShowPurchaseView;
        public event EventHandler ShowReportView;
        public event EventHandler ShowUserView;
        public event EventHandler ShowSettingsView;
        public event EventHandler ShowAboutView;
        public event EventHandler ShowExitView;
        public event EventHandler ShowHelpView;
        public event EventHandler ShowHomeView;
        public event EventHandler ShowLoginView;
        public event EventHandler ShowLogoutView;
        public event EventHandler ShowRegisterView;
        public event EventHandler ShowDashboardView;
        public event EventHandler ShowInventoryView;
        public event EventHandler ShowSupplierReportView;
        public event EventHandler ShowCustomerReportView;
        public event EventHandler ShowSalesReportView;
        public event EventHandler ShowPurchaseReportView;
        public event EventHandler ShowUserReportView;
        public event EventHandler ShowSettingsReportView;
        public event EventHandler ShowAboutReportView;
        public event EventHandler ShowExitReportView;
        public event EventHandler ShowHelpReportView;
        public event EventHandler ShowHomeReportView;
        public event EventHandler ShowLoginReportView;
        public event EventHandler ShowLogoutReportView;
        public event EventHandler ShowRegisterReportView;
        public event EventHandler ShowDashboardReportView;
        public event EventHandler ShowInventoryReportView;
    }
}