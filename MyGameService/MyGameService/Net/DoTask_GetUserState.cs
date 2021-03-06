﻿using MyGameService.Game;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SocketUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameService.Net
{
    class DoTask_GetUserState
    {
        public static void Do(ClientInfo clientInfo, string data)
        {
            C2S_GetUserState c2s = JsonConvert.DeserializeObject<C2S_GetUserState>(data);

            RoomLogic roomLogic = RoomManager.getRoomByUserId(c2s.userId_list[0]);
            if(roomLogic != null)
            {
                roomLogic.getUserState(clientInfo,c2s);
            }
        }
    }
}
