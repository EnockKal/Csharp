namespace Access_Modifier
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person()
        {

        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public int GetAge()
        {
            return this._age;
        }

        public void SetAge(int age)
        {
            this._age = age;
        }
    }
}
