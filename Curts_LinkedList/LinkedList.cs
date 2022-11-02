using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_LinkedList
{
    internal class LinkedList
    {
        Node head;

        public LinkedList()
        {
            head = null;
        }

        public void Add(string data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void Remove()
        {

        }

        public void Contains()
        {

        }
    }

}
