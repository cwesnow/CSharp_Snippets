using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Snippets
{
    class OOP
    {
        public static void play()
        {    
            Console.Clear();
            Console.WriteLine("OOP Design Principals");

            // Default Values Example
            Person owner = new Person();

            Person friend = new Person("Jimmy", "Pizza");
            Dog pet1 = new Dog("Dog","Dog Food");
            Cat pet2 = new Cat("Cat","Cat Food");

            // Abstract Class made sure every object had a Name and a Diet property
            // Interface made sure every class uses same Method()

            // Test: owner Object has null or empty values
            Console.WriteLine(
                owner.speak()
                );

            // Test: owner Object has a Name
            owner.changeName("Owner");
            Console.WriteLine(
                 owner.speak()
                );

            // Test: owner Object has a Diet
            owner.changeDiet("CheeseBurgers");
            Console.WriteLine(
                owner.speak()
                );
            

            Console.WriteLine(
                friend.speak()
            );

            Console.WriteLine(
                pet1.myNameDiet() +
                " I say " +
                pet1.speak()
                );

            Console.WriteLine(
                pet2.myNameDiet() +
                " I say " +
                pet2.speak()
                );
            
            Console.ReadKey();
        }
    }
}
