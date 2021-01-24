using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FLoraSoft.CR.DAL
{

    public class BBChargeDB
    {
        internal SqlDataReader GetBBCharge(int ChargeID)
        {
            SqlConnection myConnection = new SqlConnection(FLoraSoft.CR.DAL.AppVariables.ConStrVVDD);
            SqlCommand myCommand = new SqlCommand("CR_BBChargeSelect", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterChargeID = new SqlParameter("@ChargeID", SqlDbType.Int);
            parameterChargeID.Value = ChargeID;
            myCommand.Parameters.Add(parameterChargeID);
            try
            {
                myConnection.Open();
            }
            catch
            {

            }
            SqlDataReader dr = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        internal void UpdateBBCharge(int ChargeID, string RVBBCharge, string HVBBchage, string RVHBBCharge, int STATUS, string UserID )
        {
            SqlConnection myConnection = new SqlConnection(FLoraSoft.CR.DAL.AppVariables.ConStrVVDD);
            SqlCommand myCommand = new SqlCommand("CR_BBChargeUpdate", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterChargeID = new SqlParameter("@ChargeID", SqlDbType.Int);
            parameterChargeID.Value = ChargeID;
            myCommand.Parameters.Add(parameterChargeID);

            SqlParameter parameterRVBBCharge = new SqlParameter("@RVBBCharge", SqlDbType.Int);
            parameterRVBBCharge.Value = RVBBCharge;
            myCommand.Parameters.Add(parameterRVBBCharge);

            SqlParameter parameterHVBBchage = new SqlParameter("@HVBBchage", SqlDbType.Int);
            parameterHVBBchage.Value = HVBBchage;
            myCommand.Parameters.Add(parameterHVBBchage);

            SqlParameter parameterRVHBBCharge = new SqlParameter("@RVHBBCharge", SqlDbType.Int);
            parameterRVHBBCharge.Value = RVHBBCharge;
            myCommand.Parameters.Add(parameterRVHBBCharge);

            SqlParameter parameterSTATUS = new SqlParameter("@STATUS", SqlDbType.Int);
            parameterSTATUS.Value = STATUS;
            myCommand.Parameters.Add(parameterSTATUS);

            SqlParameter parameterUserID = new SqlParameter("@UserID", SqlDbType.VarChar);
            parameterUserID.Value = UserID;
            myCommand.Parameters.Add(parameterUserID);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch
            {
                myConnection.Close();
            }
        }

        internal void UpdateBBChargeStatus(int ChargeID,string UserID)
        {
            SqlConnection myConnection = new SqlConnection(FLoraSoft.CR.DAL.AppVariables.ConStrVVDD);
            SqlCommand myCommand = new SqlCommand("BBChargeStatusUpdate", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterChargeID = new SqlParameter("@ChargeID", SqlDbType.Int);
            parameterChargeID.Value = ChargeID;
            myCommand.Parameters.Add(parameterChargeID);

            SqlParameter parameterUserID = new SqlParameter("@UserID", SqlDbType.VarChar);
            parameterUserID.Value = UserID;
            myCommand.Parameters.Add(parameterUserID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}