///////////////////////////////////////////////////////////
//  IShopApi.cs
//  Implementation of the Interface IShopApi
//  Generated by Enterprise Architect
//  Created on:      08-五月-2013 0:20:00
//  Original author: 吉桂昕
//////////////////////////////////////////////////////////
using System.Collections.Generic;
using Top.Api.Domain;

namespace MyTools.TaoBao.Interface
{
    public interface IShopApi   {

        /// <summary>
        /// 获取卖家自己的产品类目
        /// </summary>
        /// <param name="userNick"></param>
        List<SellerCat> GetSellercatsList(string userNick);

        /// <summary>
        /// 获取商品所属的店铺类目列表
        /// </summary>
        /// <param name="userNick">淘宝用户名</param>
        /// <param name="parentSellCatName">店铺的父组类目</param>
        /// <param name="childSellCatsNames">子类目列表</param>
        string GetSellerCids(string userNick, string parentSellCatName, IEnumerable<string> childSellCatsNames);

        /// <summary>
        /// 获取商品所属的店铺类目列表
        /// </summary>
        /// <param name="sellerCats">淘宝用户名</param>
        /// <param name="parentSellCatName">店铺的父组类目</param>
        /// <param name="childSellCatsNames">子类目列表</param>
        string GetSellerCids(List<SellerCat> sellerCats, string parentSellCatName, IEnumerable<string> childSellCatsNames);

        /// <summary>
        /// 得到店铺橱窗数量
        /// </summary>
        string GetShopRemainshowcase();
    }
}//end IShopApi