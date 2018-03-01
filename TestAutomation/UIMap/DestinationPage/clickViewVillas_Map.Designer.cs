﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.DestinationsPage.clickViewVillas_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class clickViewVillas_Map:logWriter
    {
        
        /// <summary>
        /// clickViewVillas_Method
        /// </summary>
        public void clickViewVillas_Method()
        {
            #region Variable Declarations
            HtmlInputButton uIViewvillasButton = this.UIHttpnimbusdestinatioWindow.UIHttpnimbusdestinatioDocument.UIViewvillasButton;
            #endregion

            // Click 'View villas' button
            //Mouse.Click(uIViewvillasButton, new Point(48, 13));
        }

        public void clickViewVillasModified_Method(List<string> villaCenterlst)
        {
            #region Variable Declarations
            HtmlInputButton uIViewvillasButton = this.UIHttpnimbusdestinatioWindow.UIHttpnimbusdestinatioDocument.UIViewvillasButton;
            #endregion

            // Click 'View villas' button

            string centreStr = "";
            
            UITestControlCollection ui = uIViewvillasButton.FindMatchingControls();
            foreach (UITestControl utc in ui)
            {
                try
                {
                    bool tempFound = false;
                    Mouse.Click(utc);
                    string compareURL = this.UIHttpnimbusdestinatioWindow.Uri.ToString();
                    foreach (string tempcentreStr in villaCenterlst)
                    {
                        centreStr = "destination.aspx?dest=" + tempcentreStr;
                        if (compareURL.Contains(centreStr))
                        {
                            tempFound = true;
                            break;
                        }
                    }
                    if (tempFound == true)
                    {
                        WriteLogs("PASS: Click View Villas : " + centreStr);
                        tempFound = false;
                    }
                    else
                    {
                        WriteLogs("FAIL : Click View Villas : " + centreStr);
                    }
                    this.mUIHttpnimbusdestinatioWindow.Back();
                }
                catch (Exception ex)
                {
                    takeImage("clickViewVillasModified");
                    WriteLogs("FAIL : Click View Villas : " + centreStr);
                    WriteLogs("--------" + ex.Message.ToString()); ;
                }
            }
            //Mouse.Click(uIViewvillasButton, new Point(48, 13));
        }
        
        #region Properties
        public UIHttpnimbusdestinatioWindow UIHttpnimbusdestinatioWindow
        {
            get
            {
                if ((this.mUIHttpnimbusdestinatioWindow == null))
                {
                    this.mUIHttpnimbusdestinatioWindow = new UIHttpnimbusdestinatioWindow();
                }
                return this.mUIHttpnimbusdestinatioWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpnimbusdestinatioWindow mUIHttpnimbusdestinatioWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusdestinatioWindow : BrowserWindow
    {
        
        public UIHttpnimbusdestinatioWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "destinations.aspx", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpnimbusdestinatioDocument UIHttpnimbusdestinatioDocument
        {
            get
            {
                if ((this.mUIHttpnimbusdestinatioDocument == null))
                {
                    this.mUIHttpnimbusdestinatioDocument = new UIHttpnimbusdestinatioDocument(this);
                }
                return this.mUIHttpnimbusdestinatioDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpnimbusdestinatioDocument mUIHttpnimbusdestinatioDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusdestinatioDocument : HtmlDocument
    {
        
        public UIHttpnimbusdestinatioDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/destinations.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/destinations.aspx";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UIViewvillasButton
        {
            get
            {
                if ((this.mUIViewvillasButton == null))
                {
                    this.mUIViewvillasButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIViewvillasButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Id, "btnViewVillas", PropertyExpressionOperator.Contains));
                    this.mUIViewvillasButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Name, "$btnViewVillas", PropertyExpressionOperator.Contains));
                    this.mUIViewvillasButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "View villas";
                    this.mUIViewvillasButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIViewvillasButton.FilterProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Title, "villas", PropertyExpressionOperator.Contains));
                    this.mUIViewvillasButton.FilterProperties[HtmlButton.PropertyNames.Class] = "button";
                    this.mUIViewvillasButton.FilterProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.ControlDefinition, "btn", PropertyExpressionOperator.Contains));
                    this.mUIViewvillasButton.WindowTitles.Add("http://nimbus/destinations.aspx");
                    #endregion
                }
                return this.mUIViewvillasButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUIViewvillasButton;
        #endregion
    }
}
