using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recorrer_JSON {
    public partial class Inicio : Form {
        JSON<Propietario> bd = new JSON<Propietario>("bd.json");
        public Inicio() {
            InitializeComponent();
            bd.Cargar();
            CargarDataGridView(bd.valores);
        }

        private void CargarDataGridView(List<Propietario> valores) {
            dgvPropietarios.Rows.Clear();

            foreach (Propietario p in valores) {
                DataGridViewRow f1 = new DataGridViewRow();
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.DNI });
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Nombre });
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Telefono });
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Email });
                foreach(Propiedad ps in p.Proiedades) {
                    DataGridViewRow f2 = new DataGridViewRow();
                    f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Referencia });
                    f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Direccion });
                    f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Localidad });
                    f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Descripcion });
                    f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Cuota_Alquiler });
                    dgvPropiedades.Rows.Add(f2);
                }
                dgvPropietarios.Rows.Add(f1);
            }
        }
    }
}
