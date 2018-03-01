﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.selectaDateFrmCalender_MapClasses
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
    public partial class selectaDateFrmCalender_Map:logWriter
    {
        
        /// <summary>
        /// selectaDateFrmCalender_Method
        /// </summary>
        public void selectaDateFrmCalender_Method(DateTime SelectableDATE)
        {
            #region Variable Declarations
            HtmlHyperlink uIItem23Hyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIUidatepickerdivPane.UIItem23Hyperlink;
            #endregion


            UITestControlCollection allselectabledates = uIItem23Hyperlink.FindMatchingControls();
            int Numofselectabledates = allselectabledates.Count;
            int SelectableDate = Convert.ToInt32(SelectableDATE.Day.ToString());

            foreach (UITestControl link in allselectabledates)
            {
                int linkname = Convert.ToInt32(link.FriendlyName);
                if (linkname == SelectableDate)
                {
                    try
                    {
                        Mouse.Click(link);
                        WriteLogs("PASS : \"" + linkname + "\" selected as Date from Calender.");
                    }
                    catch (AssertFailedException ex)
                    {
                        takeImage("selectaDateFrmCalender");
                        WriteLogs("FAIL : Could not Click the Date.");
                        WriteLogs("-----------------" + ex.Message.ToString());
                    }
                }
            }
        }
        

        public HtmlHyperlink getselectableDatesFrmCalender_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIItem23Hyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIUidatepickerdivPane.UIItem23Hyperlink;
            #endregion

            return uIItem23Hyperlink;
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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
        public UIUidatepickerdivPane UIUidatepickerdivPane
        {
            get
            {
                if ((this.mUIUidatepickerdivPane == null))
                {
                    this.mUIUidatepickerdivPane = new UIUidatepickerdivPane(this);
                }
                return this.mUIUidatepickerdivPane;
            }
        }
        #endregion
        
        #region Fields
        private UIUidatepickerdivPane mUIUidatepickerdivPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIUidatepickerdivPane : HtmlDiv
    {
        
        public UIUidatepickerdivPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "ui-datepicker-div";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "PrevNext", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "ui-datepicker ui-widget ui-widget-content ui-helper-clearfix ui-corner-all";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"ui-datepicker ui-widget ui-widget-content ui-helper-clearfix ui-corner-all" +
                "\" id=\"ui-datepicker-div\" style=\"left: 967px; top: 317px; display: block; positio" +
                "n: absolute; z-index: 501;\"";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIItem23Hyperlink
        {
            get
            {
                if ((this.mUIItem23Hyperlink == null))
                {
                    this.mUIItem23Hyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIItem23Hyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIItem23Hyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, ".villaplus.com/#", PropertyExpressionOperator.Contains));
                    this.mUIItem23Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ui-state-default pie_first-child";
                    this.mUIItem23Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"ui-state-default pie_first-child\"";
                    this.mUIItem23Hyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIItem23Hyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIItem23Hyperlink;
        #endregion
    }
}