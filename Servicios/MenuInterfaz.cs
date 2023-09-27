using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCasaC.servicios
  {   /// <summary>
      /// interfaz que corresponde a las acciones que puede hacer el menu
      /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// muestra el mensaje bienvenida
        /// 270923
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// metodo que muestra el menu y recoge la eleccion del usuario
        /// </summary>
        /// <returns>un enetero con la opciion elegida</returns>
        public int mostrarMunuYSeleccionar();
    }
}
