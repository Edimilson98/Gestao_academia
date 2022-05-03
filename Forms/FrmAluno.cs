using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudocsharp
{
    public partial class FrmAluno : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativado");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            msktb_telefone.Enabled = true;
            cb_status.Enabled = true;
            tb_nome.Clear();
            msktb_telefone.Clear();
            cb_status.SelectedIndex = 0;
            tb_nome.Focus();
            tb_turma.Clear();
            btn_buscar.Enabled = true;
            btn_gravar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_novo.Enabled = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = false;
            msktb_telefone.Enabled = false;
            cb_status.Enabled = false;
            tb_nome.Clear();
            msktb_telefone.Clear();
            cb_status.SelectedIndex = 0;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_novo.Enabled = true;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if(destinoCompleto == "")
            {
                if(MessageBox.Show("Sem foto selecionada, Deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            } 
            if(destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_foto.ImageLocation = destinoCompleto;
                } 
                else
                {
                    if (MessageBox.Show("Erro ao localizar foto, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            string queryInsertAluno = string.Format(@"
             INSERT INTO tb_alunos
             (T_NOMEALUNO,T_TELEFONE,T_STATUS,N_IDTURMA, T_FOTO)
             VALUES ('{0}','{1}','{2}',{3},'{4}')",
             tb_nome.Text, msktb_telefone.Text, cb_status.SelectedValue, tb_turma.Tag.ToString(),destinoCompleto);
            Banco.dml(queryInsertAluno);
            MessageBox.Show("Novo Aluno Inserido");

            tb_nome.Enabled = false;
            msktb_telefone.Enabled = false;
            cb_status.Enabled = false;
            tb_nome.Clear();
            msktb_telefone.Clear();
            cb_status.SelectedIndex = 0;
            tb_turma.Clear();
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_novo.Enabled = true;
            pb_foto.ImageLocation = destinoCompleto;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Frm_SelecionarTurma frm_SelecionarTurma = new Frm_SelecionarTurma(this);
            frm_SelecionarTurma.ShowDialog();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
             origemCompleto = "";
             foto = "";
             pastaDestino = Globais.caminhoFotos;
             destinoCompleto = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if(File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

            }
            pb_foto.ImageLocation = origemCompleto;
           
        }
    }
}
