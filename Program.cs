using System;

namespace primeGenerator
{
    class Program
    {
        private static System.Collections.Generic.IEnumerable<int> primeGen()
        {
            yield return 2;
            int number=2;
            int nextPrime=3;
            while(true)
            {
                while(number<nextPrime)
                {
                    if(nextPrime%number==0)
                    {
                        nextPrime++;
                        number=2;
                    }
                    number++;
                }
                yield return nextPrime;
                nextPrime++;
                number=2;
            }
        }
        static void Main(string[] args)
        {
            int max=10;
            int counter=1;
            foreach(var i in primeGen())
            {
                Console.WriteLine(i);
                counter++;
                if(counter>max)
                    break;
            }    
        }
    }
}
