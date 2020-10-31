// Chad Weirick
// GCU & TPS
// IIS Mover
// Overall use: this is the master IISMoverList object
// Methods: Save() self-descriptive, saves an IISListMoverFunctionList
// Load() // self-descriptive, loads an IISListMoverFunctionList

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace IIS_Mover
{
    class IISMoverList
    {
        public List<IISMoverFunction> lIISMoverFunctions { get; set; }

        public IISMoverList New()
        {            
            return this;
        }

        public String Save() // saves an IISListMoverFunctionList
        {
            String sResult = "Successfully completed!";
            Program.oTargetFileDialog.Title = "Save task list";
            if (Program.oTargetFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter oStreamWriter = new StreamWriter(Program.oTargetFileDialog.FileName);
                    foreach (IISMoverFunction oThisMoverFunction in Program.oIISMoverList.lIISMoverFunctions)
                    {
                        oStreamWriter.WriteLine("ItemID:" + oThisMoverFunction.ID);
                        oStreamWriter.WriteLine("ItemName:" + oThisMoverFunction.Name);
                        oStreamWriter.WriteLine("ItemType:" + oThisMoverFunction.Type);
                        foreach (var oThisKVP in oThisMoverFunction.dKVPs)
                        {
                            oStreamWriter.WriteLine(oThisKVP.ToString());
                        }
                    }
                    oStreamWriter.Close();
                }
                catch (Exception ex)
                {
                    sResult = "Exception: " + ex.Message;                    
                }
            }
            return sResult;
        }

        public String Load() // saves an IISListMoverFunctionList
        {           
            String sResult = "Successfully loaded.";
            String sLine;
            String[] lComponents;
            int iCounter = 0;
            int iKVPCounter = 0;
            bool bIsKVP = false;            
            Program.oSourceFileDialog.Multiselect = false;
            if (Program.oSourceFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader oStreamReader = new StreamReader(Program.oSourceFileDialog.FileName);
                sLine = oStreamReader.ReadLine();
                IISMoverFunction oThisMoverFunction = new IISMoverFunction();
                while (sLine != null)
                {
                    bIsKVP = true;                    
                    // detect new IISMoverFunction                    
                    if (sLine.Contains("ItemID:"))
                    {
                        if (iCounter > 0)
                        {                            
                            this.lIISMoverFunctions.Add(oThisMoverFunction);                            
                        }
                        iCounter++;
                        oThisMoverFunction = new IISMoverFunction();
                        
                        oThisMoverFunction.ID = Int32.Parse(sLine.Replace("ItemID:", ""));
                        bIsKVP = false;
                    }
                    if (sLine.Contains("ItemName:"))
                    {
                        oThisMoverFunction.Name = sLine.Replace("ItemName:", "");
                        bIsKVP = false;
                    }
                    if (sLine.Contains("ItemType:"))
                    {
                        oThisMoverFunction.Type = Int32.Parse(sLine.Replace("ItemType:", ""));
                        bIsKVP = false;
                    }
                    if (bIsKVP)
                    {
                        sLine = sLine.Replace("[", "");
                        sLine = sLine.Replace("]", "");
                        lComponents = sLine.Split(',');              
                        if (iKVPCounter == 0)
                        {
                            oThisMoverFunction.dKVPs = new Dictionary<string, string>();
                        }
                        iKVPCounter++;                        
                        oThisMoverFunction.dKVPs.Add(lComponents[0].ToString().Trim(), lComponents[1].ToString().Trim());
                    } 
                    else
                    {
                        // reset the key value pair counter
                        iKVPCounter = 0;
                    }
                    sLine = oStreamReader.ReadLine();
                }
                if (bIsKVP)
                {
                    this.lIISMoverFunctions.Add(oThisMoverFunction);
                }                
                oStreamReader.Close();
            }            
            Program.oSourceFileDialog.Multiselect = true;            
            return sResult;
        }

    }
}
