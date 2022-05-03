namespace estudocsharp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_nomeUsuario = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_ledLogado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usúariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsúarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsúariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_gestao = new System.Windows.Forms.Button();
            this.btn_novoA = new System.Windows.Forms.Button();
            this.btn_turmas = new System.Windows.Forms.Button();
            this.btn_horarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_nomeUsuario);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_ledLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 34);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Olá";
            // 
            // lb_nomeUsuario
            // 
            this.lb_nomeUsuario.AutoSize = true;
            this.lb_nomeUsuario.Location = new System.Drawing.Point(159, 12);
            this.lb_nomeUsuario.Name = "lb_nomeUsuario";
            this.lb_nomeUsuario.Size = new System.Drawing.Size(16, 13);
            this.lb_nomeUsuario.TabIndex = 4;
            this.lb_nomeUsuario.Text = "---";
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(78, 12);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(13, 13);
            this.lb_acesso.TabIndex = 2;
            this.lb_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso";
            // 
            // pb_ledLogado
            // 
            this.pb_ledLogado.Image = global::estudocsharp.Properties.Resources.led_vermelho;
            this.pb_ledLogado.Location = new System.Drawing.Point(3, 3);
            this.pb_ledLogado.Name = "pb_ledLogado";
            this.pb_ledLogado.Size = new System.Drawing.Size(30, 27);
            this.pb_ledLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledLogado.TabIndex = 0;
            this.pb_ledLogado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.usúariosToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.logoffToolStripMenuItem});
            this.lOGINToolStripMenuItem.Image = global::estudocsharp.Properties.Resources.login3;
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logonToolStripMenuItem.Text = "Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.LogonToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.LogoffToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem,
            this.gestãoDeAlunosToolStripMenuItem});
            this.alunosToolStripMenuItem.Image = global::estudocsharp.Properties.Resources.aluno;
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.NovoAlunoToolStripMenuItem_Click);
            // 
            // gestãoDeAlunosToolStripMenuItem
            // 
            this.gestãoDeAlunosToolStripMenuItem.Name = "gestãoDeAlunosToolStripMenuItem";
            this.gestãoDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gestãoDeAlunosToolStripMenuItem.Text = "Gestão de Alunos";
            this.gestãoDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeAlunosToolStripMenuItem_Click);
            // 
            // usúariosToolStripMenuItem
            // 
            this.usúariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsúarioToolStripMenuItem,
            this.gestãoDeUsúariosToolStripMenuItem});
            this.usúariosToolStripMenuItem.Image = global::estudocsharp.Properties.Resources.login1;
            this.usúariosToolStripMenuItem.Name = "usúariosToolStripMenuItem";
            this.usúariosToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.usúariosToolStripMenuItem.Text = "Usúarios";
            // 
            // novoUsúarioToolStripMenuItem
            // 
            this.novoUsúarioToolStripMenuItem.Name = "novoUsúarioToolStripMenuItem";
            this.novoUsúarioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.novoUsúarioToolStripMenuItem.Text = "Novo Usúario";
            this.novoUsúarioToolStripMenuItem.Click += new System.EventHandler(this.NovoUsúarioToolStripMenuItem_Click);
            // 
            // gestãoDeUsúariosToolStripMenuItem
            // 
            this.gestãoDeUsúariosToolStripMenuItem.Name = "gestãoDeUsúariosToolStripMenuItem";
            this.gestãoDeUsúariosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestãoDeUsúariosToolStripMenuItem.Text = "Gestão de Usúarios";
            this.gestãoDeUsúariosToolStripMenuItem.Click += new System.EventHandler(this.GestãoDeUsúariosToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.horáriosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Image = global::estudocsharp.Properties.Resources.manutencao;
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            // 
            // horáriosToolStripMenuItem
            // 
            this.horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            this.horáriosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.horáriosToolStripMenuItem.Text = "Horários";
            this.horáriosToolStripMenuItem.Click += new System.EventHandler(this.HoráriosToolStripMenuItem_Click_1);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.ProfessoresToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.TurmasToolStripMenuItem_Click);
            // 
            // btn_gestao
            // 
            this.btn_gestao.BackColor = System.Drawing.Color.Green;
            this.btn_gestao.ForeColor = System.Drawing.Color.Black;
            this.btn_gestao.Location = new System.Drawing.Point(12, 39);
            this.btn_gestao.Name = "btn_gestao";
            this.btn_gestao.Size = new System.Drawing.Size(208, 68);
            this.btn_gestao.TabIndex = 2;
            this.btn_gestao.Text = "Gestão de Alunos";
            this.btn_gestao.UseVisualStyleBackColor = false;
            this.btn_gestao.Click += new System.EventHandler(this.btn_gestao_Click);
            // 
            // btn_novoA
            // 
            this.btn_novoA.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_novoA.Location = new System.Drawing.Point(226, 39);
            this.btn_novoA.Name = "btn_novoA";
            this.btn_novoA.Size = new System.Drawing.Size(208, 68);
            this.btn_novoA.TabIndex = 3;
            this.btn_novoA.Text = "Novo Aluno";
            this.btn_novoA.UseVisualStyleBackColor = false;
            this.btn_novoA.Click += new System.EventHandler(this.btn_novoA_Click);
            // 
            // btn_turmas
            // 
            this.btn_turmas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_turmas.Location = new System.Drawing.Point(440, 39);
            this.btn_turmas.Name = "btn_turmas";
            this.btn_turmas.Size = new System.Drawing.Size(208, 68);
            this.btn_turmas.TabIndex = 4;
            this.btn_turmas.Text = "Turmas";
            this.btn_turmas.UseVisualStyleBackColor = false;
            this.btn_turmas.Click += new System.EventHandler(this.btn_turmas_Click);
            // 
            // btn_horarios
            // 
            this.btn_horarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_horarios.Location = new System.Drawing.Point(654, 39);
            this.btn_horarios.Name = "btn_horarios";
            this.btn_horarios.Size = new System.Drawing.Size(208, 68);
            this.btn_horarios.TabIndex = 5;
            this.btn_horarios.Text = "Horários";
            this.btn_horarios.UseVisualStyleBackColor = false;
            this.btn_horarios.Click += new System.EventHandler(this.btn_horarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(867, 488);
            this.Controls.Add(this.btn_horarios);
            this.Controls.Add(this.btn_turmas);
            this.Controls.Add(this.btn_novoA);
            this.Controls.Add(this.btn_gestao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto - v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pb_ledLogado;
        public System.Windows.Forms.Label lb_nomeUsuario;
        public System.Windows.Forms.Label lb_acesso;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usúariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsúarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeUsúariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeAlunosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gestao;
        private System.Windows.Forms.Button btn_novoA;
        private System.Windows.Forms.Button btn_turmas;
        private System.Windows.Forms.Button btn_horarios;
    }
}

