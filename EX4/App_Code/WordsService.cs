using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;


namespace EX4
{
    public class WordsService
    {
        protected OleDbConnection myConnection;
        public WordsService()
        {
            string connectionString = Connect.getConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }

        public bool addKind(string KindName)
        {
            OleDbCommand myCommand = new OleDbCommand("AddKind", myConnection);
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            OleDbParameter oleDbParameter;
            oleDbParameter = myCommand.Parameters.Add("@description", OleDbType.BSTR);
            oleDbParameter.Direction = System.Data.ParameterDirection.Input;
            oleDbParameter.Value = KindName;
            if (CheckIfKindExist(KindName))
                return false;
            object obj = null;
            try
            {
                myConnection.Open();
                obj = myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return true;
        }

        public string returnWordByKod(string kodItem)
        {
            OleDbCommand myCommand = new OleDbCommand("GetKindNameByKod", myConnection);
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            OleDbParameter oleDbParameter;
            oleDbParameter = myCommand.Parameters.Add("@KodItem", OleDbType.Integer);
            oleDbParameter.Direction = System.Data.ParameterDirection.Input;
            oleDbParameter.Value = kodItem;
            object obj = null;
            try
            {
                myConnection.Open();
                obj = myCommand.ExecuteScalar();
                if (obj == null)
                    throw new Exception("kod not found");
                return obj.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public bool CheckIfKindExist(string KindName)
        {
            OleDbCommand myCommand = new OleDbCommand("CheckIfKindExist", myConnection);
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            OleDbParameter oleDbParameter;
            oleDbParameter = myCommand.Parameters.Add("@description", OleDbType.BSTR);
            oleDbParameter.Direction = System.Data.ParameterDirection.Input;
            oleDbParameter.Value = KindName;
            object obj = null;
            try
            {
                myConnection.Open();
                obj = myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return !(obj == null);
        }
        public DataSet GetSubjectsl()
        {
            OleDbCommand myCommand = new OleDbCommand("GetAllKinds", myConnection);
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = myCommand;
            DataSet dataSet = new DataSet();
            try
            {
                adapter.Fill(dataSet, "KindsTlb");
                dataSet.Tables["KindsTlb"].PrimaryKey = new DataColumn[]{
                    dataSet.Tables["KindsTlb"].Columns["KodItem"] 
                };


            }
            catch (Exception ex)
            {
                throw ex;

            }
            return dataSet;
        }

        private void CreateRelation(DataSet DS)
        {
            // Get the DataColumn objects from two DataTable objects in a DataSet.
            DataColumn parentCol;
            DataColumn childCol;
            parentCol = DS.Tables["KindsTIb"].Columns["KodItem"];
            childCol = DS.Tables["WordsT1b"].Columns["KodItem"];
            
            DataRelation relKindWord;
            relKindWord = new DataRelation("KindWord", parentCol, childCol);
            // Add the relation to the DataSet.
            DS.Relations.Add(relKindWord);
        }
    }
}
