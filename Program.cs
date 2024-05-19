internal class Program
{
    private static void Main(string[] args)
    {
        //whileDongusuOrnegi();
        //whileDongusuOrnegi2();
        //WhileDongusuOrnegi3();
        //whileDongusuOrnegi4();
        //doWhileDongusuOrnegi();
        //forDongosuOrnegi();
        //forDongusuOrnegi2();
        //forDongusuOrnegi3();
        //forDongusuOrnegi4();
        //continueOrnegi();
        //breakOrnegi();
        //icIceForOrnegi();
        //icIceForOrnegi2();


        Console.ReadKey();

    }

    private static void icIceForOrnegi2()
    {
        Console.WriteLine("Bir sayı girin:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("  *  ");
            }
            Console.WriteLine();
        }

        for (int i = n; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {
                Console.Write("  *  ");

            }
            Console.WriteLine();
        }
    }

    private static void icIceForOrnegi()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0},{1}   ", i, j);
            }
            Console.WriteLine();

        }
        int m = 5;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*  ");
            }
            Console.WriteLine();
        }
    }

    private static void breakOrnegi()
    {
        Console.WriteLine("Bir sayı girin:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bir sayı daha girin:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Şimdi sayıları yazıyorum");
        for (int i = a; i < b; i++)
        {
            if (i == 100)
                break;
            Console.WriteLine(i);
        }
        Console.WriteLine("büyük sayı kaç olursa olsun 100 den fazlasını dikkate almaz.");
        Console.WriteLine("çıkmak için bir tuşa iki kez basın.");
    }

    private static void continueOrnegi()
    {
        for (int i = 0; i <= 10; i++)
        {
            if (i % 3 == 0) //eğer i sayısının değeri 3 veya 3 ün katı ise
            {
                continue; //yazmadan devam et
            }
            Console.Write("{0,3}", i);
        }
    }

    private static void forDongusuOrnegi4()
    {
        Console.WriteLine("Bir sayı girin:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bir sayı daha girin:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Şimdi sayıları yazıyorum");
        for (int i = a; i < b; i++)
        {

            Console.WriteLine(i);
        }
        Console.WriteLine("çıkmak için bir tuşa iki kez basın.");
    }

    private static void forDongusuOrnegi3()
    {
        Console.WriteLine("Sayı   Karesi");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0,3}...{1,3}", i, i * i);
        }
    }

    private static void forDongusuOrnegi2()
    {
        for (int i = 100; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }

    private static void forDongosuOrnegi()
    {
        for (int i = 0; i < 100; i += 5)
        {
            Console.WriteLine("{0}", i); //Console.WriteLine(i); aynı şekilde çalışsır
        }
       
    }

    private static void doWhileDongusuOrnegi()
    {
        Console.WriteLine("Bir sayı girin");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        do
        {
            //Console.Writeline(i); 
            Console.Write("{0,-3}",i); //benzerşekilde çalışır
            i += 2;
        } while (i < n);
        
    }

    private static void whileDongusuOrnegi4()
    {
        Console.WriteLine("Sayı   Karesi");
        int i = 10;
        while (0 < i)
        {
            Console.WriteLine("{0,-3}... {1,-3}", i, i * i);
            i--;
        }
    }

    private static void WhileDongusuOrnegi3()
    {
        Console.WriteLine("Sayı   Karesi");
        int i = 0;
        while (i <= 10)
        {
            Console.WriteLine("{0,-3}... {1,-3}", i, i * i);
            i++;
        }
    }

    private static void whileDongusuOrnegi2()
    {
        int i = 0;
        while (i <= 10)
        {
            Console.Write("{0,-3}", i);//{0,-3} yapısı çıktıların sola yaslı yazılıp aralarında 3 
            //karakter boşluk olarak yazılmasını sağlıyor.0 sayaç için -3 boşluk karakteri için
            i++;
        }
    }

    private static void whileDongusuOrnegi()
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.WriteLine("Dögü sonu");
    }
}