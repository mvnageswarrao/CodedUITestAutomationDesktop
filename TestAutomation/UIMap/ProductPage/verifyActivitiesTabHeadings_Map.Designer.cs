﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.verifyActivitiesTabHeadings_MapClasses
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
    public partial class verifyActivitiesTabHeadings_Map:logWriter
    {
        
        /// <summary>
        /// verifyActivitiesTabHeadings_Method - Use 'verifyActivitiesTabHeadings_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyActivitiesTabHeadings_Method(List<string> activityHeadings)
        {
            #region Variable Declarations
           
            HtmlSpan uIBoattripsPane = this.UIVillaBellinaInAgiosSWindow.UIVillaBellinaInAgiosSDocument.UIBoattripsPane;
            #endregion

            UITestControlCollection ui = uIBoattripsPane.FindMatchingControls();
            //Boolean recordexist=true;
            String message = String.Empty;

            foreach (HtmlSpan ActvitviesHeading in ui)
            {
                bool found = false;
                for(int i=0;i<activityHeadings.Count ;i++)
                {
                    if(activityHeadings[i].ToString().Contains(ActvitviesHeading.InnerText.ToString().Trim()))
                    {
                        found = true;
                        break;
                    }
                }
                if(found == true)
                {
                    WriteLogs("PASS : Activity Heading - " + ActvitviesHeading.InnerText.ToString().Trim());
                }
                else
                {
                    WriteLogs("FAIL : Activity Heading - Not Present - " + ActvitviesHeading.InnerText.ToString().Trim());
                }
            }                                   
        }
  
            // Verify that the 'InnerText' property of 'Boat trips' pane contains 'Boat trips'
            //StringAssert.Contains(uIBoattripsPane.InnerText, this.verifyActivitiesTabHeadings_MethodExpectedValues.UIBoattripsPaneInnerText);
  
        
        #region Properties
        public virtual verifyActivitiesTabHeadings_MethodExpectedValues verifyActivitiesTabHeadings_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyActivitiesTabHeadings_MethodExpectedValues == null))
                {
                    this.mverifyActivitiesTabHeadings_MethodExpectedValues = new verifyActivitiesTabHeadings_MethodExpectedValues();
                }
                return this.mverifyActivitiesTabHeadings_MethodExpectedValues;
            }
        }
        
        public UIVillaBellinaInAgiosSWindow UIVillaBellinaInAgiosSWindow
        {
            get
            {
                if ((this.mUIVillaBellinaInAgiosSWindow == null))
                {
                    this.mUIVillaBellinaInAgiosSWindow = new UIVillaBellinaInAgiosSWindow();
                }
                return this.mUIVillaBellinaInAgiosSWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyActivitiesTabHeadings_MethodExpectedValues mverifyActivitiesTabHeadings_MethodExpectedValues;
        
        private UIVillaBellinaInAgiosSWindow mUIVillaBellinaInAgiosSWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyActivitiesTabHeadings_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyActivitiesTabHeadings_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Boat trips' pane contains 'Boat trips'
        /// </summary>
        public string UIBoattripsPaneInnerText = "Boat trips";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaBellinaInAgiosSWindow : BrowserWindow
    {
        
        public UIVillaBellinaInAgiosSWindow()
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
        public UIVillaBellinaInAgiosSDocument UIVillaBellinaInAgiosSDocument
        {
            get
            {
                if ((this.mUIVillaBellinaInAgiosSDocument == null))
                {
                    this.mUIVillaBellinaInAgiosSDocument = new UIVillaBellinaInAgiosSDocument(this);
                }
                return this.mUIVillaBellinaInAgiosSDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaBellinaInAgiosSDocument mUIVillaBellinaInAgiosSDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaBellinaInAgiosSDocument : HtmlDocument
    {
        
        public UIVillaBellinaInAgiosSDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            #endregion
        }
        
        #region Properties
        public HtmlSpan UIBoattripsPane
        {
            get
            {
                if ((this.mUIBoattripsPane == null))
                {
                    this.mUIBoattripsPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIBoattripsPane.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "MainContent_ListActivities_lblFullName_", PropertyExpressionOperator.Contains));
                    this.mUIBoattripsPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "ActivityName";
                    this.mUIBoattripsPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"ActivityName\"", PropertyExpressionOperator.Contains));
                    #endregion
                }
                return this.mUIBoattripsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIBoattripsPane;
        #endregion
    }
}
