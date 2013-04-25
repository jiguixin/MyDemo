using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Top.Api.Util;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;


namespace GetTbData
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// 授权码
        /// </summary>
        public string AuthrizeCode = "";
        private string url = "http://open.taobao.com/authorize/?appkey=21479233";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }
         

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(webBrowser1.DocumentText);

                foreach (HtmlNode value in doc.DocumentNode.SelectNodes("/html/body/div[@class='content']/div[2]/div[@class='copy-code']/input"))
                {
                    AuthrizeCode = value.Attributes[1].Value;
                }

                if (!string.IsNullOrEmpty(AuthrizeCode) && AuthrizeCode.IndexOf("TOP-") >= 0)
                { 
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }


    }
}
