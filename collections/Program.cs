using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Insert(1, 60);
            //list.Insert(3, 20);
            //list.RemoveAt(0);
            //list.Remove(30);
            //list.Sort();

            //Console.WriteLine($"index of 60={list.IndexOf(60)}");

            //Console.WriteLine($"capacity of the list is{list.Capacity}");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);

            //}

            //Stack stack=new Stack();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //foreach(int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            Queue que=new Queue();
            que.Enqueue(10);
            que.Enqueue(40);
            que.Enqueue(30);
            que.Enqueue(20);
            que.Contains(10);


            Console.WriteLine(que.Count);
            Console.WriteLine(que.Peek());
            Console.WriteLine(que.Contains(50));
           

            foreach(int i in que)
            {
                Console.WriteLine(i);
            }



            //Hashtable ht = new Hashtable();
            //ht.Add(91, "India");
            //ht.Add(1, "US");
            //ht.Add(63, "Aus");
            //ht.Add(33, "france");
            //ht.Remove(63); 

            //foreach(DictionaryEntry d in ht)
            //{
            //    Console.WriteLine($"{d.Key} {d.Value}");
            //}





        }
    }
}
