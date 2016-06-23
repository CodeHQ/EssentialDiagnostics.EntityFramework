using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using EssentialDiagnostics.EntityFramework.Properties;

namespace EssentialDiagnostics.EntityFramework
{
    public class Db
    {
        public static void InitializeDiagnosticTrace(DbContext dataContext, string connectionString)
        {
            InitSql(dataContext, connectionString);
        }

        public static void InitializeDiagnosticTrace(DbContext dataContext)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            InitSql(dataContext, connectionString);
        }

        private static void InitSql(DbContext dataContext, string connectionString)
        {
            bool diagnosticTraceExists = dataContext.Database
                     .SqlQuery<int?>(@"
                                 SELECT 1 FROM sys.tables AS T
                                 INNER JOIN sys.schemas AS S ON T.schema_id = S.schema_id
                                 WHERE S.Name = 'dbo' AND T.Name = 'diagnostics_Trace'")
                     .SingleOrDefault() != null;
            if (!diagnosticTraceExists)
            {
                var sqlScripts = new[]
                {
                        Resources.InitDb_DiagnosticTrace_Table,
                        Resources.InitDb_DiagnosticTrace_StoredProc,
                        Resources.InitDb_DiagnosticTrace_Roles,
                        Resources.InitDb_DiagnosticTrace_Grants
                    };

                ExecuteSql(sqlScripts, connectionString);
            }
        }

        private static void ExecuteSql(IEnumerable<string> sqlScripts, string connectionString)
        {
            using (var sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                foreach (var sqlScript in sqlScripts)
                {
                    using (var comm = new SqlCommand(sqlScript, sqlConn))
                    {
                        comm.ExecuteNonQuery();
                    }
                }
                sqlConn.Close();
            }
        }
    }
}
