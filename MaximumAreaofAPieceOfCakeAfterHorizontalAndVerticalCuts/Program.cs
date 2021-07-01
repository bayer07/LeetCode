using System.Linq;

namespace MaximumAreaofAPieceOfCakeAfterHorizontalAndVerticalCuts
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = MaxArea(5, 4, new[] {1, 2, 4}, new[] {1, 3});
            int b = MaxArea(5, 4, new[] {3, 1}, new[] {1});
            int c = MaxArea(5, 4, new[] {3}, new[] {3});
            int d = MaxArea(1000000000, 1000000000, new[] {2}, new[] {2});
        }

        private static void Max(int cut, int prev, ref int max)
        {
            int dif = cut - prev;
            if (dif > max)
            {
                max = dif;
            }
        }

        private static int Max(int size, int[] cuts)
        {
            int max = 0;
            int prev = 0;
            foreach (var cut in cuts)
            {
                Max(cut, prev, ref max);
                prev = cut;
            }

            Max(size, prev, ref max);
            return max;
        }

        public static int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            int maxH = Max(h, horizontalCuts.OrderBy(x => x).ToArray());
            int maxV = Max(w, verticalCuts.OrderBy(x => x).ToArray());

            return maxH * maxV;
        }
    }
}