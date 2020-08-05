using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastanionLibrary.Repository
{
    public class CastanionDataAccess
    {
       
        #region properties

        public String ConnectionString { get; set; }
        private bool TakeConnectionStringFromConfig { get; set; }

        #endregion

        #region Constructors

        public CastanionDataAccess()
        {
            this.TakeConnectionStringFromConfig = true;
            this.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"] != null ?
                ConfigurationManager.AppSettings["ConnectionString"].ToString() : String.Empty;
        }

        public CastanionDataAccess(String ConnectionString)
        {
            this.ConnectionString = ConnectionString;
            this.TakeConnectionStringFromConfig = false;
        }


        #endregion

        #region Methods

        #region Datatables

        public DataTable GetDataTableFromStoredProcedure(String storedProcedure)
        {
            return GetDataTable(CommandType.StoredProcedure, storedProcedure, this.ConnectionString, null);
        }

        public DataTable GetDataTableFromStoredProcedure(String storedProcedure, List<SqlParameter> parameters)
        {
            return GetDataTable(CommandType.StoredProcedure, storedProcedure, this.ConnectionString, parameters);
        }

        public DataTable GetDataTableFromStoredProcedure(String storedProcedure,String connectionString)
        {
            return GetDataTable(CommandType.StoredProcedure, storedProcedure, connectionString, null);
        }

        public DataTable GetDataTableFromStoredProcedure(String storedProcedure, String connectionString,List<SqlParameter> parameters)
        {
            return GetDataTable(CommandType.StoredProcedure, storedProcedure, connectionString, parameters);
        }


        public DataTable GetDataTableFromQuery(String storedProcedure)
        {
            return GetDataTable(CommandType.Text, storedProcedure, this.ConnectionString, null);
        }

        public DataTable GetDataTableFromQuery(String storedProcedure, List<SqlParameter> parameters)
        {
            return GetDataTable(CommandType.Text, storedProcedure, this.ConnectionString, parameters);
        }

        public DataTable GetDataTableFromQuery(String storedProcedure, String connectionString)
        {
            return GetDataTable(CommandType.Text, storedProcedure, connectionString, null);
        }

        public DataTable GetDataTableFromQuery(String storedProcedure, String connectionString, List<SqlParameter> parameters)
        {
            return GetDataTable(CommandType.Text, storedProcedure, connectionString, parameters);
        }

        private DataTable GetDataTable(CommandType commandType,String query, String connectionString, List<SqlParameter> parameters)
        {
            SqlCommand command = CastanionConnection.GetConnection(connectionString, commandType, query);
            if(parameters!=null && parameters.Any())
                command.Parameters.AddRange(parameters.ToArray());
            return CastanionConnection.ExecuteWithDataTable(command);
        }

        #endregion

        #region DataSets

        public DataSet GetDataSetFromStoredProcedure(String storedProcedure)
        {
            return GetDataSet(CommandType.StoredProcedure, storedProcedure, this.ConnectionString, null);
        }

        public DataSet GetDataSetFromStoredProcedure(String storedProcedure, List<SqlParameter> parameters)
        {
            return GetDataSet(CommandType.StoredProcedure, storedProcedure, this.ConnectionString, parameters);
        }

        public DataSet GetDataSetFromStoredProcedure(String storedProcedure, String connectionString)
        {
            return GetDataSet(CommandType.StoredProcedure, storedProcedure, connectionString, null);
        }

        public DataSet GetDataSetFromStoredProcedure(String storedProcedure, String connectionString, List<SqlParameter> parameters)
        {
            return GetDataSet(CommandType.StoredProcedure, storedProcedure, connectionString, parameters);
        }


        public DataSet GetDataSetFromQuery(String storedProcedure)
        {
            return GetDataSet(CommandType.Text, storedProcedure, this.ConnectionString, null);
        }

        public DataSet GetDataSetFromQuery(String storedProcedure, List<SqlParameter> parameters)
        {
            return GetDataSet(CommandType.Text, storedProcedure, this.ConnectionString, parameters);
        }

        public DataSet GetDataSetFromQuery(String storedProcedure, String connectionString)
        {
            return GetDataSet(CommandType.Text, storedProcedure, connectionString, null);
        }

        public DataSet GetDataSetFromQuery(String storedProcedure, String connectionString, List<SqlParameter> parameters)
        {
            return GetDataSet(CommandType.Text, storedProcedure, connectionString, parameters);
        }

        private DataSet GetDataSet(CommandType commandType, String query, String connectionString, List<SqlParameter> parameters)
        {
            SqlCommand command = CastanionConnection.GetConnection(connectionString, commandType, query);
            if (parameters != null && parameters.Any())
                command.Parameters.AddRange(parameters.ToArray());
            return CastanionConnection.ExecuteWithDataSet(command);
        }

        #endregion

        #region ExecuteNonQuery

        public bool GetExecuteNonQueryFromStoredProcedure(String storedProcedure)
        {
            return GetExecuteNonQuery(CommandType.StoredProcedure, storedProcedure, this.ConnectionString, null);
        }

        public bool GetExecuteNonQueryFromStoredProcedure(String storedProcedure, List<SqlParameter> parameters)
        {
            return GetExecuteNonQuery(CommandType.StoredProcedure, storedProcedure, this.ConnectionString, parameters);
        }

        public bool GetExecuteNonQueryFromStoredProcedure(String storedProcedure, String connectionString)
        {
            return GetExecuteNonQuery(CommandType.StoredProcedure, storedProcedure, connectionString, null);
        }

        public bool GetExecuteNonQueryFromStoredProcedure(String storedProcedure, String connectionString, List<SqlParameter> parameters)
        {
            return GetExecuteNonQuery(CommandType.StoredProcedure, storedProcedure, connectionString, parameters);
        }


        public bool GetExecuteNonQueryFromQuery(String storedProcedure)
        {
            return GetExecuteNonQuery(CommandType.Text, storedProcedure, this.ConnectionString, null);
        }

        public bool GetExecuteNonQueryFromQuery(String storedProcedure, List<SqlParameter> parameters)
        {
            return GetExecuteNonQuery(CommandType.Text, storedProcedure, this.ConnectionString, parameters);
        }

        public bool GetExecuteNonQueryFromQuery(String storedProcedure, String connectionString)
        {
            return GetExecuteNonQuery(CommandType.Text, storedProcedure, connectionString, null);
        }

        public bool GetExecuteNonQueryFromQuery(String storedProcedure, String connectionString, List<SqlParameter> parameters)
        {
            return GetExecuteNonQuery(CommandType.Text, storedProcedure, connectionString, parameters);
        }

        private bool GetExecuteNonQuery(CommandType commandType, String query, String connectionString, List<SqlParameter> parameters)
        {
            SqlCommand command = CastanionConnection.GetConnection(connectionString, commandType, query);
            if (parameters != null && parameters.Any())
                command.Parameters.AddRange(parameters.ToArray());
            return CastanionConnection.ExecuteNonQuery(command);
        }

        #endregion

        #endregion
    }
}
