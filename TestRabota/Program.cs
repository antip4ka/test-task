using System;

namespace TestRabota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X1");
            double X1 = Convert.ToDouble(Console.ReadLine());
            
                       Console.WriteLine("Введите Y1");
                       double Y1 = Convert.ToDouble(Console.ReadLine());
            

            double[] proc = new double[11];
            proc[0] = -0.5;
            double[] Z = new double[11];
            double[] A = new double[200];
            A[0] = -100;
            double[] B = new double[200];
            B[0] = -100;


            for (int i = 1; i < proc.Length; i++)
            {
                proc[i] = proc[i - 1] + 0.1;
            }


            for (int h = 0; h < proc.Length; h++)
            {
                Z[h] = (Y1 * (proc[h] + 100)) / (-100);
            }


            for (int j = 1; j < A.Length; j++)
            {
                A[j] = A[j - 1] + 1;
            }


            for (int g = 1; g < B.Length; g++)
            {
                B[g] = B[g - 1] + 1;
            }
                    
                
            

            foreach (double a in A)
            {
                foreach (double b in B)
                {
                    foreach (double z in Z)
                    {
                        if ((a + X1) * b == z)
                        {
                            Console.WriteLine(a + " " + b);
                        }

                    }
                }
            }
            
            Console.ReadLine();
        }
    }
}
