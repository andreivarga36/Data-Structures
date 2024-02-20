using Xunit;

namespace IntArray
{
    public class IntArrayFacts
    {
        [Fact]
        public void Add_ArrayWithOneElement_ShouldReturnExpectedResult()
        {
            var array = new IntArray();
            array.Add(1);

            int totalElements = 1;

            Assert.Equal(totalElements, array[0]);
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void Count_ArrayWithFiveElements_ShouldReturnExpectedResult()
        {
            var array = new IntArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);

            int totalElements = 5;

            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void Element_ElementIsLocatedOnLastIndex_ShouldReturnExpectedResult()
        {
            var array = new IntArray();
            array.Add(10);
            array.Add(20);
            array.Add(30);

            int element = 30;
            int totalElements = 3;

            Assert.Equal(element, array[2]);
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void SetElement_LastIndexIsChanged_ShouldReturnExpectedResult()
        {
            var array = new IntArray();
            array.Add(22);
            array.Add(40);
            array.Add(77);

            int element = 99;
            int totalElements = 3;

            array[2] = element;

            Assert.Equal(element, array[2]);
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void Contains_ArrayContainsElement_ShouldReturnTrue()
        {
            var array = new IntArray();
            array.Add(12);
            array.Add(24);

            int element = 24;
            int totalElements = 2;

            Assert.True(array.Contains(element));
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void IndexOf_ArrayContainsElement_ShouldReturnElementIndex()
        {
            var array = new IntArray();
            array.Add(10);
            array.Add(20);
            array.Add(30);

            int element = 20;
            int totalElements = 3;

            Assert.Equal(1, array.IndexOf(element));
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void IndexOf_ArrayDoNotContainsElement_ShouldReturnExpectedResult()
        {
            var array = new IntArray();
            array.Add(100);
            array.Add(200);

            int element = 300;
            int totalElements = 2;

            Assert.Equal(-1, array.IndexOf(element));
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void Insert_OneElementIsInserted_ShouldReturnTrue()
        {
            var array = new IntArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Insert(2, 100);

            int[] expectedArray = { 1, 2, 100, 3, 4, 5, 0, 0 };
            int totalElements = 6;

            Assert.True(AreEqual(array, expectedArray));
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void Clear_ArrayContainsThreeElements_ShouldReturnTrue()
        {
            var array = new IntArray();
            array.Add(20);
            array.Add(33);
            array.Add(44);
            array.Clear();

            int totalElements = 0;

            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void Remove_SecondElementIsRemoved_ShouldReturnTrue()
        {
            var array = new IntArray();
            array.Add(100);
            array.Add(200);
            array.Add(300);
            array.Add(400);
            array.Remove(200);

            int[] result = { 100, 300, 400, 400 };
            int totalElements = 3;

            Assert.True(AreEqual(array, result));
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void RemoveAt_LastElementIsRemoved_ShouldReturnTrue()
        {
            var array = new IntArray();
            array.Add(11);
            array.Add(2);
            array.Add(33);
            array.Add(8);
            array.RemoveAt(3);

            int[] expectedArray = { 11, 2, 33, 8 };
            int totalElements = 3;

            Assert.True(AreEqual(array, expectedArray));
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void RemoveAt_ThirdElementIsRemoved_ShouldReturnTrue()
        {
            var array = new IntArray();
            array.Add(2);
            array.Add(4);
            array.Add(6);
            array.Add(8);
            array.Add(10);
            array.RemoveAt(2);

            int[] expectedArray = { 2, 4, 8, 10, 10, 0, 0, 0 };
            int totalElements = 4;

            Assert.True(AreEqual(array, expectedArray));
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void Add_ArrayContainsFiveElements_ShouldReturnTrue()
        {
            var array = new IntArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);

            int totalElements = 5;

            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void Add_ZeroIsAddedTwice_ShouldReturnTrue()
        {
            var array = new IntArray();
            array.Add(0);
            array.Add(0);
            array.Add(1);
            array.Add(2);
            array.Add(3);

            int[] expectedArray = { 0, 0, 1, 2, 3, 0, 0, 0 };
            int totalElements = 5;

            Assert.True(AreEqual(array, expectedArray));
            Assert.Equal(totalElements, array.Count);
        }

        [Fact]
        public void SetElement_InvalidIndex_ShouldReturnExpectedResult()
        {
            var array = new IntArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);

            array[4] = 5;
            int[] expectedArray = { 1, 2, 3, 4 };

            Assert.True(AreEqual(array, expectedArray));
        }

        [Fact]
        public void Remove_ElementIsNotInArray_ShouldReturnExpectedResult()
        {
            var array = new IntArray();
            array.Add(10);
            array.Add(100);
            array.Add(1000);
            array.Remove(500);

            int[] expectedArray = { 10, 100, 1000, 0 };

            Assert.True(AreEqual(array, expectedArray));
        }

        [Fact]
        public void IndexOf_InvalidIndex_ShouldReturnExpectedResult()
        {
            var array = new IntArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);

            Assert.Equal(-1, array.IndexOf(4));
        }

        private static bool AreEqual(IntArray array, int[] expectedArray)
        {
            for (int i = 0; i < expectedArray.Length; i++)
            {
                if (array[i] != expectedArray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}