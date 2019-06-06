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
        private T[] itemArray = new T[5] ;

        private int count;
        // read-only Count property: --- read-only = get 
        public int Count { get { return count; } }
         
        private int capacity;
        // Capacity property: publicly see the size of my private array. ---write = set
        public int Capacity { get { return capacity; } set { count = value; } }


        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 5;

            itemArray = new T[capacity];
        }

        // C# indexer so that I can make the objects in my list accessible via index. A user cannot access an out-of-bounds index.

            public T this [int i]
        {
            get
            {
                return itemArray[i];
            }
            set
            {
                itemArray[i] = value;
            }
        }

        // Member method
        //ADD TESTS: 6 total 
        //Add method: adds an input value to an array.

        public void Add(T item)
        {
            itemArray[count] = item;
            count++;
            
            // if we run out room (capacity)
            // increase capacity, make new bigger array
            // fill up array, reassign to member variable array
        }

    



        // method ability to add an object 



        // method ability to remove an object





        // override the ToString method that converts the contents of the custom list to a string.

        // be able to overload the + operator, so that I can add two instances of the custom list class together.
        //List<int> one = new List<int>() {1,3,5}; and List<int> two = new List<int>() { 2, 4, 6 };
        //List<int> result = one + two;
        //result has 1,3,5,2,4,6

        //, I want to be able to overload the – operator, so that I can subtract one instance of a custom list class from another instance of a custom list class.
        //List<int> one = new List<int>() {1,3,5}; and List<int> two = new List<int>() { 2, 1, 6 };
        //List<int> result = one - two;
        //result has 3,5

        // I want the ability to zip two custom list class instances together in the form of a zipper. An example:
        //I have List<int> odd = new List<int>() {1,3,5}; and List<int> even = new List<int>() { 2, 4, 6 }; 
        //odd.Zip(even);
        //When lists odd and even are zipped together, your new list will contain values 1,2,3,4,5,6

        //custom list class to be iterable.

        //


    }

}
