using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaCasaC.servicios;

namespace TareaCasaC.Servicios
{
    internal class MenuImplenetacion : MenuInterfaz

    {
        /// <summary>
        /// clase que implementa la interfaz de menu
        /// 250923-amd
        /// </summary>

        public void mostrarMensajeBienevenida()
        {
            string mensaje = "Bienvenido Andres"
                Console.WriteLine(mensaje);
        }
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;

            Console.WriteLine("***********************************************");
            Console.WriteLine("0. Cerrar aplicacion ");
            Console.WriteLine("1. Examenes");
            Console.WriteLine("2. Ejercicios de hoy");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Selecione una opcion");
            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');
            return opcionIntroducida;   
        }


    }
}
