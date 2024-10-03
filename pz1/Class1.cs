namespace pz1
{
    public class Class1
    {
        public int FindMax(int[] numbers)
        {
            if (numbers == null)
                return 0;

            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n > max)
                    max = n;
            }
            return max;
        }

        public int FindMin(int[] numbers)
        {
            if (numbers == null)
                return 0;

            int min = numbers[0];
            foreach (int n in numbers)
            {
                if (min > n)
                    min = n;
            }
            return min;
        }
        public string ReverseString(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        public bool isPalindrome(string s)
        {
            string revers = ReverseString(s);
            return string.Equals(s, revers, StringComparison.OrdinalIgnoreCase);
        }
        public int[] SortArray(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }
    }
}
