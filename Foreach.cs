using System;

namespace Course
{
    class Foreach
    {
        static void Main(string[] args)
        {
            string[] vetores = { "RJ", "SP", "MG" };

            foreach (string vetor in vetores)
            {
                Console.WriteLine(vetor);
            }
        }
    }
}