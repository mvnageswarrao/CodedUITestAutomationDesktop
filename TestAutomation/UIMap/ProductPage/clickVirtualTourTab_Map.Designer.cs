﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.clickVirtualTourTab_MapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class clickVirtualTourTab_Map
    {
        
        /// <summary>
        /// clickVirtualTourTab_Method
        /// </summary>
        public void clickVirtualTourTab_Method()
        {
            #region Variable Declarations
            HtmlImage uIVillaCanas1BedEQuintImage = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIVillaCanas1BedEQuintImage;
            HtmlHyperlink uIClicktoenlargeHyperlink = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIClicktoenlargeHyperlink;
            HtmlCell uIClicktoenlargeCell = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIMainContent_PhotoPanTable.UIClicktoenlargeCell;
            HtmlHyperlink uIVirtualtourHyperlink = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIVITabsPane.UIVirtualtourHyperlink;
            #endregion

            //// Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            //Playback.PlaybackSettings.ContinueOnError = true;

            //// Mouse hover 'Villa Canas 1 Bed E, Quinta do Lago, Algarve, Port...' image at (22, 28)
            //Mouse.Hover(uIVillaCanas1BedEQuintImage, new Point(22, 28));

            //// Mouse hover 'Click to enlarge' link at (22, 28)
            //Mouse.Hover(uIClicktoenlargeHyperlink, new Point(22, 28));

            //// Mouse hover 'Click to enlarge' cell at (8, 1)
            //Mouse.Hover(uIClicktoenlargeCell, new Point(8, 1));

            //// Reset flag to ensure that play back stops if there is an error.
            //Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Virtual tour' link
            Mouse.Click(uIVirtualtourHyperlink, new Point(49, 17));
        }
        
        #region Properties
        public UICanas1bdrmEQuintadoLWindow UICanas1bdrmEQuintadoLWindow
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLWindow == null))
                {
                    this.mUICanas1bdrmEQuintadoLWindow = new UICanas1bdrmEQuintadoLWindow();
                }
                return this.mUICanas1bdrmEQuintadoLWindow;
            }
        }
        #endregion
        
        #region Fields
        private UICanas1bdrmEQuintadoLWindow mUICanas1bdrmEQuintadoLWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLWindow : BrowserWindow
    {
        
        public UICanas1bdrmEQuintadoLWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UICanas1bdrmEQuintadoLDocument UICanas1bdrmEQuintadoLDocument
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLDocument == null))
                {
                    this.mUICanas1bdrmEQuintadoLDocument = new UICanas1bdrmEQuintadoLDocument(this);
                }
                return this.mUICanas1bdrmEQuintadoLDocument;
            }
        }
        #endregion
        
        #region Fields
        private UICanas1bdrmEQuintadoLDocument mUICanas1bdrmEQuintadoLDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLDocument : HtmlDocument
    {
        
        public UICanas1bdrmEQuintadoLDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/product.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/product.aspx?villaid=275";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlImage UIVillaCanas1BedEQuintImage
        {
            get
            {
                if ((this.mUIVillaCanas1BedEQuintImage == null))
                {
                    this.mUIVillaCanas1BedEQuintImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIVillaCanas1BedEQuintImage.SearchProperties[HtmlImage.PropertyNames.Id] = "MainContent_PhotoPanel_dListPhotos_imgThumbnail_1";
                    this.mUIVillaCanas1BedEQuintImage.SearchProperties[HtmlImage.PropertyNames.Name] = null;
                    this.mUIVillaCanas1BedEQuintImage.SearchProperties[HtmlImage.PropertyNames.Alt] = "Villa Canas 1 Bed E, Quinta do Lago, Algarve, Portugal";
                    this.mUIVillaCanas1BedEQuintImage.FilterProperties[HtmlImage.PropertyNames.AbsolutePath] = "/images/AL/villas/photos/Canas1BedE_275_Villa2L_W4.jpg";
                    this.mUIVillaCanas1BedEQuintImage.FilterProperties[HtmlImage.PropertyNames.Src] = "http://www.villaplus.com/images/AL/villas/photos/Canas1BedE_275_Villa2L_W4.jpg";
                    this.mUIVillaCanas1BedEQuintImage.FilterProperties[HtmlImage.PropertyNames.LinkAbsolutePath] = "/images/AL/villas/photos/Canas1BedE_275_Villa2L_W4.jpg";
                    this.mUIVillaCanas1BedEQuintImage.FilterProperties[HtmlImage.PropertyNames.Href] = "http://www.villaplus.com/images/AL/villas/photos/Canas1BedE_275_Villa2L_W4.jpg";
                    this.mUIVillaCanas1BedEQuintImage.FilterProperties[HtmlImage.PropertyNames.Class] = null;
                    this.mUIVillaCanas1BedEQuintImage.FilterProperties[HtmlImage.PropertyNames.ControlDefinition] = "style=\"WIDTH: 167px; HEIGHT: 111px\" id=M";
                    this.mUIVillaCanas1BedEQuintImage.FilterProperties[HtmlImage.PropertyNames.TagInstance] = "52";
                    this.mUIVillaCanas1BedEQuintImage.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIVillaCanas1BedEQuintImage;
            }
        }
        
        public HtmlHyperlink UIClicktoenlargeHyperlink
        {
            get
            {
                if ((this.mUIClicktoenlargeHyperlink == null))
                {
                    this.mUIClicktoenlargeHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIClicktoenlargeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "MainContent_PhotoPanel_dListPhotos_lnkShadow_1";
                    this.mUIClicktoenlargeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIClicktoenlargeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIClicktoenlargeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Click to enlarge \r\n ";
                    this.mUIClicktoenlargeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/images/AL/villas/photos/Canas1BedE_275_Villa2L_W4.jpg";
                    this.mUIClicktoenlargeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Villa Canas 1 Bed E, Quinta do Lago, Algarve, Portugal";
                    this.mUIClicktoenlargeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://www.villaplus.com/images/AL/villas/photos/Canas1BedE_275_Villa2L_W4.jpg";
                    this.mUIClicktoenlargeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "villa-gallery";
                    this.mUIClicktoenlargeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "style=\"BORDER-RIGHT-WIDTH: 0px; BORDER-T";
                    this.mUIClicktoenlargeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "125";
                    this.mUIClicktoenlargeHyperlink.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIClicktoenlargeHyperlink;
            }
        }
        
        public UIMainContent_PhotoPanTable UIMainContent_PhotoPanTable
        {
            get
            {
                if ((this.mUIMainContent_PhotoPanTable == null))
                {
                    this.mUIMainContent_PhotoPanTable = new UIMainContent_PhotoPanTable(this);
                }
                return this.mUIMainContent_PhotoPanTable;
            }
        }
        
        public UIVITabsPane UIVITabsPane
        {
            get
            {
                if ((this.mUIVITabsPane == null))
                {
                    this.mUIVITabsPane = new UIVITabsPane(this);
                }
                return this.mUIVITabsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIVillaCanas1BedEQuintImage;
        
        private HtmlHyperlink mUIClicktoenlargeHyperlink;
        
        private UIMainContent_PhotoPanTable mUIMainContent_PhotoPanTable;
        
        private UIVITabsPane mUIVITabsPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIMainContent_PhotoPanTable : HtmlTable
    {
        
        public UIMainContent_PhotoPanTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = "MainContent_PhotoPanel_dListPhotos";
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties[HtmlTable.PropertyNames.InnerText] = "Click to enlarge \r\n Click to enlarge \r\n ";
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "id=MainContent_PhotoPanel_dListPhotos ce";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "6";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "4";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = null;
            this.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "6";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIClicktoenlargeCell
        {
            get
            {
                if ((this.mUIClicktoenlargeCell == null))
                {
                    this.mUIClicktoenlargeCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIClicktoenlargeCell.SearchProperties[HtmlCell.PropertyNames.Id] = null;
                    this.mUIClicktoenlargeCell.SearchProperties[HtmlCell.PropertyNames.Name] = null;
                    this.mUIClicktoenlargeCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIClicktoenlargeCell.FilterProperties[HtmlCell.PropertyNames.InnerText] = "Click to enlarge \r\n ";
                    this.mUIClicktoenlargeCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = null;
                    this.mUIClicktoenlargeCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
                    this.mUIClicktoenlargeCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIClicktoenlargeCell.FilterProperties[HtmlCell.PropertyNames.Class] = null;
                    this.mUIClicktoenlargeCell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "2";
                    this.mUIClicktoenlargeCell.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIClicktoenlargeCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIClicktoenlargeCell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIVITabsPane : HtmlDiv
    {
        
        public UIVITabsPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "VITabs";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Overview Photos Virtual tour Location Ac";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "overflow-hidden font11 Border0 width100pc ui-tabs ui-widget ui-widget-content ui-" +
                "corner-all";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=VITabs class=\"overflow-hidden font11 ";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "44";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIVirtualtourHyperlink
        {
            get
            {
                if ((this.mUIVirtualtourHyperlink == null))
                {
                    this.mUIVirtualtourHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIVirtualtourHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIVirtualtourHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIVirtualtourHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIVirtualtourHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Virtual tour";
                    this.mUIVirtualtourHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/product.aspx";
                    this.mUIVirtualtourHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIVirtualtourHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://nimbus/product.aspx?villaid=275#TourTab";
                    this.mUIVirtualtourHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIVirtualtourHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"#TourTab\" jQuery171027470488796323";
                    this.mUIVirtualtourHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "3";
                    this.mUIVirtualtourHyperlink.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIVirtualtourHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIVirtualtourHyperlink;
        #endregion
    }
}
