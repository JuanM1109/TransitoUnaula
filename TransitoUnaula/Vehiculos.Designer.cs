namespace TransitoUnaula
{
    partial class Vehiculos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPropietario = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnAñadirVehiculo = new System.Windows.Forms.Button();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.Controls.Add(this.cbPropietario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtColor, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPlaca, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAñadirVehiculo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnModificarVehiculo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbTipo, 3, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 404);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbPropietario
            // 
            this.cbPropietario.FormattingEnabled = true;
            this.cbPropietario.Location = new System.Drawing.Point(150, 139);
            this.cbPropietario.Name = "cbPropietario";
            this.cbPropietario.Size = new System.Drawing.Size(244, 26);
            this.cbPropietario.TabIndex = 14;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(547, 139);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(246, 25);
            this.txtColor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(403, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(403, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "cc.Propietario";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(150, 6);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(244, 25);
            this.txtPlaca.TabIndex = 7;
            // 
            // btnAñadirVehiculo
            // 
            this.btnAñadirVehiculo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAñadirVehiculo.BackgroundImage = global::TransitoUnaula.Properties.Resources.Añadir_vehiculo;
            this.btnAñadirVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadirVehiculo.Location = new System.Drawing.Point(150, 272);
            this.btnAñadirVehiculo.Name = "btnAñadirVehiculo";
            this.btnAñadirVehiculo.Size = new System.Drawing.Size(60, 53);
            this.btnAñadirVehiculo.TabIndex = 11;
            this.btnAñadirVehiculo.UseVisualStyleBackColor = false;
            this.btnAñadirVehiculo.Click += new System.EventHandler(this.btnAñadirVehiculo_Click);
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarVehiculo.BackgroundImage = global::TransitoUnaula.Properties.Resources.Modificar_vehiculo;
            this.btnModificarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarVehiculo.Location = new System.Drawing.Point(547, 272);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(60, 53);
            this.btnModificarVehiculo.TabIndex = 12;
            this.btnModificarVehiculo.UseVisualStyleBackColor = false;
            this.btnModificarVehiculo.Click += new System.EventHandler(this.btnModificarVehiculo_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Moto",
            "Carro",
            "Camion"});
            this.cbTipo.Location = new System.Drawing.Point(547, 6);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(244, 26);
            this.cbTipo.TabIndex = 13;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(-2, -1);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransitoUnaula.Properties.Resources.fondoMultas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Vehiculos";
            this.Text = "Vehiculos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vehiculos_FormClosing);
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnAñadirVehiculo;
        private System.Windows.Forms.Button btnModificarVehiculo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbPropietario;
        private System.Windows.Forms.Button btnRegresar;
    }
}