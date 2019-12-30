namespace ProjetoCadastro
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label idLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.gravar = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.label_excluir = new System.Windows.Forms.Label();
            this.label_editar = new System.Windows.Forms.Label();
            this.Button_ConsultarCEP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpfLabel.Location = new System.Drawing.Point(167, 22);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(33, 15);
            cpfLabel.TabIndex = 14;
            cpfLabel.Text = "CPF:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(93, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(22, 15);
            idLabel.TabIndex = 13;
            idLabel.Text = "ID:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(558, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gravar
            // 
            this.gravar.BackColor = System.Drawing.SystemColors.Window;
            this.gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravar.Location = new System.Drawing.Point(286, 355);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(75, 38);
            this.gravar.TabIndex = 13;
            this.gravar.Text = "Gravar";
            this.gravar.UseVisualStyleBackColor = false;
            this.gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(348, 200);
            this.txt_telefone.Mask = "(00) 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(104, 21);
            this.txt_telefone.TabIndex = 11;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(120, 237);
            this.txt_email.MaxLength = 50;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(332, 21);
            this.txt_email.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone:";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.Button_ConsultarCEP);
            this.groupBox.Controls.Add(this.txt_telefone);
            this.groupBox.Controls.Add(this.txt_cpf);
            this.groupBox.Controls.Add(this.txt_email);
            this.groupBox.Controls.Add(this.txt_cep);
            this.groupBox.Controls.Add(this.txt_nascimento);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(cpfLabel);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(idLabel);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txt_id);
            this.groupBox.Controls.Add(this.txt_estado);
            this.groupBox.Controls.Add(this.nome);
            this.groupBox.Controls.Add(this.txt_nome);
            this.groupBox.Controls.Add(this.txt_cidade);
            this.groupBox.Controls.Add(this.txt_endereco);
            this.groupBox.Controls.Add(this.estado);
            this.groupBox.Controls.Add(this.numero);
            this.groupBox.Controls.Add(this.txt_bairro);
            this.groupBox.Controls.Add(this.endereco);
            this.groupBox.Controls.Add(this.bairro);
            this.groupBox.Controls.Add(this.txt_numero);
            this.groupBox.Controls.Add(this.cidade);
            this.groupBox.Location = new System.Drawing.Point(221, 83);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(472, 266);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // txt_cpf
            // 
            this.txt_cpf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.Location = new System.Drawing.Point(203, 19);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(99, 21);
            this.txt_cpf.TabIndex = 2;
            // 
            // txt_cep
            // 
            this.txt_cep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.Location = new System.Drawing.Point(260, 89);
            this.txt_cep.Mask = "00000-000";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(73, 21);
            this.txt_cep.TabIndex = 10;
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nascimento.Location = new System.Drawing.Point(120, 89);
            this.txt_nascimento.Mask = "00/00/0000";
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(75, 21);
            this.txt_nascimento.TabIndex = 4;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(118, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(45, 21);
            this.txt_id.TabIndex = 1;
            // 
            // txt_estado
            // 
            this.txt_estado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.FormattingEnabled = true;
            this.txt_estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.txt_estado.Location = new System.Drawing.Point(355, 125);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(97, 23);
            this.txt_estado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de nacimento:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(17, 56);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(98, 15);
            this.nome.TabIndex = 4;
            this.nome.Text = "Nome completo:";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(118, 53);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(334, 21);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_cidade
            // 
            this.txt_cidade.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(118, 126);
            this.txt_cidade.MaxLength = 50;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(177, 21);
            this.txt_cidade.TabIndex = 5;
            // 
            // txt_endereco
            // 
            this.txt_endereco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(118, 163);
            this.txt_endereco.MaxLength = 50;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(239, 21);
            this.txt_endereco.TabIndex = 7;
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(301, 129);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(48, 15);
            this.estado.TabIndex = 12;
            this.estado.Text = "Estado:";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(363, 166);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(23, 15);
            this.numero.TabIndex = 11;
            this.numero.Text = "Nº:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(120, 200);
            this.txt_bairro.MaxLength = 50;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(163, 21);
            this.txt_bairro.TabIndex = 9;
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(49, 166);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(63, 15);
            this.endereco.TabIndex = 5;
            this.endereco.Text = "Endereço:";
            // 
            // bairro
            // 
            this.bairro.AutoSize = true;
            this.bairro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro.Location = new System.Drawing.Point(76, 203);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(43, 15);
            this.bairro.TabIndex = 13;
            this.bairro.Text = "Bairro:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(392, 164);
            this.txt_numero.MaxLength = 15;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(60, 20);
            this.txt_numero.TabIndex = 8;
            // 
            // cidade
            // 
            this.cidade.AutoSize = true;
            this.cidade.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(63, 129);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(49, 15);
            this.cidade.TabIndex = 11;
            this.cidade.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(230, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "CADASTRO DE CLIENTES";
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.SystemColors.Window;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.Location = new System.Drawing.Point(470, 355);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 38);
            this.button_excluir.TabIndex = 15;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.Excluir_Click);
            this.button_excluir.MouseLeave += new System.EventHandler(this.Button_excluir_MouseLeave);
            this.button_excluir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_excluir_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(381, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.Button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseMove);
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.AllowUserToResizeColumns = false;
            this.dg_dados.AllowUserToResizeRows = false;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(32, 410);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dados.Size = new System.Drawing.Size(835, 236);
            this.dg_dados.TabIndex = 20;
            this.dg_dados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_dados_CellContentDoubleClick);
            // 
            // label_excluir
            // 
            this.label_excluir.AutoSize = true;
            this.label_excluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_excluir.Location = new System.Drawing.Point(510, 331);
            this.label_excluir.Name = "label_excluir";
            this.label_excluir.Size = new System.Drawing.Size(0, 13);
            this.label_excluir.TabIndex = 21;
            // 
            // label_editar
            // 
            this.label_editar.AutoSize = true;
            this.label_editar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_editar.Location = new System.Drawing.Point(423, 381);
            this.label_editar.Name = "label_editar";
            this.label_editar.Size = new System.Drawing.Size(0, 13);
            this.label_editar.TabIndex = 22;
            // 
            // Button_ConsultarCEP
            // 
            this.Button_ConsultarCEP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_ConsultarCEP.BackgroundImage = global::ProjetoCadastro.Properties.Resources.busca_cep;
            this.Button_ConsultarCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_ConsultarCEP.Location = new System.Drawing.Point(339, 80);
            this.Button_ConsultarCEP.Name = "Button_ConsultarCEP";
            this.Button_ConsultarCEP.Size = new System.Drawing.Size(113, 41);
            this.Button_ConsultarCEP.TabIndex = 23;
            this.Button_ConsultarCEP.UseVisualStyleBackColor = false;
            this.Button_ConsultarCEP.Click += new System.EventHandler(this.Button_ConsultarCEP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "CEP:";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(900, 658);
            this.Controls.Add(this.label_editar);
            this.Controls.Add(this.label_excluir);
            this.Controls.Add(this.dg_dados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gravar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gravar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label bairro;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_estado;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.MaskedTextBox txt_nascimento;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Label label_excluir;
        private System.Windows.Forms.Label label_editar;
        private System.Windows.Forms.Button Button_ConsultarCEP;
        private System.Windows.Forms.Label label5;
    }
}

