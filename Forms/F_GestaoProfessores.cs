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
    public partial class F_GestaoProfessores : Form
    {
        public F_GestaoProfessores()
        {
            InitializeComponent();
        }

        private void F_GestaoProfessores_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    N_IDPROFESSOR as 'ID',
                    T_NOMEPROFESSOR as 'Professor',
                    T_TELEFONE as 'Telefone'                 
                FROM
                    tb_professores
                ORDER BY
                     N_IDPROFESSOR
            ";
            dgv_professores.DataSource = Banco.dql(vquery);
            dgv_professores.Columns[0].Width = 30;
            dgv_professores.Columns[1].Width = 170;
            dgv_professores.Columns[2].Width = 100;
        }

        private void Dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                        SELECT
                                *
                        FROM
                            tb_professores
                        WHERE
                            N_IDPROFESSOR=" + vid;
                dt = Banco.dql(vquery);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_professor.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR").ToString();
                msktb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE").ToString();
            }
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            tb_professor.Clear();
            msktb_telefone.Clear();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;

            if (tb_id.Text == "")
            {
                vquery = "INSERT INTO tb_professores (T_NOMEPROFESSOR, T_TELEFONE) VALUES ('" + tb_professor.Text + "','"+msktb_telefone.Text+"')";
            }
            else
            {
                vquery = "UPDATE tb_professores SET T_NOMEPROFESSOR='" + tb_professor.Text + "', T_TELEFONE'" + msktb_telefone.Text + "' WHERE N_IDPROFESSOR=" + tb_id.Text;
            }
            Banco.dml(vquery);

            vquery = @"
                SELECT
                    N_IDPROFESSOR as 'ID',
                    T_NOMEPROFESSOR as 'Professor',
                    T_TELEFONE as 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                     N_IDPROFESSOR  
            ";
            dgv_professores.DataSource = Banco.dql(vquery);
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_professores WHERE N_IDPROFESSOR=" + tb_id.Text;
                Banco.dml(vquery);
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
