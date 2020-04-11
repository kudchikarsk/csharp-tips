using System;
using static System.Console;
using System.Diagnostics;

namespace csharp_data_types_and_object_tips
{
    class Program6
    {
        struct StructNoRef
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        struct StructWithRef
        {
            public int X { get; set; }
            public int Y { get; set; }
            public string Description { get; set; }

            public override bool Equals(object obj)
            {
                if (!(obj is StructWithRef))
                    return false;

                var other = (StructWithRef)obj;

                return X == other.X &&
                       Y == other.Y &&
                       Description == other.Description;
            }
        }


        public static void Run(string[] args)
        {
            var stopwatch = new Stopwatch();
            var data1 = new StructNoRef();
            var data2 = new StructNoRef();
            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                data1.Equals(data2);
            }
            stopwatch.Stop();
            WriteLine("StructNoRef Comparison: "+stopwatch.ElapsedMilliseconds + " Milliseconds");

            stopwatch.Reset();
            var data3 = new StructWithRef();
            var data4 = new StructWithRef();
            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                data3.Equals(data4);
            }
            stopwatch.Stop();
            WriteLine("StructWithRef Comparison: " + stopwatch.ElapsedMilliseconds + " Milliseconds");
        }
    }
}
