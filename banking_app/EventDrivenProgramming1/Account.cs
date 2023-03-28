//Austin Tobin FRH7486
//Event Driven Programming (7630-414)

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDrivenProgramming1
{
    /// <summary>
    /// This class represents a bank account
    /// </summary>
    public class Account
    {
        
        public int AccNumber { get; set; }       // Account number
        //private string PIN { get; set; }            // PIN number
        public decimal Balance { get; set; }        // Balance in the account
        public string Name { get; set; }            // Name associated with the account (superfluous to marking but included all the same)
       // private static int SeedAccNum = 1002;       // Seed account number
        // Function to operate deposits
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            else if (amount > 0)
            {
                this.Balance += amount;
                return true;
            }
            else
                return false;
        }

        // Function to operate withdrawals
        public bool Withdrawal(decimal amount)
        {
            // NO overdraft is allowed
            if (amount < Balance)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        // return the PIN might be changed so that it validates the PIN
        //public bool CheckPin(string pin)
        //{
        //    if (pin == PIN)
        //        return true;
        //    else
        //        return false;
        //}

    //}
    //public class EventArgs
    //{ 
        //public event EventHandler<EventsWriteToLoginFile> CheckUser; // Publisher calls custom event class

        //public void CheckTestUser(Account user, string filePath, bool success)
        //{
        //    string LogFileName;
        //    int CurrentUser = user.AccNumber;
        //    int accNum = user.AccNumber;

        //    if (CurrentUser == 1000)
        //    {
        //        LogFileName = filePath + "testLoginLog.log";
        //    }
        //    else
        //    {
        //        LogFileName = filePath + "LoginLog.log";
        //    }
        //    CheckUser(this, new EventsWriteToLoginFile(success, LogFileName, accNum));
        //}
    }

    //Creating custom event Args
    //public class EventsWriteToLoginFile : EventArgs
    //{
    //    //public int sum { get; set; }
    //    public EventsWriteToLoginFile(bool success, string filePath, int accNum)
    //    {
    //        //sum = result;
    //        string logDetails = $"\nTime: {DateTime.Now.ToLongTimeString()+ " " + DateTime.Now.ToShortDateString()}, " +
    //                                        $"Account number: {accNum}, Successful: {success}";
    //        File.AppendAllText(filePath, logDetails);
    //    }
    //}


}
