﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.clickVillaNameTabfromSearchTile_MapClasses
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
    using TestAutomation.Utility;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class clickVillaNameTabfromSearchTile_Map:logWriter
    {
        
        /// <summary>
        /// clickVillaNameTabfromSearchTile_Method
        /// </summary>
        public void clickVillaNameTabfromSearchTile_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIVillaNameHyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIQstabsPane.UIVillaNameHyperlink;
            #endregion

            try
            {
                // Click 'Villa Name' link
                Mouse.Click(uIVillaNameHyperlink, new Point(40, 1));
                WriteLogs("PASS : Villa Tab is Clicked From Search Tile.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("clickVillaNameTabfromSearchTile");
                WriteLogs("FAIL : Could Not Click Villa Tab From Search Tile.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

        }
        
        #region Properties
        public UIVillaHolidaysThatYouWindow UIVillaHolidaysThatYouWindow
        {
            get
            {
                if ((this.mUIVillaHolidaysThatYouWindow == null))
                {
                    this.mUIVillaHolidaysThatYouWindow = new UIVillaHolidaysThatYouWindow();
                }
                return this.mUIVillaHolidaysThatYouWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaHolidaysThatYouWindow : BrowserWindow
    {
        
        public UIVillaHolidaysThatYouWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaHolidaysThatYouDocument UIVillaHolidaysThatYouDocument
        {
            get
            {
                if ((this.mUIVillaHolidaysThatYouDocument == null))
                {
                    this.mUIVillaHolidaysThatYouDocument = new UIVillaHolidaysThatYouDocument(this);
                }
                return this.mUIVillaHolidaysThatYouDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaHolidaysThatYouDocument mUIVillaHolidaysThatYouDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaHolidaysThatYouDocument : HtmlDocument
    {
        
        public UIVillaHolidaysThatYouDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIQstabsPane UIQstabsPane
        {
            get
            {
                if ((this.mUIQstabsPane == null))
                {
                    this.mUIQstabsPane = new UIQstabsPane(this);
                }
                return this.mUIQstabsPane;
            }
        }
        #endregion
        
        #region Fields
        private UIQstabsPane mUIQstabsPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIQstabsPane : HtmlDiv
    {
        
        public UIQstabsPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "qstabs";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Destination\r\nVilla Name", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "Border0 ui-tabs ui-widget ui-widget-content ui-corner-all";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"Border0 ui-tabs ui-widget ui-widget-content ui-corner-all\" id=\"qstabs\"";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIVillaNameHyperlink
        {
            get
            {
                if ((this.mUIVillaNameHyperlink == null))
                {
                    this.mUIVillaNameHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIVillaNameHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Villa Name";
                    this.mUIVillaNameHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIVillaNameHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Title, "Search by Villa", PropertyExpressionOperator.Contains));
                    this.mUIVillaNameHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, ".villaplus.com/#villaTab", PropertyExpressionOperator.Contains));
                    this.mUIVillaNameHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"Search by Villa\" onclick=\"javascr";
                    this.mUIVillaNameHyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIVillaNameHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIVillaNameHyperlink;
        #endregion
    }
}