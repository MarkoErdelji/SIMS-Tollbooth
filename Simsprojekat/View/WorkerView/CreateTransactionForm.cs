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

namespace Simsprojekat.View.WorkerView
{
    public partial class CreateTransactionForm : Form
    {
        private Section _section;
        private Ticket _ticket;
        private PriceListController _priceListController;
        private double _price;
        private WorkerForm _workerForm;
        private int _stationId;
        private TransactionController _transactionController;
        private TicketController _ticketController;

        public CreateTransactionForm(Section section, Ticket ticket, WorkerForm workerForm, int stationId)
        {
            _section = section;
            _ticket = ticket;
            _workerForm = workerForm;
            _priceListController = new PriceListController();
            _stationId = stationId;
            _transactionController = new TransactionController();
            _ticketController = new TicketController();
            InitializeComponent();

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            ShowVehicleSpeed();
            lblVehicle.Text = "Vehicle is of type: " + _ticket.Vehicle.Type.ToString();
            ShowPrice();

        }

        public void ShowVehicleSpeed()
        {
            var timeDiff = DateTime.Now.Subtract(_ticket.EntryTime).TotalHours;
            double averageSpeed = _section.Distance / timeDiff;
            lblSpeed.Text = "Average speed of the vehicle has been: " + Math.Round(averageSpeed, 2) + " km/h.";

        }

        public void ShowPrice()
        {
            var priceList = _priceListController.getActivePriceList();
            lblCena.Visible = true;
            if (rbEur.Checked)
            {
                if (_ticket.Vehicle.Type == VehicleType.Car)
                {
                    _price = priceList.CarCoeficient * priceList.basePriceEuro;
                }
                else if (_ticket.Vehicle.Type == VehicleType.Truck)
                {
                    _price = priceList.TruckCoeficient * priceList.basePriceEuro;
                }
                else if (_ticket.Vehicle.Type == VehicleType.Bike)
                {
                    _price = priceList.BikeCoeficient * priceList.basePriceEuro;
                }
                else if (_ticket.Vehicle.Type == VehicleType.Bus)
                {
                    _price = priceList.BusCoeficient * priceList.basePriceEuro;
                }
                else if (_ticket.Vehicle.Type == VehicleType.Car)
                {
                    _price = priceList.OtherCoeficient * priceList.basePriceEuro;
                }
                lblCena.Text = "Price: " + _price + " eur.";
            }
            else if (rbDin.Checked)
            {
                if (_ticket.Vehicle.Type == VehicleType.Car)
                {
                    _price = priceList.CarCoeficient * priceList.basePriceDinar;
                }
                else if (_ticket.Vehicle.Type == VehicleType.Truck)
                {
                    _price = priceList.TruckCoeficient * priceList.basePriceDinar;

                }
                else if (_ticket.Vehicle.Type == VehicleType.Bike)
                {
                    _price = priceList.BikeCoeficient * priceList.basePriceDinar;

                }
                else if (_ticket.Vehicle.Type == VehicleType.Bus)
                {
                    _price = priceList.BusCoeficient * priceList.basePriceDinar;

                }
                else if (_ticket.Vehicle.Type == VehicleType.Car)
                {
                    _price = priceList.OtherCoeficient * priceList.basePriceDinar;
                }
                lblCena.Text = "Price: " + _price + " din.";

            }
        }

        private void lblCena_Click(object sender, EventArgs e)
        {

        }

        private void btnKusur_Click(object sender, EventArgs e)
        {
            if (!rbEur.Checked && !rbDin.Checked)
            {
                MessageBox.Show("You need to choose the currency.");
                return;
            }

            String givenAmount = tbGivenAmount.Text;
            if (givenAmount == "")
            {
                MessageBox.Show("You need to enter the given amount of money!");
                return;
            }
            if (!double.TryParse(givenAmount, out _))
            {
                MessageBox.Show("You didn't enter a number for the given amount of money!");
                return;
            }

            double change = Convert.ToDouble(givenAmount) - _price;
            if (change < 0)
            {
                MessageBox.Show("Payee hasn't given you enough money!");
                return;
            }
            lblKusur.Visible = true;
            if (rbDin.Checked)
                lblKusur.Text = "Change is " + Math.Round(change, 2) + " din.";
            else
                lblKusur.Text = "Change is " + Math.Round(change, 2) + " eur.";
        }

        private void btnPodigniRampu_Click(object sender, EventArgs e)
        {
            if (!lblKusur.Visible)
            {
                MessageBox.Show("You need to calculate the change for the driver first.");
                return;
            } 
            _ticket.Done = true;
            _ticketController.Update(_ticket);

            var transaction = new Transaction(
                DateTime.Now,
                _price,
                rbDin.Checked ? true : false,
                _stationId,
                _ticket.Id
                );


            _transactionController.Insert(transaction);

            _workerForm.RaiseRamp();
            _workerForm.RampMovingTimer.Tick += new EventHandler(_workerForm.LowerRamp);
            _workerForm.RampMovingTimer.Interval = 7000;
            _workerForm.RampMovingTimer.Start();

            this.Close();
        }

        private void rbEur_CheckedChanged(object sender, EventArgs e)
        {
            ShowPrice();
        }
    }
}
