
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

    public void ReponerCapsulas(double cantidadCapsulas)
    {
        TotalDeCapsulas += cantidadcapsulas;
    }

    public void RellenarDeposito(double aguaIntroducida)
    {
        CantidadAgua += aguaIntroducida;
    }
}

class ejemplodemicafetera
{
    static void main()
    {
        cafetera cafetera = new cafetera("EspressoBarista", "Procoffee", 0.6, 7);

        Console.WriteLine(cafetera.CantidadAgua);
        Console.WriteLine(cafetera.ConsumirCapsulas(5));
        Console.WriteLine(cafetera.TotalDeCapsulas);
        Console.WriteLine(cafetera.ConsumirAgua(5));
        Console.WriteLine(cafetera.CantidadAgua);
        cafetera.RellenarDeposito(0.5);
        Console.WriteLine(cafetera.CantidadAgua);
        cafetera.ReponerCapsulas(3);
        Console.WriteLine(cafetera.TotalDeCapsulas);
    }
}