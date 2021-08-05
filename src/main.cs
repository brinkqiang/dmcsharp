using System;  //Using 关键字, System命名空间！
using System.IO;
using System.Text;
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
            CDMRC oArc4 = new CDMRC();
            oArc4.SetKey("1234");

            string strInput = "data\0d";

            byte[] InArray = System.Text.Encoding.ASCII.GetBytes(strInput);
            byte[] OutArray = System.Text.Encoding.ASCII.GetBytes(strInput);

            oArc4.Encrypt(InArray, 0, OutArray, 0, InArray.Length);
            oArc4.Decrypt(OutArray, 0, InArray, 0, OutArray.Length);

            string strOut = System.Text.Encoding.ASCII.GetString(InArray);
            Console.WriteLine(strOut);

            oArc4.Encrypt(InArray);
            oArc4.Decrypt(InArray);

            string strOut2 = System.Text.Encoding.ASCII.GetString(InArray);

            Console.WriteLine(strOut2);

            Db.fd_task task = new Db.fd_task
            {
                TaskId = 1001,
                Count = 1,
                State = 1,
            };

            byte[] buffer = task.ToByteArray();

            oArc4.Encrypt(buffer, 0, buffer, 0, buffer.Length);
            oArc4.Decrypt(buffer, 0, buffer, 0, buffer.Length);

            Db.fd_task copyTask = Db.fd_task.Parser.ParseFrom(buffer);

            Console.WriteLine(copyTask.ToString());
        }
    }
}
