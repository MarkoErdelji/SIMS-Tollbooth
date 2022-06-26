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
    public partial class StationManagerCreationForm : Form
    {
        UserType _userType;
        private int userId;
        bool _isUpdate;
        UserController _userController;
        public StationManagerCreationForm(UserType type)
        {
            userId = 0;
            _userController = new UserController();
            _userType = type;
            _isUpdate = false;
            InitializeComponent();
        }

        public StationManagerCreationForm(int id,string firstName, string lastName, string username, string password, string email, UserType type, Address address, City city, int tollStationId)
        {
            _userController = new UserController();
            userId = id;
            _isUpdate = true;
            _userType = type;
            InitializeComponent();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            usernameTextBox.Text = username;
            passwordTextBox.Text = password;
            emailTextBox.Text = email;
            streetNameTextBox.Text = address.StreetName;
            streetNumberTextBox.Text = address.StreetNumber;
            cityTextBox.Text = city.Name;
            zipCodeTextBox.Text = city.ZipCode;
            tollStationIdTextBox.Text = tollStationId.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(streetNameTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(streetNumberTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
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
            int tollStationId;
            try
            {
                tollStationId = int.Parse(tollStationIdTextBox.Text);
            }
            catch (Exception valueexception)
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            Address a = new Address();
            a.StreetName = streetNameTextBox.Text;
            a.StreetNumber = streetNumberTextBox.Text;
            City c = new City();
            c.Name = cityTextBox.Text;
            c.ZipCode = zipCodeTextBox.Text;
            a.City = c;
            StationManager sm = new StationManager(userId,
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                usernameTextBox.Text,
                passwordTextBox.Text,
                emailTextBox.Text,
                _userType, a, tollStationId);
            if (!_isUpdate)
            {
                if (_userController.InsertStationManager(sm))
                {
                    invalidInfoLabel.Visible = false;
                    MessageBox.Show("User succesfuly created");
                    this.Dispose();
                }
                else
                {
                    invalidInfoLabel.Visible = true;
                }
            }
            else
            {
                StationManager stationManager = _userController.GetStationManager(sm.Id);
                stationManager.FirstName = sm.FirstName;
                stationManager.LastName = sm.LastName;
                stationManager.Username = sm.Username;
                stationManager.Password = sm.Password;
                stationManager.Email = sm.Email;
                stationManager.Adress = sm.Adress;
                stationManager.Type = sm.Type;
                stationManager.TollStationId = sm.TollStationId;
                if (_userController.UpdateStationManager(stationManager))
                {
                    invalidInfoLabel.Visible = false;
                    MessageBox.Show("User succesfuly updated");
                    this.Dispose();
                }
                else
                {
                    invalidInfoLabel.Visible = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StationManagerCreationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
