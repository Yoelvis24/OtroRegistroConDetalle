
namespace CrearRegistroConDetalle.UI.Registros
{
    partial class RegistroRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroRoles));
            this.RolIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.RolIdLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.RolErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PermisoIdLabel = new System.Windows.Forms.Label();
            this.DetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.RolDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.AsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.PermisoIdComboBox = new System.Windows.Forms.ComboBox();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaCreacionLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PermisoLabel = new System.Windows.Forms.Label();
            this.PermisoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionPermisoLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.VecesAsignadoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolErrorProvider)).BeginInit();
            this.DetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermisoIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RolIdNumericUpDown
            // 
            this.RolIdNumericUpDown.Location = new System.Drawing.Point(116, 14);
            this.RolIdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RolIdNumericUpDown.Name = "RolIdNumericUpDown";
            this.RolIdNumericUpDown.Size = new System.Drawing.Size(118, 23);
            this.RolIdNumericUpDown.TabIndex = 12;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(116, 50);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(164, 23);
            this.DescripcionTextBox.TabIndex = 10;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripcionLabel.Location = new System.Drawing.Point(10, 51);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(76, 17);
            this.DescripcionLabel.TabIndex = 8;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // RolIdLabel
            // 
            this.RolIdLabel.AutoSize = true;
            this.RolIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RolIdLabel.Location = new System.Drawing.Point(10, 15);
            this.RolIdLabel.Name = "RolIdLabel";
            this.RolIdLabel.Size = new System.Drawing.Size(43, 17);
            this.RolIdLabel.TabIndex = 7;
            this.RolIdLabel.Text = "Rol ID";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(240, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(40, 29);
            this.BuscarButton.TabIndex = 13;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(137, 460);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(97, 40);
            this.NuevoButton.TabIndex = 14;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(250, 460);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(97, 40);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(362, 460);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(96, 40);
            this.EliminarButton.TabIndex = 16;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // RolErrorProvider
            // 
            this.RolErrorProvider.ContainerControl = this;
            // 
            // PermisoIdLabel
            // 
            this.PermisoIdLabel.AutoSize = true;
            this.PermisoIdLabel.Location = new System.Drawing.Point(6, 38);
            this.PermisoIdLabel.Name = "PermisoIdLabel";
            this.PermisoIdLabel.Size = new System.Drawing.Size(70, 17);
            this.PermisoIdLabel.TabIndex = 0;
            this.PermisoIdLabel.Text = "Permiso Id";
            // 
            // DetalleGroupBox
            // 
            this.DetalleGroupBox.Controls.Add(this.RemoverButton);
            this.DetalleGroupBox.Controls.Add(this.RolDetalleDataGridView);
            this.DetalleGroupBox.Controls.Add(this.AgregarButton);
            this.DetalleGroupBox.Controls.Add(this.AsignadoCheckBox);
            this.DetalleGroupBox.Controls.Add(this.PermisoIdComboBox);
            this.DetalleGroupBox.Controls.Add(this.PermisoIdLabel);
            this.DetalleGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetalleGroupBox.Location = new System.Drawing.Point(12, 142);
            this.DetalleGroupBox.Name = "DetalleGroupBox";
            this.DetalleGroupBox.Size = new System.Drawing.Size(524, 312);
            this.DetalleGroupBox.TabIndex = 17;
            this.DetalleGroupBox.TabStop = false;
            this.DetalleGroupBox.Text = "Detalle";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(6, 271);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(90, 34);
            this.RemoverButton.TabIndex = 5;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // RolDetalleDataGridView
            // 
            this.RolDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolDetalleDataGridView.Location = new System.Drawing.Point(6, 66);
            this.RolDetalleDataGridView.Name = "RolDetalleDataGridView";
            this.RolDetalleDataGridView.RowTemplate.Height = 25;
            this.RolDetalleDataGridView.Size = new System.Drawing.Size(508, 199);
            this.RolDetalleDataGridView.TabIndex = 4;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(428, 31);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(86, 29);
            this.AgregarButton.TabIndex = 3;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // AsignadoCheckBox
            // 
            this.AsignadoCheckBox.AutoSize = true;
            this.AsignadoCheckBox.Location = new System.Drawing.Point(290, 35);
            this.AsignadoCheckBox.Name = "AsignadoCheckBox";
            this.AsignadoCheckBox.Size = new System.Drawing.Size(82, 21);
            this.AsignadoCheckBox.TabIndex = 2;
            this.AsignadoCheckBox.Text = "Asignado";
            this.AsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermisoIdComboBox
            // 
            this.PermisoIdComboBox.FormattingEnabled = true;
            this.PermisoIdComboBox.Location = new System.Drawing.Point(82, 35);
            this.PermisoIdComboBox.Name = "PermisoIdComboBox";
            this.PermisoIdComboBox.Size = new System.Drawing.Size(121, 25);
            this.PermisoIdComboBox.TabIndex = 1;
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(220, 117);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoCheckBox.TabIndex = 18;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // FechaCreacionLabel
            // 
            this.FechaCreacionLabel.AutoSize = true;
            this.FechaCreacionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaCreacionLabel.Location = new System.Drawing.Point(10, 90);
            this.FechaCreacionLabel.Name = "FechaCreacionLabel";
            this.FechaCreacionLabel.Size = new System.Drawing.Size(102, 17);
            this.FechaCreacionLabel.TabIndex = 19;
            this.FechaCreacionLabel.Text = "Fecha Crecación";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(116, 86);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(164, 23);
            this.FechaDateTimePicker.TabIndex = 20;
            // 
            // PermisoLabel
            // 
            this.PermisoLabel.AutoSize = true;
            this.PermisoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PermisoLabel.Location = new System.Drawing.Point(301, 17);
            this.PermisoLabel.Name = "PermisoLabel";
            this.PermisoLabel.Size = new System.Drawing.Size(71, 17);
            this.PermisoLabel.TabIndex = 21;
            this.PermisoLabel.Text = "Permiso ID";
            // 
            // PermisoIdNumericUpDown
            // 
            this.PermisoIdNumericUpDown.Location = new System.Drawing.Point(378, 14);
            this.PermisoIdNumericUpDown.Name = "PermisoIdNumericUpDown";
            this.PermisoIdNumericUpDown.Size = new System.Drawing.Size(148, 23);
            this.PermisoIdNumericUpDown.TabIndex = 22;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreLabel.Location = new System.Drawing.Point(302, 53);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(57, 17);
            this.NombreLabel.TabIndex = 23;
            this.NombreLabel.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(378, 50);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(148, 23);
            this.NombreTextBox.TabIndex = 24;
            // 
            // DescripcionPermisoLabel
            // 
            this.DescripcionPermisoLabel.AutoSize = true;
            this.DescripcionPermisoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripcionPermisoLabel.Location = new System.Drawing.Point(301, 90);
            this.DescripcionPermisoLabel.Name = "DescripcionPermisoLabel";
            this.DescripcionPermisoLabel.Size = new System.Drawing.Size(76, 17);
            this.DescripcionPermisoLabel.TabIndex = 25;
            this.DescripcionPermisoLabel.Text = "Descripción";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(378, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 26;
            // 
            // VecesAsignadoCheckBox
            // 
            this.VecesAsignadoCheckBox.AutoSize = true;
            this.VecesAsignadoCheckBox.Location = new System.Drawing.Point(420, 117);
            this.VecesAsignadoCheckBox.Name = "VecesAsignadoCheckBox";
            this.VecesAsignadoCheckBox.Size = new System.Drawing.Size(106, 19);
            this.VecesAsignadoCheckBox.TabIndex = 27;
            this.VecesAsignadoCheckBox.Text = "Veces asignado";
            this.VecesAsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegistroRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 512);
            this.Controls.Add(this.VecesAsignadoCheckBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DescripcionPermisoLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.PermisoIdNumericUpDown);
            this.Controls.Add(this.PermisoLabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.FechaCreacionLabel);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.DetalleGroupBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.RolIdNumericUpDown);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.RolIdLabel);
            this.Name = "RegistroRoles";
            this.Text = "RegistroRoles";
            this.Load += new System.EventHandler(this.RegistroRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolErrorProvider)).EndInit();
            this.DetalleGroupBox.ResumeLayout(false);
            this.DetalleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermisoIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown RolIdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label RolIdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider RolErrorProvider;
        private System.Windows.Forms.Label PermisoIdLabel;
        private System.Windows.Forms.GroupBox DetalleGroupBox;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView RolDetalleDataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.CheckBox AsignadoCheckBox;
        private System.Windows.Forms.ComboBox PermisoIdComboBox;
        private System.Windows.Forms.CheckBox VecesAsignadoCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DescripcionPermisoLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.NumericUpDown PermisoIdNumericUpDown;
        private System.Windows.Forms.Label PermisoLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label FechaCreacionLabel;
    }
}