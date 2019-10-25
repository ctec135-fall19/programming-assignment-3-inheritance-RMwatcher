/*
Author: Richard Mora
Date: 10/22/2019
CTEC 135: Microsoft Software Development with C#

Module 4, Programming Assignment 3, Problem 4 

    Inheritance Behavior

Create a hierarchy of classes that demonstrates polymorphic behavior

An array of the base class type is created and initialized with a member of each class in the hierarchy

Show that a method belonging to the base class is called from a child instance

Demonstrate overriding a base class method by a child

Demonstrate a child method calling the parent's method

Demonstrate use of "as" and "is" keyword

Demonstrate calling a method in a for loop iterating over the instances in the array

Demonstrate calling a method in a foreach loop

Demonstrate switch statement that responds differently depending upon the type of the object

Create an object of "object" type, but initialized of the base class type, then cast it to the actual type so you can call a method

Create an object of the base class type but initialized to a child type that has a specialized method. Call the specialized method by using casting.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            //first bullet
            // here we create an new class array called Prince with a 
            // size of 3 elements
            KingsClass[] Prince = new KingsClass[3];

            // the following three lines fill in the index of the Prince array
            // each taking up a new KingsClass, QueensClass and JacksClass.
            // Each class is part of a hierarchy where KingsClass is the 
            // parent of QueensClass and QueensClass is the parent of 
            // JacksClass. Assigning each new class to an index initialized
            // each class type
            Prince[0] = new KingsClass();
            Prince[1] = new QueensClass();
            Prince[2] = new JacksClass();

            // second bullet
            // we use a foreach loop to iterate through the Prince array, 
            // where rank acts as the index for each class type also running
            // GetType() method with each class type that gets the type of 
            // the current instance
            foreach (KingsClass rank in Prince)
            {
                Console.Write("{0}: \t",rank.GetType());
                // we also run the KingsMethod() method that was created in
                // the KingsClass class and since each class type is part of 
                // a hierarchy, the child class can call this method due to
                // being the child to the KingsClass class.
                rank.KingsMethod();
            }

            Console.WriteLine();

            //third bullet
            // We use another foreach loop to iterate through the array 
            // Prince where rank acts as the index for the loop. 
            foreach (KingsClass rank in Prince)
            {
                // just like the prevous line adove, we run the GetType() 
                // method to get the type of the current instance or rank
                Console.Write("{0}: \t",rank.GetType());
                // each time we iterate through the forloop, we have each
                // instance also run the RoyalSeal() method to show the
                // virtual keyword of KingsClass and override keyword of 
                // the QueensClass and JacksClass where the two classes
                // use ROyalSeal() method however they like.
                rank.RoyalSeal();
            }

            Console.WriteLine();


            // forth bullet
            // this foreach loop runs the exact same way as the forloop adove
            foreach (KingsClass rank in Prince)
            {
                // This shows how each of the child classes can execute 
                // their parent's method by using the virtual keyword for the
                // parent and override keyword for the child classes.
                Console.Write("{0}: \t",rank.GetType());
                // each time this loop iterate, each class in the Prince 
                //array will run their version of RoyalMetting() method
                // on their class
                rank.RoyalMeeting();
                Console.WriteLine();
            }

            Console.WriteLine();

            // fifth bullet
            // again we create a foreach loop through the Prince array where
            // status acts as a index
            foreach (KingsClass status in Prince)
            {
                // we use the "as" keyword to see if the KingsClass Princess
                // has the same value as status in the KingsClass class
                // meaning Princess will act like status if they are the
                // same value otherwise it won't run property
                KingsClass Princess = status as KingsClass;

                // each time the loop iterates, it'll run the GetType() method
                // and run the RoyalSeal() method in each class on the Prince
                // array
                Console.WriteLine("{0}: \t", Princess.GetType());
                Princess.RoyalSeal();
                Console.WriteLine();
            }

            Console.WriteLine();

            // sixth bullet
            // this foreach loop creates a index of KingsClass Knight
            // for the array Prince for every item inside it.
            foreach (KingsClass Knight in Prince)
            {

                // the following if and else if statements test the conditions
                // of each item inside the array Prince. By using the 'is' 
                // keyword, we test out if any item in the Prince array to 
                // see if that item belongs to the JacksClass or is the 
                // JacksClass . If it is, it'll print out the text inside this
                // condition, if is's not the complier will move to the next
                // statement until it reaches the end of the foreach looop
                if (Knight is JacksClass)
                {
                    Console.WriteLine("Jack class is here");
                }

                // the rest of the else if statements works similar to the 
                // first if statement, seeing if the item inside the Prince
                // array is part of the QueensClass or not. It'll print the 
                // text inside this condition or move on to the next statement
                else if (Knight is QueensClass)
                {
                    Console.WriteLine("Queen class present and ready to begin");
                }

                // again this checks if the item in the Prince array is part
                // of the KingsClass or not. It'll print the text inside of
                // the condition if it is or move on the beginning of the 
                // foreach loop until it reaches the end of the array
                else if (Knight is KingsClass)
                {
                    Console.WriteLine("Since everyone's here let say hi");
                }
                Console.WriteLine();

                // seventh bullet
                // we use the for loop to iterate the Prince array, creating
                // an object card that acts as the index with a value of 
                // zero. This loop will call the KingsMethod() method from 
                // each class inside Prince until the condition (which is as
                // long as card is less than the length of the array Prince, 
                // run the loop) is no longer true.
                for (int card = 0; card < Prince.Length; card++)
                {
                    Prince[card].KingsMethod();
                }
                Console.WriteLine();
            }

            // eighth bullet
            // this foreach loop runs similar to the foreach loop from above.
            // Every idem inside the Prince array will call the RoyalSeal() 
            // method until the loop reaches the last item in the array
            foreach (KingsClass Knight in Prince)
            {
                Knight.RoyalSeal();
            }
            Console.WriteLine();

            // ninth bullet
            //this foreach loop iterate the items inside the Prince array
            // which are refer to Guard.
            foreach (KingsClass Guard in Prince)
            {
                // we use the switch statement to test the Guard object
                // which acts as the index of Prince. It'll go through each
                // case below until the condition of one of these cases is
                // true or it'll go to the next case until it reaches the 
                // default case. If the condition is true, it'll run the code 
                // below the case condition otherwise it'll go to the next 
                // case. These cases will test to see if the item inside 
                // Prince matches one of the classes described on each case
                // until it reaches the end of the Prince array.
                switch (Guard)
                {
                    case JacksClass Jack:
                        Console.WriteLine("Let play some blackjack");
                        break;

                    case QueensClass Queen:
                        Console.WriteLine("Safe guard the queen");
                        break;

                    case KingsClass King:
                        Console.WriteLine("The king of all cards");
                        break;

                    default:
                        Console.WriteLine("The princess is in another castle");
                        break;

                }
                
            }

            // tenth bullet
            Console.WriteLine();

            // for this line of code we created a new object using the object
            // keyword name it deck which we turned it into a new KingsClass.
            // We use casting to have the deck object to call KingsMethod()
            // method from the KingsClass class to showcase that you can use
            // casting to call a method from the same class
            object deck = new KingsClass();

            ((KingsClass)deck).KingsMethod();

            Console.WriteLine();

            // eleventh bullet

            // we create a new object CardGame using the KingsClass keyword 
            // but created a new object from the JacksClass so an object
            // from the JacksClass class. We initialize a class from a base
            // class to a child class
            KingsClass CardGame = new JacksClass();

            // the following code demonstrates that you can have a object
            // from a different class call a method from another class by 
            // using casting so a object from a base class can call a method
            // from a child class to show that a object from a base class
            // can call a method from a child class that is special to that 
            // class.
            ((JacksClass)CardGame).SecretKnight();
        }
    }
}
