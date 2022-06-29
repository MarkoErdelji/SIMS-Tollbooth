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

namespace Simsprojekat.View
{
    public partial class WorkerForm : Form
    {
        private LoginForm _loginForm;
        private TollBooth _tollBooth;

        public WorkerForm(Worker worker,LoginForm loginform)
        {
            _loginForm = loginform;
            InitializeComponent();
            welcomeLabel.Text += " " + worker.FirstName + " " + worker.LastName;
            _tollBooth = new TollBoothController().GetById(worker.TollBoothId);
            tollBoothLabel.Text += _tollBooth.TollBoothNumber;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            foreach (Device device in _tollBooth.Devices)
            {
                if (device.Name == "Ramp")
                {
                    if (device.Faulty)
                    {
                        tbTicket.Enabled = false;
                        lblRamp.ForeColor = Color.Red;
                        lblRamp.Text = "Ramp is not in function.";
                    }
                    else
                    {
                        lblRamp.ForeColor = Color.Green;
                        lblRamp.Text = "Ramp is in function.";
                    }
                }
                else
                {
                    if (device.Faulty)
                    {
                        tbTicket.Enabled = false;
                        lblCamera.ForeColor = Color.Red;
                        lblCamera.Text = "Camera is not in function.";
                    }
                    else
                    {
                        lblCamera.ForeColor = Color.Green;
                        lblCamera.Text = "Camera is in function.";
                    }

                }


            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _loginForm.Show();
        }
    }
}
