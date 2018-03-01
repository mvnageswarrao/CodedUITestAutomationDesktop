﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.PayOnlinePage.clickSubmitFrmVISA3D_MapClasses
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
    public partial class clickSubmitFrmVISA3D_Map:logWriter
    {
        
        /// <summary>
        /// clickSubmitFrmVISA3D_Method
        /// </summary>
        public void clickSubmitFrmVISA3D_Method()
        {
            #region Variable Declarations
            HtmlInputButton uISubmitButton = this.UIVerifiedbyVISAWindowWindow.UIVerifiedbyVISADocument.UITable2Table.UISubmitButton;
            #endregion

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(35, 13));
            WriteLogs("PASS : Clicked Submit Button From VISA 3D Page.");
        }

        public Boolean IsVisa3DPageOpened_Method()
        {
            #region Variable Declarations
            HtmlInputButton uISubmitButton = this.UIVerifiedbyVISAWindowWindow.UIVerifiedbyVISADocument.UITable2Table.UISubmitButton;
            #endregion

            Boolean IsVisa3DPageOpened = false;
            uISubmitButton.WaitForControlExist(30000);
            IsVisa3DPageOpened = uISubmitButton.TryFind();

            return IsVisa3DPageOpened;
        }
        
        #region Properties
        public UIVerifiedbyVISAWindowWindow UIVerifiedbyVISAWindowWindow
        {
            get
            {
                if ((this.mUIVerifiedbyVISAWindowWindow == null))
                {
                    this.mUIVerifiedbyVISAWindowWindow = new UIVerifiedbyVISAWindowWindow();
                }
                return this.mUIVerifiedbyVISAWindowWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIVerifiedbyVISAWindowWindow mUIVerifiedbyVISAWindowWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVerifiedbyVISAWindowWindow : BrowserWindow
    {
        
        public UIVerifiedbyVISAWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Verified by VISA";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Verified by VISA");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVerifiedbyVISADocument UIVerifiedbyVISADocument
        {
            get
            {
                if ((this.mUIVerifiedbyVISADocument == null))
                {
                    this.mUIVerifiedbyVISADocument = new UIVerifiedbyVISADocument(this);
                }
                return this.mUIVerifiedbyVISADocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVerifiedbyVISADocument mUIVerifiedbyVISADocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVerifiedbyVISADocument : HtmlDocument
    {
        
        public UIVerifiedbyVISADocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Verified by VISA";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/acs/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "acs.gpayments.com/acs/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Verified by VISA");
            #endregion
        }
        
        #region Properties
        public UITable2Table UITable2Table
        {
            get
            {
                if ((this.mUITable2Table == null))
                {
                    this.mUITable2Table = new UITable2Table(this);
                }
                return this.mUITable2Table;
            }
        }
        #endregion
        
        #region Fields
        private UITable2Table mUITable2Table;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITable2Table : HtmlTable
    {
        
        public UITable2Table(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = "table2";
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "id=table2 cellSpacing=0 cellPadding=0 width=\"100%\" border=0";
            this.WindowTitles.Add("Verified by VISA");
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
                    this.mUISubmitButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Submit";
                    this.mUISubmitButton.SearchProperties[HtmlButton.PropertyNames.Type] = "button";
                    this.mUISubmitButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "onclick=\"submitAction();return false;\" t";
                    this.mUISubmitButton.WindowTitles.Add("Verified by VISA");
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
