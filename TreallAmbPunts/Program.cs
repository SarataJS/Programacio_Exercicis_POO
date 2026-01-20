using Geometria;
namespace TreallAmbPunts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            Punt2D gruix = new Punt2D();
            Punt2D p1 = new Punt2D(1, 3);
            Console.WriteLine(p1.ToString());
            p1.Desplaça(6, -2);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.X);
            p1.X = 22;
            //p1.x = 999;
            Punt2D p2 = new Punt2D();
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Punt2D y = new Punt2D();
            int[] taulaDeNumeros = new int[N];
            for (int i = 0; i < taulaDeNumeros.Length; i++)
            {
                taulaDeNumeros[i] = i;
            }
            Punt2D[] taulaDePunts=new Punt2D[N];
            for (int i=0; i< taulaDePunts.Length; i++)
            {
                taulaDePunts[i] = new Punt2D(i + 1, i + 1);
                Console.WriteLine(taulaDePunts[i].ToString());
            }
            
        }
    }
}
