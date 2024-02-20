using Xunit;

namespace IntArray
{
    public class SortedIntArrayFacts
    {
        [Fact]
        public void Add_ElementsAreAlmostSorted_ShouldReturnTrue()
        {
            var sortedArray = new SortedIntArray();
            sortedArray.Add(2);
            sortedArray.Add(5);
            sortedArray.Add(4);

            int[] expectedArray = { 2, 4, 5, 0 };

            Assert.True(AreEqual(sortedArray, expectedArray));
        }

        [Fact]
        public void Add_ElementsAreSortedInDescendingOrder_ShouldReturnTrue()
        {
            var sortedArray = new SortedIntArray();
            sortedArray.Add(10);
            sortedArray.Add(9);
            sortedArray.Add(8);
            sortedArray.Add(7);
            sortedArray.Add(6);

            int[] expectedArray = { 6, 7, 8, 9, 10, 0, 0, 0 };

            Assert.True(AreEqual(sortedArray, expectedArray));
        }

        [Fact]
        public void Set_SortingIsAffected_ShouldReturnTrue()
        {
            var sortedArray = new SortedIntArray();
            sortedArray.Add(2);
            sortedArray.Add(4);
            sortedArray.Add(6);
            sortedArray.Add(8);
            sortedArray.Add(10);

            sortedArray[3] = 5;

            int[] expectedArray = { 2, 4, 6, 8, 10, 0, 0 , 0 };

            Assert.True(AreEqual(sortedArray, expectedArray));

        }

        [Fact]
        public void Set_SortingIsNotAffected_ShouldReturnTrue()
        {
            var sortedArray = new SortedIntArray();
            sortedArray.Add(100);
            sortedArray.Add(48);
            sortedArray.Add(253);

            sortedArray[2] = 401;

            int[] expectedArray = { 48, 100, 401, 0 };

            Assert.True(AreEqual(sortedArray, expectedArray));
        }

        [Fact]
        public void Insert_SortingIsNotAffected_ShouldReturnTrue()
        {
            var sortedArray = new SortedIntArray();
            sortedArray.Add(9);
            sortedArray.Add(7);
            sortedArray.Add(11);

            sortedArray.Insert(1, 8);

            int[] expectedArray = { 7, 8, 9, 11 };

            Assert.True(AreEqual(sortedArray, expectedArray));
        }

        [Fact]
        public void Insert_SortingIsAffected_ShouldReturnExpectedResult()
        {
            var sortedArray = new SortedIntArray();
            sortedArray.Add(25);
            sortedArray.Add(50);
            sortedArray.Add(75);
            sortedArray.Insert(0, 100);

            Assert.Equal(25, sortedArray[0]);
        }

        [Fact]
        public void Insert_InsertOnLastIndex_ShouldReturnTrue()
        {
            var sortedArray = new SortedIntArray();
            sortedArray.Add(11);
            sortedArray.Add(32);
            sortedArray.Add(7);
            sortedArray.Add(9);
            sortedArray.Add(21);
            sortedArray.Insert(4, 30);

            int[] expectedResult = { 7, 9, 11, 21, 30, 32, 0, 0 };

            Assert.True(AreEqual(sortedArray, expectedResult));
        }

        [Fact]
        public void Insert_InvalidIndex_ShouldReturnExpectedResult()
        {
            var sortedArray = new SortedIntArray();
            sortedArray.Add(25);
            sortedArray.Add(13);
            sortedArray.Add(1);
            sortedArray.Insert(-1, 100);

            int[] expectedResult = { 1, 13, 25, 0 };
            Assert.True(AreEqual(sortedArray, expectedResult));
        }

        [Fact]
        public void Insert_InsertionOnSecondIndex_ShouldReturnExpectedResult()
        {
            var sortedArray = new SortedIntArray();
            sortedArray.Add(100);
            sortedArray.Add(45);
            sortedArray.Add(200);
            sortedArray.Insert(1, 44);

            int[] expectedResult = {45, 100, 200, 0 };

            Assert.True(AreEqual(sortedArray, expectedResult));

        }


        private static bool AreEqual(SortedIntArray sortedArray, int[] expectedArray)
        {
            for (int i = 0; i < expectedArray.Length; i++)
            {
                if (sortedArray[i] != expectedArray[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
