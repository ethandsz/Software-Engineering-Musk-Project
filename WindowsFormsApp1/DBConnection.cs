﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
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

        public void saveToDB(string sqlQuery, int form_type, string site_name, string cmpltd_by, string date, string work_area, string job_desc,
            string supervisor, string inspector, string type)
        {
            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                //open connection
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                //set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sqlCommand
                sqlCommand.Parameters.Add(new SqlParameter("form_type_id", form_type));
                sqlCommand.Parameters.Add(new SqlParameter("site_name", site_name));
                sqlCommand.Parameters.Add(new SqlParameter("cmpltd_by", cmpltd_by));
                sqlCommand.Parameters.Add(new SqlParameter("date", date));
                sqlCommand.Parameters.Add(new SqlParameter("work_area", work_area));
                sqlCommand.Parameters.Add(new SqlParameter("job_desc", job_desc));
                sqlCommand.Parameters.Add(new SqlParameter("supervisor", supervisor));
                sqlCommand.Parameters.Add(new SqlParameter("inspector", inspector));
                sqlCommand.Parameters.Add(new SqlParameter("type", type));

                //execute the command
                sqlCommand.ExecuteNonQuery();

                connToDB.Close();
            }

        }

    }



}