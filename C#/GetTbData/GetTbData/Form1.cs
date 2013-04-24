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
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace GetTbData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.Load("file.htm");
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href"))
            {
                HtmlAttribute att = link["href"]; 
            }
            doc.Save("file.htm");
        }


    }
}
