using System.Collections.Generic;
using System.IO;

namespace CodeCounter
{
    internal class VcxprojReader
    {
        private readonly string filename;
        public VcxprojReader(string filename)
        {
            this.filename = filename;
        }

        public long TotalLines()
        {
            long total = 0;

            // load the vcxproj file
            string vcxprojFile = Loadvcxproj();

            // get a list of the filenames
            List<string> filenames = GetvcxprojFilenames(vcxprojFile);

            // loop over list, getting the length of each file and adding it to total
            foreach (var item in filenames)
            {
                StreamReader sr = new StreamReader(item);
                string file = sr.ReadToEnd();
                CStyleCounter counter = new CStyleCounter(file);
                total += counter.Count();
            }

            return total;

        }

        private string Loadvcxproj()
        {
            StreamReader streamReader = new System.IO.StreamReader(filename);
            string vcxproj = streamReader.ReadToEnd();
            streamReader.Close();
            return vcxproj;
        }

        private List<string> GetvcxprojFilenames(string vcxprojFile)
        {
            List<string> filenames = new List<string>();
            // find all the xml tags that contain <Compile Include=

            foreach (var item in vcxprojFile.Split('\n'))
            {
                if (item.Contains("Compile Include="))
                {
                    string file = item.Trim().Substring(item.Trim().IndexOf("Include=\"") + 9, item.Trim().Length - (item.Trim().IndexOf("Include=\"") + 9));

                    // create full path to the source file
                    string parent = Path.GetDirectoryName(filename) + "\\";
                    parent += file;

                    if (parent.Contains("/"))
                        parent = parent.Remove(parent.IndexOf("/"), 1);
                    if (parent.Contains("\""))
                        parent = parent.Remove(parent.IndexOf("\""), 1);
                    if (parent.Contains(">"))
                        parent = parent.Remove(parent.IndexOf(">"), 1);
                    parent = parent.Trim();
                    filenames.Add(parent);
                }
                else if (item.Contains("Include Include=")) // get header files
                {
                    string file = item.Trim().Substring(item.Trim().IndexOf("Include=\"") + 9, item.Trim().Length - (item.Trim().IndexOf("Include=\"") + 9));

                    // create full path to the source file
                    string parent = Path.GetDirectoryName(filename) + "\\";
                    parent += file;

                    if (parent.Contains("/"))
                        parent = parent.Remove(parent.IndexOf("/"), 1);
                    if (parent.Contains("\""))
                        parent = parent.Remove(parent.IndexOf("\""), 1);
                    if (parent.Contains(">"))
                        parent = parent.Remove(parent.IndexOf(">"), 1);
                    parent = parent.Trim();
                    filenames.Add(parent);
                }
            }

            return filenames;
        }
    }
}
