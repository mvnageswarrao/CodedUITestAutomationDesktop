﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.verifyLocationTablocText_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class verifyLocationTablocText_Map:logWriter
    {
        
        /// <summary>
        /// verifyLocationTabLocText_Method - Use 'verifyLocationTabLocText_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyLocationTabLocText_Method(string villaLocTabLocText)
        {
            #region Variable Declarations
            HtmlSpan uIMainContent_VillaLocPane = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIMainContent_VillaLocPane;
            #endregion

            // Verify that the 'InnerText' property of 'MainContent_VillaLocation' pane contains 'Vale das Canas is located in natural countryside close to both Quinta do Lago and Vale do Lobo, with a good range of shops, restaurants and leisure facilities within very easy reach by car.'
            //StringAssert.Contains(uIMainContent_VillaLocPane.InnerText, this.verifyLocationTabLocText_MethodExpectedValues.UIMainContent_VillaLocPaneInnerText);
            string toCompare = uIMainContent_VillaLocPane.InnerText;
            toCompare = toCompare.Replace("\r\n", string.Empty);
            toCompare = toCompare.Trim();
            toCompare = toCompare.Replace(" ", string.Empty);
            try
            {
                StringAssert.Contains(toCompare, villaLocTabLocText);
                WriteLogs("PASS : Location Tab - Location Text.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Location Tab - Location Text.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyLocationTabLocText_MethodExpectedValues verifyLocationTabLocText_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyLocationTabLocText_MethodExpectedValues == null))
                {
                    this.mverifyLocationTabLocText_MethodExpectedValues = new verifyLocationTabLocText_MethodExpectedValues();
                }
                return this.mverifyLocationTabLocText_MethodExpectedValues;
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
        private verifyLocationTabLocText_MethodExpectedValues mverifyLocationTabLocText_MethodExpectedValues;
        
        private UICanas1bdrmEQuintadoLWindow mUICanas1bdrmEQuintadoLWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyLocationTabLocText_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class verifyLocationTabLocText_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'MainContent_VillaLocation' pane contains 'Vale das Canas is located in natural countryside close to both Quinta do Lago and Vale do Lobo, with a good range of shops, restaurants and leisure facilities within very easy reach by car.'
        /// </summary>
        public string UIMainContent_VillaLocPaneInnerText = "Vale das Canas is located in natural countryside close to both Quinta do Lago and" +
            " Vale do Lobo, with a good range of shops, restaurants and leisure facilities wi" +
            "thin very easy reach by car.";
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
        public HtmlSpan UIMainContent_VillaLocPane
        {
            get
            {
                if ((this.mUIMainContent_VillaLocPane == null))
                {
                    this.mUIMainContent_VillaLocPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIMainContent_VillaLocPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_VillaLocation";
                    this.mUIMainContent_VillaLocPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIMainContent_VillaLocPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Vale das Canas is located in natural cou";
                    this.mUIMainContent_VillaLocPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIMainContent_VillaLocPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "margin12 displayInlineBlock";
                    this.mUIMainContent_VillaLocPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_VillaLocation\" class=\"ma";
                    this.mUIMainContent_VillaLocPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "20";
                    this.mUIMainContent_VillaLocPane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIMainContent_VillaLocPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIMainContent_VillaLocPane;
        #endregion
    }
}
