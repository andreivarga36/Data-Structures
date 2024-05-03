using DataStructures.Classes;
using Xunit;

namespace DataStructuresFacts.Classes
{
    public class ObjectEnumeratorFacts
    {
        [Fact]
        public void MoveNext_CollectionWithThreeObjects_ShouldReturnFirstObject()
        {
            var objectArray = new DataStructures.Classes.List<object> { 9.5, true, " " };
            var enumerator = new ObjectEnumerator(objectArray);
            enumerator.MoveNext();

            Assert.Equal(9.5, enumerator.Current);
        }
    }
}
