
namespace LeandroHospital
{
    partial class VerMedicos
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
            this.listMedicos = new System.Windows.Forms.ListBox();
            this.BorrarMedico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEDICOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listMedicos
            // 
            this.listMedicos.FormattingEnabled = true;
            this.listMedicos.ItemHeight = 16;
            this.listMedicos.Location = new System.Drawing.Point(171, 125);
            this.listMedicos.Name = "listMedicos";
            this.listMedicos.Size = new System.Drawing.Size(409, 212);
            this.listMedicos.TabIndex = 2;
            this.listMedicos.SelectedIndexChanged += new System.EventHandler(this.listMedicos_SelectedIndexChanged);
            // 
            // BorrarMedico
            // 
            this.BorrarMedico.Location = new System.Drawing.Point(626, 125);
            this.BorrarMedico.Name = "BorrarMedico";
            this.BorrarMedico.Size = new System.Drawing.Size(119, 33);
            this.BorrarMedico.TabIndex = 3;
            this.BorrarMedico.Text = "BORRAR";
            this.BorrarMedico.UseVisualStyleBackColor = true;
            this.BorrarMedico.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "AÑADIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VerMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BorrarMedico);
            this.Controls.Add(this.listMedicos);
            this.Controls.Add(this.label1);
            this.Name = "VerMedicos";
            this.Text = "Ver Lista de Medicos";
            this.Load += new System.EventHandler(this.VerMedicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listMedicos;
        private System.Windows.Forms.Button BorrarMedico;
        private System.Windows.Forms.Button button1;
    }
}