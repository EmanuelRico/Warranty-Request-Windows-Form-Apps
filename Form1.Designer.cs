
namespace Examen_Parcial1
{
    partial class Solicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitud));
            this.nombre_label = new System.Windows.Forms.Label();
            this.ap_paterno_label = new System.Windows.Forms.Label();
            this.ap_materno_label = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_paterno = new System.Windows.Forms.TextBox();
            this.textBox_materno = new System.Windows.Forms.TextBox();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.comboBox_marca = new System.Windows.Forms.ComboBox();
            this.tipo_prod_label = new System.Windows.Forms.Label();
            this.marca_prod_label = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudgarantia = new System.Windows.Forms.Label();
            this.opcion_ga_label = new System.Windows.Forms.Label();
            this.diacompra_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.BackColor = System.Drawing.Color.Transparent;
            this.nombre_label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_label.ForeColor = System.Drawing.SystemColors.Window;
            this.nombre_label.Location = new System.Drawing.Point(66, 120);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(64, 19);
            this.nombre_label.TabIndex = 0;
            this.nombre_label.Text = "Nombre";
            // 
            // ap_paterno_label
            // 
            this.ap_paterno_label.AutoSize = true;
            this.ap_paterno_label.BackColor = System.Drawing.Color.Transparent;
            this.ap_paterno_label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ap_paterno_label.ForeColor = System.Drawing.SystemColors.Window;
            this.ap_paterno_label.Location = new System.Drawing.Point(12, 152);
            this.ap_paterno_label.Name = "ap_paterno_label";
            this.ap_paterno_label.Size = new System.Drawing.Size(123, 19);
            this.ap_paterno_label.TabIndex = 1;
            this.ap_paterno_label.Text = "Apellido Paterno";
            // 
            // ap_materno_label
            // 
            this.ap_materno_label.AutoSize = true;
            this.ap_materno_label.BackColor = System.Drawing.Color.Transparent;
            this.ap_materno_label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ap_materno_label.ForeColor = System.Drawing.SystemColors.Window;
            this.ap_materno_label.Location = new System.Drawing.Point(10, 185);
            this.ap_materno_label.Name = "ap_materno_label";
            this.ap_materno_label.Size = new System.Drawing.Size(128, 19);
            this.ap_materno_label.TabIndex = 2;
            this.ap_materno_label.Text = "Apellido Materno";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(150, 117);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(120, 23);
            this.textBox_nombre.TabIndex = 3;
            // 
            // textBox_paterno
            // 
            this.textBox_paterno.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_paterno.Location = new System.Drawing.Point(150, 149);
            this.textBox_paterno.Name = "textBox_paterno";
            this.textBox_paterno.Size = new System.Drawing.Size(120, 23);
            this.textBox_paterno.TabIndex = 4;
            // 
            // textBox_materno
            // 
            this.textBox_materno.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_materno.Location = new System.Drawing.Point(150, 182);
            this.textBox_materno.Name = "textBox_materno";
            this.textBox_materno.Size = new System.Drawing.Size(120, 23);
            this.textBox_materno.TabIndex = 5;
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "Headset",
            "Teclado",
            "Mouse"});
            this.comboBox_tipo.Location = new System.Drawing.Point(67, 326);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(138, 25);
            this.comboBox_tipo.TabIndex = 6;
            // 
            // comboBox_marca
            // 
            this.comboBox_marca.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_marca.FormattingEnabled = true;
            this.comboBox_marca.Items.AddRange(new object[] {
            "HyperX",
            "Razer",
            "Logitech"});
            this.comboBox_marca.Location = new System.Drawing.Point(67, 411);
            this.comboBox_marca.Name = "comboBox_marca";
            this.comboBox_marca.Size = new System.Drawing.Size(138, 25);
            this.comboBox_marca.TabIndex = 7;
            // 
            // tipo_prod_label
            // 
            this.tipo_prod_label.AutoSize = true;
            this.tipo_prod_label.BackColor = System.Drawing.Color.Transparent;
            this.tipo_prod_label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_prod_label.ForeColor = System.Drawing.SystemColors.Window;
            this.tipo_prod_label.Location = new System.Drawing.Point(39, 304);
            this.tipo_prod_label.Name = "tipo_prod_label";
            this.tipo_prod_label.Size = new System.Drawing.Size(225, 19);
            this.tipo_prod_label.TabIndex = 8;
            this.tipo_prod_label.Text = "Selecciona el tipo de producto";
            // 
            // marca_prod_label
            // 
            this.marca_prod_label.AutoSize = true;
            this.marca_prod_label.BackColor = System.Drawing.Color.Transparent;
            this.marca_prod_label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_prod_label.ForeColor = System.Drawing.SystemColors.Window;
            this.marca_prod_label.Location = new System.Drawing.Point(29, 391);
            this.marca_prod_label.Name = "marca_prod_label";
            this.marca_prod_label.Size = new System.Drawing.Size(248, 19);
            this.marca_prod_label.TabIndex = 9;
            this.marca_prod_label.Text = "Selecciona la marca del producto";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButton1.Location = new System.Drawing.Point(308, 369);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(233, 23);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Reparar el producto dañado";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButton2.Location = new System.Drawing.Point(308, 396);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(282, 23);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cambiar el producto por uno nuevo";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButton3.Location = new System.Drawing.Point(308, 423);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(276, 23);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Reccibir una devolucion monetaria";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox1.Location = new System.Drawing.Point(305, 304);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(279, 23);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Cuento con la caja de mi producto";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(308, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // solicitudgarantia
            // 
            this.solicitudgarantia.AutoSize = true;
            this.solicitudgarantia.BackColor = System.Drawing.Color.Transparent;
            this.solicitudgarantia.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitudgarantia.ForeColor = System.Drawing.SystemColors.Window;
            this.solicitudgarantia.Location = new System.Drawing.Point(66, 42);
            this.solicitudgarantia.Name = "solicitudgarantia";
            this.solicitudgarantia.Size = new System.Drawing.Size(157, 19);
            this.solicitudgarantia.TabIndex = 16;
            this.solicitudgarantia.Text = "Solicitud de Garantía";
            // 
            // opcion_ga_label
            // 
            this.opcion_ga_label.AutoSize = true;
            this.opcion_ga_label.BackColor = System.Drawing.Color.Transparent;
            this.opcion_ga_label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcion_ga_label.ForeColor = System.Drawing.SystemColors.Window;
            this.opcion_ga_label.Location = new System.Drawing.Point(331, 349);
            this.opcion_ga_label.Name = "opcion_ga_label";
            this.opcion_ga_label.Size = new System.Drawing.Size(152, 19);
            this.opcion_ga_label.TabIndex = 17;
            this.opcion_ga_label.Text = "¿Qué deseas hacer?";
            // 
            // diacompra_label
            // 
            this.diacompra_label.AutoSize = true;
            this.diacompra_label.BackColor = System.Drawing.Color.Transparent;
            this.diacompra_label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diacompra_label.ForeColor = System.Drawing.SystemColors.Window;
            this.diacompra_label.Location = new System.Drawing.Point(304, 42);
            this.diacompra_label.Name = "diacompra_label";
            this.diacompra_label.Size = new System.Drawing.Size(305, 19);
            this.diacompra_label.TabIndex = 18;
            this.diacompra_label.Text = "Selecciona el Día que realizaste la compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(207, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hecho por Emanuel Rico Martínez y Jorge Eduardo Moctezuma Estrada";
            // 
            // Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen_Parcial1.Properties.Resources._1604_ghostcolor_640x480;
            this.ClientSize = new System.Drawing.Size(668, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diacompra_label);
            this.Controls.Add(this.opcion_ga_label);
            this.Controls.Add(this.solicitudgarantia);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.marca_prod_label);
            this.Controls.Add(this.tipo_prod_label);
            this.Controls.Add(this.comboBox_marca);
            this.Controls.Add(this.comboBox_tipo);
            this.Controls.Add(this.textBox_materno);
            this.Controls.Add(this.textBox_paterno);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.ap_materno_label);
            this.Controls.Add(this.ap_paterno_label);
            this.Controls.Add(this.nombre_label);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Solicitud";
            this.Text = "Solicitud de garantía";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.Label ap_paterno_label;
        private System.Windows.Forms.Label ap_materno_label;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_paterno;
        private System.Windows.Forms.TextBox textBox_materno;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.ComboBox comboBox_marca;
        private System.Windows.Forms.Label tipo_prod_label;
        private System.Windows.Forms.Label marca_prod_label;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Label solicitudgarantia;
        private System.Windows.Forms.Label opcion_ga_label;
        private System.Windows.Forms.Label diacompra_label;
        private System.Windows.Forms.Label label1;
    }
}

