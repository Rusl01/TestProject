namespace Test.Service.ClassService
{
    public class SortArrayService<T>:ISortArray<T> where T : struct, IComparable<T>
    {
        public T[] ArraySorter(T[] values)
        {
            int n = values.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (values[j].CompareTo(values[j + 1]) > 0)
                    {
                        T temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }

            return values;
        }
    }
}
