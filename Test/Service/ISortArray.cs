namespace Test.Service
{
    public interface ISortArray<T> where T: struct, IComparable<T>
    {
        public T[] ArraySorter(T[] values);
    }
}
