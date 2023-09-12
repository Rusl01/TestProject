namespace Test.Service.ClassService
{
    public class SumArrayService : ISumArray
    {
        public int GetSumArray(int[] Array)
        {
            int sum = 0;
            int count = 0;

            for (int i = 1; i < Array.Length; i += 1)
                if (Array[i] % 2 != 0)
                {
                    count++;
                    if (count == 2)
                    {
                        sum += Array[i];
                        count = 0;
                    }
                }
            return sum;
        }
    }
}
