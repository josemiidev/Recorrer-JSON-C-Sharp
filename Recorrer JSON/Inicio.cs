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
        }

        private void CargarDataGridView(List<Propietario> valores) {
            dgvPropietarios.Rows.Clear();

            foreach (Propietario p in valores) {
                DataGridViewRow f1 = new DataGridViewRow();
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.DNI });
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Nombre });
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Telefono });
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Email });
                if(p.Proiedades != null) {
                    foreach (Propiedad ps in p.Proiedades) {
                        DataGridViewRow f2 = new DataGridViewRow();
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Referencia });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Direccion });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Localidad });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Descripcion });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Cuota_Alquiler });
                        dgvPropiedades.Rows.Add(f2);
                    }
                }
                dgvPropietarios.Rows.Add(f1);
            }
        }

        private void btnGuardarPropietario_Click(object sender, EventArgs e) {
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();

            if(DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                Propietario p = new Propietario(DNI, Nombre, Telefono, Email, null);
                bd.Insertar(p);
                CargarDataGridView(bd.valores);
            }
            
        }

        private void btnModificarPropietario_Click(object sender, EventArgs e) {
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();
            if (DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                List<Propiedad> propiedades = new List<Propiedad>();
                foreach(DataGridViewRow dgvr in dgvPropiedades.Rows) {
                    String Referencia = dgvr.Cells[0].ToString().Trim();
                    String Direccion = dgvr.Cells[1].ToString().Trim();
                    String Localidad = dgvr.Cells[2].ToString().Trim();
                    String Descripcion = dgvr.Cells[3].ToString().Trim();
                    float cuota = float.Parse(dgvr.Cells[4].ToString());
                    propiedades.Add(new Propiedad(Referencia,Direccion,Localidad,Descripcion,cuota));
                }
                if(propiedades.Count> 0) {
                    Propietario p = new Propietario(DNI, Nombre, Telefono, Email, propiedades);
                    bd.Actualizar(x => x.DNI == DNI, p);
                    CargarDataGridView(bd.valores);
                } else {
                    Propietario p = new Propietario(DNI, Nombre, Telefono, Email, null);
                    bd.Actualizar(x => x.DNI == DNI, p);
                    CargarDataGridView(bd.valores);
                }
            }
        }

        private void btnEliminarPropietario_Click(object sender, EventArgs e) {
            String DNI = txtDNI.Text.ToString().Trim();
            bd.Eliminar(x => x.DNI == DNI);
            CargarDataGridView(bd.valores);
        }

        private void btnGuardarPropiedad_Click(object sender, EventArgs e) {
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();
            if (DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                List<Propiedad> propiedades = new List<Propiedad>();
                String Referencia = txtReferencia.Text.ToString().Trim();
                String Direccion = txtDireccion.Text.ToString().Trim();
                String Localidad = txtLocalidad.Text.ToString().Trim();
                String Descripcion = txtDescripcion.Text.ToString().Trim();
                float cuota = float.Parse(txtCuota.Text.ToString());
                propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cuota));

                foreach (DataGridViewRow dgvr in dgvPropiedades.Rows) {
                    Referencia = dgvr.Cells[0].ToString().Trim();
                    Direccion = dgvr.Cells[1].ToString().Trim();
                    Localidad = dgvr.Cells[2].ToString().Trim();
                    Descripcion = dgvr.Cells[3].ToString().Trim();
                    cuota = float.Parse(dgvr.Cells[4].ToString());
                    propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cuota));
                }
                if (propiedades.Count > 0) {
                    Propietario p = new Propietario(DNI, Nombre, Telefono, Email, propiedades);
                    bd.Actualizar(x => x.DNI == DNI, p);
                    CargarDataGridView(bd.valores);
                } else {
                    Propietario p = new Propietario(DNI, Nombre, Telefono, Email, null);
                    bd.Actualizar(x => x.DNI == DNI, p);
                    CargarDataGridView(bd.valores);
                }
            }
        }

        private void btnEliminarPropiedad_Click(object sender, EventArgs e) {
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();
            if (DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                List<Propiedad> propiedades = new List<Propiedad>();
                String Referencia = txtReferencia.Text.ToString().Trim();

                foreach (DataGridViewRow dgvr in dgvPropiedades.Rows) {
                    if(!dgvr.Cells[0].ToString().Trim().Equals(Referencia)) {
                        Referencia = dgvr.Cells[0].ToString().Trim();
                        String Direccion = dgvr.Cells[1].ToString().Trim();
                        String Localidad = dgvr.Cells[2].ToString().Trim();
                        String Descripcion = dgvr.Cells[3].ToString().Trim();
                        float cuota = float.Parse(dgvr.Cells[4].ToString());
                        propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cuota));
                    }
                }
                if (propiedades.Count > 0) {
                    Propietario p = new Propietario(DNI, Nombre, Telefono, Email, propiedades);
                    bd.Actualizar(x => x.DNI == DNI, p);
                    CargarDataGridView(bd.valores);
                } else {
                    Propietario p = new Propietario(DNI, Nombre, Telefono, Email, null);
                    bd.Actualizar(x => x.DNI == DNI, p);
                    CargarDataGridView(bd.valores);
                }
            }
        }

        private void btnModificarPropiedad_Click(object sender, EventArgs e) {
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();
            if (DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                List<Propiedad> propiedades = new List<Propiedad>();
                String Referencia = txtReferencia.Text.ToString().Trim();
                String Direccion = txtDireccion.Text.ToString().Trim();
                String Localidad = txtLocalidad.Text.ToString().Trim();
                String Descripcion = txtDescripcion.Text.ToString().Trim();
                float cuota = float.Parse(txtCuota.Text.ToString());
                propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cuota));

                foreach (DataGridViewRow dgvr in dgvPropiedades.Rows) {
                    if (!dgvr.Cells[0].ToString().Trim().Equals(Referencia)) {
                        Referencia = dgvr.Cells[0].ToString().Trim();
                        Direccion = dgvr.Cells[1].ToString().Trim();
                        Localidad = dgvr.Cells[2].ToString().Trim();
                        Descripcion = dgvr.Cells[3].ToString().Trim();
                        cuota = float.Parse(dgvr.Cells[4].ToString());
                        propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cuota));
                    }
                }
                if (propiedades.Count > 0) {
                    Propietario p = new Propietario(DNI, Nombre, Telefono, Email, propiedades);
                    bd.Actualizar(x => x.DNI == DNI, p);
                    CargarDataGridView(bd.valores);
                } else {
                    Propietario p = new Propietario(DNI, Nombre, Telefono, Email, null);
                    bd.Actualizar(x => x.DNI == DNI, p);
                    CargarDataGridView(bd.valores);
                }
            }
        }

        private void dgvPropietarios_SelectionChanged(object sender, EventArgs e) {
            if(dgvPropietarios.SelectedRows.Count > 0) {
                txtDNI.Text = dgvPropietarios.SelectedRows[0].Cells[0].Value.ToString();
                txtNombre.Text = dgvPropietarios.SelectedRows[0].Cells[1].Value.ToString();
                txtTelefono.Text = dgvPropietarios.SelectedRows[0].Cells[2].Value.ToString();
                txtEmail.Text = dgvPropietarios.SelectedRows[0].Cells[3].Value.ToString();
            } else {
                LimpiaCamposPropietario();
            }
        }

        private void dgvPropiedades_SelectionChanged(object sender, EventArgs e) {
            if (dgvPropiedades.SelectedRows.Count > 0) {
                txtReferencia.Text = dgvPropiedades.SelectedRows[0].Cells[0].Value.ToString();
                txtDireccion.Text = dgvPropiedades.SelectedRows[0].Cells[1].Value.ToString();
                txtLocalidad.Text = dgvPropiedades.SelectedRows[0].Cells[2].Value.ToString();
                txtDescripcion.Text = dgvPropiedades.SelectedRows[0].Cells[3].Value.ToString();
                txtCuota.Text = dgvPropiedades.SelectedRows[0].Cells[4].Value.ToString();
            } else {
                LimpiaCamposPropiedades();
            }
        }
        private void LimpiaCamposPropietario() {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }
        private void LimpiaCamposPropiedades() {
            txtReferencia.Text = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";
            txtDescripcion.Text = "";
            txtCuota.Text = "";
        }

        private void Inicio_Load(object sender, EventArgs e) {
            bd.Cargar();
            CargarDataGridView(bd.valores);
            dgvPropietarios.ClearSelection();
            dgvPropiedades.ClearSelection();
        }
    }
}
