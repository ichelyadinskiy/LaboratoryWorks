using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var ht = new CustomHashtable(5);
            ht.Add("some", "value");
            ht.Add("sososo", "val");
            ht.Add("cook", "pizza");
            ht.Add("book", "someBook");
            ht.Add("koko", "petyh");
            ht.Add("gorilla", "booking machine");
            ht.Add("obezyana", "bookva");
            ht.Delete("some");
        }
    }
}
