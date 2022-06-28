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

namespace Simsprojekat.View.StationManagerView
{

    partial class DevicesForm : Form
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
                    MessageBox.Show("Device successfully fixed");
                }
            }

        }

        private void DevicesForm_Load(object sender, EventArgs e)
        {
            this.devicesGridView.Rows.Clear();
            foreach (Device device in tollBooth.Devices)
            {


                var index = devicesGridView.Rows.Add();
                devicesGridView.Rows[index].Cells[0].Value = device.Name;
                if (device.Faulty)
                {
                    devicesGridView.Rows[index].Cells[1].Value = "Broken";
                }
                else
                {
                    devicesGridView.Rows[index].Cells[1].Value = "Working";
                }
                

            }
        }
    }
}
