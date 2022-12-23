using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SISCONTROLE.DAO
{
    class Conexao
    {
        string Banco {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projetos\... \SISCONTROLE\SISCONTROLE\dbcontrole.mdf;Integrated Security=True";
            }
        }

        public SqlConnection sqlConexao()
        {
            return new SqlConnection(Banco);
        }
    }
}
