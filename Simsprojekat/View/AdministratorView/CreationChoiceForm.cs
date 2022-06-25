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
    public partial class CreationChoiceForm : Form
    {
        public CreationChoiceForm()
        {
            InitializeComponent();
        }

        private void adminCreateBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserCreationForm usc = new UserCreationForm(UserType.Admin);
            usc.Visible = false;
            usc.ShowDialog();
        }

        private void stationManagerCreateBtn_Click(object sender, EventArgs e)
        {

        }

        private void headManagerCreateBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserCreationForm usc = new UserCreationForm(UserType.HeadManager);
            usc.Visible = false;
            usc.ShowDialog();
        }

        private void workerCreateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
