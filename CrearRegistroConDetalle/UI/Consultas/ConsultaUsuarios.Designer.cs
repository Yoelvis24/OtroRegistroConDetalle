
namespace CrearRegistroConDetalle.UI.Consultas
{
    partial class ConsultaUsuarios
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
            this.FiltroActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.esActivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivosRadioButton = new System.Windows.Forms.RadioButton();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ConsultarUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.FechaGroupBox.SuspendLayout();
            this.esActivoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarUsuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroActivoCheckBox
            // 
            this.FiltroActivoCheckBox.AutoSize = true;
            this.FiltroActivoCheckBox.Location = new System.Drawing.Point(8, 11);
            this.FiltroActivoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltroActivoCheckBox.Name = "FiltroActivoCheckBox";
            this.FiltroActivoCheckBox.Size = new System.Drawing.Size(128, 19);
            this.FiltroActivoCheckBox.TabIndex = 25;
            this.FiltroActivoCheckBox.Text = "Usar Filtro es activo";
            this.FiltroActivoCheckBox.UseVisualStyleBackColor = true;
            this.FiltroActivoCheckBox.CheckedChanged += new System.EventHandler(this.FiltroActivoCheckBox_CheckedChanged);
            // 
            // FechaGroupBox
            // 
            this.FechaGroupBox.Controls.Add(this.HastaLabel);
            this.FechaGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeLabel);
            this.FechaGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FechaGroupBox.Location = new System.Drawing.Point(183, 11);
            this.FechaGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaGroupBox.Name = "FechaGroupBox";
            this.FechaGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaGroupBox.Size = new System.Drawing.Size(366, 38);
            this.FechaGroupBox.TabIndex = 23;
            this.FechaGroupBox.TabStop = false;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(201, 14);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(37, 15);
            this.HastaLabel.TabIndex = 3;
            this.HastaLabel.Text = "Hasta";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(251, 13);
            this.HastaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.HastaDateTimePicker.TabIndex = 2;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(55, 13);
            this.DesdeDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.DesdeDateTimePicker.TabIndex = 1;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Location = new System.Drawing.Point(5, 14);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(39, 15);
            this.DesdeLabel.TabIndex = 0;
            this.DesdeLabel.Text = "Desde";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Usuario Id",
            "Alias",
            "Nombres",
            "Email",
            "RolId"});
            this.FiltroComboBox.Location = new System.Drawing.Point(51, 53);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(126, 23);
            this.FiltroComboBox.TabIndex = 21;
            // 
            // FiltroFechaCheckBox
            // 
            this.FiltroFechaCheckBox.AutoSize = true;
            this.FiltroFechaCheckBox.Location = new System.Drawing.Point(8, 30);
            this.FiltroFechaCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltroFechaCheckBox.Name = "FiltroFechaCheckBox";
            this.FiltroFechaCheckBox.Size = new System.Drawing.Size(134, 19);
            this.FiltroFechaCheckBox.TabIndex = 20;
            this.FiltroFechaCheckBox.Text = "Usar Filtro de Fechas";
            this.FiltroFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtro";
            // 
            // esActivoGroupBox
            // 
            this.esActivoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.esActivoGroupBox.Controls.Add(this.InactivosRadioButton);
            this.esActivoGroupBox.Controls.Add(this.ActivosRadioButton);
            this.esActivoGroupBox.Controls.Add(this.TodosRadioButton);
            this.esActivoGroupBox.Enabled = false;
            this.esActivoGroupBox.Location = new System.Drawing.Point(555, 3);
            this.esActivoGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.esActivoGroupBox.Name = "esActivoGroupBox";
            this.esActivoGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.esActivoGroupBox.Size = new System.Drawing.Size(108, 73);
            this.esActivoGroupBox.TabIndex = 22;
            this.esActivoGroupBox.TabStop = false;
            this.esActivoGroupBox.Text = "esActivo?";
            // 
            // InactivosRadioButton
            // 
            this.InactivosRadioButton.AutoSize = true;
            this.InactivosRadioButton.Location = new System.Drawing.Point(5, 54);
            this.InactivosRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InactivosRadioButton.Name = "InactivosRadioButton";
            this.InactivosRadioButton.Size = new System.Drawing.Size(72, 19);
            this.InactivosRadioButton.TabIndex = 2;
            this.InactivosRadioButton.Text = "Inactivos";
            this.InactivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivosRadioButton
            // 
            this.ActivosRadioButton.AutoSize = true;
            this.ActivosRadioButton.Location = new System.Drawing.Point(5, 37);
            this.ActivosRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivosRadioButton.Name = "ActivosRadioButton";
            this.ActivosRadioButton.Size = new System.Drawing.Size(64, 19);
            this.ActivosRadioButton.TabIndex = 1;
            this.ActivosRadioButton.Text = "Activos";
            this.ActivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Checked = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(5, 19);
            this.TodosRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(56, 19);
            this.TodosRadioButton.TabIndex = 0;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.Text = "Todos";
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(183, 53);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(366, 23);
            this.CriterioTextBox.TabIndex = 24;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(669, 11);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 65);
            this.BuscarButton.TabIndex = 26;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConsultarUsuariosDataGridView
            // 
            this.ConsultarUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultarUsuariosDataGridView.Location = new System.Drawing.Point(8, 91);
            this.ConsultarUsuariosDataGridView.Name = "ConsultarUsuariosDataGridView";
            this.ConsultarUsuariosDataGridView.RowTemplate.Height = 25;
            this.ConsultarUsuariosDataGridView.Size = new System.Drawing.Size(736, 306);
            this.ConsultarUsuariosDataGridView.TabIndex = 27;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(8, 403);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(128, 35);
            this.ImprimirButton.TabIndex = 28;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.ConsultarUsuariosDataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FiltroActivoCheckBox);
            this.Controls.Add(this.FechaGroupBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroFechaCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esActivoGroupBox);
            this.Controls.Add(this.CriterioTextBox);
            this.Name = "ConsultaUsuarios";
            this.Text = "Consulta de Usuarios";
            this.FechaGroupBox.ResumeLayout(false);
            this.FechaGroupBox.PerformLayout();
            this.esActivoGroupBox.ResumeLayout(false);
            this.esActivoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarUsuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FiltroActivoCheckBox;
        private System.Windows.Forms.GroupBox FechaGroupBox;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.CheckBox FiltroFechaCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox esActivoGroupBox;
        private System.Windows.Forms.RadioButton InactivosRadioButton;
        private System.Windows.Forms.RadioButton ActivosRadioButton;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView ConsultarUsuariosDataGridView;
        private System.Windows.Forms.Button ImprimirButton;
    }
}