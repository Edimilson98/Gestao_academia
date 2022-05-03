namespace estudocsharp
{
    partial class F_Gestaoturma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_turma = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_imprimirturma = new System.Windows.Forms.Button();
            this.btn_excluirturma = new System.Windows.Forms.Button();
            this.btn_salvaredicoes = new System.Windows.Forms.Button();
            this.btn_novaturma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.nud_maxAlunos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nometurma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_turma)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_turma
            // 
            this.Dgv_turma.AllowUserToAddRows = false;
            this.Dgv_turma.AllowUserToDeleteRows = false;
            this.Dgv_turma.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_turma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_turma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_turma.EnableHeadersVisualStyles = false;
            this.Dgv_turma.Location = new System.Drawing.Point(12, 12);
            this.Dgv_turma.MultiSelect = false;
            this.Dgv_turma.Name = "Dgv_turma";
            this.Dgv_turma.ReadOnly = true;
            this.Dgv_turma.RowHeadersVisible = false;
            this.Dgv_turma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_turma.Size = new System.Drawing.Size(402, 450);
            this.Dgv_turma.TabIndex = 7;
            this.Dgv_turma.SelectionChanged += new System.EventHandler(this.Dgv_turma_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_imprimirturma);
            this.panel1.Controls.Add(this.btn_excluirturma);
            this.panel1.Controls.Add(this.btn_salvaredicoes);
            this.panel1.Controls.Add(this.btn_novaturma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 53);
            this.panel1.TabIndex = 8;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_fechar.Location = new System.Drawing.Point(591, 5);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(116, 36);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // btn_imprimirturma
            // 
            this.btn_imprimirturma.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_imprimirturma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_imprimirturma.Location = new System.Drawing.Point(440, 3);
            this.btn_imprimirturma.Name = "btn_imprimirturma";
            this.btn_imprimirturma.Size = new System.Drawing.Size(129, 38);
            this.btn_imprimirturma.TabIndex = 3;
            this.btn_imprimirturma.Text = "Imprimir Turma";
            this.btn_imprimirturma.UseVisualStyleBackColor = false;
            this.btn_imprimirturma.Click += new System.EventHandler(this.btn_imprimirturma_Click);
            // 
            // btn_excluirturma
            // 
            this.btn_excluirturma.BackColor = System.Drawing.Color.Brown;
            this.btn_excluirturma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_excluirturma.Location = new System.Drawing.Point(290, 3);
            this.btn_excluirturma.Name = "btn_excluirturma";
            this.btn_excluirturma.Size = new System.Drawing.Size(144, 38);
            this.btn_excluirturma.TabIndex = 2;
            this.btn_excluirturma.Text = "Excluir Turma";
            this.btn_excluirturma.UseVisualStyleBackColor = false;
            this.btn_excluirturma.Click += new System.EventHandler(this.Btn_excluirturma_Click);
            // 
            // btn_salvaredicoes
            // 
            this.btn_salvaredicoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_salvaredicoes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_salvaredicoes.Location = new System.Drawing.Point(152, 3);
            this.btn_salvaredicoes.Name = "btn_salvaredicoes";
            this.btn_salvaredicoes.Size = new System.Drawing.Size(132, 38);
            this.btn_salvaredicoes.TabIndex = 1;
            this.btn_salvaredicoes.Text = "Salvar Edições";
            this.btn_salvaredicoes.UseVisualStyleBackColor = false;
            this.btn_salvaredicoes.Click += new System.EventHandler(this.Btn_salvaredicoes_Click);
            // 
            // btn_novaturma
            // 
            this.btn_novaturma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_novaturma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_novaturma.Location = new System.Drawing.Point(12, 3);
            this.btn_novaturma.Name = "btn_novaturma";
            this.btn_novaturma.Size = new System.Drawing.Size(134, 38);
            this.btn_novaturma.TabIndex = 0;
            this.btn_novaturma.Text = "Nova Turma";
            this.btn_novaturma.UseVisualStyleBackColor = false;
            this.btn_novaturma.Click += new System.EventHandler(this.Btn_novaturma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Máximo Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Horário";
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(420, 95);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(269, 21);
            this.cb_professor.TabIndex = 2;
            this.cb_professor.SelectedIndexChanged += new System.EventHandler(this.cb_professor_SelectedIndexChanged);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(554, 183);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(135, 21);
            this.cb_status.TabIndex = 4;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(420, 262);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(269, 21);
            this.cb_horario.TabIndex = 5;
            this.cb_horario.SelectedIndexChanged += new System.EventHandler(this.cb_horario_SelectedIndexChanged);
            // 
            // nud_maxAlunos
            // 
            this.nud_maxAlunos.Location = new System.Drawing.Point(420, 183);
            this.nud_maxAlunos.Name = "nud_maxAlunos";
            this.nud_maxAlunos.Size = new System.Drawing.Size(128, 20);
            this.nud_maxAlunos.TabIndex = 3;
            this.nud_maxAlunos.ValueChanged += new System.EventHandler(this.nud_maxAlunos_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nome Turma";
            // 
            // tb_nometurma
            // 
            this.tb_nometurma.Location = new System.Drawing.Point(420, 29);
            this.tb_nometurma.Name = "tb_nometurma";
            this.tb_nometurma.Size = new System.Drawing.Size(269, 20);
            this.tb_nometurma.TabIndex = 1;
            this.tb_nometurma.TextChanged += new System.EventHandler(this.tb_nometurma_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vagas";
            // 
            // tb_vagas
            // 
            this.tb_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_vagas.Enabled = false;
            this.tb_vagas.Location = new System.Drawing.Point(420, 326);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.Size = new System.Drawing.Size(100, 20);
            this.tb_vagas.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::estudocsharp.Properties.Resources.equipe;
            this.pictureBox1.Location = new System.Drawing.Point(554, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // F_Gestaoturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 521);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_nometurma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_maxAlunos);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_turma);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Gestaoturma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turma";
            this.Load += new System.EventHandler(this.F_Gestaoturma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_turma)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_turma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_imprimirturma;
        private System.Windows.Forms.Button btn_excluirturma;
        private System.Windows.Forms.Button btn_salvaredicoes;
        private System.Windows.Forms.Button btn_novaturma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.NumericUpDown nud_maxAlunos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nometurma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vagas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}