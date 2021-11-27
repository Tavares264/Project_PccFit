
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
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnDoutor = new System.Windows.Forms.Button();
            this.btnCadastrarNutricionista = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Location = new System.Drawing.Point(243, 12);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1075, 770);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.Location = new System.Drawing.Point(12, 98);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(225, 101);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.Text = "Cadastrar Cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            // 
            // btnDoutor
            // 
            this.btnDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoutor.Location = new System.Drawing.Point(12, 253);
            this.btnDoutor.Name = "btnDoutor";
            this.btnDoutor.Size = new System.Drawing.Size(225, 101);
            this.btnDoutor.TabIndex = 1;
            this.btnDoutor.Text = "Cadastrar Atendente";
            this.btnDoutor.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarNutricionista
            // 
            this.btnCadastrarNutricionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNutricionista.Location = new System.Drawing.Point(12, 415);
            this.btnCadastrarNutricionista.Name = "btnCadastrarNutricionista";
            this.btnCadastrarNutricionista.Size = new System.Drawing.Size(225, 101);
            this.btnCadastrarNutricionista.TabIndex = 2;
            this.btnCadastrarNutricionista.Text = "Cadastrar Nutricionista";
            this.btnCadastrarNutricionista.UseVisualStyleBackColor = true;
            // 
            // btnAgenda
            // 
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Location = new System.Drawing.Point(12, 574);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(225, 101);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            // 
            // PgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 794);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnCadastrarNutricionista);
            this.Controls.Add(this.btnDoutor);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "PgPrincipal";
            this.Text = "PgPrincipal";
            this.Load += new System.EventHandler(this.PgPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnDoutor;
        private System.Windows.Forms.Button btnCadastrarNutricionista;
        private System.Windows.Forms.Button btnAgenda;
    }
}