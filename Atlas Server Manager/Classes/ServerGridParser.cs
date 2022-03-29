using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AtlasServerManager
{
    public class ServerGridParser
    {
        static Rootobject serverGrid;

        public static bool LoadFile(string fileName)
        {
            serverGrid = JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(fileName));
            if (serverGrid == null)
                return false;

            return true;
        }

        public static Server[] GetServers()
        {
            if (serverGrid == null)
                return null;

            return serverGrid.servers;
        }
    }
}
