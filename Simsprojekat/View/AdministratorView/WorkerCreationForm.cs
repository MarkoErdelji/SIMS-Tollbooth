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

namespace Simsprojekat.View.AdministratorView
{
    public partial class WorkerCreationForm : Form
    {
        UserType _userType;
        bool _isUpdate;
        private int userId;

        UserController _userController;
        TollBoothController _tollBoothController;
        public WorkerCreationForm(UserType type)
        {
            userId = 0;
            _isUpdate = false;
            _tollBoothController = new TollBoothController();
            _userController = new UserController();
            _userType = type;
            InitializeComponent();
        }

        public WorkerCreationForm(int id,string firstName, string lastName, string username, string password, string email, UserType type, Address address, City city, int tollBoothId)
        {
            userId = id;
            _userController = new UserController();
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
            tollBoothTextBox.Text = tollBoothId.ToString();
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
            int tollBoothId;
            try
            {
                tollBoothId = int.Parse(tollBoothTextBox.Text);
            }
            catch(Exception valueexception){
                invalidInfoLabel.Visible = true;
                return;
            }
            if (_tollBoothController.GetById(tollBoothId) is null)
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
            Worker w = new Worker(userId,
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                usernameTextBox.Text,
                passwordTextBox.Text,
                emailTextBox.Text,
                _userType, a, tollBoothId);
            if (!_isUpdate)
            {
                if (_userController.InsertWorker(w))
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
                Worker worker = _userController.GetWorker(w.Id);
                worker.FirstName = w.FirstName;
                worker.LastName = w.LastName;
                worker.Username = w.Username;
                worker.Password = w.Password;
                worker.Email = w.Email;
                worker.Adress = w.Adress;
                worker.Type = w.Type;
                worker.TollBoothId = w.TollBoothId;
                if (_userController.UpdateWorker(worker))
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

        private void WorkerCreationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
