
// para trabajar con archivos se usar la libreria System.IO
using Work_withFiles_dotnet;

Console.WriteLine("Hello, World!");

///<summary> 
/// para realizar este ejercicio se divide en metodos que se encuentran en la clase Directorios, la cual se instancia aqui para 
/// ejecutar dichos metodos
///</summary>

Directorios directorios = new Directorios(); /* instanca de la clase de trabajo */

/* ******* Ventana de pruebas para ejecucion de metodos *******************/
try
{
    directorios.Listardirectoriosyarchivos();
}
catch (System.Exception e)
{
    System.Console.WriteLine("no se encuentra el directorio " + e.Message );
    
}


/****************************************************************************/
