using TareaCasaC.servicios;

namespace TareaCasaC
{
    /// <summary>
    /// clase principal de la entrada
    /// </summary>
    class Program

      /// <summary>
      /// metodo de etrada de la aplicacion
      /// 270923-amd
      /// </summary>
      /// <param name="args"></param>
        static void main(String[] args)
    {
        {


            MenuInterfaz menuInterfaz = new MenuImplenetacion();
            menuInterfaz.mensajeBienvenida();
            //Variable que controla la entrada y salida del bucle while
           
            bool cerrarMenu = false;
            //Va a contener la opcion seleccionada
            int opcionSeleccionar;

            //Si da true dentro, entrara, si no, no
            //Desde la primera iteracion debe cumplirse la condicion
            while (!cerrarMenu)
            //tambien esta el do while

            {
                opcionSeleccionar = menuInterfaz.mostrarMunuYSeleccionar();
                Console.WriteLine(opcionSeleccionar);
                //coge la opcion del usuario y la copia en la opcion seleccionada

                switch (opcionSeleccionar)
                //el while y switch van juntos
                {
                    case 0:
                        Console.WriteLine("[INFO] - se ejecuta caso 0.");
                        cerrarMenu = true;

                        break;//Sirve para que se salga del switch y vaya a la siguiente linea
                    case 1:
                        Console.WriteLine("[INFO] - se ejecuta caso 1.");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - se ejecuta caso 2.");
                        break;
                    
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no esta disponible.");
                        //este sirve para dar una informacion
                        break;
                }



            }
        }
    }
}





        






