using MySql.Data.MySqlClient;
using Prototipo1P.Clases;
using sistema_reparto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    public partial class frmCompraEncabezado : Form
    {
        public frmCompraEncabezado()
        {
            InitializeComponent();

            pnlMC.Visible = false;
            pnlIconoC.Visible = false;
            pnlEliminar.Visible = false;
            lblCliente.Visible = false;
            txtCliente.Visible = false;


            Cobros cobro = new Cobros();
            cobro.funLlenarCombo(cbxTC);
            cobro.funLlenarComboEnc(cbxDV);
        }

        private void frmCobros_Load(object sender, EventArgs e)
        {
            funCargarTabla(null);
        }

        private void cbxDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String documentoVenta = cbxDV.SelectedValue.ToString();
            Cobros cobro = new Cobros();

            String cliente = cobro.funBuscarDato("codigo_cliente", "ventas_encabezado", "documento_ventaenca",documentoVenta);
            String saldo = cobro.funBuscarDato("total_ventaenca", "ventas_encabezado", "documento_ventaenca", documentoVenta);
            String nombreCliente = cobro.funBuscarDato("nombre_cliente", "clientes", "codigo_cliente", cliente);
            txtCliente.Text = nombreCliente;
            txtSaldoVenta.Text = saldo;
        }

        private void pnlIconoC_MouseClick(object sender, MouseEventArgs e)
        {
            String codigoC = txtCodigoCo.Text;
            String tipoPago = cbxTC.SelectedValue.ToString();
            String documento = cbxDV.SelectedValue.ToString();
            String cantidadP = txtCP.Text;

            Cobros cobro = new Cobros(codigoC,tipoPago,documento,cantidadP);

            float cantidadNueva = float.Parse(txtCP.Text);
            float cantidadVieja = float.Parse(txtSaldoVenta.Text);

            if(cantidadNueva > cantidadVieja)
            {
                MessageBox.Show("No puede ingresar un numero mayor que la cantidad Anterior");
            }
            else
            {
                float resta = cantidadVieja - cantidadNueva;

                if(tipoPago == "1")
                {
                    if(cantidadNueva == cantidadVieja)
                    {
                        cobro.funInsertarCobro();

                        txtSaldoVenta.Text = resta.ToString();
                        funCargarTabla(null);
                        funVaciarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese el monto total!");
                    }
                }

                if(tipoPago == "2")
                {
                    cobro.funInsertarCobro();

                    txtSaldoVenta.Text = resta.ToString();
                    funCargarTabla(null);
                    funVaciarCampos();
                }
                
                //cobro.funModificarEnc(documento,resta);
            }
        }

        private void lblIngresarC_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMC.Visible = false;
            pnlIconoC.Visible = true;
            pnlEliminar.Visible = false;
            lblCliente.Visible = false;
            txtCliente.Visible = false;


            Cobros cobro = new Cobros();
           funCargarTabla(null);
        }

        private void funCargarTabla(string dato)
        {
            List<Cobros> lista = new List<Cobros>();
            Cobros cobro = new Cobros();

            dvgCobro.DataSource = cobro.consulta(dato);
        }

        public void funVaciarCampos()
        {
            txtCodigoCo.Text = "";
            cbxTC.SelectedIndex = 1;
            txtCP.Text = "";
            cbxDV.SelectedIndex = 1;
            txtCliente.Text = "";
            txtSaldoVenta.Text = "";
        }

        private void pnlLlenarCamp_MouseClick(object sender, MouseEventArgs e)
        {

            Cobros cobro = new Cobros();

            txtCodigoCo.Text = dvgCobro.CurrentRow.Cells[0].Value.ToString();
            cbxTC.SelectedValue = dvgCobro.CurrentRow.Cells[1].Value.ToString();
            cbxDV.SelectedValue = dvgCobro.CurrentRow.Cells[2].Value.ToString();
            txtCP.Text = dvgCobro.CurrentRow.Cells[3].Value.ToString();

            String cliente = cobro.funBuscarDato("codigo_cliente", "ventas_encabezado", "documento_ventaenca", dvgCobro.CurrentRow.Cells[2].Value.ToString());
            String saldo = cobro.funBuscarDato("total_ventaenca", "ventas_encabezado", "documento_ventaenca", dvgCobro.CurrentRow.Cells[2].Value.ToString());

            txtCliente.Text = cliente;
            txtSaldoVenta.Text = saldo;
        }

        private void pnlMC_MouseClick(object sender, MouseEventArgs e)
        {
            String codigoC = txtCodigoCo.Text;
            String tipoPago = cbxTC.SelectedValue.ToString();
            String documento = cbxDV.SelectedValue.ToString();
            String cantidadP = txtCP.Text;

            Cobros cobro = new Cobros(codigoC, tipoPago, documento, cantidadP);

            float cantidadNueva = float.Parse(txtCP.Text);
            float cantidadVieja = float.Parse(txtSaldoVenta.Text);

            if (cantidadNueva > cantidadVieja)
            {
                MessageBox.Show("No puede ingresar un numero mayor que la cantidad Anterior");
            }
            else
            {
                float resta = cantidadVieja - cantidadNueva;

                if (tipoPago == "1")
                {
                    if (cantidadNueva == cantidadVieja)
                    {
                        cobro.funModificar(codigoC);

                        txtSaldoVenta.Text = resta.ToString();
                        funCargarTabla(null);
                        funVaciarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese el monto total!");
                    }
                }

                if (tipoPago == "2")
                {
                    cobro.funModificar(codigoC);

                    txtSaldoVenta.Text = resta.ToString();
                    funCargarTabla(null);
                    funVaciarCampos();
                }

                //cobro.funModificarEnc(documento,resta);
            }
        }

        private void pnlEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            Cobros cobro = new Cobros();

            String id = txtCodigoCo.Text;

            cobro.funEliminar(id);
            funCargarTabla(null);
            funVaciarCampos();

        }

        private void pnlCobros_MouseClick(object sender, MouseEventArgs e)
        {
            frmCompraEncabezado cobros = new frmCompraEncabezado();
            cobros.Visible = true;

            Visible = false;
        }

        private void pnlPagos_MouseClick(object sender, MouseEventArgs e)
        {
            frmCompraDetalle Pagos = new frmCompraDetalle();
            Pagos.Visible = true;

            Visible = false;
        }

        private void pnlIconoBC_MouseClick(object sender, MouseEventArgs e)
        {
            String buscartxt = txtBuscarC.Text;
            funCargarTabla(buscartxt);
        }

        private void lblModificarC_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMC.Visible = true;
            pnlIconoC.Visible = false;
            pnlEliminar.Visible = false;
            lblCliente.Visible = false;
            txtCliente.Visible = false;
        }

        private void lblEliminarC_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMC.Visible = false;
            pnlIconoC.Visible = false;
            pnlEliminar.Visible = true;
            lblCliente.Visible = false;
            txtCliente.Visible = false;
        }

        private void lblProto_Click(object sender, EventArgs e)
        {

        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pnlPagos_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmCompraEncabezado obj = new frmCompraEncabezado();
            obj.Visible = true;
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
