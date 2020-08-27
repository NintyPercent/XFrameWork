﻿using System;
using System.IO;

namespace ExcelToProtobuf
{
    class Program
    {
        static void Main(string[] args)
        {
            string exePath = Directory.GetCurrentDirectory();
            string parentPath = Directory.GetParent(exePath).FullName;
            string topPath = Directory.GetParent(parentPath).FullName;
            string configFilePath = Path.Combine(topPath, "Config/PathConfig.txt");
            
            if (File.Exists(configFilePath))
            {
                string[] lines = File.ReadAllLines(configFilePath);
                if (lines.Length < 2)
                {
                    Console.WriteLine($"{configFilePath}配置文件规则不正确，请按照规则进行修改");
                }
                else
                {
                    if (Directory.Exists(lines[0]) && Directory.Exists(lines[1]))
                    {
                        string[] paths = ReadExcel.GetAllExcelPaths(lines[0]);
                        ReadExcel.CreateClientFile(lines[1]);
                        for (int i = 0; i < paths.Length; i++)
                        {
                            ReadExcel.OpenExcel(paths[i]);
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Excel表全部转换完成！！！");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine($"{configFilePath}配置文件填写的路径不正确，请填写正确的文件路径！！！");
                    }
                }
            }
            else //没有配置文件就创建配置文件并提醒填写路径： excel路径、proto输出路径 
            {
                string dir = Path.GetDirectoryName(configFilePath);
                Console.WriteLine(dir);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                File.Create(configFilePath);
                Console.WriteLine("配置文件创建完成，请按规则填写好路径配置文件！！！");
            }
            Console.ReadKey();
        }
    }
}