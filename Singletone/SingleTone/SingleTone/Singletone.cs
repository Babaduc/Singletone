using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleTone
{
    class Singletone
    {
        private static Singletone Instance;
        public static Singletone GetInstance()
    {
        if (Instance == null)
        {
            Instance = new Singletone();
        }
        return Instance;
    }
        private Singletone()
        {
            Console.WriteLine("Nice to meet you!");
        }
    }
}
