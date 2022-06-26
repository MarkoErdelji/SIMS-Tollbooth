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
        public StationManagerForm(StationManager stationManager)
        {
            InitializeComponent();
            this.tollBoothController = new TollBoothController();
            this.tollStationController = new TollStationController();
            this.stationManager = stationManager;
        }

        private void ListTollBoothPanel_Paint(object sender, PaintEventArgs e)
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
    }
}
