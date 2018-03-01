﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.verifyDescKeyNotes_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class verifyDescKeyNotes_Map:logWriter
    {
        
        /// <summary>
        /// verifyDescKeyNotes_Method - Use 'verifyDescKeyNotes_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyDescKeyNotes_Method(List<string> keyNotes)
        {
            #region Variable Declarations
            HtmlDiv uIMainContent_dvKeyNotPane = this.UIVillaHesperaInTrapezWindow.UIVillaHesperaInTrapezDocument.UIMainContent_dvKeyNotPane;
            #endregion

            string keyNotesText = uIMainContent_dvKeyNotPane.InnerText;
            keyNotesText = keyNotesText.Replace("Key notes", "");
            keyNotesText = keyNotesText.Replace("\r\n", string.Empty);
            keyNotesText = keyNotesText.Trim();
            //keyNotesText = keyNotesText.Replace(" ",string.Empty);
            int i = 0;
            //bool found = false;
            for (i = 0; i < keyNotes.Count; i++)
            {
                try
                { 
                //if (keyNotes[i].ToString().Trim().Contains(keyNotesText.ToString()))
                if ((keyNotesText.ToString().Contains(keyNotes[i].ToString().Trim())))
                WriteLogs("PASS : Description Key Notes - " + keyNotes[i].ToString().Trim());
                }
            
            catch(AssertFailedException ex)
            {
                WriteLogs("FAIL : Description Key Notes - " + keyNotes[i].ToString().Trim());
                WriteLogs("------------" + ex.Message.ToString());
            }
            }

            // Verify that the 'InnerText' property of 'MainContent_dvKeyNotes' pane contains 'Key notes
            //
            //Villa Plus In-Resort Service   
            //Mid Week Towel Change & Light Clean   
            //Bed Linen   
            //Bathroom Towels   
            //Iron & Ironing Board   
            //Villa check in time from 13:00    
            //Villa check out time 10:00    '
            //StringAssert.Contains(uIMainContent_dvKeyNotPane.InnerText, this.verifyDescKeyNotes_MethodExpectedValues.UIMainContent_dvKeyNotPaneInnerText);
        }
        
        #region Properties
        public virtual verifyDescKeyNotes_MethodExpectedValues verifyDescKeyNotes_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyDescKeyNotes_MethodExpectedValues == null))
                {
                    this.mverifyDescKeyNotes_MethodExpectedValues = new verifyDescKeyNotes_MethodExpectedValues();
                }
                return this.mverifyDescKeyNotes_MethodExpectedValues;
            }
        }
        
        public UIVillaHesperaInTrapezWindow UIVillaHesperaInTrapezWindow
        {
            get
            {
                if ((this.mUIVillaHesperaInTrapezWindow == null))
                {
                    this.mUIVillaHesperaInTrapezWindow = new UIVillaHesperaInTrapezWindow();
                }
                return this.mUIVillaHesperaInTrapezWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyDescKeyNotes_MethodExpectedValues mverifyDescKeyNotes_MethodExpectedValues;
        
        private UIVillaHesperaInTrapezWindow mUIVillaHesperaInTrapezWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyDescKeyNotes_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyDescKeyNotes_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'MainContent_dvKeyNotes' pane contains 'Key notes
        ///
        ///Villa Plus In-Resort Service   
        ///Mid Week Towel Change & Light Clean   
        ///Bed Linen   
        ///Bathroom Towels   
        ///Iron & Ironing Board   
        ///Villa check in time from 13:00    
        ///Villa check out time 10:00    '
        /// </summary>
        public string UIMainContent_dvKeyNotPaneInnerText = "Key notes\r\n\r\nVilla Plus In-Resort Service   \r\nMid Week Towel Change & Light Clean" +
            "   \r\nBed Linen   \r\nBathroom Towels   \r\nIron & Ironing Board   \r\nVilla check in t" +
            "ime from 13:00    \r\nVilla check out time 10:00    ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaHesperaInTrapezWindow : BrowserWindow
    {
        
        public UIVillaHesperaInTrapezWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaHesperaInTrapezDocument UIVillaHesperaInTrapezDocument
        {
            get
            {
                if ((this.mUIVillaHesperaInTrapezDocument == null))
                {
                    this.mUIVillaHesperaInTrapezDocument = new UIVillaHesperaInTrapezDocument(this);
                }
                return this.mUIVillaHesperaInTrapezDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaHesperaInTrapezDocument mUIVillaHesperaInTrapezDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaHesperaInTrapezDocument : HtmlDocument
    {
        
        public UIVillaHesperaInTrapezDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIMainContent_dvKeyNotPane
        {
            get
            {
                if ((this.mUIMainContent_dvKeyNotPane == null))
                {
                    this.mUIMainContent_dvKeyNotPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIMainContent_dvKeyNotPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_dvKeyNotes";
                    this.mUIMainContent_dvKeyNotPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Key notes", PropertyExpressionOperator.Contains));
                    this.mUIMainContent_dvKeyNotPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_dvKeyNotes\"";
                    #endregion
                }
                return this.mUIMainContent_dvKeyNotPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIMainContent_dvKeyNotPane;
        #endregion
    }
}
