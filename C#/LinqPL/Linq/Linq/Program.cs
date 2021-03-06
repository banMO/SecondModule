﻿using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIRST PART
            //string path = @"C:\windows";
            //ShowLargeFilesWithoutLinq(path);
            //Console.WriteLine("************************");
            //ShowLargeFilesWithLinq(path);
            //Console.WriteLine("----------------");
            //ShowLargeFilesWithLinqSecondMethod(path);

            //SECOND PART

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee{ Id = 1, Name = "Ana"},
                new Employee{ Id = 2, Name = "Cris"},
                new Employee{ Id = 2, Name = "Luis"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{ Id = 1, Name = "Alex"},
            };

            Console.WriteLine(developers.Count());
            IEnumerator<Employee> enumerator = sales.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }
        }

        //private static void ShowLargeFilesWithLinqSecondMethod(string path)
        //{
        //    var query = new DirectoryInfo(path).GetFiles()
        //                .OrderByDescending(f => f.Length)
        //                .Take(5);

        //    foreach (var file in query)
        //    {
        //        Console.WriteLine($"{file.Name} : {file.Length,10:N0}");
        //    }
        //}

        //private static void ShowLargeFilesWithLinq(string path)
        //{
        //    var query = from file in new DirectoryInfo(path).GetFiles()
        //                orderby file.Length descending
        //                select file;
        //    foreach(var file in query.Take(5))
        //    {
        //        Console.WriteLine($"{file.Name} : {file.Length,10:N0}");
        //    }
        //}

        //private static void ShowLargeFilesWithoutLinq(string path)
        //{
        //    DirectoryInfo directory = new DirectoryInfo(path);
        //    FileInfo[] files = directory.GetFiles();
        //    Array.Sort(files, new FileInfoComparer());
        //    //foreach(FileInfo file in files)
        //    //{
        //    //    Console.WriteLine($"{file.Name} : {file.Length}");
        //    //}
        //    for(int i = 0; i < 5; i++)
        //    {
        //        FileInfo file = files[i];
        //        Console.WriteLine($"{file.Name} : {file.Length, 10:N0}");
        //    }
        //}
    }

    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
