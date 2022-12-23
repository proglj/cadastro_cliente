using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SISCONTROLE.DAO
{
    class Cliente
    {
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        private SqlConnection Cnx { get; set; }

        public Cliente()
        {
          Cnx = new DAO.Conexao().sqlConexao();
          Cnx.Open();
        }

        public Cliente(string _codigo)
        {
            var cnx = new DAO.Conexao().sqlConexao();
            var adp = new SqlDataAdapter("SELECT Codigo,Nome,Endereco,Cep,Cidade,Estado,Telefone,Celular,Email FROM CLIENTE WHERE Codigo="+_codigo, cnx);
            var dst = new DataSet();
            adp.Fill(dst);

            Codigo = int.Parse(dst.Tables[0].Rows[0]["Codigo"].ToString());
            Nome = dst.Tables[0].Rows[0]["Nome"].ToString();
            Endereco = dst.Tables[0].Rows[0]["Endereco"].ToString();
            Cep = dst.Tables[0].Rows[0]["Cep"].ToString();
            Cidade = dst.Tables[0].Rows[0]["Cidade"].ToString();
            Estado = dst.Tables[0].Rows[0]["Estado"].ToString();
            Telefone = dst.Tables[0].Rows[0]["Telefone"].ToString();
            Celular = dst.Tables[0].Rows[0]["Celular"].ToString();
            Email = dst.Tables[0].Rows[0]["Email"].ToString();
            
        }

        public DataTable Listar()
        {
            var adp = new SqlDataAdapter("SELECT Codigo,Nome,Endereco,Cep,Cidade,Estado,Telefone,Celular,Email FROM CLIENTE", Cnx);
            var dst = new DataSet();
            adp.Fill(dst);
            return dst.Tables[0];
        }

        public DataTable Buscar(string nome)
        {
            var adp = new SqlDataAdapter("SELECT Codigo,Nome,Endereco,Cep,Cidade,Estado,Telefone,Celular,Email FROM CLIENTE WHERE NOME LIKE '%"+ nome +"%'", Cnx);
            var dst = new DataSet();
            adp.Fill(dst);
            return dst.Tables[0];
        }

        public string Incluir()
        {
            try
            {
                var cmd = new SqlCommand("INSERT INTO CLIENTE(NOME,ENDERECO,CEP,CIDADE,ESTADO,TELEFONE,CELULAR,EMAIL) VALUES(@NOME,@ENDERECO,@CEP,@CIDADE,@ESTADO,@TELEFONE,@CELULAR,@EMAIL)", Cnx);
                cmd.Parameters.AddWithValue("NOME", Nome);
                cmd.Parameters.AddWithValue("ENDERECO", Endereco);
                cmd.Parameters.AddWithValue("CEP", Cep);
                cmd.Parameters.AddWithValue("CIDADE", Cidade);
                cmd.Parameters.AddWithValue("ESTADO", Estado);
                cmd.Parameters.AddWithValue("TELEFONE", Telefone);
                cmd.Parameters.AddWithValue("CELULAR", Celular);
                cmd.Parameters.AddWithValue("EMAIL", Email);
                
                cmd.BeginExecuteNonQuery();
                return "Cliente gravado com sucesso.";
            }
            catch (Exception erx)
            {
                return "Erro ao tentar gravar, "+erx.Message;
            }
            finally
            {
            }
        }

        public string Alterar()
        {
            try
            {
                var cmd = new SqlCommand("UPDATE CLIENTE SET NOME=@NOME,ENDERECO=@ENDERECO,CEP=@CEP,CIDADE=@CIDADE,ESTADO=@ESTADO,TELEFONE=@TELEFONE,CELULAR=@CELULAR,EMAIL=@EMAIL WHERE CODIGO=@CODIGO", Cnx);
                cmd.Parameters.AddWithValue("CODIGO", Codigo);
                cmd.Parameters.AddWithValue("NOME", Nome);
                cmd.Parameters.AddWithValue("ENDERECO", Endereco);
                cmd.Parameters.AddWithValue("CEP", Cep);
                cmd.Parameters.AddWithValue("CIDADE", Cidade);
                cmd.Parameters.AddWithValue("ESTADO", Estado);
                cmd.Parameters.AddWithValue("TELEFONE", Telefone);
                cmd.Parameters.AddWithValue("CELULAR", Celular);
                cmd.Parameters.AddWithValue("EMAIL", Email);

                cmd.BeginExecuteNonQuery();
                return "Cliente alterado com sucesso.";
            }
            catch (Exception erx)
            {
                return "Erro ao tentar gravar, " + erx.Message;
            }
            finally
            {
            }
        }

        public string Excluir(string _codigo)
        {
            try
            {
                var cmd = new SqlCommand("DELETE FROM CLIENTE WHERE CODIGO=@COD", Cnx);
                cmd.Parameters.AddWithValue("COD", _codigo);
                cmd.BeginExecuteNonQuery();
                return "Cliente excluído.";
            }
            catch (Exception erx)
            {
                return "Erro ao tentar gravar, " + erx.Message;
            }
        }

    }
}
