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

namespace Simsprojekat.View.HeadManagerView
{
    public partial class SectionHeadManagerForm : Form
    {
        TollStationController tollStationController;
        SectionController sectionController;
        TollStation ts;
        public SectionHeadManagerForm(int tollStationId)
        {
            tollStationController = new TollStationController();
            ts = tollStationController.GetById(tollStationId);
            sectionController = new SectionController();
            InitializeComponent();
            lblTollStationName.Text += " " + ts.Id;
            lblLocation.Text += " " + ts.location.Name;
            List<Section> sections = sectionController.GetByStationId(ts.Id);
            this.dgwSection.Rows.Clear();
           
            foreach (Section section in sections)
            {

                var index = dgwSection.Rows.Add();
                TollStation otherStation;
                if (section.EntryStationId == ts.Id)
                {
                    dgwSection.Rows[index].Cells[0].Value = section.ExitStationId.ToString();
                    otherStation = tollStationController.GetById(section.ExitStationId);
                }
                else
                {
                    dgwSection.Rows[index].Cells[0].Value = section.EntryStationId.ToString();
                    otherStation = tollStationController.GetById(section.EntryStationId);
                }
                dgwSection.Rows[index].Cells[1].Value = otherStation.location.Name;
                dgwSection.Rows[index].Cells[2].Value = section.Distance;
            }
        }
    }
}
