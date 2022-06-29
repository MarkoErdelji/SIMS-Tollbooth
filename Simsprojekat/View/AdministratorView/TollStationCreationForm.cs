using Simsprojekat.Controller;
using Simsprojekat.Model;
using Simsprojekat.Observer;
using Simsprojekat.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simsprojekat.View.AdministratorView
{
    public partial class TollStationCreationForm : Form
    {
        bool _isUpdate;
        int tsId;
        TollStationController _tollStationController;
        IObserver _observer;
        public TollStationCreationForm(IObserver observer)
        {
            _isUpdate = false;
            tsId = 0;
            _observer = observer;
            _tollStationController = new TollStationController();
            InitializeComponent();
        }

        public TollStationCreationForm(IObserver observer,int id,string zipCode,string cityName)
        {
            _isUpdate = true;
            tsId = id;
            _observer = observer;
            _tollStationController = new TollStationController();
            InitializeComponent();
            cityTextBox.Text = cityName;
            zipCodeTextBox.Text = zipCode;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(zipCodeTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            City c = new City();
            c.Name = cityTextBox.Text;
            c.ZipCode = zipCodeTextBox.Text;
            TollStation ts = new TollStation();
            ts.Id = tsId;
            ts.tollBoothsId = new List<int>();
            ts.location = c;
            if (!_isUpdate)
            {
                if (_tollStationController.Insert(ts))
                {
                    invalidInfoLabel.Visible = false;
                    Thread trd = new Thread(() => ThreadCreator.TollBoothThreadTask(ts));
                    trd.IsBackground = true;
                    trd.Start();
                    MessageBox.Show("Toll station successfuly created");
                    ts.Attach(_observer);
                    ts.Notify();
                    this.Dispose();
                }
                else
                {
                    invalidInfoLabel.Visible = true;
                }
            }
            else
            {
                TollStation tollStation = _tollStationController.GetById(ts.Id);
                tollStation.Id = ts.Id;
                tollStation.location = ts.location;
                if (_tollStationController.Update(tollStation))
                {
                    invalidInfoLabel.Visible = false;
                    MessageBox.Show("Toll station successfuly updated");
                    ts.Attach(_observer);
                    ts.Notify();
                    this.Dispose();
                }
                else
                {
                    invalidInfoLabel.Visible = true;
                }
            }
        }

        private void TollStationCreationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
