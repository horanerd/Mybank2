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
    class Cadastrofuncionarios
    {
        Conexao conexao = new Conexao();
        OracleCommand cmd = new OracleCommand();
        public String mensagem = "";
         
        

        public Cadastrofuncionarios(String nome, String cpf, String rg, String nome_mae, String data_nascimento, String cnh, String logradouro, String numero,
            String complemento, String cep, String bairro, String cidade, String estado, String email, String titulo_eleitor, String salario, String cargo, String reservista, String data_emisssao)
        {
           
            

            try
            {

                //Comando sql
                cmd.CommandText = "INSERT INTO FUNCIONARIO_MYBANK (MATRICULA,  NOME, CPF, RG, NOME_MAE, DATA_NASCIMENTO, CNH, LOGRADOURO, NUMERO, COMPLEMENTO, CEP, BAIRRO, CIDADE, ESTADO, E_MAIL, TITULO_ELEITOR, SALARIO, CARGO, RESERVISTA) " +
                    "VALUES (2, '" + nome + "' , '" + cpf + "', '" + rg + "', '" + nome_mae + "', '" + data_nascimento + "', '" + cnh  + "',  '" + logradouro + "', '" + numero + "'," +
                    " '" + complemento + "', '" + cep + "', '" + bairro + "', '" + cidade + "', '" + estado + "', '" + email + "', '" + titulo_eleitor + "', '" + salario + "', '" + cargo + "', '" + reservista + "' )";

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
