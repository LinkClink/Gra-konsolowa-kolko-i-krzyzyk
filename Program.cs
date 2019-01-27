/// bY LinkClink ver 0.3
using System;
using System.Threading;
namespace OX
{  
    class Program
    {
 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void Main() //fun gl
        {
            int lg = 0; string xo = "X";
            int ff = 0, win = 0;
            string[] grace = { "peirwszy", "drugi" };
            string[] b = { "_", "_", "_", "_", "_", "_", "_", "_", "_", "_",};
            Program pr = new Program(); // dla odn 
            Console.WriteLine("Gra kolko krzyzyk 0.3 " + "1-jednoosobowy 2-dwychosobowy");
            Console.WriteLine("Podaj tryb grania: ");
            String tryb = Console.ReadLine();
            if(tryb=="2")
            {
                Console.Clear();
                Console.WriteLine("Wybrales tryb dwuosobowy");
                pr.wyd(b,grace,lg,ff,xo,tryb,win); // odniesienie do fun tr2
            }
            if (tryb == "1")
            {
                Console.Clear();
                Console.WriteLine("Wybrales tryb jedno");
                grace[1] = "komputer";
                pr.wyd(b,grace, lg, ff,xo,tryb,win); // odniesienie do fun tr2
            }
            Console.ReadKey();
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void wyd(string[] b,string[] g,int lg,int ff,string xo,string tryb,int win ) // funkcja wydrukowania i wpis, oraz komputera
        {   int a1 = 0; 
            String miejsce ; Program pr = new Program();
            Console.Clear();
            Console.WriteLine("Chodze grac " + g[lg]);
            Console.WriteLine("-------["+b[1]+ "]-------[" + b[2] + "]-------[" + b[3] + "]-------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------[" + b[4] + "]-------[" + b[5] + "]-------[" + b[6] + "]-------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------[" + b[7] + "]-------[" + b[8] + "]-------[" + b[9] + "]-------");
            if (win == 1) { Thread.Sleep(2000); System.Environment.Exit(1); }
            Console.WriteLine("Wpisz miejsce od 1 do 9: ");
            Console.WriteLine("Wpisz "+ xo);
            if (tryb == "1" && xo == "O")
            {
                pr.kom(b, g, lg, ff, xo, tryb, win);
            }
            else {
                miejsce = Console.ReadLine(); 
                a1 = Int32.Parse(miejsce);
                pr.wp(b, g, lg, ff, xo, tryb, win,a1);
                 }              
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void spr(string[] b, string[] g, int lg, int ff, string xo, string tryb, int win) // funkcja sprawdzania wyn
        {
                Program pr = new Program();
                int f1 = 1, f2 = 2, f3 = 3, gracw = 0; string[] c = { "X", "O" };
                for (int s = 0; s < 2; s++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (b[f1] == c[gracw] && b[f2] == c[gracw] && b[f3] == c[gracw]) // sprawdzania -->
                        {
                            b[f1] = "."; b[f2] = "."; b[f3] = ".";
                            Console.WriteLine("Wygral grac:" + g[gracw]);
                            Thread.Sleep(2000);
                            win = 1;
                            pr.spr(b, g, lg, ff, xo, tryb, win);
                        }
                        f1 += 3; f2 += 3; f3 += 3;
                    }
                    f1 = 1; f2 = 2; f3 = 3;
                    gracw = 1;
                }
                f1 = 1; f2 = 4; ; f3 = 7; gracw = 0;
                for (int s = 0; s < 2; s++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (b[f1] == c[gracw] && b[f2] == c[gracw] && b[f3] == c[gracw]) // sprawdzania |
                    {
                            b[f1] = "."; b[f2] = "."; b[f3] = ".";
                            Console.WriteLine("Wygral grac:" + g[gracw]);
                            Thread.Sleep(2000);
                            win = 1;
                            pr.spr(b, g, lg, ff, xo, tryb, win);
                        }
                        f1 += 1; f2 += 1; f3 += 1;
                    }
                    f1 = 1; f2 = 4; f3 = 7;
                    gracw = 1;
                }
                f1 = 1; f2 = 5; ; f3 = 9; gracw = 0;
                for (int s = 0; s < 2; s++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (b[f1] == c[gracw] && b[f2] == c[gracw] && b[f3] == c[gracw])  // sprawdzania \
                        {
                            b[f1] = "."; b[f2] = "."; b[f3] = ".";
                            Console.WriteLine("Wygral grac:" + g[gracw]);
                            Thread.Sleep(2000);
                            win = 1;
                            pr.spr(b, g, lg, ff, xo, tryb, win);
                        }
                        f1 = 3; f2 = 5; f3 = 7;
                    }
                    f1 = 1; f2 = 4; f3 = 9;
                    gracw = 1;
                }       
            pr.wyd(b, g, lg, ff, xo, tryb, win);
        }
 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public  void kom(string[] b, string[] g, int lg, int ff, string xo, string tryb, int win) //funkcja chodzenia komputera
        {
            Program pr = new Program();
            int a1 = 0;
            Random rnd = new Random();
            int ck = rnd.Next(1, 9);
            Console.WriteLine("Chodze komputer:");
            Thread.Sleep(1000);
            Console.WriteLine(ck);
            Thread.Sleep(500);
            a1 = ck;
            pr.wp(b, g, lg, ff, xo, tryb, win,a1);
        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void wp(string[] b, string[] g, int lg, int ff, string xo, string tryb, int win,int a1) //funkcja wpisewania
        {   Program pr = new Program();
            for (int i = 1; i < 10; i++) // wpisywania do tab
            {
                if (i == a1)
                {
                    if (b[i] == "_")
                    {
                        if (xo == "o" || xo == "O")
                        {
                            b[i] = "O";
                            xo = "X";
                        }
                        else
                        {
                            b[i] = "X";
                            xo = "O";
                        }
                        if (lg == 0)
                        {
                            lg++;
                        }
                        else lg--;
                        ff++;
                    }
                    else
                    {
                        Console.WriteLine("Error:Zajeto");
                        Thread.Sleep(2000);
                        break;
                    }
                }
            }
            if (ff >= 3)
                pr.spr(b, g, lg, ff, xo, tryb, win);
            else pr.wyd(b, g, lg, ff, xo, tryb, win);
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }  
}
