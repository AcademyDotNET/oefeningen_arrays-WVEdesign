/*
Ontwerp een consoletoepassing waarmee je een wachtwoord genereert voor een gebruiker. Het wachtwoord is opgebouwd uit:

de 2 eerste letters van de familienaam: de 1ste letter is een hoofdletter, de 2de letter is een kleine letter. 
Daarna worden de 2 letters gewisseld; het zonenummer van het telefoonnummer zonder de 0; het eerste cijfer van de postcode in het kwadraat.

Gebruik de ToCharArray() methode die je op een string kunt toepassen, zoals hier getoond: char[] chars = myEpicName.ToCharArray();

                                                   VeeV34         Ve-rhoeven   + neveohr-eV + 0-3/ + postcode in kwadraat 2-000 4  
 
Geef uw familienaam in. Verhoeven

Geef uw zone nummer in (bv: Antwerpen; 03)

Geef uw postcode in. 2000

https://docs.microsoft.com/en-us/dotnet/api/system.string.tochararray?view=net-5.0

 https://docs.microsoft.com/en-us/dotnet/api/system.string.tolower?view=net-5.0
 */

using System;
// namespace PRO_Password_Generator



class Program
{
    public static void Main()
    {
        int postcode = GetPostcode();
        string zoneNumberString = GetZoneNumber();
        
        string familyName = GetFamilyname();

        string Password = MakePassword(familyName, zoneNumberString, postcode);

        
        

        Console.WriteLine($"Postcode: {postcode}, Zone nummer: {zoneNumberString}, Naam: {familyName}, Password: {Password}");
      

    }

    private static string MakePassword(string familyName, string zoneNumberString, int postcode)
    {
        int zoneNumber = Convert.ToInt32(zoneNumberString);


        string password = Reverse(familyName + zoneNumberString);
        return password;
    }

    private static string Reverse(string text)
    {
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }

    private static int GetPostcode()
    {
        Console.WriteLine("Please enter your postcode: ");
        int postcode = int.Parse(Console.ReadLine());
        return postcode;
    }

    private static string GetZoneNumber()
    {
        Console.WriteLine("Please enter your zoneNumber: ");
        string zoneNumber = Console.ReadLine();
        return zoneNumber;
    }

    private static string GetFamilyname()
    {
        Console.WriteLine("Please enter your Family name: ");
        string name = Console.ReadLine();
        return name;
    }

   
}