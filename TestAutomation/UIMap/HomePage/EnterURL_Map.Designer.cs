﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.enterURL_MapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class enterURL_Map
    {
        
        /// <summary>
        /// enterURL_Method - Use 'enterURL_MethodParams' to pass parameters into this method.
        /// </summary>
        public void enterURL_Method(string strURL)
        {
            #region Variable Declarations
            BrowserWindow uIBlankPageWindowsInteWindow = this.UIBlankPageWindowsInteWindow;
            #endregion

            // Go to web page 'http://nimbus/product.aspx?villaid=275'
            //uIBlankPageWindowsInteWindow.NavigateToUrl(new System.Uri(this.enterURL_MethodParams.UIBlankPageWindowsInteWindowUrl));
            uIBlankPageWindowsInteWindow.NavigateToUrl(new System.Uri(strURL));
        }
        
        #region Properties
        public virtual enterURL_MethodParams enterURL_MethodParams
        {
            get
            {
                if ((this.menterURL_MethodParams == null))
                {
                    this.menterURL_MethodParams = new enterURL_MethodParams();
                }
                return this.menterURL_MethodParams;
            }
        }
        
        public UIBlankPageWindowsInteWindow UIBlankPageWindowsInteWindow
        {
            get
            {
                if ((this.mUIBlankPageWindowsInteWindow == null))
                {
                    this.mUIBlankPageWindowsInteWindow = new UIBlankPageWindowsInteWindow();
                }
                return this.mUIBlankPageWindowsInteWindow;
            }
        }
        #endregion
        
        #region Fields
        private enterURL_MethodParams menterURL_MethodParams;
        
        private UIBlankPageWindowsInteWindow mUIBlankPageWindowsInteWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'enterURL_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class enterURL_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://nimbus/product.aspx?villaid=275'
        /// </summary>
        public string UIBlankPageWindowsInteWindowUrl = "http://nimbus/product.aspx?villaid=914";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIBlankPageWindowsInteWindow : BrowserWindow
    {
        
        public UIBlankPageWindowsInteWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Blank Page";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Blank Page");
            this.WindowTitles.Add("http://nimbus/product.aspx?villaid=275");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
    }
}
