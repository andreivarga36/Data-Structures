using DataStructures.Classes;
using Xunit;

namespace DataStructuresFacts.Classes
{
    public class ListFacts
    {
        [Fact]
        public void Add_TwoObjectsAdded_ShouldReturnTrue()
        {
            var list = new DataStructures.Classes.List<object>() { 2.5, true };

            Assert.Contains(2.5, list);
            Assert.Contains(true, list);
        }

        [Fact]
        public void Insert_InsertionOnLastIndex_ShouldReturnTrue()
        {
            var list = new DataStructures.Classes.List<object>() { " ", 'a', 1.01 };
            list.Insert(2, "item");

            Assert.True(Equals(list[2], "item"));
            Assert.True(Equals(list[3], 1.01));
        }

        [Fact]
        public void Remove_FirstObjectIsRemoved_ShouldReturnTrue()
        {
            var list = new DataStructures.Classes.List<object>() { 1, 22.2, "string", false };
            list.Remove(1);

            Assert.True(Equals(list[0], 22.2));
        }

        [Fact]
        public void Add_Unboxing_ShouldReturnExpectedResult()
        {
            var list = new DataStructures.Classes.List<object>() { 22.5, " " };
            list[0] = (double)list[0] * 2;
            double total = (double)list[0];

            Assert.Equal(45, total);
        }

        [Fact]
        public void CopyTo_EntireListIsCopied_ShouldReturnExpectedResult()
        {
            DataStructures.Classes.List<int> list = new DataStructures.Classes.List<int>() { 1, 2, 3, 4 };
            int[] array = new int[4];
            list.CopyTo(array, 0);

            Assert.Equal(list, array);
        }

        [Fact]
        public void Remove_SecondItemIsRemoved_ShouldReturnExpectedResult()
        {
            DataStructures.Classes.List<string> list = new DataStructures.Classes.List<string>() { "red", "blue", "green" };

            Assert.True(list.Remove("blue"));
            Assert.Equal("green", list[1]);
            Assert.Equal(2, list.Count);
        }

        [Fact]
        public void Remove_ItemDoesNotExist_ShouldReturnExpectedResult()
        {
            DataStructures.Classes.List<int> list = new DataStructures.Classes.List<int>() { 2, 4, 6, 8 };

            Assert.False(list.Remove(10));
            Assert.Equal(4, list.Count);
        }

        [Fact]
        public void AssertThrows_IndexOutOfRangeException_ShouldReturnExpectedResult()
        {
            int[] array = new int[5];
            Action action = () => { array[6] = 1; };

            Assert.Throws<IndexOutOfRangeException>(action);
        }

        [Fact]
        public void AssertThrows_DivideByZeroException_ShouldReturnExpectedResult()
        {
            int a = 20;
            int b = 0;

            void action() { int result = a / b; }

            Assert.Throws<DivideByZeroException>(action);
        }

        [Fact]
        public void AssertThrows_InvalidCastException_ShouldReturnExpectedResult()
        {
            object obj = "x";

            Assert.Throws<InvalidCastException>(() => (int)obj);
        }

        [Fact]
        public void Insert_ExceptionIsThrownDueToInvalidIndex_ShouldReturnExpectedResult()
        {
            var list = new DataStructures.Classes.List<int>() { 10, 20, 30 };

            Assert.Throws<ArgumentOutOfRangeException>(() => list.Insert(5, 50));
        }

        [Fact]
        public void RemoveAt_ExceptionIsThrownDueToInvalidIndex_ShouldReturnExpectedResult()
        {
            var list = new DataStructures.Classes.List<int>() { 3, 11, 22, 9 };

            Assert.Throws<ArgumentOutOfRangeException>(() => list.RemoveAt(10));
        }

        [Fact]
        public void CopyTo_ArgumentNullExceptionIsThrown_ShouldReturnExpectedResult()
        {
            DataStructures.Classes.List<int> list = new DataStructures.Classes.List<int>() { 1, 2, 3, 4 };
            int[]? array = null;

            Assert.Throws<ArgumentNullException>(() => list.CopyTo(array, 0));
        }

        [Fact]
        public void CopyTo_ArgumentOutOfRangeExceptionIsThrown_ShouldReturnExpectedResult()
        {
            DataStructures.Classes.List<int> list = new DataStructures.Classes.List<int>() { 10, 2, 100 };
            int[] array = new int[4];

            Assert.Throws<ArgumentOutOfRangeException>(() => list.CopyTo(array, -3));
        }

        [Fact]
        public void CopyTo_ArgumentExceptionIsThrown_ShouldReturnExpectedResult()
        {
            DataStructures.Classes.List<string> list = new DataStructures.Classes.List<string>() { "red", "yellow", "blue" };
            string[] array = new string[2];

            Assert.Throws<ArgumentException>(() => list.CopyTo(array, 0));
        }

        [Fact]
        public void CopyTo_ListIsEmpty_ShouldReturnExpectedResult()
        {
            DataStructures.Classes.List<int> list = new DataStructures.Classes.List<int>();
            int[] array = new int[5];

            Assert.Throws<ArgumentException>(() => list.CopyTo(array, 0));
        }
    }
}
