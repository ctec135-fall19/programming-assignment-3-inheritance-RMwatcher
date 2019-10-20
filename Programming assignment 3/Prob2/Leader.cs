/*
Author: Richard Mora
Date: 10/18/19
CTEC 135: Microsoft Software Development with C#

Module 4: Programming Assignment 3: Problem 3

    Inheritance Behavior

Demo of Field Access and Constructor Calling Sequence

Create a class hierarchy that shows the effects of the private and 
protected access modifiers on access to fields form the child classes

These classes have to demostrate what happens when a class is calling
a sequence of methods. They also have to show the getter and setter 
values from the field section 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Leader
    {
        // fields
        // here we created two string objects Order and Location where the 
        // differences is Order is a private string while Location is a 
        // protected string
        // private makes it so no other class can access this object
        private string Order;
        // protected makes it so other subclasses could access this object in 
        // this hierarchy
        protected string Location;

        // constructors
        // Here we have a default constructor which doesn't do much, but is 
        // needed for the other constructor to run properly.
        public Leader() { }

        // this is a master constructor where it requires two string 
        // parameters for it to execute
        public Leader(string order, string location)
        {
            // for both objects we use the this keyword to have these objects
            // refer to itself when assigning a value to these objects
            this.Order = order;
            this.Location = location;
        }

        // method
        // this method we created is unique to this class when called
        public void LeadersOrders()
        {
            Console.WriteLine("A good leader inspires loyality");
        }

        // a way to print out string Order and Location
        // this method was created with a virtual keyword so since this class
        // is considered the parent, other subclasses in this hierarchy
        // are allowed to use this method again so as long as they have 
        // the override keyword so they can make it they own unique method
        public virtual void GiveTheOrder()
        {
            // the first line simply adds text to the output
            Console.WriteLine("Give me the order and your location Leader");

            // the following two lines shows the value of the objects Order
            // and Location. The $ symbol helps reduce the amount of you 
            // you could use by making it so you don't have to use two {}
            // and a comma inside the Console.WriteLine statement.
            Console.WriteLine($"Order is: {Order}");
            Console.WriteLine($"Location is: {Location}\n");

        }
    }
}
