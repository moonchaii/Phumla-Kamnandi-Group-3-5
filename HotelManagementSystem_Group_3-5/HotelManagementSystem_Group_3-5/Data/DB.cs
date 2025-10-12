using System;
using System.Collections.Generic;
//Name Spaces
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem_Group_3_5.Properties;
// Group 3-5
// Members:
// Shakila Africa : AFRSHA001
// Chai Europa : ERPTEA001
// Lilitha Somana : SMNBON004
// Lindani Xaba : XBXLIN006
namespace HotelManagementSystem_Group_3_5.Data
{
    public class DB
    {
        #region Variable declaration
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
             try
             {
                 daMain = new SqlDataAdapter(sqlLocal, cnMain);
                 cnMain.Open();
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
                cnMain.Open();
                daMain.Update(dsMain, table);
                cnMain.Close();
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

