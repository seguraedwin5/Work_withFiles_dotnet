using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Work_withFiles_dotnet
{
    public class Directorios
    {
        //constructor
        public Directorios()
        {

        }

        public void listardirectorios()
        {
            //leer y enumerar directorios

            //1. Crear una lista donde se van a enumerar directorios que encuentre en la carpeta "stores"   
            IEnumerable<string> listofdirectories = Directory.EnumerateDirectories("stores");

            //2. Recorrer la lista de directorios para imprimir los nombres de los directorios o carpetas
            foreach (var dir in listofdirectories)
            {
                System.Console.WriteLine(dir);
            }
        }


        //2. Listar directorios con archivos
        public void Listardirectoriosyarchivos()
        {
            //Crear la lista que va a almacenar los nombres de los archivos
            IEnumerable<string> AllfilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

            foreach (var file in AllfilesInAllFolders) // se lee cada archivo de la lista
            {
                System.Console.WriteLine(file);
            }
        }

        /*3. Contexto: 
        Tailwind Traders tiene muchas tiendas físicas repartidas por todo el mundo. Cada noche, cada tienda crea un archivo denominado 
        sales.json que contiene el total de todas las ventas de ese día. Estos archivos se organizan en carpetas por id. de tienda.
        
        */
        

    }

}
