using System;  //Using 关键字, System命名空间！
using System.IO;
using Google.Protobuf;

namespace HelloWorldApplication //namespace声明命名空间,包含一个helloworld的类！
{
    /* 类名为 HelloWorld */
    class HelloWorld  
    {
        /* main函数 */
        static void Main(string[] args)//main函数是C#的接入口！
        {
            /* 我的第一个 C# 程序 */

            Db.fd_task task = new Db.fd_task
            {
                TaskId = 1001,
                Count = 1,
                State = 1,
            };

            byte[] buffer = task.ToByteArray();

            Db.fd_task p = Db.fd_task.Parser.ParseFrom(buffer);

            Console.WriteLine("Hello World!");//这个一句输出语句！
            Console.ReadKey();//这个语句为了防止输出窗口一跳而过！
        }
    }
}
