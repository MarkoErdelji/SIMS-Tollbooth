using Simsprojekat.Controller;
using Simsprojekat.Model;
using Simsprojekat.Observer;
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

namespace Simsprojekat.View.AdministratorView
{
    public partial class TollBoothAdminForm : Form,IObserver
    {
        TollStationController tollStationController;
        TollBoothController tollBoothController;
        TollStation ts;

        public TollBoothAdminForm(int tollStationId)
        {
            tollStationController = new TollStationController();
            ts = tollStationController.GetById(tollStationId);
            tollBoothController = new TollBoothController();
            InitializeComponent();
            tollBoothNumberLabel.Text += " " + ts.Id;
            locationLabel.Text += " " + ts.location.Name;
            LoadTollBoothData();

        }

        public void Update(IObservable observable)
        {
            LoadTollBoothData();
        }

        public void LoadTollBoothData()
        {
            List<TollBooth> tollBooth = tollBoothController.GetByTollStationId(ts.Id);
            this.dataGridView1.Rows.Clear();
            tollBooth.ForEach(o =>
            {
                o.Attach(this);

                var index = dataGridView1.Rows.Add();

                dataGridView1.Rows[index].Tag = o;

                dataGridView1.Rows[index].Cells[0].Value = o.Id.ToString();
                dataGridView1.Rows[index].Cells[1].Value = o.TollBoothNumber;

             }
            );
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 )
            {
                int tollBoothId;
                tollBoothId = int.Parse((string)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                new DevicesForm(tollBoothController, tollBoothController.GetById(tollBoothId)).ShowDialog();
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void TollBoothAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void tollStationCreateBtn_Click(object sender, EventArgs e)
        {
            List<TollBooth> tollBooths = tollBoothController.GetByTollStationId(ts.Id);
            int maxNumber = 0;
            foreach (TollBooth tollB in tollBooths)
            {
                int currentNumber = int.Parse(tollB.TollBoothNumber);
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            TollBooth tb = new TollBooth();
            tb.TollBoothNumber = (maxNumber + 1).ToString();
            List<Device> devices = new List<Device>();
            devices.Add(new Ramp());
            devices.Add(new Camera());
            tb.Devices = devices;
            tb.TollStationId = ts.Id;
            tollBoothController.Insert(tb);
            tb.Attach(this);
            tb.Notify();
            MessageBox.Show("Toll booth successfuly created");

        }

        private void tollStationDeleteBtn_Click(object sender, EventArgs e)
        {
            var selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        int tollStationId = int.Parse((string)dataGridView1.SelectedRows[i].Cells[0].Value);
                        TollBooth tb = (TollBooth)dataGridView1.SelectedRows[i].Tag;
                        tollBoothController.Delete(tollStationId);
                        tb.Notify();
                    }
                    catch (Exception exc)
                    {
                        return;
                    }
                }
                MessageBox.Show("Selected toll booths successfuly deleted");

            }
        }
    }
}
