using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using TestAutomation.Utility;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using AshSoftware.Globals;
using System.IO;
using System.Linq;
using System.IO.Compression;
using System.IO.Packaging;


namespace TestAutomation
{
    /// <summary>
    /// Summary description for BalancePayment
    /// </summary>
    [CodedUITest]
    public class BalancePayment:logWriter
    {
        public BalancePayment()
        {
        }

        [TestMethod]
        public void BalancePaymentVerification()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.

            #region Balance Payment Initiate
            getFromDB getdata = new getFromDB();
            string DataSource = ConfigurationManager.AppSettings["BODBLocation"].ToString();
            string invoiceTestPageURL = ConfigurationManager.AppSettings["InvoiceTestPage"].ToString();
            string balancePaymentPageURL = ConfigurationManager.AppSettings["BalancePaymentPage"].ToString();
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            string Platform = ConfigurationManager.AppSettings["platform"].ToString();
            string baseDirectory = ConfigurationManager.AppSettings["BODBzipLocation"].ToString();
            string localbaseDirectory = ConfigurationManager.AppSettings["BODBLocation"].ToString();
            string pattern = "*.zip";
            string[] files = System.IO.Directory.GetFiles(baseDirectory, "BOdata_*.zip", System.IO.SearchOption.TopDirectoryOnly);
            string FileName;
            var localdirinfo = new DirectoryInfo(localbaseDirectory);
            InitiateBalancePayment runScript = new InitiateBalancePayment();

          
            #endregion

            #region Get Latest BO DB zip file and extract booking.dbf
                      
              FileName = getLatestBODBzipFileName(); 
              bool isExtract = extractBookingDBF(FileName); 
            #endregion

            #region Get Booking Ref from DBF and encrypt string
            AshSoftware.Globals.Crypto temp = new Crypto();
            DataTable dt = getdata.getDataFromDBF(DataSource);
            dt.Columns.Add("EncryptRef");

            #endregion

            #region Balance Payment Home Page
            WriteLogs("########## START ########## Balance Payment : On " + strURL + " " + DateTime.Now.ToString() + "##########");
            runScript.OpenBrowser_Obj.openBrowser_Method();
            string pkgholidaydetails=String.Empty;
            string journeydatedetails = string.Empty;
            string holidaydetails_date = string.Empty;
            String ADW_check = string.Empty;
            string flreference = string.Empty;
            string linetype = string.Empty;
            string fl_depdate = string.Empty;
            string flightno_ob = string.Empty;
            string depport_ob_code = string.Empty;
            string arrport_ob_code = string.Empty;
            string airportname_ob = string.Empty;
           
            Random rndm = new Random();
            DataRow rndm_row;
            int i = 0;
        
