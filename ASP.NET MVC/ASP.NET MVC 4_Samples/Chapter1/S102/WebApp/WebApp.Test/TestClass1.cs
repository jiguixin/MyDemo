/*
 *名称：TestClass1
 *功能：
 *创建人：吉桂昕
 *创建时间：2013-03-29 03:06:19
 *修改时间：
 *备注：
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebApp.Test
{
    [TestFixture]
    public class TestClass1
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
        }

        /// <summary>
        /// 为每个Test方法释放资源
        /// </summary>
        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void RouteMatchTest()
        {
            var vari = new Dictionary<string, object>();

            var s = "{}".ToCharArray();

            Match("Home/Index", "{controller}/{action}", out vari);
        }

        protected bool Match(string requestUrl,string Url, out Dictionary<string, object> variables)
        {
            variables = new Dictionary<string, object>();
            string[] strArray1 = requestUrl.Split('/');
            string[] strArray2 = Url.Split('/');
            if (strArray1.Length != strArray2.Length)
            {
                return false;
            }
            for (int i = 0; i < strArray2.Length; i++)
            {
                if (strArray2[i].StartsWith("{") && strArray2[i].EndsWith("}"))
                {

                    variables.Add(strArray2[i].Trim("{}".ToCharArray()), strArray1[i]);
                }
            }
            return true;
        }

    }
}