using Preprensa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preprensa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static int Nivel;

        private void btningresar_Click(object sender, EventArgs e)
        {
            FrmRegistrarPedidosProduccion Vista = new FrmRegistrarPedidosProduccion();
            int Estado   = 0;
            DataTable Dt = new DataTable();
            Data.Produccion Usuario = new Data.Produccion();            
            MenuPrincipal Menu = new MenuPrincipal();
            try {
                String Usu   = txtUsuario.Text;
                String Cont  = txtcontrasena.Text;               
                Dt = Usuario.InicioSesion(Usu, Cont);
                if (Dt.Rows.Count > 0){                   
                    DataRow Dr = Dt.Rows[0];
                    Estado = int.Parse(Dr["Estado"].ToString());
                    if (Estado == 1){
                        Nivel = int.Parse(Dr["Nivel"].ToString());                     
                        Menu.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show(Dr["Resultado"].ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtcontrasena.Text = "";
                        txtUsuario.Text    = "";
                    }                   
                }
                else
                {
                    MessageBox.Show("Problemas de conexion con el servidor de DB", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtcontrasena.Text = "";
                    txtUsuario.Text    = "";
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
