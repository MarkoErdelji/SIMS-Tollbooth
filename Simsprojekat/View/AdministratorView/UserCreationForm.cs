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

namespace Simsprojekat.View.AdministratorView
{
    public partial class UserCreationForm : Form
    {
        UserType _userType;
        bool _isUpdate;
        private int userId;
        UserController _userController;
        IObserver _observer;
        public UserCreationForm(IObserver observer,UserType type)
        {
            _observer = observer;
            _isUpdate = false;
            userId = 0;
            _userController = new UserController();
            _userType = type;
            InitializeComponent();
        }

        public UserCreationForm(IObserver observer,int id,string firstName,string lastName,string username,string password,string email,UserType type,Address address,City city)
        {
            _observer = observer;
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
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
            Address a = new Address();
            a.StreetName = streetNameTextBox.Text;
            a.StreetNumber = streetNumberTextBox.Text;
            City c = new City();
            c.Name = cityTextBox.Text;
            c.ZipCode = zipCodeTextBox.Text;
            a.City = c;
            User u = new User(userId,
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                usernameTextBox.Text,
                passwordTextBox.Text,
                emailTextBox.Text,
                _userType,a);
            if (!_isUpdate)
            {
                if (_userController.InsertUser(u))
                {
                    invalidInfoLabel.Visible = false;
                    MessageBox.Show("User succesfuly created");
                    u.Attach(_observer);
                    u.Notify();
                    this.Dispose();
                }
                else
                {
                    invalidInfoLabel.Visible = true;
                }
            }
            else
            {
                User user = _userController.GetUser(u.Id);
                user.FirstName = u.FirstName;
                user.LastName = u.LastName;
                user.Username = u.Username;
                user.Password = u.Password;
                user.Email = u.Email;
                user.Adress = u.Adress;
                user.Type = u.Type;
                if (_userController.UpdateUser(user))
                {
                    invalidInfoLabel.Visible = false;
                    MessageBox.Show("User succesfuly updated");
                    user.Attach(_observer);
                    user.Notify();
                    this.Dispose();
                }
                else
                {
                    invalidInfoLabel.Visible = true;
                }
            }
        }

        private void UserCreationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
