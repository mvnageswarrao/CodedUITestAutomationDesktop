﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.CountryVillaList.VerifyIntroText_MapClasses
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
    public partial class VerifyIntroText_Map:logWriter
    {
        
        /// <summary>
        /// VerifyIntrotext_Method - Use 'VerifyIntrotext_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyIntrotext_Method(string IntrotextfrmDB, string CenterName)
        {
            #region Variable Declarations
            HtmlSpan uIMainContent_lblDestIPane = this.UIHttpnimbusAlgarvevilWindow.UIHttpnimbusAlgarvevilDocument.UIMainContent_lblDestIPane;
            #endregion

            const string HTML_TAG_PATTERN = "<.*?>";
           
            IntrotextfrmDB = Regex.Replace(IntrotextfrmDB, HTML_TAG_PATTERN, string.Empty);
            IntrotextfrmDB = IntrotextfrmDB.Replace("~", " ");
            //IntrotextfrmDB = IntrotextfrmDB.Replace("\r\n", string.Empty);
            //IntrotextfrmDB = IntrotextfrmDB.Trim();
            //IntrotextfrmDB = IntrotextfrmDB.Replace(" ", string.Empty);
            //IntrotextfrmDB = CenterName + IntrotextfrmDB;
            //IntrotextfrmDB = IntrotextfrmDB.Substring(0, 150);
           
            string IntroFromPage = uIMainContent_lblDestIPane.InnerText;
            IntroFromPage = IntroFromPage.Trim();
            IntroFromPage = IntroFromPage.Replace("\r\n", string.Empty);
            IntroFromPage = IntroFromPage.Replace(" ", string.Empty);
            IntroFromPage = IntroFromPage.Substring(0, 150);


            // Verify that the 'InnerText' property of 'MainContent_lblDestInfo' pane matches 'Algarve
            //
            //The Algarve's continued popularity for holidaymakers derives predominantly from its coastal location and enviable climate.
            //
            //Few places in Europe can boast a coastline so littered with bays, coves, family beaches and over 300 days sunshine per annum. Temperatures are regularly in the mid to high twenties and tempered by sea breezes. 
            //
            //The Algarve, meaning "the west" in Arabic, is also characterised by its history.'
            try
            {
                //StringAssert.Matches(uIMainContent_lblDestIPane.InnerText, new Regex(this.VerifyIntrotext_MethodExpectedValues.UIMainContent_lblDestIPaneInnerText));
                StringAssert.Equals(IntrotextfrmDB, IntroFromPage);
                WriteLogs("PASS : " + CenterName + " Introduction Text Displayed as Expected.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("VerifyIntrotext");
                WriteLogs("FAIL : " + CenterName + " Introduction Text Not Displayed as Expected.");
                WriteLogs("----------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual VerifyIntrotext_MethodExpectedValues VerifyIntrotext_MethodExpectedValues
        {
            get
            {
                if ((this.mVerifyIntrotext_MethodExpectedValues == null))
                {
                    this.mVerifyIntrotext_MethodExpectedValues = new VerifyIntrotext_MethodExpectedValues();
                }
                return this.mVerifyIntrotext_MethodExpectedValues;
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
        private VerifyIntrotext_MethodExpectedValues mVerifyIntrotext_MethodExpectedValues;
        
        private UIHttpnimbusAlgarvevilWindow mUIHttpnimbusAlgarvevilWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'VerifyIntrotext_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class VerifyIntrotext_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'MainContent_lblDestInfo' pane matches 'Algarve
        ///
        ///The Algarve's continued popularity for holidaymakers derives predominantly from its coastal location and enviable climate.
        ///
        ///Few places in Europe can boast a coastline so littered with bays, coves, family beaches and over 300 days sunshine per annum. Temperatures are regularly in the mid to high twenties and tempered by sea breezes. 
        ///
        ///The Algarve, meaning "the west" in Arabic, is also characterised by its history.'
        /// </summary>
        public string UIMainContent_lblDestIPaneInnerText = @"Algarve

The Algarve's continued popularity for holidaymakers derives predominantly from its coastal location and enviable climate.

Few places in Europe can boast a coastline so littered with bays, coves, family beaches and over 300 days sunshine per annum. Temperatures are regularly in the mid to high twenties and tempered by sea breezes. 

The Algarve, meaning ""the west"" in Arabic, is also characterised by its history.";
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
        #endregion
        
        #region Fields
        private UIHttpnimbusAlgarvevilDocument mUIHttpnimbusAlgarvevilDocument;
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
        public HtmlSpan UIMainContent_lblDestIPane
        {
            get
            {
                if ((this.mUIMainContent_lblDestIPane == null))
                {
                    this.mUIMainContent_lblDestIPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIMainContent_lblDestIPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_lblDestInfo";
                    this.mUIMainContent_lblDestIPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIMainContent_lblDestIPane.FilterProperties[HtmlDiv.PropertyNames.Title] = "";
                    this.mUIMainContent_lblDestIPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "floatleft";
                    this.mUIMainContent_lblDestIPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_lblDestInfo\" class=\"floa";
                    this.mUIMainContent_lblDestIPane.WindowTitles.Add("http://nimbus/Algarve/villas");
                    #endregion
                }
                return this.mUIMainContent_lblDestIPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIMainContent_lblDestIPane;
        #endregion
    }
}
