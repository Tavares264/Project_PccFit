
namespace PccFit
{
    partial class PgPrincipalNut
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
            this.btnNRotina = new System.Windows.Forms.Button();
            this.btnNAgenda = new System.Windows.Forms.Button();
            this.PanelNPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNRotina
            // 
            this.btnNRotina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNRotina.Location = new System.Drawing.Point(12, 144);
            this.btnNRotina.Name = "btnNRotina";
            this.btnNRotina.Size = new System.Drawing.Size(239, 148);
            this.btnNRotina.TabIndex = 10;
            this.btnNRotina.Text = "Rotina";
            this.btnNRotina.UseVisualStyleBackColor = true;
            this.btnNRotina.Click += new System.EventHandler(this.btnNRotina_Click);
            // 
            // btnNAgenda
            // 
            this.btnNAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNAgenda.Location = new System.Drawing.Point(12, 434);
            this.btnNAgenda.Name = "btnNAgenda";
            this.btnNAgenda.Size = new System.Drawing.Size(239, 148);
            this.btnNAgenda.TabIndex = 9;
            this.btnNAgenda.Text = "Agenda";
            this.btnNAgenda.UseVisualStyleBackColor = true;
            this.btnNAgenda.Click += new System.EventHandler(this.btnNAgenda_Click_1);
            // 
            // PanelNPrincipal
            // 
            this.PanelNPrincipal.Location = new System.Drawing.Point(264, 12);
            this.PanelNPrincipal.Name = "PanelNPrincipal";
            this.PanelNPrincipal.Size = new System.Drawing.Size(1512, 864);
            this.PanelNPrincipal.TabIndex = 6;
            // 
            // PgPrincipalNut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 876);
            this.Controls.Add(this.btnNRotina);
            this.Controls.Add(this.btnNAgenda);
            this.Controls.Add(this.PanelNPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PgPrincipalNut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNRotina;
        private System.Windows.Forms.Button btnNAgenda;
        private System.Windows.Forms.Panel PanelNPrincipal;
    }
}