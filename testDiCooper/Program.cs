float velocitaMedia,tempo=12.0f/60.0f, distanza;
Console.WriteLine("Inserisci la distanza percorsa (in m):");
distanza=Convert.ToInt16(Console.ReadLine());
velocitaMedia = (distanza / 1000) / tempo;
if (velocitaMedia < 8)
{
    Console.WriteLine("prestazione da migliorare");
}
else if (velocitaMedia>= 8 && velocitaMedia <= 12)
{
    Console.WriteLine("prestazione nella media");
}
else if (velocitaMedia > 12)
{
    Console.WriteLine("prestazione eccellente");
}





