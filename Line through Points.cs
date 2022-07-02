using System;
class GFG {

    public class Pair {
        public int first, second;
 
        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
    }
 
    static void lineFromPoints(Pair A, Pair B)
    {
        int a = A.second - B.second;
        int b = A.first - B.first;
        int c = a * (A.first) + b * (B.second);
 
        if (b < 0) {
            Console.WriteLine(
                "The line passing through points A and B is: "
                + a + "x - " + b + "y = " + c);
        }
        else {
            Console.WriteLine(
                "The line passing through points A and B is: "
                + a + "x + " + b + "y = " + c);
        }
    }
 
    public static void Main(String[] args)
    {
        // Enter your pairs of points here
        Pair A = new Pair(4, 5);
        Pair B = new Pair(2, 3);
        lineFromPoints(A, B);
    }
}
