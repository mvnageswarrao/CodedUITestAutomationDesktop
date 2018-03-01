﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.VerifyVillaPlusLogo_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public partial class VerifyVillaPlusLogo_Map:logWriter
    {
        
        /// <summary>
        /// VerifyVillaPlusLogo_Method - Use 'VerifyVillaPlusLogo_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyVillaPlusLogo_Method()
        {
            #region Variable Declarations
            HtmlImage uIHolidayVillaswithPriImage = this.UIVillaHolidaysandVillWindow.UIVillaHolidaysandVillDocument.UIHolidayVillaswithPriImage;
            #endregion

            try
            {
                // Verify that the 'Alt' property of 'Holiday Villas with Private Pools to rent in Algar...' image equals 'Holiday Villas with Private Pools to rent in Algarve, Cyprus, Corfu, Kefalonia, Crete, Rhodes, Costa del Sol, Costa Blanca, Menorca, Mallorca, Fuerteventura, Lanzarote, Tenerife'
                Assert.AreEqual(this.VerifyVillaPlusLogo_MethodExpectedValues.UIHolidayVillaswithPriImageAlt, uIHolidayVillaswithPriImage.Alt);

                // Verify that the 'Title' property of 'Holiday Villas with Private Pools to rent in Algar...' image equals 'Holiday Villas with Private Pools to rent in Algarve, Cyprus, Corfu, Kefalonia, Crete, Rhodes, Costa del Sol, Costa Blanca, Menorca, Mallorca, Fuerteventura, Lanzarote, Tenerife'
                Assert.AreEqual(this.VerifyVillaPlusLogo_MethodExpectedValues.UIHolidayVillaswithPriImageTitle, uIHolidayVillaswithPriImage.Title);
                WriteLogs("PASS : Verify Villa Plus Logo.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Verify Villa Plus Logo.");
                WriteLogs("-----" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual VerifyVillaPlusLogo_MethodExpectedValues VerifyVillaPlusLogo_MethodExpectedValues
        {
            get
            {
                if ((this.mVerifyVillaPlusLogo_MethodExpectedValues == null))
                {
                    this.mVerifyVillaPlusLogo_MethodExpectedValues = new VerifyVillaPlusLogo_MethodExpectedValues();
                }
                return this.mVerifyVillaPlusLogo_MethodExpectedValues;
            }
        }
        
        public UIVillaHolidaysandVillWindow UIVillaHolidaysandVillWindow
        {
            get
            {
                if ((this.mUIVillaHolidaysandVillWindow == null))
                {
                    this.mUIVillaHolidaysandVillWindow = new UIVillaHolidaysandVillWindow();
                }
                return this.mUIVillaHolidaysandVillWindow;
            }
        }
        #endregion
        
        #region Fields
        private VerifyVillaPlusLogo_MethodExpectedValues mVerifyVillaPlusLogo_MethodExpectedValues;
        
        private UIVillaHolidaysandVillWindow mUIVillaHolidaysandVillWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'VerifyVillaPlusLogo_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class VerifyVillaPlusLogo_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Alt' property of 'Holiday Villas with Private Pools to rent in Algar...' image equals 'Holiday Villas with Private Pools to rent in Algarve, Cyprus, Corfu, Kefalonia, Crete, Rhodes, Costa del Sol, Costa Blanca, Menorca, Mallorca, Fuerteventura, Lanzarote, Tenerife'
        /// </summary>
        public string UIHolidayVillaswithPriImageAlt = "Holiday Villas with Private Pools to rent in Algarve, Cyprus, Corfu, Kefalonia, C" +
            "rete, Rhodes, Costa del Sol, Costa Blanca, Menorca, Mallorca, Fuerteventura, Lan" +
            "zarote, Tenerife";
        
        /// <summary>
        /// Verify that the 'Title' property of 'Holiday Villas with Private Pools to rent in Algar...' image equals 'Holiday Villas with Private Pools to rent in Algarve, Cyprus, Corfu, Kefalonia, Crete, Rhodes, Costa del Sol, Costa Blanca, Menorca, Mallorca, Fuerteventura, Lanzarote, Tenerife'
        /// </summary>
        public string UIHolidayVillaswithPriImageTitle = "Holiday Villas with Private Pools to rent in Algarve, Cyprus, Corfu, Kefalonia, C" +
            "rete, Rhodes, Costa del Sol, Costa Blanca, Menorca, Mallorca, Fuerteventura, Lan" +
            "zarote, Tenerife";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIVillaHolidaysandVillWindow : BrowserWindow
    {
        
        public UIVillaHolidaysandVillWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Villa Holidays and Villas with Private Pools - VillaPlus.com";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Holidays and Villas with Private Pools - VillaPlus.com");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaHolidaysandVillDocument UIVillaHolidaysandVillDocument
        {
            get
            {
                if ((this.mUIVillaHolidaysandVillDocument == null))
                {
                    this.mUIVillaHolidaysandVillDocument = new UIVillaHolidaysandVillDocument(this);
                }
                return this.mUIVillaHolidaysandVillDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaHolidaysandVillDocument mUIVillaHolidaysandVillDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIVillaHolidaysandVillDocument : HtmlDocument
    {
        
        public UIVillaHolidaysandVillDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Villa Holidays and Villas with Private Pools - VillaPlus.com";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays and Villas with Private Pools - VillaPlus.com");
            #endregion
        }
        
        #region Properties
        public HtmlImage UIHolidayVillaswithPriImage
        {
            get
            {
                if ((this.mUIHolidayVillaswithPriImage == null))
                {
                    this.mUIHolidayVillaswithPriImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIHolidayVillaswithPriImage.SearchProperties[HtmlImage.PropertyNames.Id] = "ImgSiteLogo";
                    this.mUIHolidayVillaswithPriImage.SearchProperties[HtmlImage.PropertyNames.Name] = null;
                    this.mUIHolidayVillaswithPriImage.SearchProperties[HtmlImage.PropertyNames.Alt] = "Holiday Villas with Private Pools to rent in Algarve, Cyprus, Corfu, Kefalonia, C" +
                        "rete, Rhodes, Costa del Sol, Costa Blanca, Menorca, Mallorca, Fuerteventura, Lan" +
                        "zarote, Tenerife";
                    this.mUIHolidayVillaswithPriImage.FilterProperties[HtmlImage.PropertyNames.AbsolutePath] = "/imgs/common/vpLogo.jpg";
                    this.mUIHolidayVillaswithPriImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/imgs/common/vpLogo.jpg", PropertyExpressionOperator.Contains));
                    this.mUIHolidayVillaswithPriImage.FilterProperties[HtmlImage.PropertyNames.Class] = "";
                    this.mUIHolidayVillaswithPriImage.FilterProperties[HtmlImage.PropertyNames.ControlDefinition] = "style=\"margin-left: 0px;\" id=\"ImgSiteLog";
                    this.mUIHolidayVillaswithPriImage.FilterProperties[HtmlImage.PropertyNames.TagInstance] = "2";
                    this.mUIHolidayVillaswithPriImage.WindowTitles.Add("Villa Holidays and Villas with Private Pools - VillaPlus.com");
                    #endregion
                }
                return this.mUIHolidayVillaswithPriImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIHolidayVillaswithPriImage;
        #endregion
    }
}