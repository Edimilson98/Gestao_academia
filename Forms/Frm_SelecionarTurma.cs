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
    public partial class Frm_SelecionarTurma : Form
    {
        FrmAluno form_novoAluno;
        public Frm_SelecionarTurma(FrmAluno f)
        {
            InitializeComponent();      
            form_novoAluno = f;
        }

        private void Frm_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurma = String.Format(@"
                SELECT
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'Turmas',
                    tbh.T_DSCHORARIO as 'Horário',
                    tbp.T_NOMEPROFESSOR as 'Professor',
                    tbt.N_MAXALUNOS as 'Máx. Alunos',
                    (   SELECT
                            count(N_IDALUNO)
                        FROM
                            tb_alunos as tba
                        WHERE
                            tba.N_IDTURMA = tbt.N_IDTURMA and T_STATUS='A'
                    ) as 'Qtde. Alunos'
                FROM
                    t_turmas as tbt
                INNER JOIN
                    tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
                INNER JOIN 
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
            ");
            Dgv_SelecionarT.DataSource = Banco.dql(queryTurma);
        }

        private void Dgv_SelecionarT_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qtdeAluno = 0;
            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdeAluno = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
            if(qtdeAluno >= maxAlunos)
            {
                MessageBox.Show("Não há Vagas nesta Turma");
            }
            else
            {
                form_novoAluno.tb_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                form_novoAluno.tb_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
