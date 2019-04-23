using System;
using DaedalusLinker.FileReaders;
using DaedalusLinker.FileWriters;

namespace DaedalusLinker
{
    public class Linker
    {
        public static void ReadSourceAndSaveOutput(string srcPath, string outputPath, bool removeComments = false)
        {
            try
            {
                SourceReader reader = new SourceReader(srcPath);
                reader.ConcatFilesText(removeComments);
                OutputWriter ow = new OutputWriter(outputPath, reader.filesContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        
        }
    }
}