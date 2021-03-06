using Simsprojekat.Controller;
using Simsprojekat.Model;
using Simsprojekat.View.StationManagerView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simsprojekat.View
{
    partial class StationManagerForm : Form
    {
        public StationManager stationManager;
        public TollBoothController tollBoothController;
        public TollStationController tollStationController;
        private LoginForm _loginForm;
        public StationManagerForm(LoginForm loginForm, StationManager stationManager)
        {
            InitializeComponent();
            this._loginForm = loginForm;
            this.tollBoothController = new TollBoothController();
            this.tollStationController = new TollStationController();
            this.stationManager = stationManager;
        }

        private void ListTollBoothPanel_Paint(object sender, PaintEventArgs e)
        {


            LoadData();

        }
        
        public void LoadData()
        {
            List<TollBooth> tollBooths = GetTollBooths();
            TollStation tollStation = tollStationController.GetById(stationManager.TollStationId);
            tollStationNameLabel.Text = tollStation.location.Name;
            this.listOfTollBoothsGridView.Rows.Clear();
            foreach (TollBooth tollBooth in tollBooths)
            {


                var index = listOfTollBoothsGridView.Rows.Add();
                listOfTollBoothsGridView.Rows[index].Cells[0].Value = tollBooth.Id.ToString();
                listOfTollBoothsGridView.Rows[index].Cells[1].Value = tollBooth.TollBoothNumber;

            }
        }

        private void listTollboothsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListTollBoothPanel.Visible = true;
           
        }

        private void StationManagerForm_Load(object sender, EventArgs e)
        {
            ListTollBoothPanel.Show();
            LoadData();
        }
        public List<TollBooth> GetTollBooths()
        {
            List<TollBooth> tollBooths = new List<TollBooth>();
            TollStation tollStation = tollStationController.GetById(stationManager.TollStationId);
            foreach(int tollBoothId in tollStation.tollBoothsId)
            {
                tollBooths.Add(tollBoothController.GetById(tollBoothId));
            }
            return tollBooths;
            


        }

        private void listOfTollBoothsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == listOfTollBoothsGridView.Columns["devices"].Index && e.RowIndex >= 0)
            {
                Console.WriteLine("Button on row {0} clicked", e.RowIndex);
                int id = int.Parse((string)listOfTollBoothsGridView.Rows[e.RowIndex].Cells[0].Value);
                TollBooth tb = tollBoothController.GetById(id);
                DevicesForm devicesForm = new DevicesForm(tollBoothController, tb);
                devicesForm.Show();
            }
        }

        private void yearlyLocalIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            TransactionController transactionController = new TransactionController();
            YearPickerForm ypf = new YearPickerForm(transactionController, stationManager);
            ypf.Show();

        }

        private void monthlyLocalIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionController transactionController = new TransactionController();
            MonthPickerForm monthPickerForm = new MonthPickerForm(transactionController, stationManager);
            monthPickerForm.Show();

        }

        private void dailyLocalIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionController transactionController = new TransactionController();
            DateTimePickerForm dateTimePickerForm = new DateTimePickerForm(transactionController, stationManager);
            dateTimePickerForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this._loginForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this._loginForm.Show();
        }
    }
}
