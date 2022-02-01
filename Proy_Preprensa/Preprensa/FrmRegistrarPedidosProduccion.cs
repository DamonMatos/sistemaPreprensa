using Aspose.Cells;
using Preprensa.Data;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace Preprensa
{
    public partial class FrmRegistrarPedidosProduccion : Form
    {
        public int NumArticulo;
        public int NumActividad;
        public int Tipo = 0;
        public FrmRegistrarPedidosProduccion()
        {
            InitializeComponent();
        }


        public FrmRegistrarPedidosProduccion(int NumOperacion)
        {
            InitializeComponent();
            try
            {
                if (Login.Nivel == 1)
                {
                    gbColaborador.Visible = true;
                    grpcordinador.Visible = false;
                }
                else {
                    gbColaborador.Visible = false;
                    grpcordinador.Visible = true;
                    txtcomentariocoordinador.Enabled = false;
                    BtnGuardarComentario.Enabled = false;
                }
                DataSet dts = new DataSet();
                DataTable dtretorno = new DataTable();
                Actividades ObjActividades = new Actividades();
                Data.Produccion dProducion = new Data.Produccion();
                dts = dProducion.BuscarPedido(NumOperacion);
                if (dts.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dts.Tables[0].Rows[0];
                    txtNumproducion.Text    = dr[0].ToString();
                    txtEstado.Text          = dr[1].ToString();
                    dtpfecha.Text           = dr[2].ToString();
                    txtNombreElaborado.Text = dr[3].ToString();
                    txtCargoElaborado.Text  = dr[4].ToString();
                    txtNombreCliente.Text   = dr[5].ToString();
                    dgDetalle.DataSource    = dts.Tables[1];

                    dgDetalle.Columns[0].Visible = false;      

                    ObjActividades.tipo         = 1;
                    ObjActividades.NumProducion = int.Parse(txtNumproducion.Text);
                    dgactividades.DataSource    = dProducion.BuscarActividades(ObjActividades);
                    dgactividades.Columns[0].Visible = false;
                }
                BtnModificar.Enabled = false;
                BtnGuardar.Enabled = false;
                BtnNuevo.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FrmRegistrarPedidosProduccion_Load(object sender, EventArgs e)
        {

        }
       

        private void dgDetalle_Click(object sender, EventArgs e)
        {
            Data.Produccion dProducion = new Data.Produccion();
            Actividades ObjActividades = new Actividades();
            try
            {
                NumArticulo                  = int.Parse(dgDetalle.Rows[dgDetalle.CurrentRow.Index].Cells[0].Value.ToString());
                txtcodigo.Text               = dgDetalle.Rows[dgDetalle.CurrentRow.Index].Cells[1].Value.ToString();
                txtLibro.Text                = dgDetalle.Rows[dgDetalle.CurrentRow.Index].Cells[2].Value.ToString();
                ObjActividades.tipo          = 2;
                ObjActividades.NumProducion  = int.Parse(txtNumproducion.Text);
                ObjActividades.IdArticulo    = NumArticulo;
                dgactividades.DataSource     = dProducion.BuscarActividades(ObjActividades);
                BtnNuevo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgactividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                if (Login.Nivel == 1)
                {
                    NumActividad = int.Parse(dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[0].Value.ToString());
                    txtactividad.Text = dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[2].Value.ToString();
                    dtpfecharegistro.Text = dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[3].Value.ToString();
                    txthorainicio.Text = dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[4].Value.ToString();
                    txthorafin.Text = dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[5].Value.ToString();
                    txtcancorrecion.Text = dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[6].Value.ToString();
                    txtcanpagina.Text = dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[7].Value.ToString();
                    txtcomentario.Text = dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[8].Value.ToString();
                    this.DesaHabilitar();
                    BtnModificar.Enabled = true;
                    BtnNuevo.Enabled = false;
                }
                else { 
                    NumActividad = int.Parse(dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[0].Value.ToString());
                    txtcomentariocoordinador.Text = dgactividades.Rows[dgactividades.CurrentRow.Index].Cells[9].Value.ToString();
                    txtcomentariocoordinador.Enabled = true;
                    BtnGuardarComentario.Enabled = true;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Habilitar() {
            txtactividad.Enabled     = true;
            dtpfecharegistro.Enabled = true;
            txthorainicio.Enabled    = true;
            txthorafin.Enabled       = true;
            txtcancorrecion.Enabled  = true;
            txtcanpagina.Enabled     = true;
            txtcomentario.Enabled    = true;
        }

        public void DesaHabilitar()
        {
            txtactividad.Enabled = false;
            dtpfecharegistro.Enabled = false;
            txthorainicio.Enabled = false;
            txthorafin.Enabled = false;
            txtcancorrecion.Enabled = false;
            txtcanpagina.Enabled = false;
            txtcomentario.Enabled = false;
        }

        public void Limipiar() {
            txtactividad.Text = "";
            txthorainicio.Text = "";
            txthorafin.Text = "";
            txtcancorrecion.Text = "";
            txtcanpagina.Text = "";
            txtcomentario.Text = "";
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Habilitar();
            this.Limipiar();
            Tipo = 1;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            String mensaje = String.Empty;
            try
            {
                DataTable dtretorno = new DataTable();
                Data.Produccion dProducion = new Data.Produccion();
                Actividades ObjActividades = new Actividades();
                ObjActividades.tipo = Tipo;
                ObjActividades.NumProducion = int.Parse(txtNumproducion.Text);
                ObjActividades.IdActividad = NumActividad;
                ObjActividades.IdArticulo = NumArticulo;
                ObjActividades.actividad = txtactividad.Text;
                ObjActividades.fecharegistro = dtpfecharegistro.Text;
                ObjActividades.horainicio = txthorainicio.Text;
                ObjActividades.horafin = txthorafin.Text;
                ObjActividades.cantPaginas = txtcanpagina.Text;
                ObjActividades.cantcorreciones = txtcancorrecion.Text;
                ObjActividades.comentariocolaborador = txtcomentario.Text;
                ObjActividades.comentariocoordinador = "";
                dtretorno = dProducion.RegistrarActividades(ObjActividades);
                DataRow dr = dtretorno.Rows[0];
                mensaje = dr["Mensaje"].ToString();
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgactividades.DataSource = dProducion.BuscarActividades(ObjActividades);
                BtnGuardar.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnModificar.Enabled = true;
                this.Limipiar();
                this.DesaHabilitar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            this.Habilitar();
            Tipo = 3;
            BtnNuevo.Enabled = false;
            BtnGuardar.Enabled = true;
        }

      

        private void BtnGuardarComentario_Click(object sender, EventArgs e)
        {
            String mensaje = String.Empty;
            try
            {
                DataTable dtretorno = new DataTable();
                Data.Produccion dProducion = new Data.Produccion();
                Actividades ObjActividades = new Actividades();
                Tipo = 2;
                ObjActividades.tipo = Tipo;
                ObjActividades.NumProducion = int.Parse(txtNumproducion.Text);
                ObjActividades.IdActividad = NumActividad;
                ObjActividades.IdArticulo = NumArticulo;
                ObjActividades.comentariocoordinador = txtcomentariocoordinador.Text;
                dtretorno = dProducion.RegistrarActividades(ObjActividades);
                DataRow dr = dtretorno.Rows[0];
                mensaje = dr["Mensaje"].ToString();
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgactividades.DataSource = dProducion.BuscarActividades(ObjActividades);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

