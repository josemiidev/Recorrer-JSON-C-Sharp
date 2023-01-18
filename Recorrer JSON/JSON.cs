using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Recorrer_JSON {
    public class JSON<T> {
        public List<T> valores = new List<T>();
        public string ruta;

        //CONSTRUCTOR DE LA CLASE EN EL QUE ESPECIFICAMOS LA RUTA DEL JSON
        public JSON(string r) {
            ruta = r;
        }

        //FUNCION DE GUARDAR EL JSON
        public void Guardar() {
            string texto = JsonConvert.SerializeObject(valores);
            File.WriteAllText(ruta, texto);
        }

        //FUNCION QUE CARGA LA LISTA DE VALORES DESDE EL JSON
        public void Cargar() {
            try {
                string archivo = File.ReadAllText(ruta);
                valores = JsonConvert.DeserializeObject<List<T>>(archivo);
            } catch (Exception) { }
        }

        //FUNCIÓN PARA INSERTAR VALORES EN EL JSON
        public void Insertar(T nuevo) {
            valores.Add(nuevo);
            Guardar();
        }

        //FUNCIÓN PARA BUSCAR VALORES EN LA LISTA
        public List<T> Buscar(Func<T, bool> criterio) {
            return valores.Where(criterio).ToList();
        }

        //FUNCIÓN PARA ELIMIAR VALORES ESPECIFICOS
        public void Eliminar(Func<T, bool> criterio) {
            valores = valores.Where(x => !criterio(x)).ToList();
            Guardar();
        }

        //FUNCION PARA MODIFICAR VALORES DEL JSON ESPECIFICOS
        public void Actualizar(Func<T, bool> criterio, T nuevo) {
            valores = valores.Select(x => {
                if (criterio(x)) x = nuevo;
                return x;
            }).ToList();
            Guardar();
        }
    }
}
