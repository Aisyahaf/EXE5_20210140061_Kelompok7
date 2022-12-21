using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_20210140061_Kelompok7
{
   class Node
   {
        public char info;
        public Node next;
        public Node(char i, Node n)
        {
            info = i;
            next = n;
        }
   }

    class Queues
    {
        Node AISAH;
        Node FITRI;

        public Queues()
        {
            AISAH = null;
            FITRI = null;
        }

        public void insert(char element)
        {
            Node el;
            el = new Node(element, null);

            if (AISAH == null)
            {
                AISAH = el;
            }
            else
            {
                FITRI.next = el;
            }
            FITRI = el;
        }

        public int remove()
        {
            Node tmp;
            Console.WriteLine("\nThe element deleted from the queue is: " + AISAH + "\n");

            tmp = AISAH;
            AISAH = AISAH.next;

            if (AISAH == null)
            {
                FITRI = null;
            }
            return tmp.info;
        }

        public void display()
        {
            Node Ai;
            Ai = AISAH;

            if ((Ai == null) && (FITRI == null))
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.WriteLine("\nElements in the queue are....\n");

            while (Ai != FITRI)
            {
                Console.WriteLine(Ai.info);
                Ai = Ai.next;
            }
            if (Ai == FITRI)
            {
                Console.WriteLine(Ai.info);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;

            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement Insert Operation");
                    Console.WriteLine("2. Implement Delete Operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice ( 1-4 ): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.WriteLine("Enter a character : ");
                                char c = Convert.ToChar(Console.ReadLine());
                                q.insert(c);
                            }
                            break;
                        case '2':
                            {
                                q.remove();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4';
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid Option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }


    }
}
 