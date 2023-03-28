//Austin Tobin FRH7486
//Event Driven Programming (7630-414)
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

namespace EventDrivenProgramming1
{
    /// <summary>
    /// Form with which transactions can be completed
    /// </summary>
    public partial class MainPage : Form
    {
        //root directory path
        public string RootDir { set; get; }
        // log file name
        static string LogFileName = "TransactionLog.log";
        // string for completed file path
        static string filePath;
        //variable to set the focus on the text box
        private TextBox currentFocus;
        // variable to pass the user object around
        public Account user;
        // bool for testmode
        private readonly bool testMode = Properties.Settings.Default.testMode;

        private static System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-IE");
        public MainPage(Account userAccount)
        {
            InitializeComponent();
            user = userAccount;                                                     // Pass the user object ot a global variable
            GetRoodDirectory();                                                     // get directory name as it is used in the log file
            lblBalance.Text = string.Format(culture, "{0:C2}", user.Balance);       // userAccount.Balance.ToString();
            // Display the balance
            lblAccNumber.Text = userAccount.AccNumber.ToString();                   // Display the account number
            lblName.Text = userAccount.Name;                                        // The user has a name, make them feel welcome
            lblStatus.Text = "";                                                    // Make the label initially blank
            currentFocus = txtAmount;                                               // Variable to be used in setting focus for buttons
           
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string labelString = "";
            bool statusBool;
            if (radioDeposit.Checked)                                               // See which radio button is checked and proceed accordingly
            {
                statusBool = user.Deposit(decimal.Parse(txtAmount.Text));           // Check if the deposit was successful (>0)
                labelString = TransactionHelperFunction(statusBool, $"Successful deposit of €" +
                    $"{txtAmount.Text}",
                    $"Unsuccessful deposit attempt", "Deposit");
            }
            else                                                                    // Similar process for withdrawal
            {
                statusBool = user.Withdrawal(decimal.Parse(txtAmount.Text));
                labelString = TransactionHelperFunction(statusBool, $"Successful withdrawal of €" +
                    $"{txtAmount.Text}", 
                    $"Unsuccessful withdrawal, \n Insufficient funds!", "Withdrawal");
            }
            
            lblStatus.Text = labelString;                                           // Set the status label 
            lblBalance.Text = string.Format(culture, "{0:C2}", user.Balance);       // user.Balance.ToString();    
        }

        // Helper function for transactions, sets the status label colour and text as well as writing to the transaction log file
        private string TransactionHelperFunction(bool statusBool, string passString, string failString, string transaction)
        {
            string labelString;
            if (statusBool)                                         // successsful deposit
            {
                lblStatus.ForeColor = Color.Green;                  // Set colour of the status label
                labelString = passString;                           // Set the status label string
                WriteToLoginFile(transaction, txtAmount.Text);      // Write to log file
            }
            else
            {
                lblStatus.ForeColor = Color.Red;                    // Set colour of the status label
                labelString = failString;                           // Set the status label string
            }
            return labelString;
        }
        // number pad buttons
        private void btnTouchpad_Click(object sender, EventArgs e)
        {
            currentFocus.Text += ((Button)sender).Text;         // Append the button text to the string in the box
            currentFocus.Select(currentFocus.Text.Length, 0);   // Put the curser at the end where it should be
        }
        // clear the amount text box
        private void btnMC_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
        }
        // logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // update balance of SQL DB 
            string strAmount = user.Balance.ToString();
            string strAccNumber = user.AccNumber.ToString();

            // Setup of SQL string
            string sql = $"UPDATE UserAccounts SET [Balance] = {strAmount} WHERE [AccNumber] = {strAccNumber}";
            // Run the SQL
            data.ExecuteSQLNonQuery(sql, CommandType.Text);
            //if (result > 0) // testing
            //    MessageBox.Show($"Result is: {result} \n Balance should be changed! New Balance {user.Balance}");


            Publisher p = new Publisher();
            p.RaiseTestEvent += EventMessage;           // Adding custom event to user object
            p.DoTestLogin(testMode);


            this.Close();       // Now close the form
        }

        // gets the location of executable
        private void GetRoodDirectory()
        {
            String path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            // Assign to rootdir cutting off a couple of the folders
            RootDir = path.Replace("bin\\Debug\\EventDrivenProgramming1.exe", "");
            // MessageBox.Show(RootDir); // Message box to show what the string is
            filePath = RootDir + LogFileName;
        }

        // Can't have non numerical values being entered for transactions now can we.
        private void TxtBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;
            string str = tbx.Text;
            if (str.Length > 0)                                         // Prevent a crash if the text bix is empty
            {
                char charStr = str[str.Length - 1];                     // Select the last letter
                if (charStr == '.')
                {
                    // check if there is more than one
                    if (str.Where(x => (x == '.')).Count() > 1)         // counting the decimal points, only one allowed!
                    {
                        TxtBoxHelper(str, tbx);                             // Chop off the last character and put the string back in the box  
                    }
                }
                else if (!Char.IsNumber(charStr))                        // Is the character NOT a number?
                {
                    TxtBoxHelper(str, tbx);                             // Chop off the last character and put the string back in the box  
                }
            }
            tbx.Focus();                                                // Put the curser back in the box
        }

        private void TxtBoxHelper(string str, TextBox tbx)
        {
            tbx.Text = str.Substring(0, str.Length - 1);        //Cut off the last character and put it back in the text box
            tbx.Select(tbx.Text.Length, 0);                     // Set the curser position to the end of the text
        }


        // Write to transaction log file
        private void WriteToLoginFile(string type, string amount)
        {
            // create string, write to log. If log file doesn't exist create it
            string logDetails =
                //account number, the time, date, the transaction type (deposit/withdrawal),
                //the amount and new balance
                $"\nUser: {user.AccNumber}, " +
                $"Time: {DateTime.Now.ToLongDateString()}," +
                $"Transaction Type: {type} , " +
                $"Amount: {amount}," +
                $"New Balance: {user.Balance}";
            File.AppendAllText(filePath, logDetails);
        }

        static void EventMessage(object sender, TestEventsArgs e)
        {
            string file = filePath.Replace("TransactionLog.log", "LoginLog.log");
            string logoutText = "\nTest user logged out " + e.Message;
            File.AppendAllText(file, logoutText);
        }
    }
}
