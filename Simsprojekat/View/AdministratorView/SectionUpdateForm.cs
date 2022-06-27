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
    public partial class SectionUpdateForm : Form
    {
        int stationOneId;
        int stationTwoId;
        SectionController _sectionController;
        TollStationController _tollStationController;

        public SectionUpdateForm(int stationOneId,int stationTwoId, int distance)
        {
            this.stationOneId = stationOneId;
            this.stationTwoId = stationTwoId;
            _sectionController = new SectionController();
            _tollStationController = new TollStationController();
            InitializeComponent();
            this.distanceTextBox.Text = distance.ToString();
        }

        private void SectionUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(distanceTextBox.Text))
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
            Section section = _sectionController.GetByStationIds(stationOneId,stationTwoId);
            section.EntryStationId = stationOneId;
            section.ExitStationId = stationTwoId;
            section.Distance = distance;
            if (_sectionController.Update(section))
            {
                invalidInfoLabel.Visible = false;
                MessageBox.Show("Section successfuly updated");
                this.Dispose();
            }
            else
            {
                invalidInfoLabel.Visible = true;
                return;
            }
        }
    }
}
