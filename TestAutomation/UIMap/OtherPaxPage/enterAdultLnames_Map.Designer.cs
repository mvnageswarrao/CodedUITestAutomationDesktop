﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.OtherPaxPage.enterAdultLnames_MapClasses
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
    public partial class enterAdultLnames_Map
    {
        
        /// <summary>
        /// enterAdultLnames_Method - Use 'enterAdultLnames_MethodParams' to pass parameters into this method.
        /// </summary>
        public void enterAdultLnames_Method()
        {
            #region Variable Declarations
            HtmlEdit uITxtAdultLNameEdit = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtAdultLNameEdit;
            #endregion

            // Type 'Test LName' in 'txtAdultLName' text box
            uITxtAdultLNameEdit.Text = this.enterAdultLnames_MethodParams.UITxtAdultLNameEditText;
        }

        public HtmlEdit getAdultLnames_Method()
        {
            #region Variable Declarations
            HtmlEdit uITxtAdultLNameEdit = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtAdultLNameEdit;
            return uITxtAdultLNameEdit;
            #endregion
        }
        
        #region Properties
        public virtual enterAdultLnames_MethodParams enterAdultLnames_MethodParams
        {
            get
            {
                if ((this.menterAdultLnames_MethodParams == null))
                {
                    this.menterAdultLnames_MethodParams = new enterAdultLnames_MethodParams();
                }
                return this.menterAdultLnames_MethodParams;
            }
        }
        
        public UIOtherPassengersDetaiWindow UIOtherPassengersDetaiWindow
        {
            get
            {
                if ((this.mUIOtherPassengersDetaiWindow == null))
                {
                    this.mUIOtherPassengersDetaiWindow = new UIOtherPassengersDetaiWindow();
                }
                return this.mUIOtherPassengersDetaiWindow;
            }
        }
        #endregion
        
        #region Fields
        private enterAdultLnames_MethodParams menterAdultLnames_MethodParams;
        
        private UIOtherPassengersDetaiWindow mUIOtherPassengersDetaiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'enterAdultLnames_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class enterAdultLnames_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Test LName' in 'txtAdultLName' text box
        /// </summary>
        public string UITxtAdultLNameEditText = "Test LName";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOtherPassengersDetaiWindow : BrowserWindow
    {
        
        public UIOtherPassengersDetaiWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Other Passengers Details", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Other Passengers Details");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIOtherPassengersDetaiDocument UIOtherPassengersDetaiDocument
        {
            get
            {
                if ((this.mUIOtherPassengersDetaiDocument == null))
                {
                    this.mUIOtherPassengersDetaiDocument = new UIOtherPassengersDetaiDocument(this);
                }
                return this.mUIOtherPassengersDetaiDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIOtherPassengersDetaiDocument mUIOtherPassengersDetaiDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOtherPassengersDetaiDocument : HtmlDocument
    {
        
        public UIOtherPassengersDetaiDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Other Passengers Details", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/allocatePax.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/allocatePax.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Other Passengers Details");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UITxtAdultLNameEdit
        {
            get
            {
                if ((this.mUITxtAdultLNameEdit == null))
                {
                    this.mUITxtAdultLNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtAdultLNameEdit.SearchProperties.Add(new PropertyExpression(HtmlEdit.PropertyNames.Id, "txtAdultLName", PropertyExpressionOperator.Contains));
                    this.mUITxtAdultLNameEdit.SearchProperties.Add(new PropertyExpression(HtmlEdit.PropertyNames.Name, "$txtAdultLName", PropertyExpressionOperator.Contains));
                    this.mUITxtAdultLNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtAdultLNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "greyText";
                    this.mUITxtAdultLNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUITxtAdultLNameEdit.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUITxtAdultLNameEdit;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUITxtAdultLNameEdit;
        #endregion
    }
}