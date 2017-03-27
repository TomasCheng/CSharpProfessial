using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007File
{
    class Program
    {
        static void Main(string[] args)
        {
//            //相对路径指的是当前运行环境的同一路径，要使得运行时可以找到这个文件，在.txt文件的属性里面设置成 始终复制
//            //FileInfo fileInfo = new FileInfo("TextFile1.txt");
//
//            //绝对路径
//            FileInfo fileInfo = new FileInfo(@"D:\work\cPlus\vsProjects\CSharpProfessial\_007File\bin\Debug\TextFile1.txt");
//            Console.WriteLine(fileInfo.Exists);
//            Console.WriteLine(fileInfo.Name);
//            Console.WriteLine(fileInfo.DirectoryName);
//            Console.WriteLine(fileInfo.Directory);
//            Console.WriteLine(fileInfo.Length);
//            Console.WriteLine(fileInfo.IsReadOnly);
//
//            Console.WriteLine(fileInfo.Attributes);
//
//            Console.WriteLine(fileInfo.LastAccessTime);
//
////            fileInfo.Delete();
//
//            
//            fileInfo.CopyTo("newTT.txt");

//            FileInfo fileInfo = new FileInfo("chengliang.txt");
//            if (fileInfo.Exists == false)
//            {
//                fileInfo.Create();
//            }
//            fileInfo.MoveTo("mm.txt");

            //文件夹

            //绝对路径
//            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\work\cPlus\vsProjects\CSharpProfessial\_007File\bin\Debug");
//
//            Console.WriteLine(directoryInfo.Exists);
//            Console.WriteLine(directoryInfo.Name);
//            Console.WriteLine(directoryInfo.FullName);
//            Console.WriteLine(directoryInfo.Root);
//            Console.WriteLine(directoryInfo.Parent);
//            Console.WriteLine(directoryInfo.CreationTime);
//
//            directoryInfo.CreateSubdirectory("chengliangdir");

//            DirectoryInfo directoryInfo = new DirectoryInfo("test");
//            if (directoryInfo.Exists == false)
//            {
//                directoryInfo.Create();
//            }
//            directoryInfo = directoryInfo.Parent;
//
//            if (directoryInfo != null)
//            {
//                FileInfo[] fileInfos = directoryInfo.GetFiles();
//                foreach (var fileInfo in fileInfos)
//                {
//                    Console.WriteLine(fileInfo);
//                }
//            }

//            DriveInfo driveInfo = new DriveInfo("d");
//            Console.WriteLine(driveInfo.Name);
//            Console.WriteLine(driveInfo.DriveFormat);
//            Console.WriteLine(driveInfo.AvailableFreeSpace);
//            Console.WriteLine(driveInfo.DriveType);
//            Console.WriteLine(driveInfo.IsReady);
//            Console.WriteLine(driveInfo.RootDirectory);
//            Console.WriteLine(driveInfo.TotalFreeSpace);
//            Console.WriteLine(driveInfo.TotalSize);
//            Console.WriteLine(driveInfo.VolumeLabel);




            Console.ReadKey();

        }
    }
}
