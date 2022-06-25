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
    public partial class UserCreationForm : Form
    {
        UserType _userType;
        UserController _userController;
        public UserCreationForm(UserType type)
        {
            _userController = new UserController();
            _userType = type;
            InitializeComponent();
        }

        public UserCreationForm(string firstName,string lastName,string username,string password,string email,UserType type,Address address,City city)
        {
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
            Address a = new Address();
            a.StreetName = streetNameTextBox.Text;
            a.StreetNumber = streetNumberTextBox.Text;
            City c = new City();
            c.Name = cityTextBox.Text;
            c.ZipCode = zipCodeTextBox.Text;
            a.City = c;
            User u = new User(0,
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                usernameTextBox.Text,
                passwordTextBox.Text,
                emailTextBox.Text,
                _userType,a);
            if (_userController.CreateUser(u))
            {
                MessageBox.Show("User succesfuly created");
            }
            else
            {
                MessageBox.Show("Error while creating user");
            }
        }
    }
}
