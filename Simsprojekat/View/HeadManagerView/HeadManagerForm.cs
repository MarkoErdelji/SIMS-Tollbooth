using Simsprojekat.Controller;
using Simsprojekat.Model;
using Simsprojekat.Observer;
using Simsprojekat.View.AdministratorView;
using Simsprojekat.View.HeadManagerView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simsprojekat.View.StationManagerView
{
    public partial class HeadManagerForm : Form, IObserver
    {
        private LoginForm _loginForm;
        private TollStationController _tollStationController;
        private PriceListController _priceListController;
        private UserController _userController;
        private int _selectedId;
        public HeadManagerForm(LoginForm loginForm)
        {
           
            this._loginForm = loginForm;
            _tollStationController = new TollStationController();
            _priceListController = new PriceListController();
            _userController = new UserController(); 
            InitializeComponent();
            this.btnSetActive.Enabled = false;
            this.panelTollStations.Show();
            this.panelPriceLists.Hide();
            this.panelWorkers.Hide();
            LoadTollStations();
        }


        private void yearlyGlobalIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionController transactionController = new TransactionController();
            GlobalYearPickerForm gypf = new GlobalYearPickerForm(transactionController);
            gypf.Show();
        }

        private void montlhyGlobalIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionController transactionController = new TransactionController();
            GlobalMonthPickerForm gmpf = new GlobalMonthPickerForm(transactionController);
            gmpf.Show();
        }

        private void dailyGlobalIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionController transactionController = new TransactionController();
            GlobalDateTimePickerForm gdtpf = new GlobalDateTimePickerForm(transactionController);
            gdtpf.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._loginForm.Show();
        }

        

        private void dgwTollStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
           
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                int tollStationId;
                tollStationId = int.Parse((string)dgwTollStations.Rows[e.RowIndex].Cells[0].Value);
                new SectionHeadManagerForm(tollStationId).ShowDialog();
            }
        }

        public void LoadWorkers()
        {
            List<User> users = _userController.GetAllUsers();
            this.dgwWorkers.Rows.Clear();

            users.ForEach(o => {
                if(o.Type == UserType.Worker)
                {
                    o.Attach(this);
                    var index = dgwWorkers.Rows.Add();
                    dgwWorkers.Rows[index].Tag = o;

                    dgwWorkers.Rows[index].Cells[0].Value = o.Id.ToString();
                    dgwWorkers.Rows[index].Cells[1].Value = o.FirstName;
                    dgwWorkers.Rows[index].Cells[2].Value = o.LastName;
                    dgwWorkers.Rows[index].Cells[3].Value = o.Username;
                    dgwWorkers.Rows[index].Cells[4].Value = o.Password;
                    dgwWorkers.Rows[index].Cells[5].Value = o.Email;
                    dgwWorkers.Rows[index].Cells[6].Value = ((UserType)o.Type).ToString();
                    dgwWorkers.Rows[index].Cells[7].Value = o.Adress.ToString();
                    dgwWorkers.Rows[index].Cells[8].Value = o.Adress.City.Name;

                }
            });

        }

        public void LoadTollStations()
        {
            List<TollStation> tollStations = _tollStationController.GetAll();
            this.dgwTollStations.Rows.Clear();
            tollStations.ForEach(o => {
                o.Attach(this);
                var index = dgwTollStations.Rows.Add();
                dgwTollStations.Rows[index].Tag = o;
                dgwTollStations.Rows[index].Cells[0].Value = o.Id.ToString();
                dgwTollStations.Rows[index].Cells[1].Value = o.location.Name;
                dgwTollStations.Rows[index].Cells[2].Value = o.location.ZipCode;



            });
        }

        public void LoadPriceLists()
        {
            List<PriceList> priceLists = _priceListController.GetAll();
            this.dgwPriceLists.Rows.Clear();
            priceLists.ForEach(o =>
            {

                o.Attach(this);

                var index = dgwPriceLists.Rows.Add();

                dgwPriceLists.Rows[index].Tag = o;

                dgwPriceLists.Rows[index].Cells[0].Value = o.Id.ToString();
                dgwPriceLists.Rows[index].Cells[2].Value = o.IsActive.ToString();
                dgwPriceLists.Rows[index].Cells[1].Value = o.LastActive.ToString();

            });
        }


        private void priceListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelPriceLists.Show();
            this.panelTollStations.Hide();
            this.panelWorkers.Hide();
            LoadPriceLists();
        }
        
        private void tollStationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelTollStations.Show();
            this.panelPriceLists.Hide();
            this.panelWorkers.Hide();
            LoadTollStations();
            
        }
        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelWorkers.Show();
            this.panelTollStations.Hide();
            this.panelPriceLists.Hide();
            LoadWorkers();
            
        }

        private void dgwPriceLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                int priceListId = int.Parse((string)dgwPriceLists.Rows[e.RowIndex].Cells[0].Value);
                bool isActive = bool.Parse((string)dgwPriceLists.Rows[e.RowIndex].Cells[2].Value);
                if (isActive == true)
                {
                    MessageBox.Show("You cannot update active price list");
                }
                else
                {
                    new CreateUpdatePriceListForm(this, priceListId).ShowDialog();
                }

            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                int priceListId = int.Parse((string)dgwPriceLists.Rows[e.RowIndex].Cells[0].Value);
                PriceList priceList = (PriceList)dgwPriceLists.Rows[e.RowIndex].Tag;
                bool isActive = bool.Parse((string)dgwPriceLists.Rows[e.RowIndex].Cells[2].Value);
                
                if (isActive == true)
                {
                    MessageBox.Show("You cannot delete active price list");
                }
                else
                {
                    if (_priceListController.Delete(priceListId))
                    {
                        MessageBox.Show("Price list successfuly deleted");
                        priceList.Notify();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            new CreateUpdatePriceListForm(this).ShowDialog();
        }

        private void btnSetActive_Click(object sender, EventArgs e)
        {
            changeActivePriceList();
        }

        private void changeActivePriceList()
        {
            PriceList selected = _priceListController.GetById(this._selectedId);
            PriceList active = _priceListController.GetActive();

            selected.IsActive = true;
            active.IsActive = false;

            selected.LastActive = "NOW";
            active.LastActive = DateTime.Now.ToString("dd-MM-yyyy");

            _priceListController.Update(selected);
            _priceListController.Update(active);
            MessageBox.Show("Successfuly changed active pricelist");
            selected.Attach(this);
            selected.Notify();


            active.Attach(this);
            active.Notify();

        }

        private void dgwPriceLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._selectedId = int.Parse((string)dgwPriceLists.Rows[e.RowIndex].Cells[0].Value);
            bool isActive = bool.Parse((string)dgwPriceLists.Rows[e.RowIndex].Cells[2].Value);
            if (isActive) btnSetActive.Enabled = false;
            else btnSetActive.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            WorkerCreationForm usc = new WorkerCreationForm(this, UserType.Worker);
            usc.Visible = false;
            usc.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRowCount = dgwWorkers.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        int userid = int.Parse((string)dgwWorkers.SelectedRows[i].Cells[0].Value);
                        string userType = (string)dgwWorkers.SelectedRows[i].Cells[6].Value;
                      
                        Worker w = _userController.GetWorker(userid);
                        WorkerCreationForm wcf = new WorkerCreationForm(this, w.Id, w.FirstName, w.LastName, w.Username, w.Password, w.Email, w.Type, w.Adress, w.Adress.City, w.TollBoothId);
                        wcf.ShowDialog();
                        
                    }
                    catch (Exception exc)
                    {
                        return;
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRowCount = dgwWorkers.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        int userid = int.Parse((string)dgwWorkers.SelectedRows[i].Cells[0].Value);
                        User user = (User)dgwWorkers.SelectedRows[i].Tag;
                        _userController.DeleteUser(userid);
                        user.Notify();

                    }
                    catch (Exception exc)
                    {
                        return;
                    }
                }
                MessageBox.Show("Selected users successfuly deleted");

            }
        }

        public void Update(IObservable observable)
        {
            LoadPriceLists();
            LoadTollStations();
            LoadWorkers();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._loginForm.Show();
        }
    }
}
