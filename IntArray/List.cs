using System.Collections;

namespace IntArray
{
    public class List<T> : IList<T>
    {
        private T[] list;

        public List()
        {
            this.list = new T[4];
        }

        public virtual int Count { get; private set; }

        public virtual bool IsReadOnly { get => false; }

        public virtual T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return list[index];
            }

            set
            {
                ValidateIndex(index);
                list[index] = value;
            }
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public virtual void Add(T item)
        {
            ResizeArray();
            list[Count] = item;
            Count++;
        }

        public virtual bool Contains(T item) => IndexOf(item) >= 0;

        public virtual int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Equals(list[i], item))
                {
                    return i;
                }
            }

            return -1;
        }

        public virtual void Insert(int index, T item)
        {
            ValidateIndex(index);
            RightShift(index);
            list[index] = item;
            Count++;
        }

        public virtual void Clear() => Count = 0;

        public virtual bool Remove(T item)
        {
            int index = IndexOf(item);

            if (index == -1)
            {
                return false;
            }

            RemoveAt(index);
            return true;
        }

        public virtual void RemoveAt(int index)
        {
            ValidateIndex(index);
            LeftShift(index);
            Count--;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ValidateList();
            ValidateArray(array);
            ValidateIndex(arrayIndex);
            ValidateArrayAvailableSpace(array, arrayIndex);
            CopyItems(array, arrayIndex);
        }

        private static void ValidateArray(T[] array)
        {
            if (array != null)
            {
                return;
            }

            throw new ArgumentNullException(nameof(array));
        }

        private void ValidateIndex(int index)
        {
            if (index >= 0 && index < Count)
            {
                return;
            }

            throw new ArgumentOutOfRangeException(nameof(index));
        }

        private void ValidateList()
        {
            if (Count > 0)
            {
                return;
            }

            throw new ArgumentException(nameof(list));
        }

        private void ValidateArrayAvailableSpace(T[] array, int arrayIndex)
        {
            if (Count <= (array.Length - arrayIndex))
            {
                return;
            }

            const string exceptionMessage = "The number of elements in the source ICollection<T> is greater than the available " +
                "space from arrayIndex to the end of the destination array.";
            throw new ArgumentException(exceptionMessage);
        }

        private void CopyItems(T[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i < array.Length; i++)
            {
                array[i] = list[i];
            }
        }

        private void RightShift(int index)
        {
            for (int i = Count; i > index; i--)
            {
                list[i] = list[i - 1];
            }
        }

        private void LeftShift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                list[i] = list[i + 1];
            }
        }

        private void ResizeArray()
        {
            if (list.Length > Count)
            {
                return;
            }

            Array.Resize(ref list, list.Length * 2);
        }
    }
}
