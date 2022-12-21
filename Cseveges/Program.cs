using System.Threading.Tasks;

namespace Cseveges
{
    internal class Program
    {
        static List<Beszelgetes> BeszelgetesList = new();
        static List<string> TagokList = new();
        static void Main(string[] args)
        {
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
        }

        private static void Feladat8()
        {
            Console.WriteLine($"8. Feladat: Leghosszabb csendes időszak 15h-tól");
            DateTime maximumCsendKezd = new DateTime(2021, 9, 27, 15, 0, 0);
            DateTime maximumCsendVeg = BeszelgetesList[0].Kezdet;
            TimeSpan maximumCsendHossz = maximumCsendVeg - maximumCsendKezd;
            DateTime jeleCsendVege = BeszelgetesList[0].Veg;

            foreach (var item in BeszelgetesList)
            {
                if (item.Kezdet > jeleCsendVege)  
                {
                    TimeSpan aktCsendHossz = item.Kezdet - jeleCsendVege;
                    if (aktCsendHossz > maximumCsendHossz)
                    {
                        maximumCsendHossz = aktCsendHossz;
                        maximumCsendKezd = jeleCsendVege;
                        maximumCsendVeg = item.Kezdet;
                    }
                }
                if (item.Veg > jeleCsendVege)
                { 
                    jeleCsendVege = item.Veg; 
                }

            }
            Console.WriteLine($"\tKezdete: {maximumCsendKezd.ToString("yy.MM.dd-HH:mm:ss")}");
            Console.WriteLine($"\tVége: {maximumCsendVeg.ToString("yy.MM.dd-HH:mm:ss")}");
            Console.WriteLine($"\tHossza: {maximumCsendHossz}");
        }

        private static void Feladat7()
        {
            Console.WriteLine($"7. feladat: Nem beszélgettek senkivel");
            List<string> nemBeszelgetotagok = new List<string>();
            foreach (var tag in TagokList)
            {
                bool talalt = false;
                foreach (var beszelgetes in BeszelgetesList)
                {
                    if (beszelgetes.Kezdemenyezo == tag || beszelgetes.Fogado == tag)
                    {
                        talalt = true;
                        break;
                    }
                }

                if (!talalt)
                {
                    nemBeszelgetotagok.Add(tag);
                }
            }

            foreach (var item in nemBeszelgetotagok)
            {
                Console.WriteLine($"\t {item}");
            }
        }

        private static void Feladat6()
        {
            Console.Write($"6. feladat: Adja meg egy tag nevét: ");
            string Nev = Console.ReadLine();
            TimeSpan ÖsszesIdo = new TimeSpan();
            foreach (var item in BeszelgetesList)
            {
                if (item.Fogado == Nev || item.Kezdemenyezo == Nev)
                {
                    ÖsszesIdo += item.osszIdo;
                }
            }
            Console.WriteLine($"\tA beszélgetések összes ideje: {ÖsszesIdo}");
        }

        private static void Feladat5()
        {
            Console.WriteLine($"5. feladat: Leghosszabb beszélgetés");

            Beszelgetes MaxBeszelgetes = BeszelgetesList[0];
            foreach (var item in BeszelgetesList)
            {
                if (item.osszIdo > MaxBeszelgetes.osszIdo)
                {
                    MaxBeszelgetes = item;
                }
            }
            Console.WriteLine($"\tKezdeményező: {MaxBeszelgetes.Kezdemenyezo}\n\tFogadó: {MaxBeszelgetes.Fogado}\n\tKezdete: {MaxBeszelgetes.Kezdet}\n\tVége: {MaxBeszelgetes.Veg}\n\tHossz: {MaxBeszelgetes.osszIdo.TotalSeconds} mp");
        }

        private static void Feladat4()
        {
            Console.WriteLine($"4. feladat: Tagok száma: {TagokList.Count} fő - Beszélgetések: {BeszelgetesList.Count} db"); 
        }

        private static void Feladat3()
        {
            using StreamReader sr = new(@"csevegesek.txt");
            _ = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                BeszelgetesList.Add(new Beszelgetes(sr.ReadLine()));
            }

            using StreamReader sr2 = new(@"tagok.txt");
            while (!sr2.EndOfStream)
            {
                TagokList.Add(sr2.ReadLine());
            }
        }
    }
}