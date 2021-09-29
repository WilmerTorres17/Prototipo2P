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
    public class Cobros
    {
        //Atributos
        String codigoCobro;
        String tipoPago;
        String documentoVenta;
        String cantidadPago;

        public string CodigoCobro { get => codigoCobro; set => codigoCobro = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public string DocumentoVenta { get => documentoVenta; set => documentoVenta = value; }
        public string CantidadPago { get => cantidadPago; set => cantidadPago = value; }

        public Cobros(string codigoCobro, string tipoPago, string documentoVenta, string cantidadPago)
        {
            this.codigoCobro = codigoCobro;
            this.tipoPago = tipoPago;
            this.documentoVenta = documentoVenta;
            this.cantidadPago = cantidadPago;
        }

        public Cobros()
        {

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

            String psql = "SELECT documento_ventaenca FROM ventas_encabezado";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(llenarCombo);

                DataTable dt = new DataTable();
                data.Fill(dt);

                documentoEnc.ValueMember = "documento_ventaenca";
                documentoEnc.DisplayMember = "documento_ventaenca";
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

        public void funInsertarCobro()
        {
            String psql = "INSERT INTO Cobros(codigo_cobro,tipo_pago,documento_venta,cantidad_pago)" +
             " VALUES('" + codigoCobro + "' , '" + tipoPago + "' , '" + documentoVenta + "' , '"+cantidadPago+"')";

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

        public void funModificarEnc(String idModificar,float resta)
        {
            String pSqlModificar = "UPDATE ventas_encabezado SET total_ventaenca='" + resta + "' WHERE documento_ventaenca='" + documentoVenta + "'";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarPuesto = new MySqlCommand(pSqlModificar, conexionBD);
                modificarPuesto.ExecuteNonQuery();
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

        public List<Object> consulta(String dato)
        {
            MySqlDataReader reader = null;
            List<Object> lista = new List<Object>();
            String sql;
            String nombreTipo;

            if (dato == null)
            {
                sql = "SELECT * FROM Cobros";
            }
            else
            {
                sql = "SELECT * FROM Cobros WHERE codigo_cobro LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarPuesto = new MySqlCommand(sql, conexionBD);
                reader = buscarPuesto.ExecuteReader();


                while (reader.Read())
                {

                    Cobros cobro = new Cobros();

                    cobro.codigoCobro = reader.GetString("codigo_cobro");
                    //nombreTipo = funBuscarDato("nombre_tipo", "Tipo_Pago", "codigo_pago", reader.GetString("tipo_pago"));
                    cobro.tipoPago = reader.GetString("tipo_pago");
                    cobro.documentoVenta = reader.GetString("documento_venta");
                    cobro.cantidadPago = reader.GetString("cantidad_pago");

                    lista.Add(cobro);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }

        public int obtenerNombreT(String codigoP)
        {
            MySqlDataReader leer = null;
            int tipoP = 0;

            String pSqlBuscar = "SELECT codigo_pago from Tipo_Pago WHERE idPermiso='" + codigoP + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscarIDtipoPermiso = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarIDtipoPermiso.ExecuteReader();
                while (leer.Read())
                {
                    tipoP = int.Parse(leer.GetString("idTipoPermiso"));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Leer los datos " + ex.Message);
            }

            return tipoP;

        }

        public void funModificar(String idModificar)
        {
            String pSqlModificar = "UPDATE Cobros SET tipo_pago='" + tipoPago + "', documento_venta='"+documentoVenta+ "', cantidad_pago='"+cantidadPago+ "' WHERE codigo_cobro='" + idModificar + "'";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarCobro = new MySqlCommand(pSqlModificar, conexionBD);
                modificarCobro.ExecuteNonQuery();
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
            String pSqlModificar = "delete FROM Cobros WHERE codigo_cobro=" + idEliminar;

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand EliminarCobro = new MySqlCommand(pSqlModificar, conexionBD);
                EliminarCobro.ExecuteNonQuery();
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
