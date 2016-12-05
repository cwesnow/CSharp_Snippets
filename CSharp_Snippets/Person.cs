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
                message = "I don't let just anybody know my real name.";
            }
            else
            {
                message = "Greetings, you can call me " + this.name + ".";
            }

            if (this.diet != null && diet.Length > 0)
            {
                message += " I love " + this.diet + ".";
            }

            return message;
        }
    }
}