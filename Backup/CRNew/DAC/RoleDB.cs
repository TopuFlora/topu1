using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace FloraSoft
{
    public class RoleDB
    {
        public SqlDataReader GetAllRoles()
        {
            SqlConnection myConnection = new SqlConnection(AppVariables.ConStr);
            SqlCommand myCommand = new SqlCommand("ACH_GetRole", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            myConnection.Open();
            SqlDataReader result = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return result;
        }
        public SqlDataReader GetRolesOfAUser(int UserID)
        {
            SqlConnection myConnection = new SqlConnection(AppVariables.ConStr);
            SqlCommand myCommand = new SqlCommand("ACH_GetRoleOfAUser", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterUserID = new SqlParameter("@UserID", SqlDbType.Int, 4);
            parameterUserID.Value = UserID;
            myCommand.Parameters.Add(parameterUserID);

            myConnection.Open();
            SqlDataReader result = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return result;
        }

        public SqlDataReader GetRolesForLoginProceed(int UserID)
        {
            SqlConnection myConnection = new SqlConnection(AppVariables.ConStr);
            SqlCommand myCommand = new SqlCommand("ACH_GetRolesForLoginProceed", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterUserID = new SqlParameter("@UserID", SqlDbType.Int, 4);
            parameterUserID.Value = UserID;
            myCommand.Parameters.Add(parameterUserID);

            myConnection.Open();
            SqlDataReader result = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return result;
        }

        public void DeleteRoleOfAUser(int UserID)
        {
            SqlConnection myConnection = new SqlConnection(AppVariables.ConStr);
            SqlCommand myCommand = new SqlCommand("ACH_DeleteUserRoleOfAUser", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterUserID = new SqlParameter("@UserID", SqlDbType.Int, 4);
            parameterUserID.Value = UserID;
            myCommand.Parameters.Add(parameterUserID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            myConnection.Dispose();
            myCommand.Dispose();
        }
        public void InsertRole(int UserID, int RoleID)
        {
            SqlConnection myConnection = new SqlConnection(AppVariables.ConStr);
            SqlCommand myCommand = new SqlCommand("ACH_InsertUserRoleOfAUser", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterUserID = new SqlParameter("@UserID", SqlDbType.Int, 4);
            parameterUserID.Value = UserID;
            myCommand.Parameters.Add(parameterUserID);

            SqlParameter parameterRoleID = new SqlParameter("@RoleID", SqlDbType.NVarChar, 50);
            parameterRoleID.Value = RoleID;
            myCommand.Parameters.Add(parameterRoleID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            myConnection.Dispose();
            myCommand.Dispose();
        }

    }
}

