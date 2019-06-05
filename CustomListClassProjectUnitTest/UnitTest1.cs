using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassProjectUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //ADD TESTS: 5 total
        [TestMethod]
        public void Add_AddItemIntToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(expected);
            actual = testList.arrayItem[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddItemStringToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            int expected = "Mike";
            int actual;

            // act
            testList.Add(expected);
            actual = testList.itemArray[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(698);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // ADDITIONAL TEST IDEA:
        // If we add an item to a list that already has 5 things in it,
        // does the newly added item go to the correct spot? (index 5?)


            //Add multiple items to an empty list
        public void Add_AddThreeItemsIntToEmptyList_ReturnThreeItemListCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1; 
            int value2 = 2;
            int value3 = 3;
            int expected = 3;
            int actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            actual = testList[0] + testList[2] + testList[3]; // testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        //Add item greater than capacity
        public void Add_AddItemsIntGreaterThanCapacity_ReturnItemListCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;
            int value6 = 12;
            int value7 = 14;
            int value8 = 16;
            int expected = 8;
            int actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            testList.Add(value6);
            testList.Add(value7);
            testList.Add(value8);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
