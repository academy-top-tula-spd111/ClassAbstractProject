namespace ClassAbstractProject
{
    class Person<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }

        public void Method(T variable)
        {

        }
    }

    class User<T> : Person<T>
    {

    }


    abstract class Animal
    {
        public abstract string Voice();

        public void Method()
        {
            Console.WriteLine("Non abstract");
        }
    }

    class Cat : Animal
    {
        public override string Voice()
        {
            return "Myau";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Method();

            Animal animal = new Cat();
             

            Person<int> person = new Person<int>();
            Person<string> person2 = new Person<string>();
        }
    }
}