using Fare;
using Simsprojekat.Controller;
using Simsprojekat.Model;
using Simsprojekat.Observer;
using Simsprojekat.View.AdministratorView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simsprojekat.View
{
    public partial class AdministratorForm : Form,IObserver
    {
        UserController _userController;
        TollStationController _tollStationController;
        TollBoothController _tollBoothController;
        TicketController _ticketController;
        SectionController _sectionController;

        private LoginForm _loginForm;
        public AdministratorForm(LoginForm loginForm)
        {
            _loginForm = loginForm;
            _sectionController = new SectionController();
            _userController = new UserController();
            _tollBoothController = new TollBoothController();
            _tollStationController = new TollStationController();
            _ticketController = new TicketController();
            InitializeComponent();

        }

        public void Update(IObservable observable)
        {
            LoadTollStationData();
            LoadUserData();
        }

        public void LoadTollStationData()
        {
            List<TollStation> tollStations = _tollStationController.GetAll();
            this.tollStationGridView.Rows.Clear();
            tollStations.ForEach(o =>
            {
                o.Attach(this);

                var index = tollStationGridView.Rows.Add();

                tollStationGridView.Rows[index].Tag = o;

                tollStationGridView.Rows[index].Cells[0].Value = o.Id.ToString();
                tollStationGridView.Rows[index].Cells[1].Value = o.location.Name;
                tollStationGridView.Rows[index].Cells[2].Value = o.location.ZipCode;
            }
            );
        }

        public void LoadUserData()
        {
            List<User> users = _userController.GetAllUsers();
            this.userDataGridView.Rows.Clear();

            users.ForEach(o =>
            {
                o.Attach(this);

                var index = userDataGridView.Rows.Add();

                userDataGridView.Rows[index].Tag = o;

                userDataGridView.Rows[index].Cells[0].Value = o.Id.ToString();
                userDataGridView.Rows[index].Cells[1].Value = o.FirstName;
                userDataGridView.Rows[index].Cells[2].Value = o.LastName;
                userDataGridView.Rows[index].Cells[3].Value = o.Username;
                userDataGridView.Rows[index].Cells[4].Value = o.Password;
                userDataGridView.Rows[index].Cells[5].Value = o.Email;
                userDataGridView.Rows[index].Cells[6].Value = ((UserType)o.Type).ToString();
                userDataGridView.Rows[index].Cells[7].Value = o.Adress.ToString();
                userDataGridView.Rows[index].Cells[8].Value = o.Adress.City.Name;
            });
        }

        private void tolLStationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
            this.panel2.Hide();
            this.panel3.Hide();
            LoadTollStationData();

        }

        private void tollStationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                int tollStationId;
                tollStationId = int.Parse((string)tollStationGridView.Rows[e.RowIndex].Cells[0].Value);
                new TollBoothAdminForm(tollStationId).ShowDialog();
                //TODO - Button Clicked - Execute Code Here
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                int tollStationId;
                tollStationId = int.Parse((string)tollStationGridView.Rows[e.RowIndex].Cells[0].Value);
                new SectionAdminForm(tollStationId).ShowDialog();
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            this.panel1.Show();
            this.panel2.Hide();
            this.panel3.Hide();
            LoadTollStationData();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Show();
            this.panel1.Hide();
            this.panel3.Hide();
            LoadUserData();
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
            new CreationChoiceForm(this).ShowDialog();
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
                            WorkerCreationForm wcf = new WorkerCreationForm(this,w.Id,w.FirstName, w.LastName,w.Username,w.Password,w.Email,w.Type,w.Adress,w.Adress.City,w.TollBoothId);
                            wcf.ShowDialog();
                        }
                        if (userType.Equals("StationManager"))
                        {
                            StationManager sm = _userController.GetStationManager(userid);
                            StationManagerCreationForm wcf = new StationManagerCreationForm(this, sm.Id,sm.FirstName, sm.LastName, sm.Username, sm.Password, sm.Email, sm.Type, sm.Adress, sm.Adress.City, sm.TollStationId);
                            wcf.ShowDialog();
                        }
                        else if (userType.Equals("HeadManager") || userType.Equals("Admin"))

                        {
                            User u = _userController.GetUser(userid);
                            UserCreationForm wcf = new UserCreationForm(this, u.Id,u.FirstName, u.LastName, u.Username, u.Password, u.Email, u.Type, u.Adress, u.Adress.City);
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
                        User u = (User) userDataGridView.SelectedRows[i].Tag;
                        _userController.DeleteUser(userid);
                        u.Notify();

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
            var selectedRowCount = tollStationGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        int tollStationId = int.Parse((string)tollStationGridView.SelectedRows[i].Cells[0].Value);
                        TollStation ts = _tollStationController.GetById(tollStationId);
                        new TollStationCreationForm(this,ts.Id, ts.location.ZipCode,ts.location.Name).ShowDialog();
                        
                    }
                    catch (Exception exc)
                    {
                        return;
                    }
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _loginForm.Show();
        }

        private void tollStationDeleteBtn_Click(object sender, EventArgs e)
        {
            var selectedRowCount = tollStationGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        int tollStationId = int.Parse((string)tollStationGridView.SelectedRows[i].Cells[0].Value);
                        TollStation ts = (TollStation)tollStationGridView.SelectedRows[i].Tag;
                        List<TollBooth> tollBooths = _tollBoothController.GetByTollStationId(tollStationId);
                        List<Section> tollStationSections = _sectionController.GetByStationId(ts.Id);
                        foreach (TollBooth tb  in tollBooths){
                            _tollBoothController.Delete(tb.Id);
                        }
                        foreach(Section s in tollStationSections)
                        {
                            _sectionController.Delete(s.EntryStationId, s.ExitStationId);
                        }
                        _tollStationController.Delete(tollStationId);
                        ts.Notify();
                    }
                    catch (Exception exc)
                    {
                        return;
                    }
                }
                MessageBox.Show("Selected toll stations successfuly deleted");

            }
        }

        private void tollStationCreateBtn_Click(object sender, EventArgs e)
        {
            new TollStationCreationForm(this).ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ticketGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Hide();
            this.panel1.Hide();
            this.panel3.Show();
            List<TollStation> tollStations = _tollStationController.GetAll();
            comboBox1.Items.Clear();
            foreach (TollStation tollStation in tollStations)
            {
                comboBox1.Items.Add(tollStation.Id + "," +tollStation.location.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ticketGenButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem is null){
                return;
            }
            string item = (string)comboBox1.SelectedItem;
            string tollStationId = item.Split(",")[0];
            int tollStationIdint;
            RadioButton rb = null;
            VehicleType type;

            if (backgroundRadioButton2.Checked == true)
            {
                type = VehicleType.Car;
            }
            else if (backgroundRadioButton1.Checked == true)
            {
                type = VehicleType.Truck;
            }
            else if (backgroundRadioButton3.Checked == true)
            {
                type = VehicleType.Bike;
            }
            else if (backgroundRadioButton4.Checked == true)
            {
                type = VehicleType.Bus;
            }
            else
            {
                type = VehicleType.Other;
            }
            try
            {
                tollStationIdint = int.Parse(tollStationId);
            }
            catch (Exception)
            {
                return;
            }
            TollStation tollStation = _tollStationController.GetById(tollStationIdint);
            Ticket t = new Ticket();
            t.EntryStationId = tollStationIdint;
            t.Done = false;
            t.EntryTime = DateTime.Now;
            var xeger = new Xeger("[A-Z][A-Z]-[0-9][0-9][0-9]-[A-Z][A-Z]");
            string generatedString = xeger.Generate();
            Vehicle vehicle = new Vehicle();
            if (new Random().Next(2) == 1)
            {
                vehicle.ElectronicTag = true;
            }
            else {
                vehicle.ElectronicTag = false;
            }
            vehicle.Type = type;
            vehicle.LicencePlate = generatedString;
            t.Vehicle = vehicle;

            _ticketController.Insert(t);
            MessageBox.Show("Ticket successfuly created\n" +
                "Vehicle license plate: " + generatedString + "\n" +
                "Electronic tag: " + vehicle.ElectronicTag + "\n" +
                "Vehicle type: " + vehicle.Type.ToString()
            );
        }

        private void vehicleRadioGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
