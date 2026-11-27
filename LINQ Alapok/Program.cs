using LINQ_Alapok;

List<Auto> autok = new List<Auto>();

if (File.Exists("Autok.txt"))
{
    foreach(string sor in File.ReadLines("Autok.txt"))
    {
        if (!string.IsNullOrWhiteSpace(sor))
        {
            Auto auto = new Auto(sor);
            autok.Add(auto);
            Console.WriteLine(auto);
        }
    }
}
int osszKm = autok.Sum(a => a.FutottKm);
double atlag = autok.Average(a => a.NapiDij);
int legkevesebbKm = autok.Min(a => a.FutottKm);
int legdragabbDij = autok.Max(a => a.NapiDij);
int teherDB = autok.Count(a => a.KategoriaEgyezik("teherautó"));
bool vanOlcso = autok.Any(a => a.NapiDij <10000);

Console.WriteLine($"Összes megtett kilométer: {osszKm} km");
Console.WriteLine($"Átlagos napi bérleti díj: {atlag} Ft");
Console.WriteLine($"Legkevesebb futott kilométer: {legkevesebbKm} km");
Console.WriteLine($"Legmagasabb napi bérleti díj: {legdragabbDij} Ft");
Console.WriteLine($"Teherautók száma a flottában: {teherDB} db");
Console.WriteLine($"Van 10 000 Ft alatti napi díjú autó? {(vanOlcso ? "igen" : "Nem")}");
