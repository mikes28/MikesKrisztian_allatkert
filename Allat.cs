using System.ComponentModel;

namespace MikesKrisztian_allatkert;

internal class Allat
{
    private string nev;
    private string faj;
    private string elohely;
    private int sebesseg;

    public string Nev { get => nev; set => nev = value; }
    public int Sebesseg { get => sebesseg;}

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
