﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.clickABTALink_MapClasses
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class clickABTALink_Map:logWriter
    {
        
        /// <summary>
        /// clickABTALink_Method
        /// </summary>
        public void clickABTALink_Method()
        {
            #region Variable Declarations
            HtmlImage uIABTAImage = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIBook_with_confidencePane.UIABTAImage;
            #endregion

            // Click 'ABTA' image
            Mouse.Click(uIABTAImage, new Point(54, 23));
            string chkURL = this.UIVillaHolidaysThatYouWindow.Uri.ToString();

            try
            {
                StringAssert.Contains(chkURL, "atol-protected-abta-members");
                WriteLogs("PASS : Clicked on ABTA logo from Footer Section.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Clicked on ABTA logo from Footer Section.");
                WriteLogs("---------" + ex.Message.ToString());
            }
            this.UIVillaHolidaysThatYouWindow.Back();
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaHolidaysThatYouWindow : BrowserWindow
    {
        
        public UIVillaHolidaysThatYouWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Villa Holidays That You’ll Love More | Villa Plus";
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaHolidaysThatYouDocument : HtmlDocument
    {
        
        public UIVillaHolidaysThatYouDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Villa Holidays That You’ll Love More | Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIBook_with_confidencePane UIBook_with_confidencePane
        {
            get
            {
                if ((this.mUIBook_with_confidencePane == null))
                {
                    this.mUIBook_with_confidencePane = new UIBook_with_confidencePane(this);
                }
                return this.mUIBook_with_confidencePane;
            }
        }
        #endregion
        
        #region Fields
        private UIBook_with_confidencePane mUIBook_with_confidencePane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIBook_with_confidencePane : HtmlDiv
    {
        
        public UIBook_with_confidencePane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "book_with_confidence";
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Book with confidence\r\n\r\nYour money is 10";
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "floatleft col_340";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"floatleft col_340\" id=\"book_with_confidence\"", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlImage UIABTAImage
        {
            get
            {
                if ((this.mUIABTAImage == null))
                {
                    this.mUIABTAImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIABTAImage.SearchProperties[HtmlImage.PropertyNames.Alt] = "ABTA";
                    this.mUIABTAImage.FilterProperties[HtmlImage.PropertyNames.AbsolutePath] = "/images/common/ABTA_Footer.png";
                    this.mUIABTAImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/images/common/ABTA_Footer.png", PropertyExpressionOperator.Contains));
                    this.mUIABTAImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.ControlDefinition, "title=\"ABTA\" alt=\"ABTA\" ", PropertyExpressionOperator.Contains));
                    this.mUIABTAImage.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIABTAImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIABTAImage;
        #endregion
    }
}
