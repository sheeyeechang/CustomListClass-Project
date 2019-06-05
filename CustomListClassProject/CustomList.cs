using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T>
    {
        //Member variable
        //Array
        FirstArray firstArray;

        public int count;

        //Constructor
        public CustomList()
        {
            count = 0;
            Capacity = 4;

            firstArray = new T[Capacity];
        }

        // Member method

        //Get Set Array
        public T this[int i]
        {
            //if ( count >= i >= 0)
            //{

            get
            {
                return firstArray[i];
            }
            set
            {
                firstArray[i] = value;
            }

            //}
        }
    }
}
