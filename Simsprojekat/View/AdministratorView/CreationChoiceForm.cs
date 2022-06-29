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
    public partial class CreationChoiceForm : Form
    {
        private IObserver _observer;
        public CreationChoiceForm(IObserver observer)
        {
            _observer = observer;
            InitializeComponent();
        }

        private void adminCreateBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserCreationForm usc = new UserCreationForm(_observer,UserType.Admin);
            usc.Visible = false;
            usc.ShowDialog();
        }

        private void stationManagerCreateBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            StationManagerCreationForm usc = new StationManagerCreationForm(_observer,UserType.StationManager);
            usc.Visible = false;
            usc.ShowDialog();
        }

        private void headManagerCreateBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserCreationForm usc = new UserCreationForm(_observer,UserType.HeadManager);
            usc.Visible = false;
            usc.ShowDialog();
        }

        private void workerCreateBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            WorkerCreationForm usc = new WorkerCreationForm(_observer,UserType.Worker);
            usc.Visible = false;
            usc.ShowDialog();

        }

        private void CreationChoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
