namespace SISCONTROLE
{
    partial class frmClientes
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gvwClientes = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwClientes)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Location = new System.Drawing.Point(10, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(9, 19);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(62, 20);
            this.txtcodigo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(96, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 19);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(409, 20);
            this.txtNome.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEndereco);
            this.groupBox3.Location = new System.Drawing.Point(10, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 19);
            this.txtEndereco.MaxLength = 200;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(309, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtcidade);
            this.groupBox4.Location = new System.Drawing.Point(339, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 53);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cidade";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(6, 19);
            this.txtcidade.MaxLength = 100;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(309, 20);
            this.txtcidade.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtcep);
            this.groupBox5.Location = new System.Drawing.Point(12, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(84, 53);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cep";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(6, 19);
            this.txtcep.MaxLength = 10;
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(72, 20);
            this.txtcep.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txttelefone);
            this.groupBox6.Location = new System.Drawing.Point(102, 168);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(129, 53);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Telefone";
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(6, 19);
            this.txttelefone.MaxLength = 20;
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(117, 20);
            this.txttelefone.TabIndex = 5;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtemail);
            this.groupBox7.Location = new System.Drawing.Point(372, 168);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(425, 53);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "E-mail";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(6, 19);
            this.txtemail.MaxLength = 200;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(411, 20);
            this.txtemail.TabIndex = 7;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtcelular);
            this.groupBox8.Location = new System.Drawing.Point(237, 168);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(129, 53);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Celular";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(6, 19);
            this.txtcelular.MaxLength = 20;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(117, 20);
            this.txtcelular.TabIndex = 6;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtestado);
            this.groupBox9.Location = new System.Drawing.Point(668, 110);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(221, 53);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(6, 19);
            this.txtestado.MaxLength = 50;
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(209, 20);
            this.txtestado.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(92, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 11;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // gvwClientes
            // 
            this.gvwClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwClientes.Location = new System.Drawing.Point(12, 286);
            this.gvwClientes.Name = "gvwClientes";
            this.gvwClientes.Size = new System.Drawing.Size(877, 162);
            this.gvwClientes.TabIndex = 12;
            this.gvwClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvwClientes_CellClick);
            this.gvwClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvwClientes_CellDoubleClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(8, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(254, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox10.Controls.Add(this.btnListarTodos);
            this.groupBox10.Controls.Add(this.btnBuscar);
            this.groupBox10.Controls.Add(this.txtbuscar);
            this.groupBox10.Location = new System.Drawing.Point(12, 227);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(877, 53);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Pesquisar por Nome";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(424, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(6, 19);
            this.txtbuscar.MaxLength = 200;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(411, 20);
            this.txtbuscar.TabIndex = 7;
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new System.Drawing.Point(505, 18);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnListarTodos.TabIndex = 9;
            this.btnListarTodos.Text = "Listar todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(173, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(442, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(804, 13);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(79, 23);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 475);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gvwClientes);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClientes";
            this.Text = "Cadastro de CLientes";
            this.Activated += new System.EventHandler(this.frmClientes_Activated);
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwClientes)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView gvwClientes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
    }
}

