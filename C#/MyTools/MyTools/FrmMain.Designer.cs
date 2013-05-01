namespace MyTools
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biAuthenticate = new DevExpress.XtraBars.BarButtonItem();
            this.TaoBaoPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.taoBaoPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.publishGoodsPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.analysisPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navBar = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.biAuthenticate});
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 2;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.TaoBaoPage});
            this.mainRibbon.Size = new System.Drawing.Size(961, 147);
            this.mainRibbon.StatusBar = this.ribbonStatusBar;
            // 
            // biAuthenticate
            // 
            this.biAuthenticate.Caption = "Authenticate";
            this.biAuthenticate.Glyph = global::MyTools.Properties.Resources.Mark_32x32;
            this.biAuthenticate.Id = 1;
            this.biAuthenticate.LargeGlyph = global::MyTools.Properties.Resources.Mark_32x32;
            this.biAuthenticate.Name = "biAuthenticate";
            // 
            // TaoBaoPage
            // 
            this.TaoBaoPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.taoBaoPageGroup,
            this.publishGoodsPageGroup,
            this.analysisPageGroup});
            this.TaoBaoPage.Name = "TaoBaoPage";
            this.TaoBaoPage.Text = "TaoBaoPage";
            // 
            // taoBaoPageGroup
            // 
            this.taoBaoPageGroup.ItemLinks.Add(this.biAuthenticate);
            this.taoBaoPageGroup.Name = "taoBaoPageGroup";
            this.taoBaoPageGroup.Text = "general";
            // 
            // publishGoodsPageGroup
            // 
            this.publishGoodsPageGroup.Name = "publishGoodsPageGroup";
            this.publishGoodsPageGroup.Text = "publish goods";
            // 
            // analysisPageGroup
            // 
            this.analysisPageGroup.Name = "analysisPageGroup";
            this.analysisPageGroup.Text = "analysis";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 501);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.mainRibbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(961, 31);
            // 
            // navBar
            // 
            this.navBar.ActiveGroup = null;
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Location = new System.Drawing.Point(0, 147);
            this.navBar.Name = "navBar";
            this.navBar.OptionsNavPane.ExpandedWidth = 140;
            this.navBar.Size = new System.Drawing.Size(140, 354);
            this.navBar.TabIndex = 2;
            this.navBar.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 532);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.mainRibbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.mainRibbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MyTools";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage TaoBaoPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup publishGoodsPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraNavBar.NavBarControl navBar;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup analysisPageGroup;
        private DevExpress.XtraBars.BarButtonItem biAuthenticate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup taoBaoPageGroup;
    }
}