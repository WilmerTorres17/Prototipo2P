using MySql.Data.MySqlClient;
using sistema_reparto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P.Clases
{
    public class Pagos
    {
        //Atributos
        String codigo_pago;
        String tipo_pago;
        String documento_compra;
        String cantidad_pago;

        public Pagos()
        {

        }

        public string Codigo_pago { get => codigo_pago; set => codigo_pago = value; }
        public string Tipo_pago { get => tipo_pago; set => tipo_pago = value; }
        public string Documento_compra { get => documento_compra; set => documento_compra = value; }
        public string Cantidad_pago { get => cantidad_pago; set => cantidad_pago = value; }

        public Pagos(string codigo_pago, string tipo_pago, string documento_compra, string cantidad_pago)
        {
            this.codigo_pago = codigo_pago;
            this.tipo_pago = tipo_pago;
            this.documento_compra = documento_compra;
            this.cantidad_pago = cantidad_pago;
        }

        public void funLlenarCombo(ComboBox tipoPago)
        {
            tipoPago.DataSource = null;
            tipoPago.Items.Clear();

            String psql = "SELECT codigo_pago,nombre_tipo FROM Tipo_Pago";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(llenarCombo);

                DataTable dt = new DataTable();
                data.Fill(dt);

                tipoPago.ValueMember = "codigo_pago";
                tipoPago.DisplayMember = "nombre_tipo";
                tipoPago.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void funLlenarComboEnc(ComboBox documentoEnc)
        {
            documentoEnc.DataSource = null;
            documentoEnc.Items.Clear();

            String psql = "SELECT documento_compraenca FROM compras_encabezado";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(llenarCombo);

                DataTable dt = new DataTable();
                data.Fill(dt);

                documentoEnc.ValueMember = "documento_compraenca";
                documentoEnc.DisplayMember = "documento_compraenca";
                documentoEnc.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public String funBuscarDato(String dato, String tabla, String idBuscar, String id)
        {
            MySqlDataReader leer = null;
            String sql;
            String datoEncontrado = "";

            sql = "SELECT" + " " + dato + " " + "FROM" + " " + tabla + " " + "WHERE" + " " + idBuscar + "=" + id;

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand buscarPuestos = new MySqlCommand(sql, conexionBD);
                leer = buscarPuestos.ExecuteReader();

                while (leer.Read())
                {
                    datoEncontrado = leer.GetString(dato);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            return datoEncontrado;
        }

        public void funInsertarPago()
        {
            String psql = "INSERT INTO Pagos(codigo_pago,tipo_pago,documento_compra,cantidad_pago)" +
             " VALUES('" + codigo_pago + "' , '" + tipo_pago + "' , '" + documento_compra + "' , '" + cantidad_pago + "')";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand insertarCliente = new MySqlCommand(psql, conexionBD);
                insertarCliente.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }


        public List<Object> consulta(String dato)
        {
            MySqlDataReader reader = null;
            List<Object> lista = new List<Object>();
            String sql;
            String nombreTipo;

            if (dato == null)
            {
                sql = "SELECT * FROM Pagos";
            }
            else
            {
                sql = "SELECT * FROM Pagos WHERE codigo_pago LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarPuesto = new MySqlCommand(sql, conexionBD);
                reader = buscarPuesto.ExecuteReader();


                while (reader.Read())
                {

                    Pagos pago = new Pagos();

                    pago.codigo_pago = reader.GetString("codigo_pago");
                    //nombreTipo = funBuscarDato("nombre_tipo", "Tipo_Pago", "codigo_pago", reader.GetString("tipo_pago"));
                    pago.tipo_pago = reader.GetString("tipo_pago");
                    pago.documento_compra = reader.GetString("documento_compra");
                    pago.cantidad_pago = reader.GetString("cantidad_pago");

                    lista.Add(pago);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }


        public void funModificar(String idModificar)
        {
            String pSqlModificar = "UPDATE Pagos SET tipo_pago='" + tipo_pago + "', documento_compra='" + documento_compra + "', cantidad_pago='" + cantidad_pago + "' WHERE codigo_pago='" + idModificar + "'";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarPagos = new MySqlCommand(pSqlModificar, conexionBD);
                modificarPagos.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void funEliminar(String idEliminar)
        {
            String pSqlModificar = "delete FROM Pagos WHERE codigo_pago=" + idEliminar;

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand EliminarPagos= new MySqlCommand(pSqlModificar, conexionBD);
                EliminarPagos.ExecuteNonQuery();
                MessageBox.Show("Datos Eliminados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
