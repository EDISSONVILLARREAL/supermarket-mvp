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
using static Supermarket_mvp.Views.PayModeView;

namespace Supermarket_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        private object payModeList;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePayModeDetail);


        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public void SetPayModeListBildingSource(BindingSource payModeBindingSource)
        {
            DgPayMode.DataSource = payModeList;
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
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }


        internal interface IPayModeView
        {
            event EventHandler SearchEvent;
            event EventHandler AddNewEvent;
            event EventHandler EditEvent;
            event EventHandler DeleteEvent;
            event EventHandler SaveEvent;
            event EventHandler CancelEvent;

            string SearchValue { get; set; }

            
            void Show();
            void SetPayModeListBildingSource(BindingSource payModeBindingSource);
        }
    }
}