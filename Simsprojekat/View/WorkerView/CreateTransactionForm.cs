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

namespace Simsprojekat.View.WorkerView
{
    public partial class CreateTransactionForm : Form
    {
        private Section _section;
        private Ticket _ticket;
        public CreateTransactionForm(Section section, Ticket ticket)
        {
            _section = section;
            _ticket = ticket;
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            var timeDiff = DateTime.Now.Subtract(_ticket.EntryTime).TotalHours;
            double averageSpeed = _section.Distance / timeDiff;
            lblSpeed.Text = "Average speed of the vehicle has been: " + Math.Round(averageSpeed, 2) + " km/h.";
        }
    }
}
