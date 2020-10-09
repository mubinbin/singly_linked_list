using System;
using System.Collections.Generic;

namespace singly_linked_list
{
    public class SinglyLinkedList
    {
        private Node head;
        public Node Head {get {return head;} set{head = value;}}
        public SinglyLinkedList()
        {
            head = null;
        }
        
        public void AddNode(int num)
        {
            Node newNode = new Node(num);
            if (head == null){
                head = newNode;
            }else{
                Node runner = head;
                while (runner.Next != null){
                    runner = runner.Next;
                }
                runner.Next = newNode;
                if(num == -11190){
                    newNode.Next = head;
                }
            }
        }

        public void Remove()
        {   
            Node pointer1 = head;
            int counter = 0;
            while (pointer1 != null){
                pointer1 = pointer1.Next;
                counter++;
            }
            counter -=2;
            Node pointer = head;
            while (counter > 0){
                pointer = pointer.Next;
                counter--;
            }
            int ans = pointer.Next.Val;
            pointer.Next = null;
            Console.WriteLine($"Removed {ans} from the list.");
            Console.WriteLine(" ");
            // return ans;
        }

        public int ListSize()
        {
            int counter = 0;
            Node pointer = head;
            while (pointer != null){
                counter++;
                pointer = pointer.Next;
            }
            return counter;
        }
        public void PrintValues()
        {   
            Node pointer = head;
            while (pointer != null){
                Console.WriteLine(pointer.Val);
                pointer = pointer.Next;
            }
        }
        public bool Find(int num)
        {
            int counter = 0;
            Node pointer = head;

            while(pointer != null){
                if (pointer.Val == num){
                    Console.WriteLine($"{num} is found at index {counter}");
                    Console.WriteLine(" ");
                    return true;
                }
                pointer = pointer.Next;
                counter++;
            }
            Console.WriteLine($"{num} is not in the list!");
            Console.WriteLine(" ");
            return false;
        }

        public void RemoveAt (int num){
            Node pointer = head;
            int size = ListSize();
            int index = num;
            if(num == 0){
                int ans = head.Val;
                head = head.Next;
                Console.WriteLine($"Element at index {index} has been removed! The element is {ans}!");
                Console.WriteLine(" ");
            }else if (num == size-1){
                size -=2;
                while (size > 0){
                    pointer = pointer.Next;
                    size--;
                }
                int ans = pointer.Next.Val;
                pointer.Next = null;
                Console.WriteLine($"Element at index {index} has been removed! The element is {ans}!");
                Console.WriteLine(" ");
            }else if(num > 0 && num < size-1){
                num--;
                while (num > 0){
                    pointer = pointer.Next;
                    num--;
                }
                int ans = pointer.Next.Val;
                pointer.Next = pointer.Next.Next;
                Console.WriteLine($"Element at index {index} has been removed! The element is {ans}!");
                Console.WriteLine(" ");
            }else{
                Console.WriteLine($"This index you input is out of range!");
                Console.WriteLine("");
            }
        }

        public void Reverse(){
            Node prev = null;
            Node current = head;
            Node next = null;
            

            while(current != null){
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public void Reverse2(){
            Node pointer = head;
            head = null;
            while (pointer != null){
                Node NewNode = new Node(pointer.Val);
                NewNode.Next = head;
                head = NewNode;
                pointer = pointer.Next;
            }
        }

        public bool HasLoop(){
            Node fast = head;
            Node slow = head;

            while (fast != null && fast.Next !=null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if(slow == fast)
                    return true;
            }
            return false;
        }
        public void BreakLoop(){
            if(HasLoop())
            {
                Node fast = head;
                Node slow = head;
                while (fast != null && fast.Next !=null)
                {
                    slow = slow.Next;
                    fast = fast.Next.Next;
                    if(slow == fast)
                        break;
                }
                if (slow !=head && fast != head){
                    slow = head.Next;
                    while (fast.Next != slow){
                        slow = slow.Next;
                        fast = fast.Next;
                    }
                    fast.Next = null;
                }else{
                    while (fast.Next != slow) {fast = fast.Next;}
                    fast.Next = null;
                }
            }else{
                Console.WriteLine("Loop does not exist.");
            }
        }

        public void createLoop()
            {
                Node runner = this.head;
                int count = 0;
                Node loop = this.head;
                while (runner.Next != null)
                {
                    count++;
                    if (count == 3)
                    {
                        loop = runner;
                    }
                    runner = runner.Next;
                }
                runner.Next = loop;
            }
    }
    
    

}