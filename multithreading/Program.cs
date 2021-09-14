using System;
using System.Threading.Tasks;

namespace multithreading
{
    internal static class Program
    {
        public static void Write(char c)
        {
            int i = 1000;
            while(i --> 0)
            {
                Console.Write(c);
            }
        }

        public static void Write(object o)
        {
            int i = 1000;
            while (i --> 0)
            {
                Console.Write(o);
            }
        }

        public static int TextLength(object o)
        {
            Console.WriteLine($"\nTask with id {Task.CurrentId} processing object {o}...");
            return o.ToString().Length;
        }

        public static void Main()
        {
            //Task t = new Task(Write, "hello");
            //Task.Factory.StartNew(() => Write('J'));
            //var t = new Task(() => Write('K'));
            //t.Start();
            //Task.Factory.StartNew(Write, 123);

            //Write('L');
            string text1 = "ju137", text2 = "whatthashit";
            var task1 = new Task<int>(TextLength, text1);
            task1.Start();
            Task.Factory.StartNew<int>(TextLength, text2);

            Console.WriteLine($"\nthe length of '{text1}' is {task1.Result}");
            Console.WriteLine($"\nthe length of '{text2}' is {task1.Result}");
            Console.WriteLine("Done");
        }
    }
}
