﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.selectActTabDate_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class selectActTabDate_Map
    {
        
        /// <summary>
        /// selectActTabDate_Method - Use 'selectActTabDate_MethodParams' to pass parameters into this method.
        /// </summary>
        public Boolean selectActTabDate_Method()
        {
            #region Variable Declarations
            HtmlDiv uIJuly2013Thurs4Thurs1Pane = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIAvailabilityTabPane.UIJuly2013Thurs4Thurs1Pane;
            HtmlDiv uIThurs25Pane = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIThurs25Pane;
            HtmlDiv uIJuly2013Pane = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIAvailabilityTabPane.UIJuly2013Pane;
            HtmlDiv uIJune2013Thurs6Thurs1Pane = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIAvailabilityTabPane.UIJune2013Thurs6Thurs1Pane;
            HtmlDiv uIThurs27Pane = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIThurs27Pane;
            HtmlCheckBox uIChk14CheckBox = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIChk14CheckBox;
            #endregion

            //UITestControlCollection ui = uIChk14CheckBox.FindMatchingControls();
            //int NumofAvaialableDates = ui.Count;

            //try
            //{
            //    if (NumofAvaialableDates > 0)
            //    {
            //        Random rnd = new Random();
            //        int Randomdatetoselect = rnd.Next(0, NumofAvaialableDates);
            //        uIChk14CheckBox.Checked = Convert.ToBoolean(Randomdatetoselect);
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
               
            //}
            //catch (Exception)
            //{
            //    return false;
            //}

            ////// Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            ////Playback.PlaybackSettings.ContinueOnError = true;

            ////// Mouse hover 'July 2013 Thurs 4 Thurs 11' pane at (354, 58)
            ////Mouse.Hover(uIJuly2013Thurs4Thurs1Pane, new Point(354, 58));

            ////// Mouse hover 'Thurs 25' pane at (61, 0)
            ////Mouse.Hover(uIThurs25Pane, new Point(61, 0));

            ////// Mouse hover 'July 2013' pane at (253, 14)
            ////Mouse.Hover(uIJuly2013Pane, new Point(253, 14));

            ////// Mouse hover 'June 2013 Thurs 6 Thurs 13' pane at (237, 96)
            ////Mouse.Hover(uIJune2013Thurs6Thurs1Pane, new Point(237, 96));

            ////// Mouse hover 'Thurs 27' pane at (24, 60)
            ////Mouse.Hover(uIThurs27Pane, new Point(24, 60));

            ////// Reset flag to ensure that play back stops if there is an error.
            ////Playback.PlaybackSettings.ContinueOnError = false;

            ////// Select 'chk14' check box
            ////uIChk14CheckBox.Checked = this.selectActTabDate_MethodParams.UIChk14CheckBoxChecked;

            try
            {
                if (uIChk14CheckBox.Checked = this.selectActTabDate_MethodParams.UIChk14CheckBoxChecked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        #region Properties
        public virtual selectActTabDate_MethodParams selectActTabDate_MethodParams
        {
            get
            {
                if ((this.mselectActTabDate_MethodParams == null))
                {
                    this.mselectActTabDate_MethodParams = new selectActTabDate_MethodParams();
                }
                return this.mselectActTabDate_MethodParams;
            }
        }
        
        public UICanas1bdrmEQuintadoLWindow UICanas1bdrmEQuintadoLWindow
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLWindow == null))
                {
                    this.mUICanas1bdrmEQuintadoLWindow = new UICanas1bdrmEQuintadoLWindow();
                }
                return this.mUICanas1bdrmEQuintadoLWindow;
            }
        }
        #endregion
        
        #region Fields
        private selectActTabDate_MethodParams mselectActTabDate_MethodParams;
        
        private UICanas1bdrmEQuintadoLWindow mUICanas1bdrmEQuintadoLWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'selectActTabDate_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class selectActTabDate_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'chk14' check box
        /// </summary>
        public bool UIChk14CheckBoxChecked = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLWindow : BrowserWindow
    {
        
        public UICanas1bdrmEQuintadoLWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UICanas1bdrmEQuintadoLDocument UICanas1bdrmEQuintadoLDocument
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLDocument == null))
                {
                    this.mUICanas1bdrmEQuintadoLDocument = new UICanas1bdrmEQuintadoLDocument(this);
                }
                return this.mUICanas1bdrmEQuintadoLDocument;
            }
        }
        #endregion
        
        #region Fields
        private UICanas1bdrmEQuintadoLDocument mUICanas1bdrmEQuintadoLDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLDocument : HtmlDocument
    {
        
        public UICanas1bdrmEQuintadoLDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/product.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/product.aspx?villaid=275";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIAvailabilityTabPane UIAvailabilityTabPane
        {
            get
            {
                if ((this.mUIAvailabilityTabPane == null))
                {
                    this.mUIAvailabilityTabPane = new UIAvailabilityTabPane(this);
                }
                return this.mUIAvailabilityTabPane;
            }
        }
        
        public HtmlDiv UIThurs25Pane
        {
            get
            {
                if ((this.mUIThurs25Pane == null))
                {
                    this.mUIThurs25Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIThurs25Pane.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "div", PropertyExpressionOperator.Contains));
                    this.mUIThurs25Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIThurs25Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Thurs 25";
                    this.mUIThurs25Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIThurs25Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = "departure-calendar-week available";
                    this.mUIThurs25Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"div24\" class=\"departure-calendar-wee";
                    this.mUIThurs25Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "212";
                    this.mUIThurs25Pane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIThurs25Pane;
            }
        }
        
        public HtmlDiv UIThurs27Pane
        {
            get
            {
                if ((this.mUIThurs27Pane == null))
                {
                    this.mUIThurs27Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIThurs27Pane.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "div", PropertyExpressionOperator.Contains));
                    this.mUIThurs27Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIThurs27Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Thurs 27";
                    this.mUIThurs27Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIThurs27Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = "departure-calendar-week available";
                    this.mUIThurs27Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"div14\" class=\"departure-calendar-wee";
                    this.mUIThurs27Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "199";
                    this.mUIThurs27Pane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIThurs27Pane;
            }
        }
        
        public HtmlCheckBox UIChk14CheckBox
        {
            get
            {
                if ((this.mUIChk14CheckBox == null))
                {
                    this.mUIChk14CheckBox = new HtmlCheckBox(this);
                    #region Search Criteria
                    this.mUIChk14CheckBox.SearchProperties.Add(new PropertyExpression(HtmlCheckBox.PropertyNames.Id, "chk", PropertyExpressionOperator.Contains));
                    this.mUIChk14CheckBox.SearchProperties[HtmlCheckBox.PropertyNames.Name] = null;
                    this.mUIChk14CheckBox.SearchProperties[HtmlCheckBox.PropertyNames.Value] = "on";
                    this.mUIChk14CheckBox.SearchProperties[HtmlCheckBox.PropertyNames.LabeledBy] = null;
                    this.mUIChk14CheckBox.FilterProperties[HtmlCheckBox.PropertyNames.Title] = "";
                    this.mUIChk14CheckBox.FilterProperties[HtmlCheckBox.PropertyNames.Class] = "ez-hide";
                    this.mUIChk14CheckBox.FilterProperties.Add(new PropertyExpression(HtmlCheckBox.PropertyNames.ControlDefinition, "id=\"chk", PropertyExpressionOperator.Contains));
                    #endregion
                }
                return this.mUIChk14CheckBox;
            }
        }
        #endregion
        
        #region Fields
        private UIAvailabilityTabPane mUIAvailabilityTabPane;
        
        private HtmlDiv mUIThurs25Pane;
        
        private HtmlDiv mUIThurs27Pane;
        
        private HtmlCheckBox mUIChk14CheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIAvailabilityTabPane : HtmlDiv
    {
        
        public UIAvailabilityTabPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "AvailabilityTab";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\r\n\r\nPrices & availability\r\n Please provi";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "vi-tabs ui-tabs-panel ui-widget-content ui-corner-bottom";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"min-height: 625px;\" id=\"Availabil";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "170";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIJuly2013Thurs4Thurs1Pane
        {
            get
            {
                if ((this.mUIJuly2013Thurs4Thurs1Pane == null))
                {
                    this.mUIJuly2013Thurs4Thurs1Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIJuly2013Thurs4Thurs1Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIJuly2013Thurs4Thurs1Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIJuly2013Thurs4Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\r\nJuly 2013\r\n\r\n\r\nThurs 4\r\n\r\n\r\nThurs 11\r\n";
                    this.mUIJuly2013Thurs4Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIJuly2013Thurs4Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = "departure-calendar-month clearfix";
                    this.mUIJuly2013Thurs4Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"departure-calendar-month clearfix";
                    this.mUIJuly2013Thurs4Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "33";
                    this.mUIJuly2013Thurs4Thurs1Pane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIJuly2013Thurs4Thurs1Pane;
            }
        }
        
        public HtmlDiv UIJuly2013Pane
        {
            get
            {
                if ((this.mUIJuly2013Pane == null))
                {
                    this.mUIJuly2013Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIJuly2013Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIJuly2013Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIJuly2013Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "July 2013";
                    this.mUIJuly2013Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIJuly2013Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = "departure-calendar-month-title";
                    this.mUIJuly2013Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"departure-calendar-month-title\"";
                    this.mUIJuly2013Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "34";
                    this.mUIJuly2013Pane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIJuly2013Pane;
            }
        }
        
        public HtmlDiv UIJune2013Thurs6Thurs1Pane
        {
            get
            {
                if ((this.mUIJune2013Thurs6Thurs1Pane == null))
                {
                    this.mUIJune2013Thurs6Thurs1Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIJune2013Thurs6Thurs1Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIJune2013Thurs6Thurs1Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIJune2013Thurs6Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\r\n\r\nJune 2013\r\n\r\n\r\nThurs 6\r\n\r\n\r\nThurs 13";
                    this.mUIJune2013Thurs6Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIJune2013Thurs6Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = "departure-calendar-months";
                    this.mUIJune2013Thurs6Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"departure-calendar-months\"";
                    this.mUIJune2013Thurs6Thurs1Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "19";
                    this.mUIJune2013Thurs6Thurs1Pane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIJune2013Thurs6Thurs1Pane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIJuly2013Thurs4Thurs1Pane;
        
        private HtmlDiv mUIJuly2013Pane;
        
        private HtmlDiv mUIJune2013Thurs6Thurs1Pane;
        #endregion
    }
}