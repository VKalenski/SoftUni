using System;
using System.IO.Compression;

namespace _06_ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\GitHub_Repository\03_CSharp_Advanced\01_CSharp_Advanced\10_EXERCISE STREAMS, FILES AND DIRECTORIES\01_\Text",
@"C:\GitHub_Repository\03_CSharp_Advanced\01_CSharp_Advanced\10_EXERCISE STREAMS, FILES AND DIRECTORIES\01_\Text2.zip");
            ZipFile.ExtractToDirectory(@"C:\GitHub_Repository\03_CSharp_Advanced\01_CSharp_Advanced\10_EXERCISE STREAMS, FILES AND DIRECTORIES\01_\Text2.zip",
                @"C:\GitHub_Repository\03_CSharp_Advanced\01_CSharp_Advanced\10_EXERCISE STREAMS, FILES AND DIRECTORIES\01_\Text2");
        }
    }
}
