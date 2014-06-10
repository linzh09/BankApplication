using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        IBusinessAuthentication iau = GenericFactory<BusinessLayer, IBusinessAuthentication>.CreateInstance();
        try
        {
            string chkAcctNum = iau.IsValidUser(Utils.StripPunctuation(txtUsername.Text), 
                Utils.StripPunctuation(txtPassword.Text));
            if (chkAcctNum != "")
            {
                lblStatus.Text = "Welcome User";
                SessionFacade.USERNAME = txtUsername.Text;
                SessionFacade.CHECKINGACCTNUM = chkAcctNum;
                if (SessionFacade.PAGEREQUESTED != null)
                    Response.Redirect(SessionFacade.PAGEREQUESTED);
            }

            else
                lblStatus.Text = "Invalid User..";
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.Message;
        }
    }
}