using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudocsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {

                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ACESSO NÃO PERMITIDO!");
                }
            }

            else
            {
                MessageBox.Show("É NECESSÁRIO TER UM USÚARIO LOGADO");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void LogoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void BancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abreForm();
        }

        private void NovoUsúarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            abreForm(1, f_NovoUsuario);
        }

        private void GestãoDeUsúariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
            abreForm(1, f_GestaoUsuarios);
            
        }

        private void NovoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno frmAluno = new FrmAluno();
            abreForm(1, frmAluno);
        }

       

        private void HoráriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            F_Horarios f_Horarios = new F_Horarios();
            abreForm(1, f_Horarios);
        }

        private void ProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            abreForm(3, f_GestaoProfessores);
        }

        private void TurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Gestaoturma f_Gestaoturma = new F_Gestaoturma();
            abreForm(3, f_Gestaoturma);
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GAlunos frm_GAlunos = new Frm_GAlunos();
            abreForm(1, frm_GAlunos);
        }

        private void btn_gestao_Click(object sender, EventArgs e)
        {
            Frm_GAlunos frm_GAlunos = new Frm_GAlunos();
            abreForm(1, frm_GAlunos);
        }

        private void btn_novoA_Click(object sender, EventArgs e)
        {
            FrmAluno frmAluno = new FrmAluno();
            abreForm(1, frmAluno);
        }

        private void btn_turmas_Click(object sender, EventArgs e)
        {
            F_Gestaoturma f_Gestaoturma = new F_Gestaoturma();
            abreForm(3, f_Gestaoturma);
        }

        private void btn_horarios_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            abreForm(1, f_Horarios);
        }
    }
}
