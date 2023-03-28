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
    /// Login form
    /// </summary>
    public partial class Login : Form
    {
        //root directory path
        public string RootDir { set; get; }
        // log file name
        static string LogFileName = "LoginLog.log";
        // string for completed file path
        static string filePath;
        // Bool taken from settings.settings for testmode
        private readonly bool testMode = Properties.Settings.Default.testMode;
        //public int LoginAttempts = 0;
        private TextBox currentFocus;

        public Login()
        {
            InitializeComponent();

            //Set the initial focus on the account number text box
            currentFocus = txtAccNum;
            currentFocus.Focus();
        }
        // function for the login number pad
        private void btnInput_Click(object sender, EventArgs e)
        {
            currentFocus.Text += ((Button)sender).Text;
            currentFocus.Select(currentFocus.Text.Length, 0);   // Put the curser at the end where it should be
        }
        // On form load
        private void Login_Load(object sender, EventArgs e)
        {
            if (testMode) // if in test mode load a default test account
            {   // preload account and pin for test user
                txtAccNum.Text = "1000";
                txtPin.Text = "12345";
            }
            GetRootDirectory();             // root! directory for log files
        }
        // if the account number text box is clicked the focus is set there
        private void txtAccNum_Enter(object sender, EventArgs e)
        {
            currentFocus = txtAccNum;
        }
        // if the PIN text box is clicked the focus is set there
        private void txtPin_Enter(object sender, EventArgs e)
        {
            currentFocus = txtPin;
        }
        // Calls authentication function and if authentic the account will be passed to the main page
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginSuccess;                      // boolean variable to track if a login attempt is successful for the log

            string stAccNumber = txtAccNum.Text;    // Account number
            string stPinNumber = txtPin.Text;       // Pin number
            string sql = $"SELECT * FROM UserAccounts WHERE [AccNumber] = {stAccNumber} AND [PIN] = '{stPinNumber}';";

            var selectedAcc = data.GetData<Account>(sql, CommandType.Text);
            Account loadUser = new Account();

            if (selectedAcc.Count > 0)                      // if there is an account
            {                                               // Loading parameters
                var user = selectedAcc[0];                  // Select the first and only account from the list
                loadUser.AccNumber = user.AccNumber;
                loadUser.Name = user.Name;
                loadUser.Balance = user.Balance;
                Publisher p = new Publisher();
                p.RaiseTestEvent += EventMessage;           // Adding custom event to user object
                p.DoTestLogin(testMode);
                loginSuccess = true;                       // login success
                
                WriteToLoginFile(loginSuccess);             // Logs the successful login to the login log file


                MainPage accMgt = new MainPage(loadUser);   // create the main form object
                this.Hide();                                // Hide the login form
                accMgt.ShowDialog();                        // Make the main form visible
                this.Show();                                // Show the login form again
            }
            else
            {   // let the user know that they entered incorrect login details
                loginSuccess = false;
                WriteToLoginFile(loginSuccess);             // Logs the failed login to the login log file
                MessageBox.Show("Please enter valid login credentials", "Login Fail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearLogins();                                  // Clears the login text boxes for after the main page is closed
        }

        // clears the text boxes and resets the focus to to the account number text box (txtAccNum)
        private void ClearLogins()
        {
            txtAccNum.Clear();
            txtPin.Clear();
            currentFocus = txtAccNum;
            txtAccNum.Focus();
        }

        // Clears the account and PIN text boxes
        private void btnLBackSpace_Click(object sender, EventArgs e)
        {
            ClearLogins();
        }
        // Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Gets the root directory and sets up the path for the login log file
        private void GetRootDirectory()
        {
            // gets the location of executable
            String path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            // Assign to rootdir cutting off a couple of the folders
            RootDir = path.Replace("bin\\Debug\\EventDrivenProgramming1.exe", "");
            // MessageBox.Show(RootDir); // Message box to show what the string is
            filePath = RootDir + LogFileName;

        }
        // Write to log file
        private void WriteToLoginFile(bool success)
        {
            // create string, write to log. If log file doesn't exist create it
            string logDetails = $"\nTime: {DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortDateString()}, " +
                                $"Account number: {txtAccNum.Text}, Successful: {success}";
            File.AppendAllText(filePath,logDetails);
        }
        // Now the account number can only be numbers
        private void TxtBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;
            string str = tbx.Text;
            if (str.Length > 0)                                     // Prevent a crash if the text bix is empty
            {
                char charStr = str[str.Length - 1];                 // Select the last letter
                if (!Char.IsNumber(charStr))                        // Is the character NOT a number?
                {
                    tbx.Text = str.Substring(0, str.Length - 1);    //Cut off the last character and put it back in the text box
                    tbx.Select(tbx.Text.Length, 0);                 // Set the curser position to the end of the text
                }
            }
        }

        //static void EventMessage(object sender, EventsWriteToLoginFile e)
        //{ }

        static void EventMessage(object sender, TestEventsArgs e)
        {
            string logoutText = "\nTest user logged in at " + e.Message;
            File.AppendAllText(filePath, logoutText);
        }

    } // End of class


}

