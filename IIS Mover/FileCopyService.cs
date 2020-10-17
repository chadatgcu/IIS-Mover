// 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIS_Mover
{
    class FileCopyService
    {
        public string CopyFiles(List<string> lSourceFiles, List<string> lTargetFiles)
        {
            string sResults = "";
            int iCounter = 0;
            foreach (string sThisFile in lSourceFiles)
            {               
                if (!Directory.Exists(Path.GetDirectoryName(lTargetFiles[iCounter])))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(lTargetFiles[iCounter]));
                }
                File.Copy(sThisFile, lTargetFiles[iCounter], true);
                iCounter++;
            }
            return sResults;
        }
    }
}
