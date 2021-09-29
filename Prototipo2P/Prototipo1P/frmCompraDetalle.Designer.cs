
namespace Prototipo1P
{
    partial class frmCompraDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraDetalle));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblProto = new System.Windows.Forms.Label();
            this.pnlPagos = new System.Windows.Forms.Panel();
            this.pnlIconoPagos = new System.Windows.Forms.Panel();
            this.lblPagos = new System.Windows.Forms.Label();
            this.pnlCobros = new System.Windows.Forms.Panel();
            this.pnlIconoCobros = new System.Windows.Forms.Panel();
            this.lblCobros = new System.Windows.Forms.Label();
            this.pnlBordeEP = new System.Windows.Forms.Panel();
            this.pnlBordeMP = new System.Windows.Forms.Panel();
            this.pnlBordeP = new System.Windows.Forms.Panel();
            this.lblEliminarP = new System.Windows.Forms.Label();
            this.lblModificarP = new System.Windows.Forms.Label();
            this.lblIngresarP = new System.Windows.Forms.Label();
            this.lblTtuloPago = new System.Windows.Forms.Label();
            this.pnlEP = new System.Windows.Forms.Panel();
            this.pnlMP = new System.Windows.Forms.Panel();
            this.pnlIconoP = new System.Windows.Forms.Panel();
            this.pnlProveedor = new System.Windows.Forms.Panel();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.pnlDC = new System.Windows.Forms.Panel();
            this.cbxDV = new System.Windows.Forms.ComboBox();
            this.lblDP = new System.Windows.Forms.Label();
            this.pnlCP = new System.Windows.Forms.Panel();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.pnlContenidoTP = new System.Windows.Forms.Panel();
            this.cbxTP = new System.Windows.Forms.ComboBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.pnlContenidoP = new System.Windows.Forms.Panel();
            this.lblP = new System.Windows.Forms.Label();
            this.txtCodigoCo = new System.Windows.Forms.TextBox();
            this.dvgPago = new System.Windows.Forms.DataGridView();
            this.txtBuscarP = new System.Windows.Forms.TextBox();
            this.pnlIconoB = new System.Windows.Forms.Panel();
            this.pnlCerrar = new System.Windows.Forms.Panel();
            this.pnlSaldoV = new System.Windows.Forms.Panel();
            this.lblSaldoVenta = new System.Windows.Forms.Label();
            this.txtSaldoVenta = new System.Windows.Forms.TextBox();
            this.pnlLlenarCamp = new System.Windows.Forms.Panel();
            this.codigopagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadpagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSidebar.SuspendLayout();
            this.pnlPagos.SuspendLayout();
            this.pnlCobros.SuspendLayout();
            this.pnlProveedor.SuspendLayout();
            this.pnlDC.SuspendLayout();
            this.pnlCP.SuspendLayout();
            this.pnlContenidoTP.SuspendLayout();
            this.pnlContenidoP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPago)).BeginInit();
            this.pnlSaldoV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.pnlSidebar.Controls.Add(this.lblProto);
            this.pnlSidebar.Controls.Add(this.pnlPagos);
            this.pnlSidebar.Controls.Add(this.pnlCobros);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 1);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(188, 567);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lblProto
            // 
            this.lblProto.AutoSize = true;
            this.lblProto.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProto.Location = new System.Drawing.Point(37, 25);
            this.lblProto.Name = "lblProto";
            this.lblProto.Size = new System.Drawing.Size(111, 28);
            this.lblProto.TabIndex = 13;
            this.lblProto.Text = "Prototipo";
            // 
            // pnlPagos
            // 
            this.pnlPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.pnlPagos.Controls.Add(this.pnlIconoPagos);
            this.pnlPagos.Controls.Add(this.lblPagos);
            this.pnlPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPagos.Location = new System.Drawing.Point(3, 290);
            this.pnlPagos.Name = "pnlPagos";
            this.pnlPagos.Size = new System.Drawing.Size(185, 33);
            this.pnlPagos.TabIndex = 3;
            this.pnlPagos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPagos_MouseClick);
            // 
            // pnlIconoPagos
            // 
            this.pnlIconoPagos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoPagos.BackgroundImage")));
            this.pnlIconoPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoPagos.Location = new System.Drawing.Point(15, 8);
            this.pnlIconoPagos.Name = "pnlIconoPagos";
            this.pnlIconoPagos.Size = new System.Drawing.Size(20, 19);
            this.pnlIconoPagos.TabIndex = 2;
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Location = new System.Drawing.Point(81, 11);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(37, 13);
            this.lblPagos.TabIndex = 1;
            this.lblPagos.Text = "Pagos";
            // 
            // pnlCobros
            // 
            this.pnlCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.pnlCobros.Controls.Add(this.pnlIconoCobros);
            this.pnlCobros.Controls.Add(this.lblCobros);
            this.pnlCobros.Location = new System.Drawing.Point(3, 257);
            this.pnlCobros.Name = "pnlCobros";
            this.pnlCobros.Size = new System.Drawing.Size(185, 33);
            this.pnlCobros.TabIndex = 1;
            this.pnlCobros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCobros_MouseClick);
            // 
            // pnlIconoCobros
            // 
            this.pnlIconoCobros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoCobros.BackgroundImage")));
            this.pnlIconoCobros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoCobros.Location = new System.Drawing.Point(15, 8);
            this.pnlIconoCobros.Name = "pnlIconoCobros";
            this.pnlIconoCobros.Size = new System.Drawing.Size(20, 19);
            this.pnlIconoCobros.TabIndex = 2;
            // 
            // lblCobros
            // 
            this.lblCobros.AutoSize = true;
            this.lblCobros.Location = new System.Drawing.Point(83, 11);
            this.lblCobros.Name = "lblCobros";
            this.lblCobros.Size = new System.Drawing.Size(40, 13);
            this.lblCobros.TabIndex = 1;
            this.lblCobros.Text = "Cobros";
            // 
            // pnlBordeEP
            // 
            this.pnlBordeEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.pnlBordeEP.Location = new System.Drawing.Point(804, 102);
            this.pnlBordeEP.Name = "pnlBordeEP";
            this.pnlBordeEP.Size = new System.Drawing.Size(82, 3);
            this.pnlBordeEP.TabIndex = 16;
            // 
            // pnlBordeMP
            // 
            this.pnlBordeMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.pnlBordeMP.Location = new System.Drawing.Point(537, 102);
            this.pnlBordeMP.Name = "pnlBordeMP";
            this.pnlBordeMP.Size = new System.Drawing.Size(82, 3);
            this.pnlBordeMP.TabIndex = 15;
            // 
            // pnlBordeP
            // 
            this.pnlBordeP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.pnlBordeP.Location = new System.Drawing.Point(234, 102);
            this.pnlBordeP.Name = "pnlBordeP";
            this.pnlBordeP.Size = new System.Drawing.Size(82, 3);
            this.pnlBordeP.TabIndex = 14;
            // 
            // lblEliminarP
            // 
            this.lblEliminarP.AutoSize = true;
            this.lblEliminarP.Location = new System.Drawing.Point(807, 85);
            this.lblEliminarP.Name = "lblEliminarP";
            this.lblEliminarP.Size = new System.Drawing.Size(71, 13);
            this.lblEliminarP.TabIndex = 13;
            this.lblEliminarP.Text = "Eliminar Pago";
            this.lblEliminarP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblEliminarP_MouseClick);
            // 
            // lblModificarP
            // 
            this.lblModificarP.AutoSize = true;
            this.lblModificarP.Location = new System.Drawing.Point(538, 86);
            this.lblModificarP.Name = "lblModificarP";
            this.lblModificarP.Size = new System.Drawing.Size(78, 13);
            this.lblModificarP.TabIndex = 12;
            this.lblModificarP.Text = "Modificar Pago";
            this.lblModificarP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblModificarP_MouseClick);
            // 
            // lblIngresarP
            // 
            this.lblIngresarP.AutoSize = true;
            this.lblIngresarP.Location = new System.Drawing.Point(237, 87);
            this.lblIngresarP.Name = "lblIngresarP";
            this.lblIngresarP.Size = new System.Drawing.Size(73, 13);
            this.lblIngresarP.TabIndex = 11;
            this.lblIngresarP.Text = "Ingresar Pago";
            this.lblIngresarP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblIngresarP_MouseClick);
            // 
            // lblTtuloPago
            // 
            this.lblTtuloPago.AutoSize = true;
            this.lblTtuloPago.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtuloPago.Location = new System.Drawing.Point(204, 9);
            this.lblTtuloPago.Name = "lblTtuloPago";
            this.lblTtuloPago.Size = new System.Drawing.Size(73, 28);
            this.lblTtuloPago.TabIndex = 10;
            this.lblTtuloPago.Text = "Pagos";
            // 
            // pnlEP
            // 
            this.pnlEP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEP.BackgroundImage")));
            this.pnlEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEP.Location = new System.Drawing.Point(338, 413);
            this.pnlEP.Name = "pnlEP";
            this.pnlEP.Size = new System.Drawing.Size(43, 42);
            this.pnlEP.TabIndex = 24;
            this.pnlEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlEP_MouseClick);
            // 
            // pnlMP
            // 
            this.pnlMP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMP.BackgroundImage")));
            this.pnlMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMP.Location = new System.Drawing.Point(338, 413);
            this.pnlMP.Name = "pnlMP";
            this.pnlMP.Size = new System.Drawing.Size(43, 42);
            this.pnlMP.TabIndex = 23;
            this.pnlMP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMP_MouseClick);
            // 
            // pnlIconoP
            // 
            this.pnlIconoP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoP.BackgroundImage")));
            this.pnlIconoP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlIconoP.Location = new System.Drawing.Point(338, 413);
            this.pnlIconoP.Name = "pnlIconoP";
            this.pnlIconoP.Size = new System.Drawing.Size(43, 42);
            this.pnlIconoP.TabIndex = 22;
            this.pnlIconoP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlIconoP_MouseClick);
            // 
            // pnlProveedor
            // 
            this.pnlProveedor.Controls.Add(this.lblProveedor);
            this.pnlProveedor.Controls.Add(this.txtProveedor);
            this.pnlProveedor.Location = new System.Drawing.Point(496, 273);
            this.pnlProveedor.Name = "pnlProveedor";
            this.pnlProveedor.Size = new System.Drawing.Size(133, 70);
            this.pnlProveedor.TabIndex = 18;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(13, 13);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 3;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(11, 38);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(108, 20);
            this.txtProveedor.TabIndex = 2;
            // 
            // pnlDC
            // 
            this.pnlDC.Controls.Add(this.cbxDV);
            this.pnlDC.Controls.Add(this.lblDP);
            this.pnlDC.Location = new System.Drawing.Point(281, 273);
            this.pnlDC.Name = "pnlDC";
            this.pnlDC.Size = new System.Drawing.Size(133, 70);
            this.pnlDC.TabIndex = 21;
            // 
            // cbxDV
            // 
            this.cbxDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDV.FormattingEnabled = true;
            this.cbxDV.Location = new System.Drawing.Point(6, 37);
            this.cbxDV.Name = "cbxDV";
            this.cbxDV.Size = new System.Drawing.Size(121, 21);
            this.cbxDV.TabIndex = 4;
            this.cbxDV.SelectedIndexChanged += new System.EventHandler(this.cbxDV_SelectedIndexChanged);
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Location = new System.Drawing.Point(5, 13);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(101, 13);
            this.lblDP.TabIndex = 3;
            this.lblDP.Text = "Documento Compra";
            // 
            // pnlCP
            // 
            this.pnlCP.Controls.Add(this.lblPago);
            this.pnlCP.Controls.Add(this.txtCP);
            this.pnlCP.Location = new System.Drawing.Point(701, 172);
            this.pnlCP.Name = "pnlCP";
            this.pnlCP.Size = new System.Drawing.Size(133, 70);
            this.pnlCP.TabIndex = 19;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(13, 13);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(77, 13);
            this.lblPago.TabIndex = 3;
            this.lblPago.Text = "Cantidad Pago";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(11, 38);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(108, 20);
            this.txtCP.TabIndex = 2;
            // 
            // pnlContenidoTP
            // 
            this.pnlContenidoTP.Controls.Add(this.cbxTP);
            this.pnlContenidoTP.Controls.Add(this.lblTipoPago);
            this.pnlContenidoTP.Location = new System.Drawing.Point(496, 172);
            this.pnlContenidoTP.Name = "pnlContenidoTP";
            this.pnlContenidoTP.Size = new System.Drawing.Size(133, 70);
            this.pnlContenidoTP.TabIndex = 20;
            // 
            // cbxTP
            // 
            this.cbxTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTP.FormattingEnabled = true;
            this.cbxTP.Location = new System.Drawing.Point(6, 37);
            this.cbxTP.Name = "cbxTP";
            this.cbxTP.Size = new System.Drawing.Size(121, 21);
            this.cbxTP.TabIndex = 4;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(5, 13);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(56, 13);
            this.lblTipoPago.TabIndex = 3;
            this.lblTipoPago.Text = "Tipo Pago";
            // 
            // pnlContenidoP
            // 
            this.pnlContenidoP.Controls.Add(this.lblP);
            this.pnlContenidoP.Controls.Add(this.txtCodigoCo);
            this.pnlContenidoP.Location = new System.Drawing.Point(281, 172);
            this.pnlContenidoP.Name = "pnlContenidoP";
            this.pnlContenidoP.Size = new System.Drawing.Size(133, 70);
            this.pnlContenidoP.TabIndex = 17;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(13, 13);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(68, 13);
            this.lblP.TabIndex = 3;
            this.lblP.Text = "Codigo Pago";
            // 
            // txtCodigoCo
            // 
            this.txtCodigoCo.Location = new System.Drawing.Point(11, 38);
            this.txtCodigoCo.Name = "txtCodigoCo";
            this.txtCodigoCo.Size = new System.Drawing.Size(108, 20);
            this.txtCodigoCo.TabIndex = 2;
            // 
            // dvgPago
            // 
            this.dvgPago.AutoGenerateColumns = false;
            this.dvgPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigopagoDataGridViewTextBoxColumn,
            this.tipopagoDataGridViewTextBoxColumn,
            this.documentocompraDataGridViewTextBoxColumn,
            this.cantidadpagoDataGridViewTextBoxColumn});
            this.dvgPago.DataSource = this.pagosBindingSource;
            this.dvgPago.Location = new System.Drawing.Point(645, 391);
            this.dvgPago.Name = "dvgPago";
            this.dvgPago.Size = new System.Drawing.Size(240, 150);
            this.dvgPago.TabIndex = 25;
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Location = new System.Drawing.Point(645, 365);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(240, 20);
            this.txtBuscarP.TabIndex = 4;
            // 
            // pnlIconoB
            // 
            this.pnlIconoB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoB.BackgroundImage")));
            this.pnlIconoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoB.Location = new System.Drawing.Point(890, 364);
            this.pnlIconoB.Name = "pnlIconoB";
            this.pnlIconoB.Size = new System.Drawing.Size(21, 20);
            this.pnlIconoB.TabIndex = 26;
            this.pnlIconoB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlIconoB_MouseClick);
            // 
            // pnlCerrar
            // 
            this.pnlCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCerrar.BackgroundImage")));
            this.pnlCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCerrar.Location = new System.Drawing.Point(905, 9);
            this.pnlCerrar.Name = "pnlCerrar";
            this.pnlCerrar.Size = new System.Drawing.Size(21, 22);
            this.pnlCerrar.TabIndex = 27;
            // 
            // pnlSaldoV
            // 
            this.pnlSaldoV.Controls.Add(this.lblSaldoVenta);
            this.pnlSaldoV.Controls.Add(this.txtSaldoVenta);
            this.pnlSaldoV.Location = new System.Drawing.Point(701, 274);
            this.pnlSaldoV.Name = "pnlSaldoV";
            this.pnlSaldoV.Size = new System.Drawing.Size(133, 70);
            this.pnlSaldoV.TabIndex = 28;
            // 
            // lblSaldoVenta
            // 
            this.lblSaldoVenta.AutoSize = true;
            this.lblSaldoVenta.Location = new System.Drawing.Point(13, 13);
            this.lblSaldoVenta.Name = "lblSaldoVenta";
            this.lblSaldoVenta.Size = new System.Drawing.Size(67, 13);
            this.lblSaldoVenta.TabIndex = 3;
            this.lblSaldoVenta.Text = "Saldo Actual";
            // 
            // txtSaldoVenta
            // 
            this.txtSaldoVenta.Enabled = false;
            this.txtSaldoVenta.Location = new System.Drawing.Point(11, 38);
            this.txtSaldoVenta.Name = "txtSaldoVenta";
            this.txtSaldoVenta.Size = new System.Drawing.Size(108, 20);
            this.txtSaldoVenta.TabIndex = 2;
            // 
            // pnlLlenarCamp
            // 
            this.pnlLlenarCamp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLlenarCamp.BackgroundImage")));
            this.pnlLlenarCamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLlenarCamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLlenarCamp.Location = new System.Drawing.Point(496, 433);
            this.pnlLlenarCamp.Name = "pnlLlenarCamp";
            this.pnlLlenarCamp.Size = new System.Drawing.Size(119, 22);
            this.pnlLlenarCamp.TabIndex = 32;
            this.pnlLlenarCamp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLlenarCamp_MouseClick);
            // 
            // codigopagoDataGridViewTextBoxColumn
            // 
            this.codigopagoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_pago";
            this.codigopagoDataGridViewTextBoxColumn.HeaderText = "Codigo pago";
            this.codigopagoDataGridViewTextBoxColumn.Name = "codigopagoDataGridViewTextBoxColumn";
            // 
            // tipopagoDataGridViewTextBoxColumn
            // 
            this.tipopagoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_pago";
            this.tipopagoDataGridViewTextBoxColumn.HeaderText = "Tipo pago";
            this.tipopagoDataGridViewTextBoxColumn.Name = "tipopagoDataGridViewTextBoxColumn";
            // 
            // documentocompraDataGridViewTextBoxColumn
            // 
            this.documentocompraDataGridViewTextBoxColumn.DataPropertyName = "Documento_compra";
            this.documentocompraDataGridViewTextBoxColumn.HeaderText = "Documento compra";
            this.documentocompraDataGridViewTextBoxColumn.Name = "documentocompraDataGridViewTextBoxColumn";
            // 
            // cantidadpagoDataGridViewTextBoxColumn
            // 
            this.cantidadpagoDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_pago";
            this.cantidadpagoDataGridViewTextBoxColumn.HeaderText = "Cantidad pago";
            this.cantidadpagoDataGridViewTextBoxColumn.Name = "cantidadpagoDataGridViewTextBoxColumn";
            // 
            // pagosBindingSource
            // 
            this.pagosBindingSource.DataSource = typeof(Prototipo1P.Clases.Pagos);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 565);
            this.Controls.Add(this.pnlLlenarCamp);
            this.Controls.Add(this.pnlSaldoV);
            this.Controls.Add(this.pnlCerrar);
            this.Controls.Add(this.pnlIconoB);
            this.Controls.Add(this.txtBuscarP);
            this.Controls.Add(this.dvgPago);
            this.Controls.Add(this.pnlEP);
            this.Controls.Add(this.pnlMP);
            this.Controls.Add(this.pnlIconoP);
            this.Controls.Add(this.pnlProveedor);
            this.Controls.Add(this.pnlDC);
            this.Controls.Add(this.pnlCP);
            this.Controls.Add(this.pnlContenidoTP);
            this.Controls.Add(this.pnlContenidoP);
            this.Controls.Add(this.pnlBordeEP);
            this.Controls.Add(this.pnlBordeMP);
            this.Controls.Add(this.pnlBordeP);
            this.Controls.Add(this.lblEliminarP);
            this.Controls.Add(this.lblModificarP);
            this.Controls.Add(this.lblIngresarP);
            this.Controls.Add(this.lblTtuloPago);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlPagos.ResumeLayout(false);
            this.pnlPagos.PerformLayout();
            this.pnlCobros.ResumeLayout(false);
            this.pnlCobros.PerformLayout();
            this.pnlProveedor.ResumeLayout(false);
            this.pnlProveedor.PerformLayout();
            this.pnlDC.ResumeLayout(false);
            this.pnlDC.PerformLayout();
            this.pnlCP.ResumeLayout(false);
            this.pnlCP.PerformLayout();
            this.pnlContenidoTP.ResumeLayout(false);
            this.pnlContenidoTP.PerformLayout();
            this.pnlContenidoP.ResumeLayout(false);
            this.pnlContenidoP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPago)).EndInit();
            this.pnlSaldoV.ResumeLayout(false);
            this.pnlSaldoV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblProto;
        private System.Windows.Forms.Panel pnlPagos;
        private System.Windows.Forms.Panel pnlIconoPagos;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Panel pnlCobros;
        private System.Windows.Forms.Panel pnlIconoCobros;
        private System.Windows.Forms.Label lblCobros;
        private System.Windows.Forms.Panel pnlBordeEP;
        private System.Windows.Forms.Panel pnlBordeMP;
        private System.Windows.Forms.Panel pnlBordeP;
        private System.Windows.Forms.Label lblEliminarP;
        private System.Windows.Forms.Label lblModificarP;
        private System.Windows.Forms.Label lblIngresarP;
        private System.Windows.Forms.Label lblTtuloPago;
        private System.Windows.Forms.Panel pnlEP;
        private System.Windows.Forms.Panel pnlMP;
        private System.Windows.Forms.Panel pnlIconoP;
        private System.Windows.Forms.Panel pnlProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Panel pnlDC;
        private System.Windows.Forms.ComboBox cbxDV;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.Panel pnlCP;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Panel pnlContenidoTP;
        private System.Windows.Forms.ComboBox cbxTP;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Panel pnlContenidoP;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtCodigoCo;
        private System.Windows.Forms.DataGridView dvgPago;
        private System.Windows.Forms.TextBox txtBuscarP;
        private System.Windows.Forms.Panel pnlIconoB;
        private System.Windows.Forms.Panel pnlCerrar;
        private System.Windows.Forms.Panel pnlSaldoV;
        private System.Windows.Forms.Label lblSaldoVenta;
        private System.Windows.Forms.TextBox txtSaldoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentocompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadpagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pagosBindingSource;
        private System.Windows.Forms.Panel pnlLlenarCamp;
    }
}