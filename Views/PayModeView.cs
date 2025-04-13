using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Presenters;

namespace Supermarket_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModeDetail);
            BtnClose.Click += delegate { this.Close(); };



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

            // Asigna el evento Click del botón BtnNew para invocar el evento AddNewEvent
            BtnNew.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Add New Pay Mode"; // Cambia el titulo de la
                                                                // pestaña
            };

            BtnEdit.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Edit Pay Mode"; // Cambia el título de la
                                                              // pestaña


            };
            BtnDelete.Click += delegate {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay Mode",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnSave.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful) // SI grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPagePayModeDetail);
                    tabControl1.TabPages.Add(tabPagePayModeList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeDetail);
                tabControl1.TabPages.Add(tabPagePayModeList);
            };
        }

        public string PayModelId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PayModelName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string GetPayModeObservation()
        {
            throw new NotImplementedException();
        }

        public void SetPayModeObservation(string value)
        {
            throw new NotImplementedException();
        }

        public string GetSearchValue()
        {
            throw new NotImplementedException();
        }

        public void SetSearchValue(string value)
        {
            throw new NotImplementedException();
        }

        public bool GetIsEdit()
        {
            throw new NotImplementedException();
        }

        public void SetIsEdit(bool value)
        {
            throw new NotImplementedException();
        }

        public bool GetIsSuccessful()
        {
            throw new NotImplementedException();
        }

        public void SetIsSuccessful(bool value)
        {
            throw new NotImplementedException();
        }

        public string GetMessage()
        {
            throw new NotImplementedException();
        }

        public void SetMessage(string value)
        {
            throw new NotImplementedException();
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPayModelistBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }

        // Patrón singleton para controlar solo una instancia del formulario
        private static PayModeView instance;
        private string sqlConnectionString;

        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
                instance.MdiParent = parentContainer.IsMdiContainer ? parentContainer : null;

                /*
                instance.FormBorderStyle = FormBorderStyle.None; 
                /instance.Dock = DockStyle.Fill; 
                [YO NO PUSE ESTO PORQUE SE VUELVE MUY FEO EL FORMULARIO]
                */
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
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
            get { return IsEdit; }
            set { IsEdit = value; }
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

        bool IPayModeView.isEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

        private static IPayModeView GetInstance()
        {
            throw new NotImplementedException();
        }
    }
}
