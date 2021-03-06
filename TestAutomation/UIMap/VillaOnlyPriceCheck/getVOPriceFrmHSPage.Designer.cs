﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.VillaOnlyPriceCheck.getVOPriceFrmHSPage_MapClasses
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
    public partial class getVOPriceFrmHSPage_Map:logWriter
    {
        
        /// <summary>
        /// getVOPriceFrmHSPage_Method - Use 'getVOPriceFrmHSPage_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void getVOPriceFrmHSPage_Method(string villaOnlyPricefromDB, string villanameweb)
        {
            #region Variable Declarations
            HtmlCell uIItem59466Cell = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIItem59466Cell;
            string webprice = null;
           

            #endregion

            // Verify that the 'InnerText' property of '£594.66' cell contains ''
            webprice = uIItem59466Cell.InnerText;
            webprice = webprice.Remove(0, 1);
            decimal price = Convert.ToDecimal(webprice);
            price = Math.Round(price, 0);
            webprice = Convert.ToString(price);
          
            try
            {
                StringAssert.Contains(webprice, villaOnlyPricefromDB);
              

                WriteLogs("PASS: Villa Only Price from Holiday Summary Page:  " + webprice + " is matched with  Villa Only Price from DB: " + villaOnlyPricefromDB + " ");

            }
            catch (AssertFailedException ex)
            {
                takeImage("getVOPriceFrmHSPage");
                WriteLogs("FAIL : Price didn't Matched for  \"" + villanameweb + "\" from DB and product page.");
                WriteLogs("FAIL:-----------------" + ex.Message.ToString());
                WriteLogs("-------------------------------------------------");

            }
        }
        
        #region Properties
        public virtual getVOPriceFrmHSPage_MethodExpectedValues getVOPriceFrmHSPage_MethodExpectedValues
        {
            get
            {
                if ((this.mgetVOPriceFrmHSPage_MethodExpectedValues == null))
                {
                    this.mgetVOPriceFrmHSPage_MethodExpectedValues = new getVOPriceFrmHSPage_MethodExpectedValues();
                }
                return this.mgetVOPriceFrmHSPage_MethodExpectedValues;
            }
        }
        
        public UIYourHolidaySummaryWiWindow UIYourHolidaySummaryWiWindow
        {
            get
            {
                if ((this.mUIYourHolidaySummaryWiWindow == null))
                {
                    this.mUIYourHolidaySummaryWiWindow = new UIYourHolidaySummaryWiWindow();
                }
                return this.mUIYourHolidaySummaryWiWindow;
            }
        }
        #endregion
        
        #region Fields
        private getVOPriceFrmHSPage_MethodExpectedValues mgetVOPriceFrmHSPage_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'getVOPriceFrmHSPage_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class getVOPriceFrmHSPage_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of '£594.66' cell contains ''
        /// </summary>
        public string UIItem59466CellInnerText = "";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYourHolidaySummaryWiWindow : BrowserWindow
    {
        
        public UIYourHolidaySummaryWiWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYourHolidaySummaryDocument UIYourHolidaySummaryDocument
        {
            get
            {
                if ((this.mUIYourHolidaySummaryDocument == null))
                {
                    this.mUIYourHolidaySummaryDocument = new UIYourHolidaySummaryDocument(this);
                }
                return this.mUIYourHolidaySummaryDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYourHolidaySummaryDocument mUIYourHolidaySummaryDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYourHolidaySummaryDocument : HtmlDocument
    {
        
        public UIYourHolidaySummaryDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/default.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/default.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIItem59466Cell
        {
            get
            {
                if ((this.mUIItem59466Cell == null))
                {
                    this.mUIItem59466Cell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIItem59466Cell.SearchProperties[HtmlCell.PropertyNames.Id] = "tdpackagetotal";
                    this.mUIItem59466Cell.SearchProperties[HtmlCell.PropertyNames.Name] = "";
                    this.mUIItem59466Cell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "£", PropertyExpressionOperator.Contains));
                    this.mUIItem59466Cell.FilterProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.ControlDefinition, "align=\"right\" class=\"hsHeadersNoIndent tabBg contentText boldText\" id=\"tdpackaget" +
                                "otal\" style=\"padding-right: 10px;\"", PropertyExpressionOperator.Contains));
                    this.mUIItem59466Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "7";
                    this.mUIItem59466Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "6";
                    this.mUIItem59466Cell.FilterProperties[HtmlCell.PropertyNames.Class] = "hsHeadersNoIndent tabBg contentText boldText";
                    this.mUIItem59466Cell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "57";
                    this.mUIItem59466Cell.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIItem59466Cell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIItem59466Cell;
        #endregion
    }
}
