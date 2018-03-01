﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.verifyChatWndwDisplay_MapClasses
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
    public partial class verifyChatWndwDisplay_Map:logWriter
    {
        
        /// <summary>
        /// verifyChatWndwDisplay_Method - Use 'verifyChatWndwDisplay_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public Boolean verifyChatWndwDisplay_Method()
        {
            #region Variable Declarations
            HtmlDiv uIItemPane = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIItemFrame.UIHttpsstaging1villaplDocument.UINew_chat_formPane.UIItemPane;
            #endregion

            Boolean IsChatWndwOpened = false;
            IsChatWndwOpened = uIItemPane.Exists;
            // Verify that the 'InnerText' property of '−' pane equals '−'
            //Assert.AreEqual(this.verifyChatWndwDisplay_MethodExpectedValues.UIItemPaneInnerText, uIItemPane.InnerText);

            return IsChatWndwOpened;
        }

        public void clickMinimiseFrmChatWndw_Method()
        {
            #region Variable Declarations
            HtmlDiv uIItemPane = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIItemFrame.UIHttpsstaging1villaplDocument.UINew_chat_formPane.UIItemPane;
            #endregion

            try
            {
                Assert.AreEqual(this.verifyChatWndwDisplay_MethodExpectedValues.UIItemPaneInnerText, uIItemPane.InnerText);
                Mouse.Click(uIItemPane);
                WriteLogs("PASS : Clicked Minimise from Chat Window.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Could not click Minimise from Chat Window/Chat Window is already minimised.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

        }
        
        #region Properties
        public virtual verifyChatWndwDisplay_MethodExpectedValues verifyChatWndwDisplay_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyChatWndwDisplay_MethodExpectedValues == null))
                {
                    this.mverifyChatWndwDisplay_MethodExpectedValues = new verifyChatWndwDisplay_MethodExpectedValues();
                }
                return this.mverifyChatWndwDisplay_MethodExpectedValues;
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
        private verifyChatWndwDisplay_MethodExpectedValues mverifyChatWndwDisplay_MethodExpectedValues;
        
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyChatWndwDisplay_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyChatWndwDisplay_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of '−' pane equals '−'
        /// </summary>
        public string UIItemPaneInnerText = "−";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaHolidaysThatYouWindow : BrowserWindow
    {
        
        public UIVillaHolidaysThatYouWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIItemFrame UIItemFrame
        {
            get
            {
                if ((this.mUIItemFrame == null))
                {
                    this.mUIItemFrame = new UIItemFrame(this);
                }
                return this.mUIItemFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIItemFrame mUIItemFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIItemFrame : HtmlIFrame
    {
        
        public UIItemFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.FilterProperties[HtmlFrame.PropertyNames.AbsolutePath] = "false";
            this.FilterProperties[HtmlFrame.PropertyNames.PageUrl] = "javascript:false";
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "src=\"javascript:false\" frameBorder=\"0\" s";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIHttpsstaging1villaplDocument UIHttpsstaging1villaplDocument
        {
            get
            {
                if ((this.mUIHttpsstaging1villaplDocument == null))
                {
                    this.mUIHttpsstaging1villaplDocument = new UIHttpsstaging1villaplDocument(this);
                }
                return this.mUIHttpsstaging1villaplDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpsstaging1villaplDocument mUIHttpsstaging1villaplDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHttpsstaging1villaplDocument : HtmlDocument
    {
        
        public UIHttpsstaging1villaplDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UINew_chat_formPane UINew_chat_formPane
        {
            get
            {
                if ((this.mUINew_chat_formPane == null))
                {
                    this.mUINew_chat_formPane = new UINew_chat_formPane(this);
                }
                return this.mUINew_chat_formPane;
            }
        }
        #endregion
        
        #region Fields
        private UINew_chat_formPane mUINew_chat_formPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UINew_chat_formPane : HtmlDiv
    {
        
        public UINew_chat_formPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = "new_chat_form";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Chat with us", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "meshim_widget_components_chatWindow_NewChatForm desktop cwp_medium cwp_br mini lt" +
                "r br stack_child stack_child_mini     stack_child_no_menu force_dock";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = @"class=""meshim_widget_components_chatWindow_NewChatForm desktop cwp_medium cwp_br mini ltr br stack_child stack_child_mini     stack_child_no_menu force_dock"" style=""padding-top: 0px; padding-bottom: 0px; display: block;"" name=""new_chat_form"" __JX__ID=""___$_11 ___$_11 ___$_11""";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "−";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = "Minimize";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "meshim_widget_widgets_IconFont icon_font close";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "title=\"Minimize\" class=\"meshim_widget_widgets_IconFont icon_font close\" __JX__ID=" +
                        "\"___$_11__close ___$_11__close\"";
                    this.mUIItemPane.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIItemPane;
        #endregion
    }
}