using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace estudocsharp
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=" + Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;

        }

        public static DataTable dql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q,string msgOK=null,string msgERRO=null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

                if(msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }


            }
            catch (Exception ex)
            {
                if(msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" +ex.Message);
                }
                MessageBox.Show("Não foi possível fazer a alteração");
            }
        }



        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            } catch (Exception ex)
            {
                throw ex;
            }
        }

       

        // INICIO FUNÇOES DO FORM F_GestaoUsuarios
        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usúario',T_NOMEUSUARIO as 'Nome Usúario' FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // FIM FUNÇOES DO FORM F_GestaoUsuarios

        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO='"+u.nome+ "', T_USERNAME='" + u.username + "', T_SENHAUSUARIO='" + u.senha + "', T_STATUSUSUARIO='" + u.status + "', N_NIVELUSUARIO="+u.nivel+" WHERE N_IDUSUARIO="+u.id;   
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não Foi Possível alterar o usúario");
            }
        }

        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome,@username,@senha,@status,@nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usúario inserido com sucesso");
                vcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo Usúario");
         
            }
        }

        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='"+u.username+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }

        public static void Deletarusuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não Foi Possível alterar o usúario");
            }
        }
    }
}
