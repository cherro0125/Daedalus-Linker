using System;
using System.IO;
using System.Linq;
using DaedalusLinker.FileReaders;
using DaedalusLinker.Utils;

namespace DaedalusLinker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("SYNTAX: dotnet DedalusLinker [src file path] -o [output path with file name] [optional: --removeComments]");
                return;
            }

            String path = args[0];
            String outputPath = String.Empty;

            if (!args.Contains("-o"))
            {
                Console.WriteLine("Used source path and default output filename.");
                outputPath = Path.GetDirectoryName(path) + "/" + "output.d";
            }
            else
            {
                outputPath = args[Array.LastIndexOf(args, "-o")+1];
            }

            Linker.ReadSourceAndSaveOutput(path,outputPath, args.Contains("--removeComments")); 
            
        }
    }
}
