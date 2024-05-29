namespace TransitoUnaula
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiMultas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenerarMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMultados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAgregarMultados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarMultados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAgregarVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.agentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAgregarAgentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarAgentes = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dgvMultas = new System.Windows.Forms.DataGridView();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.msAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.msAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("msAdmin.BackgroundImage")));
            this.msAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.msAdmin.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMultas,
            this.tsmiMultados,
            this.tsmiVehiculos,
            this.agentesToolStripMenuItem});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.MdiWindowListItem = this.agentesToolStripMenuItem;
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(93, 450);
            this.msAdmin.TabIndex = 0;
            this.msAdmin.Text = "menuStrip1";
            // 
            // tsmiMultas
            // 
            this.tsmiMultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGenerarMulta,
            this.tsmiConsultarMulta});
            this.tsmiMultas.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMultas.Image")));
            this.tsmiMultas.Name = "tsmiMultas";
            this.tsmiMultas.Size = new System.Drawing.Size(86, 20);
            this.tsmiMultas.Text = "/Multas";
            this.tsmiMultas.Click += new System.EventHandler(this.tsmiMultas_Click);
            // 
            // tsmiGenerarMulta
            // 
            this.tsmiGenerarMulta.Image = ((System.Drawing.Image)(resources.GetObject("tsmiGenerarMulta.Image")));
            this.tsmiGenerarMulta.Name = "tsmiGenerarMulta";
            this.tsmiGenerarMulta.Size = new System.Drawing.Size(163, 22);
            this.tsmiGenerarMulta.Text = "Generar";
            this.tsmiGenerarMulta.Click += new System.EventHandler(this.tsmiGenerarMulta_Click);
            // 
            // tsmiConsultarMulta
            // 
            this.tsmiConsultarMulta.Image = global::TransitoUnaula.Properties.Resources.lupa;
            this.tsmiConsultarMulta.Name = "tsmiConsultarMulta";
            this.tsmiConsultarMulta.Size = new System.Drawing.Size(163, 22);
            this.tsmiConsultarMulta.Text = "Consultar estado";
            // 
            // tsmiMultados
            // 
            this.tsmiMultados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAgregarMultados,
            this.tsmiModificarMultados});
            this.tsmiMultados.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMultados.Image")));
            this.tsmiMultados.Name = "tsmiMultados";
            this.tsmiMultados.Size = new System.Drawing.Size(86, 20);
            this.tsmiMultados.Text = "/Multados";
            // 
            // tsmiAgregarMultados
            // 
            this.tsmiAgregarMultados.Image = global::TransitoUnaula.Properties.Resources.boton_agregar;
            this.tsmiAgregarMultados.Name = "tsmiAgregarMultados";
            this.tsmiAgregarMultados.Size = new System.Drawing.Size(180, 22);
            this.tsmiAgregarMultados.Text = "Agregar";
            this.tsmiAgregarMultados.Click += new System.EventHandler(this.tsmiAgregarMultados_Click);
            // 
            // tsmiModificarMultados
            // 
            this.tsmiModificarMultados.Image = global::TransitoUnaula.Properties.Resources.editar__1_;
            this.tsmiModificarMultados.Name = "tsmiModificarMultados";
            this.tsmiModificarMultados.Size = new System.Drawing.Size(180, 22);
            this.tsmiModificarMultados.Text = "Modificar";
            this.tsmiModificarMultados.Click += new System.EventHandler(this.tsmiModificarMultados_Click);
            // 
            // tsmiVehiculos
            // 
            this.tsmiVehiculos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAgregarVehiculos,
            this.tsmiModificarVehiculos});
            this.tsmiVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("tsmiVehiculos.Image")));
            this.tsmiVehiculos.Name = "tsmiVehiculos";
            this.tsmiVehiculos.Size = new System.Drawing.Size(86, 20);
            this.tsmiVehiculos.Text = "/Vehiculos";
            // 
            // tsmiAgregarVehiculos
            // 
            this.tsmiAgregarVehiculos.Image = global::TransitoUnaula.Properties.Resources.boton_agregar;
            this.tsmiAgregarVehiculos.Name = "tsmiAgregarVehiculos";
            this.tsmiAgregarVehiculos.Size = new System.Drawing.Size(125, 22);
            this.tsmiAgregarVehiculos.Text = "Agregar";
            this.tsmiAgregarVehiculos.Click += new System.EventHandler(this.tsmiAgregarVehiculos_Click);
            // 
            // tsmiModificarVehiculos
            // 
            this.tsmiModificarVehiculos.Image = global::TransitoUnaula.Properties.Resources.editar__1_;
            this.tsmiModificarVehiculos.Name = "tsmiModificarVehiculos";
            this.tsmiModificarVehiculos.Size = new System.Drawing.Size(125, 22);
            this.tsmiModificarVehiculos.Text = "Modificar";
            this.tsmiModificarVehiculos.Click += new System.EventHandler(this.tsmiModificarVehiculos_Click);
            // 
            // agentesToolStripMenuItem
            // 
            this.agentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAgregarAgentes,
            this.tsmiModificarAgentes});
            this.agentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agentesToolStripMenuItem.Image")));
            this.agentesToolStripMenuItem.Name = "agentesToolStripMenuItem";
            this.agentesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.agentesToolStripMenuItem.Text = "/Agentes";
            // 
            // tsmiAgregarAgentes
            // 
            this.tsmiAgregarAgentes.Image = global::TransitoUnaula.Properties.Resources.boton_agregar;
            this.tsmiAgregarAgentes.Name = "tsmiAgregarAgentes";
            this.tsmiAgregarAgentes.Size = new System.Drawing.Size(125, 22);
            this.tsmiAgregarAgentes.Text = "Agregar";
            this.tsmiAgregarAgentes.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // tsmiModificarAgentes
            // 
            this.tsmiModificarAgentes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiModificarAgentes.Image = global::TransitoUnaula.Properties.Resources.editar__1_;
            this.tsmiModificarAgentes.Name = "tsmiModificarAgentes";
            this.tsmiModificarAgentes.Size = new System.Drawing.Size(125, 22);
            this.tsmiModificarAgentes.Text = "Modificar";
            this.tsmiModificarAgentes.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(124, 165);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(209, 20);
            this.txtCedula.TabIndex = 1;
            // 
            // dgvMultas
            // 
            this.dgvMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultas.Location = new System.Drawing.Point(124, 218);
            this.dgvMultas.Name = "dgvMultas";
            this.dgvMultas.Size = new System.Drawing.Size(648, 190);
            this.dgvMultas.TabIndex = 2;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(125, 137);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(71, 25);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "Cédula";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.BackgroundImage = global::TransitoUnaula.Properties.Resources.lupa1;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(339, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.dgvMultas);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.msAdmin);
            this.MainMenuStrip = this.msAdmin;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiMultas;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenerarMulta;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarMulta;
        private System.Windows.Forms.ToolStripMenuItem tsmiMultados;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarMultados;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarMultados;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehiculos;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarVehiculos;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarVehiculos;
        private System.Windows.Forms.ToolStripMenuItem agentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarAgentes;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarAgentes;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DataGridView dgvMultas;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnBuscar;
    }
}