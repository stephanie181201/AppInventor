using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class Empleado
    {
         private string numsecsoc, nombre, primerApellido;
        private byte edad;

        public string Numsecsoc {
            get => numsecsoc; 
            set => numsecsoc = value;
        }
        public string Nombre {
            get => nombre;
            set => nombre = value;
        }
        public string PrimerApellido {
            get => primerApellido;
            set => primerApellido = value;
        }
        public byte Edad {
            get => edad;
            set => edad = value;
        }
    }
    
}
