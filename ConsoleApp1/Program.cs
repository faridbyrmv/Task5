using System.ComponentModel.Design.Serialization;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static int ReadInt(string caption, string errorMessage)
            {
                var backupColor = Console.ForegroundColor;

            l1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(caption);
                Console.ForegroundColor = backupColor;

                string aStr = Console.ReadLine();

                bool state = int.TryParse(aStr, out int a);

                if (!state)
                {
                    if (!string.IsNullOrWhiteSpace(errorMessage))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errorMessage);
                        Console.ForegroundColor = backupColor;
                    }

                    goto l1;
                }

                return a;
            }

            // Misal - 1

            //Console.WriteLine("4 reqemli ededi daxil edin");

            //string DaxilOlunanEded = Console.ReadLine();

            //if (DaxilOlunanEded.Length == 4 && int.TryParse(DaxilOlunanEded, out int eded))

            //{
            //    string ededStr = eded.ToString();

            //    int cem = 0;

            //    for ( int i = 0; i < 4; i++ )
            //    {

            //        cem += int.Parse(ededStr[i].ToString());

            //    }

            //    Console.WriteLine($"Ededlerin cemi: " + cem);
            //}
            //else
            //{
            //    Console.WriteLine($"4 reqemli eded daxil olunmadi.");
            //}


            //===============================================

            // Misal - 2

            //Console.WriteLine("6 reqemli ededi daxil edin");

            //string DaxilOlunanEded = Console.ReadLine();

            //if (DaxilOlunanEded.Length == 6 && int.TryParse(DaxilOlunanEded, out int eded))
            //{
            //    string ededStr = eded.ToString();

            //    int cem = 0;

            //    for (int i = 0; i < 3; i++)
            //    {
            //        cem += int.Parse(ededStr[i].ToString());
            //    }
            //    Console.WriteLine($"ilk 3 ededin cemi: " + cem);

            //}
            //else
            //{
            //    Console.WriteLine("6 reqemli eded daxil olunmadi");
            //}

            //========================================================

            // Misal - 3 

            //Console.WriteLine("9 reqemli eded daxil edin");

            //string DaxilOlunanEded = Console.ReadLine();

            //if (DaxilOlunanEded.Length == 9 && long.TryParse(DaxilOlunanEded, out long eded))
            //{

            //    string ededStr = eded.ToString();

            //    int ortaIndex = ededStr.Length / 2;
            //    int cem = 0;

            //    for (int i = ortaIndex - 1; i <= ortaIndex + 1; i++)
            //    {
            //        cem += int.Parse(ededStr[i].ToString());

            //    }
            //    Console.WriteLine($"ortadaki 3 reqemin cemini topla: " + cem);

            //}
            //else
            //{
            //    Console.WriteLine($"9 reqemli eded daxil olunmadi.");
            //}

            //========================================================

            // Misal - 4

            //Console.WriteLine("5 reqemli eded daxil edin");

            //string DaxilOlunanEded = Console.ReadLine();

            //if (DaxilOlunanEded.Length == 5 && int.TryParse(DaxilOlunanEded, out int eded))
            //{

            //    string ededStr = eded.ToString();

            //    int ilkReqem = int.Parse(ededStr[0].ToString());
            //    int sonReqm = int.Parse(ededStr[4].ToString());
            //    int cem = ilkReqem + sonReqm;
            //    int kvadrat = cem * cem;

            //    Console.WriteLine($"ilk ve son reqemlerin ceminin kvadrati: " + kvadrat);
            //}
            //else
            //{
            //    Console.WriteLine($"5 reqemli eded daxil olunmadi.");
            //}

            //=================================================

            // Misal - 5

            //Console.WriteLine($"6 reqemli eded daxil edin.");

            //string DaxilOLunanEded = Console.ReadLine();

            //if (DaxilOLunanEded.Length == 6 && int.TryParse(DaxilOLunanEded, out int eded))
            //{

            //    int ilkReqem = eded / 100000;
            //    int tezeEded = eded * 10 + ilkReqem;

            //    Console.WriteLine($"Daxil olunan eded: " + tezeEded);
            //}
            //else
            //{
            //    Console.WriteLine($"6 reqmli eded daxil olunmadi.");
            //}

            //=================================================

            // Misal - 6 

            //Console.WriteLine($"8 reqemli eded daxil edin");

            //string DaxilOlunanEded = Console.ReadLine();

            //if (DaxilOlunanEded.Length == 8 && long.TryParse(DaxilOlunanEded, out long eded))
            //{

            //    int ortadakiReqemler = (int)(eded / 10 % 1000000);

            //    Console.WriteLine($"Ortadaki 6 reqem: " + ortadakiReqemler);
            //}
            //else
            //{
            //    Console.WriteLine($"8 reqemli eded daxil olunmadi");
            //}

            //=================================================

            // Misal - 7

            //    Console.WriteLine($"4 reqemli eded daxil edin.");

            //    string DaxilOlunanEded =Console.ReadLine();

            //    if (DaxilOlunanEded.Length == 4 && int.TryParse(DaxilOlunanEded, out int eded))
            //    {
            //        int tersEded = TersiniTap(eded);
            //        int tezeEded = tersEded * 10 + 8;

            //        Console.WriteLine($"Daxil olunan eded: " + tezeEded);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"4 reqemli eded daxil olunmadi.");
            //    }
            //}
            //static int TersiniTap(int eded)
            //{
            //    int tersEded = 0;
            //    while (eded > 0)
            //    {
            //        tersEded = tersEded * 10 + eded % 10;
            //        eded = eded / 10;
            //    }
            //    return tersEded;


            //=================================================

            // Misal - 8

            //Console.WriteLine($"Eded daxil edin");

            //string DaxilOlunanEded = Console.ReadLine();

            //if (long.TryParse(DaxilOlunanEded, out long eded))
            //{
            //    int axrinciEded = (int)(eded % 10);

            //    int sondanUcuncuEded = (int)((eded / 100) % 10);

            //    int cem = axrinciEded + sondanUcuncuEded;

            //    Console.WriteLine($"Axirdan 3. ve sonuncu reqemin cemi: " + cem);
            //}

            //else

            //{
            //    Console.WriteLine($"Eded daxil edilmeyib");
            //}


            //=================================================

            // Misal - 9 



            //    Console.WriteLine($"9 reqemli eded daxil edin");

            //    string DaxilOlunanEded = Console.ReadLine();

            //    if (DaxilOlunanEded.Length == 9 && long.TryParse(DaxilOlunanEded, out long eded))

            //    {
            //        long DuzelenEded = Duzelt(eded);

            //        Console.WriteLine($"Duzelen eded: " + DuzelenEded);

            //    }
            //    else
            //    {
            //        Console.WriteLine($"9 reqemli eded daxil olunmayib.");
            //    }

            //}

            //static long Duzelt(long eded)
            //{
            //    string ededStr = eded.ToString();
            //    string DuzelenEdedStr = ededStr[0].ToString();

            //    for (int i = 1; i < ededStr.Length; i++)
            //    {
            //        if (ededStr[i] != ededStr[i - 1])
            //        {
            //            DuzelenEdedStr += ededStr[i];
            //        }
            //    }
            //    return long.Parse(DuzelenEdedStr);


            // Misal - 10


            //    Console.WriteLine($"9 reqemli eded daxil et");

            //    string DaxilOLunanEded = Console.ReadLine();

            //    if (DaxilOLunanEded.Length == 9 && long.TryParse(DaxilOLunanEded, out long eded))
            //    {
            //        long TekYerdeDuzelenEded = Duzelt(eded, true);

            //        long CutYerdeDuzelenEded = Duzelt(eded, false);

            //        long cem = TekYerdeDuzelenEded + CutYerdeDuzelenEded;

            //        Console.WriteLine($"Tek yerde dayananlari birlesdirilmiw ededi: " + TekYerdeDuzelenEded);
            //        Console.WriteLine($"Cut yerde dayananlari birlesdirilmiw ededi: " + CutYerdeDuzelenEded);
            //        Console.WriteLine($"Cem: " + cem);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"9 reqemli eded daxil olunmayib");
            //    }

            //}
            //static long Duzelt(long eded, bool TekYerde)
            //{
            //    string ededStr = eded.ToString();
            //    string DuzelenEdedStr = "";

            //    for (int i = TekYerde ? 0 : 1; i < ededStr.Length; i += 2)
            //    {
            //        DuzelenEdedStr += ededStr[i];
            //    }

            //    return long.Parse(DuzelenEdedStr);


            // Misal - 11

            //Console.WriteLine($"8 reqemli eded daxil edin.");

            //string DaxilOLunanEded = Console.ReadLine();    

            //if (DaxilOLunanEded.Length == 8 && int.TryParse(DaxilOLunanEded, out int eded))
            //{
            //    int grup1 = (eded / 10000000) + ((eded / 1000)  % 1000);
            //    int grup2 = ((eded / 10000) % 100) + (eded % 1000);

            //    int cem = grup1 + grup2;

            //    int netice = (cem + 99) - (int)(cem * 0.18);

            //    Console.WriteLine($"Netice: " + netice);
            //}
            //else
            //{
            //    Console.WriteLine($"8 reqemli eded daxil olunmadi.");
            //}


            // Misal - 12 

            //Console.WriteLine($" I. 5 reqemli ededi daxil edin: ");
            //string eded1Str = Console.ReadLine();

            //Console.WriteLine($" II. 5 reqemli ededi daxil edin: ");
            //string eded2Str = Console.ReadLine();

            //if ( eded1Str.Length == 5 && eded2Str.Length == 5 && int.TryParse( eded1Str, out int eded1) && int.TryParse( eded2Str, out int eded2))
            //{
            //    int cemUs = (eded1 % 10) + ((eded1 / 10) % 10) + ((eded1 / 100) % 10) + ((eded1 / 1000) % 10) + (eded1 / 10000);
            //    double usCem = Math.Pow(cemUs, 2);

            //    int vurma = (eded2 % 10) * ((eded2 / 10) % 10) * ((eded2 / 100) % 10) * ((eded2 / 1000) % 10) * (eded2 / 10000);

            //    int netice = (int)(usCem + vurma);
            //    int neticeSonReqem = netice % 10;
            //    int eded1SonReqem = eded1 % 10;
            //    int tezeNetice = netice - neticeSonReqem + eded1SonReqem;

            //    Console.WriteLine($"Netice: " + tezeNetice);

            //}
            //else
            //{
            //    Console.WriteLine($"2 li 5 eded daxil edilmeyib. ");
            //}


            //    // Misal - 13


            //    Console.WriteLine($" I. 5 reqemli ededi daxil edin.");
            //    string eded1Str = Console.ReadLine();

            //    Console.WriteLine($" II. 5 reqemli ededi daxil edin. ");
            //    string eded2Str = Console.ReadLine();

            //    Console.WriteLine($" III. 5 reqemli ededi daxil edin. ");
            //    string eded3Str = Console.ReadLine();

            //    if ( eded1Str.Length == 5 && eded2Str.Length == 5 && eded3Str.Length == 5 && 
            //        int.TryParse( eded1Str, out int eded1) && int.TryParse( eded2Str, out int eded2) && int.TryParse( eded3Str, out int eded3) )
            //    {
            //        int duzelen1 = Duzelt(eded1);
            //        int duzelen2 = Duzelt(eded2);
            //        int duzelen3 = Duzelt(eded3);

            //        int cem = duzelen1 + duzelen2 + duzelen3;

            //        double yuzde50 = cem * 0.5;

            //        double finalNetice = yuzde50 + cem;

            //        Console.WriteLine($"Cem: " + finalNetice);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"3 lu 5 eded daxil olunmayib.");
            //    }
            //}

            //static int Duzelt(int eded)
            //{
            //    int ilkReqem = eded / 10000;
            //    int sonReqem = eded % 10;
            //    return ilkReqem + sonReqem;


            // Misal -14

            //Console.WriteLine($" I. 6 reqeli eded daxil edin: ");
            //string eded1Str = Console.ReadLine();

            //Console.WriteLine($" II. 6 reqemli ededi daxil edin: ");
            //string eded2Str = Console.ReadLine();

            //Console.WriteLine($" III. 6 reqemli ededi daxil edin: ");
            //string eded3Str = Console.ReadLine();

            //Console.WriteLine($" IV. 7 reqemli ededi daxil edin: ");
            //string eded4Str = Console.ReadLine();   

            //if (eded1Str.Length == 6 && eded2Str.Length == 6 && eded3Str.Length == 6 && eded4Str.Length == 7 &&
            //    long.TryParse(eded1Str, out long eded1) && long.TryParse(eded2Str, out long eded2) &&
            //    long.TryParse(eded3Str, out long eded3) && long.TryParse(eded4Str, out long eded4))
            //{

            //    int cem = (int)(eded1 / 1000) + (int)(eded2 / 1000) + (int)(eded3 / 1000);

            //    int sonReqemler = (int)(eded4 % 10000);
            //    cem += sonReqemler;

            //    long vurma = ((eded4 / 1000000) % 1000) * (((eded4 / 100000) % 10) * ((eded4/ 1000) % 10));
            //    int netice = cem - (int)vurma;

            //    double yuzde60 = netice * 0.6;
            //    double sonda = yuzde60 + 60;

            //    sonda -= netice * 0.18;

            //    Console.WriteLine($"Sonda: " + sonda);

            //}
            //else
            //{
            //    Console.WriteLine($" 4 eded daxil olunmadi.");
            //}



            // Misal - 15 


            int number1, number2,  //3reqemli
                number3, number4,  //6reqemli
                number5;           //7reqemli

        l2: 
            number1 = ReadInt("3 reqemli eded daxil et", null);

            if (number1 < 100 || number1 >= 1000)
            {
                goto l2;
            }


        l3: 
            number2 = ReadInt("II. 3reqemli eded daxil et", null);

            if (number2 < 100 || number2 >= 1000)
            {
                goto l3;
            }

        l4:
            number3 = ReadInt("6 reqemli eded daxil et", null);

            if (number3 < 100000 || number3 >= 1000000)
            {
                goto l4;
            }


        l5:
            number4 = ReadInt("II. 6reqemli eded daxil et", null);

            if (number4 < 100000 || number4 >= 1000000)
            {
                goto l5;
            }


        l6:
            number5 = ReadInt("7 reqemli eded daxil et", null);

            if (number5 < 1000000 || number5 >= 10000000)
            {
                goto l6;
            }
            
            long sumOfNum1AndNum2 = number1 + number2;

            sumOfNum1AndNum2 %= 100;

            sumOfNum1AndNum2 = Convert.ToInt32(Math.Pow(sumOfNum1AndNum2, 2));

            long joinNum1AndNum2 = number1 * 1000 + number2 + sumOfNum1AndNum2;

            joinNum1AndNum2 -= (number5 % 100000);

            long sumOfNum3AndNum4 = number3 + number4;

            sumOfNum3AndNum4 %= 1000;
            joinNum1AndNum2 += sumOfNum3AndNum4;

            long reverseForNum5 = RevereNumber(SumOfDigit(number5));

            joinNum1AndNum2 += reverseForNum5;

            joinNum1AndNum2 = joinNum1AndNum2 * 100 + 11;

            long oddPlaceNumber = GetNumberFromOdd(number5) - joinNum1AndNum2;

            oddPlaceNumber = ((oddPlaceNumber / 100) * 100 + 88) *10 + oddPlaceNumber % 10;

            Console.WriteLine( oddPlaceNumber );

        }

        static long SumOfDigit(long value)
        {
            long sum = 0;

            while (value > 0)
            {
                sum += value % 10;

                value /= 10;
            }
            return sum;
        }

        static long RevereNumber(long value)
        {
            long reverse = 0;

            while (value > 0)
            {
                reverse = reverse * 10 + (value % 10);

                value /= 10;
            }
            return reverse;
        }
        static long GetNumberFromOdd(long number)
        {
            long step = 1;
            long newNumberOdd = 0;

            while (number > 0)
            {
                newNumberOdd = step * (number % 10) + newNumberOdd;
                step += 10;
                number /= 100;

            }

            return newNumberOdd;
        }

    }
}