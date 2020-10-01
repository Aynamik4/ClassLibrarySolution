using System;
using MyClassLibrary;

namespace MyGame
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                bool x = Utils.ProbabilityTrue(10);
            }
        }
    }
}
