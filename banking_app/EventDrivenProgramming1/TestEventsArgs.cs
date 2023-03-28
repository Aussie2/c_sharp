//Austin Tobin FRH7486
//Event Driven Programming (7630-414)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgramming1
{
    // to hold custom event info
    public class TestEventsArgs : EventArgs
    {
        public string Message { get; set; }
        public TestEventsArgs(string message)
        {
            Message = message;
        }
    }

    // publisher
    public class Publisher
    {
        // Declare event using EventHandler<T>
        public event EventHandler<TestEventsArgs> RaiseTestEvent;

        public void DoTestLogin(bool testMode)
        {
            if (testMode)
            {
                OnRaiseTestEvent(new TestEventsArgs("Test User logging in"));
            }
            
        }
    
        // Class used to publish the event
        protected virtual void OnRaiseTestEvent(TestEventsArgs e)
        {
            
            EventHandler<TestEventsArgs> raiseEvent = RaiseTestEvent;
            if (RaiseTestEvent != null)
            {
                // Append to testArgEvents message property value
                e.Message = $" at {DateTime.Now}";

                // Call the raise event
                raiseEvent(this, e);
            }
        }
    }

}
