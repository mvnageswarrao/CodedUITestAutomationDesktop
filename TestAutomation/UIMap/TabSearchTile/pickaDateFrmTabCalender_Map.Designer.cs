﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.TabSearchTile.pickaDateFrmTabCalender_MapClasses
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
    public partial class pickaDateFrmTabCalender_Map:logWriter
    {
        
        /// <summary>
        /// pickaDateFrmTabCalender_Method
        /// </summary>
        public void pickaDateFrmTabCalender_Method(DateTime SelectableDATE)
        {
            #region Variable Declarations
            HtmlHyperlink uIItem29Hyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIUidatepickergroup_0Pane1.UIItem29Hyperlink;
            #endregion

            //UITestControlCollection allselectabledates = uIItem29Hyperlink.FindMatchingControls();
            //int Numofselectabledates = allselectabledates.Count;
            //int SelectableDate = Convert.ToInt32(SelectableDATE.Day.ToString());

            //foreach (UITestControl link in allselectabledates)
            //{
            //    int linkname = Convert.ToInt32(link.FriendlyName);
            //    if (linkname == SelectableDate)
            //    {
            //        try
            //        {
            //            Mouse.Click(link);
            //            WriteLogs("PASS : \"" + linkname + "\" selected as Date from Calender.");
            //        }
            //        catch (AssertFailedException ex)
            //        {
            //            WriteLogs("FAIL : Could not Click the Date.");
            //            WriteLogs("-----------------" + ex.Message.ToString());
            //        }
            //    }
            //}
         
            try
            {
                // Click '29' link
                Mouse.Click(uIItem29Hyperlink, new Point(20, 16));
                WriteLogs("PASS : Selected a Date From Tablet Calender.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("pickaDateFrmTabCalender");
                WriteLogs("FAIL : Could Not Select a Date From Tablet Calender.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
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
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "| Villa Plus", PropertyExpressionOperator.Contains));
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "| Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIUidatepickergroup_0Pane UIUidatepickergroup_0Pane
        {
            get
            {
                if ((this.mUIUidatepickergroup_0Pane == null))
                {
                    this.mUIUidatepickergroup_0Pane = new UIUidatepickergroup_0Pane(this);
                }
                return this.mUIUidatepickergroup_0Pane;
            }
        }
        
        public UIUidatepickergroup_0Pane1 UIUidatepickergroup_0Pane1
        {
            get
            {
                if ((this.mUIUidatepickergroup_0Pane1 == null))
                {
                    this.mUIUidatepickergroup_0Pane1 = new UIUidatepickergroup_0Pane1(this);
                }
                return this.mUIUidatepickergroup_0Pane1;
            }
        }
        #endregion
        
        #region Fields
        private UIUidatepickergroup_0Pane mUIUidatepickergroup_0Pane;
        
        private UIUidatepickergroup_0Pane1 mUIUidatepickergroup_0Pane1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIUidatepickergroup_0Pane : HtmlDiv
    {
        
        public UIUidatepickergroup_0Pane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "ui-datepicker-group_", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "ui-datepicker-group ui-datepicker-group-", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"ui-datepicker-group ui-datepicker-group-", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIItem21Hyperlink
        {
            get
            {
                if ((this.mUIItem21Hyperlink == null))
                {
                    this.mUIItem21Hyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIItem21Hyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIItem21Hyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIItem21Hyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIItem21Hyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "21";
                    this.mUIItem21Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/";
                    this.mUIItem21Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIItem21Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://tabstaging1.villaplus.com/#";
                    this.mUIItem21Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ui-state-default";
                    this.mUIItem21Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"ui-state-default\" href=\"#\"";
                    this.mUIItem21Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "16";
                    this.mUIItem21Hyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIItem21Hyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIItem21Hyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIUidatepickergroup_0Pane1 : HtmlDiv
    {
        
        public UIUidatepickergroup_0Pane1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "ui-datepicker-group_", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "ui-datepicker-group ui-datepicker-group-", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"ui-datepicker-group ui-datepicker-group-", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIItem29Hyperlink
        {
            get
            {
                if ((this.mUIItem29Hyperlink == null))
                {
                    this.mUIItem29Hyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIItem29Hyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIItem29Hyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, ".villaplus.com/#", PropertyExpressionOperator.Contains));
                    this.mUIItem29Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ui-state-default";
                    this.mUIItem29Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"ui-state-default\" href=\"#\"";
                    this.mUIItem29Hyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIItem29Hyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIItem29Hyperlink;
        #endregion
    }
}
