using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recorrer_JSON {
    
    public class Propiedad {
        public Propietario Propietario;
        public String Referencia;
        public String Direccion;
        public String Localidad;
        public String Descripcion;
        public float Cuota_Alquiler;
        public Propiedad(Propietario propietario, String referencia, String direccion, String localidad, String descripcion, float cuota) {
            this.Propietario = propietario;
            this.Referencia = referencia;
            this.Direccion = direccion;
            this.Localidad = localidad;
            this.Descripcion = descripcion;
            this.Cuota_Alquiler= cuota;
        }
    }
}
