using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class XferHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (SessionFacade.USERNAME == null)
        {
            SessionFacade.PAGEREQUESTED = Request.ServerVariables["SCRIPT_NAME"];
            Response.Redirect("Login.aspx");
        }

        if (!IsPostBack)
            ShowTransferHistory(SessionFacade.CHECKINGACCTNUM);
    }

    void ShowTransferHistory(string chkAcctNum)
    {
        try
        {
            IBusinessAccount iba = GenericFactory<BusinessLayer, IBusinessAccount>.CreateInstance();
            List<TransferHistory> TList = iba.GetTransferHistory(chkAcctNum);
            gv1.DataSource = TList;
            gv1.DataBind();
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.Message;
        }
    }
}