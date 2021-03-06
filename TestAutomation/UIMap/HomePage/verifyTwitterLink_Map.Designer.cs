﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.verifyTwitterLink_MapClasses
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
    public partial class verifyTwitterLink_Map:logWriter
    {
        
        /// <summary>
        /// verifyTwitterLink_Method - Use 'verifyTwitterLink_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyTwitterLink_Method()
        {
            #region Variable Declarations
            HtmlImage uITwitterImage = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UITwitterImage;
            #endregion

            try
            {
                // Verify that the 'HelpText' property of 'Twitter' image equals 'Twitter'
                Assert.AreEqual(this.verifyTwitterLink_MethodExpectedValues.UITwitterImageHelpText, uITwitterImage.HelpText);
                WriteLogs("PASS : Verify the Twitter LInk from Footer Section.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Verify the Twitter LInk from Footer Section.");
                WriteLogs("-----------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyTwitterLink_MethodExpectedValues verifyTwitterLink_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyTwitterLink_MethodExpectedValues == null))
                {
                    this.mverifyTwitterLink_MethodExpectedValues = new verifyTwitterLink_MethodExpectedValues();
                }
                return this.mverifyTwitterLink_MethodExpectedValues;
            }
        }
        
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
        private verifyTwitterLink_MethodExpectedValues mverifyTwitterLink_MethodExpectedValues;
        
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyTwitterLink_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyTwitterLink_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'HelpText' property of 'Twitter' image equals 'Twitter'
        /// </summary>
        public string UITwitterImageHelpText = "Twitter";
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
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Villa Holidays That You’ll Love More | Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlImage UITwitterImage
        {
            get
            {
                if ((this.mUITwitterImage == null))
                {
                    this.mUITwitterImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUITwitterImage.SearchProperties[HtmlImage.PropertyNames.Id] = "imgtw";
                    this.mUITwitterImage.SearchProperties[HtmlImage.PropertyNames.Alt] = "Twitter";
                    this.mUITwitterImage.FilterProperties[HtmlImage.PropertyNames.AbsolutePath] = "/Images/Common/tw-count.png";
                    this.mUITwitterImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/Images/Common/tw-count.png", PropertyExpressionOperator.Contains));
                    this.mUITwitterImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.ControlDefinition, "title=\"Twitter\" id=\"imgtw\" alt=\"Twitter\"", PropertyExpressionOperator.Contains));
                    this.mUITwitterImage.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUITwitterImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUITwitterImage;
        #endregion
    }
}
