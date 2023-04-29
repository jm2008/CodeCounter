using System.Collections.Generic;
using System.IO;

namespace CodeCounter
{
    internal class csprojReader
    {
        private string filename;
        public csprojReader(string filename) 
        {
            this.filename = filename;
        }

        public long totalLines()
        {
            long total = 0;

            // load the csproj file
            string csprojFile = loadcsproj();

            // get a list of the filenames
            List<string> filenames = getcsprojFilenames(csprojFile);

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

        private string loadcsproj()
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader(filename);
            string csproj = streamReader.ReadToEnd();
            streamReader.Close();
            return csproj;
        }

        private List<string> getcsprojFilenames(string csprojFile)
        {
            List<string> filenames = new List<string>();
            // find all the xml tags that start with <Compile Include=

            foreach (var item in csprojFile.Split('\n'))
            {
                if (item.Trim().StartsWith("<Compile Include="))
                {
                    string file = item.Trim().Substring(18, item.Trim().Length - 20);

                    // create full path to the source file
                    string parent = System.IO.Path.GetDirectoryName(filename) + "\\";
                    parent += file;

                    if (parent.Contains("/"))
                        parent = parent.Remove(parent.IndexOf("/"), 1);
                    if (parent.Contains("\""))
                        parent = parent.Remove(parent.IndexOf("\""), 1);
                    parent = parent.Trim();
                    filenames.Add(parent);
                }
            }

            return filenames;
        }
    }
}
