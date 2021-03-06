﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.OtherPaxPage.clickNextFrmOtherPaxPage_MapClasses
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
    public partial class clickNextFrmOtherPaxPage_Map:logWriter
    {
        
        /// <summary>
        /// clickNextFrmOtherPaxPage_Method
        /// </summary>
        public void clickNextFrmOtherPaxPage_Method(string strURL)
        {
            #region Variable Declarations
            HtmlDiv uINextPane = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UINextPane;
            #endregion

            // Click 'Next' pane
            Mouse.Click(uINextPane, new Point(22, 17));
            delayExecution(strURL);
        }
        
        #region Properties
        public UIOtherPassengersDetaiWindow UIOtherPassengersDetaiWindow
        {
            get
            {
                if ((this.mUIOtherPassengersDetaiWindow == null))
                {
                    this.mUIOtherPassengersDetaiWindow = new UIOtherPassengersDetaiWindow();
                }
                return this.mUIOtherPassengersDetaiWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIOtherPassengersDetaiWindow mUIOtherPassengersDetaiWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOtherPassengersDetaiWindow : BrowserWindow
    {
        
        public UIOtherPassengersDetaiWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Other Passengers Details", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Other Passengers Details");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIOtherPassengersDetaiDocument UIOtherPassengersDetaiDocument
        {
            get
            {
                if ((this.mUIOtherPassengersDetaiDocument == null))
                {
                    this.mUIOtherPassengersDetaiDocument = new UIOtherPassengersDetaiDocument(this);
                }
                return this.mUIOtherPassengersDetaiDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIOtherPassengersDetaiDocument mUIOtherPassengersDetaiDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOtherPassengersDetaiDocument : HtmlDocument
    {
        
        public UIOtherPassengersDetaiDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Other Passengers Details", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/allocatePax.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/allocatePax.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Other Passengers Details");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UINextPane
        {
            get
            {
                if ((this.mUINextPane == null))
                {
                    this.mUINextPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUINextPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "btnNextEnable";
                    this.mUINextPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Next";
                    this.mUINextPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "orangeButtons";
                    this.mUINextPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"orangeButtons\" id=\"btnNextEnable\" style=\"width: 40px; float: right;\" oncli" +
                        "ck=\"javascript:PageController(\'paxnext\',\'onClick\');\"";
                    this.mUINextPane.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUINextPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUINextPane;
        #endregion
    }
}
