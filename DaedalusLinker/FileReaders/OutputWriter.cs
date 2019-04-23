using System;
using System.IO;

namespace DaedalusLinker.FileReaders
{
    public class OutputWriter
    {
        public String content { get; set; }

        public OutputWriter(String outputPath, String outputContent = null)
        {
            content = outputContent;
            using (StreamWriter sw = new StreamWriter(outputPath))
            {
                sw.WriteLine(content);                
            }
        }
    }
}