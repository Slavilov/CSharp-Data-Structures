using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Implementing_a_Stack_Using_a_List
{
    internal class Stack
    {
        public Stack()
        {
            List = new List<string>();
        }
        private List<string> list;

		public List<string> List
		{
			get { return list; }
			set { list = value; }
		}

        public void Push(string item)
        {
            list.Add(item);
        }

        public string Pop()
        {
            int count = list.Count;
            if (count >0) 
            {
                string poppedElement = list[count - 1];
                list.RemoveAt(count-1);
                return poppedElement;
            }
            else
            {
                throw InvalidOperationException();
            }
        }

        public string Peek()
        {
            int count = list.Count;

            if (count > 0)
            {
                string peekedElement = list[count - 1];
                return peekedElement;
            }
            else
            {
                throw InvalidOperationException();
            }

        }

        private Exception InvalidOperationException()
        {
            throw new NotImplementedException();
        }

	}
}
