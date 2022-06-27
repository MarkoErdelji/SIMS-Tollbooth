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
    public partial class SectionCreationForm : Form
    {
        int stationOneId;
        SectionController _sectionController;
        TollStationController _tollStationController;
        public SectionCreationForm(int stationOneId)
        {
            this.stationOneId = stationOneId;
            _sectionController = new SectionController();
            _tollStationController = new TollStationController();
            InitializeComponent();

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(distanceTextBox.Text))
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            int tollStationId;
            try
            {
                tollStationId = int.Parse(toTextBox.Text);
            }
            catch (Exception valueexception)
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            int distance;
            try
            {
                distance = int.Parse(distanceTextBox.Text);
            }
            catch (Exception valueexception)
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            if (_tollStationController.GetById(tollStationId) is null)
            {
                invalidInfoLabel.Visible = true;
                return;
            }
            Section section = new Section();
            section.EntryStationId = stationOneId;
            section.ExitStationId = tollStationId;
            section.Distance = distance;
            if (_sectionController.Insert(section))
            {
                invalidInfoLabel.Visible = false;
                MessageBox.Show("Section successfuly created");
                this.Dispose();
            }
            else
            {
                invalidInfoLabel.Visible = true;
                return;
            }
        }

        private void SectionCreationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
