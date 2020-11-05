using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LogFeedbackClass
/// </summary>
public class LogFeedbackClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Insert on Log_FeedbackWholeField table with the insert Operation */
    public void insertOn_Log_FeedbackWholeField_WithInsertOperation(String feedbackDate)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String feedbackWholeFieldLog_Date;
        String feedbackWholeFieldLog_Operation = "Insert";

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        feedbackWholeFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_feedbackWholeField";
        cmd.CommandType = CommandType.StoredProcedure;

        /*Getting Feedback Id from Feedback's username and putting that userId value*/
        try
        {
            FeedbackClass fc = new FeedbackClass();
            
            /*Getting Feedback Id from Feedback's userId*/
            DataTable dtFeedback = fc.SelectAllFeedbackFromFeedbackDate(feedbackDate);
            if (dtFeedback.Rows.Count > 0)
            {
                String feedbackIdString = dtFeedback.Rows[0]["feedbackId"].ToString();
                int feedbackId = Convert.ToInt32(feedbackIdString);
                cmd.Parameters.Add("@feedbackId", feedbackId);
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        cmd.Parameters.Add("@feedbackWholeFieldLog_Date", feedbackWholeFieldLog_Date);
        cmd.Parameters.Add("@feedbackWholeFieldLog_Operation", feedbackWholeFieldLog_Operation);
        cmd.ExecuteNonQuery();
    }
}