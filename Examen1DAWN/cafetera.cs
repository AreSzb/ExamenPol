using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPol
{
    class Cafetera
    {
        public const double CONSUMO_AGUA = 0.1; ///<param name="CONSUMO_AGUA">Valor constante de tipo int el cual específica el consumo de agua de la cafetera.</param>
                                                ///<remarks>Recuerde modificar este campo cuando la cantidad del consumo de la maquina varie.</remarks>
        public string Marca { get; set; } ///<param name="Marca">Valor de tipo string el cual específica la marca de la cafetera.</param>
        public string Modelo { get; set; } ///<param name="Modelo">Valor de tipo string el cual específica el modelo de la cafetera.</param>
        public double CantidadAgua { get; set; } ///<param name="CantidadAgua">Valor de tipo double el cual específica la cantidad de agua actual en la cafetera.</param>
        public int TotalDeCapsulas { get; set; } ///<param name="TotalDeCapsulas">Valor de tipo int el cual específica la cantidad de capsulas restantes en la cafetera.</param>

        public Cafetera(string marca, string modelo, double cantidadAgua, int totalDeCapsulas)
        {
            Marca = marca;
            Modelo = modelo;
            TotalDeCapsulas = totalDeCapsulas;
            CantidadAgua = cantidadAgua;
        }

        /// <summary>
        /// Consume el agua necesaria para la produccion del cafe.
        /// </summary>
        /// <param name="cantidadCafe">Valor de tipo double el cual específica la cantidad de cafe a consumir.</param>
        /// <returns>Devuelve un mensaje de error debido a la falta de agua</returns>
        /// <returns>Una vez se ha consumido el agua requerida muestra un mensaje con el agua restante en el deposito</returns>
        public string ConsumirAgua(int cantidadCafe)
        {
            CantidadAgua -= cantidadCafe * CONSUMO_AGUA; ///<value>Se resta la cantidad de agua dependiendo de la cantidad de cafe a producir</value>

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

        /// <summary>
        /// Consume las capsulas necesarias para la produccion del cafe.
        /// </summary>
        /// <param name="cantidadCafe">Valor de tipo double el cual específica la cantidad de cafe a consumir.</param>
        /// <returns>Devuelve un mensaje de error debido a la falta de capsulas en el deposito.</returns>
        /// <returns>Una vez se ha consumido la o las capsulas requeridas muestra un mensaje con las restantes.</returns>
        public string ConsumirCapsulas(int cantidadCafe)
        {
            TotalDeCapsulas -= cantidadCafe; ///<value>Se resta la cantidad de cafe a la acutal.</value>

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

        /// <summary>
        /// Repone las capsulas de la maquina
        /// </summary>
        /// <param name="cantidadCapsulas">>Valor de tipo double el cual específica la cantidad de capsulas a reponer en la cafetera.</param>
        public void ReponerCapsulas(int cantidadCapsulas)
        {
            TotalDeCapsulas += cantidadCapsulas; ///<value>Se añaen nuevas capsulas</value>
        }

        /// <summary>
        /// Rellena el tanque de agua de la maquina
        /// </summary>
        /// <param name="aguaIntroducida">Valor de tipo double el cual específica la cantidad de agua a rellenar en la cafetera.</param>
        public void RellenarDeposito(double aguaIntroducida)
        {
            CantidadAgua += aguaIntroducida; ///<value>Se añade agua al deposito</value>
        }
    }
}
