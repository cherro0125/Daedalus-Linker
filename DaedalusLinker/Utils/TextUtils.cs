using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using DaedalusLinker.FileReaders;

namespace DaedalusLinker.Utils
{
    public class TextUtils
    {
        public static string StripComments(string code)
        {
            var re = @"(@(?:""[^""]*"")+|""(?:[^""\n\\]+|\\.)*""|'(?:[^'\n\\]+|\\.)*')|//.*|/\*(?s:.*?)\*/";
            return Regex.Replace(Regex.Replace(code, re, "$1"), @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);            
        }

        public static SourcePath TrimPath(string txt)
        {
            SourcePath sourcePath = new SourcePath();
            sourcePath.wildCard = Path.GetFileName(txt);
            sourcePath.path = Path.GetDirectoryName(txt);         
            return sourcePath;
        }
    }
}
