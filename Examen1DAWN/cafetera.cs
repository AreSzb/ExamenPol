
using System;


//namespace EDexamenT6a8

class cafetera
{
    public const double CONSUMO_AGUA = 0.1;
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double CantidadAgua { get; set; }
    public double TotalDeCapsulas { get; set; }

    public cafetera(string marca, string modelo, double cantidadAgua, double totalDeCapsulas)
    {
        Marca = marca; //marca de la máquina cafetera
        Modelo = modelo; //referencia del modelo
        TotalDeCapsulas = totalDeCapsulas; //Total de cápsulas en la máquina. 
        CantidadAgua = cantidadAgua; //Cantidad de agua en el recipiente. 
    }


    public string ConsumirAgua(double cantidadDeCafe) //numero de cafés a hacer
    {
        CantidadAgua -= cantidadDeCafe * CONSUMO_AGUA; // Constante de consumo de agua 0.1l por cada unidad de café. 

        if (CantidadAgua < 0.1)
        {
            CantidadAgua = 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else
        {
            return "Quedan" + CantidadAgua + " centilitros";
        }
    }

    public string ConsumirCapsulas(double cantidadCafe) //Hacer un café 
    {
        TotalDeCapsulas -= cantidadCafe;

        if (TotalDeCapsulas < 0)
        {
            TotalDeCapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else
        {
            return "Quedan" + TotalDeCapsulas + "unidades";
        }
    }

    public double ReponerCapsulas(double cantidadcapsulas)
    {
        this.totaldecapsulas = this.totaldecapsulas + cantidadcapsulas;
        return this.totaldecapsulas;
    }
    public double llenardep(double litros)
    {
        this.agua = this.agua + litros;
        return this.agua;
    }

    public void verespecificacion(string r, string m)
    {
        this.m = m;
        this.r = r;
    }

}

class ejemplodemicafetera
{

    static void main()
    {
        cafetera mi_cafetera_ejemplo = new cafetera("EspressoBarista", "Procoffee", 0.6, 7);

        Console.WriteLine(mi_cafetera_ejemplo.agua);
        Console.WriteLine(mi_cafetera_ejemplo.consumocapsulas(5));
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas);
        Console.WriteLine(mi_cafetera_ejemplo.consumoagua(5));
        Console.WriteLine(mi_cafetera_ejemplo.agua);
        mi_cafetera_ejemplo.llenardep(0.5);
        Console.WriteLine(mi_cafetera_ejemplo.agua);
        mi_cafetera_ejemplo.reponercapsulas(3);
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas);
    }

}