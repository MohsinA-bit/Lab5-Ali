using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Program
    {
       
        public string name { get; set; }
        public void bark()
        {
            Console.WriteLine(name + "is barking...");
        }
        public void doTrick(string trickname)
        {
            Console.WriteLine("{0} is so smart! {0} is doing a {1}", Name, trickname);
            {
                static void Main(string[] args)
                {
                    Dog myDog = new Dog();
                    myDog.Name = "snake";

                    myDog.bark();
                    myDog.doTrick("Fetch");


                }
                    


            }
        }
    }
}

//Question1. a. The scope is located in “Public” it shows where the method is called from
// b.Static methods can be called without the need for creating another object in the class, the above example is a non-static method
// c. A return type defines and constrains the data type of the value returned from a subroutine or method
// d. The method name in the above example is “getArea”
// e. The perimeter is inside the () which the computer uses to retrieve data from the method
// f. A method body is just a set of instructions in the above example it would be the “ height and the with”. 

//Question 2.framework is a re-usable design for a software system, so a framework method is a preexisting method designed for a piece of software,
//while a user defined method is a method created by the user. We should consider what kind of software we are creating the method for.

// Question 3. The difference between a Static and non-static method is with a non-static method you must create an object for which class you want to call, 
//with a static method you can create a method with out creating an object.












