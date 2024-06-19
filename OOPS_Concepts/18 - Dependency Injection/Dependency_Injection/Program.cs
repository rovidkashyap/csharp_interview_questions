using System;

namespace Dependency_Injection
{
    // Dependency Injection is a design pattern used to Implement inversion of Control (IoC)
    // Three Types of Dependency Injection
    // 1. Constructor Injection - Dependency are procided through class Constructor.
    // 2. Property Injection - Dependencies are provided through public properties.
    // 3. Method Injection - Dependencies are provided through method parameters.
    
    // Dependency Injection helps to creating loosely coupled, testable and maintainable code.
    // DI containers can automate the process of managing dependencies, especially in larger applications.

    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine Started.");
        }
    }
    public class Car
    {
        private readonly Engine _engine;

        // Constructor Injection
        public Car(Engine engine)
        {
            _engine = engine;
        }
        public void Start()
        {
            _engine.Start();
            Console.WriteLine("Car started.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();   // Create Engine instance outside of Car
            Car car = new Car(engine);      // Inject Engine instance into car
            car.Start();
        }
    }
}
