<<<<<<< HEAD
﻿using System;

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
=======
﻿using System;

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
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
