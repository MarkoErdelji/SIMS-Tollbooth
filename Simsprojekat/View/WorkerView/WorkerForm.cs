using Simsprojekat.Controller;
using Simsprojekat.Model;
using Simsprojekat.View.WorkerView;
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
        private SectionController _sectionController;
        private TicketController _ticketController;
        private TollStationController _tollStationController;

        public WorkerForm(Worker worker,LoginForm loginform)
        {
            _loginForm = loginform;
            _sectionController = new SectionController();
            _ticketController = new TicketController();
            _tollStationController = new TollStationController();
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

        private void submitTicketBtn_Click(object sender, EventArgs e)
        {
            if(tbTicket.Text == "")
            {
                MessageBox.Show("Ticket ID input field can't be empty!");
                return;
            }

            var ticketId = Convert.ToInt32(tbTicket.Text);
            var ticket = _ticketController.GetById(ticketId);
            if(ticket == null)
            {
                MessageBox.Show("Ticket with this ID doesn't exist!");
                return;
            }
            var stationId = _tollStationController.FindByTollBooth(_tollBooth.Id).Id;

            var sections = _sectionController.All();
            
            var sec = sections.Find(section =>
                (section.EntryStationId == ticket.EntryStationId || section.ExitStationId == ticket.EntryStationId)
                && (section.EntryStationId == stationId || section.ExitStationId == stationId)
            );

            if(sec != null)
            {
                CreateTransactionForm transactionForm = new CreateTransactionForm(sec, ticket);
                transactionForm.ShowDialog();
            } else
            {
                MessageBox.Show("You can't use this ticket here!");
            }

            
/*            foreach (Section section in sections)
            {
                if (section.EntryStationId == ticket.EntryStationId || section.ExitStationId == ticket.EntryStationId)
                {
                    if (section.EntryStationId == stationId || section.ExitStationId == stationId)
                    {
                        MessageBox.Show("It works :)");
                        return;
                    }
                }
            }*/
            
        }
    }
}
