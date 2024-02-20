namespace IntArray
{
    public class SortedIntArray : IntArray
    {
        public SortedIntArray() : base()
        {
        }

        public override int this[int index]
        {
            get => base[index];
            set
            {
                if (!ValidateIndex(index)
                    || ElementOrDefault(index - 1, value) > value
                    || ElementOrDefault(index + 1, value) < value)
                {
                    return;
                }

                base[index] = value;
            }
        }

        public override void Add(int element)
        {
            base.Add(element);
            SortArray();
        }

        public override void Insert(int index, int element)
        {
            if (!ValidateIndex(index)
                || ElementOrDefault(index, element) < element
                || ElementOrDefault(index - 1, element) > element)
            {
                return;
            }

            base.Insert(index, element);
        }

        private int ElementOrDefault(int index, int value)
        {
            return ValidateIndex(index) ? base[index] : value;
        }

        private void SortArray()
        {
            bool numbersAreNotSorted = true;

            while (numbersAreNotSorted)
            {
                numbersAreNotSorted = false;

                for (int i = 1; i < Count; i++)
                {
                    if (base[i] < base[i - 1])
                    {
                        Swap(i, i - 1);
                        numbersAreNotSorted = true;
                    }
                }
            }
        }

        private void Swap(int firstNumber, int secondNumber)
        {
            (base[secondNumber], base[firstNumber]) = (base[firstNumber], base[secondNumber]);
        }
    }
}
