using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public class MyList<T>
    {
        public int counter { get; set; }

        class Node<T>
        {
            public T info;
            public Node<T> next;
        }

        private Node<T> root, leaf;

        public MyList()
        {
            root = null;
            leaf = null;
        }

        public bool IsEmpty()
        {
            if (root == null)
            {
                return true;
            }
            else
            {
                return false;
            }              
        }

        public void Insert(T info)
        {
            Node<T> newNode = new Node<T>();
            newNode.info = info;
            newNode.next = null;
            if (IsEmpty())
            {
                root = newNode;
                leaf = newNode;
            }
            else
            {
                leaf.next = newNode;
                leaf = newNode;
            }

            counter++;
        }

        public T Extraer()
        {
            if (!IsEmpty())
            {
                T informacion = root.info;
                if (root == leaf)
                {
                    root = null;
                    leaf = null;
                }
                else
                {
                    root = root.next;
                }

                counter--;

                return informacion;
            }
            else
                return default(T);
        }
    }
}
