using MyGeometry;

Console.WriteLine("Inserisci la base del rettangolo:");
int baseRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci l'altezza del rettangolo:");
int altezzaRettangolo = int.Parse(Console.ReadLine());

 Rettangolo geometria= new Rettangolo(baseRettangolo, altezzaRettangolo );

geometria.calcolaPerimetro();
geometria.calcolaArea();
geometria.StampaRettangolo();

geometria.Disegna();