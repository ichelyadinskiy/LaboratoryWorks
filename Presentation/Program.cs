using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;
using Lab_3;
using Lab_4;
using Lab_5;

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

            //var high = new CustomQueue<string>(1);
            //high.Enqueue("first");
            //high.Enqueue("second");
            //high.Enqueue("third");
            //Console.WriteLine("First queue: " + high);

            //var low = new CustomQueue<string>(3);
            //low.Enqueue("seventh");
            //low.Enqueue("eighth");
            //low.Enqueue("ninth");
            //Console.WriteLine("Second queue: " + low);

            //var med = new CustomQueue<string>(2);
            //med.Enqueue("fourth");
            //med.Enqueue("fifth");
            //med.Enqueue("sixth");
            //Console.WriteLine("Third queue: " + med);

            //var queue = new MainQueue<string>(high, low, med);
            //queue.CreateQueue();
            //Console.WriteLine(Environment.NewLine);
            //Console.WriteLine("Result: " + queue);

            #endregion

            #region Lab4

            //var postfix = new Postfix("3+6");
            //Console.WriteLine("Normal: " + postfix.Expression);
            //Console.WriteLine("Postfix: " + postfix.CreatePostfix());
            //Console.WriteLine("Answer: " + postfix.GetResult());
            //Console.WriteLine();

            //var prefix = new Prefix("9+2");
            //Console.WriteLine("Normal: " + prefix.Expression);
            //Console.WriteLine("Prefix: " + prefix.CreatePrefix());
            //Console.WriteLine("Answer: " + prefix.GetResult());

            #endregion

            #region Lab5

            BinaryTree<int> integerTree = new BinaryTree<int>();

            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                int value = rand.Next(100);
                Console.WriteLine("Adding {0}", value);
                integerTree.Add(value);
            }

            Console.WriteLine("Number of nodes is {0}", integerTree.Count);
            Console.WriteLine("Max value is {0}", integerTree.MaxValue);
            Console.WriteLine("Min value is {0}", integerTree.MinValue);
            Console.WriteLine("Preorder traversal:");
            Console.WriteLine(string.Join(" ", integerTree.Preorder()));
            Console.WriteLine("Inorder traversal:");
            Console.WriteLine(string.Join(" ", integerTree.Inorder()));
            Console.WriteLine("Postorder traversal:");
            Console.WriteLine(string.Join(" ", integerTree.Postorder()));
            Console.WriteLine("Levelorder traversal:");
            Console.WriteLine(string.Join(" ", integerTree.Levelorder()));
            Console.WriteLine("Default traversal (inorder):");
            foreach (int n in integerTree)
                Console.Write("{0} ", n);
            Console.WriteLine();
            Console.ReadKey(true);

            #endregion
        }
    }
}
