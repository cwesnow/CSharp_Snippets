using System;

namespace CSharp_Snippets
{
    class Cat : Animal, Ispeak
    {
        public Cat(string name, string diet)
            : base(name, diet)
        {

        }

        public string speak()
        {
            return "Meow";
        }
    }

}
