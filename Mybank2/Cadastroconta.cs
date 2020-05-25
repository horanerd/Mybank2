using mybank2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Microsoft.SqlServer.Server;
using Oracle.DataAccess.Types;
using System.Security.Cryptography;

namespace Mybank2
{
    class Cadastroconta
    {
        Conexao conexao = new Conexao();
        OracleCommand cmd = new OracleCommand();
        public String mensagem = "";
         
        

        public Cadastroconta(String cod_conta, String num_agencia, String transferencia, String data_emicao)
        {
           
            

            try
            {

                //Comando sql
                cmd.CommandText = "INSERT INTO CONTA_CORRENTE_MYBANK (COD_CLIENTE,  COD_CONTA, NUM_AGENCIA, TRANSFERENCIA, DATA_EMICAO) " +
                    "VALUES (2, " + cod_conta + "', '" + num_agencia + "', '" + transferencia + "', '" + data_emicao + "' )";

                //Conectar com banco
                cmd.Connection = conexao.Conectar();
                //Execução do comando
                cmd.ExecuteNonQuery();
                //desconctar 
                conexao.Desconectar();
                //Mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso";
            }
            catch (OracleException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de Dados " + e;
            }
            
           
        }
    }
}
