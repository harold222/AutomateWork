using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Text;

namespace automateWork.Functions
{
    public class verifyCompressed
    {
        private string pathExtract, extension, pathSearch;

        public verifyCompressed(string _pathSearch, string _pathExtract, string _extension)
        {
            this.pathExtract = _pathExtract;
            this.extension = _extension;
            this.pathSearch = _pathSearch;
        }

        public void timeOutVerify()
        {
            bool foundCompressed = false;

            try
            {
                while (!foundCompressed)
                {
                    DirectoryInfo dir = new DirectoryInfo(this.pathSearch);
                    FileInfo[] files = dir.GetFiles($"*.{this.extension.ToLower()}");

                    // obtiene un listado de todos los archivos con esa extension, si
                    // hay mas de uno se deberian mostrar en forma de lista en el programa
                    // para que el usuario escoja cual quiere escojer

                    // una vez se escoja se busca por ese nombre, se corta ese archivo se pega
                    // en la ruta de crear, se descomprime y se elimina ese archivo

                    if (files?.Length > 0)
                    {
                        FileInfo? fileCompressed = files.FirstOrDefault();
                        if (fileCompressed != null)
                        {
                            ZipFile.ExtractToDirectory(fileCompressed.FullName, this.pathExtract);
                            File.Delete(fileCompressed.FullName);
                            //if ()
                            //{
                            //    foundCompressed = true;
                            //}
                        }
                        else Thread.Sleep(30000);
                    }
                    else Thread.Sleep(30000);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
