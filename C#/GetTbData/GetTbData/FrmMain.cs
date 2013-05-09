using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Top.Api;
using Top.Api.Domain;
using Top.Api.Request;
using Top.Api.Response;
using Top.Api.Util;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace GetTbData
{
    public class Product
    {
        public string Name;
        public long? Num;
        public string Type;
        public string StuffStatus;
        public string Title;
        public string Desc;
      


    }

    public partial class FrmMain : Form
    {
        private TopContext context;

        private List<SellerCat> sellerCats;

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

            #region 获取店铺类目

            SellercatsListGetRequest reqCats = new SellercatsListGetRequest();
            reqCats.Nick = context.UserNick;
            SellercatsListGetResponse responseCats = client.Execute(reqCats);
            sellerCats = responseCats.SellerCats;
            
              

            // var cats = responseCats.SellerCats.FirstOrDefault(f => f.Name == "");
            

            //714827841
            #endregion

            ItemAddRequest req = new ItemAddRequest();
            req.Num = 30L;
            req.Price = "2000.07";
            req.Type = "fixed";
            req.StuffStatus = "new";
            req.Title = "美邦男装";
            req.Desc = "这是一个好商品";
            req.LocationState = "浙江";
            req.LocationCity = "杭州";
            //req.ApproveStatus = "onsale";
            req.Cid = 50000436;
           // req.Props = "20000:33564;21514:38489";
            req.FreightPayer = "buyer";
            //req.ValidThru = 7L;
            req.HasInvoice = false;
            req.HasWarranty = false;
            req.HasShowcase = false;
            req.SellerCids = GetCatsList("T恤 - 长袖T恤;T恤 - 短袖T恤;T恤 - 圆领T恤", "Metersbonwe - 女装");
            req.HasDiscount = true;
            req.PostFee = "15.07";
            req.ExpressFee = "15.07";
            req.EmsFee = "25.07";
            DateTime dateTime = DateTime.Parse("2000-01-01 00:00:00");
            req.ListTime = dateTime;
            req.Increment = "2.50";
            FileItem fItem = new FileItem(@"C:\Users\Administrator\Desktop\a.png");
            req.Image = fItem;
           // req.PostageId = 775752L;
            //req.AuctionPoint = 5L;
            req.PropertyAlias = "pid:vid:别名;pid1:vid1:别名1";
            req.InputPids = "20000";
            req.SkuProperties = "pid:vid;pid:vid";
            req.SkuQuantities = "2,3,4";
            req.SkuPrices = "200.07";
            req.SkuOuterIds = "1234,1342";
            req.Lang = "zh_CN";
            req.OuterId = "12345";
            req.ProductId = 123456789L;
            req.PicPath = "i7/T1rfxpXcVhXXXH9QcZ_033150.jpg";
            req.AutoFill = "time_card";
            req.InputStr = "耐克;";
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
         

        private string GetCatsList(string childSellCatsContent,string parentSellerName)
        {
            SellerCat parentSellerCat = null;
             
            if (string.IsNullOrEmpty(parentSellerName))
                return null;

            // 获取父节点
            parentSellerCat = sellerCats.FirstOrDefault(s => s.Name == parentSellerName);

            if (parentSellerCat == null)
                return null;

            //如果用户数据有误，将子节点放到了父结点中，如果发现是子节点，就直接返回CID
            if (parentSellerCat.ParentCid != 0)
                return parentSellerCat.Cid.ToString(CultureInfo.InvariantCulture);
             
            //如果子结点为空，直接返回父亲结点CID
            if (string.IsNullOrEmpty(childSellCatsContent))
            { 
                return parentSellerCat.Cid.ToString(CultureInfo.InvariantCulture);
            }

            var cats = childSellCatsContent.Split(';');

            //1, 获取该parentName对应的Cid
//            var parentCid = sellerCats.FirstOrDefault(s=>s.Name == parentSellerName);
//
//            if (parentCid == null)
//                return null;



            //2，根据父CID和各类别名查找相应的子类别用逗号分开
            //string result = null;
            //foreach (var cat in cats)
            //{
            //    var sellerCat = sellerCats.FirstOrDefault(s => s.ParentCid == parentCid.Cid && s.Name == cat);
            //    if (sellerCat != null)
            //    {
            //        if (!string.IsNullOrEmpty(result))
            //            result += "," + sellerCat.Cid;
            //        else
            //            result += sellerCat.Cid;
            //    }
               
            //}
            //return result;
            //等同于下面表达式
            string result = null;
            foreach (var sellerCat in cats.Select(cat => sellerCats.FirstOrDefault(s => s.ParentCid == parentSellerCat.Cid && s.Name == cat)).Where(sellerCat => sellerCat != null))
            {
                if (!string.IsNullOrEmpty(result))
                    result += "," + sellerCat.Cid;
                else
                    result += sellerCat.Cid;
            }
            return result;

            //等同于下面


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
 

