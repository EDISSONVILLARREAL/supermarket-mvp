using Supermarket_mvp.Models;
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
    public partial class PayModeView : Form IPayModeView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public PayModeView()

        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePayModeDetail);


        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }

        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }

        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        public string PayModeSearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool PayModeIsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool PayModeIsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string PayModeMessage
        {
            get { return message; }
            set { message = value; }
        }
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void SetPayModeListBindingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }

        void IPayModeView.Add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        void IPayModeView.Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        IEnumerable<PayModeModel> IPayModeView.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<PayModeModel> IPayModeView.GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
