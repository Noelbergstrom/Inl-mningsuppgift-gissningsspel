Random r = new Random();
int val = r.Next(1, 100);
bool rätt = false;
int räknare = 0;

Console.WriteLine("Jag tänker på ett nummer mellan 0-100, gissa vilket");

while (!rätt)
{
    int gissning = int.Parse(Console.ReadLine());

    if (gissning < val)
    {
        Console.WriteLine("Ditt tal är mindre än datorns tal, gissa igen");
        räknare += 1;
    }
    else if (gissning > val)
    {
        Console.WriteLine("Ditt tal är större än datorns tal, gissa igen");
        räknare += 1;
    }
    else
    {
        rätt = true;
        Console.WriteLine("Du gissade rätt! " + "Du gissade " + räknare + " gånger");
    }
}