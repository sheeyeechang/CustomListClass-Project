using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T> : IEnumerable
    {
        //Member variable  ------------------------------------------------------------------------------------------
        //Array
        private T[] itemArray = new T[5];

        private int count;
        // read-only Count property: --- read-only = get 
        public int Count { get { return count; } }

        private int capacity;
        // Capacity property: publicly see the size of my private array. ---write = set
        public int Capacity { get { return capacity; } set { count = value; } }
        //Constructor  ------------------------------------------------------------------------------------------------
        public CustomList()
        {
            count = 0;
            capacity = 5;

            itemArray = new T[capacity];
        }
        // C# indexer so that I can make the objects in my list accessible via index. A user cannot access an out-of-bounds index.
        public T this[int i]            // It is identifiable as an indexer by the use of "this". 
        {
            get
            {
                return itemArray[i];
            }
            set 
            {
                if (count >= i && i >= 0)       // count greater than i and i greater than 0
                {
                    itemArray[i] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("i must be less than count and greater than 0.");
                }
            }
        }
        // Member method  --------------------------------------------------------------------------------------------
        //Add method: adds an input value to an array. // method ability to add an object  ---------------------------
        public void Add(T item)
        {
            if (count == capacity)  //this happen if over capacity
            {
                capacity *= 2;  //add double to capacity // increase capacity, make new bigger array
                T[] item2Array = new T[capacity];  //create new array
                for (int i = 0; i < count; i++)
                {
                    item2Array[i] = itemArray[i];  //new array copy old array
                }
                item2Array[count] = item;  //new array count add the new value
                itemArray = item2Array;  // fill up array, reassign to member variable array
                count++;
            }
            else
            {
                itemArray[count] = item;
                count++;
            }
        }
        //Remove method: remove an input value from an array. // method ability to remove an object  ---------------------
        public void Remove(T item)
        {
            int j = 0;                      //set new variable
            int tempCount = 0;               //set temp count = 0 or tempCOunt = count   

            T[] item2Array = new T[capacity];  //create new array
            for (int i = 0; i < count; i++)     
            {
                if (!item.Equals(itemArray[i])) // if item not equal, do add item
                {
                    item2Array[j] = itemArray[i];
                    j++;         
                }
                else
                {
                    tempCount++;
                }
            }
            itemArray = item2Array;         //reassign to member variable ar      
            count -= tempCount;         // count = count - tempCount
        }
        // override the ToString method that converts the contents of the custom list to a string.  -----------------------------
        public override string ToString()
        {
            string itemString = "";
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    itemString += $"{itemArray[i]}";                    
                }
                else
                {
                    itemString += ($", {itemArray[i]}");
                }
            }
            return itemString;
        }
        // overload the + operator  -----------------------------------------------------------------------------------
        public static CustomList<T> operator + (CustomList<T> testList1, CustomList<T> testList2)
        {
            CustomList<T> testListResult = new CustomList<T>();     //create new list or object
            for (int i = 0; i < testList1.count; i++)
            {
                testListResult.Add(testList1.itemArray[i]);      // add list 1
            }
            for (int j = 0; j < testList2.count; j++)
            {
                testListResult.Add(testList2.itemArray[j]);      // add list 2
            }
            return testListResult;
        }
        // Overload + operator to add two Box objects.
        //public static Box operator +(Box b, Box c)
        //{
        //    Box box = new Box();
        //    box.length = b.length + c.length;
        //    box.breadth = b.breadth + c.breadth;
        //    box.height = b.height + c.height;
        //    return box;
        //}

        // overload the – operator  ------------------------------------------------------------------------------------------
        public static CustomList<T> operator -(CustomList<T> testList1, CustomList<T> testList2)
        {
            CustomList<T> testListResult = new CustomList<T>();     //create new list or object
            for (int i = 0; i < testList1.count; i++)              // for loop for list 1
            {
                for (int j = 0; j < testList2.count; j++)           // for loop for list 2
                {
                    if (testList2.itemArray[j].Equals(testList1.itemArray[i])) // if list 2 item equal list 1 item
                    {
                        testList1.Remove(testList1.itemArray[i]);       // do remove item from List 1
                    }
                }
                testListResult = testList1;      //rename variable
            }
            return testListResult;
        }
        //  Zip two custom  ----------------------------------------------------------------------------------------------------
        public static CustomList<T> Zip (CustomList<T> testListOdd, CustomList<T> testLiistEven)
        {
            CustomList<T> testListResult = new CustomList<T>();     //create new list or object
            for (int i = 0; i < testListOdd.count; i++)              // for loop for list 1
            {
                testListResult.Add(testListOdd[i]);                 // add List 1
                testListResult.Add(testLiistEven[i]);                 // add List 2
            }
            return testListResult;
        }

        //custom list class to be iterable.  ---------------------------------------------------------------------------
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return itemArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
    }

}
