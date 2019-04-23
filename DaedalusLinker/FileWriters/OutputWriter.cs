using System;
using System.IO;

namespace DaedalusLinker.FileWriters
{
    public class OutputWriter
    {
        public String content { get; set; }

        public OutputWriter(String outputPath, String outputContent = null)
        {
            if (Path.GetExtension(outputPath).ToLower() != ".d")
                throw new Exception("Bad output extension!");            
            content = outputContent;
            using (StreamWriter sw = new StreamWriter(outputPath))
            {
                sw.WriteLine(content);                
            }
        }
    }
}