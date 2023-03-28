using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDrivenProgramming1
{
    internal class data
    {
        static string connectionString = ConfigurationManager.AppSettings["connectionString"];

        //Retrieve list of rows from DB 
        public static List<T> GetData<T>(string SQL, CommandType cmdType)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                var objProps = Activator.CreateInstance<T>().GetType().GetProperties();     //// FAils here instantiating the account object 
                var returnList = new List<T>();

                using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandTimeout = 30000;


                    try
                    {
                        cnn.Open();
                        SqlDataReader dataReader = cmd.ExecuteReader(); // retrieves multiple records
                        var columns = dataReader.GetSchemaTable().Rows.Cast<DataRow>().Select(row => row["ColumnName"].ToString().ToLower()).ToList();

                        while (dataReader.Read())
                        {
                            var thisRow = Activator.CreateInstance<T>();
                            foreach (var prop in objProps)
                            {
                                if (columns.Contains(prop.Name.ToLower()))// AccNumber is contained in the columns variable. Computer says yes!!
                                {
                                    if (dataReader.IsDBNull(dataReader.GetOrdinal(prop.Name)))
                                    {
                                        prop.SetValue(thisRow, null, null);
                                    }
                                    else
                                    {
                                        prop.SetValue(thisRow, dataReader[prop.Name], null);        //// this is set to null resulting in an exception being thrown
                                    }
                                }
                            }
                            returnList.Add(thisRow);
                        }
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    finally
                    {
                        if (cnn.State != ConnectionState.Closed)
                        {
                            MessageBox.Show("Closing Connection because all else failed!!!!");
                            cnn.Close();
                        }
                    }
                }
                return returnList;
            }
        }
        // Execute non query Inserts updates and deletes on DB
        public static int ExecuteSQLNonQuery(string sql, CommandType cmdType)
        {
            int num = 0;
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.CommandTimeout = 30000;

                        cnn.Open();
                        num = cmd.ExecuteNonQuery();
                    }
                }
                return num;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return num;
            }
        }

        // retrieves a simgle value returns value in the first column of the first row from the result set
        public static string ExecuteSQLscaler(string sql, CommandType cmdType)
        {
            string res = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.CommandTimeout = 30000;

                        cnn.Open();
                        var sqlResult = cmd.ExecuteScalar();
                        res = sqlResult.ToString();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return res;
        }
    }
}
