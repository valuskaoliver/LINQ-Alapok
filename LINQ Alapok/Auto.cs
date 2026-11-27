using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Alapok
{
    internal class Auto
    {
        public string Rendszam { get; set; }
        public string Tipus { get; set; }
        public string Kategoria { get; set; }
        public int NapiDij { get; set; }
        public int FutottKm { get; set; }

        public Auto (string sor)
        {
            var adatok = sor.Split(';');
            Rendszam = adatok[0];
            Tipus = adatok[1];
            Kategoria = adatok[2];
            NapiDij = int.Parse(adatok[4]);
            FutottKm = int.Parse(adatok[5]);
        }

        public int BerlesiDijKalkulator(int napokSzama)
        {
            if (napokSzama >= 7)
            {
                return (int)(NapiDij * napokSzama * 0.9);
            }
            else return NapiDij * napokSzama;
        }

        public bool KategoriaEgyezik(string keresettKategoria)
        {
            return Kategoria.ToLower() == keresettKategoria.ToLower();
        }

        public override string ToString()
        {
            return $"[{Rendszam}] {Tipus}({Kategoria}) - Napi díj: {NapiDij} Ft | Futottkm: {FutottKm} km";
        }
    }
}
