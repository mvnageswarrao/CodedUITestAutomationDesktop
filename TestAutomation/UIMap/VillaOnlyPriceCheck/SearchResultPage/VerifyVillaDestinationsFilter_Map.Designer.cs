﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchResultPage.VerifyVillaDestinationsFilter_MapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
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

    
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public partial class VerifyVillaDestinationsFilter_Map:logWriter
    {
        
        /// <summary>
        /// VerifyVillaDestinationsFilter_Method - Use 'VerifyVillaDestinationsFilter_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyVillaDestinationsFilter_Method(List<string> CentersList, List<string> VillaCountFrEachCenter)
        {
            #region Variable Declarations
            HtmlDiv uIVilladestinationCleaPane = this.UIYoursearchfound31VilWindow.UIYoursearchfound31VilDocument.UIRightContent_dvAllFiPane.UIVilladestinationCleaPane;
            #endregion

            // Verify that the 'TagName' property of 'Villa destination Clear Algarve' pane equals 'DIV'
            //Assert.AreEqual(this.VerifyVillaDestinationsFilter_MethodExpectedValues.UIVilladestinationCleaPaneTagName, uIVilladestinationCleaPane.TagName);

            string TxtFrmPage = uIVilladestinationCleaPane.InnerText;
            TxtFrmPage = TxtFrmPage.Replace("\r\n", string.Empty);
            TxtFrmPage = TxtFrmPage.Replace("Villa destination", string.Empty).Trim();
            int i = 0;
            
                for (i = 0; i < CentersList.Count; i++)
                {
                    try
                    {           
                        string TxtFrmDB = CentersList[i].ToString() + " (" + VillaCountFrEachCenter[i].ToString() + ")".Trim();
                        StringAssert.Contains(TxtFrmPage, TxtFrmDB);
                        WriteLogs("PASS : Center Name : " + CentersList[i] + " And Villa Count: " + VillaCountFrEachCenter[i] + " is Matched with DB.");
                    }
                    catch (AssertFailedException ex)
                    {
                        WriteLogs("PASS : Center Name : " + CentersList[i] + " And Villa Count: " + VillaCountFrEachCenter[i] + " is NOT Matched with DB.");
                        WriteLogs("----------" + ex.Message.ToString());
                    }       
            }

                


            //foreach (KeyValuePair<String,string> Record in hashtable)
            //{
            //  String test=  Record.Key;
            //    if((Record.Key + Record.Value).Contains(TxtFrmPage.ToString().Trim()))
            //    {
            //        WriteLogs("PASS : " + Record.Key + " is as Expected = " + Record.Key);
            //    }
            //    else
            //    {
            //        WriteLogs("FAIL : " + Record.Key + " is Not as Expected = " + Record.Key);
            //    }
            //}
                       
        }
        
        #region Properties
        public virtual VerifyVillaDestinationsFilter_MethodExpectedValues VerifyVillaDestinationsFilter_MethodExpectedValues
        {
            get
            {
                if ((this.mVerifyVillaDestinationsFilter_MethodExpectedValues == null))
                {
                    this.mVerifyVillaDestinationsFilter_MethodExpectedValues = new VerifyVillaDestinationsFilter_MethodExpectedValues();
                }
                return this.mVerifyVillaDestinationsFilter_MethodExpectedValues;
            }
        }
        
        public UIYoursearchfound31VilWindow UIYoursearchfound31VilWindow
        {
            get
            {
                if ((this.mUIYoursearchfound31VilWindow == null))
                {
                    this.mUIYoursearchfound31VilWindow = new UIYoursearchfound31VilWindow();
                }
                return this.mUIYoursearchfound31VilWindow;
            }
        }
        #endregion
        
        #region Fields
        private VerifyVillaDestinationsFilter_MethodExpectedValues mVerifyVillaDestinationsFilter_MethodExpectedValues;
        
        private UIYoursearchfound31VilWindow mUIYoursearchfound31VilWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'VerifyVillaDestinationsFilter_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class VerifyVillaDestinationsFilter_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'TagName' property of 'Villa destination Clear Algarve' pane equals 'DIV'
        /// </summary>
        public string UIVilladestinationCleaPaneTagName = "DIV";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIYoursearchfound31VilWindow : BrowserWindow
    {
        
        public UIYoursearchfound31VilWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found ", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 31 Villa holidays");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound31VilDocument UIYoursearchfound31VilDocument
        {
            get
            {
                if ((this.mUIYoursearchfound31VilDocument == null))
                {
                    this.mUIYoursearchfound31VilDocument = new UIYoursearchfound31VilDocument(this);
                }
                return this.mUIYoursearchfound31VilDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound31VilDocument mUIYoursearchfound31VilDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIYoursearchfound31VilDocument : HtmlDocument
    {
        
        public UIYoursearchfound31VilDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found ", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "searchresult.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 31 Villa holidays");
            #endregion
        }
        
        #region Properties
        public UIRightContent_dvAllFiPane UIRightContent_dvAllFiPane
        {
            get
            {
                if ((this.mUIRightContent_dvAllFiPane == null))
                {
                    this.mUIRightContent_dvAllFiPane = new UIRightContent_dvAllFiPane(this);
                }
                return this.mUIRightContent_dvAllFiPane;
            }
        }
        #endregion
        
        #region Fields
        private UIRightContent_dvAllFiPane mUIRightContent_dvAllFiPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIRightContent_dvAllFiPane : HtmlDiv
    {
        
        public UIRightContent_dvAllFiPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "rightContent_dvAllFilterCol";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Refine by: \r\n Clear All", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"rightContent_dvAllFilterCol\"";
            this.WindowTitles.Add("Your search found 31 Villa holidays");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIVilladestinationCleaPane
        {
            get
            {
                if ((this.mUIVilladestinationCleaPane == null))
                {
                    this.mUIVilladestinationCleaPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIVilladestinationCleaPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Villa destination\r\n   Clear", PropertyExpressionOperator.Contains));
                    this.mUIVilladestinationCleaPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "column ";
                    this.mUIVilladestinationCleaPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"column \"";
                    this.mUIVilladestinationCleaPane.WindowTitles.Add("Your search found 31 Villa holidays");
                    #endregion
                }
                return this.mUIVilladestinationCleaPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIVilladestinationCleaPane;
        #endregion
    }
}
