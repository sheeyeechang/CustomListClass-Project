using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customIntList = new CustomList<int>();
            // Add item
            customIntList.Add(1);
            customIntList.Add(7);
            customIntList.Add(3);
            customIntList.Add(4);
            customIntList.Add(5);
            customIntList.Add(6);
            //remove item
            customIntList.Remove(1);
            customIntList.Remove(7);
            customIntList.Remove(3);
            //ToString
            Console.WriteLine(customIntList.ToString());
            Console.ReadLine();
        }
    }
}
