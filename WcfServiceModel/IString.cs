using System.ServiceModel;

namespace WcfServiceModel
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IString”。
    [ServiceContract]  // 指明该类是一个WCF接口的类
    public interface IString
    {
        [OperationContract]  // 指明该方法是一个WCF接口的方法
        string GethuashiServerString(string str);
    }
}
