﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.verifyVillaTypes_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class verifyVillaTypes_Map:logWriter
    {
        
        /// <summary>
        /// verifyVillaTypes_Method - Use 'verifyVillaTypes_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyVillaTypes_Method(List<string> VillaTypes)
        {
            #region Variable Declarations
            HtmlDiv uICouplesandsmallgroupPane = this.UIVillaVelazcoInCalanFWindow.UIVillaVelazcoInCalanFDocument.UICouplesandsmallgroupPane;
            #endregion

            // Verify that the 'InnerText' property of 'Couples and small groups' pane contains '
            //Couples and small groups'
            string villaTypesWebPage = uICouplesandsmallgroupPane.InnerText.ToString();
            villaTypesWebPage = villaTypesWebPage.Replace("\r\n", string.Empty);
            villaTypesWebPage = villaTypesWebPage.Trim();
            int i = 0;
            for (i = 0; i < VillaTypes.Count; i++)
                if (villaTypesWebPage != string.Empty)
                { 
                    try
                    {
                    
                    
                        if (villaTypesWebPage.ToString().Contains(VillaTypes[i].ToString()))
                        {
                            WriteLogs("PASS : Villa Types - " + VillaTypes[i].ToString());
                        }
                        //StringAssert.Contains(uICouplesandsmallgroupPane.InnerText, this.verifyVillaTypes_MethodExpectedValues.UICouplesandsmallgroupPaneInnerText);
                    }
                    catch (Exception ex)
                    {
                        WriteLogs("FAIL : Villa Types are not Matched");
                        WriteLogs("--------" + ex.Message.ToString());
                    }
            
                }
            else
                {
                    WriteLogs("INFO : No Villa Types available for selected Villa.");
                }
            }
        

        
        #region Properties
        public virtual verifyVillaTypes_MethodExpectedValues verifyVillaTypes_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyVillaTypes_MethodExpectedValues == null))
                {
                    this.mverifyVillaTypes_MethodExpectedValues = new verifyVillaTypes_MethodExpectedValues();
                }
                return this.mverifyVillaTypes_MethodExpectedValues;
            }
        }
        
        public UIVillaVelazcoInCalanFWindow UIVillaVelazcoInCalanFWindow
        {
            get
            {
                if ((this.mUIVillaVelazcoInCalanFWindow == null))
                {
                    this.mUIVillaVelazcoInCalanFWindow = new UIVillaVelazcoInCalanFWindow();
                }
                return this.mUIVillaVelazcoInCalanFWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyVillaTypes_MethodExpectedValues mverifyVillaTypes_MethodExpectedValues;
        
        private UIVillaVelazcoInCalanFWindow mUIVillaVelazcoInCalanFWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyVillaTypes_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class verifyVillaTypes_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Couples and small groups' pane contains '
        ///Couples and small groups'
        /// </summary>
        public string UICouplesandsmallgroupPaneInnerText = "\r\nCouples and small groups";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIVillaVelazcoInCalanFWindow : BrowserWindow
    {
        
        public UIVillaVelazcoInCalanFWindow()
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
        public UIVillaVelazcoInCalanFDocument UIVillaVelazcoInCalanFDocument
        {
            get
            {
                if ((this.mUIVillaVelazcoInCalanFDocument == null))
                {
                    this.mUIVillaVelazcoInCalanFDocument = new UIVillaVelazcoInCalanFDocument(this);
                }
                return this.mUIVillaVelazcoInCalanFDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaVelazcoInCalanFDocument mUIVillaVelazcoInCalanFDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIVillaVelazcoInCalanFDocument : HtmlDocument
    {
        
        public UIVillaVelazcoInCalanFDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
        }
        
        #region Properties
        public HtmlDiv UICouplesandsmallgroupPane
        {
            get
            {
                if ((this.mUICouplesandsmallgroupPane == null))
                {
                    this.mUICouplesandsmallgroupPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUICouplesandsmallgroupPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "dvVillaTypes";
                    this.mUICouplesandsmallgroupPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "BlueBkgColor", PropertyExpressionOperator.Contains));
                    this.mUICouplesandsmallgroupPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"BlueBkgColor\" id=\"dvVillaTypes\"", PropertyExpressionOperator.Contains));
                    #endregion
                }
                return this.mUICouplesandsmallgroupPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUICouplesandsmallgroupPane;
        #endregion
    }
}
