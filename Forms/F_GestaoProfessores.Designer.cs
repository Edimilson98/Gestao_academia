namespace estudocsharp
{
    partial class F_GestaoProfessores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_professor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_professores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.msktb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(9, 32);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(66, 20);
            this.tb_id.TabIndex = 2;
            // 
            // tb_professor
            // 
            this.tb_professor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_professor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_professor.Location = new System.Drawing.Point(9, 78);
            this.tb_professor.Name = "tb_professor";
            this.tb_professor.Size = new System.Drawing.Size(192, 20);
            this.tb_professor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // dgv_professores
            // 
            this.dgv_professores.AllowUserToAddRows = false;
            this.dgv_professores.AllowUserToDeleteRows = false;
            this.dgv_professores.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professores.EnableHeadersVisualStyles = false;
            this.dgv_professores.Location = new System.Drawing.Point(207, 12);
            this.dgv_professores.MultiSelect = false;
            this.dgv_professores.Name = "dgv_professores";
            this.dgv_professores.ReadOnly = true;
            this.dgv_professores.RowHeadersVisible = false;
            this.dgv_professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professores.Size = new System.Drawing.Size(324, 269);
            this.dgv_professores.TabIndex = 6;
            this.dgv_professores.SelectionChanged += new System.EventHandler(this.Dgv_professores_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 54);
            this.panel1.TabIndex = 7;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_fechar.Location = new System.Drawing.Point(414, 10);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(117, 37);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Brown;
            this.btn_excluir.Location = new System.Drawing.Point(262, 10);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(117, 37);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_salvar.Location = new System.Drawing.Point(139, 10);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(117, 37);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_novo.Location = new System.Drawing.Point(16, 10);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(117, 37);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo Professor";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // msktb_telefone
            // 
            this.msktb_telefone.Location = new System.Drawing.Point(9, 127);
            this.msktb_telefone.Mask = "(99) 99999-9999";
            this.msktb_telefone.Name = "msktb_telefone";
            this.msktb_telefone.Size = new System.Drawing.Size(148, 20);
            this.msktb_telefone.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::estudocsharp.Properties.Resources.prof;
            this.pictureBox1.Location = new System.Drawing.Point(58, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // F_GestaoProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msktb_telefone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_professores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_professor);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Professores";
            this.Load += new System.EventHandler(this.F_GestaoProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_professor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_professores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.MaskedTextBox msktb_telefone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}