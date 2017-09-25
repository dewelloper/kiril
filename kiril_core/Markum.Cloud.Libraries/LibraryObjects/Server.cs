using System;

namespace Markum.Cloud.Libraries.LibraryObjects
{
    [Serializable()]
    public class Server
    {
        #region Properties

        public int ServerID { get; set; }
        public string ServerName { get; set; }
        public string ServerDescription { get; set; }
        public string ServerControlPanelAdminUrl { get; set; }
        public string ServerControlPanelUserUrl { get; set; }
        public string ServerControlPanelApiUrl { get; set; }
        public string ServerControlPanelPort { get; set; }
        public string ServerControlPanelApiUsername { get; set; }
        public string ServerContorlPanelApiPassword { get; set; }
        public string ServerPhpMyAdminUrl { get; set; }
        public string ServerPhpMyAdminUsername { get; set; }
        public string ServerPhpMyAdminPassword { get; set; }
        public string ServerMySqlUsername { get; set; }
        public string ServerMySqlPassword { get; set; }
        public string ServerMsSqlHostName { get; set; }
        public string ServerMsSqlUsername { get; set; }
        public string ServerMsSqlPassword { get; set; }
        public bool IsServerPool { get; set; }
        public bool IsVirtual { get; set; }
        public int VirtualServerParentID { get; set; }
        public int ServerStatusID { get; set; }
        public string ServerStatusDescription { get; set; }
        public string ServerCryptoKey { get; set; }
        public string ServerTypeName { get; set; }
        public string ServerAclList { get; set; }
        public int ServerMainIPAddressID { get; set; }
        public string ServerPanelMarkumUsername { get; set; }
        public int ControlPanelID { get; set; }
        public int MarkumUserID { get; set; }
        public int SecondaryServerID { get; set; }
        public int DatacenterID { get; set; }
        public int RackID { get; set; }
        public int SwitchID { get; set; }
        public int ServerOperatingSystemTypeID { get; set; }
        public int ServerModelTypeID { get; set; }
        public string MailEnableWebServiceUrl { get; set; }
        public string MailEnableWebMailUrl { get; set; }
        public string MailEnableWebAdminUrl { get; set; }
        public string MailEnablePOP3 { get; set; }
        public string MailEnableApiUsername { get; set; }
        public string MailEnableApiPassword { get; set; }
        public string ServerMsSqlDataPath { get; set; }
        public string ServerMsSqlLogPath { get; set; }
        public string ServerMsSqlLocalBackupPath { get; set; }
        public string ServerMsSqlNetworkBackupPath { get; set; }
        public bool IsActive { get; set; }
        public string MailEnableDirectoryPath { get; set; }
        public string MailEnableConfigPath { get; set; }
        public string MailEnableConfigBackupPath { get; set; }
        public bool HasMailEnableServiceControl { get; set; }
        public string ServerGuid { get; set; }
        public int ServerPoolRuleID { get; set; }
        public int MsSqlVersion { get; set; }
        public string ServerWebsitePanelDatabaseHostName { get; set; }
        public string ServerWebsitePanelDatabaseName { get; set; }
        public string ServerWebsitePanelDatabaseUsername { get; set; }
        public string ServerWebsitePanelDatabaseUserPassword { get; set; }
        public int SoldPlanID { get; set; }
        public string ServerCabinet { get; set; }
        public string ServerSticketCode { get; set; }
        public string ServerServiceTag { get; set; }
        public string ServerWarrantyTimeDate { get; set; }
        public string ServerTotalDiskSize { get; set; }
        public string ServerDiskToTrack { get; set; }
        public string ServerTotalRamSize { get; set; }
        public string ServerStatusNote { get; set; }
        public string ServerMx1 { get; set; }
        public string ServerMx2 { get; set; }
        public int ServerMaxCapacitySize { get; set; }

        #endregion

        #region Constructors

        public Server() { }

