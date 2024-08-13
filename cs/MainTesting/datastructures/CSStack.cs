using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTesting.datastructures
{
    internal class CSStack
    {
        private int track;
        private int[] structure;
        public CSStack() {
            this.track = 0;
            this.structure = new int[1];
        }
        public CSStack(int capacity) {
            this.track = 0;
            this.structure = new int[capacity];
        }

        public bool push(int value)
        {
            if (this.track < this.structure.Length)
            {
                this.structure[this.track++] = value;
                return true;
            }
            return false;
        }

        public int pop()
        {
            if (this.track >= 0)
            {
                int returnValue = this.structure[this.track];
                this.structure[--this.track] = 0;
            }
            return -1;
        }

        public void print()
        {
            Console.WriteLine("At index: " + this.track + " with capacity: " + this.structure.Length);
            string result = "";
            foreach (int i in this.structure)
            {
                result += i.ToString() + ", ";
            }
            Console.WriteLine("[" + result + "]");
        }

    }
}
