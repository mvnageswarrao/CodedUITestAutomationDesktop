﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.verifyNoOfImages_MapClasses
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
    public partial class verifyNoOfImages_Map:logWriter
    {
        
        /// <summary>
        /// verifyNoOfImages_Method - Use 'verifyNoOfImages_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyNoOfImages_Method(string CountImage)
        {
            #region Variable Declarations
            HtmlSpan uIItem13to21photosPane1 = this.UIVillaPoppyPolisCypruWindow.UIVillaPoppyPolisCypruDocument.UIItem13to21photosPane.UIItem13to21photosPane1;
            #endregion

            // Verify that the 'InnerText' property of '13 to 21 photos' pane equals '14 to 21 photos'
            //Assert.AreEqual(this.verifyNoOfImages_MethodExpectedValues.UIItem13to21photosPane1InnerText, uIItem13to21photosPane1.InnerText);

            // Verify that the 'InnerText' property of '13 to 21 photos' pane contains '14 to 21 photos'
            //StringAssert.Contains(uIItem13to21photosPane1.InnerText, this.verifyNoOfImages_MethodExpectedValues.UIItem13to21photosPane1InnerText1);
            string pagePhotoCount = null;

            string[] pagePhotoCountArr = new string[]{};
            pagePhotoCount = uIItem13to21photosPane1.InnerText.ToString();
            pagePhotoCountArr = pagePhotoCount.Split(' ');
            pagePhotoCount = pagePhotoCountArr[2];
            try
            {
                StringAssert.Equals(pagePhotoCount, CountImage);
                WriteLogs("PASS : Photo Panel - No Of Images - " + CountImage);
            }
            catch(AssertFailedException ex)
            {
                WriteLogs("FAIL : Photo Panel - No Of Images - " + CountImage);
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyNoOfImages_MethodExpectedValues verifyNoOfImages_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyNoOfImages_MethodExpectedValues == null))
                {
                    this.mverifyNoOfImages_MethodExpectedValues = new verifyNoOfImages_MethodExpectedValues();
                }
                return this.mverifyNoOfImages_MethodExpectedValues;
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
        private verifyNoOfImages_MethodExpectedValues mverifyNoOfImages_MethodExpectedValues;
        
        private UIVillaPoppyPolisCypruWindow mUIVillaPoppyPolisCypruWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyNoOfImages_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class verifyNoOfImages_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of '13 to 21 photos' pane equals '14 to 21 photos'
        /// </summary>
        public string UIItem13to21photosPane1InnerText = "14 to 21 photos";
        
        /// <summary>
        /// Verify that the 'InnerText' property of '13 to 21 photos' pane contains '14 to 21 photos'
        /// </summary>
        public string UIItem13to21photosPane1InnerText1 = "14 to 21 photos";
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
        public UIItem13to21photosPane UIItem13to21photosPane
        {
            get
            {
                if ((this.mUIItem13to21photosPane == null))
                {
                    this.mUIItem13to21photosPane = new UIItem13to21photosPane(this);
                }
                return this.mUIItem13to21photosPane;
            }
        }
        #endregion
        
        #region Fields
        private UIItem13to21photosPane mUIItem13to21photosPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIItem13to21photosPane : HtmlDiv
    {
        
        public UIItem13to21photosPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_imgSlider_screen";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n13 to 21 photos";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "screen";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"left: 0px; width: 585px; height: ";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "13";
            this.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UIItem13to21photosPane1
        {
            get
            {
                if ((this.mUIItem13to21photosPane1 == null))
                {
                    this.mUIItem13to21photosPane1 = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIItem13to21photosPane1.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIItem13to21photosPane1.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIItem13to21photosPane1.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "13 to 21 photos";
                    this.mUIItem13to21photosPane1.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIItem13to21photosPane1.FilterProperties[HtmlDiv.PropertyNames.Class] = "img-counter";
                    this.mUIItem13to21photosPane1.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"img-counter\"";
                    this.mUIItem13to21photosPane1.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "1";
                    this.mUIItem13to21photosPane1.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
                    #endregion
                }
                return this.mUIItem13to21photosPane1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIItem13to21photosPane1;
        #endregion
    }
}
