using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simsprojekat.Model;

namespace Simsprojekat.View
{
    public partial class LoginForm : Form
    {
        private UserController _userController;
        public LoginForm()
        {
            _userController = new UserController();
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user = _userController.Login(usernameTextBox.Text, passwordTextBox.Text);
            wrongLoginLabel.Visible = false;
            if (user != null)
            {
                this.Hide();
                if (user.Type == UserType.Admin)
                {
                    AdministratorForm adminForm = new AdministratorForm(this);
                    adminForm.Show();
                }
                if (user.Type == UserType.HeadManager)
                {
                    HeadManagerForm headManagerForm = new HeadManagerForm();
                    headManagerForm.Show();
                }
                if (user.Type == UserType.StationManager)
                {
                    StationManagerForm stationManagerForm = new StationManagerForm(_userController.GetStationManager(user.Id));
                    stationManagerForm.Show();
                }
                if (user.Type == UserType.Worker)
                {
                    Worker worker = _userController.GetWorker(user.Id);
                    WorkerForm workerForm = new WorkerForm(worker,this);
                    workerForm.Show();
                }
            }
            else
            {
                wrongLoginLabel.Visible = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
