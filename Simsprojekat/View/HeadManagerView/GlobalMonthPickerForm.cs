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

namespace Simsprojekat.View.HeadManagerView
{
    partial class GlobalMonthPickerForm : Form
    {
        public TransactionController transactionController;
        public GlobalMonthPickerForm(TransactionController transactionController)
        {
            InitializeComponent();
            this.transactionController = transactionController;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = transactionController.GetAll();
            DateTime selectedDate = new DateTime(int.Parse(yearTxb.Text), int.Parse(monthTxb.Text), 1, 0, 0, 0);

            StreamWriter fileDin = new StreamWriter("../../../Reports/Monthly_Global_Report_In_Dinars_for_" + monthTxb.Text + "_" + yearTxb.Text + ".txt");
            StreamWriter fileEur = new StreamWriter("../../../Reports/Monthly_Global_Report_In_Euros_for_" + monthTxb.Text + "_" + yearTxb.Text + ".txt");
            double euroSum = 0;
            double dinSum = 0;
            foreach (Transaction transaction in transactions)
            {
                string line = "";
                if (transaction.Date > selectedDate)
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
            this.Dispose();
        }
    }
}
