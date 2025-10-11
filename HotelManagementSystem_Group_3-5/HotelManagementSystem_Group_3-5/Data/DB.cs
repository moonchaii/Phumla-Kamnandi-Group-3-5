using System;
using System.Collections.Generic;
//Name Spaces
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem_Group_3_5.Properties;//***needs to be added to be able to use the Settings property

namespace HotelManagementSystem_Group_3_5.Data
{
    public class DB
    {
        #region Variable declaration
        //***Once the database is created you can find the correct connection string by using the Settings.Default object to select the correct connection string
        private string strConn = Settings.Default.PhumlaKamnandiDatabaseConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;

        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2
        }
        #endregion

        #region Constructor
        public DB()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        #endregion

        #region Update the DateSet
        public void FillDataSet(string sqlLocal, string table)
        {
            //fills dataset fresh from the db for a specific table and with a specific Query
             try
             {
                 daMain = new SqlDataAdapter(sqlLocal, cnMain);
                 cnMain.Open();
                 //dsMain.Clear();
                 daMain.Fill(dsMain, table);
                 cnMain.Close();
             }
             catch (Exception errObj)
             {
                 MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
             }

           
            }

        #endregion

        #region Update the data source 
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                //open the connection
                cnMain.Open();
                //***update the database table via the data adapter
                daMain.Update(dsMain, table);
                //---close the connection
                cnMain.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion
    }
}

