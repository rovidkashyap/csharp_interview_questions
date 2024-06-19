using System;

namespace abstraction_and_encapsulation
{
    // Abstraction and encapsulation are two fundamental concepts in object-oriented programming (OOP) that often get confused. 
    // Abstraction is the concept of hiding the complex implementation details and showing only the essential features of an object.
    // It focuses on what an object does rather than how it does it. This is usually achieved using abstract classes and interfaces.

    // Encapsulation is the concept of bundling the data (variables) and methods that operate on the data into a single unit,
    // known as a class, and restricting the access to some of the object's components. 
    // This is usually achieved using access specifiers (private, public, protected).

    #region ABSTRACTION EXAMPLES
    // Abstract class
    public abstract class Shape
    {
        // Abstract method (does not have a body)
        public abstract double GetArea();
        public abstract double GetPerimeter();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("Displaying the shape.");
        }
    }
    // Derived class (inherits from Shape)
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementing the abstract methods
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
    #endregion

    #region ENCAPSULATION EXAMPLES
    public class BankAccount
    {
        // Private fields
        private double balance;
        private string accountNumber;

        // Constructor
        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            balance = initialBalance;
        }

        // Public method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        // Public method to withdraw money
        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        // Public method to get the current balance
        public double GetBalance()
        {
            return balance;
        }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------- ABSTRACTION ----------------");
            Shape circle = new Circle(5.0);
            Console.WriteLine("Area: " + circle.GetArea());
            Console.WriteLine("Perimeter: " + circle.GetPerimeter());
            circle.Display();

            Console.WriteLine("\n------------------- ENCAPSULATION ------------------");
            BankAccount account = new BankAccount("12345", 1000.0);
            account.Deposit(500.0);
            Console.WriteLine("Balance after deposit: " + account.GetBalance());

            if(account.Withdraw(200.0))
            {
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Withdrawal failed.");
            }

            Console.WriteLine("Final balance: " + account.GetBalance());
        }
    }
}
