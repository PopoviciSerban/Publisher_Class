using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher_Class
{
    class Program
    {
        public delegate void iteratie(int x);

        static void Main(string[] args)
        {
            Publisher x = new Publisher();
            SubscriberA a = new SubscriberA();
            SubscriberB b = new SubscriberB();

            x.eveniment += a.ShowMessage;
            x.eveniment += b.ShowMessage;

            x.DeclansareEveniment();

            Console.ReadKey();
        }

        public class Publisher
        {
            public event iteratie eveniment;

            public void DeclansareEveniment()
            {
                for (int i = 1; i <= 100; i++)
                    eveniment.Invoke(i);
            }
        }

        public class SubscriberA
        {
            public void ShowMessage(int x)
            {
                Console.WriteLine("Iteratia {0} a clasei SubscriberA", x);
            }
        }

        public class SubscriberB
        {
            public void ShowMessage(int x)
            {
                Console.WriteLine("Iteratia {0} a clasei SubscriberB", x);
            }
        }
    }
}
