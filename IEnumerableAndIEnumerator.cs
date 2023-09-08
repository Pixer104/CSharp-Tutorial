/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class IEnumerableAndIEnumerator
    {
        
        public IEnumerable<int> GetCollection(int option)
        {

            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> numberQueue = new Queue<int>();
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(11);
            numberQueue.Enqueue(13);
            numberQueue.Enqueue(15);
            numberQueue.Enqueue(17);

            if(option == 1)
            {
                return numbersList;
            }
            else if(option ==2)
            {
                return numberQueue;
            }
            else
            {
                return new int[] { 2, 4, 6, 8, 10, 12};
            }


          }        

    }

    public class Display
    {
        public void Print()
        {
            IEnumerable<int> customCollection;
            customCollection = GetCollection();
        }

        
    }

    
}
*/