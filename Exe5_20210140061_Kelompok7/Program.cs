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

        public void remove()
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


    }
}
 