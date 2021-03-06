﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.verifyLocTabInThisArea_MapClasses
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
    public partial class verifyLocTabInThisArea_Map:logWriter
    {
        
        /// <summary>
        /// verifyLocTabInThisArea_Method - Use 'verifyLocTabInThisArea_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyLocTabInThisArea_Method(string villaLocTabInThisAreatxt)
        {
            #region Variable Declarations
            HtmlCustom uIItemCustom = this.UIVillaPoppyPolisCypruWindow.UIVillaPoppyPolisCypruDocument.UIDvAreaPane.UIItemCustom;
            #endregion

            // Verify that the 'InnerText' property of custom control equals '
            //
            //Beach ½ mile 
            //
            //
            //
            //Restaurant 600 yards 
            //
            //
            //
            //Mini market 500 yards 
            //
            //
            //
            //Super market ½ mile 
            //
            //
            //
            //Latchi Harbour 2 miles 
            //
            //
            //
            //Polis Centre 500 yards 
            //
            //
            //
            //Coral Bay 20 miles 
            //
            //
            //
            //Tombs of the Kings 25 miles 
            //
            //
            //
            //Paphos Harbour 25 miles 
            //
            //
            //
            //Paphos Airport 33 miles '
            //Assert.AreEqual(this.verifyLocTabInThisArea_MethodExpectedValues.UIItemCustomInnerText, uIItemCustom.InnerText);
            string toCompare = uIItemCustom.InnerText;
            toCompare = toCompare.Replace("\r\n", string.Empty);
            toCompare = toCompare.Trim();
            toCompare = toCompare.Replace(" ", string.Empty);
            try
            {
                Assert.AreEqual(villaLocTabInThisAreatxt, toCompare);
                WriteLogs("PASS : Location Tab - In this Area.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Location Tab - In this Area.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
            
        }
        
        #region Properties
        public virtual verifyLocTabInThisArea_MethodExpectedValues verifyLocTabInThisArea_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyLocTabInThisArea_MethodExpectedValues == null))
                {
                    this.mverifyLocTabInThisArea_MethodExpectedValues = new verifyLocTabInThisArea_MethodExpectedValues();
                }
                return this.mverifyLocTabInThisArea_MethodExpectedValues;
            }
        }
        
        public UIVillaPoppyPolisCypruWindow UIVillaPoppyPolisCypruWindow
        {
            get
            {
                if ((this.mUIVillaPoppyPolisCypruWindow == null))
                {
                    this.mUIVillaPoppyPolisCypruWindow = new UIVillaPoppyPolisCypruWindow();
                }
                return this.mUIVillaPoppyPolisCypruWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyLocTabInThisArea_MethodExpectedValues mverifyLocTabInThisArea_MethodExpectedValues;
        
        private UIVillaPoppyPolisCypruWindow mUIVillaPoppyPolisCypruWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyLocTabInThisArea_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class verifyLocTabInThisArea_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of custom control equals '
        ///
        ///Beach ½ mile 
        ///
        ///
        ///
        ///Restaurant 600 yards 
        ///
        ///
        ///
        ///Mini market 500 yards 
        ///
        ///
        ///
        ///Super market ½ mile 
        ///
        ///
        ///
        ///Latchi Harbour 2 miles 
        ///
        ///
        ///
        ///Polis Centre 500 yards 
        ///
        ///
        ///
        ///Coral Bay 20 miles 
        ///
        ///
        ///
        ///Tombs of the Kings 25 miles 
        ///
        ///
        ///
        ///Paphos Harbour 25 miles 
        ///
        ///
        ///
        ///Paphos Airport 33 miles '
        /// </summary>
        public string UIItemCustomInnerText = @"

Beach ½ mile 



Restaurant 600 yards 



Mini market 500 yards 



Super market ½ mile 



Latchi Harbour 2 miles 



Polis Centre 500 yards 



Coral Bay 20 miles 



Tombs of the Kings 25 miles 



Paphos Harbour 25 miles 



Paphos Airport 33 miles ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIVillaPoppyPolisCypruWindow : BrowserWindow
    {
        
        public UIVillaPoppyPolisCypruWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPoppyPolisCypruDocument UIVillaPoppyPolisCypruDocument
        {
            get
            {
                if ((this.mUIVillaPoppyPolisCypruDocument == null))
                {
                    this.mUIVillaPoppyPolisCypruDocument = new UIVillaPoppyPolisCypruDocument(this);
                }
                return this.mUIVillaPoppyPolisCypruDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPoppyPolisCypruDocument mUIVillaPoppyPolisCypruDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIVillaPoppyPolisCypruDocument : HtmlDocument
    {
        
        public UIVillaPoppyPolisCypruDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Villa Poppy, Polis, Cyprus, Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/product.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/product.aspx?villaid=914";
            this.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIDvAreaPane UIDvAreaPane
        {
            get
            {
                if ((this.mUIDvAreaPane == null))
                {
                    this.mUIDvAreaPane = new UIDvAreaPane(this);
                }
                return this.mUIDvAreaPane;
            }
        }
        #endregion
        
        #region Fields
        private UIDvAreaPane mUIDvAreaPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIDvAreaPane : HtmlDiv
    {
        
        public UIDvAreaPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "dvArea";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "In this area\r\n\r\n\r\n\r\n\r\n Beach ½ mile \r\n\r\n";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"dvArea\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "152";
            this.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIItemCustom.SearchProperties["Id"] = null;
                    this.mUIItemCustom.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIItemCustom.SearchProperties["TagName"] = "UL";
                    this.mUIItemCustom.FilterProperties["Class"] = "List";
                    this.mUIItemCustom.FilterProperties["ControlDefinition"] = "class=\"List\"";
                    this.mUIItemCustom.FilterProperties["TagInstance"] = "1";
                    this.mUIItemCustom.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
                    #endregion
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIItemCustom;
        #endregion
    }
}
