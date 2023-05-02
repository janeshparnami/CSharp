namespace AbstractClass_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dog dog = new Dog();
            Animal animal = new Dog();
            dog.Name = name;
            Console.WriteLine(dog.Name);
            animal.Name = name + "animal";
            Console.WriteLine(animal.Name);

            dog.Eat();
            animal.Eat();
        }
    }
}