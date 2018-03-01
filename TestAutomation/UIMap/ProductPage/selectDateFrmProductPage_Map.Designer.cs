﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.selectDateFrmProductPage_MapClasses
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
    public partial class selectDateFrmProductPage_Map
    {
        
        /// <summary>
        /// selectDateFrmProductPage_Method - Use 'selectDateFrmProductPage_MethodParams' to pass parameters into this method.
        /// </summary>
        public Boolean selectDateFrmProductPage_Method()
        {
            #region Variable Declarations
            HtmlCheckBox uIChk32CheckBox = this.UIVillaLArestaInPollenWindow.UIVillaLArestaInPollenDocument.UIChk32CheckBox;
            HtmlDiv uISat14Pane = this.UIVillaLArestaInPollenWindow.UIVillaLArestaInPollenDocument.UISat14Pane;
            #endregion

            UITestControlCollection DatePane = uISat14Pane.FindMatchingControls();
            int NumofPanes = DatePane.Count;
            string displaytext = uISat14Pane.DisplayText.Trim();
            int txtcount = displaytext.Length;

            try
            {
                //Boolean availdate = uISat14Pane.Exists;
                if (txtcount >= 5 && txtcount<10)
                {
                    // Select 'chk32' check box
                    Mouse.Click(uISat14Pane);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        
        #region Properties
        public virtual selectDateFrmProductPage_MethodParams selectDateFrmProductPage_MethodParams
        {
            get
            {
                if ((this.mselectDateFrmProductPage_MethodParams == null))
                {
                    this.mselectDateFrmProductPage_MethodParams = new selectDateFrmProductPage_MethodParams();
                }
                return this.mselectDateFrmProductPage_MethodParams;
            }
        }
        
        public UIVillaLArestaInPollenWindow UIVillaLArestaInPollenWindow
        {
            get
            {
                if ((this.mUIVillaLArestaInPollenWindow == null))
                {
                    this.mUIVillaLArestaInPollenWindow = new UIVillaLArestaInPollenWindow();
                }
                return this.mUIVillaLArestaInPollenWindow;
            }
        }
        #endregion
        
        #region Fields
        private selectDateFrmProductPage_MethodParams mselectDateFrmProductPage_MethodParams;
        
        private UIVillaLArestaInPollenWindow mUIVillaLArestaInPollenWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'selectDateFrmProductPage_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class selectDateFrmProductPage_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'chk32' check box
        /// </summary>
        public bool UIChk32CheckBoxChecked = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaLArestaInPollenWindow : BrowserWindow
    {
        
        public UIVillaLArestaInPollenWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "| Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa L\'Aresta In Pollensa, Majorca | Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaLArestaInPollenDocument UIVillaLArestaInPollenDocument
        {
            get
            {
                if ((this.mUIVillaLArestaInPollenDocument == null))
                {
                    this.mUIVillaLArestaInPollenDocument = new UIVillaLArestaInPollenDocument(this);
                }
                return this.mUIVillaLArestaInPollenDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaLArestaInPollenDocument mUIVillaLArestaInPollenDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaLArestaInPollenDocument : HtmlDocument
    {
        
        public UIVillaLArestaInPollenDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "| Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/product.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/product.aspx?villaid=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa L\'Aresta In Pollensa, Majorca | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UISat14Pane
        {
            get
            {
                if ((this.mUISat14Pane == null))
                {
                    this.mUISat14Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUISat14Pane.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "div", PropertyExpressionOperator.Contains));
                    this.mUISat14Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = "departure-calendar-week available";
                    this.mUISat14Pane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"departure-calendar-week available\" id=\"div", PropertyExpressionOperator.Contains));
                    this.mUISat14Pane.WindowTitles.Add("Villa L\'Aresta In Pollensa, Majorca | Villa Plus");
                    #endregion
                }
                return this.mUISat14Pane;
            }
        }
        
        public HtmlCheckBox UIChk32CheckBox
        {
            get
            {
                if ((this.mUIChk32CheckBox == null))
                {
                    this.mUIChk32CheckBox = new HtmlCheckBox(this);
                    #region Search Criteria
                    this.mUIChk32CheckBox.SearchProperties.Add(new PropertyExpression(HtmlCheckBox.PropertyNames.Id, "chk", PropertyExpressionOperator.Contains));
                    this.mUIChk32CheckBox.SearchProperties[HtmlCheckBox.PropertyNames.Value] = "on";
                    this.mUIChk32CheckBox.FilterProperties[HtmlCheckBox.PropertyNames.Class] = "ez-hide";
                    this.mUIChk32CheckBox.FilterProperties.Add(new PropertyExpression(HtmlCheckBox.PropertyNames.ControlDefinition, "class=\"ez-hide\" type=\"checkbo", PropertyExpressionOperator.Contains));
                    this.mUIChk32CheckBox.WindowTitles.Add("Villa L\'Aresta In Pollensa, Majorca | Villa Plus");
                    #endregion
                }
                return this.mUIChk32CheckBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUISat14Pane;
        
        private HtmlCheckBox mUIChk32CheckBox;
        #endregion
    }
}