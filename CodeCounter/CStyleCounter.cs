using System.Collections.Generic;

namespace CodeCounter
{
    public class CStyleCounter : Counter
    {
        protected string File;

        public CStyleCounter(string file)
        {
            File = file;
        }

        protected List<string> Parse()
        {
            // parse File and return a list with a line on each item
            List<string> list = new List<string>();
            foreach (var item in File.Split('\n'))
            {
                list.Add(item);
            }
            return list;
        }

        public new long Count()
        {
            // counter variable
            long LineCount = 0;
            // get a list of the lines
            List<string> lines = Parse();

            bool inMultilineComment = false;

            // loop over lines and update counter
            for (int i  = 0; i < lines.Count; i++)
            {
                if (inMultilineComment) // we are in the middle of a multiline comment
                {
                    if (lines[i].Trim().StartsWith("*/")) // end multiline comment
                    {
                        inMultilineComment = false;
                    }
                    continue;
                }
                else if (lines[i].Trim() == "") // whitespace
                {
                    continue;
                }
                else if (lines[i].Trim().StartsWith("//")) // single line comments
                {
                    continue;
                }
                else if (lines[i].Trim().StartsWith("/*")) // multiline comments
                {
                    if (lines[i].Trim().Contains("*/")) // multiline comment on one line
                    {
                        continue;
                    }
                    inMultilineComment = true;
                    continue;
                }
                else
                {
                    LineCount++;
                }
            }

            return LineCount;
        }
    }
}
