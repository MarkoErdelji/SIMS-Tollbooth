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

namespace Simsprojekat.View
{
    public partial class WorkerForm : Form
    {
        private LoginForm _loginForm;

        public WorkerForm(Worker worker,LoginForm loginform)
        {
            _loginForm = loginform;
            InitializeComponent();
            welcomeLabel.Text += " " + worker.FirstName + " " + worker.LastName;
            TollBooth tb = new UserController().GetTollbooth(worker.TollBoothId);
            tollBoothLabel.Text += tb.TollBoothNumber;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _loginForm.Show();
        }
    }
}
