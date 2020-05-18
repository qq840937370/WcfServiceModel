namespace WcfServiceModel
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“String”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 String.svc 或 String.svc.cs，然后开始调试。
    public class String : IString
    {
        public string GethuashiServerString(string str)
        {
            string str1 = "这个字符串是 "+ str;
            return str1;
        }
    }
}
