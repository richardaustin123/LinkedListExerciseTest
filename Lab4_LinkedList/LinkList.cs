using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_LinkedList
{
    class LinkList
    {
        private Link list = null; //default value – empty list
        private int head = 0;

        public void AddItem(int item) //add item to front of list
        {
            list = new Link(item, list);
        }

        public string DisplayItems() //write items to string and return
        {
            Link temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                buffer += temp.Data + ", ";
                temp = temp.Next;
            }
            return buffer;
        }

        public int Count() // returns number of items in list
        {
            int count = 0;
            Link temp = list;

            while(temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }

        public void AppendItem(int item)
        {
            Link temp = list;

            if(temp == null)
                list = new Link(item);
             else
            {
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new Link(item);
            }
        }

        public void RemoveItem(int item)
        {
            Link temp = list;
            LinkList newList = new LinkList();

            if (temp == null)
                Console.WriteLine("empty");
            else
            {
                while(temp.Next != null)
                {
                    if(item.CompareTo(temp.Data) != 0)
                    {
                        newList.AppendItem(temp.Data);
                    } 
                    else
                    {
                       temp = temp.Next;
                    }
                }
                list = newList.list;
            }
        }

        public bool isPresentItem(int item)
        {
            Link temp = list;
            while (temp != null)
            {
                if (item.CompareTo(temp.Data) == 0)
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        /*public int sortItems(int item)
        {
            Link temp = list;
            while(temp != null)
            {
                if(item.CompareTo()
            }
            return list;
        }*/
    }
}
