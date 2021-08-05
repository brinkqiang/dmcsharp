using System;  //Using 关键字, System命名空间！
using System.IO;
using System.Text;

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

            string strInput = "data1234";

            byte[] InArray = System.Text.Encoding.ASCII.GetBytes(strInput);
            byte[] OutArray = System.Text.Encoding.ASCII.GetBytes(strInput);

            oArc4.Encrypt(InArray, 0, OutArray, 0, InArray.Length);

            var hexString = BitConverter.ToString(OutArray);
            Console.WriteLine(hexString);

            oArc4.Decrypt(OutArray, 0, InArray, 0, OutArray.Length);

            string strOut = System.Text.Encoding.ASCII.GetString(InArray);
            Console.WriteLine(strOut);

            oArc4.Encrypt(InArray);
            oArc4.Decrypt(InArray);

            string strOut2 = System.Text.Encoding.ASCII.GetString(InArray);

            Console.WriteLine(strOut2);
        }
    }
}
