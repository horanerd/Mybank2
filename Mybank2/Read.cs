using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Data;

namespace mybank2
{
    class Read
    {

       

        OracleCommand cmd = new OracleCommand();
        public bool tem = false;
        Conexao ora = new Conexao();
        OracleDataReader dr;
        string mensagem = "";
        


        public  Read(string Tabela)
        
        {
            this.ExeRead(Tabela);
            
            
        }

        private object ExeRead(string Tabela, string Dados = null) {

            

            cmd.CommandText = "SELECT * FROM " + Tabela + "" + Dados +"";
           

            cmd.Connection = ora.Conectar();
            cmd.ExecuteNonQuery();

            string teste = "retorno";

            return teste;

            try
            {
                cmd.Connection = ora.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }

            }
            catch (OracleException)
            {

                this.mensagem = "Erro com banco de dados!";
            }
            return tem;
        }
        
    }



    }

