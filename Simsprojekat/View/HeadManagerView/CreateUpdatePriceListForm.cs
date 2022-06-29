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

namespace Simsprojekat.View.HeadManagerView
{
    public partial class CreateUpdatePriceListForm : Form
    {
        PriceListController _priceListController;
        PriceList? _priceList;
        bool _isNew;
        public CreateUpdatePriceListForm(int priceListId=-1)
        {
            this._priceListController = new PriceListController();
            this._priceList = null;

            InitializeComponent();
            
            if(priceListId == -1)
            {
                this._priceList = new PriceList();
                this._priceList.Id = -1;
                _isNew = true;

                txbBike.Text = "";
                txbTruck.Text = "";
                txbCar.Text = "";
                txbBus.Text = "";
                txbOther.Text = "";
                txbDinar.Text = "";
                txbEuro.Text = "";
            }
            else
            {
                this._priceList = this._priceListController.GetById(priceListId);
                _isNew = false;

                txbBike.Text = this._priceList.BikeCoeficient.ToString();
                txbTruck.Text = this._priceList.TruckCoeficient.ToString();
                txbCar.Text = this._priceList.CarCoeficient.ToString();
                txbBus.Text = this._priceList.BusCoeficient.ToString();
                txbOther.Text = this._priceList.OtherCoeficient.ToString();
                txbDinar.Text = this._priceList.BasePriceDinar.ToString();
                txbEuro.Text = this._priceList.BasePriceEuro.ToString();

            }

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (fieldsChecked()) {
                this._priceList.BikeCoeficient = Convert.ToDouble(txbBike.Text);
                this._priceList.TruckCoeficient = Convert.ToDouble(txbTruck.Text);
                this._priceList.CarCoeficient = Convert.ToDouble(txbCar.Text);
                this._priceList.BusCoeficient = Convert.ToDouble(txbBus.Text);
                this._priceList.OtherCoeficient = Convert.ToDouble(txbOther.Text);
                this._priceList.BasePriceDinar = Convert.ToDouble(txbDinar.Text);
                this._priceList.BasePriceEuro = Convert.ToDouble(txbEuro.Text);
                this._priceList.LastActive = "NEVER";
                this._priceList.IsActive = false;


                if (_isNew)
                {
                    _priceListController.Insert(_priceList);
                    MessageBox.Show("You have successfuly added new price list");
                }
                else
                {
                    _priceListController.Update(_priceList);
                    MessageBox.Show("You have successfuly updated price list");
                }
                this.Dispose();
            }
        }

        private bool fieldsChecked()
        {
            List<string> textBoxes = new List<string>()
            {
                txbBike.Text, txbTruck.Text, txbCar.Text, txbBus.Text,
                txbOther.Text, txbDinar.Text, txbEuro.Text,
            };


            foreach(string text in textBoxes)
            {
                if(text == "" || text == "0")
                {
                    MessageBox.Show("Inputs cannot be empty or 0");
                    return false;
                }
            }
            return true;
        }

        private void keyboardCheck(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txbEuro.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        private void txbEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyboardCheck(e);
        }

        private void txbDinar_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyboardCheck(e);
        }

        private void txbCar_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyboardCheck(e);
        }

        private void txbTruck_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyboardCheck(e);
        }

        private void txbOther_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyboardCheck(e);
        }

        private void txbBike_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyboardCheck(e);
        }

        private void txbBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyboardCheck(e);
        }
    }
}
