using System;

namespace Metode_opg_1._1_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kunne ikke få try catch til at virke så der kommer ingen fejlmeddelser - øver mig videre!

            /*1.	Indtast 2 heltal i konsollen og: 
                    - Adder tallene
                    - Divider ta1 med tal2(både heltals og floating point division hvis brugeren har indtastet heltal)
                    - Undersøg hvor mange gange går op i(moduls)
                    -Opløft tal1 i tal2 potens*/

            int tal1 = GetTal("Indtast det første tal");//Metodekald, sender en string med

            int tal2 = GetTal("Indtast det andet tal");//metodekald, sender en string med
            
            Console.WriteLine("Resultatet af {0} + {1} = " + GetSum(tal1, tal2), tal1, tal2);
            
            Console.WriteLine("Resultatet af {0} / {1} = " + Math.Round(GetDivision(tal1, tal2), 2), tal1, tal2); //udskrift med metodekald


            Console.WriteLine("Ved heltalsdivision er der en rest på " + GårOpI(tal1, tal2));

            Console.WriteLine("Resultatet af {0} opløftet til {1} = " + GetPotens(tal1, tal2), tal1, tal2); //udskrift med metodekald

            Console.ReadKey();
        }
        public static int GetTal(string question)
        {
            Console.WriteLine(question);
            int tal = int.Parse(Console.ReadLine());//erklærer en variabel og tildeler den brugerens indtastning (konverteret)
            return tal; //sender tallet tilbage så der kan regnes med det

        }
        public static int GetSum(int tal1, int tal2)
        {
            return tal1 + tal2;
        }
        //Opretter metode med returværdi, sender brugerens indtastninger med ved metodekald
        public static float GetDivision(int tal1, int tal2)
        {
            float resultat = (float)tal1 / (float)tal2;/*overloader så int ses som en float for at få decimaltal på ved division
                                                        * hvor resultatet ikke nødvendigvis er et helt tal*/
            return resultat; //sender resultatet retur

        }
        //Opretter metoder til at finde ud af hvor mange gange tallet går op i
        public static int GårOpI(int tal1, int tal2)
        {
            int antalGangegårOpI = tal1 / tal2;
            int rest = tal1 % tal2;
            return rest;

            
        }
        public static double GetPotens(int tal1, int tal2)
        {
            double resultat = Math.Pow(tal1, tal2); //bruger Math.Pow (metode fra Math class indbygget i C#)
            return resultat;

        }
    }
}
