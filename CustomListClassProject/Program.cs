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
            // Add item  ----------------------------------------------------------------------------------
            customIntList.Add(1);
            customIntList.Add(7);
            customIntList.Add(3);
            customIntList.Add(4);
            customIntList.Add(5);
            customIntList.Add(6);
            //remove item  -----------------------------------------------------------------------------------
            customIntList.Remove(1);
            customIntList.Remove(7);
            customIntList.Remove(3);
            //ToString  -----------------------------------------------------------------------------------------
            Console.WriteLine(customIntList.ToString());
            Console.ReadLine();
            // operator +  ---------------------------------------------------------------------------------------
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(4);
            testList1.Add(5);
            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(4);
            testList2.Add(6);
            // act
            CustomList<int> result = testList1 + testList2;

            // operator -           ------------------------------------------------------------------------------
            // act
            CustomList<int> result2 = testList1 - testList2;

            // zip two custom list
            //act
            CustomList<int> actual = CustomList<int>.Zip(testList1, testList2);

        }
    }
}
