using System;
using System.Configuration;
using System.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Collections.Generic;

namespace SeleniumFramework
{

    public static class GlobalVars
    {
        // collecting all global variables for the reporter class in one class
        public static class Reporter
        {

            private static string g_tStart_Time;
            private static string _ReportLevel;
            private static string _SnapshotCaptureLevel;
            private static string g_sFinal_Result;
            private static string intEndTime;
            private static int g_iPass_Count;
            private static int g_iFail_Count;
            private static int g_iTotalPassCount;
            private static int g_totalfailsteps;
            private static int g_iTotalFailCount;
            private static int g_iTotalTestCaseCount;
            private static int g_iImage_Capture;
            private static int g_iCapture_Count;
            private static string strApplicationDataXMLfile;
            private static int intIterationStartTime;
            private static string sErrorValidationSheet;
            private static bool b_TestCase_Log;
            private static int i_TestCaseIterations;
            private static int i_CycleTotalTestCases;

            private static string sReportsFolder;
            private static string sRunResultFolder;
            private static string sScreenShootFolder;
            private static string sRQM_RunResult;

            private static string g_sFileName;

            //Initailize Reporter variables

            public static void InitializeReporterVars()
            {

                i_TestCaseIterations = 0;

                i_CycleTotalTestCases = 0;

                sReportsFolder = GlobalVars.Environment.FrameworkPath + "Framework\\Reports";

                RunResultFolder = sReportsFolder + "\\Automation_Result_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");

                sRQM_RunResult = sReportsFolder + "\\RQM_RunResult";

                sScreenShootFolder = RunResultFolder + "\\ScreenShots_" + GlobalVars.Test.ProjectName;

                g_sFileName = RunResultFolder + "\\" + "Automation_Report_"+GlobalVars.Test.ProjectName+".html";
                            

            }

            //getter and setter properties for Reporter varaibles.
            
            public static int CycleTotalTestCases
            {
                get
                {
                    return i_CycleTotalTestCases;
                }
                set
                {
                    i_CycleTotalTestCases = value;
                }
            }

            public static string ReportFolder
            {
                get
                {
                    return sReportsFolder;
                }
                set
                {
                    sReportsFolder = value;
                }
            }

            public static string ReportLevel
            {
                get
                {
                    return _ReportLevel;
                }
                set
                {
                    _ReportLevel = value;
                }
            }

            public static string SnapshotCaptureLevel
            {
                get
                {
                    return _SnapshotCaptureLevel;
                }
                set
                {
                    _SnapshotCaptureLevel = value;
                }
            }

            public static string RunResultFolder
            {
                get
                {
                    return sRunResultFolder;
                }
                set
                {
                    sRunResultFolder = value;
                }
            }

            public static string RQM_RunResult
            {
                get
                {
                    return sRQM_RunResult;
                }
                set
                {
                    sRQM_RunResult = value;
                }
            }

            public static string ScreenShootFolder
            {
                get
                {
                    return sScreenShootFolder;
                }
                set
                {
                    sScreenShootFolder = value;
                }
            }

            public static string FinalResults
            {
                get
                {
                    return g_sFinal_Result;
                }
                set
                {
                    g_sFinal_Result = value;
                }
            }

            public static string StartTime
            {
                get
                {
                    return g_tStart_Time;
                }
                set
                {
                    g_tStart_Time = value;
                }
            }

            public static string EndTime
            {
                get
                {
                    return intEndTime;
                }
                set
                {
                    intEndTime = value;
                }
            }

            public static int TestCaseIterations
            {
                get
                {
                    return i_TestCaseIterations;
                }
                set
                {
                    i_TestCaseIterations = value;
                }
            }

            public static int PassCount
            {
                get
                {
                    return g_iPass_Count;
                }
                set
                {
                    g_iPass_Count = value;
                }
            }

            public static int FailCount
            {
                get
                {
                    return g_iFail_Count;
                }
                set
                {
                    g_iFail_Count = value;
                }
            }

            public static int TotalPassCount
            {
                get
                {
                    return g_iTotalPassCount;
                }
                set
                {
                    g_iTotalPassCount = value;
                }
            }

