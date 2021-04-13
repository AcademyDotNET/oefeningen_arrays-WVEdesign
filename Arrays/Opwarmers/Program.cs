using System;

//Opwarmers
class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        Console.WriteLine("Opwarmer1: Array gevuld met de getallen 0 tot 100:");
        NulTotHonderd();

        Console.WriteLine("\n\nOpwarmer2: Array gevuld met de getallen 100 tot 1:");
        HonderdTotNul();

        Console.WriteLine("\n\nOpwarmer3: Array gevuld met de letters a tot z:");
        ATotZ();

        Console.WriteLine("\n\nOpwarmer4: Array gevuld met willekeurige getallen tussen 1 en 100 (de array is 20 lang):");
        Random20();

        Console.WriteLine("\n\nOpwarmer5: Array gevuld met afwisselend true en false (de array is 30 lang):");
        RandomTrueFalse();

        

        Console.ForegroundColor = ConsoleColor.Gray;
    }



    private static void NulTotHonderd()
    {
        const int MAX_SIZE = 100;
        int[] hundredARRAY = new int[MAX_SIZE];
        for(int i=0;i< MAX_SIZE; i++)
        {
            hundredARRAY[i] = i;
            Console.Write($"{i}, ");
        }
    }
    private static void HonderdTotNul()
    {
        const int MAX_SIZE = 100;
        int[] hundredARRAY = new int[MAX_SIZE];
        for (int i = MAX_SIZE; i > 0 ; i--)
        {
            hundredARRAY[i-1] = i;
            Console.Write($"{i}, ");
        }
        for (int i = 0; i < MAX_SIZE; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{i}, ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    private static void ATotZ()
    {
        const int MAX_SIZE = 26;
        char[] alpha = new char[MAX_SIZE];
        for (int i = 0; i < MAX_SIZE; i++)
        {
            alpha[i] = (char)(97+i);                // voor hoofdletters starten bij 65 ipv 97
            Console.Write($"{alpha[i]}, ");
        }
    }
    private static void Random20()
    {
        Random rnd_Num = new Random();
        const int MAX_SIZE = 20;
        int[] hundredARRAY = new int[MAX_SIZE];
        for (int i = 0; i < MAX_SIZE; i++)
        {
            hundredARRAY[i] = rnd_Num.Next(0, 100);
            Console.Write($"{hundredARRAY[i]}, ");
        }
    }
    private static void RandomTrueFalse()
    {
        bool toggleBool = true;
        const int MAX_SIZE = 30;
        bool[] hundredARRAY = new bool[MAX_SIZE];
        for (int i = 0; i < MAX_SIZE; i++)
        {
            hundredARRAY[i] = toggleBool;
            Console.Write($"{hundredARRAY[i]}, ");

            if (toggleBool == true)
            {
                toggleBool = false;
            }
            else
            {
                toggleBool = true;
            }
        }
    }
}