namespace CSharp_Snippets
{
    class Person : Animal, Ispeak
    {
        public Person()
        {

        }

        public Person(string name, string diet)
            : base(name, diet)
        {

        }

        public string speak()
        {
            string message;

            if (this.name == null || name.Length == 0) {
                message = "I don't have a name yet.";
            }
            else
            {
                message = "Greetings, my name is " + this.name + ".";
            }

            if (this.diet == null || diet.Length == 0)
            {
                message += " I don't know what I like yet.";
            } else
            {
                message += " I like to eat " + this.diet + ".";
            }

            return message;
        }
    }
}