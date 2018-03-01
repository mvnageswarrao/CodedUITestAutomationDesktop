﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.TwitterLink_MapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class TwitterLink_Map
    {
        
        /// <summary>
        /// TwitterLink_Method - Use 'TwitterLink_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void TwitterLink_Method()
        {
            #region Variable Declarations
            WinClient uINavigationBarClient = this.UIVillaPlusVillaPlusNeWindow.UIItemWindow.UINavigationBarClient;
            #endregion

            // Verify that the 'AccessibleDescription' property of 'Navigation Bar' client equals 'twitter.com'
            Assert.AreEqual(this.TwitterLink_MethodExpectedValues.UINavigationBarClientAccessibleDescription, uINavigationBarClient.AccessibleDescription);
        }
        
        #region Properties
        public virtual TwitterLink_MethodExpectedValues TwitterLink_MethodExpectedValues
        {
            get
            {
                if ((this.mTwitterLink_MethodExpectedValues == null))
                {
                    this.mTwitterLink_MethodExpectedValues = new TwitterLink_MethodExpectedValues();
                }
                return this.mTwitterLink_MethodExpectedValues;
            }
        }
        
        public UIVillaPlusVillaPlusNeWindow UIVillaPlusVillaPlusNeWindow
        {
            get
            {
                if ((this.mUIVillaPlusVillaPlusNeWindow == null))
                {
                    this.mUIVillaPlusVillaPlusNeWindow = new UIVillaPlusVillaPlusNeWindow();
                }
                return this.mUIVillaPlusVillaPlusNeWindow;
            }
        }
        #endregion
        
        #region Fields
        private TwitterLink_MethodExpectedValues mTwitterLink_MethodExpectedValues;
        
        private UIVillaPlusVillaPlusNeWindow mUIVillaPlusVillaPlusNeWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TwitterLink_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class TwitterLink_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'AccessibleDescription' property of 'Navigation Bar' client equals 'twitter.com'
        /// </summary>
        public string UINavigationBarClientAccessibleDescription = "twitter.com";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIVillaPlusVillaPlusNeWindow : BrowserWindow
    {
        
        public UIVillaPlusVillaPlusNeWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Villa Plus (@VillaPlusNews) on Twitter";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Plus (@VillaPlusNews) on Twitter");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "AddressDisplay Control";
            this.WindowTitles.Add("Villa Plus (@VillaPlusNews) on Twitter");
            #endregion
        }
        
        #region Properties
        public WinClient UINavigationBarClient
        {
            get
            {
                if ((this.mUINavigationBarClient == null))
                {
                    this.mUINavigationBarClient = new WinClient(this);
                    #region Search Criteria
                    this.mUINavigationBarClient.WindowTitles.Add("Villa Plus (@VillaPlusNews) on Twitter");
                    #endregion
                }
                return this.mUINavigationBarClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUINavigationBarClient;
        #endregion
    }
}
