namespace IntArray
{
    public class IntArray
    {
        private int[] array;

        public IntArray() => array = new int[4];

        public int Count { get; private set; }

        public virtual int this[int index]
        {
            get => array[index];
            set
            {
                if (!ValidateIndex(index))
                {
                    return;
                }

                array[index] = value;
            }
        }

        public virtual void Add(int element)
        {
            ResizeArray();
            array[Count] = element;
            Count++;
        }

        public bool Contains(int element) => IndexOf(element) >= 0;

        public int IndexOf(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }

        public virtual void Insert(int index, int element)
        {
            if (!ValidateIndex(index))
            {
                return;
            }

            RightShift(index);
            array[index] = element;
            Count++;
        }

        public void Clear() => Count = 0;

        public void Remove(int element)
        {
            RemoveAt(IndexOf(element));
        }

        public void RemoveAt(int index)
        {
            if (!ValidateIndex(index))
            {
                return;
            }

            LeftShift(index);
            Count--;
        }

        public bool ValidateIndex(int index)
        {
            return index >= 0 && index < Count;
        }

        private void ResizeArray()
        {
            if (array.Length > Count)
            {
                return;
            }

            Array.Resize(ref array, array.Length * 2);
        }

        private void RightShift(int index)
        {
            for (int i = Count; i > index; i--)
            {
                array[i] = array[i - 1];
            }
        }

        private void LeftShift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }
        }
    }
}