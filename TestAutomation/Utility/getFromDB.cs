using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Xml;
using System.Data.Odbc;
using System.Data.OleDb;


namespace TestAutomation.Utility
{
    class getFromDB:logWriter
    {
        public getFromDB()
        {

        }
        public SqlDataReader getData(string SQLquery, string InitialCatalog)
        {
            
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

            scsb.DataSource = ConfigurationManager.AppSettings["DataSource"].ToString();
            if (InitialCatalog != "")
            { 
                scsb.InitialCatalog = InitialCatalog;
            }
            else
            {
                scsb.InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();
            }
            scsb.IntegratedSecurity = false; // set to true is using Windows Authentication
            scsb.UserID = ConfigurationManager.AppSettings["UserID"].ToString();
            scsb.Password = ConfigurationManager.AppSettings["Password"].ToString();

            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            SqlDataReader rdr = null;
            try
            {
                SqlCommand cmd = new SqlCommand(SQLquery);
                conn.Open();
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader();

                return rdr;
            }
            catch (SqlException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                //conn.Close();
            }
        }
        public SqlDataReader getData(string SQLquery)
        {

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

            scsb.DataSource = ConfigurationManager.AppSettings["DataSource"].ToString();
            scsb.InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();
            
            scsb.IntegratedSecurity = false; // set to true is using Windows Authentication
            scsb.UserID = ConfigurationManager.AppSettings["UserID"].ToString();
            scsb.Password = ConfigurationManager.AppSettings["Password"].ToString();

            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            SqlDataReader rdr = null;
            try
            {
                SqlCommand cmd = new SqlCommand(SQLquery);
                conn.Open();
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader();

                return rdr;
            }
            catch (SqlException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataSet getdatafrmdtset(string SQLquery)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

            scsb.DataSource = ConfigurationManager.AppSettings["DataSource"].ToString();
            scsb.InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();
            scsb.IntegratedSecurity = false; // set to true is using Windows Authentication
            scsb.UserID = ConfigurationManager.AppSettings["UserID"].ToString();
            scsb.Password = ConfigurationManager.AppSettings["Password"].ToString();

            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQLquery;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                conn.Open();
                da.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (SqlException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable getDataFromDBF(string DataSource)
        {
            string DBF_FileName = "bookings.dbf";
            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DataSource + ";Collating Sequence=machine;");
            OleDbCommand command = new OleDbCommand("select top 50 Ref as BookRef , Totalprice as HolidayCost , bookid as Bookid , creditcharge , payed from " + DBF_FileName + " where status like '%Booking%' Order by Bookid desc", conn);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                DataTable dt_Customer = new DataTable();
                return dt;
            }
            catch (OleDbException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
            
        }
        public DataTable getDataFromreceiptstable(string DataSource,string bookingid)
        {
            string DBF_FileName = "receipts.dbf";
            int bookiid = Int32.Parse(bookingid);
            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DataSource + ";Collating Sequence=machine;");
            OleDbCommand command = new OleDbCommand("select date as Date , Chequeno as Reference , payment as TotalPayment , CcardRate as CCRate from " + DBF_FileName + " where Bookid=" + bookingid, conn);

            try
            {
                conn.Open();
                DataTable dt_receipts = new DataTable();
                dt_receipts.Load(command.ExecuteReader());
                return dt_receipts;
            }
            catch (OleDbException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }
        public DataTable getDataFromvillapacktable(string DataSource, string bookingid)
        {
            string DBF_FileName = "villapack.dbf";
            int bookiid = Int32.Parse(bookingid);
            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DataSource + ";Collating Sequence=machine;");
            OleDbCommand command = new OleDbCommand("select linetype , villaid,centre,nights,arrdate from " + DBF_FileName + " where Bookid=" + bookingid, conn);

            try
            {
                conn.Open();
                DataTable dt_villapack = new DataTable();
                DataTable dt_flightdetails = new DataTable();
                dt_villapack.Load(command.ExecuteReader());
                return dt_villapack;
            }
            catch (OleDbException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable getDataflightdetailsFromvillapacktable(string DataSource, string bookingid)
        {
            string DBF_FileName = "villapack.dbf";
            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DataSource + ";Collating Sequence=machine;");
            OleDbCommand command_flights = new OleDbCommand("select linetype,nights,adults,child,infants,adultrate,childrate,infantrate,flightextra,lineprice,flreference,fl_depdate,flightno_ob,depport_ob,arrport_ob,arrtime_ob,fl_retdate,flightno_ib,depport_ib,arrport_ib,arrtime_ib from " + DBF_FileName + " where Bookid=" + bookingid, conn);
            try
            {
                conn.Open();
                DataTable dt_flightdetails = new DataTable();
                dt_flightdetails.Load(command_flights.ExecuteReader());
                return dt_flightdetails;
            }
            catch (OleDbException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable getDataairportnamefromairporttable(string DataSource, string airportcode)
        {
            string DBF_FileName = "airport.dbf";
            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DataSource + ";Collating Sequence=machine;");
            OleDbCommand command_flights = new OleDbCommand("select airport from " + DBF_FileName + " where code=code=\"'+airportcode+'\"", conn);

            try
            {
                conn.Open();
                DataTable dt_airportname = new DataTable();
                dt_airportname.Load(command_flights.ExecuteReader());
                return dt_airportname;
            }
            catch (OleDbException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable getDataFromvillastable(string DataSource, string villaid)
        {
            string DBF_FileName = "villas.dbf";
            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DataSource + ";Collating Sequence=machine;");
            OleDbCommand command = new OleDbCommand("select centre,name,resortid,bedrooms from " + DBF_FileName + " where id =" + villaid, conn);
            try
            {
                conn.Open();
                DataTable dt_villas = new DataTable();
                dt_villas.Load(command.ExecuteReader());
                return dt_villas;
            }
            catch (OleDbException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable getDataFromcentretable(string DataSource, string centre)
        {
            string DBF_FileName = "centre.dbf";
            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DataSource + ";Collating Sequence=machine;");
            OleDbCommand command = new OleDbCommand("select desc as centre_name from " + DBF_FileName + " where code=\"" + centre + "\"", conn);
            try
            {
                conn.Open();
                DataTable dt_centrename = new DataTable();
                dt_centrename.Load(command.ExecuteReader());
                return dt_centrename;
            }
            catch (OleDbException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable getDataFromresorttable(string DataSource, string resortid)
        {
            string DBF_FileName = "resort.dbf";
            int resid = Int32.Parse(resortid);

            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DataSource + ";Collating Sequence=machine;");
            OleDbCommand command = new OleDbCommand("select name as resort_name from " + DBF_FileName + " where id =" + resid, conn);
            
            try
            {                
                conn.Open();
                DataTable dt_resortname = new DataTable();
                dt_resortname.Load(command.ExecuteReader());
                return dt_resortname;
            }
            catch (OleDbException ex)
            {
                WriteLogs("Error in connection : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}