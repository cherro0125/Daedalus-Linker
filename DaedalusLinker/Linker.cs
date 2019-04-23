using System;
using DaedalusLinker.FileReaders;

namespace DaedalusLinker
{
    public class Linker
    {
        public static void ReadSourceAndSaveOutput(string srcPath, string outputPath, bool removeComments = false)
        {
            SourceReader reader = new SourceReader(srcPath);
            reader.ConcatFilesText(removeComments);
            OutputWriter ow = new OutputWriter(outputPath,reader.filesContent);
        }
    }
}