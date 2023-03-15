using System;
using MySql.Data.MySqlClient;
using System.Data;


namespace ProjetoAgendaContatos
{
    class Cl_Login
    {
        cl_Conexao c = new cl_Conexao();

        public bool Logar(string l, string s)
        {
            try
            {
                string sql = "select login , senha from tblogin where login like '" + l + "' and senha like '" + s + "' ;";
                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                c.conectar();
                MySqlDataReader objDados = cmd.ExecuteReader();
                // leitura no banco
                if (!objDados.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch (MySqlException e)
            {
                throw (e);
            }

            finally
            {
                c.desconectar();
            }
        }
    }
}

