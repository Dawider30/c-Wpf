// use of classes

// brand -  tank capacity - fuel consumtion
Samochod sam = new Samochod("Opel Astra", 60, 180, 7);
// speed - distance
sam.jedz(120, 500);

Kabriolet k = new Kabriolet("BMW Z4", 50, 250, 10);
k.otworz_dach();
k.jedz(200, 1000);
k.zamknij_dach();
k.jedz(200, 1000);
class Samochod
{
    // declaring variables

    private string marka;
    private float poj_baku;
    private float predkosc_max;
    private float zuzycie_paliwa;

    // constructor

    public Samochod(string marka, float poj_baku, float predkosc_max, float zuzycie_paliwa)
    {
        this.marka = marka;
        this.poj_baku = poj_baku;
        this.predkosc_max = predkosc_max;
        this.zuzycie_paliwa = zuzycie_paliwa;
    }

    // method jedz

    public void jedz(float jakSzybko, float jakDaleko, bool kabriolet = false, bool dachOtwarty = false)
    {
        float dystans = 0;
        float paliwo = 0;
        float czas = 0;
        float zuzycie_paliwa_zmodyfikowane = zuzycie_paliwa;

        if (kabriolet && dachOtwarty)
        {
            zuzycie_paliwa_zmodyfikowane *= 1.15f; // 15% more fuel with open roof
        }

        while (dystans < jakDaleko)
        {
            float czas_na_etap;
            float dystans_na_etap;
            float paliwo_na_etap;

            if (jakSzybko <= predkosc_max)
            {
                czas_na_etap = jakDaleko / jakSzybko;
                dystans_na_etap = jakDaleko;
                paliwo_na_etap = (dystans_na_etap / 100) * zuzycie_paliwa_zmodyfikowane;
            }
            else
            {
                czas_na_etap = jakDaleko / predkosc_max;
                dystans_na_etap = predkosc_max * czas_na_etap;
                paliwo_na_etap = (dystans_na_etap / 100) * zuzycie_paliwa_zmodyfikowane;
            }

            dystans += dystans_na_etap;
            paliwo += paliwo_na_etap;
            czas += czas_na_etap;
        }

        int ilosc_tankowan = (int)Math.Ceiling(paliwo / poj_baku);

        Console.WriteLine($"Samochód marki {marka} pojedzie z prędkością {Math.Min(jakSzybko, predkosc_max)} km/h przez {jakDaleko} km i będzie musiał zatankować {ilosc_tankowan} razy.");
    }
}

class Kabriolet : Samochod
{
    private bool dach_otwarty;

    public Kabriolet(string marka, float poj_baku, float predkosc_max, float zuzycie_paliwa) : base(marka, poj_baku, predkosc_max, zuzycie_paliwa)
    {
        dach_otwarty = false;
    }

    public void otworz_dach()
    {
        dach_otwarty = true;
    }

    public void zamknij_dach()
    {
        dach_otwarty = false;
    }

    public new void jedz(float jakSzybko, float jakDaleko)
    {
        base.jedz(jakSzybko, jakDaleko, true, dach_otwarty);
    }
}

