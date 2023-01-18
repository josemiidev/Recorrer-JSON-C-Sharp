using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recorrer_JSON {
    public class Propietario {
        public String DNI;
        public String Nombre;
        public String Telefono;
        public String Email;

        public Propietario(String dni, String nombre, String telefono, String email) {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Email = email;
        }
    }
}
