namespace Students_and_Workers
{
    abstract class Human
    {
        // fields and properties
        private string firstName;
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // base constructor for all Hummans
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}