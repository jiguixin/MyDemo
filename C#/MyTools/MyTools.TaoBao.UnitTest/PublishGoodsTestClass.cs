/*
 *名称：PublishGoodsTestClass
 *功能：
 *创建人：吉桂昕
 *创建时间：2013-05-05 04:47:11
 *修改时间：
 *备注：
 */

using System;
using System.Diagnostics;
using Infrastructure.CrossCutting.IoC.Ninject;
using Infrastructure.Crosscutting.IoC;
using Infrastructure.Crosscutting.Utility;
using MyTools.TaoBao.Impl;
using MyTools.TaoBao.Interface;
using NUnit.Framework;
using Top.Api;
using Top.Api.Domain;
using Top.Api.Request;
using Product = MyTools.TaoBao.DomainModule.Product;

namespace MyTools.TaoBao.UnitTest
{
    [TestFixture]
    public class PublishGoodsTestClass
    {
        /// <summary>
        /// 为整个TestFixture初始化资源
        /// </summary>
        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
        }

        /// <summary>
        /// 为整个TestFixture释放资源
        /// </summary>
        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
        }

        /// <summary>
        /// 为每个Test方法创建资源
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            InstanceLocator.SetLocator(
              new NinjectContainer().WireDependenciesInAssemblies(typeof(ItemCats).Assembly.FullName).Locator);
        }

        /// <summary>
        /// 为每个Test方法释放资源
        /// </summary>
        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void TestGetCid()
        {
            IItemCats client = InstanceLocator.Current.GetInstance<IItemCats>();

            string parentCid = client.GetCid("T恤", "女装");
            Console.WriteLine(parentCid);

            string parentCid1 = client.GetCid("T恤", "女装");
            Console.WriteLine(parentCid);

        }

        [Test]
        public void GetSellerCid()
        {
            string sellerCid = "T恤 - 短袖T恤";

            IShopApi client = InstanceLocator.Current.GetInstance<IShopApi>();

            string s = client.GetSellerCids("mbgou", "Metersbonwe - 女装", "T恤 - 短袖T恤", "T恤 - 长袖T恤");

            Console.WriteLine(s);
        }

       


        [Test]
        public void PublishGoodsTest()
        {

        } 
    }
}