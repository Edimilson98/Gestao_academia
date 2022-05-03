namespace estudocsharp
{
    partial class Frm_GAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.msktb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.btn_imprimirCar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.pb_alterarfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alterarfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToAddRows = false;
            this.dgv_alunos.AllowUserToDeleteRows = false;
            this.dgv_alunos.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.EnableHeadersVisualStyles = false;
            this.dgv_alunos.Location = new System.Drawing.Point(13, 13);
            this.dgv_alunos.MultiSelect = false;
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.ReadOnly = true;
            this.dgv_alunos.RowHeadersVisible = false;
            this.dgv_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alunos.Size = new System.Drawing.Size(346, 364);
            this.dgv_alunos.TabIndex = 0;
            this.dgv_alunos.SelectionChanged += new System.EventHandler(this.dgv_alunos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(371, 30);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(268, 20);
            this.tb_nome.TabIndex = 3;
            // 
            // msktb_telefone
            // 
            this.msktb_telefone.Location = new System.Drawing.Point(374, 88);
            this.msktb_telefone.Mask = "(99)99999-9999";
            this.msktb_telefone.Name = "msktb_telefone";
            this.msktb_telefone.Size = new System.Drawing.Size(127, 20);
            this.msktb_telefone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(507, 88);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(132, 21);
            this.cb_status.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Turmas:";
            // 
            // cb_turmas
            // 
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(374, 140);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(265, 21);
            this.cb_turmas.TabIndex = 8;
            // 
            // btn_imprimirCar
            // 
            this.btn_imprimirCar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_imprimirCar.Location = new System.Drawing.Point(374, 179);
            this.btn_imprimirCar.Name = "btn_imprimirCar";
            this.btn_imprimirCar.Size = new System.Drawing.Size(265, 23);
            this.btn_imprimirCar.TabIndex = 9;
            this.btn_imprimirCar.Text = "Imprimir Carteirinha";
            this.btn_imprimirCar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Clique Duplo para alterar a Foto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_financeiro);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 53);
            this.panel1.TabIndex = 12;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_fechar.Location = new System.Drawing.Point(493, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(154, 38);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_financeiro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_financeiro.Location = new System.Drawing.Point(333, 3);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(154, 38);
            this.btn_financeiro.TabIndex = 2;
            this.btn_financeiro.Text = "Financeiro";
            this.btn_financeiro.UseVisualStyleBackColor = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Brown;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_excluir.Location = new System.Drawing.Point(173, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(154, 38);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "Excluir Aluno";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_salvar.Location = new System.Drawing.Point(13, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(154, 38);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar Edições";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // pb_alterarfoto
            // 
            this.pb_alterarfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_alterarfoto.Location = new System.Drawing.Point(374, 208);
            this.pb_alterarfoto.Name = "pb_alterarfoto";
            this.pb_alterarfoto.Size = new System.Drawing.Size(85, 113);
            this.pb_alterarfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_alterarfoto.TabIndex = 11;
            this.pb_alterarfoto.TabStop = false;
            // 
            // Frm_GAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 455);
            this.Controls.Add(this.pb_alterarfoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_imprimirCar);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msktb_telefone);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_alunos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_GAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_GAlunos";
            this.Load += new System.EventHandler(this.Frm_GAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_alterarfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.MaskedTextBox msktb_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_turmas;
        private System.Windows.Forms.Button btn_imprimirCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.PictureBox pb_alterarfoto;
    }
}