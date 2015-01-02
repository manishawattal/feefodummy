using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace feefoFeedReader
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xml_filename = "http://perf.isango.com/feefo.xml";
            string xslPath = MapPath("feedback.xsl"); //xsl document in same working directory as this page



            XPathDocument xpathDoc = new XPathDocument(xml_filename);
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(xslPath);
            transform.Transform(xpathDoc, null, Response.Output);
        }
    }
}