
namespace Prototipo1P
{
    partial class frmCompraEncabezado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraEncabezado));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblProto = new System.Windows.Forms.Label();
            this.pnlPagos = new System.Windows.Forms.Panel();
            this.lblPagos = new System.Windows.Forms.Label();
            this.pnlCobros = new System.Windows.Forms.Panel();
            this.lblCobros = new System.Windows.Forms.Label();
            this.lblTtuloCobros = new System.Windows.Forms.Label();
            this.lblIngresarC = new System.Windows.Forms.Label();
            this.lblModificarC = new System.Windows.Forms.Label();
            this.cbxTC = new System.Windows.Forms.ComboBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.cbxDV = new System.Windows.Forms.ComboBox();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.pnlIconoC = new System.Windows.Forms.Panel();
            this.pnlMC = new System.Windows.Forms.Panel();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.pnlIconoBC = new System.Windows.Forms.Panel();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.dvgCobro = new System.Windows.Forms.DataGridView();
            this.pnlCerrar = new System.Windows.Forms.Panel();
            this.lblSaldoVenta = new System.Windows.Forms.Label();
            this.txtSaldoVenta = new System.Windows.Forms.TextBox();
            this.pnlLlenarCamp = new System.Windows.Forms.Panel();
            this.lblEliminarC = new System.Windows.Forms.Label();
            this.txtCodigoCo = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlPagos.SuspendLayout();
            this.pnlCobros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCobro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.lblProto);
            this.pnlSidebar.Controls.Add(this.pnlPagos);
            this.pnlSidebar.Controls.Add(this.pnlCobros);
            this.pnlSidebar.Location = new System.Drawing.Point(-3, -2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(188, 551);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblProto
            // 
            this.lblProto.AutoSize = true;
            this.lblProto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProto.Location = new System.Drawing.Point(50, 44);
            this.lblProto.Name = "lblProto";
            this.lblProto.Size = new System.Drawing.Size(93, 24);
            this.lblProto.TabIndex = 13;
            this.lblProto.Text = "Compras";
            this.lblProto.Click += new System.EventHandler(this.lblProto_Click);
            // 
            // pnlPagos
            // 
            this.pnlPagos.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPagos.Controls.Add(this.lblPagos);
            this.pnlPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPagos.Location = new System.Drawing.Point(3, 214);
            this.pnlPagos.Name = "pnlPagos";
            this.pnlPagos.Size = new System.Drawing.Size(185, 33);
            this.pnlPagos.TabIndex = 3;
            this.pnlPagos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPagos_MouseClick_1);
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Location = new System.Drawing.Point(54, 11);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(79, 13);
            this.lblPagos.TabIndex = 1;
            this.lblPagos.Text = "Compra Detalle";
            this.lblPagos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPagos_MouseClick_1);
            // 
            // pnlCobros
            // 
            this.pnlCobros.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCobros.Controls.Add(this.lblCobros);
            this.pnlCobros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCobros.Location = new System.Drawing.Point(3, 181);
            this.pnlCobros.Name = "pnlCobros";
            this.pnlCobros.Size = new System.Drawing.Size(185, 33);
            this.pnlCobros.TabIndex = 1;
            this.pnlCobros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCobros_MouseClick);
            // 
            // lblCobros
            // 
            this.lblCobros.AutoSize = true;
            this.lblCobros.Location = new System.Drawing.Point(42, 11);
            this.lblCobros.Name = "lblCobros";
            this.lblCobros.Size = new System.Drawing.Size(103, 13);
            this.lblCobros.TabIndex = 1;
            this.lblCobros.Text = "CompraEncabezado";
            // 
            // lblTtuloCobros
            // 
            this.lblTtuloCobros.AutoSize = true;
            this.lblTtuloCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtuloCobros.Location = new System.Drawing.Point(518, 15);
            this.lblTtuloCobros.Name = "lblTtuloCobros";
            this.lblTtuloCobros.Size = new System.Drawing.Size(230, 25);
            this.lblTtuloCobros.TabIndex = 1;
            this.lblTtuloCobros.Text = "Compra Encabezado";
            // 
            // lblIngresarC
            // 
            this.lblIngresarC.AutoSize = true;
            this.lblIngresarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIngresarC.Location = new System.Drawing.Point(387, 87);
            this.lblIngresarC.Name = "lblIngresarC";
            this.lblIngresarC.Size = new System.Drawing.Size(45, 13);
            this.lblIngresarC.TabIndex = 4;
            this.lblIngresarC.Text = "Ingresar";
            this.lblIngresarC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblIngresarC_MouseClick);
            // 
            // lblModificarC
            // 
            this.lblModificarC.AutoSize = true;
            this.lblModificarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModificarC.Location = new System.Drawing.Point(528, 87);
            this.lblModificarC.Name = "lblModificarC";
            this.lblModificarC.Size = new System.Drawing.Size(50, 13);
            this.lblModificarC.TabIndex = 5;
            this.lblModificarC.Text = "Modificar";
            this.lblModificarC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblModificarC_MouseClick);
            // 
            // cbxTC
            // 
            this.cbxTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTC.FormattingEnabled = true;
            this.cbxTC.Location = new System.Drawing.Point(247, 236);
            this.cbxTC.Name = "cbxTC";
            this.cbxTC.Size = new System.Drawing.Size(121, 21);
            this.cbxTC.TabIndex = 4;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(246, 212);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(67, 13);
            this.lblTipoPago.TabIndex = 3;
            this.lblTipoPago.Text = "Tipo Compra";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(417, 212);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(88, 13);
            this.lblPago.TabIndex = 3;
            this.lblPago.Text = "Cantidad Compra";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(415, 237);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(121, 20);
            this.txtCP.TabIndex = 2;
            // 
            // cbxDV
            // 
            this.cbxDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDV.FormattingEnabled = true;
            this.cbxDV.Location = new System.Drawing.Point(418, 155);
            this.cbxDV.Name = "cbxDV";
            this.cbxDV.Size = new System.Drawing.Size(121, 21);
            this.cbxDV.TabIndex = 4;
            this.cbxDV.SelectedIndexChanged += new System.EventHandler(this.cbxDV_SelectedIndexChanged);
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(417, 131);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(80, 13);
            this.lblDC.TabIndex = 3;
            this.lblDC.Text = "ID Doc Compra";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(598, 356);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(596, 381);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(121, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // pnlIconoC
            // 
            this.pnlIconoC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoC.BackgroundImage")));
            this.pnlIconoC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlIconoC.Location = new System.Drawing.Point(362, 290);
            this.pnlIconoC.Name = "pnlIconoC";
            this.pnlIconoC.Size = new System.Drawing.Size(59, 53);
            this.pnlIconoC.TabIndex = 10;
            this.pnlIconoC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlIconoC_MouseClick);
            // 
            // pnlMC
            // 
            this.pnlMC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMC.BackgroundImage")));
            this.pnlMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMC.Location = new System.Drawing.Point(364, 290);
            this.pnlMC.Name = "pnlMC";
            this.pnlMC.Size = new System.Drawing.Size(56, 53);
            this.pnlMC.TabIndex = 11;
            this.pnlMC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMC_MouseClick);
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEliminar.BackgroundImage")));
            this.pnlEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEliminar.Location = new System.Drawing.Point(367, 290);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(53, 55);
            this.pnlEliminar.TabIndex = 12;
            this.pnlEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlEliminar_MouseClick);
            // 
            // pnlIconoBC
            // 
            this.pnlIconoBC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoBC.BackgroundImage")));
            this.pnlIconoBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoBC.Location = new System.Drawing.Point(906, 156);
            this.pnlIconoBC.Name = "pnlIconoBC";
            this.pnlIconoBC.Size = new System.Drawing.Size(21, 20);
            this.pnlIconoBC.TabIndex = 29;
            this.pnlIconoBC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlIconoBC_MouseClick);
            // 
            // txtBuscarC
            // 
            this.txtBuscarC.Location = new System.Drawing.Point(586, 156);
            this.txtBuscarC.Name = "txtBuscarC";
            this.txtBuscarC.Size = new System.Drawing.Size(314, 20);
            this.txtBuscarC.TabIndex = 27;
            // 
            // dvgCobro
            // 
            this.dvgCobro.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dvgCobro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCobro.Location = new System.Drawing.Point(586, 182);
            this.dvgCobro.Name = "dvgCobro";
            this.dvgCobro.Size = new System.Drawing.Size(448, 150);
            this.dvgCobro.TabIndex = 28;
            // 
            // pnlCerrar
            // 
            this.pnlCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCerrar.BackgroundImage")));
            this.pnlCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCerrar.Location = new System.Drawing.Point(1018, 5);
            this.pnlCerrar.Name = "pnlCerrar";
            this.pnlCerrar.Size = new System.Drawing.Size(21, 22);
            this.pnlCerrar.TabIndex = 30;
            this.pnlCerrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCerrar_MouseClick);
            // 
            // lblSaldoVenta
            // 
            this.lblSaldoVenta.AutoSize = true;
            this.lblSaldoVenta.Location = new System.Drawing.Point(570, 365);
            this.lblSaldoVenta.Name = "lblSaldoVenta";
            this.lblSaldoVenta.Size = new System.Drawing.Size(67, 13);
            this.lblSaldoVenta.TabIndex = 3;
            this.lblSaldoVenta.Text = "Saldo Actual";
            this.lblSaldoVenta.Visible = false;
            // 
            // txtSaldoVenta
            // 
            this.txtSaldoVenta.Enabled = false;
            this.txtSaldoVenta.Location = new System.Drawing.Point(575, 390);
            this.txtSaldoVenta.Name = "txtSaldoVenta";
            this.txtSaldoVenta.Size = new System.Drawing.Size(121, 20);
            this.txtSaldoVenta.TabIndex = 2;
            this.txtSaldoVenta.Visible = false;
            // 
            // pnlLlenarCamp
            // 
            this.pnlLlenarCamp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLlenarCamp.BackgroundImage")));
            this.pnlLlenarCamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLlenarCamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLlenarCamp.Location = new System.Drawing.Point(769, 347);
            this.pnlLlenarCamp.Name = "pnlLlenarCamp";
            this.pnlLlenarCamp.Size = new System.Drawing.Size(119, 22);
            this.pnlLlenarCamp.TabIndex = 31;
            this.pnlLlenarCamp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLlenarCamp_MouseClick);
            // 
            // lblEliminarC
            // 
            this.lblEliminarC.AutoSize = true;
            this.lblEliminarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminarC.Location = new System.Drawing.Point(686, 86);
            this.lblEliminarC.Name = "lblEliminarC";
            this.lblEliminarC.Size = new System.Drawing.Size(43, 13);
            this.lblEliminarC.TabIndex = 6;
            this.lblEliminarC.Text = "Eliminar";
            this.lblEliminarC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblEliminarC_MouseClick);
            // 
            // txtCodigoCo
            // 
            this.txtCodigoCo.Location = new System.Drawing.Point(249, 156);
            this.txtCodigoCo.Name = "txtCodigoCo";
            this.txtCodigoCo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoCo.TabIndex = 2;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(251, 131);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(79, 13);
            this.lblCC.TabIndex = 3;
            this.lblCC.Text = "Codigo Compra";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(60, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 73);
            this.panel1.TabIndex = 14;
            // 
            // frmCompraEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1046, 546);
            this.Controls.Add(this.cbxDV);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblSaldoVenta);
            this.Controls.Add(this.txtSaldoVenta);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.cbxTC);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.txtCodigoCo);
            this.Controls.Add(this.pnlLlenarCamp);
            this.Controls.Add(this.pnlCerrar);
            this.Controls.Add(this.pnlIconoBC);
            this.Controls.Add(this.txtBuscarC);
            this.Controls.Add(this.dvgCobro);
            this.Controls.Add(this.pnlEliminar);
            this.Controls.Add(this.pnlMC);
            this.Controls.Add(this.pnlIconoC);
            this.Controls.Add(this.lblEliminarC);
            this.Controls.Add(this.lblModificarC);
            this.Controls.Add(this.lblIngresarC);
            this.Controls.Add(this.lblTtuloCobros);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompraEncabezado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.frmCobros_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlPagos.ResumeLayout(false);
            this.pnlPagos.PerformLayout();
            this.pnlCobros.ResumeLayout(false);
            this.pnlCobros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCobro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCobros;
        private System.Windows.Forms.Label lblCobros;
        private System.Windows.Forms.Panel pnlPagos;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblTtuloCobros;
        private System.Windows.Forms.Label lblIngresarC;
        private System.Windows.Forms.Label lblModificarC;
        private System.Windows.Forms.ComboBox cbxTC;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.ComboBox cbxDV;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Panel pnlIconoC;
        private System.Windows.Forms.Panel pnlMC;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Label lblProto;
        private System.Windows.Forms.Panel pnlIconoBC;
        private System.Windows.Forms.TextBox txtBuscarC;
        private System.Windows.Forms.DataGridView dvgCobro;
        private System.Windows.Forms.Panel pnlCerrar;
        private System.Windows.Forms.Label lblSaldoVenta;
        private System.Windows.Forms.TextBox txtSaldoVenta;
        private System.Windows.Forms.Panel pnlLlenarCamp;
        private System.Windows.Forms.Label lblEliminarC;
        private System.Windows.Forms.TextBox txtCodigoCo;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Panel panel1;
    }
}

