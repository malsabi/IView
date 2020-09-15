using IView.Core.Models;
using IViewNet.Common;

namespace IView.Core.Interfaces
{
    public interface IUpdate
    {
        void UpdateFormListview();
        void UpdateFormLog(LogModel Log);
        void UpdateDefaultServerSettings(NetConfig ServerConfig, NetConfig ClientConfig);
        NetConfig GetDefaultServerSettings();
    }
}