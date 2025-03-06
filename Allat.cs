using System.ComponentModel;

namespace MikesKrisztian_allatkert;

internal class Allat
{
    private string nev;
    private readonly string faj;
    private readonly string elohely;
    private readonly int sebesseg;

    public string Nev { get => nev; set => nev = value; }
    public int Sebesseg { get => sebesseg; }

    public Allat(string nev, string faj, string elohely, int sebesseg)
    {
        this.nev = nev;
        this.faj = faj;

        this.elohely = elohely;
        this.sebesseg = sebesseg;
    }

    public override string? ToString()
    {
        return $"Név: {nev}, Faj: {faj}, Élőhely: {elohely}, Sebesség: {sebesseg} km/h,";
    }

}

internal class ViziAllat(string nev, string faj, int sebesseg) : Allat(nev, faj, "Viz", sebesseg)
{ }
internal class RepuloAllat(string nev, string faj, int sebesseg) : Allat(nev, faj, "Levego", sebesseg)
{ }
internal class SzarazfoldiAllat(string nev, string faj, int sebesseg): Allat(nev, faj, "Szárazföld", sebesseg)
{ }