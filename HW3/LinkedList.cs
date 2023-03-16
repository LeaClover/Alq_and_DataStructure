using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.alg_and_data_str.HW3 {

    public class LinkedList<T> {
        private Node head;
        public Node Head => head;
        

        public class Node {

            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value) {
                Value = value;
            }
        }

        public void AddFirst(T value) {
            Node node = new Node(value);
            if (head != null)
                node.Next = head;
            head = node;
        }

        public void RemoveFirst() {
            if (head != null)
                head = head.Next;
        }

        public void AddLast(T value) {
            Node node = new Node(value);
            if (head == null) {
                head = node;
            }
            else {
                Node last = head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = node;
            }
        }

        public void RemoveLast() {
            if (head == null)
                return;
            Node node = head;
            while (node.Next != null) {
                if (node.Next.Next == null) {
                    node.Next = null;
                    return;
                }
                node = node.Next;
            }
            head = null;
        }

        public void Reverse(LinkedList<T> list) {   

            LinkedList<T>.Node node = list.head;
            LinkedList<T>.Node prev = null;
            while(node != null) {
                LinkedList<T>.Node tmp = node.Next;
                node.Next = prev;
                prev = node;
                list.head = node;
                node = tmp;
            }
        }
    }
}