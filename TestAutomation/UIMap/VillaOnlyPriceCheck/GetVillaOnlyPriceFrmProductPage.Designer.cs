﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.VillaOnlyPriceCheck.GetVillaOnlyPriceFrmProductPage_mapclasses
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
    public partial class GetVillaOnlyPriceFrmProductPage_map:logWriter
    {
        
        /// <summary>
        /// GetVillaOnlyPriceFrmProductPage_Method - Use 'GetVillaOnlyPriceFrmProductPage_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void GetVillaOnlyPriceFrmProductPage_Method(string villaOnlyPricefromDB, string villanameweb)
        {
            #region Variable Declarations
            HtmlDiv uIVillaonlyTotal569Pane = this.UIVillaTamarellInCalanWindow.UIVillaTamarellInCalanDocument.UIVillaonlyTotal569Pane;
            #endregion

            // Verify that the 'InnerText' property of 'Villa only Total = £569' pane contains '
            //
            //Villa only
            //Total = £569
            //
            // '
          //  StringAssert.Contains(uIVillaonlyTotal569Pane.InnerText, this.GetVillaOnlyPriceFrmProductPage_MethodExpectedValues.UIVillaonlyTotal569PaneInnerText);
            try
            {
              
                string VOPriceProdPAge = uIVillaonlyTotal569Pane.InnerText;
                VOPriceProdPAge = VOPriceProdPAge.Split('£')[1].ToString();
                VOPriceProdPAge = VOPriceProdPAge.Trim();
                StringAssert.Contains(VOPriceProdPAge, villaOnlyPricefromDB);
                WriteLogs("PASS: Villa Only Price from product Page:  " + VOPriceProdPAge + " is matched with  Villa Only Price from DB: " + villaOnlyPricefromDB + " ");
                WriteLogs("-------------------------------------------------------------------");

            }
            catch (AssertFailedException ex)
            {
              
                WriteLogs("FAIL : Price didn't Matched for  \"" + villanameweb + "\" from DB and product page.");
                WriteLogs("FAIL:-----------------" + ex.Message.ToString());
                WriteLogs("-------------------------------------------------");
            }
        }
        
        #region Properties
        public virtual GetVillaOnlyPriceFrmProductPage_MethodExpectedValues GetVillaOnlyPriceFrmProductPage_MethodExpectedValues
        {
            get
            {
                if ((this.mGetVillaOnlyPriceFrmProductPage_MethodExpectedValues == null))
                {
                    this.mGetVillaOnlyPriceFrmProductPage_MethodExpectedValues = new GetVillaOnlyPriceFrmProductPage_MethodExpectedValues();
                }
                return this.mGetVillaOnlyPriceFrmProductPage_MethodExpectedValues;
            }
        }
        
        public UIVillaTamarellInCalanWindow UIVillaTamarellInCalanWindow
        {
            get
            {
                if ((this.mUIVillaTamarellInCalanWindow == null))
                {
                    this.mUIVillaTamarellInCalanWindow = new UIVillaTamarellInCalanWindow();
                }
                return this.mUIVillaTamarellInCalanWindow;
            }
        }
        #endregion
        
        #region Fields
        private GetVillaOnlyPriceFrmProductPage_MethodExpectedValues mGetVillaOnlyPriceFrmProductPage_MethodExpectedValues;
        
        private UIVillaTamarellInCalanWindow mUIVillaTamarellInCalanWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'GetVillaOnlyPriceFrmProductPage_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class GetVillaOnlyPriceFrmProductPage_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Villa only Total = £569' pane contains '
        ///
        ///Villa only
        ///Total = £569
        ///
        /// '
        /// </summary>
        public string UIVillaonlyTotal569PaneInnerText = "\r\n\r\nVilla only\r\nTotal = £569\r\n\r\n ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaTamarellInCalanWindow : BrowserWindow
    {
        
        public UIVillaTamarellInCalanWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Villa Tamarell In Calan Bosch, Menorca | Villa Plus";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Tamarell In Calan Bosch, Menorca | Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaTamarellInCalanDocument UIVillaTamarellInCalanDocument
        {
            get
            {
                if ((this.mUIVillaTamarellInCalanDocument == null))
                {
                    this.mUIVillaTamarellInCalanDocument = new UIVillaTamarellInCalanDocument(this);
                }
                return this.mUIVillaTamarellInCalanDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaTamarellInCalanDocument mUIVillaTamarellInCalanDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaTamarellInCalanDocument : HtmlDocument
    {
        
        public UIVillaTamarellInCalanDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Villa Tamarell In Calan Bosch, Menorca | Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/menorca/villas/calan-bosch/villa-tamarell";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://staging1.villaplus.com/menorca/villas/calan-bosch/villa-tamarell";
            this.WindowTitles.Add("Villa Tamarell In Calan Bosch, Menorca | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIVillaonlyTotal569Pane
        {
            get
            {
                if ((this.mUIVillaonlyTotal569Pane == null))
                {
                    this.mUIVillaonlyTotal569Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIVillaonlyTotal569Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_villaPriceLayer_divVOPriceLayer";
                    this.mUIVillaonlyTotal569Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIVillaonlyTotal569Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Villa only\r\nTotal = £569\r\n\r\n ";
                    this.mUIVillaonlyTotal569Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIVillaonlyTotal569Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIVillaonlyTotal569Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_villaPriceLayer_divVOPriceLayer\"";
                    this.mUIVillaonlyTotal569Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "263";
                    this.mUIVillaonlyTotal569Pane.WindowTitles.Add("Villa Tamarell In Calan Bosch, Menorca | Villa Plus");
                    #endregion
                }
                return this.mUIVillaonlyTotal569Pane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIVillaonlyTotal569Pane;
        #endregion
    }
}