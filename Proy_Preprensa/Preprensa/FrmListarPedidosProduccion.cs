using Aspose.Cells;
using Preprensa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preprensa
{
    public partial class FrmListarPedidosProduccion : Form
    {
        DataTable Dt = new DataTable();
        public FrmListarPedidosProduccion()
        {
            InitializeComponent();
        }
        private void FrmListarPedidosProduccion_Load(object sender, EventArgs e)
        {
            this.cargar();
        }


        public void cargar()
        {
            Data.Produccion dProducion = new Data.Produccion();
            try
            {
                Dt = dProducion.ListarPedidos();
                dgListarProduccion.DataSource = Dt;

                DataGridViewButtonColumn Coldescargar = new DataGridViewButtonColumn();
                Coldescargar.Name = "Descargar";
                Coldescargar.HeaderText = "Descargar";
                this.dgListarProduccion.Columns.Add(Coldescargar);

                DataGridViewButtonColumn ColAbrir = new DataGridViewButtonColumn();
                ColAbrir.Name = "Abrir";
                ColAbrir.HeaderText = "Abrir";
                this.dgListarProduccion.Columns.Add(ColAbrir);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AbrirFormulario(int NumOperacion)
        {
            try
            {
                FrmRegistrarPedidosProduccion Vista = new FrmRegistrarPedidosProduccion(NumOperacion);
                Vista.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DescargarReporte(int NumPedido) {
            Data.Produccion dProducion = new Data.Produccion();
            String pathTemplate = String.Empty;
            String ruta         = String.Empty;
            int Fila            = 0;
            Workbook book       = null;
            Worksheet pReporte  = null;
            try
            {
                DataSet ds = new DataSet();
                ds = dProducion.ReporteDiario(NumPedido);
                ruta = Path.Combine(Path.GetTempPath(), "ReporteDiario.xlsx");
                if (ds.Tables[0].Rows.Count > 0 || ds.Tables[1].Rows.Count > 0)
                {
                    Aspose.Cells.License license = new Aspose.Cells.License();
                    license.SetLicense("Aspose.Cells.lic");
                    pathTemplate = AppDomain.CurrentDomain.BaseDirectory + @"Resources\" + "plantilla.xlsx";
                    book = new Workbook(pathTemplate);
                    Aspose.Cells.Worksheet wstemplate = book.Worksheets[0];
                    book.Worksheets.Clear();
                    pReporte = book.Worksheets.Add("Reporte Diario");
                    pReporte.Copy(wstemplate);

                    DataRow vrows = ds.Tables[0].Rows[0];
                    pReporte.Cells[4, 3].Value = vrows[1].ToString();
                    pReporte.Cells[5, 3].Value = vrows[2].ToString();
                    Fila = 7;
                    foreach (DataRow Dr in ds.Tables[1].Rows)
                    {
                        pReporte.Cells[Fila, 1].Value = Dr[1].ToString();
                        pReporte.Cells[Fila, 2].Value = Dr[2].ToString();
                        pReporte.Cells[Fila, 3].Value = Dr[3].ToString();
                        pReporte.Cells[Fila, 4].Value = Dr[4].ToString();
                        pReporte.Cells[Fila, 5].Value = Dr[5].ToString();
                        pReporte.Cells[Fila, 6].Value = Dr[6].ToString();
                        pReporte.Cells[Fila, 7].Value = Dr[7].ToString();
                        pReporte.Cells[Fila, 8].Value = Dr[8].ToString();
                        pReporte.Cells[Fila, 9].Value = Dr[9].ToString();
                        pReporte.Cells[Fila, 10].Value = Dr[10].ToString();
                        Fila++;
                    }
                }
                book.Save(ruta);
                Process.Start(ruta);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

   




        private void dgListarProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
                          
        }

        private void dgListarProduccion_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int NumOperacion = 0;
            try {
                int indice = e.ColumnIndex;
                if (indice != -1) {
                    if (this.dgListarProduccion.Columns[e.ColumnIndex].Name == "Descargar")
                    {
                        NumOperacion = (int)this.dgListarProduccion.Rows[e.RowIndex].Cells["N°Pedido"].Value;
                        // NumOperacion = int.Parse(dgListarProduccion.Rows[dgListarProduccion.CurrentRow.Index].Cells[0].Value.ToString());
                        this.DescargarReporte(NumOperacion);
                    }
                   else if (this.dgListarProduccion.Columns[e.ColumnIndex].Name == "Abrir")
                    {
                        NumOperacion = (int)this.dgListarProduccion.Rows[e.RowIndex].Cells["N°Pedido"].Value;
                        this.AbrirFormulario(NumOperacion);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Aviso");
            }
            
           
        }

        private void dgListarProduccion_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgListarProduccion.Columns[e.ColumnIndex].Name == "Descargar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dgListarProduccion.Rows[e.RowIndex].Cells["Descargar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\excel.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left +3 , e.CellBounds.Top + 3);
                this.dgListarProduccion.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dgListarProduccion.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }

           else if (e.ColumnIndex >= 0 && this.dgListarProduccion.Columns[e.ColumnIndex].Name == "Abrir" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dgListarProduccion.Rows[e.RowIndex].Cells["Abrir"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\abrir.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left +3 , e.CellBounds.Top + 3);
                this.dgListarProduccion.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dgListarProduccion.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }

        }
    }
}
