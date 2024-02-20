using Xunit;

namespace IntArray
{
    public class SortedListFacts
    {
        [Fact]
        public void Add_SortedListOfInts_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<int>() { 1, 2, 3, 4 };

            Assert.Equal(4, sortedList.Count);
        }

        [Fact]
        public void Add_UnsortedListOfInts_ShouldReturnExpectedResult()
        {
            var list = new SortedList<int>() { 3, 1, 2, 4, 11, 9 };

            Assert.Equal(6, list.Count);
        }

        [Fact]
        public void Add_SortedListOfStrings_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<string>() { "bologna", "inter", "roma" };

            Assert.Equal(3, sortedList.Count);
        }

        [Fact]
        public void Add_UnsortedListOfStrings_ShouldReturnExpectedResult()
        {
            var list = new SortedList<string>() { "bmw", "mercedes", "audi", "opel", "skoda", "bentley", "volvo" };

            Assert.Equal(7, list.Count);
        }

        [Fact]
        public void Insert_SortedListOfIntsInsertionOnLastIndex_ShouldReturnTrue()
        {
            var sortedList = new SortedList<int> { 2, 4, 6, 8, 10 };
            sortedList.Insert(4, 9);

            Assert.Equal(9, sortedList[4]);
            Assert.Equal(10, sortedList[5]);
        }


        [Fact]
        public void Insert_UnsortedListOfStringsInsertionOnSecondIndex_ShouldReturnTrue()
        {
            var list = new SortedList<string>() { "cat", "bear", "tiger", "lion", "butterfly", "monkey" };
            list.Insert(1, "bug");

            Assert.True(Equals(list[1], "bug"));
        }

        [Fact]
        public void Set_SortedListOfIntsIsNotAffected_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<int>() { 100, 200, 800, 900 };
            sortedList[1] = 799;

            Assert.Equal(799, sortedList[1]);
        }

        [Fact]
        public void Set_SortedListOfIntsIsAffected_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<int>() { 1, 2, 5, 7 };
            sortedList[2] = 1;

            Assert.Equal(5, sortedList[2]);
        }

        [Fact]
        public void Insert_InvalidIndex_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<char> { 'a', 'e', 'i', 'o' };

            Assert.Throws < ArgumentOutOfRangeException>(() => sortedList.Insert(4, 'u'));
        }

        [Fact]
        public void Set_InvalidIndex_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<string>() { "bob", "john", "michael" };
            sortedList[-1] = "paul";

            Assert.Equal(3, sortedList.Count);
        }

        [Fact]
        public void Set_SetOnFirstIndex_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<int>() { 2, 4, 6, 8 };
            sortedList[0] = 0;

            Assert.Equal(0, sortedList[0]);
        }

        [Fact]
        public void Set_SetOnSecondIndex_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<string>() { "bear", "cow", "horse" };
            sortedList[1] = "monkey";

            Assert.Equal("cow", sortedList[1]);
        }

        [Fact]
        public void Insert_InsertOnFirstIndex_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<int>() { 100, 200, 300, 400, 500 };
            sortedList.Insert(0, 99);

            Assert.Equal(99, sortedList[0]);
            Assert.Equal(100, sortedList[1]);
        }

        [Fact]
        public void Insert_InsertionOnLastIndex_ShouldReturnExpectedResult()
        {
            var sortedList = new SortedList<string>() { "blue", "green", "yellow"};
            sortedList.Insert(2, "red");

            Assert.Equal("red", sortedList[2]);
            Assert.Equal("yellow", sortedList[3]);
        }

        [Fact]
        public void Add_ElementsAddedInDescendingOrder_ShouldReturnExpectedResult()
        {
            var list = new SortedList<int>();
            list.Add(3);
            list.Add(2);
            list.Add(1);

            Assert.Equal(1, list[0]);
            Assert.Equal(2, list[1]);
            Assert.Equal(3, list[2]);
        }
    }
}
