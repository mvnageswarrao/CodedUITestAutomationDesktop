﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.CountryVillaList.ClickViewVillabtn_MapClasses
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
    using System.Configuration;
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class ClickViewVillabtn_Map:logWriter
    {
        
        /// <summary>
        /// ClickViewVillabtn_Method
        /// </summary>
        public void ClickViewVillabtn_Method()
        {
            #region Variable Declarations
            HtmlInputButton uIViewVillaButton = this.UIHttpnimbusAlgarvevilWindow.UIHttpnimbusAlgarvevilDocument.UIViewVillaButton;
            #endregion

            // Click 'View Villa' button
            Mouse.Click(uIViewVillaButton, new Point(45, 9));
        }

        public void ClickViewVillabtnModified_Method(List<string> VillalistIDs)
        {
            #region Variable Declarations
            HtmlInputButton uIViewVillaButton = this.UIHttpnimbusAlgarvevilWindow.UIHttpnimbusAlgarvevilDocument.UIViewVillaButton;
            #endregion

            string resortIDStr = "";
            int i = 1;
            UITestControlCollection UI = uIViewVillaButton.FindMatchingControls();
 
            foreach (UITestControl utc in UI)
            {
                if (i == 5)
                {
                    break;
                }
                else
                {
                    try
                    {
                        bool tempFound = false;
                        Mouse.Click(utc);
                        string compareURL = this.UIHttpnimbusAlgarvevilWindow.Uri.ToString();
                        foreach (string tempvillaID in VillalistIDs)
                        {
                            resortIDStr = "=" + tempvillaID;
                            if (compareURL.Contains(resortIDStr))
                            {
                                tempFound = true;
                                break;
                            }
                        }
                        if (tempFound == true)
                        {

                            WriteLogs("PASS : Product Page For VillaID : " + resortIDStr + " Opened Successfully.");
                            tempFound = false;
                            this.UIHttpnimbusAlgarvevilWindow.Back();
                        }
                        else
                        {
                            WriteLogs("FAIL : Product Page For VillaID : " + resortIDStr + " Is Not Opened.");
                        }

                    }
                    catch (Exception ex)
                    {
                        takeImage("ClickViewVillabtnModified");
                        WriteLogs("FAIL : Click View Villas for " + resortIDStr);
                        WriteLogs("--------" + ex.Message.ToString()); ;
                    }
                    i++;
                }
            }
        }

        /// <summary>
        /// ClickViewVillabtnAssert_Method - Use 'ClickViewVillabtnAssert_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void ClickViewVillabtnAssert_Method()
        {
            #region Variable Declarations
            HtmlDiv uIBookthisvillaPane = this.UIHttpnimbusAlgarvevilWindow.UICanas1bdrmEQuintadoLDocument.UIContentPane.UIBookthisvillaPane;
            #endregion

            // Verify that the 'InnerText' property of 'Book this villa' pane matches 'Book this villa
            //
            // '
            StringAssert.Matches(uIBookthisvillaPane.InnerText, new Regex(this.ClickViewVillabtnAssert_MethodExpectedValues.UIBookthisvillaPaneInnerText));
        }
        
        #region Properties
        public virtual ClickViewVillabtnAssert_MethodExpectedValues ClickViewVillabtnAssert_MethodExpectedValues
        {
            get
            {
                if ((this.mClickViewVillabtnAssert_MethodExpectedValues == null))
                {
                    this.mClickViewVillabtnAssert_MethodExpectedValues = new ClickViewVillabtnAssert_MethodExpectedValues();
                }
                return this.mClickViewVillabtnAssert_MethodExpectedValues;
            }
        }
        
        public UIHttpnimbusAlgarvevilWindow UIHttpnimbusAlgarvevilWindow
        {
            get
            {
                if ((this.mUIHttpnimbusAlgarvevilWindow == null))
                {
                    this.mUIHttpnimbusAlgarvevilWindow = new UIHttpnimbusAlgarvevilWindow();
                }
                return this.mUIHttpnimbusAlgarvevilWindow;
            }
        }
        #endregion
        
        #region Fields
        private ClickViewVillabtnAssert_MethodExpectedValues mClickViewVillabtnAssert_MethodExpectedValues;
        
        private UIHttpnimbusAlgarvevilWindow mUIHttpnimbusAlgarvevilWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'ClickViewVillabtnAssert_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class ClickViewVillabtnAssert_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Book this villa' pane matches 'Book this villa
        ///
        /// '
        /// </summary>
        public string UIBookthisvillaPaneInnerText = "Book this villa\r\n\r\n ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusAlgarvevilWindow : BrowserWindow
    {
        
        public UIHttpnimbusAlgarvevilWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "/villas", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("http://nimbus/Algarve/villas");
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpnimbusAlgarvevilDocument UIHttpnimbusAlgarvevilDocument
        {
            get
            {
                if ((this.mUIHttpnimbusAlgarvevilDocument == null))
                {
                    this.mUIHttpnimbusAlgarvevilDocument = new UIHttpnimbusAlgarvevilDocument(this);
                }
                return this.mUIHttpnimbusAlgarvevilDocument;
            }
        }
        
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
        private UIHttpnimbusAlgarvevilDocument mUIHttpnimbusAlgarvevilDocument;
        
        private UICanas1bdrmEQuintadoLDocument mUICanas1bdrmEQuintadoLDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusAlgarvevilDocument : HtmlDocument
    {
        
        public UIHttpnimbusAlgarvevilDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/villas", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/villas", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("http://nimbus/Algarve/villas");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UIViewVillaButton
        {
            get
            {
                if ((this.mUIViewVillaButton == null))
                {
                    this.mUIViewVillaButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIViewVillaButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Id, "btnViewVilla", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Name, "btnViewVilla", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "View Villa";
                    this.mUIViewVillaButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIViewVillaButton.FilterProperties[HtmlButton.PropertyNames.Title] = "click to view this villa";
                    this.mUIViewVillaButton.FilterProperties[HtmlButton.PropertyNames.Class] = "button";
                    this.mUIViewVillaButton.FilterProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.ControlDefinition, "villaCtrl", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaButton.WindowTitles.Add("http://nimbus/Algarve/villas");
                    #endregion
                }
                return this.mUIViewVillaButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUIViewVillaButton;
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/product.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "http://nimbus/product.aspx?villaid=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIContentPane UIContentPane
        {
            get
            {
                if ((this.mUIContentPane == null))
                {
                    this.mUIContentPane = new UIContentPane(this);
                }
                return this.mUIContentPane;
            }
        }
        #endregion
        
        #region Fields
        private UIContentPane mUIContentPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIContentPane : HtmlDiv
    {
        
        public UIContentPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "content";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"content\">\n        <!-- Left Hand sec";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "9";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIBookthisvillaPane
        {
            get
            {
                if ((this.mUIBookthisvillaPane == null))
                {
                    this.mUIBookthisvillaPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIBookthisvillaPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIBookthisvillaPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIBookthisvillaPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Book this villa\r\n\r\n ", PropertyExpressionOperator.Contains));
                    this.mUIBookthisvillaPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIBookthisvillaPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "LayerBkgColor padding-bottom10 Padding-Top10";
                    this.mUIBookthisvillaPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"LayerBkgColor padding-bottom10 Pa";
                    this.mUIBookthisvillaPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "199";
                    this.mUIBookthisvillaPane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIBookthisvillaPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIBookthisvillaPane;
        #endregion
    }
}
