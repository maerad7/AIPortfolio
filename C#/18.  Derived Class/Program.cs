<<<<<<< HEAD
﻿using System;

namespace Derived_Class
{
    public class Animal
    {
        public string Name { get; set;}
        public int Age { get; set;}


    }

    public class Dog : Animal
    {
        public void HowOld()
        {
            Console.WriteLine("나이 : {0}", this.Age);
        }
    }
    public class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("{0}가 날다.", this.Name);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.HowOld();
        }
    }
}
=======
﻿using System;

namespace Derived_Class
{
    public class Animal
    {
        public string Name { get; set;}
        public int Age { get; set;}


    }

    public class Dog : Animal
    {
        public void HowOld()
        {
            Console.WriteLine("나이 : {0}", this.Age);
        }
    }
    public class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("{0}가 날다.", this.Name);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.HowOld();
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
