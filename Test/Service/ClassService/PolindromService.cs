namespace Test.Service.ClassService
{
    public class PolindromService : IPalindrom
    {
        public bool ChekPolindrom(string Strings)
        {
          
            string Input = Strings.Replace(" ", "").ToLower();

            for (int i = 0; i < Input.Length / 2; i++)
                if (Input[i] != Input[Input.Length - i - 1])
                    return false;

            return true; 
        }
    }
}
