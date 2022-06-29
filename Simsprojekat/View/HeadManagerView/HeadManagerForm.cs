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
        public HeadManagerForm(LoginForm loginForm)
        {
           
            this._loginForm = loginForm;
            _tollStationController = new TollStationController();
            InitializeComponent();
            this.priceListsPanel.Hide();
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

        private void pricelistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.priceListsPanel.Show();
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
    }
}
