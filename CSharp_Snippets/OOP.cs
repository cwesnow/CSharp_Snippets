using System;

namespace CSharp_Snippets
{
    class OOP : Play
    {
        public void Play()
        {
            string NL = Environment.NewLine;

            Console.Clear();
            Console.WriteLine(NL + "OOP Design Principals" + NL);

            // Test: owner Object has a Name
            Console.WriteLine(NL + "Building human . . ." + NL);
            Person person = new Person(getName(), getDiet());

            Console.WriteLine(NL + "Building dog . . ." + NL);
            Dog dog = new Dog(getName(), getDiet());

            Console.WriteLine(NL + "Building cat . . ." + NL);
            Cat cat = new Cat(getName(), getDiet());

            Animal[] objects = new Animal[3];
            objects[0] = person;
            objects[1] = dog;
            objects[2] = cat;

            for (int x = 0; x < objects.Length; x++)
            {
                Console.WriteLine(NL + "Name: " + objects[x].name + "\tDiet: " + objects[x].diet + NL + NL);
            }

            Console.WriteLine(
                "Person says, \"{0}\"" + NL +
                "Dog says,\"{1}\"." + NL +
                "Cat says,\"{2}\"." + NL,
                person.speak(),
                dog.speak(),
                cat.speak()
                );

            Console.ReadKey();
        }

        public string getName()
        {
            Console.WriteLine("What's its name?");
            return Console.ReadLine();
        }

        public string getDiet()
        {
            Console.WriteLine("What's its favorite food?");
            return Console.ReadLine();
        }
    }
}
