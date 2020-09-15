using IViewNet.Common;
using IViewNet.Common.Models;

namespace IView.Core.Networking
{
    public class PacketRegister
    {
        public PacketManager PacketManager { get; set; }
        public PacketRegister(PacketManager PacketManager)
        {
            this.PacketManager = PacketManager;
        }
        public void RegisterUserPackets()
        {
            PacketManager.AddPacket(new Packet(3, "ClientInformation", null));
        }
    }
}