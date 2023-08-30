using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUI
{
    public class CashBoxView
    {
        CashDesk cashDesk;
        public Label CashDeskName { get; set; }
        public NumericUpDown NumericBox { get; set; }
        public ProgressBar QueueLength { get; set; }
        public Label LeaveCustomersCount { get; set; }
        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;
            CashDeskName = new Label();
            NumericBox = new NumericUpDown();
            QueueLength = new ProgressBar();
            LeaveCustomersCount= new Label();

            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y);
            CashDeskName.Name = "modelCashDeskName" + number;
            CashDeskName.Size = new System.Drawing.Size(35, 13);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();

            NumericBox.Location = new System.Drawing.Point(x + 80, y);
            NumericBox.Name = "numericBoxCashDeskName" + number;
            NumericBox.Size = new System.Drawing.Size(120, 20);
            NumericBox.TabIndex = number;
            NumericBox.Maximum = 1000000000000000000;

            QueueLength.Location = new System.Drawing.Point(x + 300, y);
            QueueLength.Maximum = cashDesk.MaxQueueLength;
            QueueLength.Name = "modelQueueLenth" + number;
            QueueLength.Size = new System.Drawing.Size(100, 23);
            QueueLength.TabIndex = number;
            QueueLength.Value = 0;

            LeaveCustomersCount.AutoSize = true;
            LeaveCustomersCount.Location = new System.Drawing.Point(x + 400, y);
            LeaveCustomersCount.Name = "leaveCustomer" + number;
            LeaveCustomersCount.Size = new System.Drawing.Size(35, 13);
            LeaveCustomersCount.TabIndex = number;
            LeaveCustomersCount.Text = "";

            cashDesk.ChequeClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object? sender, Cheque e)
        {
            if (!NumericBox.IsDisposed)
            {
                NumericBox.Invoke((Action)delegate
                {
                    NumericBox.Value += e.TotalSumm;
                    QueueLength.Value = cashDesk.Count;
                    LeaveCustomersCount.Text = cashDesk.ExitCustomer.ToString();
                });
            }
        }
    }
}
