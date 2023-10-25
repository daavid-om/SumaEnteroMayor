using SumaEnteroMayor.Servicios;

namespace SumaEnteroMayor
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 251023 - dom
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// 251023 - dom
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creamos los objetos
            SumaEnteroInterfaz se = new SumaEnteroImplementacion();
            //Se llama al método a través del objeto
            se.NumeroEntero();
        }
    }
}