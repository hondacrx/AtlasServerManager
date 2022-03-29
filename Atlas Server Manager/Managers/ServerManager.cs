using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AtlasServerManager
{
    class ServerManager
    {
        List<ServerNodeControl> serverNodes = new();
        Rootobject serverGrid;

        public bool ReadServerGridFile(string fileName)
        {
            serverGrid = JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(fileName));
            if (serverGrid == null)
                return false;

            return true;
        }

        public void LoadServers()
        {
            if (serverGrid.servers == null || serverGrid.servers.Length == 0)
                return;

            foreach (var server in serverGrid.servers)
            {
                //todo load some of these from a file that keeps the info from last session

                var serverNode = new ServerNode();
                serverNode.Selected = true;
                serverNode.Active = true;
                serverNode.ServerName = server.name;
                serverNode.Grid = $"{(char)(server.gridX + 65)}{server.gridY + 1}";
                serverNode.SaveFolder = $"{(char)(server.gridX + 65)}{server.gridY + 1}";
                serverNode.Status = ServerStatus.Off;
                serverNodes.Add(new ServerNodeControl(serverNode));
            }

            //find running servers
            var runningServers = Process.GetProcessesByName("AtlasGame");
            if (runningServers.Length > 0)
            {
                foreach (var process in runningServers)
                {
                    var m = Regex.Match(process.ProcessName, @"\[AltSaveDir=(.+)\]");

                    //Find server in serverNodes
                    var foundServer = serverNodes.Find(p => p.GetSaveFolder() == m.Value);
                    if (foundServer == null)
                    {
                        //Cantfind server lets just close the process?
                        process.Kill();
                        continue;
                    }

                    foundServer.SetProcessId(process.Id);
                    foundServer.SetStatus(ServerStatus.Running);
                }
            }
        }

        public List<ServerNodeControl> GetServers()
        {
            return serverNodes;
        }
    }

    public class Rootobject
    {
        public string BaseServerArgs { get; set; }
        public float gridSize { get; set; }
        public string MetaWorldURL { get; set; }
        public string MapImagesExtension { get; set; }
        public string WorldFriendlyName { get; set; }
        public string MainRegionName { get; set; }
        public string WorldAtlasId { get; set; }
        public string AuthListURL { get; set; }
        public string WorldAtlasPassword { get; set; }
        public string ModIDs { get; set; }
        public string MapImageURL { get; set; }
        public string OverAllMapImageURL { get; set; }
        public int totalGridsX { get; set; }
        public int totalGridsY { get; set; }
        public bool bUseUTCTime { get; set; }
        public bool usePVEServerConfiguration { get; set; }
        public float columnUTCOffset { get; set; }
        public string Day0 { get; set; }
        public float globalTransitionMinZ { get; set; }
        public string AdditionalCmdLineParams { get; set; }
        public Overrideshootergamemodedefaultgameini OverrideShooterGameModeDefaultGameIni { get; set; }
        public string globalGameplaySetup { get; set; }
        public int numPathingGridRows { get; set; }
        public int numPathingGridColumns { get; set; }
        public float coordsScaling { get; set; }
        public bool showServerInfo { get; set; }
        public bool showDiscoZoneInfo { get; set; }
        public bool showShipPathsInfo { get; set; }
        public bool showTradeWindsInfo { get; set; }
        public bool showPortalNodes { get; set; }
        public bool showIslandNames { get; set; }
        public bool showBackground { get; set; }
        public Regionsbackgroundimgpath regionsBackgroundImgPath { get; set; }
        public Regionstradewindoverlayimgpath regionsTradeWindOverlayImgPath { get; set; }
        public string discoZonesImagePath { get; set; }
        public Server[] servers { get; set; }
        public Spawneroverridetemplate[] spawnerOverrideTemplates { get; set; }
        public int idGenerator { get; set; }
        public int regionsIdGenerator { get; set; }
        public int shipPathsIdGenerator { get; set; }
        public int PortalPathsIdGenerator { get; set; }
        public int tradeWindsIdGenerator { get; set; }
        public Shippath[] shipPaths { get; set; }
        public Tradewind[] tradeWinds { get; set; }
        public object[] portalPaths { get; set; }
        public DateTime lastImageOverride { get; set; }
        public Servertemplate[] serverTemplates { get; set; }
        public object[] regionTemplates { get; set; }
        public Appliedregiontemplate[] appliedRegionTemplates { get; set; }
        public object[] serverConfigurations { get; set; }
        public Transientnodetemplate[] transientNodeTemplates { get; set; }
        public object[] foliageAttachmentOverrides { get; set; }
        public object[] regionsCategories { get; set; }
    }

    public class Overrideshootergamemodedefaultgameini
    {
    }

    public class Regionsbackgroundimgpath
    {
        public string Main { get; set; }
    }

    public class Regionstradewindoverlayimgpath
    {
    }

    public class Server
    {
        public int gridX { get; set; }
        public int gridY { get; set; }
        public string MachineIdTag { get; set; }
        public string ip { get; set; }
        public string name { get; set; }
        public int port { get; set; }
        public int gamePort { get; set; }
        public int seamlessDataPort { get; set; }
        public bool isHomeServer { get; set; }
        public string hiddenAtlasId { get; set; }
        public int forceServerRules { get; set; }
        public string AdditionalCmdLineParams { get; set; }
        public Overrideshootergamemodedefaultgameini1 OverrideShooterGameModeDefaultGameIni { get; set; }
        public int floorZDist { get; set; }
        public int utcOffset { get; set; }
        public int transitionMinZ { get; set; }
        public string GlobalBiomeSeamlessServerGridPreOffsetValues { get; set; }
        public string GlobalBiomeSeamlessServerGridPreOffsetValuesOceanWater { get; set; }
        public string OceanDinoDepthEntriesOverride { get; set; }
        public string OceanEpicSpawnEntriesOverrideValues { get; set; }
        public string oceanFloatsamCratesOverride { get; set; }
        public string treasureMapLootTablesOverride { get; set; }
        public string oceanEpicSpawnEntriesOverrideTemplateName { get; set; }
        public string NPCShipSpawnEntriesOverrideTemplateName { get; set; }
        public string regionOverrides { get; set; }
        public float waterColorR { get; set; }
        public float waterColorG { get; set; }
        public float waterColorB { get; set; }
        public float billboardsOffsetX { get; set; }
        public float billboardsOffsetY { get; set; }
        public float billboardsOffsetZ { get; set; }
        public int skyStyleIndex { get; set; }
        public float serverIslandPointsMultiplier { get; set; }
        public string ServerCustomDatas1 { get; set; }
        public string ServerCustomDatas2 { get; set; }
        public string ClientCustomDatas1 { get; set; }
        public string ClientCustomDatas2 { get; set; }
        public Sublevel[] sublevels { get; set; }
        public DateTime lastModified { get; set; }
        public DateTime lastImageOverride { get; set; }
        public bool islandLocked { get; set; }
        public bool discoLocked { get; set; }
        public bool pathsLocked { get; set; }
        public bool windsLocked { get; set; }
        public string[] extraSublevels { get; set; }
        public string[] totalExtraSublevels { get; set; }
        public Islandinstance[] islandInstances { get; set; }
        public Discozone[] discoZones { get; set; }
        public Spawnregion[] spawnRegions { get; set; }
        public string serverTemplateName { get; set; }
        public string serverConfigurationKeyPVP { get; set; }
        public string serverConfigurationKeyPVE { get; set; }
        public int?[] ServerPathingGrid { get; set; }
        public string BackgroundImgPath { get; set; }
    }

    public class Overrideshootergamemodedefaultgameini1
    {
    }

    public class Sublevel
    {
        public string name { get; set; }
        public float additionalTranslationX { get; set; }
        public float additionalTranslationY { get; set; }
        public float additionalTranslationZ { get; set; }
        public float additionalRotationPitch { get; set; }
        public float additionalRotationYaw { get; set; }
        public float additionalRotationRoll { get; set; }
        public int id { get; set; }
        public int landscapeMaterialOverride { get; set; }
    }

    public class Islandinstance
    {
        public string name { get; set; }
        public int id { get; set; }
        public Spawneroverrides spawnerOverrides { get; set; }
        public object[] harvestOverrideKeys { get; set; }
        public string[] harvestOverrideKeysTemplateInherited { get; set; }
        public string[] treasureMapSpawnPoints { get; set; }
        public string[] wildPirateCampSpawnPoints { get; set; }
        public float minTreasureQuality { get; set; }
        public float maxTreasureQuality { get; set; }
        public bool useNpcVolumesForTreasures { get; set; }
        public bool useLevelBoundsForTreasures { get; set; }
        public bool prioritizeVolumesForTreasures { get; set; }
        public bool isControlPoint { get; set; }
        public bool isControlPointAllowCapture { get; set; }
        public int islandPoints { get; set; }
        public string islandTreasureBottleSupplyCrateOverrides { get; set; }
        public float islandWidth { get; set; }
        public float islandHeight { get; set; }
        public float singleSpawnPointX { get; set; }
        public float singleSpawnPointY { get; set; }
        public float singleSpawnPointZ { get; set; }
        public float maxIslandClaimFlagZ { get; set; }
        public float worldX { get; set; }
        public float worldY { get; set; }
        public float rotation { get; set; }
        public string landNodeKey { get; set; }
        public int spawnPointRegionOverride { get; set; }
    }

    public class Spawneroverrides
    {
    }

    public class Discozone
    {
        public string name { get; set; }
        public float sizeX { get; set; }
        public float sizeY { get; set; }
        public float sizeZ { get; set; }
        public int id { get; set; }
        public float xp { get; set; }
        public bool bIsManuallyPlaced { get; set; }
        public int explorerNoteIndex { get; set; }
        public bool allowSea { get; set; }
        public float worldX { get; set; }
        public float worldY { get; set; }
        public float rotation { get; set; }
        public string ManualVolumeName { get; set; }
    }

    public class Spawnregion
    {
        public string name { get; set; }
    }

    public class Spawneroverridetemplate
    {
        public string Name { get; set; }
        public string NPCSpawnEntries { get; set; }
        public string NPCSpawnLimits { get; set; }
        public float MaxDesiredNumEnemiesMultiplier { get; set; }
    }

    public class Shippath
    {
        public Node[] Nodes { get; set; }
        public string AutoSpawnShipClass { get; set; }
        public int AutoSpawnEveryUTCInterval { get; set; }
        public bool autoSpawn { get; set; }
        public int PathId { get; set; }
        public bool isLooping { get; set; }
        public string PathName { get; set; }
    }

    public class Node
    {
        public float controlPointsDistance { get; set; }
        public float worldX { get; set; }
        public float worldY { get; set; }
        public float rotation { get; set; }
    }

    public class Tradewind
    {
        public Node1[] Nodes { get; set; }
        public bool reverseDir { get; set; }
        public bool isLoopingAroundWorld { get; set; }
        public float StartInterpolatingOceanColorAtPercentage { get; set; }
        public int PathId { get; set; }
        public bool isLooping { get; set; }
        public string PathName { get; set; }
    }

    public class Node1
    {
        public float width { get; set; }
        public float strength { get; set; }
        public float controlPointsDistance { get; set; }
        public float worldX { get; set; }
        public float worldY { get; set; }
        public float rotation { get; set; }
    }

    public class Servertemplate
    {
        public float templateColorR { get; set; }
        public float templateColorG { get; set; }
        public float templateColorB { get; set; }
        public int gridX { get; set; }
        public int gridY { get; set; }
        public string MachineIdTag { get; set; }
        public string ip { get; set; }
        public string name { get; set; }
        public int port { get; set; }
        public int gamePort { get; set; }
        public int seamlessDataPort { get; set; }
        public bool isHomeServer { get; set; }
        public int forceServerRules { get; set; }
        public string AdditionalCmdLineParams { get; set; }
        public Overrideshootergamemodedefaultgameini2 OverrideShooterGameModeDefaultGameIni { get; set; }
        public int floorZDist { get; set; }
        public int utcOffset { get; set; }
        public int transitionMinZ { get; set; }
        public string GlobalBiomeSeamlessServerGridPreOffsetValues { get; set; }
        public string GlobalBiomeSeamlessServerGridPreOffsetValuesOceanWater { get; set; }
        public string OceanDinoDepthEntriesOverride { get; set; }
        public string OceanEpicSpawnEntriesOverrideValues { get; set; }
        public string oceanFloatsamCratesOverride { get; set; }
        public string treasureMapLootTablesOverride { get; set; }
        public string oceanEpicSpawnEntriesOverrideTemplateName { get; set; }
        public string NPCShipSpawnEntriesOverrideTemplateName { get; set; }
        public string regionOverrides { get; set; }
        public float waterColorR { get; set; }
        public float waterColorG { get; set; }
        public float waterColorB { get; set; }
        public float billboardsOffsetX { get; set; }
        public float billboardsOffsetY { get; set; }
        public float billboardsOffsetZ { get; set; }
        public int skyStyleIndex { get; set; }
        public float serverIslandPointsMultiplier { get; set; }
        public string ServerCustomDatas1 { get; set; }
        public string ServerCustomDatas2 { get; set; }
        public string ClientCustomDatas1 { get; set; }
        public string ClientCustomDatas2 { get; set; }
        public DateTime lastModified { get; set; }
        public DateTime lastImageOverride { get; set; }
        public bool islandLocked { get; set; }
        public bool discoLocked { get; set; }
        public bool pathsLocked { get; set; }
        public bool windsLocked { get; set; }
        public string[] extraSublevels { get; set; }
        public string hiddenAtlasId { get; set; }
        public object[] sublevels { get; set; }
        public object[] totalExtraSublevels { get; set; }
        public object[] islandInstances { get; set; }
        public object[] discoZones { get; set; }
        public object[] spawnRegions { get; set; }
        public string serverConfigurationKeyPVP { get; set; }
        public string serverConfigurationKeyPVE { get; set; }
        public int[] ServerPathingGrid { get; set; }
        public string BackgroundImgPath { get; set; }
    }

    public class Overrideshootergamemodedefaultgameini2
    {
    }

    public class Appliedregiontemplate
    {
        public int gridX { get; set; }
        public int gridY { get; set; }
        public string MachineIdTag { get; set; }
        public string ip { get; set; }
        public string name { get; set; }
        public int port { get; set; }
        public int gamePort { get; set; }
        public int seamlessDataPort { get; set; }
        public bool isHomeServer { get; set; }
        public string hiddenAtlasId { get; set; }
        public int forceServerRules { get; set; }
        public string AdditionalCmdLineParams { get; set; }
        public Overrideshootergamemodedefaultgameini3 OverrideShooterGameModeDefaultGameIni { get; set; }
        public int floorZDist { get; set; }
        public int utcOffset { get; set; }
        public int transitionMinZ { get; set; }
        public string GlobalBiomeSeamlessServerGridPreOffsetValues { get; set; }
        public string GlobalBiomeSeamlessServerGridPreOffsetValuesOceanWater { get; set; }
        public string OceanDinoDepthEntriesOverride { get; set; }
        public string oceanFloatsamCratesOverride { get; set; }
        public string treasureMapLootTablesOverride { get; set; }
        public string oceanEpicSpawnEntriesOverrideTemplateName { get; set; }
        public string NPCShipSpawnEntriesOverrideTemplateName { get; set; }
        public string regionOverrides { get; set; }
        public float waterColorR { get; set; }
        public float waterColorG { get; set; }
        public float waterColorB { get; set; }
        public float billboardsOffsetX { get; set; }
        public float billboardsOffsetY { get; set; }
        public float billboardsOffsetZ { get; set; }
        public int skyStyleIndex { get; set; }
        public float serverIslandPointsMultiplier { get; set; }
        public object[] sublevels { get; set; }
        public DateTime lastModified { get; set; }
        public DateTime lastImageOverride { get; set; }
        public bool islandLocked { get; set; }
        public bool discoLocked { get; set; }
        public bool pathsLocked { get; set; }
        public bool windsLocked { get; set; }
        public object[] extraSublevels { get; set; }
        public object[] totalExtraSublevels { get; set; }
        public object[] islandInstances { get; set; }
        public object[] discoZones { get; set; }
        public object[] spawnRegions { get; set; }
        public string serverConfigurationKeyPVP { get; set; }
        public string serverConfigurationKeyPVE { get; set; }
        public int[] ServerPathingGrid { get; set; }
        public string BackgroundImgPath { get; set; }
    }

    public class Overrideshootergamemodedefaultgameini3
    {
    }

    public class Transientnodetemplate
    {
        public string Key { get; set; }
        public Nodekeyweights NodeKeyWeights { get; set; }
    }

    public class Nodekeyweights
    {
        public float AotD1 { get; set; }
        public float Atlantean1 { get; set; }
    }
}
