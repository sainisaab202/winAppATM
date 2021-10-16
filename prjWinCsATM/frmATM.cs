using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using ATMLibrary;

namespace prjWinCsATM
{
    public partial class frmATM : Form
    {
        public frmATM()
        {
            InitializeComponent();
        }

        //For current Customer
        string accNum;
        clsATM anATM;

        private void frmATM_Load(object sender, EventArgs e)
        {
            anATM = new clsATM("ROYAL BANK ATM", "ATM001");
            lblTitle.Text = anATM.Company;

            getClientsFile();
            this.Height = 209;
            grpAccInfo.Visible = grpTransType.Visible = grpAccountType.Visible = grpPinValid.Visible = false;
        }

        /// <summary>
        /// Will add clients to our clsATM instance
        /// </summary>
        private void getClientsFile()
        {
            StreamReader myFile = new StreamReader("Clients.txt");
            while (!myFile.EndOfStream)
            {
                string tempNum = myFile.ReadLine();
                string tempName = myFile.ReadLine();
                string tempPin = myFile.ReadLine();
                clsClient tempClient = new clsClient(tempName, tempNum, tempPin);
                anATM.Fill(tempClient);
            }
            myFile.Close();
        }

        private void btnNextReadCard_Click(object sender, EventArgs e)
        {
            accNum = txtCardNum.Text.Trim().ToUpper();
            if (accNum.Length == 0)
            {
                MessageBox.Show("Please Enter Your Card Number!!", "Card Number is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNum.Focus();
            }
            else
            {
                if (anATM.Clients.ContainsKey(accNum))
                {
                    grpPinValid.Visible = true;
                    this.Height = 337;
                    lblWelcomeName.Text = "BIENVENUE, " + anATM.Clients[accNum].Name.ToUpper();
                }
                else
                {
                    MessageBox.Show("Invalid Account Number!!", "Try Again");
                    txtCardNum.Focus();
                }
            }
        }

        private void btnNextPinValid_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text.Trim();
            if (pin.Length == 0)
            {
                MessageBox.Show("Please Enter Your PIN Number!!", "Enter PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPin.Focus();
            }
            else
            {
                if (pin == anATM.Clients[accNum].Pin)
                {
                    grpAccountType.Visible = true;
                    this.Height = 461;
                    addRelatedTypes();
                }
                else
                {
                    MessageBox.Show("Invalid PIN Number!!", "Try Again");
                    txtPin.Focus();
                }
            }
        }

        /// <summary>
        /// Will add related account types of a client in Combo Box
        /// </summary>
        private void addRelatedTypes() 
        {
            getAccountsFile();
            foreach (clsAccount acc in anATM.Clients[accNum].Accounts.Values)
            {
                cmbAccountType.Items.Add(acc.Type);
            }
            cmbAccountType.SelectedIndex = 0;
        }

        /// <summary>
        /// Will add accounts in a Client
        /// </summary>
        private void getAccountsFile()
        {
            StreamReader myFile = new StreamReader("Accounts.txt");
            while (!myFile.EndOfStream)
            {
                string tempAccNum = myFile.ReadLine();
                string tempClientNum = myFile.ReadLine();
                string tempAccType = myFile.ReadLine();
                Int16 tempDay= Convert.ToInt16(myFile.ReadLine());
                Int16 tempMonth=Convert.ToInt16(myFile.ReadLine());
                Int16 tempYear = Convert.ToInt16(myFile.ReadLine());
                decimal tempBalance = Convert.ToDecimal(myFile.ReadLine());
                clsAccount tmpAcc = new clsAccount(tempBalance, tempAccNum, tempDay, tempMonth, tempYear, tempAccType);
                foreach(clsClient aClient in anATM.Clients.Values)
                {
                    if (aClient.Number == tempClientNum)
                    {
                        aClient.Accounts.Add(tmpAcc.Number, tmpAcc);
                    }
                }
            }
            myFile.Close();
        }

        private void btnNextAccType_Click(object sender, EventArgs e)
        {
            grpTransType.Visible = true;
            this.Height = 617;
            rdbDeposit.Checked = true;
        }

        private void rdbDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = lblDeposit.Visible = rdbDeposit.Checked;
        }

        private void rdbWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Visible = lblWithdraw.Visible = rdbWithdraw.Checked;
        }

