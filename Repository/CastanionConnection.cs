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
    public class CastanionConnection
    {

        /// <summary>
        /// Create a new connection
        /// </summary>
        /// <param name="connectionString">Connection string base</param>
        /// <param name="commandType">Type of command, Stored procedure or Query</param>
        /// <param name="query">Name of stored procedure or string query to execute</param>
        /// <returns></returns>
        public static SqlCommand GetConnection(String connectionString, CommandType commandType, String query)
        {
            SqlCommand Command;
            SqlConnection Connection = new SqlConnection(connectionString);
            Command = new SqlCommand(query, Connection);
            Command.CommandType = commandType;
            return Command;
        }

        /// <summary>
        /// Return dataTable and extract a datatable result
        /// </summary>
        /// <param name="Command">Command created by with connection</param>
        /// <returns></returns>
        public static DataTable ExecuteWithDataTable(SqlCommand Command)
        {
            DataTable dt = new DataTable();
            try
            {
                Command.Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter();
                Adapter.SelectCommand = Command;
                Adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //TODO: send error library
            }
            finally
            {
                Command.Connection.Dispose();
                Command.Dispose();
            }
            return dt;
        }

        /// <summary>
        /// Return dataSet and extract a dataset result
        /// </summary>
        /// <param name="Command">Command created by with connection</param>
        /// <returns></returns>
        public static DataSet ExecuteWithDataSet(SqlCommand Command)
        {
            DataSet ds = new DataSet();
            try
            {
                Command.Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter();
                Adapter.SelectCommand = Command;
                Adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                //TODO: create capture exception
            }
            finally
            {
                Command.Connection.Dispose();
                Command.Dispose();
            }
            return ds;
        }

        /// <summary>
        /// Execute query without result set, only true or false
        /// </summary>
        /// <param name="Command"></param>
        /// <returns></returns>
        public static bool ExecuteNonQuery(SqlCommand Command)
        {
            try
            {
                Command.Connection.Open();
                return Command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Command.Connection.Dispose();
                Command.Dispose();
            }
        }


    }
}
