using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AtlasServerManager
{
    public class AtlasServerManagerSettings
    {
        public bool StartWithWindows = true;
        public int StartDelayInSecs = 5;
        public int StopDelayInSecs = 5;
        public int NumAttemptGameSave = 3;
        public int MaxSecsBeforeKillCommand = 30;

        public DirectorySettings DirectorySettings = new();
        public DatabaseConnectionSettings DatabaseConnectionSettings = new();
        public ServerSettings ServerSettings = new();
        public ModSettings ModSettings = new();
        public RconSettings RconSettings = new();
        public SteamSettings SteamSettings = new();
    }

    public class DirectorySettings
    {
        public string AtlasDirectory = "C:/AtlasSrv";
        public int AltSaveDirectoryType = 1;
        public string AltSaveDirectory = "";
    }

    public class DatabaseConnectionSettings
    {
        public string type = "mysql";
        public string host = "127.0.0.1";
        public int port = 3306;
        public string username = "root";
        public string password = "password";
        public string database = "atlasservermanager";
    }

    public class ServerSettings
    {
        public string CommandLineArguments = "-log -server -servergamelog -NoBattleEye";
        public string AdminPassword = "ChangeMe";
        public int MaxPlayers;
        public int ReservedSlots;
        public string MapName = "ocean";
        public bool StartServersAsService;
        public bool StartServersMinimized = true;
        public string GridNamingScheme = "";
    }

    public class ModSettings
    {
        public bool ManageMods = true;
        public int ModDownloadTimeoutInMins = 10;
        public bool DetectModChanges = true;
        public bool AutoInstallModChanges = true;
    }

    public class RconSettings
    {
        public string RconIpAddress = "127.0.0.1";
        public bool UseGameUserSettingsPorts;
        public int[] RconPortsCustom;
    }

    public class SteamSettings
    {

    }
}
