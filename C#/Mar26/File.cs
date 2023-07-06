using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mar26
{
    internal class File
    {
        public File() 
        {
          //  FileInfo fi = new FileInfo("D:\\Sample.txt");
          //  fi.Delete();
            FileInfo fi1 = new FileInfo("D:\\Sample1.txt");
            
            fi1.MoveTo("D:\\New folder\\"+"Sample1.txt");



        }

        

    }
}
