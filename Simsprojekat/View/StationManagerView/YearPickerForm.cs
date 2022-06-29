using Simsprojekat.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simsprojekat.Model;
using System.Windows.Forms;
using System.IO;

namespace Simsprojekat.View.StationManagerView
{
    
    partial class YearPickerForm : Form
    {
        public TransactionController transactionController;
        public StationManager stationManager;
        public YearPickerForm(TransactionController transactionController, StationManager stationManager)
        {
            InitializeComponent();
            this.transactionController = transactionController;
            this.stationManager = stationManager;
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = transactionController.GetAllByTollStation(stationManager.TollStationId);
            DateTime selectedDate = new DateTime(int.Parse(yearTextBox.Text), 1, 1, 0, 0, 0);

            StreamWriter fileDin = new StreamWriter("../../../Reports/Annual_Report_In_Dinars_for_" + yearTextBox.Text + ".txt");
            StreamWriter fileEur = new StreamWriter("../../../Reports/Annual_Report_In_Euros_for_" + yearTextBox.Text + ".txt");
            double euroSum = 0;
            double dinSum = 0;
            foreach(Transaction transaction in transactions)
            {
                string line = "";
                if(transaction.Date > selectedDate){
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
            MessageBox.Show("Annual report has been created! Check Reports directiorium.");
            this.Dispose();
        }
    }
}
