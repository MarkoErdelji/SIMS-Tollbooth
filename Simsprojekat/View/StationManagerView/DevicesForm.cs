using Simsprojekat.Controller;
using Simsprojekat.Model;
using Simsprojekat.Observer;
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

    partial class DevicesForm : Form,IObserver
    {
        public TollBoothController tollBoothController;
        public TollBooth tollBooth;
        public DevicesForm(TollBoothController tollBoothController, TollBooth tollBooth)
        {
            InitializeComponent();
            this.tollBoothController=tollBoothController;
            this.tollBooth = tollBooth;
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            int rowindex = devicesGridView.CurrentRow.Index;
            string selectedDeviceName = (string)devicesGridView.Rows[rowindex].Cells[0].Value;
            foreach(Device device in tollBooth.Devices)
            {
                if(device.Name == selectedDeviceName)
                {
                    device.Faulty = false;
                    tollBoothController.Update(tollBooth);
                    device.Attach(this);
                    device.Notify();
                    MessageBox.Show("Device successfully fixed");
                }
            }

        }

        public void LoadData()
        {
            this.devicesGridView.Rows.Clear();
            tollBooth.Devices.ForEach(o =>
            {
                var index = devicesGridView.Rows.Add();


                devicesGridView.Rows[index].Cells[0].Value = o.Name;
                if (o.Faulty)
                {
                    devicesGridView.Rows[index].Cells[1].Value = "Broken";
                }
                else
                {
                    devicesGridView.Rows[index].Cells[1].Value = "Working";
                }
            });

        }

        private void DevicesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void Update(IObservable observable)
        {
            LoadData();
        }
    }
}
