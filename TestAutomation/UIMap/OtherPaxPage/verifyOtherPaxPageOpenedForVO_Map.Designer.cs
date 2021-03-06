﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.OtherPaxPage.verifyOtherPaxPageOpenedForVO_MapClasses
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
    public partial class verifyOtherPaxPageOpenedForVO_Map:logWriter
    {
        
        /// <summary>
        /// verifyOtherPaxPageOpenedForVO_Method - Use 'verifyOtherPaxPageOpenedForVO_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyOtherPaxPageOpenedForVO_Method()
        {
            #region Variable Declarations
            HtmlCell uIOtherPartyMembersCell = this.UIOtherPartyMembersDetWindow.UIOtherPartyMembersDetDocument.UIOtherPartyMembersCell;
            #endregion

            try
            {
                Assert.AreEqual(this.verifyOtherPaxPageOpenedForVO_MethodExpectedValues.UIOtherPartyMembersCellInnerText, uIOtherPartyMembersCell.InnerText);
                WriteLogs("PASS : Other Pax Page for VO is Opened Successfully. : VERIFICATION");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyOtherPaxPageOpenedForVO");
                WriteLogs("FAIL : Other Pax Page for VO Could not Opened. : VERIFICATION");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

        }
        
        #region Properties
        public virtual verifyOtherPaxPageOpenedForVO_MethodExpectedValues verifyOtherPaxPageOpenedForVO_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyOtherPaxPageOpenedForVO_MethodExpectedValues == null))
                {
                    this.mverifyOtherPaxPageOpenedForVO_MethodExpectedValues = new verifyOtherPaxPageOpenedForVO_MethodExpectedValues();
                }
                return this.mverifyOtherPaxPageOpenedForVO_MethodExpectedValues;
            }
        }
        
        public UIOtherPartyMembersDetWindow UIOtherPartyMembersDetWindow
        {
            get
            {
                if ((this.mUIOtherPartyMembersDetWindow == null))
                {
                    this.mUIOtherPartyMembersDetWindow = new UIOtherPartyMembersDetWindow();
                }
                return this.mUIOtherPartyMembersDetWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyOtherPaxPageOpenedForVO_MethodExpectedValues mverifyOtherPaxPageOpenedForVO_MethodExpectedValues;
        
        private UIOtherPartyMembersDetWindow mUIOtherPartyMembersDetWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyOtherPaxPageOpenedForVO_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyOtherPaxPageOpenedForVO_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Other Party Members' cell equals '  Other Party Members   '
        /// </summary>
        public string UIOtherPartyMembersCellInnerText = "  Other Party Members   ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOtherPartyMembersDetWindow : BrowserWindow
    {
        
        public UIOtherPartyMembersDetWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Other Party Members Details", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Other Party Members Details");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIOtherPartyMembersDetDocument UIOtherPartyMembersDetDocument
        {
            get
            {
                if ((this.mUIOtherPartyMembersDetDocument == null))
                {
                    this.mUIOtherPartyMembersDetDocument = new UIOtherPartyMembersDetDocument(this);
                }
                return this.mUIOtherPartyMembersDetDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIOtherPartyMembersDetDocument mUIOtherPartyMembersDetDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOtherPartyMembersDetDocument : HtmlDocument
    {
        
        public UIOtherPartyMembersDetDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Other Party Members Details", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/allocatePax.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/allocatePax.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Other Party Members Details");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIOtherPartyMembersCell
        {
            get
            {
                if ((this.mUIOtherPartyMembersCell == null))
                {
                    this.mUIOtherPartyMembersCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIOtherPartyMembersCell.SearchProperties[HtmlCell.PropertyNames.Id] = "mainContentsCell";
                    this.mUIOtherPartyMembersCell.SearchProperties[HtmlCell.PropertyNames.InnerText] = "Other Party Members   ";
                    this.mUIOtherPartyMembersCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "class=\"padding-left10\" id=\"mainContentsCell\"";
                    this.mUIOtherPartyMembersCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "6";
                    this.mUIOtherPartyMembersCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIOtherPartyMembersCell.FilterProperties[HtmlCell.PropertyNames.Class] = "padding-left10";
                    this.mUIOtherPartyMembersCell.WindowTitles.Add("Other Party Members Details");
                    #endregion
                }
                return this.mUIOtherPartyMembersCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIOtherPartyMembersCell;
        #endregion
    }
}
