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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    N_IDHORARIO as 'ID',
                    T_DSCHORARIO as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                     T_DSCHORARIO
            ";
            dgv_Horarios.DataSource = Banco.dql(vquery);
            dgv_Horarios.Columns[0].Width = 80;
            dgv_Horarios.Columns[1].Width = 170;
        }

        private void Dgv_Horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                        SELECT
                                *
                        FROM
                            tb_horarios
                        WHERE
                            N_IDHORARIO="+vid;
                dt = Banco.dql(vquery);
                tb_idHorario.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mscb_dscHorario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");

            }
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            tb_idHorario.Clear();
            mscb_dscHorario.Clear();
            mscb_dscHorario.Focus();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;

            if (tb_idHorario.Text == "")
            {
                 vquery = "INSERT INTO tb_horarios (T_DSCHORARIO) VALUES ('" + mscb_dscHorario.Text + "')";
            } else
            {
                 vquery = "UPDATE tb_horarios SET T_DSCHORARIO='" + mscb_dscHorario.Text + "' WHERE N_IDHORARIO="+tb_idHorario.Text;
            }
            Banco.dml(vquery);

            vquery = @"
                SELECT
                    N_IDHORARIO as 'ID',
                    T_DSCHORARIO as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                     T_DSCHORARIO  
            ";
            dgv_Horarios.DataSource = Banco.dql(vquery);

        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horarios WHERE N_IDHORARIO="+tb_idHorario.Text;
                Banco.dml(vquery);
                dgv_Horarios.Rows.Remove(dgv_Horarios.CurrentRow);
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
