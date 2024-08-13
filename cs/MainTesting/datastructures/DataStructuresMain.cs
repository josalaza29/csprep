using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTesting.datastructures
{
    internal class DataStructuresMain
    {
        static void Mainx(string[] args)
        {
            //Console.WriteLine("Hello");
        CSStack stack = new CSStack(7);
        stack.push(15);
        stack.print();
        stack.push(6);
        stack.push(2);
        stack.push(9);
        stack.print();
        stack.pop();
        stack.print();
//        JQueueGeneric que = new JQueueStatic(7);
            //        que.in(15);
            //        que.in(6);
            //        que.in(4);
            //        que.in(3);
            //        que.in(8);
            //        que.in(9);
            //        que.in(10);
            //        que.print();
            //        que.out();
            //        que.print();
            //        que.out();
            //        que.print();
            //        que.in(1);
            //        que.out();
            //        que.print();
            //        JLinkedList list = new JLinkedList();
            //        list.lInsert(5);
            //        list.print();
            //        list.lInsert(15);
            //        list.print();
            //        list.lInsert(25);
            //        list.print();
            //        list.lInsert(45);
            //        list.print();
            //        list.lDelete(25);
            //        list.print();
            //        list.lInsert(25);
            //        list.print();
        }
    }
}
