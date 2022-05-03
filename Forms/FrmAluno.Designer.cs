namespace estudocsharp
{
    partial class FrmAluno
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.msktb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(13, 30);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(291, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // msktb_telefone
            // 
            this.msktb_telefone.Enabled = false;
            this.msktb_telefone.Location = new System.Drawing.Point(321, 30);
            this.msktb_telefone.Mask = "(99)99999-9999";
            this.msktb_telefone.Name = "msktb_telefone";
            this.msktb_telefone.Size = new System.Drawing.Size(106, 20);
            this.msktb_telefone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(16, 84);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turma:";
            // 
            // tb_turma
            // 
            this.tb_turma.Enabled = false;
            this.tb_turma.Location = new System.Drawing.Point(178, 84);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(192, 20);
            this.tb_turma.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_gravar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 55);
            this.panel1.TabIndex = 9;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_fechar.Location = new System.Drawing.Point(469, 6);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(93, 37);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Brown;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancelar.Location = new System.Drawing.Point(211, 6);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(93, 37);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_gravar.Enabled = false;
            this.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_gravar.Location = new System.Drawing.Point(112, 6);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(93, 37);
            this.btn_gravar.TabIndex = 1;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = false;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_novo.Location = new System.Drawing.Point(13, 6);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(93, 37);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Add.Location = new System.Drawing.Point(477, 8);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(85, 23);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add Foto";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(477, 36);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(85, 113);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 10;
            this.pb_foto.TabStop = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::estudocsharp.Properties.Resources.lupa_de_pesquisa;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Enabled = false;
            this.btn_buscar.Image = global::estudocsharp.Properties.Resources.lupa_de_pesquisa;
            this.btn_buscar.Location = new System.Drawing.Point(367, 84);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(30, 21);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 226);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msktb_telefone);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.FrmAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.MaskedTextBox msktb_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_novo;
        public System.Windows.Forms.TextBox tb_turma;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Add;
    }
}