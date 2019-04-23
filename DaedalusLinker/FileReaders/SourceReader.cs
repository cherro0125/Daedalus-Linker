using System;
using System.Collections.Generic;
using System.IO;
using DaedalusLinker.Utils;

namespace DaedalusLinker.FileReaders
{
    public class SourceReader
    {
        public List<SourcePath> paths { get; set; }
        public String filesContent { get; set; }

        public SourceReader(String srcPath)
        {
            this.paths = new List<SourcePath>();
            filesContent = String.Empty;
            using (StreamReader sr = File.OpenText(srcPath))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    s = Path.GetDirectoryName(srcPath) + "/" + s;
                    this.paths.Add(TextUtils.TrimPath(s));
                }
            }
        }


        public void ConcatFilesText(bool removeComments = false)
        {
            foreach (var folderPath in paths)
            {

                foreach (string file in Directory.EnumerateFiles(folderPath.path, folderPath.wildCard))
                {
                    string contents = File.ReadAllText(file);
                    if (removeComments)
                        contents = TextUtils.StripComments(contents);
                    filesContent += contents;
                }

            }

        }
    }
}
