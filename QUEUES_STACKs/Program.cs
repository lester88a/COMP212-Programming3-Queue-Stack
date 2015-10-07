using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUES_STACKs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Queues & Stacks
             * In general, both represents non-generic collection,
             * Stack, however, has a generic countrpart
             * 
             */
             
             /*
             * Counter
             * Remove > [1]
             *          [2]
             *          [3]
             *          [4]
             *  Add  >  [ ] Addition
             *
             * First in, First OUt [FIFO]
             * 
             * 
             * Methods/Function:[non-static]
             * Enqueue: add an item in the queue
             * Dequeue: removes and add oldest one
             * Contains: Check if an entry is there
             * Peek: gets the reference of the oldest one
             */
               
            //Create the object first
            Queue days = new Queue();
            days.Enqueue("Sunday"); //string
            //MessageBox.show(days.Dequeue).toString();
            days.Enqueue(55);//int


            //Stack > Last In, First out > LIFO
            /*
             * Stacks: function/method
             * Push: adds item to the stack
             * Pop: returns the last item from the stack
             * Peek: Brings the reference of the last one
             * contains: check the object is contained in the stack
             */

            Stack das = new Stack();
            das.Push("Sunday");
            das.Push(105);

            //Generic stack
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(1000);
            //stack.Push("li xu"); >will not work


            //LinkedList
            //adding a node in between
            //[1] > [2] >[n]> [3] > [4]
            //delete a node in anywhere in between
            //[1] > [2] >{[3] >} [4]

            //AddLast&AddFirst
            LinkedList<string> linked = new LinkedList<string>();
            linked.AddLast("Cat");
            linked.AddLast("Dog");
            linked.AddLast("Man"); // cat > dog > man
            linked.AddFirst("Bird"); //bird > cat > dog > man

           
            
            //AddAfter&AddBefore
            //AddAfter(NodeObeject, InsertedObject)
            LinkedListNode<string> node = linked.Find("Cat");
            linked.AddAfter(node,"Monkey"); //bird>cat>monkey>dog>man
             

            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }

        }
    }
}
