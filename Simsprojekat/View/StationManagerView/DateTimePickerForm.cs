using Simsprojekat.Controller;
using Simsprojekat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simsprojekat.View.StationManagerView
{
    partial class DateTimePickerForm : Form
    {
        public TransactionController transactionController;
        public StationManager stationManager;
        public DateTimePickerForm(TransactionController transactionController, StationManager stationManager)
        {
            InitializeComponent();
            this.transactionController = transactionController;
            this.stationManager = stationManager;
        }


        private void createReportButton_Click(object sender, EventArgs e)
        {
            DateTime pickedDate = dateTimePicker1.Value.Date;
            List<Transaction> transactions = transactionController.GetAllByTollStation(stationManager.TollStationId);


            StreamWriter fileDin = new StreamWriter("../../../Reports/Daily_Report_In_Dinars_for_" + pickedDate.ToString("dd_MM_yyyy") + ".txt");
            StreamWriter fileEur = new StreamWriter("../../../Reports/Daily_Report_In_Euros_for_" + pickedDate.ToString("dd_MM_yyyy") + ".txt");
            double euroSum = 0;
            double dinSum = 0;
            foreach (Transaction transaction in transactions)
            {
                string line = "";
                if (transaction.Date >= pickedDate)
                {
                    line += transaction.Id.ToString();
                    line += "\t";
                    line += transaction.Date.ToString("D");
                    line += "\t";
                    line += transaction.Amount.ToString();
                    if (transaction.PaidInDinars)
                    {

                        fileDin.WriteLine(line);

                        dinSum += transaction.Amount;

                    }
                    else
                    {
                        fileEur.WriteLine(line);
                        euroSum += transaction.Amount;
                    }
                }
            }
            string sumDin = "Sum: ";
            string sumEuro = "Sum: ";
            sumDin += dinSum.ToString();
            sumEuro += euroSum.ToString();
            fileDin.WriteLine(sumDin);
            fileEur.WriteLine(sumEuro);
            fileDin.Close();
            fileEur.Close();
            MessageBox.Show("Daily report has been created! Check Reports directiorium.");
            this.Dispose();
        }
    }
}
