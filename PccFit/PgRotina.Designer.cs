namespace PccFit
{
    partial class PgRotina
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_R_Paciente = new System.Windows.Forms.ComboBox();
            this.cb_R_Nutricionista = new System.Windows.Forms.ComboBox();
            this.btn_R_PPesquisar = new System.Windows.Forms.Button();
            this.btn_R_NPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txt_R_IDNutricionista = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txt_R_Itens = new System.Windows.Forms.TextBox();
            this.txt_R_IDPaciente = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.btn_R_Cadastrar = new System.Windows.Forms.Button();
            this.btn_R_Excluir = new System.Windows.Forms.Button();
            this.dtGridRotina = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRotina)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_R_Paciente);
            this.groupBox1.Controls.Add(this.cb_R_Nutricionista);
            this.groupBox1.Controls.Add(this.btn_R_PPesquisar);
            this.groupBox1.Controls.Add(this.btn_R_NPesquisar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.txt_R_IDNutricionista);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.txt_R_Itens);
            this.groupBox1.Controls.Add(this.txt_R_IDPaciente);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Location = new System.Drawing.Point(49, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 294);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // cb_R_Paciente
            // 
            this.cb_R_Paciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_R_Paciente.FormattingEnabled = true;
            this.cb_R_Paciente.Location = new System.Drawing.Point(237, 241);
            this.cb_R_Paciente.Name = "cb_R_Paciente";
            this.cb_R_Paciente.Size = new System.Drawing.Size(495, 24);
            this.cb_R_Paciente.TabIndex = 52;
            this.cb_R_Paciente.SelectedIndexChanged += new System.EventHandler(this.cb_R_Paciente_SelectedIndexChanged);
            // 
            // cb_R_Nutricionista
            // 
            this.cb_R_Nutricionista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_R_Nutricionista.FormattingEnabled = true;
            this.cb_R_Nutricionista.Location = new System.Drawing.Point(249, 105);
            this.cb_R_Nutricionista.Name = "cb_R_Nutricionista";
            this.cb_R_Nutricionista.Size = new System.Drawing.Size(495, 24);
            this.cb_R_Nutricionista.TabIndex = 49;
            this.cb_R_Nutricionista.SelectedIndexChanged += new System.EventHandler(this.cb_R_Nutricionista_SelectedIndexChanged);
            // 
            // btn_R_PPesquisar
            // 
            this.btn_R_PPesquisar.Location = new System.Drawing.Point(417, 166);
            this.btn_R_PPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_R_PPesquisar.Name = "btn_R_PPesquisar";
            this.btn_R_PPesquisar.Size = new System.Drawing.Size(237, 42);
            this.btn_R_PPesquisar.TabIndex = 48;
            this.btn_R_PPesquisar.Text = "Pesquisar";
            this.btn_R_PPesquisar.UseVisualStyleBackColor = true;
            this.btn_R_PPesquisar.Click += new System.EventHandler(this.btn_R_PPesquisar_Click);
            // 
            // btn_R_NPesquisar
            // 
            this.btn_R_NPesquisar.Location = new System.Drawing.Point(417, 24);
            this.btn_R_NPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_R_NPesquisar.Name = "btn_R_NPesquisar";
            this.btn_R_NPesquisar.Size = new System.Drawing.Size(237, 41);
            this.btn_R_NPesquisar.TabIndex = 47;
            this.btn_R_NPesquisar.Text = "Pesquisar";
            this.btn_R_NPesquisar.UseVisualStyleBackColor = true;
            this.btn_R_NPesquisar.Click += new System.EventHandler(this.btn_R_NPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome Paciente:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(31, 105);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(200, 20);
            this.label47.TabIndex = 42;
            this.label47.Text = "Nome Nutricionista:";
            // 
            // txt_R_IDNutricionista
            // 
            this.txt_R_IDNutricionista.BackColor = System.Drawing.SystemColors.Window;
            this.txt_R_IDNutricionista.Enabled = false;
            this.txt_R_IDNutricionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_IDNutricionista.Location = new System.Drawing.Point(207, 33);
            this.txt_R_IDNutricionista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_R_IDNutricionista.Name = "txt_R_IDNutricionista";
            this.txt_R_IDNutricionista.Size = new System.Drawing.Size(143, 22);
            this.txt_R_IDNutricionista.TabIndex = 41;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(33, 36);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(168, 20);
            this.label46.TabIndex = 40;
            this.label46.Text = "ID Nutricionista:";
            // 
            // txt_R_Itens
            // 
            this.txt_R_Itens.Location = new System.Drawing.Point(830, 105);
            this.txt_R_Itens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_R_Itens.Multiline = true;
            this.txt_R_Itens.Name = "txt_R_Itens";
            this.txt_R_Itens.Size = new System.Drawing.Size(233, 103);
            this.txt_R_Itens.TabIndex = 32;
            // 
            // txt_R_IDPaciente
            // 
            this.txt_R_IDPaciente.Enabled = false;
            this.txt_R_IDPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_IDPaciente.Location = new System.Drawing.Point(207, 179);
            this.txt_R_IDPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_R_IDPaciente.Name = "txt_R_IDPaciente";
            this.txt_R_IDPaciente.Size = new System.Drawing.Size(143, 22);
            this.txt_R_IDPaciente.TabIndex = 31;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(63, 181);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(126, 20);
            this.label41.TabIndex = 28;
            this.label41.Text = "ID Paciente:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(862, 76);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(153, 20);
            this.label39.TabIndex = 26;
            this.label39.Text = "Iten da Rotina:";
            // 
            // btn_R_Cadastrar
            // 
            this.btn_R_Cadastrar.Location = new System.Drawing.Point(313, 350);
            this.btn_R_Cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_R_Cadastrar.Name = "btn_R_Cadastrar";
            this.btn_R_Cadastrar.Size = new System.Drawing.Size(237, 47);
            this.btn_R_Cadastrar.TabIndex = 49;
            this.btn_R_Cadastrar.Text = "Cadastrar";
            this.btn_R_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_R_Cadastrar.Click += new System.EventHandler(this.btn_R_Cadastrar_Click);
            // 
            // btn_R_Excluir
            // 
            this.btn_R_Excluir.Location = new System.Drawing.Point(715, 350);
            this.btn_R_Excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_R_Excluir.Name = "btn_R_Excluir";
            this.btn_R_Excluir.Size = new System.Drawing.Size(237, 47);
            this.btn_R_Excluir.TabIndex = 48;
            this.btn_R_Excluir.Text = "Excluir";
            this.btn_R_Excluir.UseVisualStyleBackColor = true;
            this.btn_R_Excluir.Click += new System.EventHandler(this.btn_R_Excluir_Click);
            // 
            // dtGridRotina
            // 
            this.dtGridRotina.AllowUserToOrderColumns = true;
            this.dtGridRotina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridRotina.Location = new System.Drawing.Point(34, 412);
            this.dtGridRotina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGridRotina.Name = "dtGridRotina";
            this.dtGridRotina.RowHeadersWidth = 51;
            this.dtGridRotina.RowTemplate.Height = 24;
            this.dtGridRotina.Size = new System.Drawing.Size(1199, 350);
            this.dtGridRotina.TabIndex = 50;
            this.dtGridRotina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridRotina_CellDoubleClick);
            // 
            // PgRotina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 785);
            this.Controls.Add(this.dtGridRotina);
            this.Controls.Add(this.btn_R_Cadastrar);
            this.Controls.Add(this.btn_R_Excluir);
            this.Controls.Add(this.groupBox1);
            this.Name = "PgRotina";
            this.Text = "PgRotina";
            this.Load += new System.EventHandler(this.PgRotina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRotina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_R_Paciente;
        private System.Windows.Forms.ComboBox cb_R_Nutricionista;
        private System.Windows.Forms.Button btn_R_PPesquisar;
        private System.Windows.Forms.Button btn_R_NPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txt_R_IDNutricionista;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txt_R_Itens;
        private System.Windows.Forms.TextBox txt_R_IDPaciente;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btn_R_Cadastrar;
        private System.Windows.Forms.Button btn_R_Excluir;
        private System.Windows.Forms.DataGridView dtGridRotina;
    }
}