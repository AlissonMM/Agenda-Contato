﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjetoAgendaContatos
{
    class cl_ControleContato
    {
        cl_Conexao c = new cl_Conexao();
        public string cadastrar(cl_Contato cont)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into tbcontato (codcontato, nome, telefone, celular, email)" +
                "values('" + cont.Codcontato + "','" + cont.Nome + "','" + cont.Telefone + "','" +
                cont.Celular + "','" + cont.Email + "')", c.con);
                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Cadastro realizado com sucesso");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }


        }

        public string excluir(cl_Contato cont)
        {
            try
            {
                MySqlCommand exc = new MySqlCommand("delete from tbcontato where codcontato =" + cont.Codcontato + ";", c.con);
                c.conectar();
                exc.ExecuteNonQuery();
                c.desconectar();
                return ("Cadastro excluído com sucesso");
            }
            catch (MySqlException a)
            {
                return (a.ToString());
            }
        }

        public string Alterar(cl_Contato cont)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update tbcontato set nome = '" + cont.Nome + "' , telefone = '" + cont.Telefone + "' , celular = '" + cont.Celular + "' , email = '" + cont.Email + "' where codcontato = '" + cont.Codcontato + "';", c.con);
                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Dados alterados com sucesso!");

            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public cl_Contato buscar(int codigo)
        {
            cl_Contato cont = new cl_Contato();
            try
            {
                string sql = "Select * from tbcontato where codcontato=" + codigo + ";";
                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                c.conectar();

                MySqlDataReader objDados = cmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    return null;
                }
                else
                {
                    objDados.Read();

                    cont.Codcontato = Convert.ToInt32(objDados["codcontato"]);
                    cont.Nome = objDados["nome"].ToString();
                    cont.Telefone = objDados["telefone"].ToString();
                    cont.Celular = objDados["celular"].ToString();
                    cont.Email = objDados["email"].ToString();

                    objDados.Close();
                    return cont;

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

        public DataTable PreencherTodos()
        {
            string sql = "select codcontato as 'Código', nome as Nome, telefone as Telefone, " + "celular as Celular, email as Email from tbcontato ; ";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaCodigo(int codigo)
        {
            string sql = "select codcontato as 'Código', nome as Nome, telefone as Telefone, " + "celular as Celular, email as Email from tbcontato where codcontato = " + codigo + " ; ";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisanome(string nomecontato)
        {
            string sql = "select codcontato as 'Código', nome as Nome, telefone as Telefone, " + "celular as Celular, email as Email from tbcontato where nome like '%" + nomecontato + "%'";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisatelefone(string telefonecod)
        {
            string sql = "select codcontato as 'Código', nome as Nome, telefone as Telefone, " + "celular as Celular, email as Email from tbcontato where telefone like '%" + telefonecod + "%'";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisacelular(string cel)
        {
            string sql = "select codcontato as 'Código', nome as Nome, telefone as Telefone, " + "celular as Celular, email as Email from tbcontato where celular like '%" + cel + "%'";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaemail(string emailcod)
        {
            string sql = "select codcontato as 'Código', nome as Nome, telefone as Telefone, " + "celular as Celular, email as Email from tbcontato where email like '%" + emailcod + "%'";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public string Backup(string Caminho)
        {
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string CaminhoBackup = Caminho + "\\backupContatos_" + dataAtual + ".sql";

            try
            {
                MySqlCommand cmd = new MySqlCommand(CaminhoBackup, c.con);
                MySqlBackup mb = new MySqlBackup(cmd);
                c.conectar();
                mb.ExportToFile(CaminhoBackup);
                c.desconectar();
                return ("Backup do banco de dados realizado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string Restore(string Caminho) //Backup a MySQL database
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(Caminho, c.con);
                MySqlBackup mb = new MySqlBackup(cmd);
                c.conectar();
                mb.ImportFromFile(Caminho);
                c.desconectar();
                return ("Banco de dados restaurado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }



        }
    }





