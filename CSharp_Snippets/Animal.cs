namespace CSharp_Snippets
{
    abstract class Animal
    {
        public string name { get; private set; }
        public string diet { get; private set; }

        public Animal() {
            
        }

        public Animal(string s, string d)
        {
            name = s;
            diet = d;
        }

        public void changeName(string s)
        {
            name = s;
        }

        public void changeDiet(string d)
        {
            diet = d;
        }

        public virtual string myNameDiet()
        {
            return string.Format("My name is {0} and I eat {1}.", this.name, this.diet);
        }
    }
}