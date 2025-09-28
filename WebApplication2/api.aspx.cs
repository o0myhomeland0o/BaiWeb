using System;

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "application/json; charset=utf-8";

        try
        {
            double[] nums = new double[5];
            for (int i = 0; i < 5; i++)
            {
                string val = Request["n" + (i + 1)];
                double temp;
                if (!double.TryParse(val, out temp))
                {
                    Response.Write("{\"error\":\"Số " + (i + 1) + " không hợp lệ\"}");
                    return;
                }
                nums[i] = temp;
            }

            double sum = 0;
            foreach (double n in nums) sum += n;
            double avg = sum / 5.0;

            Response.Write("{\"result\":" + avg + "}");
        }
        catch (Exception ex)
        {
            Response.Write("{\"error\":\"" + ex.Message.Replace("\"", "\\\"") + "\"}");
        }
    }
}
