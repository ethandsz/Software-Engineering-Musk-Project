using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteInspection
{
    class DBConnection
    {
        //private object of the class itself
        private static DBConnection _instance;

        //connection string
        private string connStr;

        //connection to the DB
        private SqlConnection connToDB;

        /// <summary>
        /// constructor
        /// </summary>
        private DBConnection()
        {
            connStr = Properties.Settings.Default.form_db_connection;

        }

        ///
        ///methods
        ///
        /**
         * a static method that creates an unique object of the class itself
         */
        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        /**
         * Returns a data set built based on the query sent as parameter
         */
        public DataSet getDataSet(string sqlQuery)
        {
            //create an empty dataset
            DataSet dataSet = new DataSet();

            using (connToDB = new SqlConnection(connStr))
            {
                //open the connection
                connToDB.Open();

                //create teh object dataAdapter to send a query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill in the dataset
                dataAdapter.Fill(dataSet);

            }

            return dataSet;

        }

    }



}