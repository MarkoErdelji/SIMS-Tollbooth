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
using Simsprojekat.Controller;
using Simsprojekat.Model;
using Simsprojekat.View.StationManagerView;
using Simsprojekat.Utils;
using System.Runtime.InteropServices;

namespace Simsprojekat.View
{
    public partial class LoginForm : Form
    {
        private UserController _userController;
        private TollBoothController tollBoothController;
        private TollStationController tollStationController;


        public LoginForm()
        {
            tollBoothController = new TollBoothController();
            tollStationController = new TollStationController();
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
                    HeadManagerForm headManagerForm = new HeadManagerForm(this);
                    headManagerForm.Show();
                }
                if (user.Type == UserType.StationManager)
                {
                    StationManager sm = _userController.GetStationManager(user.Id);
                    TollStation ts = tollStationController.GetById(sm.TollStationId);
                    if (ts == null)
                    {
                        MessageBox.Show("You are being redirected to another tollstation! (Administrator)");
                        return;
                    }
                    StationManagerForm stationManagerForm = new StationManagerForm(this, sm);
                    stationManagerForm.Show();
                }
                if (user.Type == UserType.Worker)
                {
                    Worker worker = _userController.GetWorker(user.Id);
                    TollBooth tb = tollBoothController.GetById(worker.TollBoothId);
                    if (tb == null)
                    {
                        MessageBox.Show("You are being redirected to another tollbooth! (Administrator)");
                        return;
                    }
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
            List<TollStation> tollStations = tollStationController.GetAll();
            foreach(TollStation ts in tollStations)
            {
                Thread trd = new Thread(() => ThreadCreator.TollBoothThreadTask(ts));
                trd.IsBackground = true;
                trd.Start();
            }
        }


        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
