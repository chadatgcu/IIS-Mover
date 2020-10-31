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
/// v1.0 9-29-20
/// v1.0.1 10-4-20 support for copy/compress moved to one UI for simplicity
/// v1.0.2 10-5-20 protected user against sorting top task and bottom task up or down respectively (i.e. top item should be able to sort up/bottom should not be able to sort down)
/// v1.0.3 10-29-20 added documentation and readme
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
        
        static void FillLists() // populates list with items
        {
            PopulateFunctionsList();
            PopulateAppPoolList();
            PopulateAPICallMethods();
        }

        static void PopulateAppPoolList() // uses apppool serverice to populate apppools
        {
            lAppPools = oAppPoolService.FetchAppPools();
        }

        static void PopulateAPICallMethods() // supported api methods list population
        {
            lAPIMethods.Add("Get");
            lAPIMethods.Add("Post");
            lAPIMethods.Add("Put");
            lAPIMethods.Add("Update");
        }

        static void PopulateFunctionsList() // populates list of supported functions
        {
            lFunctions.Add("API Call");
            lFunctions.Add("APP Pool");
            lFunctions.Add("Compress");
            lFunctions.Add("Copy");
            lFunctions.Add("Wait");
        }

    }
}
