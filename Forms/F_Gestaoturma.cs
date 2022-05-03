using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace estudocsharp
{
    public partial class F_Gestaoturma : Form
    {
        string idSelecionado;
        int modo = 0; // 0 = Padrão, 1 = Edição, 2 = Inserção
        string vqueryDGV;
        public F_Gestaoturma()
        {
            InitializeComponent();
        }

        private void F_Gestaoturma_Load(object sender, EventArgs e)
        {
                vqueryDGV = @"
                SELECT
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'turmas',
                    tbh.T_DSCHORARIO as 'Horario'
                FROM
                    t_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
                ";

            Dgv_turma.DataSource = Banco.dql(vqueryDGV);
            Dgv_turma.Columns[0].Width = 40;
            Dgv_turma.Columns[1].Width = 250;
            Dgv_turma.Columns[2].Width = 85;

            // Popular CombBox Professores

            string vqueryProfessores = @"
                SELECT
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    N_IDPROFESSOR
           ";

            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";


            // Popular CmBox Status (Ativa=A, Paralisada=P, Cancelada=C)
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            //Popular ComBox Horarios
            string vqueryHorarios = @"
                SELECT
                   *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
           ";

            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.dql(vqueryHorarios);
            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";

        }
        

        private void Dgv_turma_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                idSelecionado = Dgv_turma.Rows[Dgv_turma.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"
                        SELECT
                            T_DSCTURMA,
                            N_IDPROFESSOR,
                            N_IDHORARIO,
                            N_MAXALUNOS,
                            T_STATUS
                        FROM
                            t_turmas
                        WHERE
                            N_IDTURMA=" + idSelecionado;

                DataTable dt = Banco.dql(vqueryCampos);
                tb_nometurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                nud_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");

                tb_vagas.Text = Calc_vagas();
              
            }
        }

       

        private void Btn_novaturma_Click(object sender, EventArgs e)
        {
            tb_nometurma.Clear();
            cb_professor.SelectedIndex = -1;
            nud_maxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horario.SelectedIndex = -1;
            tb_nometurma.Focus();
            modo = 2;
            tb_vagas.Clear();
        }

        private void Btn_salvaredicoes_Click(object sender, EventArgs e)
        {
            if(modo != 0) {
                string msg = "";
                string queryTurma="  ";
                if(modo == 1)
                {
                msg = "Turma Alterada!";
                queryTurma = string.Format(@"
                UPDATE
                    t_turmas
                SET
                    T_DSCTURMA='{0}',
                    N_IDPROFESSOR={1},
                    N_IDHORARIO={2},
                    N_MAXALUNOS={3},
                    T_STATUS='{4}'
                WHERE
                    N_IDTURMA={5}", tb_nometurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(nud_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado);
                }
                else
                {
                    msg = "Nova Turma Inserida!";
                    queryTurma = string.Format(@"
                    INSERT INTO
                        t_turmas
                    (T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS)
                    VALUES ('{0}',{1},{2},{3},'{4}')", tb_nometurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(nud_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue);
                    
                }

                    int linha = Dgv_turma.SelectedRows[0].Index;
                    Banco.dml(queryTurma);
                    if(modo == 1)
                    {
                        Dgv_turma[1, linha].Value = tb_nometurma.Text;
                        Dgv_turma[2, linha].Value = cb_horario.Text;
                        tb_vagas.Text = Calc_vagas(); 
                    } 
                    else
                    {
                        Dgv_turma.DataSource = Banco.dql(vqueryDGV);
                    }
                    
                       
                        

                MessageBox.Show(msg);
                
            }
            
        }

        private string Calc_vagas()
        {
            // Cálculo de Vagas
            string queryVagas = string.Format(@"
                    SELECT
                        count(N_IDALUNO) as 'contVagas'
                    FROM
                        tb_alunos
                    WHERE
                        T_STATUS='A' and N_IDTURMA={0}", idSelecionado);
            DataTable dt = Banco.dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(nud_maxAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            return vagas.ToString();
        }

        private void Btn_excluirturma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryExcluirTurma = string.Format(@"
                    DELETE
                    FROM
                        t_turmas
                    WHERE
                       N_IDTURMA={0}", idSelecionado);
                Banco.dml(queryExcluirTurma);
                Dgv_turma.Rows.Remove(Dgv_turma.CurrentRow);
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(modo == 0)
            {
                modo = 1;
            }
          
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void tb_nometurma_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void nud_maxAlunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }

        }

        private void btn_imprimirturma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatório de turmas\n\n");

            PdfPTable tabela = new PdfPTable(3);
            tabela.DefaultCell.FixedHeight = 20;

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            DataTable dtTurmas = Banco.dql(vqueryDGV);
            for(int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("turmas"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horario"));
            }

            doc.Open();
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o relatório?", "Relatório", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }
        }
    }
}
