using Simsprojekat.Controller;
using Simsprojekat.Model;
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
    public partial class HeadManagerForm : Form
    {
        private LoginForm _loginForm;
        private TollStationController _tollStationController;
        private PriceListController _priceListController;
        public HeadManagerForm(LoginForm loginForm)
        {
           
            this._loginForm = loginForm;
            _tollStationController = new TollStationController();
            _priceListController = new PriceListController();
            InitializeComponent();
            this.panelTollStations.Hide();
            this.panelPriceLists.Hide();
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

        private void tollStationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelTollStations.Show();
            this.panelPriceLists.Hide();
            List<TollStation> tollStations = _tollStationController.GetAll();
            this.dgwTollStations.Rows.Clear();
            foreach (TollStation tollStation in tollStations)
            {
                var index = dgwTollStations.Rows.Add();

                dgwTollStations.Rows[index].Cells[0].Value = tollStation.Id.ToString();
                dgwTollStations.Rows[index].Cells[1].Value = tollStation.location.Name;
                dgwTollStations.Rows[index].Cells[2].Value = tollStation.location.ZipCode;
            }
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

        private void priceListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelPriceLists.Show();
            this.panelTollStations.Hide();
            List<PriceList> priceLists = _priceListController.GetAll();
            this.dgwPriceLists.Rows.Clear();
            foreach(PriceList priceList in priceLists)
            {
                var index = dgwPriceLists.Rows.Add();

                dgwPriceLists.Rows[index].Cells[0].Value = priceList.Id.ToString();
                dgwPriceLists.Rows[index].Cells[2].Value = priceList.IsActive.ToString();
                dgwPriceLists.Rows[index].Cells[1].Value = priceList.LastActive.ToString();

            }


        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                    new CreateUpdatePriceListForm(priceListId).ShowDialog();
                }

            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                int priceListId = int.Parse((string)dgwPriceLists.Rows[e.RowIndex].Cells[0].Value);
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
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            new CreateUpdatePriceListForm().ShowDialog();
        }
    }
}
