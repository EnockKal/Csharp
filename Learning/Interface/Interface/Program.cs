namespace Interface;

internal class Program
{
    static void Main(string[] args)
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();

        dog.speak();
        cat.speak();
    }
}
