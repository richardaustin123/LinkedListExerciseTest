using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_LinkedList
{
    class Link
    {
        private int data;
        private Link next;

        public Link(int item) //constructor with an item
        {
            //constructors
            data = item; 
            next = null;
        }
        public Link(int item, Link list) //constructor with item and list
        {
            this.data = item;
            this.next = list;
        }

        public int Data //property for data
        {
            set { this.data = value; }
            get { return this.data; }
        }

        public Link Next //property for next
        {
            set { this.next = value; }
            get { return this.next; }
        }
    }
}
