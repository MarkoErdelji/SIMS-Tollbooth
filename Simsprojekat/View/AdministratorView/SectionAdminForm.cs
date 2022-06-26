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
    public partial class SectionAdminForm : Form
    {
        TollStationController tollStationController;
        SectionController sectionController;
        TollStation ts;

        public SectionAdminForm(int tollStationId)
        {
            tollStationController = new TollStationController();
            ts = tollStationController.GetById(tollStationId);
            sectionController = new SectionController();
            InitializeComponent();
            tollBoothNumberLabel.Text += " " + ts.Id;
            locationLabel.Text += " " + ts.location.Name;
            List<Section> sections = sectionController.GetByStationId(ts.Id);
            this.dataGridView1.Rows.Clear();
            foreach (Section section in sections)
            {

                var index = dataGridView1.Rows.Add();
                TollStation otherStation;
                if(section.EntryStationId == ts.Id)
                {
                    dataGridView1.Rows[index].Cells[0].Value = section.ExitStationId.ToString();
                    otherStation = tollStationController.GetById(section.ExitStationId);
                }
                else
                {
                    dataGridView1.Rows[index].Cells[0].Value = section.EntryStationId.ToString();
                    otherStation = tollStationController.GetById(section.EntryStationId);
                }
                dataGridView1.Rows[index].Cells[1].Value = otherStation.location.Name;
                dataGridView1.Rows[index].Cells[2].Value = section.Distance;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SectionAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void sectionCreateBtn_Click(object sender, EventArgs e)
        {
            new SectionCreationForm(ts.Id).ShowDialog();
        }

        private void sectionUpdate_Click(object sender, EventArgs e)
        {
            var selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        int otherStationId = int.Parse((string)dataGridView1.SelectedRows[i].Cells[0].Value);
                        new SectionUpdateForm(ts.Id, otherStationId, int.Parse((string)dataGridView1.SelectedRows[i].Cells[1].Value)).ShowDialog();
                    }
                    catch (Exception exc)
                    {
                        return;
                    }
                }

            }
        }

        private void sectionDeleteBtn_Click(object sender, EventArgs e)
        {
            var selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        int otherStationId = int.Parse((string)dataGridView1.SelectedRows[i].Cells[0].Value);
                        sectionController.Delete(ts.Id,otherStationId);
                    }
                    catch (Exception exc)
                    {
                        return;
                    }
                }
                MessageBox.Show("Selected sections successfuly deleted");

            }
        }
    }
}
