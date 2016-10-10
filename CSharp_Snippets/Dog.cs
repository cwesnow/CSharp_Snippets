using System;

namespace CSharp_Snippets
{
    class Dog : Animal, Ispeak
    {
        public Dog(string name, string diet)
            : base(name, diet)
        {

        }

        public string speak()
        {
            return "Woof";
        }
    }

}
