using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace FloraSoft.CR.DAL
{
    public class ReportDB
    {
        internal System.Data.DataTable GenericChargeReport(DateTime fronDate, DateTime toDate)
        {
            SqlConnection myConnection = new SqlConnection(FLoraSoft.CR.DAL.AppVariables.ConStrVVDD);
            SqlDataAdapter myCommand = new SqlDataAdapter("CR_BankContibution", myConnection);
            myCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

            myCommand.SelectCommand.Parameters.Add("@From", SqlDbType.DateTime, 8).Value = fronDate;
            myCommand.SelectCommand.Parameters.Add("@TO", SqlDbType.DateTime, 8).Value = toDate;
            myCommand.SelectCommand.Parameters.Add("@ReportCriteria", SqlDbType.Bit, 1).Value = 1;
            try
            {
                myConnection.Open();
            }
            catch
            {

            }
            DataTable dt = new DataTable();
            myCommand.Fill(dt);
            return dt;
        }

        internal System.Data.DataTable ChargeDeductionReport(DateTime fronDate, DateTime toDate, bool p)
        {
            SqlConnection myConnection = new SqlConnection(FLoraSoft.CR.DAL.AppVariables.ConStrVVDD);
            SqlDataAdapter myCommand = new SqlDataAdapter("CR_CollectedCharge", myConnection);
            myCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

            //SqlParameter parameterUserID = new SqlParameter("@UserID", SqlDbType.Int, 4);
            //parameterUserID.Value = UserID;
            //myCommand.SelectCommand.Parameters.Add(parameterUserID);

            //SqlParameter parameterMonth = new SqlParameter("@Month", SqlDbType.Int, 4);
            //parameterMonth.Value = Month;
            //myCommand.SelectCommand.Parameters.Add(parameterMonth);

            //SqlParameter parameterYearID = new SqlParameter("@Year", SqlDbType.Int, 4);
            //parameterYearID.Value = Year;
            //myCommand.SelectCommand.Parameters.Add(parameterYearID);
            try
            {
                myConnection.Open();
            }
            catch
            {

            }
            DataTable dt = new DataTable();
            myCommand.Fill(dt);
            return dt;
        }

        internal System.Data.DataTable ChargeRealizationReport(DateTime fronDate, DateTime toDate, bool p)
        {
            SqlConnection myConnection = new SqlConnection(FLoraSoft.CR.DAL.AppVariables.ConStrVVDD);
            SqlDataAdapter myCommand = new SqlDataAdapter("CR_UnCollectedCharge", myConnection);
            myCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

            //SqlParameter parameterUserID = new SqlParameter("@UserID", SqlDbType.Int, 4);
            //parameterUserID.Value = UserID;
            //myCommand.SelectCommand.Parameters.Add(parameterUserID);

            //SqlParameter parameterMonth = new SqlParameter("@Month", SqlDbType.Int, 4);
            //parameterMonth.Value = Month;
            //myCommand.SelectCommand.Parameters.Add(parameterMonth);

            //SqlParameter parameterYearID = new SqlParameter("@Year", SqlDbType.Int, 4);
            //parameterYearID.Value = Year;
            //myCommand.SelectCommand.Parameters.Add(parameterYearID);
            try
            {
                myConnection.Open();
            }
            catch
            {

            }
            DataTable dt = new DataTable();
            myCommand.Fill(dt);
            return dt;
        }


        internal DataTable SearchUserHistory(DateTime fromDate, DateTime toDate, string chargeType, string activityType, string userId)
        {
            SqlConnection myConnection = new SqlConnection(FLoraSoft.CR.DAL.AppVariables.ConStrVVDD);
            SqlDataAdapter myCommand = new SqlDataAdapter("UserActivityHistorySelect", myConnection);
            myCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

            myCommand.SelectCommand.Parameters.Add("@FromDate", SqlDbType.Date, 8).Value = fromDate;

            myCommand.SelectCommand.Parameters.Add("@ToDate", SqlDbType.Date, 8).Value = toDate;

            myCommand.SelectCommand.Parameters.Add("@ChargeType", SqlDbType.VarChar, 30).Value = chargeType;

            myCommand.SelectCommand.Parameters.Add("@ActivityType", SqlDbType.VarChar, 20).Value = activityType;

            myCommand.SelectCommand.Parameters.Add("@UserID", SqlDbType.VarChar, 20).Value = userId; 

            try
            {
                myConnection.Open();
            }
            catch
            { 
            
            }
            DataTable dt = new DataTable();
            myCommand.Fill(dt);
            return dt;
        }

    }
}