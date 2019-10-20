/*
Author: Richard Mora
Date: 10/18/19
CTEC 135: Microsoft Software Developnment with C#

Module 4, Programming Assignment 3, Problem 2 

    Inheritance Behavior: 

Demo of Field Access and Constructor Calling Sequence

Demostrates how using private and protected access modifiers can effect the access to fields from child classes

Demostrates calling sequence of constructors

Demostrates setting and getting field values
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            // here we test method inheritance

            // we created a new Leader object BigBoss with Regroup and Command Center
            // as parameters
            Leader BigBoss = new Leader("Regroup", "Command Center");
            // this calls the GiveTheOrder method from the leader's class 
            // and prints out the value of the objects that were inside 
            // the fields 
            BigBoss.GiveTheOrder();

            // we created a new Commander object SecondInCommand with Follow,
            // Bravo, and Stable as parameters
            Commander SecondInCommand = new Commander("Follow", "Bravo", "Stable");
            // this calls the GiveTheOrder method from the Commander's class 
            // and prints out the value of the objects with the exception of
            // the parameter string "Follow" since one of the parameters is 
            // from an object that has a private keyword attached to it so
            // this class can't access it
            SecondInCommand.GiveTheOrder();

            // We created a new Captain object ViceCaptain with Fall back, 
            // Alpha, Wounded, and Captain as parameters
            Captain ViceCaptain = new Captain("Fall back","Alpha", "Wounded", "Captain");
            // this calls the GiveTheOrder method from the Captain's class
            // and prints out the value of the objects except for the 
            // parameter string "Fall back" since again this string is from 
            // a object that has the private keyword attached to it so this
            // class can't access or use it.
            ViceCaptain.GiveTheOrder();

            // the next few lines shows that you can call the method of each
            // class using the "Captain" class or the grandchild of Leader
            ViceCaptain.LeadersOrders();
            ViceCaptain.CommanderOrders();
            ViceCaptain.CaptainsOrders();
            Console.WriteLine();
            
        }
    }
}
