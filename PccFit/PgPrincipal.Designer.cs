
namespace PccFit
{
    partial class PgPrincipal
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.btnCad_Cliente = new System.Windows.Forms.Button();
            this.btnCad_Atendente = new System.Windows.Forms.Button();
            this.btnCad_Nutricionista = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Location = new System.Drawing.Point(264, 6);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1512, 864);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // btnCad_Cliente
            // 
            this.btnCad_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad_Cliente.Location = new System.Drawing.Point(12, 236);
            this.btnCad_Cliente.Name = "btnCad_Cliente";
            this.btnCad_Cliente.Size = new System.Drawing.Size(239, 197);
            this.btnCad_Cliente.TabIndex = 0;
            this.btnCad_Cliente.Text = "Cadastrar Paciente";
            this.btnCad_Cliente.UseVisualStyleBackColor = true;
            this.btnCad_Cliente.Click += new System.EventHandler(this.btnCad_Cliente_Click);
            // 
            // btnCad_Atendente
            // 
            this.btnCad_Atendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad_Atendente.Location = new System.Drawing.Point(12, 439);
            this.btnCad_Atendente.Name = "btnCad_Atendente";
            this.btnCad_Atendente.Size = new System.Drawing.Size(239, 197);
            this.btnCad_Atendente.TabIndex = 1;
            this.btnCad_Atendente.Text = "Cadastrar Atendente";
            this.btnCad_Atendente.UseVisualStyleBackColor = true;
            this.btnCad_Atendente.Click += new System.EventHandler(this.btnCad_Atendente_Click);
            // 
            // btnCad_Nutricionista
            // 
            this.btnCad_Nutricionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad_Nutricionista.Location = new System.Drawing.Point(12, 642);
            this.btnCad_Nutricionista.Name = "btnCad_Nutricionista";
            this.btnCad_Nutricionista.Size = new System.Drawing.Size(239, 197);
            this.btnCad_Nutricionista.TabIndex = 2;
            this.btnCad_Nutricionista.Text = "Cadastrar Nutricionista";
            this.btnCad_Nutricionista.UseVisualStyleBackColor = true;
            this.btnCad_Nutricionista.Click += new System.EventHandler(this.btnCad_Nutricionista_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Location = new System.Drawing.Point(12, 33);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(239, 197);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // PgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 876);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnCad_Nutricionista);
            this.Controls.Add(this.btnCad_Atendente);
            this.Controls.Add(this.btnCad_Cliente);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "PgPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PgPrincipal";
            this.Load += new System.EventHandler(this.PgPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button btnCad_Cliente;
        private System.Windows.Forms.Button btnCad_Atendente;
        private System.Windows.Forms.Button btnCad_Nutricionista;
        private System.Windows.Forms.Button btnAgenda;
    }
}