        public Server(string ServerName, string ServerDescription, string ServerControlPanelAdminUrl, string ServerControlPanelUserUrl, string ServerControlPanelApiUrl, string ServerControlPanelPort, string ServerControlPanelApiUsername, string ServerContorlPanelApiPassword, string ServerPhpMyAdminUrl, string ServerPhpMyAdminUsername, string ServerPhpMyAdminPassword, string ServerMySqlUsername, string ServerMySqlPassword, string ServerMsSqlHostName, string ServerMsSqlUsername, string ServerMsSqlPassword, bool IsServerPool, bool IsVirtual, int VirtualServerParentID, int ServerStatusID, string ServerStatusDescription, string ServerCryptoKey, string ServerTypeName, string ServerAclList, int ServerMainIPAddressID, string ServerPanelMarkumUsername, int ControlPanelID, int MarkumUserID, int SecondaryServerID, int DatacenterID, int RackID, int SwitchID, int ServerOperatingSystemTypeID, int ServerModelTypeID, string MailEnableWebServiceUrl, string MailEnableWebMailUrl, string MailEnableWebAdminUrl, string MailEnablePOP3, string MailEnableApiUsername, string MailEnableApiPassword, string ServerMsSqlDataPath, string ServerMsSqlLogPath, string ServerMsSqlLocalBackupPath, string ServerMsSqlNetworkBackupPath, bool IsActive, string MailEnableDirectoryPath, string MailEnableConfigPath, string MailEnableConfigBackupPath, bool HasMailEnableServiceControl, int ServerPoolRuleID, int MsSqlVersion, string ServerWebsitePanelDatabaseHostName, string ServerWebsitePanelDatabaseName, string ServerWebsitePanelDatabaseUsername, string ServerWebsitePanelDatabaseUserPassword)
        {
            this.ServerName = ServerName;
            this.ServerDescription = ServerDescription;
            this.ServerControlPanelAdminUrl = ServerControlPanelAdminUrl;
            this.ServerControlPanelUserUrl = ServerControlPanelUserUrl;
            this.ServerControlPanelApiUrl = ServerControlPanelApiUrl;
            this.ServerControlPanelPort = ServerControlPanelPort;
            this.ServerControlPanelApiUsername = ServerControlPanelApiUsername;
            this.ServerContorlPanelApiPassword = ServerContorlPanelApiPassword;
            this.ServerPhpMyAdminUrl = ServerPhpMyAdminUrl;
            this.ServerPhpMyAdminUsername = ServerPhpMyAdminUsername;
            this.ServerPhpMyAdminPassword = ServerPhpMyAdminPassword;
            this.ServerMySqlUsername = ServerMySqlUsername;
            this.ServerMySqlPassword = ServerMySqlPassword;
            this.ServerMsSqlHostName = ServerMsSqlHostName;
            this.ServerMsSqlUsername = ServerMsSqlUsername;
            this.ServerMsSqlPassword = ServerMsSqlPassword;
            this.IsServerPool = IsServerPool;
            this.IsVirtual = IsVirtual;
            this.VirtualServerParentID = VirtualServerParentID;
            this.ServerStatusID = ServerStatusID;
            this.ServerStatusDescription = ServerStatusDescription;
            this.ServerCryptoKey = ServerCryptoKey;
            this.ServerTypeName = ServerTypeName;
            this.ServerAclList = ServerAclList;
            this.ServerMainIPAddressID = ServerMainIPAddressID;
            this.ServerPanelMarkumUsername = ServerPanelMarkumUsername;
            this.ControlPanelID = ControlPanelID;
            this.MarkumUserID = MarkumUserID;
            this.SecondaryServerID = SecondaryServerID;
            this.DatacenterID = DatacenterID;
            this.RackID = RackID;
            this.SwitchID = SwitchID;
            this.ServerOperatingSystemTypeID = ServerOperatingSystemTypeID;
            this.ServerModelTypeID = ServerModelTypeID;
            this.MailEnableWebServiceUrl = MailEnableWebServiceUrl;
            this.MailEnableWebMailUrl = MailEnableWebMailUrl;
            this.MailEnableWebAdminUrl = MailEnableWebAdminUrl;
            this.MailEnablePOP3 = MailEnablePOP3;
            this.MailEnableApiUsername = MailEnableApiUsername;
            this.MailEnableApiPassword = MailEnableApiPassword;
            this.ServerMsSqlDataPath = ServerMsSqlDataPath;
            this.ServerMsSqlLogPath = ServerMsSqlLogPath;
            this.ServerMsSqlLocalBackupPath = ServerMsSqlLocalBackupPath;
            this.ServerMsSqlNetworkBackupPath = ServerMsSqlNetworkBackupPath;
            this.IsActive = IsActive;
            this.MailEnableDirectoryPath = MailEnableDirectoryPath;
            this.MailEnableConfigPath = MailEnableConfigPath;
            this.MailEnableConfigBackupPath = MailEnableConfigBackupPath;
            this.HasMailEnableServiceControl = HasMailEnableServiceControl;
            this.ServerPoolRuleID = ServerPoolRuleID;
            this.MsSqlVersion = MsSqlVersion;
            this.ServerWebsitePanelDatabaseHostName = ServerWebsitePanelDatabaseHostName;
            this.ServerWebsitePanelDatabaseName = ServerWebsitePanelDatabaseName;
            this.ServerWebsitePanelDatabaseUsername = ServerWebsitePanelDatabaseUsername;
            this.ServerWebsitePanelDatabaseUserPassword = ServerWebsitePanelDatabaseUserPassword;
        }

        #endregion
    }
}
