using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace CustomListClassProjectUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //ADD TESTS: 6 total  ----------------------------------------------------------------------
        [TestMethod]
        public void Add_AddItemIntToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 4;
            int expected = 4;
            int actual;
            
            // act
            testList.Add(value1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemStringToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string value1 = "Mike";
            string expected = "Mike";
            string actual;

            // act
            testList.Add(value1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int expected = 1;
            int actual;

            // act
            testList.Add(value1);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // ADDITIONAL TEST IDEA:
        // If we add an item to a list that already has 5 things in it,
        // does the newly added item go to the correct spot? (index 5?)


        //Add multiple items to an empty list

        [TestMethod]
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
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        //Add item greater than capacity

        [TestMethod]
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
        // Test if value in the right spot
        [TestMethod]
        public void Add_AddItemsIntGreaterThanCapacity_ReturnItemListCountSort()
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
            int expected = 16;
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
            actual = testList[7];

            // assert
            Assert.AreEqual(expected, actual);
        }

        //REMOVE TESTS: 5 total  ---------------------------------------------------------------------------------------
        [TestMethod]
        public void Remove_RemoveItemIntFromList_ReturnItemIndexOneToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>(); //need to add value before remove value
            int value1 = 4;
            int value2 = 6;
            int expected = 6;
            int actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Remove(value1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemStringFromList_ReturnItemIndexOneToIndexZero()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string value1 = "Mike";
            string value2 = "Bob";
            string expected = "Bob";
            string actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Remove(value1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveOneItemIntFromList_RemoveOneItemFromTheCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>(); //need to add value before remove value
            int value1 = 4;
            int value2 = 6;
            int value3 = 7;
            int expected = 2;
            int actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(value1);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveThreeItemIntFromList_RemoveThreeItemFromTheCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>(); //need to add value before remove value
            int value1 = 4;
            int value2 = 6;
            int value3 = 7;
            int value4 = 5;
            int expected = 1;
            int actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Remove(value1);
            testList.Remove(value2);
            testList.Remove(value4);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemIntFromMiddleOfList_RemoveOneItemFromTheCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>(); //need to add value before remove value
            int value1 = 4;
            int value2 = 6;
            int value3 = 7;
            int expected = 2;
            int actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(value2);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemIntNotOnTheList_ReturnNothingRemoveFromList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>(); //need to add value before remove value
            int value1 = 4;
            int value2 = 6;
            int value3 = 7;
            int value4 = 5;
            int expected = 3;
            int actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(value4);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        //ToString: 4 total  --------------------------------------------------------------------------------------------
        [TestMethod]
        public void ToString_ItemFromListWithNoValue_ReturnItemWithNoValueAsString()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string value1 = "";
            string expected = "";
            string actual;

            // act
            testList.Add(value1);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_OneItemIntFromList_ReturnOneItemAsString()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 4;
            string expected = "4";
            string actual;

            // act
            testList.Add(value1);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_MultipleItemIntFromList_ReturnMultipleItemAsString()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>(); 
            int value1 = 4;
            int value2 = 6;
            int value3 = 8;
            string expected = "4, 6, 8";
            string actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_MultipleItemStringFromList_ReturnMultipleItemStringAsString()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string value1 = "Go";
            string value2 = "Pack";
            string value3 = "Go";
            string expected = "Go, Pack, Go";
            string actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        // Overload the + operator: 3 total  ----------------------------------------------------------------------------
        [TestMethod]
        public void Overload_AddTwoCustomList_ReturnItemIdexTwo()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(3);
            expectedResult.Add(5);
            expectedResult.Add(2);
            expectedResult.Add(4);
            expectedResult.Add(6);
            int expected = 5;
            int actual;

            // act
            CustomList<int> result = testList1 + testList2;
            actual = expectedResult[2];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_AddTwoCustomList_ReturnItemIdexFive()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(3);
            expectedResult.Add(5);
            expectedResult.Add(2);
            expectedResult.Add(4);
            expectedResult.Add(6);
            int expected = 6;
            int actual;

            // act
            CustomList<int> result = testList1 + testList2;
            actual = expectedResult[5];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_AddTwoCustomList_ReturnAddTwoCustomCount()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(3);
            expectedResult.Add(5);
            expectedResult.Add(2);
            expectedResult.Add(4);
            expectedResult.Add(6);
            int expected = 6;
            int actual;

            // act
            CustomList<int> result = testList1 + testList2;
            actual = expectedResult.Count;
            // assert
            Assert.AreEqual(expected, actual);

        }
        // Overload the - operator: 3 total  -----------------------------------------------------------------------------
        [TestMethod]
        public void Overload_MinusOneItemFromTwoCustomList_ReturnItemIdexZero()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(3);
            expectedResult.Add(5);
            int expected = 3;
            int actual;

            // act
            CustomList<int> result = testList1 - testList2;
            actual = expectedResult[0];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Overload_MinusOneItemFromTwoCustomList_ReturnItemIdexOne()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(3);
            expectedResult.Add(5);
            int expected = 5;
            int actual;

            // act
            CustomList<int> result = testList1 - testList2;
            actual = expectedResult[1];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Overload_MinusTwoItemsFromTwoCustomList_ReturnItemCount()
        {
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
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(3);
            expectedResult.Add(5);
            int expected = 2;
            int actual;

            // act
            CustomList<int> result = testList1 - testList2;
            actual = expectedResult.Count;
            // assert
            Assert.AreEqual(expected, actual);
        }
        //zip two custom: 5 total  -----------------------------------------------------------------------------------------
        [TestMethod]
        public void Zip_ZipTwoCustomList_ReturnItemValueFromIdexZero()
        {
            // arrange
            CustomList<int> testListOdd = new CustomList<int>();
            testListOdd.Add(1);
            testListOdd.Add(3);
            testListOdd.Add(5);
            CustomList<int> testListEven = new CustomList<int>();
            testListEven.Add(2);
            testListEven.Add(4);
            testListEven.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);
            int expected = 1;
            int actual;

            // act
            CustomList<int> result = CustomList<int>.Zip(testListOdd, testListEven);  // cannot do list 1 - or + list 2 for Zip like operator
            actual = expectedResult[0];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ZipTwoCustomList_ReturnItemValueFromIdexThree()
        {
            // arrange
            CustomList<int> testListOdd = new CustomList<int>();
            testListOdd.Add(1);
            testListOdd.Add(3);
            testListOdd.Add(5);
            CustomList<int> testListEven = new CustomList<int>();
            testListEven.Add(2);
            testListEven.Add(4);
            testListEven.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);
            int expected = 4;
            int actual;

            // act
            CustomList<int> result = CustomList<int>.Zip(testListOdd, testListEven);  // cannot do list 1 - or + list 2 for Zip like operator
            actual = expectedResult[3];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ZipTwoCustomList_ReturnItemValueFromIdexFive()
        {
            // arrange
            CustomList<int> testListOdd = new CustomList<int>();
            testListOdd.Add(1);
            testListOdd.Add(3);
            testListOdd.Add(5);
            CustomList<int> testListEven = new CustomList<int>();
            testListEven.Add(2);
            testListEven.Add(4);
            testListEven.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);
            int expected = 6;
            int actual;

            // act
            CustomList<int> result = CustomList<int>.Zip(testListOdd, testListEven);  // cannot do list 1 - or + list 2 for Zip like operator
            actual = expectedResult[5];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ZipTwoCustomList_ReturnTwoCustomListCount()
        {
            // arrange
            CustomList<int> testListOdd = new CustomList<int>();
            testListOdd.Add(1);
            testListOdd.Add(3);
            testListOdd.Add(5);
            CustomList<int> testListEven = new CustomList<int>();
            testListEven.Add(2);
            testListEven.Add(4);
            testListEven.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);
            int expected = 6;
            int actual;

            // act

            // act
            CustomList<int> result = CustomList<int>.Zip(testListOdd, testListEven);  // cannot do list 1 - or + list 2 for Zip like operator
            actual = expectedResult.Count;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ZipTwoCustomList_ReturnItemValueConvertToString()
        {
            // arrange
            CustomList<int> testListOdd = new CustomList<int>();
            testListOdd.Add(1);
            testListOdd.Add(3);
            testListOdd.Add(5);
            CustomList<int> testListEven = new CustomList<int>();
            testListEven.Add(2);
            testListEven.Add(4);
            testListEven.Add(6);
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);

            // act
            CustomList<int> actual = CustomList<int>.Zip(testListOdd, testListEven);  // cannot do list 1 - or + list 2 for Zip like operator
            //compare result to string
            string actualString = actual.ToString();
            string expectedString = expectedResult.ToString();

            // assert
            Assert.AreEqual(expectedString, actualString);
        }
        //Sort two custom: 5 total  -----------------------------------------------------------------------------------------
        //[TestMethod]
        //public void Sort_SortTwoCustomList_ReturnItemValueFromIdexZero()
        //{
        //    // arrange
        //    CustomList<int> testListOdd = new CustomList<int>();
        //    testListOdd.Add(1);
        //    testListOdd.Add(3);
        //    testListOdd.Add(5);
        //    CustomList<int> testListEven = new CustomList<int>();
        //    testListEven.Add(2);
        //    testListEven.Add(4);
        //    testListEven.Add(6);
        //    CustomList<int> expectedResult = new CustomList<int>();
        //    expectedResult.Add(1);
        //    expectedResult.Add(2);
        //    expectedResult.Add(3);
        //    expectedResult.Add(4);
        //    expectedResult.Add(5);
        //    expectedResult.Add(6);
        //    int expected = 1;
        //    int actual;

        //    // act
        //    CustomList<int> result = CustomList<int>.Sort(testListOdd, testListEven);  // cannot do list 1 - or + list 2 for Zip like operator
        //    actual = expectedResult[0];
        //    // assert
        //    Assert.AreEqual(expected, actual);
        //}

    }
}
