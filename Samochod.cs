using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Samochod
{   
    private string marka
    {
        get { return marka; }
        set { marka = value; }
    }
    private string model
    {
        get { return model; }
        set { model = value; }
    }
    private int iloscDrzwi
    {
        get { return iloscDrzwi; }
        set { iloscDrzwi = value; }
    }
    private int pojemnoscSilnika
    {
        get { return pojemnoscSilnika; }
        set { pojemnoscSilnika = value; }
    }
    private double srednieSpalanie
    {
        get { return srednieSpalanie; }
        set { srednieSpalanie = value; }
    }
    private int liczbaSamochodow = 0;

    public Samochod()
    {
        this.marka = "nieznana";
        this.model = "nieznany";
        this.iloscDrzwi = 0;
        this.pojemnoscSilnika = 0;
        this.srednieSpalanie = 0.0;
        liczbaSamochodow++;
    }

}
