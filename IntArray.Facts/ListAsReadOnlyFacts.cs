using Xunit;

namespace IntArray
{
    public class ListAsReadOnlyFacts
    {
        [Fact]
        public void Add_ListIsReadOnly_ShouldReturnExpectedResult()
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            var listAsReadOnly = new ReadOnlyList<int>(list);

            Assert.True(listAsReadOnly.IsReadOnly);
            Assert.Throws<NotSupportedException>(() => listAsReadOnly.Add(5));
        }

        [Fact]
        public void Set_ListIsReadOnly_ShouldReturnExpectedResult()
        {
            var list = new List<int>() { 10, 20, 30 };
            var listAsReadOnly = new ReadOnlyList<int>(list);

            Assert.Throws<NotSupportedException>(() => listAsReadOnly[1] = 15);
        }

        [Fact]
        public void Remove_ListIsReadOnly_ShouldReturnExpectedResult()
        {
            var list = new List<string>() { "car", "house", "iron" };
            var listAsReadOnly = new ReadOnlyList<string>(list);

            Assert.Throws<NotSupportedException>(() => listAsReadOnly.Remove("iron"));
        }

        [Fact]
        public void Insert_OwnerCanModifyList_ShouldReturnExpectedResult()
        {
            var list = new List<int>() { 100, 400, 600, 800 };
            var listAsReadOnly = new ReadOnlyList<int>(list);

            list.Add(999);

            Assert.Equal(999, listAsReadOnly[4]);
            Assert.Equal(5, listAsReadOnly.Count);
        }

        [Fact]
        public void CopyTo_ListIsCopied_ShouldReturnExpectedResult()
        {
            var list = new List<char>() { 'a', 'b', 'c', 'd', };
            var charArray = new char[4];
            list.CopyTo(charArray, 0);

            Assert.Equal(list, charArray);
        }

        [Fact]
        public void IndexProperty_InvalidIndex_ShouldReturnExpectedResult()
        {
            var list = new List<int>() { 1, 2, 3 };
            var readOnlyList = new ReadOnlyList<int>(list);

            Assert.Throws<ArgumentOutOfRangeException>(() => readOnlyList[-1]);
        }
    }
}