            while(i<3)
            {
                int Totalprice;
                int creditcharge;
                int payed;
                rndm_row = dt.Rows[rndm.Next(0, dt.Rows.Count - 1)];
                Totalprice = Convert.ToInt32(rndm_row[1]);
                creditcharge = Convert.ToInt32(rndm_row[3]);
                payed = Convert.ToInt32(rndm_row[4]);

                if ((Totalprice + creditcharge) - (payed) > 0)
                {
                    string bookRef = rndm_row[0].ToString();
                    string HolidayCost_DB = rndm_row[1].ToString().Trim();
                    string Bookid = rndm_row[2].ToString().Trim();
                    string tempbookingref = rndm_row[0].ToString();
                    tempbookingref = tempbookingref.Trim();
                    rndm_row[5] = temp.Encrypt(tempbookingref);

                    string encryptStr = rndm_row[5].ToString();
                    string balancePaymentPageURLNew = balancePaymentPageURL + encryptStr;
                    runScript.enterURL_Obj.enterURL_Method(balancePaymentPageURLNew);
                    WriteLogs("-------------------- START -------------------- Bookingref : " + bookRef);

                    runScript.verifyBPpgOpen_Obj.verifyBPpgOpen_Method(bookRef);
                    runScript.verifyPayNowBtnVisible_Obj.verifyPayNowBtnVisible_Method(bookRef);
                    runScript.VerifyHolidayCostSection_obj.VerifyHolidayCostSection_Method(HolidayCost_DB);

                    DataTable dt_receipts = new DataTable();
                    dt_receipts = getdata.getDataFromreceiptstable(DataSource, Bookid);
                    foreach (DataRow dtrow in dt_receipts.Rows)
                    {
                        string date = Convert.ToDateTime(dtrow[0]).ToString("dd MMM yyyy");
                        string Reference = dtrow[1].ToString();
                        Reference = Reference.Substring(Reference.IndexOf('-') + 1);
                        Reference = Reference.Trim();
                        string TotalPayment = dtrow[2].ToString();
                        string payhistory = "£" + TotalPayment;
                        runScript.VerifyPayHistorySection_obj.VerifyPayHistorySection_Method(Reference, payhistory);

                    }

                    //getting details from villapack table

                    DataTable dt_villapack = new DataTable();
                    dt_villapack = getdata.getDataFromvillapacktable(DataSource, Bookid);
                    foreach (DataRow dtrow in dt_villapack.Rows)
                    {
                        string villaid = dtrow[1].ToString();
                        string centre = dtrow[2].ToString();
                        string nights = dtrow[3].ToString();
                        int noofnights = Int32.Parse(nights);
                        string ArrDate = Convert.ToDateTime(dtrow[4]).ToString("ddd dd MMM yyyy");

                        DateTime returndate = Convert.ToDateTime(dtrow[4]).AddDays(noofnights);
                        string returndate_str = returndate.ToString("ddd dd MMM yyyy");
                        holidaydetails_date = nights + " nights from " + ArrDate + " to 10am " + returndate_str;
                        DataTable dt_villas = new DataTable();
                        dt_villas = getdata.getDataFromvillastable(DataSource, villaid);
                        foreach (DataRow dtrow_villas in dt_villas.Rows)
                        {
                            string villaname = dtrow_villas[1].ToString().Trim();
                            string resortid = dtrow_villas[2].ToString();
                            string noofbedrooms = dtrow_villas[3].ToString();
                            pkgholidaydetails = villaname + ", ";
                            string adw_check = "Accidental Damage Waiver - " + noofbedrooms + " Bedrooms @ £20.00 each";
                            DataTable dt_resortname = getdata.getDataFromresorttable(DataSource, resortid);

                            foreach (DataRow dtrow_resortname in dt_resortname.Rows)
                            {
                                string resortname = dtrow_resortname[0].ToString().Trim();
                                pkgholidaydetails = pkgholidaydetails + resortname + ", ";
                            }

                        }

                        //getting centre name from centre table

                        DataTable dt_centrename = getdata.getDataFromcentretable(DataSource, centre);
                        foreach (DataRow dtrow_centre in dt_centrename.Rows)
                        {
                            string centrename = dtrow_centre[0].ToString().Trim();
                            pkgholidaydetails = pkgholidaydetails + centrename;

                        }
                        runScript.VerifyHolidayDetailsSection_obj.VerifyHolidayDetailsSection_Method(pkgholidaydetails);
                        runScript.VerifyHolidayDetailsSection_obj.VerifyHolidayDetailsSection_date_Method(holidaydetails_date);
                        runScript.VerifyHolidayDetailsSection_obj.VerifyHolidayDetailsSection_ADW_Method(ADW_check);

                        // getting flight details from villapack table

                        DataTable dt_flightdetails = getdata.getDataflightdetailsFromvillapacktable(DataSource, Bookid);
                        foreach (DataRow dtrow_flights in dt_flightdetails.Rows)
                        {
                            linetype = dtrow_flights[0].ToString().Trim();

                            if (linetype == "Villa-Pk")
                            {
                                flreference = dtrow_flights[10].ToString().Trim();
                                flreference = "Flight Ref No. : " + flreference;
                                runScript.VerifyHolidayDetailsSection_obj.VerifyHolidayDetailsSection_Flight_Reference_Method(flreference);

                                flightno_ob = dtrow_flights[12].ToString().Trim();
                                fl_depdate = Convert.ToDateTime(dtrow_flights[11]).ToString("ddd dd MMM yyyy");
                                string flightdetails_ob = flightno_ob + " " + fl_depdate;
                                runScript.VerifyHolidayDetailsSection_obj.VerifyHolidayDetailsSection_Flightdetailsob_Method(flightdetails_ob);

                                depport_ob_code = dtrow_flights[13].ToString().Trim();
                                arrport_ob_code = dtrow_flights[14].ToString().Trim();
                            }

                        }


                        WriteLogs("-------------------- END -------------------- Bookingref : " + bookRef);

                    }

                    i++;
                }

            }
            
            #endregion

            WriteLogs("########## END ########## Balance Payment : On " + strURL + " " + DateTime.Now.ToString() + "##########");
           
        }

        private static string getLatestBODBzipFileName()
        {
            string fileFullName = "";
            string fileName = "";
            string baseDirectory = ConfigurationManager.AppSettings["BODBzipLocation"].ToString(); ;
            string extractPath = ConfigurationManager.AppSettings["BODBLocation"].ToString();
            string pattern = "*.zip";
            var dirInfo = new DirectoryInfo(baseDirectory);
            int fileCount = Directory.GetFiles(dirInfo.ToString(), pattern).Length;
            if (fileCount > 0)
            {
                var file = (from f in dirInfo.GetFiles(pattern) orderby f.LastWriteTime descending select f).First();
                fileFullName = file.FullName;
                fileName =  file.Name;
            }
            if(fileName != string.Empty)
            {
                System.IO.File.Copy(fileFullName, extractPath + fileName);
            }
            return extractPath + fileName;
        }

        private static bool extractBookingDBF(string FileName)
        {
            string extractPath = ConfigurationManager.AppSettings["BODBLocation"].ToString();

            using (ZipArchive archive = ZipFile.OpenRead(FileName))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.Equals("bookings.dbf", StringComparison.OrdinalIgnoreCase) 
                        || entry.FullName.Equals("bookings.fpt", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("bookings.tbk", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("bookings.bak", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("bookings.cdx", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("TSYS.DBC", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("TSYS.DCT", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("tsys.DCX", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("receipts.dbf", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("receipts.fpt", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("receipts.cdx", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("villapack.dbf", StringComparison.OrdinalIgnoreCase) 
                        || entry.FullName.Equals("villapack.fpt", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("villapack.tbk", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("villapack.bak", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("villapack.cdx", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("villas.dbf", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("villas.fpt", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("villas.tbk", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("villas.bak", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("villas.cdx", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("resort.dbf", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("resort.fpt", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("resort.cdx", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("centre.dbf", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("centre.fpt", StringComparison.OrdinalIgnoreCase)
                        || entry.FullName.Equals("centre.cdx", StringComparison.OrdinalIgnoreCase)
                        )
                    {
                        entry.ExtractToFile(Path.Combine(extractPath, entry.FullName));
                        
                    }
                }
            }
            return false;
        }
        
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
