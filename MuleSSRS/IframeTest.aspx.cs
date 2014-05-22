using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MuleSSRS
{
    public partial class IframeTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RptViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
            //RptViewer.ServerReport.ReportServerUrl = new Uri("http://wksdevvm861/ReportServer");
            //RptViewer.ServerReport.ReportPath = "/Reports/WcfReport";
            //RptViewer.ServerReport.Refresh(); 
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            List<ReportParameter> lstParams = new List<ReportParameter>();
            RptViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
            RptViewer.ServerReport.ReportServerUrl = new Uri("http://wksdevvm861/ReportServer");
            RptViewer.ServerReport.ReportPath = "/Reports/Check1";

            string strSt = "";

            if (txtState.Text != string.Empty)
                strSt = txtState.Text.Trim();
            else
                strSt = "nofilter";

            lstParams.Add(new ReportParameter("stpar", strSt));
            lstParams.Add(new ReportParameter("fname", "nofilter"));
            lstParams.Add(new ReportParameter("lname", "nofilter"));
            lstParams.Add(new ReportParameter("ssn", "nofilter"));
            lstParams.Add(new ReportParameter("pan", "nofilter"));
            lstParams.Add(new ReportParameter("masterid", "nofilter"));
            lstParams.Add(new ReportParameter("hospid", "nofilter"));
            lstParams.Add(new ReportParameter("labid", "nofilter"));

            RptViewer.ServerReport.SetParameters(lstParams);
            RptViewer.ServerReport.Refresh();
        }

        protected void btnHospital_Click(object sender, EventArgs e)
        {
            List<ReportParameter> lstParams = new List<ReportParameter>();
            RptViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
            RptViewer.ServerReport.ReportServerUrl = new Uri("http://wksdevvm861/ReportServer");
            RptViewer.ServerReport.ReportPath = "/Reports/HospitalReport";

            string strFname = "", strLname = "", strSSN = "", strPAN = "";

            if (txtFristNameHosp.Text != string.Empty)
                strFname = txtFristNameHosp.Text.Trim();
            else
                strFname = "nofilter";

            if (txtLastNameHosp.Text != string.Empty)
                strLname = txtLastNameHosp.Text.Trim();
            else
                strLname = "nofilter";

            if (txtSSNHosp.Text != string.Empty)
                strSSN = txtSSNHosp.Text.Trim();
            else
                strSSN = "nofilter";

            if (txtPANHosp.Text != string.Empty)
                strPAN = txtPANHosp.Text.Trim();
            else
                strPAN = "nofilter";

            lstParams.Add(new ReportParameter("stpar", "nofilter"));
            lstParams.Add(new ReportParameter("fname", strFname));
            lstParams.Add(new ReportParameter("lname", strLname));
            lstParams.Add(new ReportParameter("ssn", strSSN));
            lstParams.Add(new ReportParameter("pan", strPAN));
            lstParams.Add(new ReportParameter("masterid", "nofilter"));
            lstParams.Add(new ReportParameter("hospid", "1"));
            lstParams.Add(new ReportParameter("labid", "nofilter"));

            RptViewer.ServerReport.SetParameters(lstParams);
            RptViewer.ServerReport.Refresh();
        }
        protected void btnLabMaster_Click(object sender, EventArgs e)
        {
            List<ReportParameter> lstParams = new List<ReportParameter>();
            RptViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
            RptViewer.ServerReport.ReportServerUrl = new Uri("http://wksdevvm861/ReportServer");
            RptViewer.ServerReport.ReportPath = "/Reports/LabReport";

            string strFname = "", strLname = "", strSSN = "", strPAN = "";

            if (txtFirstNameLab.Text != string.Empty)
                strFname = txtFirstNameLab.Text.Trim();
            else
                strFname = "nofilter";

            if (txtLastNameLab.Text != string.Empty)
                strLname = txtLastNameLab.Text.Trim();
            else
                strLname = "nofilter";

            if (txtSSNLab.Text != string.Empty)
                strSSN = txtSSNLab.Text.Trim();
            else
                strSSN = "nofilter";

            if (txtPANLab.Text != string.Empty)
                strPAN = txtPANLab.Text.Trim();
            else
                strPAN = "nofilter";

            lstParams.Add(new ReportParameter("stpar", "nofilter"));
            lstParams.Add(new ReportParameter("fname", strFname));
            lstParams.Add(new ReportParameter("lname", strLname));
            lstParams.Add(new ReportParameter("ssn", strSSN));
            lstParams.Add(new ReportParameter("pan", strPAN));
            lstParams.Add(new ReportParameter("masterid", "nofilter"));
            lstParams.Add(new ReportParameter("hospid", "nofilter"));
            lstParams.Add(new ReportParameter("labid", "1"));

            RptViewer.ServerReport.SetParameters(lstParams);
            RptViewer.ServerReport.Refresh();
        }
    }
}