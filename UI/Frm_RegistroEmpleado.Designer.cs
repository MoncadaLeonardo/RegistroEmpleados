namespace SistemaEmpleadosColegioBautista.Vistas
{
    partial class Frm_RegistroEmpleado
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
            pictureBox5 = new PictureBox();
            label1 = new Label();
            lbl_Nombre = new Label();
            lbl_Cedula = new Label();
            lbl_Area = new Label();
            lbl_Correo = new Label();
            lbl_Telefono = new Label();
            tb_Nombre = new TextBox();
            tb_Correo = new TextBox();
            tb_Telefono = new TextBox();
            tb_Cedula = new TextBox();
            cb_Area = new ComboBox();
            btn_Guardar = new Button();
            btn_Editar = new Button();
            btn_Eliminar = new Button();
            btn_Agregar = new Button();
            pictureBox1 = new PictureBox();
            dgv_Empleados = new DataGridView();
            btn_Siguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1422, 62);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(211, 27);
            label1.TabIndex = 13;
            label1.Text = "Registrar Empleado";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nombre.Location = new Point(63, 220);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(201, 27);
            lbl_Nombre.TabIndex = 14;
            lbl_Nombre.Text = "Nombre Completo";
            // 
            // lbl_Cedula
            // 
            lbl_Cedula.AutoSize = true;
            lbl_Cedula.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Cedula.Location = new Point(63, 356);
            lbl_Cedula.Name = "lbl_Cedula";
            lbl_Cedula.Size = new Size(201, 27);
            lbl_Cedula.TabIndex = 15;
            lbl_Cedula.Text = "Número de Cédula";
            // 
            // lbl_Area
            // 
            lbl_Area.AutoSize = true;
            lbl_Area.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Area.Location = new Point(981, 288);
            lbl_Area.Name = "lbl_Area";
            lbl_Area.Size = new Size(58, 27);
            lbl_Area.TabIndex = 16;
            lbl_Area.Text = "Área";
            // 
            // lbl_Correo
            // 
            lbl_Correo.AutoSize = true;
            lbl_Correo.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Correo.Location = new Point(63, 291);
            lbl_Correo.Name = "lbl_Correo";
            lbl_Correo.Size = new Size(198, 27);
            lbl_Correo.TabIndex = 17;
            lbl_Correo.Text = "Correo Electrónico";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Telefono.Location = new Point(945, 221);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(98, 27);
            lbl_Telefono.TabIndex = 18;
            lbl_Telefono.Text = "Teléfono";
            // 
            // tb_Nombre
            // 
            tb_Nombre.Location = new Point(270, 221);
            tb_Nombre.Name = "tb_Nombre";
            tb_Nombre.Size = new Size(590, 27);
            tb_Nombre.TabIndex = 19;
            // 
            // tb_Correo
            // 
            tb_Correo.Location = new Point(270, 291);
            tb_Correo.Name = "tb_Correo";
            tb_Correo.Size = new Size(590, 27);
            tb_Correo.TabIndex = 20;
            // 
            // tb_Telefono
            // 
            tb_Telefono.Location = new Point(1052, 221);
            tb_Telefono.Name = "tb_Telefono";
            tb_Telefono.Size = new Size(234, 27);
            tb_Telefono.TabIndex = 21;
            // 
            // tb_Cedula
            // 
            tb_Cedula.Location = new Point(270, 357);
            tb_Cedula.Name = "tb_Cedula";
            tb_Cedula.Size = new Size(363, 27);
            tb_Cedula.TabIndex = 22;
            // 
            // cb_Area
            // 
            cb_Area.FormattingEnabled = true;
            cb_Area.Items.AddRange(new object[] { "Administración ", "Informática ", "Servicio y Mantenimiento ", "Atención al Cliente", "Docencia E.I", "Docencia Primaria ", "Docencia Secundaria ", "Ayudantía", "Inspectoría " });
            cb_Area.Location = new Point(1052, 287);
            cb_Area.Name = "cb_Area";
            cb_Area.Size = new Size(234, 28);
            cb_Area.TabIndex = 23;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(47, 64, 80);
            btn_Guardar.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(483, 84);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(135, 70);
            btn_Guardar.TabIndex = 24;
            btn_Guardar.Text = "GUARDAR";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.BackColor = Color.FromArgb(47, 64, 80);
            btn_Editar.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Editar.ForeColor = Color.White;
            btn_Editar.Location = new Point(754, 84);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(135, 70);
            btn_Editar.TabIndex = 25;
            btn_Editar.Text = "EDITAR";
            btn_Editar.UseVisualStyleBackColor = false;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.FromArgb(47, 64, 80);
            btn_Eliminar.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Eliminar.ForeColor = Color.White;
            btn_Eliminar.Location = new Point(1027, 84);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(135, 70);
            btn_Eliminar.TabIndex = 26;
            btn_Eliminar.Text = "ELIMINAR";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(47, 64, 80);
            btn_Agregar.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = Color.White;
            btn_Agregar.Location = new Point(202, 84);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(135, 70);
            btn_Agregar.TabIndex = 27;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(243, 243, 244);
            pictureBox1.Location = new Point(0, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1422, 120);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // dgv_Empleados
            // 
            dgv_Empleados.BackgroundColor = Color.FromArgb(243, 243, 244);
            dgv_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Empleados.Location = new Point(46, 435);
            dgv_Empleados.Name = "dgv_Empleados";
            dgv_Empleados.RowHeadersWidth = 51;
            dgv_Empleados.Size = new Size(1293, 451);
            dgv_Empleados.TabIndex = 29;
            // 
            // btn_Siguiente
            // 
            btn_Siguiente.BackColor = Color.Teal;
            btn_Siguiente.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Siguiente.ForeColor = Color.White;
            btn_Siguiente.Location = new Point(1073, 356);
            btn_Siguiente.Name = "btn_Siguiente";
            btn_Siguiente.Size = new Size(135, 56);
            btn_Siguiente.TabIndex = 45;
            btn_Siguiente.Text = "SIGUIENTE";
            btn_Siguiente.UseVisualStyleBackColor = false;
            // 
            // Frm_RegistroEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1422, 950);
            Controls.Add(btn_Siguiente);
            Controls.Add(dgv_Empleados);
            Controls.Add(btn_Agregar);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Guardar);
            Controls.Add(cb_Area);
            Controls.Add(tb_Cedula);
            Controls.Add(tb_Telefono);
            Controls.Add(tb_Correo);
            Controls.Add(tb_Nombre);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Correo);
            Controls.Add(lbl_Area);
            Controls.Add(lbl_Cedula);
            Controls.Add(lbl_Nombre);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_RegistroEmpleado";
            Text = "Frm_RegistroEmpleado";
            Load += Frm_RegistroEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label label1;
        private Label lbl_Nombre;
        private Label lbl_Cedula;
        private Label lbl_Area;
        private Label lbl_Correo;
        private Label lbl_Telefono;
        private TextBox tb_Nombre;
        private TextBox tb_Correo;
        private TextBox tb_Telefono;
        private TextBox tb_Cedula;
        private ComboBox cb_Area;
        private Button btn_Guardar;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private Button btn_Agregar;
        private PictureBox pictureBox1;
        private DataGridView dgv_Empleados;
        private Button btn_Siguiente;
    }
}