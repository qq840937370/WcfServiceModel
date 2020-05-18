using System.ServiceModel;

namespace WcfServiceModel
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUser”。
    [ServiceContract] // 指明该接口是一个WCF的接口，如果不加的话，将不能被外部调用
    public interface IUser
    {
        [OperationContract]  // 指明该方法是一个WCF接口的方法，不加的话将不能被外部调用
        string ShowName(string name);
    }
}
