using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Commander : Leader
    {
        //fields
        // here we created a protected string object Condition where it could
        // be accessed by other subclasses in this hierarchy
        protected string Condition;

        // consturctors
        // this default consturctor doesn't do much but it's needed for the 
        // other consturctor to run properly
        public Commander() { }

        // this master constructor requires three string as parameters for 
        // this constructor to execute. Order and the Location string object
        // are from the parent class Leader
        public Commander(string Order, string Location, string condition) 
            
            // the base(Order,Location) tells the complier this two string 
            // object is from a parent class
            : base(Order,Location)
        {
            // we use the this keyword to refer to itself when executing the 
            // code where the value of condition becomes Condition
            this.Condition = condition;
        }

        // this method is created where it outputs a text when this method 
        // is called
        public void CommanderOrders()
        {
            Console.WriteLine("A leader shows respect to their men");
        }

        // a way to print out string Order and Location
        // we use the same method from the Leader class with the addition of
        // the override keyword which allows this class to use the method
        // from the parent class and make this method unique to this class
        public override void GiveTheOrder()
        {
            Console.WriteLine("Status report Commander");
            // Since the string Order is from the Leader class and the access 
            // modifier is private, the child class Commander can't access 
            // that object thus I'm unable to execute the following line 
            // below
            // Console.WriteLine($"Order is: {Order}");

            // the following two lines prints out the value of Location
            // and Condition along with some text
            Console.WriteLine($"Location is: {Location}");
            Console.WriteLine($"Condition of Commander: {Condition}\n");
        }
    }
}
