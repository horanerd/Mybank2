using mybank2;
using System;
using Oracle.DataAccess.Client;

namespace mybank2
{
    public class Conexao
    {


        Oracle.DataAccess.Client.OracleConnection ora = new Oracle.DataAccess.Client.OracleConnection();

        //Construtor
        public Conexao()
        {
            ora.ConnectionString = "DATA SOURCE = localhost; PASSWORD = 946079; USER ID = SYSTEM";
        }

        public Oracle.DataAccess.Client.OracleConnection Conectar()
        {
            if (ora.State == System.Data.ConnectionState.Closed) 
            {
                 ora.Open();

            }
            return ora;
        }
        public void Desconectar()
        {
            if (ora.State == System.Data.ConnectionState.Open) 
            {
                ora.Close();
            }
          
        }
        

    }
}
