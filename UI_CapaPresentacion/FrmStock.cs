using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_CapaPresentacion
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }




        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0R0DL9B\SQLEXPRESS;Initial Catalog=TP_TecnicasProg;Integrated Security=True");

        //public void agregar(string descripcion, string precio, string id_producto)
        //{
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTO (ID_PRODUCTO,DESCRIPCION,PRECIO) VALUES (@ID,@DESCRIPCION,@PRECIO)");
        //        cmd.Parameters.AddWithValue("ID", id_producto);
        //        cmd.Parameters.AddWithValue("DESCRIPCION", descripcion);
        //        cmd.Parameters.AddWithValue("PRECIO", precio);

        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);


        //        if (dt.Rows.Count == 1)
        //        {
        //            MessageBox.Show("AGREGO");
        //            // this.Hide();
        //            //if (dt.Rows[0][0].ToString() == "")
        //            //{
        //            //    /*FrmAdmin formularioDeAdministrador = new FrmAdmin();
        //            //    this.Hide();*/

        //            //    FrmAdmin frmAdmin = new FrmAdmin();
        //            //    //this.Hide();
        //            //    frmAdmin.Show();

        //            //    //new FrmAdmin().ShowDialog();
        //            //}
        //            //else if (dt.Rows[0][0].ToString() == "Cliente")
        //            //{
        //            //    FrmCliente cliente = new FrmCliente();
        //            //    cliente.Show();
        //            //}
        //            //else if (dt.Rows[0][0].ToString() == "Gerente")
        //            //{
        //            //    new FrmGerente().Show();
        //            //}
        //            //else if (dt.Rows[0][0].ToString() == "logistica")
        //            //{
        //            //    Frmencargadoinventario frmencargadoinventario = new Frmencargadoinventario();
        //            //    frmencargadoinventario.Show();
        //            //}
        //        }
        //        else
        //        {
        //            MessageBox.Show("NO SE AGREGO");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmIniciarsesion patallaPrincipal = new FrmIniciarsesion();
            this.Hide();

            patallaPrincipal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FrmStock_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            // 
            //try
            //{

            //    string query = "INSERT INTO PRODUCTO (DESCRIPCION,PRECIO) VALUES (@DESCRIPCION,@PRECIO)";
            //    con.Open();
            //    SqlCommand Comando = new SqlCommand(query, con);
            //    Comando.Parameters.AddWithValue("@DESCRIPCION", txtdescripcion.Text);
            //    Comando.Parameters.AddWithValue("@PRECIO", txtprecio.Text);
            //    Comando.ExecuteNonQuery(); nos tira un exepcion no controlada que no nos deja agregar productos:(
            //    MessageBox.Show("agregado");


            //}
            //catch
            //{
            //    MessageBox.Show("no agregado");
            //}
            //finally { MessageBox.Show("agregao1"); }

            ////agregar(txtbdescripcion.Text,txtprecio.Text,txtid.Text);

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            FrmIniciarsesion frmIniciarsesion = new FrmIniciarsesion();
            this.Hide();
            frmIniciarsesion.Show();
        }

        private void txtbid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