            public static int TotalFailSteps
            {
                get
                {
                    return g_totalfailsteps;
                }
                set
                {
                    g_totalfailsteps = value;
                }
            }

            public static int TotalFailCount
            {
                get
                {
                    return g_iTotalFailCount;
                }
                set
                {
                    g_iTotalFailCount = value;
                }
            }

            public static int TotalTestCaseCount
            {
                get
                {
                    return g_iTotalTestCaseCount;
                }
                set
                {
                    g_iTotalTestCaseCount = value;
                }
            }

            public static int ScreenCaptureCount
            {
                get
                {
                    return g_iCapture_Count;
                }
                set
                {
                    g_iCapture_Count = value;
                }
            }

            public static int ImageCaptureLevels
            {
                get
                {
                    return g_iImage_Capture;
                }
                set
                {
                    g_iImage_Capture = value;
                }
            }

            public static int IterationStartTime
            {
                get
                {
                    return intIterationStartTime;
                }
                set
                {
                    intIterationStartTime = value;
                }
            }
            
            public static string ReportFileName
            {
                get
                {
                    return g_sFileName;
                }
                set
                {
                    g_sFileName = value;
                }
            }

            public static string ApplicationDataXMLfile
            {
                get
                {
                    return strApplicationDataXMLfile;
                }
                set
                {
                    strApplicationDataXMLfile = value;
                }
            }

            public static string ErrorValidationSheet
            {
                get
                {
                    return sErrorValidationSheet;
                }
                set
                {
                    sErrorValidationSheet = value;
                }
            }
			
            public static bool TestCaseStatus
            {
                get
                {
                    return b_TestCase_Log;
                }
                set
                {
                    b_TestCase_Log = value;
                }
            }                

            
        }
        
        // Collecting All TestEnvironment Global variables
        public static class Test {

            private static string _URL;
            private static string _BrowserType;
            private static string _RunLang;
            private static string _RunType;
            private static string _RunEnvironment;
            private static string _ProjectName;
            private static bool _CustomReport;            
            private static IWebDriver _Browser;
            //private static DeviceDescription _DeviceDesc;
            //private static IDevice _Device;
            private static string LogedInUser;
            private static bool _IsLogedIn;
            private static bool _isFirstLogin;
            private static double _BrowserTimeOut;        
            
            public static Dictionary<string, string> EnvironmentData = null;

            //Id The device ID used by Mobile Center.
            //Public Property Manufacturer    The manufacturer of the device.
            //Public Property Model The model of the device.  
            //Public Property Name The logical name that Mobile Center uses to identify the device.  
            //Public Property OsType The operating system currently running on the device.
            //Public Property OsVersion

            public static void InitializeTestVars(DataTable envVars)
            {
               EnvironmentData = DataManager.GetDictionaryFromDataTable(envVars);
                _BrowserTimeOut = double.Parse(ConfigurationManager.AppSettings["Browser.DefaultTimeout"].Trim());
                string DeviceId = envVars.Select("Name = 'MOB_Device_ID'")[0]["Value"].ToString(); 
                string DeviceName = envVars.Select("Name = 'MOB_Device_Name'")[0]["Value"].ToString(); 
                string DeviceOsType = envVars.Select("Name = 'MOB_Device_OsType'")[0]["Value"].ToString(); 
                string DeviceOsVersion = envVars.Select("Name = 'MOB_Device_OsVersion'")[0]["Value"].ToString();                           

                _URL = envVars.Select("Name = 'URL'")[0]["Value"].ToString();

                _BrowserType = envVars.Select("Name = 'Explorer'")[0]["Value"].ToString();

                _ProjectName = envVars.Select("Name = 'ProjectName'")[0]["Value"].ToString();

                _RunType = envVars.Select("Name = 'RunType'")[0]["Value"].ToString();
                
                _RunLang = envVars.Select("Name = 'RunLang'")[0]["Value"].ToString();

                _CustomReport = bool.Parse( envVars.Select("Name = 'CustomReport'")[0]["Value"].ToString());

                _RunEnvironment = envVars.Select("Name = 'RunEnvironment'")[0]["Value"].ToString();

                //_DeviceDesc = new DeviceDescription();

                _isFirstLogin = false;

                _IsLogedIn = false;

                //if (DeviceId.Trim() != "")
                //    _DeviceDesc.Id = DeviceId.ToString();
                //if (DeviceName.Trim() != "")
                //    _DeviceDesc.Name = DeviceName.Trim();
                //if (DeviceOsType.Trim() != "")
                //    _DeviceDesc.OsType = DeviceOsType.Trim();
                //if (DeviceOsVersion.Trim() != "")
                //    _DeviceDesc.OsVersion = DeviceOsVersion.Trim();

            }

