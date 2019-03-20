using FirebirdSql.Data.FirebirdClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ETL_DaDo_Bier.Codigos.Base
{

    //Strings de conexão com o banco

    public static class ConexaoFirebird_Telefonia
    {
        private static string connectionString = @"User=sysdba;Password=masterkey;Database=192.168.1.251:c:\Program Files (x86)\Leucotron Telecom\Banco de Dados\taritronregistros.fdb; Dialect = 3;";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }

    public static class ConexaoSQL_Telefonia
    {
        private static string connectionString = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=DADOBIER_TELEFONIA;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }

    public static class ConexaoSQL_Testes
    {
        private static string connectionString = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=TESTES;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }

    public static class ConexaoSQL_Ferramentas
    {
        private static string connectionString = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=FERRAMENTAS;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }

    public static class ConexaoSQL_BitBar_Cubo
    {
        private static string connectionString = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=BITBAR_CUBO;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }

    public static class ConexaoSQL_Dadobier_Etl
    {
        private static string connectionString = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=DADOBIER_ETL;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }

    public static class ConexaoOracleCigam
    {
        private static string connectionString = @"Data Source=192.168.1.206:1521/cigam;User Id=system;Password=cigam;";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }

    public static class ConexaoFirebird_BitBar_Cubo
    {
        private static string connectionString = @"User=DADOBIER;Password=DADOBIER;Database=192.168.1.250:c:\data\bitbar2\data\ibmaster.fdb; Dialect = 3;";
        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }


    //CONEXÕES QUEOPS

    public class DALDadosConexao_Queops
    {
        public static string StringConexaoQueopsCubo = Properties.Connections.Default.QueopsCubo;
        public static string StringConexaoQueopsUmuarama = @"Data Source=192.168.2.248;Initial Catalog=DadoBier_Umu;Persist Security Info=True;User ID=dado;Password=Dad01995";
        public static string StringConexaoQueopsRetaguarda = @"Data Source=192.168.1.249;Initial Catalog=master;Persist Security Info=True;User ID=dado;Password=Dad01995";
    }

    public class DALDadosConexao_QueopsETL
    {
        public static string StringConexaoQueopsCuboETL = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=QUEOPS_CUBO;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";
        public static string StringConexaoQueopsUmuaramaETL = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=QUEOPS_UMUARAMA;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";
        public static string StringConexaoQueopsRetaguardaETL = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=QUEOPS_RETAGUARDA;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";
    }

    public class DALConexaoQueops
    {
        private string _stringConexao_Queops;
        private SqlConnection _conexao_Queops;

        public DALConexaoQueops(string dadosConexao)
        {
            this._conexao_Queops = new SqlConnection();
            this.StringConexao_Queops = dadosConexao;
            this._conexao_Queops.ConnectionString = dadosConexao;

        }
        public String StringConexao_Queops
        {
            get { return this._stringConexao_Queops; }
            set { this._stringConexao_Queops = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao_Queops; }
            set { this._conexao_Queops = value; }
        }

        public void Conectar()
        {
            this._conexao_Queops.Open();
        }

        public void Desconectar()
        {
            this._conexao_Queops.Close();
        }
    }

    public class DALConexaoQueopsETL
    {
        private string _stringConexao_QueopsETL;
        private SqlConnection _conexao_QueopsETL;

        public DALConexaoQueopsETL(string dadosConexao)
        {
            this._conexao_QueopsETL = new SqlConnection();
            this.StringConexao_QueopsETL = dadosConexao;
            this._conexao_QueopsETL.ConnectionString = dadosConexao;

        }
        public String StringConexao_QueopsETL
        {
            get { return this._stringConexao_QueopsETL; }
            set { this._stringConexao_QueopsETL = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao_QueopsETL; }
            set { this._conexao_QueopsETL = value; }
        }

        public void Conectar()
        {
            this._conexao_QueopsETL.Open();
        }

        public void Desconectar()
        {
            this._conexao_QueopsETL.Close();
        }
    }


    //CONEXÃÕES BITBAR

    public class DALDadosConexao_BitBar
    {
        public static string StringConexaoBitBarCubo = @"User=DADOBIER;Password=DADOBIER;Database=192.168.1.250:c:\data\bitbar2\data\ibmaster.fdb; Dialect = 3;";
        public static string StringConexaoBitBarArqMortoCubo = @"User=DADOBIER;Password=DADOBIER;Database=192.168.1.250:c:\data\bitbar2\data\ARQMORTO_2017_12.fdb; Dialect = 3;";

        public static string StringConexaoBitBarUmuarama = @"User=DADOBIER;Password=DADOBIER;Database=192.168.2.99:c:\data\bitbar2\data\IBMASTER.fdb; Dialect = 3;";
        public static string StringConexaoBitBarArqMortoUmuarama = @";";

    }

    public class DALDadosConexao_BitBarSQL
    {
        public static string StringConexaoBitBarSQLProducaoCubo = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=BITBAR_CUBO;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";

        public static string StringConexaoBitBarSQLBackupCubo = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=BITBAR_CUBO_ARQ_MORTO;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";

        public static string StringConexaoBitBarSQLProducaoUmuarama = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=BITBAR_UMUARAMA;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";

        public static string StringConexaoBitBarSQLBackupUmuarama = @"Data Source=DB-WS024\DADOBIER_BI;Initial Catalog=BITBAR_UMUARAMA_ARQ_MORTO;Persist Security Info=True;User ID=sa;Password=@1q2w3e4r";
    }


    // Classes abstratas onde executa a conexão no banco

    public abstract class DALConexaoFireBirdFones
    {
        // CONECTA NO BANCO        
        public static string conn = ConexaoFirebird_Telefonia.ConnectionString;
        public FbConnection myConnection = new FbConnection(conn);
    }

    public abstract class DALConexaoSQLFones
    {
        // CONECTA NO BANCO 
        public static string conn = ConexaoSQL_Telefonia.ConnectionString;
        public SqlConnection myConnection = new SqlConnection(conn);
    }

    public abstract class DALConexaoFirebirdBitBar
    {
        // CONECTA NO BANCO 
        public static string conn = ConexaoFirebird_BitBar_Cubo.ConnectionString;
        public FbConnection myConnection = new FbConnection(conn);
    }

    public abstract class DALConexaoSQLBitBar_Cubo
    {
        // CONECTA NO BANCO 
        public static string conn = ConexaoSQL_BitBar_Cubo.ConnectionString;
        public SqlConnection myConnection = new SqlConnection(conn);
    }

    public abstract class DALConexaoSql_Dadobier_Etl
    {
        // CONECTA NO BANCO 
        public static string conn = ConexaoSQL_Dadobier_Etl.ConnectionString;
        public SqlConnection myConnection = new SqlConnection(conn);
    }

    public abstract class DALConexaoSql_Testes
    {
        // CONECTA NO BANCO 
        public static string conn = ConexaoSQL_Testes.ConnectionString;
        public SqlConnection myConnection = new SqlConnection(conn);
    }

    public abstract class DALConexaoSql_Ferramentas
    {
        // CONECTA NO BANCO 
        public static string conn = ConexaoSQL_Ferramentas.ConnectionString;
        public SqlConnection myConnection = new SqlConnection(conn);
    }

    public abstract class DALConexaoOracleCigam
    {
        // CONECTA NO BANCO 
        public static string conn = ConexaoOracleCigam.ConnectionString;
        public OracleConnection myConnection = new OracleConnection(conn);
    }

    class DBConnection
    {
    }
}
