﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.TabSearchTile.clickaDatetoMoveNext_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class clickaDatetoMoveNext_Map
    {
        
        /// <summary>
        /// clickaDatetoMoveNext_Method
        /// </summary>
        public Boolean clickaDatetoMoveNext_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIItem31Hyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIUidatepickergroup_1Pane.UIItem31Hyperlink;
            #endregion

            Boolean IsdateavaialtoClick = false;

            UITestControlCollection allselectabledates = uIItem31Hyperlink.FindMatchingControls();
            int Numofselectabledates = allselectabledates.Count;
            if (Numofselectabledates > 1)
            {
                Mouse.Click(allselectabledates[Numofselectabledates - 1]);
                IsdateavaialtoClick = true;
            }
            else
            {
                IsdateavaialtoClick = false;
            }

            return IsdateavaialtoClick;
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
        public UIUidatepickergroup_1Pane UIUidatepickergroup_1Pane
        {
            get
            {
                if ((this.mUIUidatepickergroup_1Pane == null))
                {
                    this.mUIUidatepickergroup_1Pane = new UIUidatepickergroup_1Pane(this);
                }
                return this.mUIUidatepickergroup_1Pane;
            }
        }
        #endregion
        
        #region Fields
        private UIUidatepickergroup_1Pane mUIUidatepickergroup_1Pane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIUidatepickergroup_1Pane : HtmlDiv
    {
        
        public UIUidatepickergroup_1Pane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "ui-datepicker-group_1";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Next", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "ui-datepicker-group ui-datepicker-group-last";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"ui-datepicker-group ui-datepicker-group-last\" id=\"ui-datepicker-group_1\"";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIItem31Hyperlink
        {
            get
            {
                if ((this.mUIItem31Hyperlink == null))
                {
                    this.mUIItem31Hyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIItem31Hyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIItem31Hyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, ".villaplus.com/#", PropertyExpressionOperator.Contains));
                    this.mUIItem31Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ui-state-default";
                    this.mUIItem31Hyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"ui-state-default\" href=\"#\"";
                    this.mUIItem31Hyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIItem31Hyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIItem31Hyperlink;
        #endregion
    }
}
