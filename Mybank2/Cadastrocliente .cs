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
    class Cadastrocliente
    {
        Conexao conexao = new Conexao();
        OracleCommand cmd = new OracleCommand();
        public String mensagem = "";
         
        

        public Cadastrocliente(String nome, String cpf, String rg, String data_nascimento, String estado_civil, String logradouro, String numero,
            String complemento, String cep, String bairro, String cidade, String estado, String email, String titulo_eleitor, String salario, String celular, String telefone)
        {
           
            

            try
            {

                //Comando sql
                cmd.CommandText = "INSERT INTO CLIENTE_MYBANK (COD_CLIENTE,  CLIENTE_NOME, CLIENTE_CPF, CLIENTE_RG,  DATA_NASCIMENTO, ESTADO_CIVIL,  LOGRADOURO, NUMERO, COMPLEMENTO, CEP, BAIRRO, CIDADE, ESTADO, E_MAIL, TITULO_ELEITOR, RENDA, CELULAR,  TELEFONE) " +
                    "VALUES (2, '" + nome + "' , '" + cpf + "', '" + rg + "','" + data_nascimento + "','" + estado_civil + "',  '" + logradouro + "', '" + numero + "'," +
                    " '" + complemento + "', '" + cep + "', '" + bairro + "', '" + cidade + "', '" + estado + "', '" + email + "', '" + titulo_eleitor + "', '" + salario + "', '" + celular + "', '" + telefone + "' )";

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
