
namespace LeandroHospital
{
    partial class VerPacientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.listPacientes = new System.Windows.Forms.ListBox();
            this.BorrarPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PACIENTES";
            // 
            // listPacientes
            // 
            this.listPacientes.FormattingEnabled = true;
            this.listPacientes.ItemHeight = 16;
            this.listPacientes.Location = new System.Drawing.Point(189, 133);
            this.listPacientes.Name = "listPacientes";
            this.listPacientes.Size = new System.Drawing.Size(423, 244);
            this.listPacientes.TabIndex = 1;
            // 
            // BorrarPaciente
            // 
            this.BorrarPaciente.Location = new System.Drawing.Point(672, 133);
            this.BorrarPaciente.Name = "BorrarPaciente";
            this.BorrarPaciente.Size = new System.Drawing.Size(99, 33);
            this.BorrarPaciente.TabIndex = 2;
            this.BorrarPaciente.Text = "BORRAR";
            this.BorrarPaciente.UseVisualStyleBackColor = true;
            this.BorrarPaciente.Click += new System.EventHandler(this.BorrarPaciente_Click);
            // 
            // VerPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BorrarPaciente);
            this.Controls.Add(this.listPacientes);
            this.Controls.Add(this.label1);
            this.Name = "VerPacientes";
            this.Text = "VerPacientes";
            this.Load += new System.EventHandler(this.VerPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPacientes;
        private System.Windows.Forms.Button BorrarPaciente;
    }
}