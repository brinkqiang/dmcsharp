using System;  //Using 关键字, System命名空间！
namespace HelloWorldApplication //namespace声明命名空间,包含一个helloworld的类！
{
    /* 类名为 HelloWorld */
    class HelloWorld  
    {
        /* main函数 */
        static void Main(string[] args)//main函数是C#的接入口！
        {
            /* 我的第一个 C# 程序 */
            Console.WriteLine("Hello World!");//这个一句输出语句！
            Console.ReadKey();//这个语句为了防止输出窗口一跳而过！
        }
    }
}
