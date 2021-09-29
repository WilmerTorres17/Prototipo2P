using Prototipo1P.Clases;
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
    public partial class frmCompraDetalle : Form
    {
        public frmCompraDetalle()
        {
            InitializeComponent();

            pnlIconoP.Visible = false;
            pnlMP.Visible = false;
            pnlEP.Visible = false;

            Pagos pago = new Pagos();
            pago.funLlenarCombo(cbxTP);
            pago.funLlenarComboEnc(cbxDV);

            funCargarTabla(null);
        }

        private void pnlPagos_MouseClick(object sender, MouseEventArgs e)
        {
            frmCompraDetalle Pagos = new frmCompraDetalle();
            Pagos.Visible = true;

            Visible = false;

        }

        private void pnlCobros_MouseClick(object sender, MouseEventArgs e)
        {
            frmCompraEncabezado cobros = new frmCompraEncabezado();
            cobros.Visible = true;

            Visible = false;
        }

        private void pnlIconoP_MouseClick(object sender, MouseEventArgs e)
        {
            String codigoC = txtCodigoCo.Text;
            String tipoPago = cbxTP.SelectedValue.ToString();
            String documento = cbxDV.SelectedValue.ToString();
            String cantidadP = txtCP.Text;

            Pagos pago = new Pagos(codigoC, tipoPago, documento, cantidadP);

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
                        pago.funInsertarPago();

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
                    pago.funInsertarPago();

                    txtSaldoVenta.Text = resta.ToString();
                    funCargarTabla(null);
                    funVaciarCampos();
                }

                //cobro.funModificarEnc(documento,resta);
            }
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {

        }

        private void funCargarTabla(string dato)
        {
            List<Pagos> lista = new List<Pagos>();
            Pagos pago = new Pagos();

            dvgPago.DataSource = pago.consulta(dato);
        }

        public void funVaciarCampos()
        {
            txtCodigoCo.Text = "";
            cbxTP.SelectedIndex = 1;
            txtCP.Text = "";
            cbxDV.SelectedIndex = 1;
            txtProveedor.Text = "";
            txtSaldoVenta.Text = "";
        }

        private void cbxDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String documentoCompra = cbxDV.SelectedValue.ToString();
            Cobros cobro = new Cobros();

            String proveedor = cobro.funBuscarDato("codigo_proveedor", "compras_encabezado", "documento_compraenca", documentoCompra);
            String saldo = cobro.funBuscarDato("total_compraenca", "compras_encabezado", "documento_compraenca", documentoCompra);
            String nombreProveedor = cobro.funBuscarDato("nombre_proveedor", "proveedores", "codigo_proveedor", proveedor);
            txtProveedor.Text = nombreProveedor;
            txtSaldoVenta.Text = saldo;
        }

        private void pnlMP_MouseClick(object sender, MouseEventArgs e)
        {
            String codigoC = txtCodigoCo.Text;
            String tipoPago = cbxTP.SelectedValue.ToString();
            String documento = cbxDV.SelectedValue.ToString();
            String cantidadP = txtCP.Text;

            Pagos pago = new Pagos(codigoC, tipoPago, documento, cantidadP);

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
                        pago.funModificar(codigoC);

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
                    pago.funModificar(codigoC);

                    txtSaldoVenta.Text = resta.ToString();
                    funCargarTabla(null);
                    funVaciarCampos();
                }

                //cobro.funModificarEnc(documento,resta);
            }
        }

        private void pnlLlenarCamp_MouseClick(object sender, MouseEventArgs e)
        {
            Cobros cobro = new Cobros();

            txtCodigoCo.Text = dvgPago.CurrentRow.Cells[0].Value.ToString();
            cbxTP.SelectedValue = dvgPago.CurrentRow.Cells[1].Value.ToString();
            cbxDV.SelectedValue = dvgPago.CurrentRow.Cells[2].Value.ToString();
            txtCP.Text = dvgPago.CurrentRow.Cells[3].Value.ToString();

            String proveedor = cobro.funBuscarDato("codigo_proveedor", "compras_encabezado", "documento_compraenca", dvgPago.CurrentRow.Cells[2].Value.ToString());
            String saldo = cobro.funBuscarDato("total_compraenca", "compras_encabezado", "documento_compraenca", dvgPago.CurrentRow.Cells[2].Value.ToString());

            txtProveedor.Text = proveedor;
            txtSaldoVenta.Text = saldo;
        }

        private void pnlEP_MouseClick(object sender, MouseEventArgs e)
        {
            Pagos pago = new Pagos();

            String id = txtCodigoCo.Text;

            pago.funEliminar(id);
            funCargarTabla(null);
            funVaciarCampos();
        }

        private void lblIngresarP_MouseClick(object sender, MouseEventArgs e)
        {
            pnlIconoP.Visible = true;
            pnlMP.Visible = false;
            pnlEP.Visible = false;
        }

        private void lblModificarP_MouseClick(object sender, MouseEventArgs e)
        {
            pnlIconoP.Visible = false;
            pnlMP.Visible = true;
            pnlEP.Visible = false;
        }

        private void lblEliminarP_MouseClick(object sender, MouseEventArgs e)
        {
            pnlIconoP.Visible = false;
            pnlMP.Visible = false;
            pnlEP.Visible = true;
        }

        private void pnlIconoB_MouseClick(object sender, MouseEventArgs e)
        {
            String buscarTxt = txtBuscarP.Text;
            funCargarTabla(buscarTxt);
        }
    }
}
