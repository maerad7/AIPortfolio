using System;

namespace publicandprotect
{
    public class Mybase
    {
        public string Name { get; set; }
        protected int Age { get; set; }
    }

    public class MyDerived : Mybase
    {
        public void Run()
        {
            Console.WriteLine("나이 {0}", this.Age);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyDerived myDerived = new MyDerived();
            myDerived.Name = "12";
            
            // Error
            // myDerived.Age = 1
            myDerived.Run();
        }
    }
}
