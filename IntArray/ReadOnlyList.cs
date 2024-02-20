using System.Collections;

namespace IntArray
{
    public class ReadOnlyList<T> : IList<T>
    {
        private readonly IList<T> list;

        public ReadOnlyList(IList<T> list)
        {
            this.list = list;
        }

        public int Count => list.Count;

        public bool IsReadOnly { get => true; }

        public T this[int index]
        {
            get => list[index];

            set => throw new NotSupportedException();
        }

        public void Add(T item) => throw new NotSupportedException();

        public void Clear() => throw new NotSupportedException();

        public bool Contains(T item) => list.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => list.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() => list.GetEnumerator();

        public int IndexOf(T item) => list.IndexOf(item);

        public void Insert(int index, T item) => throw new NotSupportedException();

        public bool Remove(T item) => throw new NotSupportedException();

        public void RemoveAt(int index) => throw new NotSupportedException();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
