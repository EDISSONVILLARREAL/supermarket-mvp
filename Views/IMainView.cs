using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IMainView
    {
        event EventHandler ShowPayModeView;
        event EventHandler ShowProductView;
        event EventHandler ShowCustomerView;
        event EventHandler ShowSupplierView;
        event EventHandler ShowSaleView;
        event EventHandler ShowPurchaseView;
        event EventHandler ShowReportView;
        event EventHandler ShowUserView;
        event EventHandler ShowSettingsView;
        event EventHandler ShowAboutView;
        event EventHandler ShowExitView;
        event EventHandler ShowHelpView;
        event EventHandler ShowHomeView;
        event EventHandler ShowLoginView;
        event EventHandler ShowLogoutView;
        event EventHandler ShowRegisterView;
        event EventHandler ShowDashboardView;
        event EventHandler ShowInventoryView;
        event EventHandler ShowSupplierReportView;
        event EventHandler ShowCustomerReportView;
        event EventHandler ShowSalesReportView;
        event EventHandler ShowPurchaseReportView;
        event EventHandler ShowUserReportView;
        event EventHandler ShowSettingsReportView;
        event EventHandler ShowAboutReportView;
        event EventHandler ShowExitReportView;
        event EventHandler ShowHelpReportView;
        event EventHandler ShowHomeReportView;
        event EventHandler ShowLoginReportView;
        event EventHandler ShowLogoutReportView;
        event EventHandler ShowRegisterReportView;
        event EventHandler ShowDashboardReportView;
        event EventHandler ShowInventoryReportView;






    }
}
