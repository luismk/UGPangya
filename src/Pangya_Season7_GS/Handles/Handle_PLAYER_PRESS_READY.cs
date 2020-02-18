﻿using Pangya_Season7_GS.Handles_Packet;
using PangyaAPI;
using PangyaAPI.BinaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangya_Season7_GS.Handles
{
    public class Handle_PLAYER_PRESS_READY : HandleBase<Packet_PLAYER_PRESS_READY>
    {
        public Handle_PLAYER_PRESS_READY(Player player) : base(player)
        {
            Handle();
        }

        private void Handle()
        {
            var response = new PangyaBinaryWriter();

            response.Write(new byte[] { 0x78, 0x00 });
            response.Write(Player.ConnectionId);
            response.Write(PacketResult.Ready);

            //Envia para todos
            Player.Game.Players.ForEach(p => p.SendResponse(response.GetBytes()));
        }
    }
}
