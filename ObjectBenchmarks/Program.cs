using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedTest
{
    internal class TestModel
    {
        public string PropOne { get; set; }
        public string PropTwo { get; set; }

        public string PropThree { get; set; }

        public string PropFour { get; set; }
        public string PropFive { get; set; }
    }
    class Program
    {
        private const int ITERATIONS = 100000000;


        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            CreateObject(stopwatch);

            CreateDynamic(stopwatch);
            CreateObject(stopwatch);

            CreateDynamic(stopwatch);

            CreateObject(stopwatch);

            CreateDynamic(stopwatch);
            CreateObject(stopwatch);

            CreateDynamic(stopwatch);
            CreateObject(stopwatch);

            CreateDynamic(stopwatch);

            CreateObject(stopwatch);

            CreateDynamic(stopwatch);
            CreateObject(stopwatch);

            CreateDynamic(stopwatch);
            CreateObject(stopwatch);

            CreateDynamic(stopwatch);

            CreateObject(stopwatch);

            CreateDynamic(stopwatch);


            Console.ReadKey();

        }

        private static void CreateObject(Stopwatch stopwatch)
        {
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < ITERATIONS; i++)
            {
                var m = new TestModel() {PropOne="a test", PropTwo = "another test", PropThree = "a third test", PropFour = "a fourth test", PropFive = "a five test"};
            }
            stopwatch.Stop();

            Console.WriteLine(string.Format("Static Object Created Elapsed {0}", stopwatch.ElapsedMilliseconds));
        }

        private static void CreateDynamic(Stopwatch stopwatch)
        {
            var sum = 0;
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < ITERATIONS; i++)
            {
                var m = new  { PropOne = "a test", PropTwo = "another test", PropThree = "a third test", PropFour = "a fourth test", PropFive = "a five test" };
            }
            stopwatch.Stop();

            Console.WriteLine(string.Format("Dynamic Object Created Elapsed {0}", stopwatch.ElapsedMilliseconds));
        }
        
    }
}
