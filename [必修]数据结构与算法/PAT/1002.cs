using System.*;

namespace t1002
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            String num;
            
            num=Console.ReadLine();
            foreach (var item in num)
            {
                n+=Convert.ToInt32(item);
            }
            Console.WriteLine(n);
        }
    }
    
}