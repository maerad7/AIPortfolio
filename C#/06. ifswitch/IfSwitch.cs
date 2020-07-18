<<<<<<< HEAD
﻿using System;

namespace IfSwitch
{
    class Program
    {
        static bool verbose = false;
        static bool continueOnError = false;
        static bool logging = false;
        static void Main(string[] args)
        {
            if (args.Length != 1 )
            {
                Console.WriteLine("Usage : MyApp.exe option");
                return;
            }

            string option = args[0];
            
            switch (option.ToLower())
            {
                case "/v":
                case "/verbose":
                    verbose = true;
                    break;

                case "/c":
                    continueOnError = true;
                    break;
                    
                case "/l":
                    logging = true;
                    break;
                
                default:
                    Console.WriteLine("Unkoown argument: {0}", option);
                    break;

            }
        }
    }
}
=======
﻿using System;

namespace IfSwitch
{
    class Program
    {
        static bool verbose = false;
        static bool continueOnError = false;
        static bool logging = false;
        static void Main(string[] args)
        {
            if (args.Length != 1 )
            {
                Console.WriteLine("Usage : MyApp.exe option");
                return;
            }

            string option = args[0];
            
            switch (option.ToLower())
            {
                case "/v":
                case "/verbose":
                    verbose = true;
                    break;

                case "/c":
                    continueOnError = true;
                    break;
                    
                case "/l":
                    logging = true;
                    break;
                
                default:
                    Console.WriteLine("Unkoown argument: {0}", option);
                    break;

            }
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
