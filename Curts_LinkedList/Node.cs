﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_LinkedList
{
    internal class Node
    {
        public string Data;
        public Node Next;
        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
}
