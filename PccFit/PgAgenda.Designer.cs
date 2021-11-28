
namespace PccFit
{
    partial class PgAgenda
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
            this.txt_AG_NomeNutricionista = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txt_AG_IDNutricionista = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.lst_AG_Ano = new System.Windows.Forms.ListBox();
            this.lst_AG_Mes = new System.Windows.Forms.ListBox();
            this.lst_AG_Dia = new System.Windows.Forms.ListBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txt_AG_Minuto = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_AG_Hora = new System.Windows.Forms.TextBox();
            this.txt_AG_Descrição = new System.Windows.Forms.TextBox();
            this.txt_AG_IDPaciente = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.btn_AG_Excluir = new System.Windows.Forms.Button();
            this.btn_AG_Atualizar = new System.Windows.Forms.Button();
            this.btn_AG_Visualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_nutricionista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_agenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AG_PPesquisar = new System.Windows.Forms.Button();
            this.btn_AG_NPesquisar = new System.Windows.Forms.Button();
            this.txt_AG_Paciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AG_Agendar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_AG_NomeNutricionista
            // 
            this.txt_AG_NomeNutricionista.Location = new System.Drawing.Point(237, 102);
            this.txt_AG_NomeNutricionista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AG_NomeNutricionista.Name = "txt_AG_NomeNutricionista";
            this.txt_AG_NomeNutricionista.Size = new System.Drawing.Size(495, 22);
            this.txt_AG_NomeNutricionista.TabIndex = 43;
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
            // txt_AG_IDNutricionista
            // 
            this.txt_AG_IDNutricionista.Location = new System.Drawing.Point(207, 33);
            this.txt_AG_IDNutricionista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AG_IDNutricionista.Name = "txt_AG_IDNutricionista";
            this.txt_AG_IDNutricionista.Size = new System.Drawing.Size(143, 22);
            this.txt_AG_IDNutricionista.TabIndex = 41;
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
            // lst_AG_Ano
            // 
            this.lst_AG_Ano.FormattingEnabled = true;
            this.lst_AG_Ano.ItemHeight = 16;
            this.lst_AG_Ano.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036"});
            this.lst_AG_Ano.Location = new System.Drawing.Point(1178, 35);
            this.lst_AG_Ano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_AG_Ano.Name = "lst_AG_Ano";
            this.lst_AG_Ano.Size = new System.Drawing.Size(81, 20);
            this.lst_AG_Ano.TabIndex = 39;
            // 
            // lst_AG_Mes
            // 
            this.lst_AG_Mes.FormattingEnabled = true;
            this.lst_AG_Mes.ItemHeight = 16;
            this.lst_AG_Mes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.lst_AG_Mes.Location = new System.Drawing.Point(990, 35);
            this.lst_AG_Mes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_AG_Mes.Name = "lst_AG_Mes";
            this.lst_AG_Mes.Size = new System.Drawing.Size(81, 20);
            this.lst_AG_Mes.TabIndex = 38;
            // 
            // lst_AG_Dia
            // 
            this.lst_AG_Dia.FormattingEnabled = true;
            this.lst_AG_Dia.ItemHeight = 16;
            this.lst_AG_Dia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.lst_AG_Dia.Location = new System.Drawing.Point(810, 35);
            this.lst_AG_Dia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_AG_Dia.Name = "lst_AG_Dia";
            this.lst_AG_Dia.Size = new System.Drawing.Size(81, 20);
            this.lst_AG_Dia.TabIndex = 37;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(1004, 101);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(82, 20);
            this.label45.TabIndex = 36;
            this.label45.Text = "Minuto:";
            // 
            // txt_AG_Minuto
            // 
            this.txt_AG_Minuto.Location = new System.Drawing.Point(1097, 99);
            this.txt_AG_Minuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AG_Minuto.Name = "txt_AG_Minuto";
            this.txt_AG_Minuto.Size = new System.Drawing.Size(143, 22);
            this.txt_AG_Minuto.TabIndex = 35;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(750, 101);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(61, 20);
            this.label44.TabIndex = 34;
            this.label44.Text = "Hora:";
            // 
            // txt_AG_Hora
            // 
            this.txt_AG_Hora.Location = new System.Drawing.Point(834, 99);
            this.txt_AG_Hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AG_Hora.Name = "txt_AG_Hora";
            this.txt_AG_Hora.Size = new System.Drawing.Size(143, 22);
            this.txt_AG_Hora.TabIndex = 33;
            // 
            // txt_AG_Descrição
            // 
            this.txt_AG_Descrição.Location = new System.Drawing.Point(825, 182);
            this.txt_AG_Descrição.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AG_Descrição.Name = "txt_AG_Descrição";
            this.txt_AG_Descrição.Size = new System.Drawing.Size(415, 22);
            this.txt_AG_Descrição.TabIndex = 32;
            // 
            // txt_AG_IDPaciente
            // 
            this.txt_AG_IDPaciente.Location = new System.Drawing.Point(207, 179);
            this.txt_AG_IDPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AG_IDPaciente.Name = "txt_AG_IDPaciente";
            this.txt_AG_IDPaciente.Size = new System.Drawing.Size(143, 22);
            this.txt_AG_IDPaciente.TabIndex = 31;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(931, 35);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(53, 20);
            this.label43.TabIndex = 30;
            this.label43.Text = "Mês:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(757, 35);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(47, 20);
            this.label42.TabIndex = 29;
            this.label42.Text = "Dia:";
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
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(1119, 35);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 20);
            this.label40.TabIndex = 27;
            this.label40.Text = "Ano:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(710, 184);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(108, 20);
            this.label39.TabIndex = 26;
            this.label39.Text = "Descrição:";
            // 
            // btn_AG_Excluir
            // 
            this.btn_AG_Excluir.Location = new System.Drawing.Point(1023, 339);
            this.btn_AG_Excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AG_Excluir.Name = "btn_AG_Excluir";
            this.btn_AG_Excluir.Size = new System.Drawing.Size(237, 47);
            this.btn_AG_Excluir.TabIndex = 25;
            this.btn_AG_Excluir.Text = "Excluir";
            this.btn_AG_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_AG_Atualizar
            // 
            this.btn_AG_Atualizar.Location = new System.Drawing.Point(722, 339);
            this.btn_AG_Atualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AG_Atualizar.Name = "btn_AG_Atualizar";
            this.btn_AG_Atualizar.Size = new System.Drawing.Size(237, 47);
            this.btn_AG_Atualizar.TabIndex = 24;
            this.btn_AG_Atualizar.Text = "Atualizar";
            this.btn_AG_Atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_AG_Visualizar
            // 
            this.btn_AG_Visualizar.Location = new System.Drawing.Point(141, 339);
            this.btn_AG_Visualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AG_Visualizar.Name = "btn_AG_Visualizar";
            this.btn_AG_Visualizar.Size = new System.Drawing.Size(237, 47);
            this.btn_AG_Visualizar.TabIndex = 23;
            this.btn_AG_Visualizar.Text = "Visualizar";
            this.btn_AG_Visualizar.UseVisualStyleBackColor = true;
            this.btn_AG_Visualizar.Click += new System.EventHandler(this.btn_AG_Visualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_nutricionista,
            this.id_paciente,
            this.dt_agenda,
            this.horario,
            this.descricao});
            this.dataGridView1.Location = new System.Drawing.Point(48, 400);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1298, 442);
            this.dataGridView1.TabIndex = 44;
            // 
            // id_nutricionista
            // 
            this.id_nutricionista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_nutricionista.DataPropertyName = "id_nutricionista";
            this.id_nutricionista.HeaderText = "Nutricionista";
            this.id_nutricionista.MinimumWidth = 6;
            this.id_nutricionista.Name = "id_nutricionista";
            this.id_nutricionista.Width = 115;
            // 
            // id_paciente
            // 
            this.id_paciente.DataPropertyName = "id_paciente";
            this.id_paciente.HeaderText = "Paciente";
            this.id_paciente.MinimumWidth = 6;
            this.id_paciente.Name = "id_paciente";
            this.id_paciente.Width = 125;
            // 
            // dt_agenda
            // 
            this.dt_agenda.DataPropertyName = "dt_agenda";
            this.dt_agenda.HeaderText = "Data";
            this.dt_agenda.MinimumWidth = 6;
            this.dt_agenda.Name = "dt_agenda";
            this.dt_agenda.Width = 125;
            // 
            // horario
            // 
            this.horario.DataPropertyName = "horario";
            this.horario.HeaderText = "Horario";
            this.horario.MinimumWidth = 6;
            this.horario.Name = "horario";
            this.horario.Width = 125;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_AG_PPesquisar);
            this.groupBox1.Controls.Add(this.btn_AG_NPesquisar);
            this.groupBox1.Controls.Add(this.txt_AG_Paciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lst_AG_Ano);
            this.groupBox1.Controls.Add(this.lst_AG_Mes);
            this.groupBox1.Controls.Add(this.txt_AG_NomeNutricionista);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.lst_AG_Dia);
            this.groupBox1.Controls.Add(this.txt_AG_IDNutricionista);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.txt_AG_Minuto);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.txt_AG_Hora);
            this.groupBox1.Controls.Add(this.txt_AG_Descrição);
            this.groupBox1.Controls.Add(this.txt_AG_IDPaciente);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Location = new System.Drawing.Point(48, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1298, 294);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btn_AG_PPesquisar
            // 
            this.btn_AG_PPesquisar.Location = new System.Drawing.Point(417, 166);
            this.btn_AG_PPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AG_PPesquisar.Name = "btn_AG_PPesquisar";
            this.btn_AG_PPesquisar.Size = new System.Drawing.Size(237, 42);
            this.btn_AG_PPesquisar.TabIndex = 48;
            this.btn_AG_PPesquisar.Text = "Pesquisar";
            this.btn_AG_PPesquisar.UseVisualStyleBackColor = true;
            this.btn_AG_PPesquisar.Click += new System.EventHandler(this.btn_AG_PPesquisar_Click);
            // 
            // btn_AG_NPesquisar
            // 
            this.btn_AG_NPesquisar.Location = new System.Drawing.Point(417, 24);
            this.btn_AG_NPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AG_NPesquisar.Name = "btn_AG_NPesquisar";
            this.btn_AG_NPesquisar.Size = new System.Drawing.Size(237, 41);
            this.btn_AG_NPesquisar.TabIndex = 47;
            this.btn_AG_NPesquisar.Text = "Pesquisar";
            this.btn_AG_NPesquisar.UseVisualStyleBackColor = true;
            this.btn_AG_NPesquisar.Click += new System.EventHandler(this.btn_AG_NPesquisar_Click);
            // 
            // txt_AG_Paciente
            // 
            this.txt_AG_Paciente.Location = new System.Drawing.Point(237, 242);
            this.txt_AG_Paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AG_Paciente.Name = "txt_AG_Paciente";
            this.txt_AG_Paciente.Size = new System.Drawing.Size(495, 22);
            this.txt_AG_Paciente.TabIndex = 45;
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
            // btn_AG_Agendar
            // 
            this.btn_AG_Agendar.Location = new System.Drawing.Point(432, 339);
            this.btn_AG_Agendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AG_Agendar.Name = "btn_AG_Agendar";
            this.btn_AG_Agendar.Size = new System.Drawing.Size(237, 47);
            this.btn_AG_Agendar.TabIndex = 46;
            this.btn_AG_Agendar.Text = "Agendar";
            this.btn_AG_Agendar.UseVisualStyleBackColor = true;
            this.btn_AG_Agendar.Click += new System.EventHandler(this.btn_AG_Agendar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(495, 24);
            this.comboBox1.TabIndex = 49;
            // 
            // PgAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 867);
            this.Controls.Add(this.btn_AG_Agendar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_AG_Visualizar);
            this.Controls.Add(this.btn_AG_Atualizar);
            this.Controls.Add(this.btn_AG_Excluir);
            this.Name = "PgAgenda";
            this.Text = "PgAgenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AG_NomeNutricionista;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txt_AG_IDNutricionista;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ListBox lst_AG_Ano;
        private System.Windows.Forms.ListBox lst_AG_Mes;
        private System.Windows.Forms.ListBox lst_AG_Dia;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txt_AG_Minuto;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txt_AG_Hora;
        private System.Windows.Forms.TextBox txt_AG_Descrição;
        private System.Windows.Forms.TextBox txt_AG_IDPaciente;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btn_AG_Excluir;
        private System.Windows.Forms.Button btn_AG_Atualizar;
        private System.Windows.Forms.Button btn_AG_Visualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_nutricionista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_agenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.TextBox txt_AG_Paciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AG_Agendar;
        private System.Windows.Forms.Button btn_AG_PPesquisar;
        private System.Windows.Forms.Button btn_AG_NPesquisar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}