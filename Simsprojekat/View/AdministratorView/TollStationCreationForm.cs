﻿using Simsprojekat.Controller;
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
    public partial class TollStationCreationForm : Form
    {
        bool _isUpdate;
        int tsId;
        TollStationController _tollStationController;
        public TollStationCreationForm()
        {
            _isUpdate = false;
            tsId = 0;
            _tollStationController = new TollStationController();
            InitializeComponent();
        }

        public TollStationCreationForm(int id,string zipCode,string cityName)
        {
            _isUpdate = true;
            tsId = id;
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
                    MessageBox.Show("Toll station successfuly created");
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