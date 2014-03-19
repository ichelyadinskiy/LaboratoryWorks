using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;
using Lab_3;

namespace Presentation
{
    class Program
    {
        static void Main()
        {
            #region Lab2
            //var ht = new CustomHashtable(5);
            //ht.Add("some", "value");
            //ht.Add("sososo", "val");
            //ht.Add("cook", "pizza");
            //ht.Add("book", "someBook");
            //ht.Add("koko", "petyh");
            //ht.Add("gorilla", "booking machine");
            //ht.Add("kakashka", "prekluchenia");
            //ht.Add("obezyana", "bookva");
            //Console.WriteLine(ht.Find("obezyana"));
            //ht.Delete("some");
            #endregion

            #region Lab3

            var high = new CustomQueue<string>(1);
            high.Enqueue("first");
            high.Enqueue("second");
            high.Enqueue("third");
            Console.WriteLine("First queue: " + high);

            var low = new CustomQueue<string>(3);
            low.Enqueue("seventh");
            low.Enqueue("eighth");
            low.Enqueue("ninth");
            Console.WriteLine("Second queue: " + low);

            var med = new CustomQueue<string>(2);
            med.Enqueue("fourth");
            med.Enqueue("fifth");
            med.Enqueue("sixth");
            Console.WriteLine("Third queue: " + med);

            var queue = new MainQueue<string>(high, low, med);
            queue.CreateQueue();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Result: " + queue);

            #endregion
        }
    }
}
