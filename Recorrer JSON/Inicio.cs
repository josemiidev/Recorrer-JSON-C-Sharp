using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recorrer_JSON {
    public partial class Inicio : Form {
        //EL SEGUIMIENTO DE ESTE EJERCICIO SE HA REALIZADO EN GITHUB: https://github.com/josemiidev/Recorrer-JSON-C-Sharp.git
        //INSTANCIAMOS EL DOCUMENTO JSON
        JSON<Propietario> bd = new JSON<Propietario>("bd.json");

        //CONSTRUCTOR FORMULARIO INICIO
        public Inicio() {
            InitializeComponent();
        }

        //METODO PARA CARGAR LOS DOS DATAGRIDVIEW
        private void CargarDataGridView(List<Propietario> valores) {
            //LIMPIAMOS LOS DATAGRIDVIEWS
            dgvPropietarios.Rows.Clear();
            dgvPropiedades.Rows.Clear();

            //RECORREMOS LOS VALORES DE LA LISTA DEL JSON
            foreach (Propietario p in valores) {
                //CREAMOS UNA FILA DE DATAGRIDVIEW
                DataGridViewRow f1 = new DataGridViewRow();
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.DNI });
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Nombre });
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Telefono });
                f1.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Email });
                if(p.Proiedades != null) {
                    //RECORREMOS LAS PROPIEDADES Y LAS AÑADIMOS
                    foreach (Propiedad ps in p.Proiedades) {
                        DataGridViewRow f2 = new DataGridViewRow();
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Referencia });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Direccion });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Localidad });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Descripcion });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Cuota_Alquiler });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = p.DNI });
                        //AÑADIMOS LA FILA AL DATAGRIDVIEW DE PROPIEDADES
                        dgvPropiedades.Rows.Add(f2);
                    }
                }
                //AÑADIMOS LA FILA AL DATAGRIDVIEW DE PROPIETARIOS
                dgvPropietarios.Rows.Add(f1);
            }
        }

        //METODO PARA CARGAR EL DATAGRIDVIEW DE PROPIEDADES A PARTIR DE UN PROPIETARIO
        private void CargaPropiedades(String DNI) {
            //LIMPIAMOS EL DATAGRIDVIEW
            dgvPropiedades.Rows.Clear();
            //BUSCAMOS LAS PROPIEDADES DE UN PROPIETARIO
            List<Propietario> ls = bd.Buscar(x => x.DNI == DNI);
            //COMPROBAMOS QUE TIENE PROPIEDADES
            if(ls.Count > 0) {
                if (ls[0].Proiedades != null) {
                    //RECORREMOS LAS PROPIEDADES
                    foreach (Propiedad ps in ls[0].Proiedades) {
                        //CREAMOS LA FILA PARA EL DATAGRIDVIEW DE PROPIEDADES
                        DataGridViewRow f2 = new DataGridViewRow();
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Referencia });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Direccion });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Localidad });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Descripcion });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = ps.Cuota_Alquiler });
                        f2.Cells.Add(new DataGridViewTextBoxCell() { Value = DNI });
                        //AÑADIMOS LA FILA
                        dgvPropiedades.Rows.Add(f2);
                    }
                }
            }
        }

        //METODO DEL EVENTO CLICK DEL BOTON GUARDAR PROPIETARIO
        private void btnGuardarPropietario_Click(object sender, EventArgs e) {
            //CARGAMOS LAS VARIABLES
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();

            //COMPROBAMOS QUE LOS CAMPOS NO ESTÉN VACÍOS
            if(DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                //SI NO ESTÁ VACIO, CREAMOS EL PROPIETARIO
                Propietario p = new Propietario(DNI, Nombre, Telefono, Email, null);
                bd.Insertar(p);
                //RECARGAMOS LOS DATAGRIDVIEW
                CargarDataGridView(bd.valores);
                dgvPropietarios.ClearSelection();
            }
        }

        //METODO DEL EVENTO CLICK DEL BOTON MODIFICAR PROPIETARIO
        private void btnModificarPropietario_Click(object sender, EventArgs e) {
            //CARGAMOS LAS VARIABLES
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();

            //COMPROBAMOS QUE LOS CAMPOS NO ESTÉN VACÍOS
            if (DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                //SI NO ESTAN VACÍOS, CARGAMOS LAS PROPIEDADES EN UN LIST
                List<Propiedad> propiedades = new List<Propiedad>();
                foreach(DataGridViewRow dgvr in dgvPropiedades.Rows) {
                    String Referencia = dgvr.Cells[0].Value.ToString().Trim();
                    String Direccion = dgvr.Cells[1].Value.ToString().Trim();
                    String Localidad = dgvr.Cells[2].Value.ToString().Trim();
                    String Descripcion = dgvr.Cells[3].Value.ToString().Trim();
                    float cuota = float.Parse(dgvr.Cells[4].Value.ToString());
                    propiedades.Add(new Propiedad(Referencia,Direccion,Localidad,Descripcion,cuota));
                }
                //COMPROBAMOS SI HAY O NO PROPIEDADES Y ACTUALIZAMOS EL REGISTRO Y LOS DATAGRIDVIEWS
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

        //METODO DEL EVENTO CLICK DEL BOTON ELIMINAR PROPIETARIO
        private void btnEliminarPropietario_Click(object sender, EventArgs e) {
            //CARGAMOS EL DNI EN UNA VARIABLE
            String DNI = txtDNI.Text.ToString().Trim();
            //UTILIZAMOS EL METODO ELIMINAR Y RECARGAMOS LOS DATAGRIDVIEWS
            bd.Eliminar(x => x.DNI == DNI);
            CargarDataGridView(bd.valores);
        }

        //METODO DEL EVENTO CLICK DEL BOTON GUARDAR PROPIEDAD
        private void btnGuardarPropiedad_Click(object sender, EventArgs e) {
            //CARGAMOS LAS VARIABLES
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();
            //COMPROBAMOS QUE TODOS LOS CAMPOS ESTÉN RELLENOS
            if (DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                //COMPROBAMOS QUE LA CANTIDAD DE CUOTA SEA UN FLOAT
                float cantidad;
                if (float.TryParse(txtCuota.Text.ToString().Trim(), out cantidad)) {
                    //SI TODO ES CORRECTO, CARGAMOS LA NUEVA PROPIEDAD
                    List<Propiedad> propiedades = new List<Propiedad>();
                    String Referencia = txtReferencia.Text.ToString().Trim();
                    String Direccion = txtDireccion.Text.ToString().Trim();
                    String Localidad = txtLocalidad.Text.ToString().Trim();
                    String Descripcion = txtDescripcion.Text.ToString().Trim();

                    propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cantidad));
                    //CARGAMOS LAS PROPIEDADES ANTERIORES
                    foreach (DataGridViewRow dgvr in dgvPropiedades.Rows) {
                        Referencia = dgvr.Cells[0].Value.ToString().Trim();
                        Direccion = dgvr.Cells[1].Value.ToString().Trim();
                        Localidad = dgvr.Cells[2].Value.ToString().Trim();
                        Descripcion = dgvr.Cells[3].Value.ToString().Trim();
                        cantidad = float.Parse(dgvr.Cells[4].Value.ToString());
                        propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cantidad));
                    }
                    //COMPROBAMOS QUE TENGRA PROPIEDADES PARA AÑADIRLAS A NULL O COMO LSITA
                    if (propiedades.Count > 0) {
                        Propietario p = new Propietario(DNI, Nombre, Telefono, Email, propiedades);
                        bd.Actualizar(x => x.DNI == DNI, p);
                        CargarDataGridView(bd.valores);
                    } else {
                        Propietario p = new Propietario(DNI, Nombre, Telefono, Email, null);
                        bd.Actualizar(x => x.DNI == DNI, p);
                        CargarDataGridView(bd.valores);
                    }
                } else {
                    //MOSTRAMOS ERROR POR LA CANTIDAD DE LA CUOTA
                    lblErrorPropiedad.Text = "LA CANTIDAD DE LA CUOTA NO ES CORRECTA";
                }
            }
        }

        //EVENTO CLICK DEL BOTON ELIMINAR PROPIEDAD
        private void btnEliminarPropiedad_Click(object sender, EventArgs e) {
            //CARGAMOS LAS VARIABLES
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();
            if (DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                //CARGAMOS LA REFERENCIA A ELIMINAR
                List<Propiedad> propiedades = new List<Propiedad>();
                String Referencia = txtReferencia.Text.ToString().Trim();

                //AÑADIMOS A LA LISTA LAS PROPIEDADES QUE NO SEAN LA QUE VAMOS A ELIMINAR
                foreach (DataGridViewRow dgvr in dgvPropiedades.Rows) {
                    if(!dgvr.Cells[0].Value.ToString().Trim().Equals(Referencia)) {
                        Referencia = dgvr.Cells[0].Value.ToString().Trim();
                        String Direccion = dgvr.Cells[1].Value.ToString().Trim();
                        String Localidad = dgvr.Cells[2].Value.ToString().Trim();
                        String Descripcion = dgvr.Cells[3].Value.ToString().Trim();
                        float cuota = float.Parse(dgvr.Cells[4].Value.ToString());
                        propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cuota));
                    }
                }
                //COMPROBAMOS SI HAY O NO PROPIEDADES PARA AÑADIR NULL O LA LISTA
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

        //EVENTO CLICK DEL BOTON MODIFICAR PROPIEDAD
        private void btnModificarPropiedad_Click(object sender, EventArgs e) {
            //CARGAMOS LAS VARIABLES
            String DNI = txtDNI.Text.ToString().Trim();
            String Nombre = txtNombre.Text.ToString().Trim();
            String Telefono = txtTelefono.Text.ToString().Trim();
            String Email = txtEmail.Text.ToString().Trim();
            //COMPROBAMOS QUE TODOS LOS DATOS ESTEN RELLENOS
            if (DNI.Equals("") || Nombre.Equals("") || Telefono.Equals("") || Email.Equals("")) {
                lblErrorPropietario.Text = "DEBE RELLENAR TODOS LOS CAMPOS";
            } else {
                //COMPROBAMOS QUE LA CANTIDAD DE CUOTA SE PUEDA PASAR A FLOAT
                float cantidad;
                if(float.TryParse(txtCuota.Text.ToString(), out cantidad)){
                    //CREAMOS LA LISTA DE PROPIEDADES Y CARGAMOS LAS PROPIEDAD MODIFICADA
                    List<Propiedad> propiedades = new List<Propiedad>();
                    String Referencia = txtReferencia.Text.ToString().Trim();
                    String Direccion = txtDireccion.Text.ToString().Trim();
                    String Localidad = txtLocalidad.Text.ToString().Trim();
                    String Descripcion = txtDescripcion.Text.ToString().Trim();
                    propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cantidad));

                    //INSERTAMOS LAS OTRAS PROPIEDADES DEL PROPIETARIO
                    foreach (DataGridViewRow dgvr in dgvPropiedades.Rows) {
                        if (!dgvr.Cells[0].Value.ToString().Trim().Equals(Referencia)) {
                            Referencia = dgvr.Cells[0].Value.ToString().Trim();
                            Direccion = dgvr.Cells[1].Value.ToString().Trim();
                            Localidad = dgvr.Cells[2].Value.ToString().Trim();
                            Descripcion = dgvr.Cells[3].Value.ToString().Trim();
                            cantidad = float.Parse(dgvr.Cells[4].Value.ToString());
                            propiedades.Add(new Propiedad(Referencia, Direccion, Localidad, Descripcion, cantidad));
                        }
                    }
                    //COMPROBAMOS SI TIENE PROPIEDADES PARA AÑADIR DE NULL O LIST
                    if (propiedades.Count > 0) {
                        Propietario p = new Propietario(DNI, Nombre, Telefono, Email, propiedades);
                        bd.Actualizar(x => x.DNI == DNI, p);
                        CargarDataGridView(bd.valores);
                    } else {
                        Propietario p = new Propietario(DNI, Nombre, Telefono, Email, null);
                        bd.Actualizar(x => x.DNI == DNI, p);
                        CargarDataGridView(bd.valores);
                    }
                } else {
                    lblErrorPropiedad.Text = "LA CANTIDAD DE LA CUOTA NO ES CORRECTA";
                }
            }
        }

        //EVENTO CAMBIO SELECCION DGVPROPIETARIOS
        private void dgvPropietarios_SelectionChanged(object sender, EventArgs e) {
            //COMPROBAMOS SI HAY ALGUN ELEMENTO SELECCIONADO
            if(dgvPropietarios.SelectedRows.Count > 0) {
                //CARGAMOS LOS CAMPOS CON LA INFORMACION DEL PROPIETARIO
                txtDNI.Text = dgvPropietarios.SelectedRows[0].Cells[0].Value.ToString();
                txtNombre.Text = dgvPropietarios.SelectedRows[0].Cells[1].Value.ToString();
                txtTelefono.Text = dgvPropietarios.SelectedRows[0].Cells[2].Value.ToString();
                txtEmail.Text = dgvPropietarios.SelectedRows[0].Cells[3].Value.ToString();
                //CARGAMOS LAS PROPIEDADES DEL PROPIETARIO
                CargaPropiedades(dgvPropietarios.SelectedRows[0].Cells[0].Value.ToString());
                dgvPropiedades.ClearSelection();
            } else {
                //LIMPIAMOS LOS CAMPOS SI NO HAY ELEMENTO SELECCIONADO
                LimpiaCamposPropietario();
            }
        }

        //EVENTO CAMBIO SELECCION DGVPROPIEDADES
        private void dgvPropiedades_SelectionChanged(object sender, EventArgs e) {
            //COMPROBAMOS SI HAY ALGUN ELEMENTO SELECCIONADO
            if (dgvPropiedades.SelectedRows.Count > 0) {
                //CARGAMOS LOS CAMPOS CON LA INFORMACION DEL PROPIETARIO
                txtReferencia.Text = dgvPropiedades.SelectedRows[0].Cells[0].Value.ToString();
                txtDireccion.Text = dgvPropiedades.SelectedRows[0].Cells[1].Value.ToString();
                txtLocalidad.Text = dgvPropiedades.SelectedRows[0].Cells[2].Value.ToString();
                txtDescripcion.Text = dgvPropiedades.SelectedRows[0].Cells[3].Value.ToString();
                txtCuota.Text = dgvPropiedades.SelectedRows[0].Cells[4].Value.ToString();
                SeleccionarPropietario(dgvPropiedades.SelectedRows[0].Cells[5].Value.ToString());
                //LIMPIAMOS LOS CAMPOS SI NO HAY ELEMENTO SELECCIONADO
            } else {
                LimpiaCamposPropiedades();
            }
        }

        //METODO PARA CARGAR LA INFORMACION DEL PROPIETARIO EN LOS CAMPOS
        private void SeleccionarPropietario(String dni) {
            //RECORREMOS EL DATAGRIDVIEW DE PROPIETARIOS BUSCANDO POR DNI Y CARGAMOS LOS CAMPOS
            foreach(DataGridViewRow r in dgvPropietarios.Rows) {
                if (r.Cells[0].Value.ToString().Equals(dni)) {
                    txtDNI.Text = r.Cells[0].Value.ToString();
                    txtNombre.Text = r.Cells[1].Value.ToString();
                    txtTelefono.Text = r.Cells[2].Value.ToString();
                    txtEmail.Text = r.Cells[3].Value.ToString();
                    //USAMOS EL BREAK PARA CORTAR LA BUSQUEDA
                    break;
                }
            }
        }

        //METODO PARA LIMPIAR LOS CAMPOS DEL FORMULARIO PROPIETARIO
        private void LimpiaCamposPropietario() {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        //METODO PARA LIMPIAR LOS CAMPOS DEL FORMULARIO PROPIEDAD
        private void LimpiaCamposPropiedades() {
            txtReferencia.Text = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";
            txtDescripcion.Text = "";
            txtCuota.Text = "";
        }

        //EVENTO LOAD DEL FORMULARIO
        private void Inicio_Load(object sender, EventArgs e) {
            //CARGAMOS LOS VALORES ALMACENADOS EN EL JSON
            bd.Cargar();
            //CARGAMOS LOS DATAGRIDVIEWS
            CargarDataGridView(bd.valores);
            //DESELECCIONAMOS LAS FILAS DE LOS DATAGRIDVIEWS
            dgvPropietarios.ClearSelection();
            dgvPropiedades.ClearSelection();
        }

        //EVENTO CLIC DEL BOTON LIMPIAR SELECCION
        private void btnLimpiar_Click(object sender, EventArgs e) {
            //CARGAMOS DE NUEVO LOS DATAGRIDVIEW
            CargarDataGridView(bd.valores);
            //ELIMINAMOS LA INFORMACION DE LOS FORMULARIOS
            LimpiaCamposPropiedades();
            LimpiaCamposPropietario();
            //DESELECCIONAMOS FILAS DE LOS DATAGRIDVIEW
            dgvPropiedades.ClearSelection();
            dgvPropietarios.ClearSelection();
        }

        //EVENTO CLICK BOTON POSTERIOR PROPIETARIOS
        private void btnPosteriorPropietario_Click(object sender, EventArgs e) {
            //COMPROBAMOS SI HAY ALGUNA FILA SELECCIONADA
            //  SI NO HAY SELECCIONAMOS LA 0
            //  SI HAY SELECCIONAMOS LA SIGUIENTE SI NO ES LA ULTIMA
            if (dgvPropietarios.SelectedRows.Count > 0) {
                if (dgvPropietarios.SelectedRows[0].Index < dgvPropietarios.Rows.Count - 1) {
                    dgvPropietarios.Rows[dgvPropietarios.SelectedRows[0].Index + 1].Selected = true;
                }
            } else {
                dgvPropietarios.Rows[0].Selected = true;
            }
        }

        //EVENTO CLICK BOTON ANTERIOR PROPIETARIOS
        private void btnAnteriorPropietario_Click(object sender, EventArgs e) {
            //COMPROBAMOS SI HAY ALGUNA FILA SELECCIONADA
            //  SI NO HAY SELECCIONAMOS LA 0
            //  SI HAY SELECCIONAMOS LA SIGUIENTE SI NO ES LA PRIMERA
            if (dgvPropietarios.SelectedRows.Count > 0) {
                if (dgvPropietarios.SelectedRows[0].Index > 0) {
                    dgvPropietarios.Rows[dgvPropietarios.SelectedRows[0].Index - 1].Selected = true;
                }
            } else {
                dgvPropietarios.Rows[0].Selected = true;
            }
        }

        //EVENTO CLICK BOTON ANTERIOR PROPIEDADES
        private void btnAnteriorPropiedad_Click(object sender, EventArgs e) {
            //COMPROBAMOS SI HAY ALGUNA FILA SELECCIONADA
            //  SI NO HAY SELECCIONAMOS LA 0
            //  SI HAY SELECCIONAMOS LA SIGUIENTE SI NO ES LA PRIMERA
            if (dgvPropiedades.SelectedRows.Count > 0) {
                if (dgvPropiedades.SelectedRows[0].Index > 0) {
                    dgvPropiedades.Rows[dgvPropiedades.SelectedRows[0].Index - 1].Selected = true;
                }
            } else {
                dgvPropiedades.Rows[0].Selected = true;
            }
        }

        //EVENTO CLICK BOTON POSTERIOR PROPIEDADES
        private void btnPosteriorPropiedad_Click(object sender, EventArgs e) {
            //COMPROBAMOS SI HAY ALGUNA FILA SELECCIONADA
            //  SI NO HAY SELECCIONAMOS LA 0
            //  SI HAY SELECCIONAMOS LA SIGUIENTE SI NO ES LA ULTIMA
            if (dgvPropiedades.SelectedRows.Count > 0) {
                if (dgvPropiedades.SelectedRows[0].Index < dgvPropiedades.Rows.Count - 1) {
                    dgvPropiedades.Rows[dgvPropiedades.SelectedRows[0].Index + 1].Selected = true;
                }
            } else {
                dgvPropiedades.Rows[0].Selected = true;
            }
        }
    }
}
