using Simsprojekat.Controller;
using Simsprojekat.Model;
using Simsprojekat.View.AdministratorView;
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
    public partial class AdministratorForm : Form
    {
        UserController _userController;
        TollStationController _tollStationController;
        public AdministratorForm()
        {
            _userController = new UserController();
            _tollStationController = new TollStationController();
            InitializeComponent();

        }

        private void tolLStationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
            this.panel2.Hide();
            List<TollStation> tollStations = _tollStationController.GetAll();
            this.tollStationGridView.Rows.Clear();
            foreach (TollStation tollStation in tollStations)
            {
                var index = tollStationGridView.Rows.Add();

                tollStationGridView.Rows[index].Cells[0].Value = tollStation.Id.ToString();
                tollStationGridView.Rows[index].Cells[1].Value = tollStation.location.Name;
                tollStationGridView.Rows[index].Cells[2].Value = tollStation.location.ZipCode;
            }

        }

        private void tollStationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            this.panel1.Show();
            this.panel2.Hide();
            List<TollStation> tollStations = _tollStationController.GetAll();
            this.tollStationGridView.Rows.Clear();
            foreach (TollStation tollStation in tollStations)
            {
                var index = tollStationGridView.Rows.Add();

                tollStationGridView.Rows[index].Cells[0].Value = tollStation.Id.ToString();
                tollStationGridView.Rows[index].Cells[1].Value = tollStation.location.Name;
                tollStationGridView.Rows[index].Cells[2].Value = tollStation.location.ZipCode;
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Show();
            this.panel1.Hide();
            List<User> users = _userController.GetAllUsers();
            this.userDataGridView.Rows.Clear();
            foreach (User user in users)
            {

                var index = userDataGridView.Rows.Add();

                userDataGridView.Rows[index].Cells[0].Value = user.Id.ToString();
                userDataGridView.Rows[index].Cells[1].Value = user.FirstName;
                userDataGridView.Rows[index].Cells[2].Value = user.LastName;
                userDataGridView.Rows[index].Cells[3].Value = user.Username;
                userDataGridView.Rows[index].Cells[4].Value = user.Password;
                userDataGridView.Rows[index].Cells[5].Value = user.Email;
                userDataGridView.Rows[index].Cells[6].Value = ((UserType) user.Type).ToString();
                userDataGridView.Rows[index].Cells[7].Value = user.Adress.ToString();
                userDataGridView.Rows[index].Cells[8].Value = user.Adress.City.Name;
            }
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userCreateBtn_Click(object sender, EventArgs e)
        {
            new CreationChoiceForm().ShowDialog();
        }

        private void userUpdateBtn_Click(object sender, EventArgs e)
        {
            var selectedRowCount = userDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        int userid = int.Parse((string)userDataGridView.SelectedRows[i].Cells[0].Value);
                        string userType = (string)userDataGridView.SelectedRows[i].Cells[6].Value;
                        if (userType.Equals("Worker")){
                            Worker w = _userController.GetWorker(userid);
                            WorkerCreationForm wcf = new WorkerCreationForm(w.Id,w.FirstName, w.LastName,w.Username,w.Password,w.Email,w.Type,w.Adress,w.Adress.City,w.TollBoothId);
                            wcf.ShowDialog();
                        }
                        if (userType.Equals("StationManager"))
                        {
                            StationManager sm = _userController.GetStationManager(userid);
                            StationManagerCreationForm wcf = new StationManagerCreationForm(sm.Id,sm.FirstName, sm.LastName, sm.Username, sm.Password, sm.Email, sm.Type, sm.Adress, sm.Adress.City, sm.TollStationId);
                            wcf.ShowDialog();
                        }
                        else
                        {
                            User u = _userController.GetUser(userid);
                            UserCreationForm wcf = new UserCreationForm(u.Id,u.FirstName, u.LastName, u.Username, u.Password, u.Email, u.Type, u.Adress, u.Adress.City);
                            wcf.ShowDialog();
                        }
                    }
                    catch (Exception exc)
                    {
                        return;
                    }
                }

            }
        }

        private void userDeleteBtn_Click(object sender, EventArgs e)
        {
            var selectedRowCount = userDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        int userid = int.Parse((string)userDataGridView.SelectedRows[i].Cells[0].Value);
                        _userController.DeleteUser(userid);
                                           }
                    catch (Exception exc){
                        return;
                    }
                }
                MessageBox.Show("Selected users successfuly deleted");

            }
        }

        private void tollStationUpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
