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
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
using Top.Api.Util;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace GetTbData
{
    public partial class FrmMain : Form
    {
        private TopContext context;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* HtmlDocument doc = new HtmlDocument();
            doc.Load("file.htm");
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href"))
            {
                HtmlAttribute att = link["href"]; 
            }
            doc.Save("file.htm");*/

            PublishProduct();



           /* //沙箱环境接入地址：http://gw.api.tbsandbox.com/router/rest
            //正式环境接入地址：http://gw.api.taobao.com/router/rest 
            string TopUrl = "http://gw.api.taobao.com/router/rest";
            TopXmlRestClient client = new TopXmlRestClient(TopUrl, Txt_appkey.Text.Trim(), Txt_appsecret.Text.Trim());
            ItemsGetRequest ieq = new ItemsGetRequest();
            ieq.Fields = "detail_url,num_iid,title,price,nick,pic_url,num,volume";//需返回的商品结构字段列表
            ieq.Cid = 1101;//这是类目ID，可以通过API查到的。
            ieq.PageSize = 10;//每页返回数量
            //这个API有很多参数，大家可以参考API文档。
            PageList<Item> result = client.ItemsGet(ieq);
            List<Item> items = result.Content;
            string table = "<table id=Table1>";
            foreach (Item item in items)
            {
                table += "<tr>";
                table += "<td width=250><img src=" + item.PicUrl + " width=200 height=200 /></td>";
                table += "<td>标题：" + item.Title + " <br/>";
                table += "价格：" + item.Price + " 卖家： " + item.Nick + "<br/>";
                table += "商品数量：" + item.Num + " 30天销量：" + item.Volume + "</td>";
                table += "</tr>";
            }
            table += "</table>";
            Literal1.Text = table;
            */
        }

        private void PublishProduct()
        { 
            string authCode = null;
            if (!GetAuthorizeCode( out authCode))
            {
                MessageBox.Show("没有找到相应的 authCode");
                return;
            }

            context = TopUtils.GetTopContext(authCode);

            ITopClient client = new DefaultTopClient("http://gw.api.taobao.com/router/rest", "21479233", "98dd6f00daf3f94322ec1a4ff72370b7");
            ItemAddRequest req = new ItemAddRequest();
            req.Num = 30L;
            req.Price = "200.07";
            req.Type = "fixed";
            req.StuffStatus = "new";
            req.Title = "Nokia N97全新行货";
            req.Desc = "这是一个好商品";
            req.LocationState = "浙江";
            req.LocationCity = "杭州";
            req.ApproveStatus = "onsale";
            req.Cid = 1512L;
            req.Props = "20000:33564;21514:38489";
            req.FreightPayer = "buyer";
            req.ValidThru = 7L;
            req.HasInvoice = true;
            req.HasWarranty = true;
            req.HasShowcase = true;
            req.SellerCids = "1101,1102,1103";
            req.HasDiscount = true;
            req.PostFee = "5.07";
            req.ExpressFee = "15.07";
            req.EmsFee = "25.07";
            DateTime dateTime = DateTime.Parse("2000-01-01 00:00:00");
            req.ListTime = dateTime;
            req.Increment = "2.50";
            FileItem fItem = new FileItem(@"C:\Users\Administrator\Desktop\a.png");
            req.Image = fItem;
            req.PostageId = 775752L;
            req.AuctionPoint = 5L;
            req.PropertyAlias = "pid:vid:别名;pid1:vid1:别名1";
            req.InputPids = "pid1,pid2,pid3";
            req.SkuProperties = "pid:vid;pid:vid";
            req.SkuQuantities = "2,3,4";
            req.SkuPrices = "200.07";
            req.SkuOuterIds = "1234,1342";
            req.Lang = "zh_CN";
            req.OuterId = "12345";
            req.ProductId = 123456789L;
            req.PicPath = "i7/T1rfxpXcVhXXXH9QcZ_033150.jpg";
            req.AutoFill = "time_card";
            req.InputStr = "耐克;耐克系列;科比系列;科比系列;2K5,Nike乔丹鞋;乔丹系列;乔丹鞋系列;乔丹鞋系列;";
            req.IsTaobao = true;
            req.IsEx = true;
            req.Is3D = true;
            req.SellPromise = true;
            req.AfterSaleId = 47758L;
            req.CodPostageId = 53899L;
            req.IsLightningConsignment = true;
            req.Weight = 100L;
            req.IsXinpin = false;
            req.SubStock = 1L;
            req.FoodSecurityPrdLicenseNo = "QS410006010388";
            req.FoodSecurityDesignCode = "Q/DHL.001-2008";
            req.FoodSecurityFactory = "远东恒天然乳品有限公司";
            req.FoodSecurityFactorySite = "台北市仁爱路4段85号";
            req.FoodSecurityContact = "00800-021216";
            req.FoodSecurityMix = "有机乳糖、有机植物油";
            req.FoodSecurityPlanStorage = "常温";
            req.FoodSecurityPeriod = "2年";
            req.FoodSecurityFoodAdditive = "磷脂 、膨松剂";
            req.FoodSecuritySupplier = "深圳岸通商贸有限公司";
            req.FoodSecurityProductDateStart = "2012-06-01";
            req.FoodSecurityProductDateEnd = "2012-06-10";
            req.FoodSecurityStockDateStart = "2012-06-20";
            req.FoodSecurityStockDateEnd = "2012-06-30";
            req.GlobalStockType = "1";
            req.ScenicTicketPayWay = 1L;
            req.ScenicTicketBookCost = "5.99";
            req.ItemSize = "bulk:8";
            req.ItemWeight = "10";
            req.ChangeProp = "162707:28335:28335,28338";
            req.LocalityLifeChooseLogis = "0";
            req.LocalityLifeExpirydate = "2012-08-06,2012-08-16";
            req.LocalityLifeNetworkId = "5645746";
            req.LocalityLifeMerchant = "56879:码商X";
            req.LocalityLifeVerification = "101";
            req.LocalityLifeRefundRatio = 50L;
            req.LocalityLifeOnsaleAutoRefundRatio = 80L;
            req.PaimaiInfoMode = 1L;
            req.PaimaiInfoDeposit = 20L;
            req.PaimaiInfoInterval = 5L;
            req.PaimaiInfoReserve = "11";
            req.PaimaiInfoValidHour = 2L;
            req.PaimaiInfoValidMinute = 22L;
            ItemAddResponse response = client.Execute(req, context.SessionKey);
        }

        private string GetSessionKey()
        {

            string url =
                "https://oauth.taobao.com/authorize?response_type=token&client_id=12304977&redirect_uri=http://www.oauth.net/2/&scope=item&state=1212";


            return "";
        }

        /// <summary>
        /// 判断是否顺利获取SessionKey
        /// </summary>
        /// <returns></returns>
        private bool GetAuthorizeCode(out string authorizeCode)
        {
            authorizeCode = null;
            FrmLogin dlg = new FrmLogin();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                authorizeCode = dlg.AuthrizeCode;
            }

            if (string.IsNullOrEmpty(authorizeCode)) return false;
              
            return true;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
 