        private void btnNextTransType_Click(object sender, EventArgs e)
        {
            foreach (clsAccount acc in anATM.Clients[accNum].Accounts.Values)
            {
                if (acc.Type == cmbAccountType.SelectedItem.ToString())
                {
                    if (rdbDeposit.Checked)
                    {
                        decimal amount = Convert.ToDecimal(txtDeposit.Text.Trim().Length != 0 ? txtDeposit.Text.Trim() : "0");
                        string response=acc.Deposit(amount);
                        if (response == "lessThanMin")
                        {
                            showMsg("Depositing Amount should be more than or equal to $2 ");
                            return;
                        }
                        else if (response == "moreThanMax")
                        {
                            showMsg("Depositing Amount should be less than or equal to $20000");
                            return;
                        }
                        else
                        {
                            grpTransType.Enabled = false;
                            grpAccInfo.Visible = true;
                            this.Height = 742;
                            lblAccInfo.Text=acc.Consult();
                        }                    
                    }
                    else if (rdbWithdraw.Checked)
                    {
                        decimal amount = Convert.ToDecimal(txtWithdraw.Text.Trim().Length != 0 ? txtWithdraw.Text.Trim() : "0");
                        string response = acc.Withdraw(amount);
                        if (response == "lessThanMin")
                        {
                            showMsg("Minimum amount for withdrawal is $20");
                            return;
                        }
                        else if(response == "moreThanMax")
                        {
                            showMsg("Maximum amount for withdrawal is $500");
                            return;
                        }
                        else if (response == "multipleOf20")
                        {
                            showMsg("Amount must be a multiple of 20's\nLike 20, 40, 60, 80, 100");
                            return;
                        }
                        else if (response == "insufficientBalance")
                        {
                            showMsg("Amount you entered is less than your Account Balance");
                            return;
                        }
                        else
                        {
                            grpTransType.Enabled = false;
                            grpAccInfo.Visible = true;
                            this.Height = 742;
                            lblAccInfo.Text = acc.Consult();
                        }
                    }
                    else
                    {
                        grpTransType.Enabled = false;
                        grpAccInfo.Visible = true;
                        this.Height = 742;
                        lblAccInfo.Text = acc.Consult();
                    }
                }
            }
        }

        /// <summary>
        /// Will Show a message Box with a specific message
        /// </summary>
        /// <param name="anyMessage">The message you want to display</param>
        private void showMsg(string anyMessage)
        {
            MessageBox.Show(anyMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //To take input only in numeric value for Deposit money
        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //To take input only in numeric value for Withdrew money
        private void txtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //To SAVE last transaction and to RESET everything for new transaction
        private void btnTerminate_Click(object sender, EventArgs e)
        {
            //Reset all the components
            lblAccInfo.Text = lblWelcomeName.Text = "";
            txtDeposit.Clear();
            txtWithdraw.Clear();
            cmbAccountType.Items.Clear();
            cmbAccountType.SelectedIndex = -1;
            txtPin.Clear();
            txtCardNum.Clear();

            //Save last transaction
            saveAccounts();
            saveClients();

            //Getting ready for new transaction
            this.Height = 209;
            grpAccInfo.Visible = grpTransType.Visible = grpAccountType.Visible = grpPinValid.Visible = false;
            grpTransType.Enabled = true;
            txtCardNum.Focus();

            //reset our collection
            anATM.Clients = null;
            anATM.Clients = new Dictionary<string, clsClient>();
            getClientsFile();
        }

        /// <summary>
        /// Will write data in text file(Accounts.txt) from Accounts collection
        /// </summary>
        private void saveAccounts()
        {
            StreamWriter myFile = new StreamWriter("Accounts.txt");
            Int16 clientCount = 0;
            Int16 accountCount = 0;
            
            foreach(clsClient aClient in anATM.Clients.Values)
            {
                accountCount = 0;
                foreach(clsAccount anAcc in aClient.Accounts.Values)
                {
                    myFile.WriteLine(anAcc.Number);
                    myFile.WriteLine(aClient.Number);
                    myFile.WriteLine(anAcc.Type);
                    myFile.WriteLine(anAcc.OpenDate.Day);
                    myFile.WriteLine(anAcc.OpenDate.Month);
                    myFile.WriteLine(anAcc.OpenDate.Year);
                    if (clientCount + 1 != anATM.Clients.Count || accountCount + 1 != aClient.Accounts.Count)
                        myFile.WriteLine(anAcc.Balance);
                    else
                        myFile.Write(anAcc.Balance);
                    accountCount++;
                }
                clientCount++;
            }
            myFile.Close();
        }

        /// <summary>
        /// Will save data in Clients.txt (file) from clients collection
        /// </summary>
        private void saveClients()
        {
            StreamWriter myClientFile = new StreamWriter("Clients.txt");
            Int16 count = 0;
            foreach(clsClient client in anATM.Clients.Values)
            {
                myClientFile.WriteLine(client.Number);
                myClientFile.WriteLine(client.Name);
                if (count + 1 != anATM.Clients.Count)
                    myClientFile.WriteLine(client.Pin);
                else
                    myClientFile.Write(client.Pin);

                count++;
            }
            myClientFile.Close();
        }
    }
}