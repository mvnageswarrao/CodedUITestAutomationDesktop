﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.verifyLocationTabLocFeatures_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class verifyLocationTabLocFeatures_Map:logWriter
    {
        
        /// <summary>
        /// verifyLocationTabLocFeatures_Method - Use 'verifyLocationTabLocFeatures_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyLocationTabLocFeatures_Method(string villaLocTabLocFeatures)
        {
            #region Variable Declarations
            HtmlSpan uIMainContent_LocationPane = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIMainContent_LocationPane;
            #endregion

            // Verify that the 'InnerText' property of 'MainContent_LocationFeatures' pane contains 'Vale das Canas is a small, select development of just 8 apartments and a villa set amongst rolling lawns and mature trees within easy reach of both Quinta do Lago and Vale do Lobo. Quinta do Lago and Vale do Lobo, each with a wide choice of leisure facilities for the whole family, are less than a mile and half from Vale das Canas. The nearest restaurant is just over 1100 yards away. Just a mile from the apartments are Bouganvilia Plaza and Quinta Shopping, right at the entrance to Quinta do Lago. Between them they offer a wide range of shops and restaurants, a supermarket, a bank and a nightclub. The praça at Vale do Lobo, which overlooks the lovely sandy beach there, is just over 2 miles from Vale das Canas. There are shops, bars, restaurants and nightclubs here, with a children's play park very close by. Vale do Lobo's famous Royal golf course is under 2 miles from Vale das Canas, and there are several other championship courses in the area. The Ria Formosa Natural Park stretches from Tavira to Faro: the Quinta do Lago part of the Park is around 3 miles away, with its Nature Trails, wildlife and beautiful views. There is a horse riding centre within 1 mile, and the Quinta do Lago water sports centre is just three and a quarter miles away, on the lake. The area boasts a number of restaurants for all tastes as well as informal beach bars. In the spacious grounds, there is a large communal pool with a gated area for children, a tennis court (rackets and balls are not provided) and a games area with a pool table and table tennis tables . All around the estate are shady pines, delicate pepper trees and attractive flowering shrubs. The whole area is laid to lawn. An electronic gate and secure fences provide a good measure of security and privacy.'
            //StringAssert.Contains(uIMainContent_LocationPane.InnerText, this.verifyLocationTabLocFeatures_MethodExpectedValues.UIMainContent_LocationPaneInnerText);
            string toCompare = uIMainContent_LocationPane.InnerText;
            toCompare = toCompare.Replace("\r\n", string.Empty);
            toCompare = toCompare.Trim();
            try
            {
                StringAssert.Equals(toCompare, villaLocTabLocFeatures);
                WriteLogs("PASS : Location Tab - Location Features.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Location Tab - Location Features.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyLocationTabLocFeatures_MethodExpectedValues verifyLocationTabLocFeatures_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyLocationTabLocFeatures_MethodExpectedValues == null))
                {
                    this.mverifyLocationTabLocFeatures_MethodExpectedValues = new verifyLocationTabLocFeatures_MethodExpectedValues();
                }
                return this.mverifyLocationTabLocFeatures_MethodExpectedValues;
            }
        }
        
        public UICanas1bdrmEQuintadoLWindow UICanas1bdrmEQuintadoLWindow
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLWindow == null))
                {
                    this.mUICanas1bdrmEQuintadoLWindow = new UICanas1bdrmEQuintadoLWindow();
                }
                return this.mUICanas1bdrmEQuintadoLWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyLocationTabLocFeatures_MethodExpectedValues mverifyLocationTabLocFeatures_MethodExpectedValues;
        
        private UICanas1bdrmEQuintadoLWindow mUICanas1bdrmEQuintadoLWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyLocationTabLocFeatures_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class verifyLocationTabLocFeatures_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'MainContent_LocationFeatures' pane contains 'Vale das Canas is a small, select development of just 8 apartments and a villa set amongst rolling lawns and mature trees within easy reach of both Quinta do Lago and Vale do Lobo. Quinta do Lago and Vale do Lobo, each with a wide choice of leisure facilities for the whole family, are less than a mile and half from Vale das Canas. The nearest restaurant is just over 1100 yards away. Just a mile from the apartments are Bouganvilia Plaza and Quinta Shopping, right at the entrance to Quinta do Lago. Between them they offer a wide range of shops and restaurants, a supermarket, a bank and a nightclub. The praça at Vale do Lobo, which overlooks the lovely sandy beach there, is just over 2 miles from Vale das Canas. There are shops, bars, restaurants and nightclubs here, with a children's play park very close by. Vale do Lobo's famous Royal golf course is under 2 miles from Vale das Canas, and there are several other championship courses in the area. The Ria Formosa Natural Park stretches from Tavira to Faro: the Quinta do Lago part of the Park is around 3 miles away, with its Nature Trails, wildlife and beautiful views. There is a horse riding centre within 1 mile, and the Quinta do Lago water sports centre is just three and a quarter miles away, on the lake. The area boasts a number of restaurants for all tastes as well as informal beach bars. In the spacious grounds, there is a large communal pool with a gated area for children, a tennis court (rackets and balls are not provided) and a games area with a pool table and table tennis tables . All around the estate are shady pines, delicate pepper trees and attractive flowering shrubs. The whole area is laid to lawn. An electronic gate and secure fences provide a good measure of security and privacy.'
        /// </summary>
        public string UIMainContent_LocationPaneInnerText = "Vale das Canas is a small, select development of just 8 apartments and a villa se" +
            "t amongst rolling lawns and mature trees within easy reach of both Quinta do Lag" +
            "o and Vale do Lobo. Quinta do Lago and Vale do Lobo, each with a wide choice of " +
            "leisure facilities for the whole family, are less than a mile and half from Vale" +
            " das Canas. The nearest restaurant is just over 1100 yards away. Just a mile fro" +
            "m the apartments are Bouganvilia Plaza and Quinta Shopping, right at the entranc" +
            "e to Quinta do Lago. Between them they offer a wide range of shops and restauran" +
            "ts, a supermarket, a bank and a nightclub. The praça at Vale do Lobo, which over" +
            "looks the lovely sandy beach there, is just over 2 miles from Vale das Canas. Th" +
            "ere are shops, bars, restaurants and nightclubs here, with a children\'s play par" +
            "k very close by. Vale do Lobo\'s famous Royal golf course is under 2 miles from V" +
            "ale das Canas, and there are several other championship courses in the area. The" +
            " Ria Formosa Natural Park stretches from Tavira to Faro: the Quinta do Lago part" +
            " of the Park is around 3 miles away, with its Nature Trails, wildlife and beauti" +
            "ful views. There is a horse riding centre within 1 mile, and the Quinta do Lago " +
            "water sports centre is just three and a quarter miles away, on the lake. The are" +
            "a boasts a number of restaurants for all tastes as well as informal beach bars. " +
            "In the spacious grounds, there is a large communal pool with a gated area for ch" +
            "ildren, a tennis court (rackets and balls are not provided) and a games area wit" +
            "h a pool table and table tennis tables . All around the estate are shady pines, " +
            "delicate pepper trees and attractive flowering shrubs. The whole area is laid to" +
            " lawn. An electronic gate and secure fences provide a good measure of security a" +
            "nd privacy.";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLWindow : BrowserWindow
    {
        
        public UICanas1bdrmEQuintadoLWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UICanas1bdrmEQuintadoLDocument UICanas1bdrmEQuintadoLDocument
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLDocument == null))
                {
                    this.mUICanas1bdrmEQuintadoLDocument = new UICanas1bdrmEQuintadoLDocument(this);
                }
                return this.mUICanas1bdrmEQuintadoLDocument;
            }
        }
        #endregion
        
        #region Fields
        private UICanas1bdrmEQuintadoLDocument mUICanas1bdrmEQuintadoLDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLDocument : HtmlDocument
    {
        
        public UICanas1bdrmEQuintadoLDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/product.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/product.aspx?villaid=275";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UIMainContent_LocationPane
        {
            get
            {
                if ((this.mUIMainContent_LocationPane == null))
                {
                    this.mUIMainContent_LocationPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIMainContent_LocationPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_LocationFeatures";
                    this.mUIMainContent_LocationPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIMainContent_LocationPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Vale das Canas is a small, select develo";
                    this.mUIMainContent_LocationPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIMainContent_LocationPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "margin12 displayInlineBlock";
                    this.mUIMainContent_LocationPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_LocationFeatures\" class=";
                    this.mUIMainContent_LocationPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "22";
                    this.mUIMainContent_LocationPane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIMainContent_LocationPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIMainContent_LocationPane;
        #endregion
    }
}
