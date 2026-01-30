using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1-1
            var datelist = new List<DateTime>
            {
                new DateTime(2019,12, 9, 8,15, 0),
                new DateTime(2020, 8, 4,23, 6, 0),
                new DateTime(2010, 4, 5, 8, 1, 0),
                new DateTime(2018,12,12,10,13, 0),
                new DateTime(2016, 3,18,15,35, 0),
                new DateTime(2014, 4, 1,18,46, 0),
            };

            // Q2-2
            Console.WriteLine(datelist.Count);

            // Q2-3
            foreach (var date in datelist)
            {
                Console.WriteLine(date.ToString("yyyy年MM月dd日 HH:mm"));
            }
        }

    }
}
