﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProvConfPage.clickContinueBtnforOnline_MapClasses
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
    public partial class clickContinueBtnforOnline_Map:logWriter
    {
        
        /// <summary>
        /// clickContinueBtnforOnline_Method
        /// </summary>
        public void clickContinueBtnforOnline_Method()
        {
            #region Variable Declarations
            HtmlImage uIContinueImage = this.UIVillaPlusHolidayBookWindow.UIVillaPlusHolidayBookDocument.UIContinueImage;
            #endregion

            // Click 'Continue' image
            Mouse.Click(uIContinueImage, new Point(55, 11));
            WriteLogs("PASS : \"Continue\" button from Pay Online info layer is Clicked Succssfully.");
 
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
                    this.mUIContinueImage.SearchProperties[HtmlImage.PropertyNames.Id] = "imgContinuePayOnline";
                    this.mUIContinueImage.SearchProperties[HtmlImage.PropertyNames.Alt] = "Continue";
                    this.mUIContinueImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.AbsolutePath, "/imgs/vp/buttons/Continue.gif", PropertyExpressionOperator.Contains));
                    this.mUIContinueImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/imgs/vp/buttons/Continue.gif", PropertyExpressionOperator.Contains));
                    this.mUIContinueImage.FilterProperties[HtmlImage.PropertyNames.ControlDefinition] = "id=\"imgContinuePayOnline\" style=\"display";
                    this.mUIContinueImage.WindowTitles.Add("Villa Plus - Holiday Booking Details");
                    #endregion
                }
                return this.mUIContinueImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIContinueImage;
        #endregion
    }
}
