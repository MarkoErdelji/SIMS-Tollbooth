using Simsprojekat.Controller;
using Simsprojekat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simsprojekat.View.AdministratorView
{
    public partial class TollBoothAdminForm : Form
    {
        TollStationController tollStationController;
        TollBoothController tollBoothController;

        public TollBoothAdminForm(int tollStationId)
        {
            tollStationController = new TollStationController();
            TollStation ts = tollStationController.GetById(tollStationId);
            tollBoothController = new TollBoothController();
            InitializeComponent();
            List<TollBooth> tollBooth = tollBoothController.GetByTollStationId(tollStationId);
            tollBoothNumberLabel.Text += " " + ts.Id;
            locationLabel.Text += " " + ts.location.Name;
            this.dataGridView1.Rows.Clear();
            foreach (TollBooth tb in tollBooth)
            {

                var index = dataGridView1.Rows.Add();

                dataGridView1.Rows[index].Cells[0].Value = tb.Id.ToString();
                dataGridView1.Rows[index].Cells[1].Value = tb.TollBoothNumber;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int tollBoothId;
                tollBoothId = int.Parse((string)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                new DeviceAdminForm(tollBoothId).ShowDialog();
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void TollBoothAdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
