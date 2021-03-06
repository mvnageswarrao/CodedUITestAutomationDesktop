﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProvConfPage.clickContinueBtnforPhone_MapClasses
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
    public partial class clickContinueBtnforPhone_Map:logWriter
    {
        
        /// <summary>
        /// clickContinueBtnforPhone_Method
        /// </summary>
        public Boolean clickContinueBtnforPhone_Method()
        {
            #region Variable Declarations
            HtmlTable uIItemTable = this.UIVillaPlusHolidayBookWindow.UIVillaPlusHolidayBookDocument.UIDvHoverBoxPane.UIItemTable;
            HtmlImage uIContinueImage = this.UIVillaPlusHolidayBookWindow.UIVillaPlusHolidayBookDocument.UIContinueImage;
            #endregion

            Boolean IsContinueforPhoneClicked = false;

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover  table at (146, 227)
            Mouse.Hover(uIItemTable, new Point(146, 227));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Continue' image
            Mouse.Click(uIContinueImage, new Point(49, 8));
            WriteLogs("PASS : \"Continue\" button from Pay By Phone/Confirm info layer is Clicked Succssfully. : VERIFICATION");
            IsContinueforPhoneClicked = true;
            return IsContinueforPhoneClicked;
        }
        
        #region Properties
        public UIVillaPlusHolidayBookWindow UIVillaPlusHolidayBookWindow
        {
            get
            {
                if ((this.mUIVillaPlusHolidayBookWindow == null))
                {
                    this.mUIVillaPlusHolidayBookWindow = new UIVillaPlusHolidayBookWindow();
                }
                return this.mUIVillaPlusHolidayBookWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusHolidayBookWindow mUIVillaPlusHolidayBookWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaPlusHolidayBookWindow : BrowserWindow
    {
        
        public UIVillaPlusHolidayBookWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Plus - Holiday Booking Details");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPlusHolidayBookDocument UIVillaPlusHolidayBookDocument
        {
            get
            {
                if ((this.mUIVillaPlusHolidayBookDocument == null))
                {
                    this.mUIVillaPlusHolidayBookDocument = new UIVillaPlusHolidayBookDocument(this);
                }
                return this.mUIVillaPlusHolidayBookDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusHolidayBookDocument mUIVillaPlusHolidayBookDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaPlusHolidayBookDocument : HtmlDocument
    {
        
        public UIVillaPlusHolidayBookDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/bookingstatus.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/bookingstatus.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus - Holiday Booking Details");
            #endregion
        }
        
        #region Properties
        public HtmlImage UIContinueImage
        {
            get
            {
                if ((this.mUIContinueImage == null))
                {
                    this.mUIContinueImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIContinueImage.SearchProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Id, "imgContinueByPhone", PropertyExpressionOperator.Contains));
                    this.mUIContinueImage.SearchProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Alt, "Continue", PropertyExpressionOperator.Contains));
                    this.mUIContinueImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.AbsolutePath, "/imgs/vp/buttons/Continue.gif", PropertyExpressionOperator.Contains));
                    this.mUIContinueImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/imgs/vp/buttons/Continue.gif", PropertyExpressionOperator.Contains));
                    this.mUIContinueImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.ControlDefinition, "id=\"imgContinueByPhone\" style=\"display: ", PropertyExpressionOperator.Contains));
                    this.mUIContinueImage.WindowTitles.Add("Villa Plus - Holiday Booking Details");
                    #endregion
                }
                return this.mUIContinueImage;
            }
        }
        
        public UIDvHoverBoxPane UIDvHoverBoxPane
        {
            get
            {
                if ((this.mUIDvHoverBoxPane == null))
                {
                    this.mUIDvHoverBoxPane = new UIDvHoverBoxPane(this);
                }
                return this.mUIDvHoverBoxPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIContinueImage;
        
        private UIDvHoverBoxPane mUIDvHoverBoxPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDvHoverBoxPane : HtmlDiv
    {
        
        public UIDvHoverBoxPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "dvHoverBox";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = "dvHoverBox";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Pay By Phone", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "alertOuter", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"alertOuter", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus - Holiday Booking Details");
            #endregion
        }
        
        #region Properties
        public HtmlTable UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new HtmlTable(this);
                    #region Search Criteria
                    this.mUIItemTable.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "This will be a PROVISIONAL booking only ", PropertyExpressionOperator.Contains));
                    this.mUIItemTable.WindowTitles.Add("Villa Plus - Holiday Booking Details");
                    #endregion
                }
                return this.mUIItemTable;
            }
        }
        #endregion
        
        #region Fields
        private HtmlTable mUIItemTable;
        #endregion
    }
}
