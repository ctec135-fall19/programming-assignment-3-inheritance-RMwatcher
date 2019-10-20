using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Captain : Commander
    {
        // fields
        // here we created a protected string object named Rank which could
        // be shared with other classes if there were one other class below 
        // this one
        protected string Rank;

        // constructors
        // this is a default constructor which doesn't do anything but is 
        // required for the other constructor to run.
        public Captain() { }

        // this master constructor have parameters of order, location, 
        // Condition and rank where order, location and Condition are from 
        // another class from a parent class.
        public Captain(string order, string location, string Condition, string rank) 

            // this line tells the complier order, location and Condition
            // are from a parent class saying it can use the paramenter here
            : base(order,location,Condition)
        {
            // we use the this keyword to tell Captain to refer to itself
            // when assigning Rank with rank whichever rank happens to be
            this.Rank = rank;
        }
        // this method we created is unique to this class when called 
        public void CaptainsOrders()
        {
            // when this method is called, it outputs a message
            Console.WriteLine("Don't let your men down.");
        }

        // this method was from a parent class that has a virtual keyword
        // as a modifier. The override keyword lets the the class Captain
        // to use this method and add their own code to make it their own
        public override void GiveTheOrder()
        {
            Console.WriteLine("What's your status Captain sir?");
            //Console.WriteLine($"Order is: {Order}");

            // the following three lines show the value of the three objects
            // Location, Condition and Rank in this class. The $ made the 
            // shorter to write where it doesn't require two {} and a comma
            Console.WriteLine($"Location is: {Location}");
            Console.WriteLine($"Condition of Captain: {Condition}");
            Console.WriteLine($"The rank of the Captain: {Rank}\n");
        }
    }
}
