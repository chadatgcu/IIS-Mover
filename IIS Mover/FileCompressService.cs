// Chad Weirick
// GCU & TPS
// IIS Mover
// Overall use: allows for compression of files 
// Methods:  CompressFiles(List<string> lFilesToZip, string sTargetName) compresses specified files into a specified zip

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIS_Mover
{
    class FileCompressService
    {
        public string CompressFiles(List<string> lFilesToZip, string sTargetName) // Compresses specified files into a specified zip
        {
            string sResults = "";
            using (ZipArchive oZip = ZipFile.Open(sTargetName, ZipArchiveMode.Create))
            {
                foreach (String sThisFile in lFilesToZip)
                {
                    oZip.CreateEntryFromFile(sThisFile, Path.GetFileName(sThisFile));
                }                                
            }
            return sResults;
        }
    }
}
