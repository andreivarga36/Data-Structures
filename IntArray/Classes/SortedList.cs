namespace DataStructures.Classes
{
    public class SortedList<T> : List<T>
        where T : IComparable<T>
    {
        public SortedList() : base()
        {
        }

        public override T this[int index]
        {
            get => base[index];
            set
            {
                if (ElementOrDefault(index - 1, value).CompareTo(value) > 0
                   || ElementOrDefault(index + 1, value).CompareTo(value) < 0)
                {
                    return;
                }

                base[index] = value;
            }
        }

        public override void Add(T item)
        {
            base.Add(item);
            SortList();
        }

        public override void Insert(int index, T item)
        {
            if (ElementOrDefault(index - 1, item).CompareTo(item) > 0
                || ElementOrDefault(index, item).CompareTo(item) < 0)
            {
                return;
            }

            base.Insert(index, item);
        }

        public T ElementOrDefault(int index, T value)
        {
            return index >= 0 && index < Count ? base[index] : value;
        }

        private void SortList()
        {
            bool numbersAreNotSorted = true;

            while (numbersAreNotSorted)
            {
                numbersAreNotSorted = false;

                for (int i = 1; i < Count; i++)
                {
                    if (base[i - 1].CompareTo(base[i]) > 0)
                    {
                        Swap(i, i - 1);
                        numbersAreNotSorted = true;
                    }
                }
            }
        }

        private void Swap(int index, int secondIndex)
        {
            (base[secondIndex], base[index]) = (base[index], base[secondIndex]);
        }
    }
}
