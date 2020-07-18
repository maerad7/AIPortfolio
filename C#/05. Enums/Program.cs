using System;

namespace Enums
{
    enum City
    {
        Seoul,
        Daejun,
        Busan = 5,
        Jeju = 10
    }
    class Program
    {
        static void Main(string[] args)
        {
            City myCity;

            myCity = City.Seoul;
            int cityValue = (int) myCity;

            if (myCity == City.Seoul)
            {
                Console.WriteLine("Welcome to Seoul");
            }
        }
    }
}
