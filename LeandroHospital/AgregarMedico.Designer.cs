
namespace LeandroHospital
{
    partial class AgregarMedico
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomAgMedico = new System.Windows.Forms.TextBox();
            this.txtApeAgMedico = new System.Windows.Forms.TextBox();
            this.txtMatAgMedico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR MEDICO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "MATRICULA";
            // 
            // txtNomAgMedico
            // 
            this.txtNomAgMedico.Location = new System.Drawing.Point(160, 103);
            this.txtNomAgMedico.Name = "txtNomAgMedico";
            this.txtNomAgMedico.Size = new System.Drawing.Size(210, 22);
            this.txtNomAgMedico.TabIndex = 4;
            // 
            // txtApeAgMedico
            // 
            this.txtApeAgMedico.Location = new System.Drawing.Point(160, 176);
            this.txtApeAgMedico.Name = "txtApeAgMedico";
            this.txtApeAgMedico.Size = new System.Drawing.Size(210, 22);
            this.txtApeAgMedico.TabIndex = 5;
            // 
            // txtMatAgMedico
            // 
            this.txtMatAgMedico.Location = new System.Drawing.Point(160, 251);
            this.txtMatAgMedico.Name = "txtMatAgMedico";
            this.txtMatAgMedico.Size = new System.Drawing.Size(210, 22);
            this.txtMatAgMedico.TabIndex = 6;
            // 
            // AgregarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMatAgMedico);
            this.Controls.Add(this.txtApeAgMedico);
            this.Controls.Add(this.txtNomAgMedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarMedico";
            this.Text = "AgregarMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomAgMedico;
        private System.Windows.Forms.TextBox txtApeAgMedico;
        private System.Windows.Forms.TextBox txtMatAgMedico;
    }
}