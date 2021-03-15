
namespace CrearRegistroConDetalle.UI.Consultas
{
    partial class ConsultaRoles
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
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FechaGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.esActivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivosRadioButton = new System.Windows.Forms.RadioButton();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ConsultarRolesDataGridView = new System.Windows.Forms.DataGridView();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.FiltroActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaGroupBox.SuspendLayout();
            this.esActivoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarRolesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(159, 58);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(366, 23);
            this.CriterioTextBox.TabIndex = 14;
            // 
            // FechaGroupBox
            // 
            this.FechaGroupBox.Controls.Add(this.HastaLabel);
            this.FechaGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeLabel);
            this.FechaGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FechaGroupBox.Location = new System.Drawing.Point(159, 8);
            this.FechaGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaGroupBox.Name = "FechaGroupBox";
            this.FechaGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaGroupBox.Size = new System.Drawing.Size(366, 38);
            this.FechaGroupBox.TabIndex = 13;
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
            // esActivoGroupBox
            // 
            this.esActivoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.esActivoGroupBox.Controls.Add(this.InactivosRadioButton);
            this.esActivoGroupBox.Controls.Add(this.ActivosRadioButton);
            this.esActivoGroupBox.Controls.Add(this.TodosRadioButton);
            this.esActivoGroupBox.Location = new System.Drawing.Point(539, 8);
            this.esActivoGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.esActivoGroupBox.Name = "esActivoGroupBox";
            this.esActivoGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.esActivoGroupBox.Size = new System.Drawing.Size(108, 73);
            this.esActivoGroupBox.TabIndex = 12;
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
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Rol id",
            "Descripción"});
            this.FiltroComboBox.Location = new System.Drawing.Point(47, 58);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(104, 23);
            this.FiltroComboBox.TabIndex = 11;
            // 
            // FiltroFechaCheckBox
            // 
            this.FiltroFechaCheckBox.AutoSize = true;
            this.FiltroFechaCheckBox.Location = new System.Drawing.Point(7, 18);
            this.FiltroFechaCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltroFechaCheckBox.Name = "FiltroFechaCheckBox";
            this.FiltroFechaCheckBox.Size = new System.Drawing.Size(134, 19);
            this.FiltroFechaCheckBox.TabIndex = 10;
            this.FiltroFechaCheckBox.Text = "Usar Filtro de Fechas";
            this.FiltroFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtro";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(653, 16);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(84, 65);
            this.BuscarButton.TabIndex = 15;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConsultarRolesDataGridView
            // 
            this.ConsultarRolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultarRolesDataGridView.Location = new System.Drawing.Point(7, 95);
            this.ConsultarRolesDataGridView.Name = "ConsultarRolesDataGridView";
            this.ConsultarRolesDataGridView.RowTemplate.Height = 25;
            this.ConsultarRolesDataGridView.Size = new System.Drawing.Size(730, 288);
            this.ConsultarRolesDataGridView.TabIndex = 16;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(7, 389);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(112, 36);
            this.ImprimirButton.TabIndex = 17;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // FiltroActivoCheckBox
            // 
            this.FiltroActivoCheckBox.AutoSize = true;
            this.FiltroActivoCheckBox.Location = new System.Drawing.Point(7, 34);
            this.FiltroActivoCheckBox.Name = "FiltroActivoCheckBox";
            this.FiltroActivoCheckBox.Size = new System.Drawing.Size(130, 19);
            this.FiltroActivoCheckBox.TabIndex = 18;
            this.FiltroActivoCheckBox.Text = "Usar Filtro es Activo";
            this.FiltroActivoCheckBox.UseVisualStyleBackColor = true;
            this.FiltroActivoCheckBox.CheckedChanged += new System.EventHandler(this.FiltroActivoCheckBox_CheckedChanged);
            // 
            // ConsultaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 437);
            this.Controls.Add(this.FiltroActivoCheckBox);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.ConsultarRolesDataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FechaGroupBox);
            this.Controls.Add(this.esActivoGroupBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroFechaCheckBox);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaRoles";
            this.Text = "Consulta de Roles";
            this.FechaGroupBox.ResumeLayout(false);
            this.FechaGroupBox.PerformLayout();
            this.esActivoGroupBox.ResumeLayout(false);
            this.esActivoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarRolesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.GroupBox FechaGroupBox;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.GroupBox esActivoGroupBox;
        private System.Windows.Forms.RadioButton InactivosRadioButton;
        private System.Windows.Forms.RadioButton ActivosRadioButton;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.CheckBox FiltroFechaCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView ConsultarRolesDataGridView;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.CheckBox FiltroActivoCheckBox;
    }
}