            //public static DeviceDescription MobileDeviceDescription
            //{
            //    get
            //    {
            //        return _DeviceDesc;
            //    }
            //    set
            //    {
            //        _DeviceDesc = value;
            //    }
            //}

            public static double BrowserTimeOut
            {
                get
                {
                    return _BrowserTimeOut;
                }
                set
                {
                    _BrowserTimeOut = value;
                }
            }

            public static bool isFirstLogin
            {
                get
                {
                    return _isFirstLogin;
                }
                set
                {
                    _isFirstLogin = value;
                }
            }

            //public static IDevice MobileDevice
            //{
            //    get
            //    {
            //        return _Device;
            //    }
            //    set
            //    {
            //        _Device = value;
            //    }
            //}

            public static IWebDriver Browser
            {
                get
                {
                    return _Browser;
                }
                set
                {
                    _Browser = value;
                }
            }

            public static string RunEnvironment
            {
                get
                {
                    return _RunEnvironment;
                }
                set
                {
                    _RunEnvironment = value;
                }
            }

            public static string URL
            {
                get
                {
                    return _URL;
                }
                set
                {
                    _URL = value;
                }
            }

            public static string BrowserName
            {
                get
                {
                    return _BrowserType;
                }
                set
                {
                    _BrowserType = value;
                }
            }
            
            public static string RunLanguage
            {
                get
                {
                    return _RunLang;
                }
                set
                {
                    _RunLang = value;
                }
            }

            public static string RunType
            {
                get
                {
                    return _RunType;
                }
                set
                {
                    _RunType = value;
                }
            }

            public static string ProjectName
            {
                get
                {
                    return _ProjectName;
                }
                set
                {
                    _ProjectName = value;
                }
            }

            public static bool CustomReportEnable
            {
                get
                {
                    return _CustomReport;
                }
                set
                {
                    _CustomReport = value;
                }
            }

            public static string LogedInUserName
            {
                get
                {
                    return LogedInUser;
                }
                set
                {
                    LogedInUser = value;
                }
            }

            public static bool IsLogedIn
            {
                get
                {
                    return _IsLogedIn;
                }
                set
                {
                    _IsLogedIn = value;
                }
            }

        }

        //collecting Environment Variables
        public static class Environment {

            private static string Framework_Path;
            private static string Control_File_Name;
            private static string sRQM_TESTCASE_ID;
            private static string _ExcelConnString;
            private static string _LoggerFilePath;
            
            
            // initailize environment paths variables
            public static void InitializeEnvironmentVars()
            {
                string[] arrFullPath = System.Environment.CurrentDirectory.Split('\\');
                Framework_Path = "";
                for (int i = 0; i < arrFullPath.Length - 3; i++)
                {
                    Framework_Path = Framework_Path + arrFullPath[i] + "\\";
                }

                Control_File_Name = Framework_Path + ConfigurationManager.AppSettings["ControlFileName"];

                _ExcelConnString = ConfigurationManager.ConnectionStrings["MyExcelConn"].ConnectionString.Replace("[ControlFileName]", Control_File_Name);

                _LoggerFilePath = Framework_Path + "\\Framework\\Log";

                // CREATE lOG FILE
                Logger.CreateLogFile();
            }
            
            // class variables get / set properties
            public static string ExcelConnString
            {
                get
                {
                    return _ExcelConnString;
                }
                set
                {
                    _ExcelConnString = value;
                }
            }

            public static string LoggerFilePath
            {
                get
                {
                    return _LoggerFilePath;
                }
                set
                {
                    _LoggerFilePath = value;
                }
            }
                      
            public static string FrameworkPath
            {
                get
                {
                    return Framework_Path;
                }
                set
                {
                    Framework_Path = value;
                }
            }

