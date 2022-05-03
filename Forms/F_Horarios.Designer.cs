namespace estudocsharp
{
    partial class F_Horarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idHorario = new System.Windows.Forms.TextBox();
            this.mscb_dscHorario = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Horarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário";
            // 
            // tb_idHorario
            // 
            this.tb_idHorario.Location = new System.Drawing.Point(25, 31);
            this.tb_idHorario.Name = "tb_idHorario";
            this.tb_idHorario.ReadOnly = true;
            this.tb_idHorario.Size = new System.Drawing.Size(73, 20);
            this.tb_idHorario.TabIndex = 2;
            this.tb_idHorario.TabStop = false;
            // 
            // mscb_dscHorario
            // 
            this.mscb_dscHorario.Location = new System.Drawing.Point(25, 81);
            this.mscb_dscHorario.Mask = "99:99 às 99:99";
            this.mscb_dscHorario.Name = "mscb_dscHorario";
            this.mscb_dscHorario.Size = new System.Drawing.Size(90, 20);
            this.mscb_dscHorario.TabIndex = 3;
            // 
            // dgv_Horarios
            // 
            this.dgv_Horarios.AllowUserToAddRows = false;
            this.dgv_Horarios.AllowUserToDeleteRows = false;
            this.dgv_Horarios.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Horarios.EnableHeadersVisualStyles = false;
            this.dgv_Horarios.Location = new System.Drawing.Point(212, 10);
            this.dgv_Horarios.MultiSelect = false;
            this.dgv_Horarios.Name = "dgv_Horarios";
            this.dgv_Horarios.ReadOnly = true;
            this.dgv_Horarios.RowHeadersVisible = false;
            this.dgv_Horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Horarios.Size = new System.Drawing.Size(272, 264);
            this.dgv_Horarios.TabIndex = 4;
            this.dgv_Horarios.SelectionChanged += new System.EventHandler(this.Dgv_Horarios_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 38);
            this.panel1.TabIndex = 5;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_fechar.Location = new System.Drawing.Point(374, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(110, 32);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Brown;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_excluir.Location = new System.Drawing.Point(247, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(112, 32);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir Horário";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_salvar.Location = new System.Drawing.Point(132, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(99, 32);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar Horário";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_novo.Location = new System.Drawing.Point(10, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(105, 32);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo Horário";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::estudocsharp.Properties.Resources.mudancas_de_horario;
            this.pictureBox1.Location = new System.Drawing.Point(25, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Horarios);
            this.Controls.Add(this.mscb_dscHorario);
            this.Controls.Add(this.tb_idHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idHorario;
        private System.Windows.Forms.MaskedTextBox mscb_dscHorario;
        private System.Windows.Forms.DataGridView dgv_Horarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}