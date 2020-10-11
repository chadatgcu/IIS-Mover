using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace IIS_Mover
{
    public partial class IISMoverMainWindow : Form
    {
        // 93, 12 is the 
        public IISMoverMainWindow()
        {        
            InitializeComponent();
            foreach (String sName in Program.lFunctions)
            {
                FunctionListBox.Items.Add(sName);
            }

            foreach (String sName in Program.lAppPools)
            {
                appPoolListBox.Items.Add(sName);
            }

            foreach (String sName in Program.lAPIMethods)
            {
                apiListBox.Items.Add(sName);
            }
            StartUI();
        }

        void UpdateTaskListBox()
        {
            taskListBox.Items.Clear();
            foreach (IISMoverFunction oThisMoverFunction in Program.oIISMoverList.lIISMoverFunctions)
            {
                taskListBox.Items.Add(oThisMoverFunction.Name);
                taskListBox.Update();
            }
        }
        void StartUI()
        {            
            HideAllFunctions();
            LockOrUnlockButtons();
            addButton.Enabled = false;
            Program.oSourceFileDialog = new OpenFileDialog();
            Program.oTargetFileDialog = new SaveFileDialog();
            Program.oTargetFolderDialog = new FolderBrowserDialog();
            Program.oSourceFileDialog.RestoreDirectory = true;          
            Program.oSourceFileDialog.Multiselect = true;
            Program.oSourceFileDialog.Title = "Select file(s) and/or folders";            
            resultsTextBox.Text = "";
        }
        
        void LockOrUnlockButtons()
        {
            
            if (Program.oIISMoverList.lIISMoverFunctions.Count == 0)
            {
                saveButton.Enabled = false;
                processButton.Enabled = false;
                taskDeleteButton.Enabled = false;
                taskListBox.Enabled = false;
                upBotton.Enabled = false;
                downButton.Enabled = false;
            }
            
            if (Program.oIISMoverList.lIISMoverFunctions.Count > 0)
            {
                saveButton.Enabled = true;
                processButton.Enabled = true;
                taskDeleteButton.Enabled = true;
                taskListBox.Enabled = true;
            } else
            {
                saveButton.Enabled = false;
                processButton.Enabled = false;
                taskDeleteButton.Enabled = false;
                taskListBox.Enabled = false;
            }

            if (Program.oIISMoverList.lIISMoverFunctions.Count > 1)
            {
                upBotton.Enabled = true;
                downButton.Enabled = true;
            } else
            {
                upBotton.Enabled = false;
                downButton.Enabled = false;
            }
        }

        void HideAllFunctions()
        {
            HideCopyCompressFunctions();
            HideAPIFunctions();
            HideWaitFunctions();
            HideAppPoolFunctions();
            targetTextBox.Text = "";
            sourceTextBox.Text = "";
        }

        void HideCopyCompressFunctions()
        {            
            copyCompressGroupBox.Visible = false;            
        }

        void ShowCopyCompressFunctions()
        {
            copyCompressGroupBox.Visible = true;
        }

        void HideAPIFunctions()
        {     
            apiGroupBox.Visible = false;
        }

        void ShowAPIFunctions()
        {
            apiGroupBox.Visible = true;
        }

        void HideWaitFunctions()
        {
            waitGroupBox.Visible = false;
        }

        void ShowWaitFunctions()
        {
            waitGroupBox.Visible = true;
        }

        void HideAppPoolFunctions()
        {
            appPoolGroupBox.Visible = false;
        }

        void ShowAppPoolFunctions()
        {
            appPoolGroupBox.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // move up
            IISMoverFunction oTempUp = new IISMoverFunction();
            IISMoverFunction oTempDown = new IISMoverFunction();
            int _iIndex = 0;
            foreach (IISMoverFunction oThisMoverFunction in Program.oIISMoverList.lIISMoverFunctions)
            {
                if (taskListBox.SelectedItem.Equals(oThisMoverFunction.Name))
                {
                    oTempUp = oThisMoverFunction;
                    oTempDown = Program.oIISMoverList.lIISMoverFunctions[(_iIndex - 1)];
                    break;
                }
                _iIndex++;
            }
            Program.oIISMoverList.lIISMoverFunctions[_iIndex] = oTempDown;
            Program.oIISMoverList.lIISMoverFunctions[(_iIndex - 1)] = oTempUp;
            RefreshTaskList();
        }

        private void copyCompressGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Program.bAppPoolStart = true;
        }

        private void appPoolStopRB_CheckedChanged(object sender, EventArgs e)
        {
            Program.bAppPoolStart = false;
        }

        private void APPPoolStartStop()
        {
            if (Program.bAppPoolStart)
            {
                appPoolStartRB.Checked = true;
                appPoolStopRB.Checked = false;
            } 
            else
            {
                appPoolStartRB.Checked = true;
                appPoolStopRB.Checked = false;
            }
        }

        private void FunctionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FunctionListBox.SelectedIndex != -1)
            {
                Program.oIISMoverFunction = new IISMoverFunction();
                Program.oIISMoverFunction.dKVPs = new Dictionary<string, string>();                        
                HideAllFunctions();
                // 0 = API Call, 1 = App Pool, 2 = Compress, 3 = Copy, 4 = Wait
                switch (FunctionListBox.SelectedIndex)
                {
                    case 0:
                        apiGroupBox.Enabled = true;
                        ShowAPIFunctions();
                        Program.sCurrentTask = "API";
                        Program.oIISMoverFunction.Type = 0;
                        break;
                    case 1:
                        Program.sAppPoolName = "";
                        Program.bAppPoolStart = true;
                        APPPoolStartStop();
                        ShowAppPoolFunctions();
                        Program.sCurrentTask = "APP";
                        Program.oIISMoverFunction.Type = 1;
                        break;
                    case 2:
                        ShowCopyCompressFunctions();
                        Program.sCurrentTask = "ZIP";
                        Program.oIISMoverFunction.Type = 2;
                        //Program.oTargetFileDialog.Filter = "Zip (*.Zip)";
                        break;
                    case 3:
                        ShowCopyCompressFunctions();
                        Program.sCurrentTask = "COPY";
                        Program.oIISMoverFunction.Type = 3;
                        //Program.oTargetFileDialog.Filter = "";
                        break;
                    case 4:
                        waitMessageTextBox.Text = "";
                        waitTimeOutTextBox.Text = "";
                        ShowWaitFunctions();                        
                        Program.sCurrentTask = "WAIT";                        
                        Program.oIISMoverFunction.Type = 4;
                        break;
                }
                addButton.Enabled = true;
                Program.oIISMoverFunction.Name = Program.sCurrentTask + Program.oIISMoverList.lIISMoverFunctions.Count.ToString();                
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool bReadyToAdd = true;
            int _iZipCounter = 0;
            String sMethod = "";
            String sText = "";
            String sIssues = ""; // for a future release to be more explicit with what is not entered correctly.
            int iTest = 0;
            List<string> _lToCopy = new List<string>();
            // checks are different depending on the current 
            switch (Program.sCurrentTask)
            {
                case "API":
                    // requires method
                    if (apiListBox.SelectedIndex != -1)
                    {
                         sMethod = apiListBox.SelectedItem.ToString();
                    } 
                    else
                    {
                        bReadyToAdd = false;
                    }                    
                    // requires text
                    
                    if (apiCallTextBox.Text.Length > 0)
                    {
                        sText = apiCallTextBox.Text;
                    }
                    else
                    {
                        bReadyToAdd = false;
                    }
                    if (bReadyToAdd)
                    {
                        // timeout is optional
                        if (apiTimeoutTextBox.Text.Length > 0)
                        {
                            try
                            {
                                iTest = Int32.Parse(apiTimeoutTextBox.Text);
                                Program.oIISMoverFunction.dKVPs.Add("Timeout", iTest.ToString());
                            }
                            catch (FormatException ex)
                            {
                                bReadyToAdd = false;
                            }
                        }
                        if (bReadyToAdd)
                        {
                            Program.oIISMoverFunction.dKVPs.Add("Method", sMethod);
                            Program.oIISMoverFunction.dKVPs.Add("CallText", sText);
                        }

                    }
                    break;
                case "APP":
                    // app pool is selected
                    if (Program.sAppPoolName.Length > 0)
                    {
                        if (Program.bAppPoolStart)
                        {
                            // action is always selected selected
                            Program.oIISMoverFunction.dKVPs.Add("StartOrStop", "Start");
                        }
                        else
                        {
                            Program.oIISMoverFunction.dKVPs.Add("StartOrStop", "Stop");
                        }
                        
                        Program.oIISMoverFunction.dKVPs.Add("AppPoolName", Program.sAppPoolName);
                        Program.oIISMoverFunction.dKVPs.Add("Timeout", "1"); // default value.  This is for future versions                        
                    }
                    else 
                    {
                        bReadyToAdd = false;
                    }
                    appPoolListBox.ClearSelected();
                    break;
                case "ZIP":
                    // source is filled out
                    // destination is filled out         
                    try
                    {
                        _lToCopy = Program.lFileNames.ToList();
                        if (_lToCopy.Count > 0)
                        {
                            // destination is filled out
                            if (Program.oTargetFileDialog.FileName.Length > 0)
                            {
                                _iZipCounter = 0;
                                Program.oIISMoverFunction.dKVPs.Add("Target", Program.oTargetFileDialog.FileName);
                                _lToCopy = new List<string>();
                                _lToCopy = Program.lFileNames.ToList();
                                foreach (String sFileName in _lToCopy)
                                {
                                    Program.oIISMoverFunction.dKVPs.Add("ZIP" + _iZipCounter.ToString(), sFileName);
                                    _iZipCounter++;
                                }
                            }
                            else
                            {
                                bReadyToAdd = false;
                            }                            
                        }
                        else
                        {
                            bReadyToAdd = false;
                        }
                    }
                    catch (ArgumentNullException ex)
                    {
                        bReadyToAdd = false;
                    }
                    break;
                case "COPY":
                    // source is filled out                   
                    try
                    {
                        _lToCopy = new List<string>();
                        _lToCopy = Program.lFileNames.ToList();
                        if (_lToCopy.Count > 0)
                        {
                            // destination is filled out
                            string _sTarget = Program.oTargetFolderDialog.SelectedPath;
                            if (_sTarget.Length > 0)
                            {
                                foreach (String sFileName in _lToCopy)
                                {
                                    Program.oIISMoverFunction.dKVPs.Add(sFileName, _sTarget + @"\" + Path.GetFileName(sFileName));
                                    HideAllFunctions();
                                    LockOrUnlockButtons();
                                }
                            }
                            else
                            {
                                bReadyToAdd = false;
                            }
                        }
                    }
                    catch (ArgumentNullException ex)                    
                    {
                        bReadyToAdd = false;
                    }

                    break;
                case "WAIT":
                    // timeout is required
                    try
                    {
                        iTest = Int32.Parse(waitTimeOutTextBox.Text);                        
                        if (waitMessageTextBox.Text.Length > 0)
                        {
                            Program.oIISMoverFunction.dKVPs.Add("WaitText", waitMessageTextBox.Text);
                        }
                        Program.oIISMoverFunction.dKVPs.Add("Timeout", iTest.ToString());
                    }
                    catch (FormatException ex)
                    {
                        bReadyToAdd = false;
                    }
                    // 
                    break;
            }
            if (bReadyToAdd)
            {                
                Program.oIISMoverList.lIISMoverFunctions.Add(Program.oIISMoverFunction);
                resultsTextBox.Text = "";
                Program.oIISMoverFunction = new IISMoverFunction();
                addButton.Enabled = false;
                RefreshTaskList();
            } else
            {
                MessageBox.Show("Please verify that every setting is properly selected.");
            }
        }

        private void sourceButton_Click_1(object sender, EventArgs e)
        {
            sourceTextBox.Text = "";
            List<string> _lToCopy = new List<string>();
            if (Program.oSourceFileDialog.ShowDialog() == DialogResult.OK) {
                Program.lFileNames = Program.oSourceFileDialog.FileNames;
                _lToCopy = Program.lFileNames.ToList();
                foreach (String sFileName in _lToCopy)
                {
                    sourceTextBox.Text += sFileName + ";";                    
                }
            }            
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            string sTarget = "";
            targetTextBox.Text = "";
            switch (Program.sCurrentTask)
            {
                case "COPY":
                    if (Program.oTargetFolderDialog.ShowDialog() == DialogResult.OK)
                    {
                        sTarget = Program.oTargetFolderDialog.SelectedPath;
                    }
                    break;
                case "ZIP":
                    if (Program.oTargetFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        sTarget = Program.oTargetFileDialog.FileName;
                    }
                    break;
            }
            targetTextBox.Text += sTarget;
        }

        private void appPoolListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appPoolListBox.SelectedIndex != -1)
            {
                Program.sAppPoolName = appPoolListBox.SelectedItem.ToString();                
            }               
        }

        private void waitMessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sMessage = "";            
            if (taskListBox.SelectedIndex != -1)
            {                
                if (taskListBox.SelectedIndex == 0)
                {
                    upBotton.Enabled = false;
                } 
                else
                {
                    if (Program.oIISMoverList.lIISMoverFunctions.Count > 1)
                    {
                        upBotton.Enabled = true;
                    }
                }
                if (taskListBox.SelectedIndex == (Program.oIISMoverList.lIISMoverFunctions.Count - 1))                
                {
                    downButton.Enabled = false;
                }
                else
                {
                    if (Program.oIISMoverList.lIISMoverFunctions.Count > 1)
                    {
                        downButton.Enabled = true;
                    }
                }
                foreach (IISMoverFunction oThisMoverFunction in Program.oIISMoverList.lIISMoverFunctions)
                {
                    if (taskListBox.SelectedItem.Equals(oThisMoverFunction.Name))
                    {
                        sMessage = "Results" + Environment.NewLine;
                        sMessage += "Name: " + oThisMoverFunction.Name + Environment.NewLine;
                        sMessage += "Type: " + oThisMoverFunction.Type.ToString() + Environment.NewLine;
                        foreach (var oThisKVP in oThisMoverFunction.dKVPs)
                        {
                            sMessage += oThisKVP.ToString() + Environment.NewLine;
                        }                        
                    }
                }
                MessageBox.Show(sMessage);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Program.oIISMoverList.Save();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.oIISMoverList.Load());
            RefreshTaskList();
        }

        private void resultsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void downButton_Click(object sender, EventArgs e)
        {
            // move down
            IISMoverFunction oTempUp = new IISMoverFunction();
            IISMoverFunction oTempDown = new IISMoverFunction();
            int _iIndex = 0;
            foreach (IISMoverFunction oThisMoverFunction in Program.oIISMoverList.lIISMoverFunctions)
            {
                if (taskListBox.SelectedItem.Equals(oThisMoverFunction.Name))
                {
                    oTempDown = oThisMoverFunction;
                    oTempUp = Program.oIISMoverList.lIISMoverFunctions[(_iIndex + 1)];
                    break;
                }
                _iIndex++;
            }
            Program.oIISMoverList.lIISMoverFunctions[_iIndex] = oTempUp;
            Program.oIISMoverList.lIISMoverFunctions[(_iIndex + 1)] = oTempDown;
            RefreshTaskList();
        }

        private void RefreshTaskList()
        {
            HideAllFunctions();
            LockOrUnlockButtons();
            UpdateTaskListBox();
            FunctionListBox.ClearSelected();
        }

        private void taskDeleteButton_Click(object sender, EventArgs e)
        {
            int _iIndex = 0;
            foreach (IISMoverFunction oThisMoverFunction in Program.oIISMoverList.lIISMoverFunctions)
            {
                if (taskListBox.SelectedItem.Equals(oThisMoverFunction.Name))
                {
                    Program.oIISMoverList.lIISMoverFunctions.RemoveAt(_iIndex);
                    break;
                }
                _iIndex++;
            }
            RefreshTaskList();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            String sErrorMessage = "";
            String sSummary = "Tasks complete!";
            resultsTextBox.Text = "";
            AppPoolService oAppPoolService = new AppPoolService();
            APICallService oAPICallService = new APICallService();
            FileCompressService oFileCompressService = new FileCompressService();
            FileCopyService oFileCopyService = new FileCopyService();
            List<string> lFileNames = new List<string>();
            List<string> lTargetNames = new List<string>();

            foreach (IISMoverFunction oThisMoverFunction in Program.oIISMoverList.lIISMoverFunctions)
            {
                try
                {
                    // 0 = API Call, 1 = App Pool, 2 = Compress, 3 = Copy, 4 = Wait
                    switch (oThisMoverFunction.Type)
                    {
                        case 0:
                            oAPICallService.MakeCall(oThisMoverFunction.dKVPs["Method"], oThisMoverFunction.dKVPs["CallText"]);
                            break;
                        case 1:
                            if (oThisMoverFunction.dKVPs["StartOrStop"].Trim().ToUpper().Equals("STOP"))
                            {
                                oAppPoolService.StopAppPool(oThisMoverFunction.dKVPs["AppPoolName"], Int32.Parse(oThisMoverFunction.dKVPs["Timeout"]));
                            } 
                            else
                            {
                                oAppPoolService.StartAppPool(oThisMoverFunction.dKVPs["AppPoolName"], Int32.Parse(oThisMoverFunction.dKVPs["Timeout"]));
                            }
                            break;
                        case 2:
                            lFileNames = new List<string>();
                            foreach (var oThisKVP in oThisMoverFunction.dKVPs)
                            {
                                if (oThisKVP.Key.Contains("ZIP")){
                                    lFileNames.Add(oThisKVP.Value);
                                }
                            }
                            oFileCompressService.CompressFiles(lFileNames, oThisMoverFunction.dKVPs["Target"]);
                            break;
                        case 3:
                            lFileNames = new List<string>();
                            lTargetNames = new List<string>();
                            foreach (var oThisKVP in oThisMoverFunction.dKVPs)
                            {
                                lFileNames.Add(oThisKVP.Key);                                
                                lTargetNames.Add(oThisKVP.Value);
                            }
                            oFileCopyService.CopyFiles(lFileNames, lTargetNames);
                            break;
                        case 4:
                            MessageBox.Show(oThisMoverFunction.dKVPs["WaitText"]);
                            Thread.Sleep(1000 * Int32.Parse(oThisMoverFunction.dKVPs["Timeout"]));
                            break;
                    }                    
                    resultsTextBox.Text += oThisMoverFunction.Name + " processed OK" + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    sErrorMessage += oThisMoverFunction.Name + " error: " + ex.Message + Environment.NewLine;
                    resultsTextBox.Text += oThisMoverFunction.Name + " error: " + ex.Message + Environment.NewLine;
                    DialogResult oDialogResult = MessageBox.Show(sErrorMessage, "Continue?", MessageBoxButtons.YesNo);
                    if (oDialogResult == DialogResult.Yes)
                    {
                        // notify of user continuing
                    }
                    else if (oDialogResult == DialogResult.No)
                    {
                        // stop
                        break;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
            MessageBox.Show(sSummary);
        }

        private void apiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
