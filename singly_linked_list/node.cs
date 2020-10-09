using System;

namespace singly_linked_list
{

    public class Node{
        private int val;
        private Node next;
        public int Val{ get{return val;}}
        public Node Next{get{return next;} set{next = value;}}

        public Node(int num)
        {
            val = num;
            next = null;
        }
    }

}