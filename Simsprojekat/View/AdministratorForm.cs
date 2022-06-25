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
    public partial class AdministratorForm : Form
    {
        UserController _userController;
        public AdministratorForm()
        {
            _userController = new UserController();
            InitializeComponent();
        }

        private void tolLStationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
            this.panel2.Hide();

        }

        private void tollStationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Show();
            this.panel1.Hide();
            List<User> users = _userController.GetAllUsers();
            this.userDataGridView.Rows.Clear();
            foreach (User user in users)
            {


                DataGridViewRow row = (DataGridViewRow)userDataGridView.Rows[0].Clone();
                row.Cells[0].Value = user.Id.ToString();
                row.Cells[1].Value = user.FirstName;
                row.Cells[2].Value = user.LastName;
                row.Cells[3].Value = user.Username;
                row.Cells[4].Value = user.Password;
                row.Cells[5].Value = user.Email;
                row.Cells[6].Value = ((UserType) user.Type).ToString();
                row.Cells[7].Value = user.Adress.ToString();
                row.Cells[8].Value = user.Adress.ToString();
                userDataGridView.Rows.Add(row);
            }
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