            public static string ControlFile
            {
                get
                {
                    return Control_File_Name;
                }
                set
                {
                    Control_File_Name = value;
                }
            }

            public static string RQM_TESTCASE_ID
            {
                get
                {
                    return sRQM_TESTCASE_ID;
                }
                set
                {
                    sRQM_TESTCASE_ID = value;
                }
            }

         
        }

        //collecting DB global variables
        public static class Dates {

            public static string greCurrent;
            public static string greDayOver;
            public static string greDayBack;
            public static string greWeekOver;
            public static string greWeekBack;
            public static string greMonthOver;
            public static string greMonthBack;
            public static string greYearOver;
            public static string greYearBack;

            public static string hijCurrent;
            public static string hijDayOver;
            public static string hijDayBack;
            public static string hijWeekOver;
            public static string hijWeekBack;
            public static string hijMonthOver;
            public static string hijMonthBack;
            public static string hijYearOver;
            public static string hijYearBack;

            //public static void InitializeDates()
            //{
            //    try
            //    {
            //        greCurrent = Common.zeroPading(DateTime.Now.Day.ToString()) + "/" + Common.zeroPading(DateTime.Now.Month.ToString()) + "/" + DateTime.Now.Year;
            //        greDayBack = Common.zeroPading(DateTime.Now.AddDays(-1).Day.ToString()) + "/" + Common.zeroPading(DateTime.Now.AddDays(-1).Month.ToString()) + "/" + DateTime.Now.AddDays(-1).Year;
            //        greDayOver = Common.zeroPading(DateTime.Now.AddDays(1).Day.ToString()) + "/" + Common.zeroPading(DateTime.Now.AddDays(1).Month.ToString()) + "/" + DateTime.Now.AddDays(1).Year;
            //        greWeekBack = Common.zeroPading(DateTime.Now.AddDays(-7).Day.ToString()) + "/" + Common.zeroPading(DateTime.Now.AddDays(-7).Month.ToString()) + "/" + DateTime.Now.AddDays(-7).Year;
            //        greWeekOver = Common.zeroPading(DateTime.Now.AddDays(7).Day.ToString()) + "/" + Common.zeroPading(DateTime.Now.AddDays(7).Month.ToString()) + "/" + DateTime.Now.AddDays(7).Year;
            //        greMonthBack = Common.zeroPading(DateTime.Now.AddMonths(-1).Day.ToString()) + "/" + Common.zeroPading(DateTime.Now.AddMonths(-1).Month.ToString()) + "/" + DateTime.Now.AddMonths(-1).Year;
            //        greMonthOver = Common.zeroPading(DateTime.Now.AddMonths(1).Day.ToString()) + "/" + Common.zeroPading(DateTime.Now.AddMonths(1).Month.ToString()) + "/" + DateTime.Now.AddMonths(1).Year;
            //        greYearBack = Common.zeroPading(DateTime.Now.AddYears(-1).Day.ToString()) + "/" + Common.zeroPading(DateTime.Now.AddYears(-1).Month.ToString()) + "/" + DateTime.Now.AddYears(-1).Year;
            //        greYearOver = Common.zeroPading(DateTime.Now.AddYears(1).Day.ToString()) + "/" + Common.zeroPading(DateTime.Now.AddYears(1).Month.ToString()) + "/" + DateTime.Now.AddYears(1).Year;

            //        hijCurrent = Common.GregorianToHijriDate(greCurrent);
            //        hijDayOver = Common.GregorianToHijriDate(greDayOver);
            //        hijDayBack = Common.GregorianToHijriDate(greDayBack);
            //        hijWeekOver = Common.GregorianToHijriDate(greWeekOver);
            //        hijWeekBack = Common.GregorianToHijriDate(greWeekBack);
            //        hijMonthOver = Common.GregorianToHijriDate(greMonthOver);
            //        hijMonthBack = Common.GregorianToHijriDate(greMonthBack);
            //        hijYearOver = Common.GregorianToHijriDate(greYearOver);
            //        hijYearBack = Common.GregorianToHijriDate(greYearBack);
            //    }
            //    catch (Exception ex)
            //    {
            //        Logger.LogError(ex);
            //    }

            //}
        }

    } // end globalvars
} //end namespace


