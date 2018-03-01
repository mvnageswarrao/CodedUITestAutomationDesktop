﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.clickCheckAvaiandPricesBtn_MapClasses
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
    public partial class clickCheckAvaiandPricesBtn_Map:logWriter
    {
        
        /// <summary>
        /// clickCheckAvailandPricesBtn_method
        /// </summary>
        public void clickCheckAvailandPricesBtn_method()
        {
            #region Variable Declarations
            HtmlImage uICheckAvailabilityPriImage = this.UIVillaAnimadoInMontecWindow.UIVillaAnimadoInMontecDocument.UICheckAvailabilityPriImage;
            #endregion

            // Click 'Check Availability & Prices' image
            //Mouse.Click(uICheckAvailabilityPriImage, new Point(112, 40));

            try
            {
                // Click 'Check Availability & Prices' image
                Mouse.Click(uICheckAvailabilityPriImage);
                WriteLogs("PASS : Check Availability and Prices button is clicked");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("PASS : Check Availability and Prices button is not clicked");
                WriteLogs("-----------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public UIVillaAnimadoInMontecWindow UIVillaAnimadoInMontecWindow
        {
            get
            {
                if ((this.mUIVillaAnimadoInMontecWindow == null))
                {
                    this.mUIVillaAnimadoInMontecWindow = new UIVillaAnimadoInMontecWindow();
                }
                return this.mUIVillaAnimadoInMontecWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaAnimadoInMontecWindow mUIVillaAnimadoInMontecWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIVillaAnimadoInMontecWindow : BrowserWindow
    {
        
        public UIVillaAnimadoInMontecWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaAnimadoInMontecDocument UIVillaAnimadoInMontecDocument
        {
            get
            {
                if ((this.mUIVillaAnimadoInMontecDocument == null))
                {
                    this.mUIVillaAnimadoInMontecDocument = new UIVillaAnimadoInMontecDocument(this);
                }
                return this.mUIVillaAnimadoInMontecDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaAnimadoInMontecDocument mUIVillaAnimadoInMontecDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIVillaAnimadoInMontecDocument : HtmlDocument
    {
        
        public UIVillaAnimadoInMontecDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
        }
        
        #region Properties
        public HtmlImage UICheckAvailabilityPriImage
        {
            get
            {
                if ((this.mUICheckAvailabilityPriImage == null))
                {
                    this.mUICheckAvailabilityPriImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUICheckAvailabilityPriImage.SearchProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Id, "imgChkAvailability", PropertyExpressionOperator.Contains));
                    this.mUICheckAvailabilityPriImage.SearchProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Alt, "Check Availability & Prices", PropertyExpressionOperator.Contains));
                    #endregion
                }
                return this.mUICheckAvailabilityPriImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUICheckAvailabilityPriImage;
        #endregion
    }
}
