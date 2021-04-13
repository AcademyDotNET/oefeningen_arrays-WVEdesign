using System;

//Leverbedrijf
class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        int[] postCodes = new int[] { 2000, 2640, 2610, 2600, 2240, 2160, 2100, 2040, 2020, 2018 };
        int inputPostcode;
        bool PostcodeOK;
        double[] prijsPerCodekg = new double[] { 5.25, 6.35, 8.00, 7.99, 5.50, 4.39, 8.25, 4.66, 6.99, 7.33 }; // prijs/kg, per postcode respectievelijk
        double inputGewicht;
        double outputPrijs;

        inputPostcode = PostcodeRequest(postCodes);
        PostcodeOK = PostcodeCheck(inputPostcode, postCodes);

        if (PostcodeOK == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error = de ingegeven postcode staat niet in onze databank waardoor er geen prijs berekend kan worden.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            inputGewicht = GewichtRequest();
            outputPrijs = CalculatePrice(inputGewicht, inputPostcode, postCodes, prijsPerCodekg);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Berekende Prijs: EUR {outputPrijs}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    private static double CalculatePrice(double inputGewicht, int inputPostcode, int[] postCodes, double[] prijsPerCodekg)
    {
        int indexPostcodes = Array.FindIndex(postCodes, item => item == inputPostcode);
        double outputPrijs = inputGewicht * prijsPerCodekg[indexPostcodes];
        return outputPrijs;
    }

    private static double GewichtRequest()
    {
        Console.Write("Voer het gewicht van uw pakketje in [kg]: ");
        double inputGewicht = Convert.ToDouble(Console.ReadLine());
        return inputGewicht;
    }

    private static bool PostcodeCheck(int inputPostcode, int[] postCodes)
    {
        int i;
        for (i = 0; i < postCodes.Length; i++)
        {
            if (postCodes[i] == inputPostcode)
                return true;
        }
        return false;
    }

    private static int PostcodeRequest(int[] postCodes)
    {
        Console.Write("Voer uw postcode in [2000, 2640, 2610, 2600, 2240, 2160, 2100, 2040, 2020, 2018]: ");
        int inputPostcode = Convert.ToInt32(Console.ReadLine());
        return inputPostcode;
    }
}