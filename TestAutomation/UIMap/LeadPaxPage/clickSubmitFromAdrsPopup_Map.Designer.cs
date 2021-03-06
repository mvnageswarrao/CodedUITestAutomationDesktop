﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.LeadPaxPage.clickSubmitFromAdrsPopup_MapClasses
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
    public partial class clickSubmitFromAdrsPopup_Map:logWriter
    {
        
        /// <summary>
        /// clickSubmitFromAdrsPopup_Method
        /// </summary>
        public void clickSubmitFromAdrsPopup_Method(string strURL)
        {
            #region Variable Declarations
            HtmlInputButton uISubmitButton = this.UIAllocateLeadPassengeWindow.UIAllocateLeadPassengeDocument.UISubmitButton;
            #endregion

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(36, 13));
            delayExecution(strURL);
        }
        
        #region Properties
        public UIAllocateLeadPassengeWindow UIAllocateLeadPassengeWindow
        {
            get
            {
                if ((this.mUIAllocateLeadPassengeWindow == null))
                {
                    this.mUIAllocateLeadPassengeWindow = new UIAllocateLeadPassengeWindow();
                }
                return this.mUIAllocateLeadPassengeWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIAllocateLeadPassengeWindow mUIAllocateLeadPassengeWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAllocateLeadPassengeWindow : BrowserWindow
    {
        
        public UIAllocateLeadPassengeWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Allocate Lead Passenger", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Allocate Lead Passenger");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIAllocateLeadPassengeDocument UIAllocateLeadPassengeDocument
        {
            get
            {
                if ((this.mUIAllocateLeadPassengeDocument == null))
                {
                    this.mUIAllocateLeadPassengeDocument = new UIAllocateLeadPassengeDocument(this);
                }
                return this.mUIAllocateLeadPassengeDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIAllocateLeadPassengeDocument mUIAllocateLeadPassengeDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAllocateLeadPassengeDocument : HtmlDocument
    {
        
        public UIAllocateLeadPassengeDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Allocate Lead Passenger", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/allocateLeadPax.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/allocateLeadPax.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Allocate Lead Passenger");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UISubmitButton
        {
            get
            {
                if ((this.mUISubmitButton == null))
                {
                    this.mUISubmitButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUISubmitButton.SearchProperties[HtmlButton.PropertyNames.Id] = "addressListControl_cmdSubmit";
                    this.mUISubmitButton.SearchProperties[HtmlButton.PropertyNames.Name] = "addressListControl$cmdSubmit";
                    this.mUISubmitButton.FilterProperties[HtmlButton.PropertyNames.Type] = "image";
                    this.mUISubmitButton.FilterProperties[HtmlButton.PropertyNames.Title] = "Submit";
                    this.mUISubmitButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"addressListControl$cmdSubmit\" titl";
                    this.mUISubmitButton.WindowTitles.Add("Allocate Lead Passenger");
                    #endregion
                }
                return this.mUISubmitButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUISubmitButton;
        #endregion
    }
}
