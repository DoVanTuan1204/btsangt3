using System;

namespace diemdanh26_4
{
    class Program
    {
        static void Main(string[] args)
        { 

                Cat cat255 = new Cat();
                cat255.eat();
                cat255.makeSound();
                cat255.run();
                Bird bird255 = new Bird();
                bird255.eat();
                bird255.makeSound();
                bird255.fly();
                Console.ReadKey();
            }
        }
        class Animal
        {
            public virtual void eat()
            {
                Console.WriteLine("Thuc an");
            }
            public virtual void makeSound()
            {
                Console.WriteLine("");
            }
        }
        class Cat : Animal
        {
            public void run()
            {
                Console.WriteLine("Meo chay nhanh");

            }
            public override void eat()
            {
                Console.WriteLine("Meo an ca");
            }
            public override void makeSound()
            {
                Console.WriteLine("Meo keu meo meo");
            }
        }
        class Bird : Animal
        {
            public void fly()
            {
                Console.WriteLine("Chim bay cao");

            }
            public override void eat()
            {
                Console.WriteLine("Chim an sau");
            }
            public override void makeSound()
            {
                Console.WriteLine("Chim an con trung");
            }
        }
    }


