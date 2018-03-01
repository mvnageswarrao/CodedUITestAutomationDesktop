﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.checkTabAvailablity_MapClasses
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
    public partial class checkTabAvailablity_Map
    {
        
        /// <summary>
        /// checkTabAvailablity_Method - Use 'checkTabAvailablity_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public Boolean checkTabAvailablity_Method(string tabName)
        {
            #region Variable Declarations
            HtmlCustom uIItemCustom = this.UICasaDuasInVilamouraAWindow.UICasaDuasInVilamouraADocument.UIVITabsPane.UIItemCustom;
            #endregion

            // Verify that the 'InnerText' property of custom control contains 'Description
            //Photos
            //Virtual tour
            //Location
            //Activities
            //Reviews
            //Availability'
            try
            {
                
                StringAssert.Contains(uIItemCustom.InnerText, this.checkTabAvailablity_MethodExpectedValues.UIItemCustomInnerText);
                return true;
            }
            catch (AssertFailedException ex)
            {
                //WriteLogs(tabName + " Tab not available");
                //WriteLogs("-----------------" + ex.Message.ToString());
                return false;
            }
        }
        
        #region Properties
        public virtual checkTabAvailablity_MethodExpectedValues checkTabAvailablity_MethodExpectedValues
        {
            get
            {
                if ((this.mcheckTabAvailablity_MethodExpectedValues == null))
                {
                    this.mcheckTabAvailablity_MethodExpectedValues = new checkTabAvailablity_MethodExpectedValues();
                }
                return this.mcheckTabAvailablity_MethodExpectedValues;
            }
        }
        
        public UICasaDuasInVilamouraAWindow UICasaDuasInVilamouraAWindow
        {
            get
            {
                if ((this.mUICasaDuasInVilamouraAWindow == null))
                {
                    this.mUICasaDuasInVilamouraAWindow = new UICasaDuasInVilamouraAWindow();
                }
                return this.mUICasaDuasInVilamouraAWindow;
            }
        }
        #endregion
        
        #region Fields
        private checkTabAvailablity_MethodExpectedValues mcheckTabAvailablity_MethodExpectedValues;
        
        private UICasaDuasInVilamouraAWindow mUICasaDuasInVilamouraAWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'checkTabAvailablity_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class checkTabAvailablity_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of custom control contains 'Description
        ///Photos
        ///Virtual tour
        ///Location
        ///Activities
        ///Reviews
        ///Availability'
        /// </summary>
        public string UIItemCustomInnerText = "Description\r\nPhotos\r\nVirtual tour\r\nLocation\r\nActivities\r\nReviews\r\nAvailability";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICasaDuasInVilamouraAWindow : BrowserWindow
    {
        
        public UICasaDuasInVilamouraAWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "| Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UICasaDuasInVilamouraADocument UICasaDuasInVilamouraADocument
        {
            get
            {
                if ((this.mUICasaDuasInVilamouraADocument == null))
                {
                    this.mUICasaDuasInVilamouraADocument = new UICasaDuasInVilamouraADocument(this);
                }
                return this.mUICasaDuasInVilamouraADocument;
            }
        }
        #endregion
        
        #region Fields
        private UICasaDuasInVilamouraADocument mUICasaDuasInVilamouraADocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICasaDuasInVilamouraADocument : HtmlDocument
    {
        
        public UICasaDuasInVilamouraADocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "| Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/product.aspx";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/product.aspx?villaid=", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
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
        private UIVITabsPane mUIVITabsPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVITabsPane : HtmlDiv
    {
        
        public UIVITabsPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "VITabs";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Description\r\nPhotos\r\nVirtual tour\r\nLocat", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = "";
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "Border0 width100pc ui-tabs ui-widget ui-widget-content ui-corner-all";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"Border0 width100pc ui-tabs ui-widget ui-widget-content ui-corner-all\" id=\"" +
                "VITabs\"";
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIItemCustom.SearchProperties["TagName"] = "UL";
                    this.mUIItemCustom.SearchProperties["Id"] = null;
                    this.mUIItemCustom.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIItemCustom.FilterProperties["Class"] = "ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all";
                    this.mUIItemCustom.FilterProperties["ControlDefinition"] = "class=\"ui-tabs-nav ui-helper-reset ui-he";
                    this.mUIItemCustom.FilterProperties["TagInstance"] = "1";
                    #endregion
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIItemCustom;
        #endregion
    }
}