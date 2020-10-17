using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIS_Mover
{
    static class Program
    {
        /// <summary>
        /// IIS Mover
        /// CWW
        /// GCU CST 451/452 capstone
        /// This project is designed to allow a sequencing of steps to permit moving applications in
        /// an IIS app pool
        /// current tasks are:
        /// API calls
        /// App Pool start/stop
        /// File copying
        /// File compressing
        /// Forcing a notice/wait notification for tasks outside the scope of IIS Mover
        /// </summary>
        public static List<String> lFunctions = new List<string>();
        public static List<String> lAppPools = new List<string>();
        public static List<String> lAPIMethods = new List<string>();
        public static String sCurrentTask = "";
        public static OpenFileDialog oSourceFileDialog;
        public static SaveFileDialog oTargetFileDialog;
        public static FolderBrowserDialog oTargetFolderDialog;
        public static String[] lFileNames;        
        public static IISMoverFunction oIISMoverFunction = new IISMoverFunction();
        public static IISMoverList oIISMoverList = new IISMoverList();
        public static AppPoolService oAppPoolService = new AppPoolService();
        public static String sAppPoolName = "";
        public static bool bAppPoolStart = false;

        [STAThread]
        static void Main()
        {
            FillLists();            
            oIISMoverList.lIISMoverFunctions = new List<IISMoverFunction>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IISMoverMainWindow());            
        }
        
        static void FillLists()
        {
            PopulateFunctionsList();
            PopulateAppPoolList();
            PopulateAPICallMethods();
        }

        static void PopulateAppPoolList()
        {

            lAppPools = oAppPoolService.FetchAppPools();
        }

        static void PopulateAPICallMethods()
        {
            lAPIMethods.Add("Get");
            lAPIMethods.Add("Post");
            lAPIMethods.Add("Put");
            lAPIMethods.Add("Update");
        }

        static void PopulateFunctionsList()
        {
            lFunctions.Add("API Call");
            lFunctions.Add("APP Pool");
            lFunctions.Add("Compress");
            lFunctions.Add("Copy");
            lFunctions.Add("Wait");
        }

    }
}
