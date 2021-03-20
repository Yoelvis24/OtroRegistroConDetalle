
namespace CrearRegistroConDetalle.UI.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.CLaveTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EntrarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CorreoLabel.Location = new System.Drawing.Point(12, 102);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(74, 25);
            this.CorreoLabel.TabIndex = 0;
            this.CorreoLabel.Text = "Correo";
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClaveLabel.Location = new System.Drawing.Point(12, 175);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(113, 25);
            this.ClaveLabel.TabIndex = 1;
            this.ClaveLabel.Text = "Contraseña";
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CorreoTextBox.Location = new System.Drawing.Point(12, 139);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(305, 27);
            this.CorreoTextBox.TabIndex = 2;
            // 
            // CLaveTextBox
            // 
            this.CLaveTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CLaveTextBox.Location = new System.Drawing.Point(12, 214);
            this.CLaveTextBox.Name = "CLaveTextBox";
            this.CLaveTextBox.PasswordChar = '*';
            this.CLaveTextBox.Size = new System.Drawing.Size(305, 27);
            this.CLaveTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EntrarButton
            // 
            this.EntrarButton.Location = new System.Drawing.Point(121, 256);
            this.EntrarButton.Name = "EntrarButton";
            this.EntrarButton.Size = new System.Drawing.Size(89, 30);
            this.EntrarButton.TabIndex = 5;
            this.EntrarButton.Text = "Entrar";
            this.EntrarButton.UseVisualStyleBackColor = true;
            this.EntrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 302);
            this.Controls.Add(this.EntrarButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CLaveTextBox);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.CorreoLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CorreoLabel;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.TextBox CLaveTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EntrarButton;
    }
}