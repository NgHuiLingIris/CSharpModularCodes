namespace MatrixMultiplication
{
    class H10
    {
        static void Main()
        {
            int[,] X = new int[,] { {1,2 },{3,4 } ,{ 5, 6 } };
            int[,] Y = new int[,] { {1,3,5,7},{ 2,4,6,8} };
            int[,] Z = new int[X.GetLength(0), Y.GetLength(1)];
            int a = 0, b = 0, c = 0;
            for (c = 0;c<Y.GetLength(1);c++)
            {
                for(a=0;a<X.GetLength(0);a++)
                {
                    for(b=0;b<Y.GetLength(0);b++)
                    {
                        Z[a, c] = Z[a, c] + (X[a, b] * Y[b, c]);
                    }
                }
            }
            PrintArray(Z);
        }
        static void PrintArray(int[,] A)
        {
            for (int j = 0; j < A.GetLength(0); j++)
            {
                Console.Write("{");
                for (int i = 0; i < A.GetLength(1); i++)
                {
                    Console.Write(A[j, i] + "\t");
                }
                Console.WriteLine("}");
                
            }
        }
    }
}
