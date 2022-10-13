using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automateWork.Functions
{
    public class verifyCompressed
    {
        private string path;

        public verifyCompressed(string _path)
        {
            this.path = _path;
        }

        public void timeOutVerify()
        {
            bool foundCompressed = false;

            while (!foundCompressed)
            {
                DirectoryInfo dir = new DirectoryInfo(this.path);
                FileInfo[] files = dir.GetFiles();

                //if ()
                //{
                //    foundCompressed = true;
                //}
                Thread.Sleep(30000);
            }
        }
    }
}
