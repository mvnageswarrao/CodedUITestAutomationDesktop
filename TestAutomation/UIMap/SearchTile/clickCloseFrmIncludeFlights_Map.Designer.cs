﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.clickCloseFrmIncludeFlights_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class clickCloseFrmIncludeFlights_Map
    {
        
        /// <summary>
        /// clickCloseFrmIncludeFlights_Method
        /// </summary>
        public void clickCloseFrmIncludeFlights_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uICloseHyperlink = this.UIYoursearchfound1VillWindow.UIYoursearchfound1VillDocument.UICloseHyperlink;
            #endregion

            // Click 'close' link
            Mouse.Click(uICloseHyperlink, new Point(10, 7));
        }
        
        #region Properties
        public UIYoursearchfound1VillWindow UIYoursearchfound1VillWindow
        {
            get
            {
                if ((this.mUIYoursearchfound1VillWindow == null))
                {
                    this.mUIYoursearchfound1VillWindow = new UIYoursearchfound1VillWindow();
                }
                return this.mUIYoursearchfound1VillWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound1VillWindow mUIYoursearchfound1VillWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound1VillWindow : BrowserWindow
    {
        
        public UIYoursearchfound1VillWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 1 Villa holiday");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound1VillDocument UIYoursearchfound1VillDocument
        {
            get
            {
                if ((this.mUIYoursearchfound1VillDocument == null))
                {
                    this.mUIYoursearchfound1VillDocument = new UIYoursearchfound1VillDocument(this);
                }
                return this.mUIYoursearchfound1VillDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound1VillDocument mUIYoursearchfound1VillDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound1VillDocument : HtmlDocument
    {
        
        public UIYoursearchfound1VillDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/searchresult.aspx";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 1 Villa holiday");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UICloseHyperlink
        {
            get
            {
                if ((this.mUICloseHyperlink == null))
                {
                    this.mUICloseHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICloseHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "close";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/searchresult.aspx";
                    this.mUICloseHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, ".villaplus.com/searchresult.aspx", PropertyExpressionOperator.Contains));
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ui-dialog-titlebar-close ui-corner-all";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"ui-dialog-titlebar-close ui-corne";
                    this.mUICloseHyperlink.WindowTitles.Add("Your search found 1 Villa holiday");
                    #endregion
                }
                return this.mUICloseHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUICloseHyperlink;
        #endregion
    }
}
