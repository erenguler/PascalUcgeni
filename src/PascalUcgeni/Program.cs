using System;

namespace PascalUcgeni
{
    class Program
    {
        //     1             o anki satırın o anki elemanı 
        //    1 1                         =
        //   1 2 1       bir önceki satırın bir önceki elemanı
        //  1 3 3 1                       +     
        // 1 4 6 4 1       bir önceki satırın o anki elemanı

        static void Main()
        {
            int satir = 13;

            for (int i = 1; i <= satir; i++)
            {
                // satırbaşı boşluklarını bırak
                for (int k = 1; k <= satir - i; k++)
                    Console.Write("{0,3}", " ");

                // o satırdaki sayıları yaz
                for (int j = 1; j <= i; j++)
                    Console.Write("{0,3}{1,3}", Pascal(i, j).ToString(), " ");

                // alt satıra geç
                Console.WriteLine();
            }
        }

        // a --> satır
        // b --> sütun
        public static int Pascal(int a, int b)
        {
            if (a == 1)     // ilk satır ise --> 1 
                return 1;
            if (b == 1)     // satırın ilk elemanı ise --> 1 
                return 1;
            if (a == b)     // satırın son elemanı ise --> 1 
                return 1;

            return Pascal(a - 1, b - 1) + Pascal(a - 1, b);
        }

    }
}
