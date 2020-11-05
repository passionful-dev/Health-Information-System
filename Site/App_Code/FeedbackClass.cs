using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Summary description for FeedbackClass
/// </summary>
public class FeedbackClass
{
    GlobalConnection gc = new GlobalConnection();

    //New/*selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters*/
    public DataTable selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters(int
        feedbackByUserId, String letter)
    {
        String data = "SELECT Feedback.feedbackDate As Date, Users.username, "
            + " Feedback.feedbackSubject As Subject, Feedback.feedbackDescription As Message "
            + " FROM Users INNER JOIN Feedback "
            + " ON Users.userId = Feedback.feedbackToUserId "
            + " WHERE Feedback.feedbackByUserId = " + feedbackByUserId
            + " AND Users.username LIKE '" + letter + "%'"
            + " ORDER BY CONVERT(DATETIME, Feedback.feedbackDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }
  
    //New/*selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters*/
    public DataTable selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(int
        feedbackToUserId, String letter)
    {
        String data = "SELECT Feedback.feedbackDate As Date, Users.username, "
            + " Feedback.feedbackSubject As Subject, Feedback.feedbackDescription As Message "
            + " FROM Users INNER JOIN Feedback "
            + " ON Users.userId = Feedback.feedbackByUserId "
            + " WHERE Feedback.feedbackToUserId = " + feedbackToUserId
            + " AND Users.username LIKE '" + letter + "%'"
            + " ORDER BY CONVERT(DATETIME, Feedback.feedbackDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    //New/*selectAllSentMessage_OfThatSelectedUser*/
    public DataTable selectAllSentMessage_OfThatSelectedUser(String fromUsername,
        int feedbackByUserId)
    {
        String data = "SELECT Feedback.feedbackDate As Date, Users.username, "
            + " Feedback.feedbackSubject As Subject, Feedback.feedbackDescription As Message "
            + " FROM Users INNER JOIN Feedback "
            + " ON Users.userId = Feedback.feedbackToUserId "
            + " WHERE Feedback.feedbackByUserId = " + feedbackByUserId
            + " AND Users.username = '" + fromUsername + "' "
            + " ORDER BY CONVERT(DATETIME, Feedback.feedbackDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    //New/*selectAllRespectiveFeedbackForInboxFromfeedbackToUserId*/
    public DataTable selectAllRespectiveFeedbackForInboxFromfeedbackToUserId(int
        feedbackToUserId)
    {
        String data = "SELECT Feedback.feedbackDate As Date, Users.username, "
            + " Feedback.feedbackSubject As Subject, Feedback.feedbackDescription As Message "
            + " FROM Users INNER JOIN Feedback "
            + " ON Users.userId = Feedback.feedbackByUserId "
            + " WHERE Feedback.feedbackToUserId = " + feedbackToUserId
            + " ORDER BY CONVERT(DATETIME, Feedback.feedbackDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    //New/*selectAllRespectiveFeedbackForSentFromfeedbackByUserId*/
    public DataTable selectAllRespectiveFeedbackForSentFromfeedbackByUserId(int 
        feedbackByUserId)
    {
        String data = "SELECT Feedback.feedbackDate As Date, Users.username, "
            + " Feedback.feedbackSubject As Subject, Feedback.feedbackDescription As Message "
            + " FROM Users INNER JOIN Feedback "
            + " ON Users.userId = Feedback.feedbackToUserId "
            + " WHERE Feedback.feedbackByUserId = " + feedbackByUserId
            + " ORDER BY CONVERT(DATETIME, Feedback.feedbackDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Insert Feedback*/
    public void InsertFeedback(int feedbackByUserId, int feedbackToUserId, String feedbackSubject,
        String feedbackDescription)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String feedbackDate;

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        feedbackDate = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_feedback";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@feedbackDate", feedbackDate);
        cmd.Parameters.Add("@feedbackByUserId", feedbackByUserId);
        cmd.Parameters.Add("@feedbackToUserId", feedbackToUserId);
        cmd.Parameters.Add("@feedbackSubject", feedbackSubject);
        cmd.Parameters.Add("@feedbackDescription", feedbackDescription);
        cmd.ExecuteNonQuery();
    }

    /*Select All Feedback From FeedbackId*/
    public DataTable SelectAllFeedbackFromFeedbackDate(String feedbackDate)
    {
        String data = "SELECT * FROM Feedback WHERE feedbackDate='" + feedbackDate + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Feedback");
        return ds.Tables[0];
    }
}