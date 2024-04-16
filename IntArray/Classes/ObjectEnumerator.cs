using System.Collections;

namespace DataStructures.Classes
{
    public class ObjectEnumerator : IEnumerator
    {
        private readonly List<object> list;
        private int position = -1;

        public ObjectEnumerator(List<object> list) => this.list = list;

        public object Current { get => list[position]; }

        public bool MoveNext()
        {
            position++;
            return position < list.Count;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
