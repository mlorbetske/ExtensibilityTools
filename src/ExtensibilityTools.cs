namespace MadsKristensen.ExtensibilityTools
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidExtensibilityToolsPkgString = "f8330d54-0469-43a7-8fc0-7f19febeb897";
        public const string guidExtensibilityToolsCmdSetString = "5dbd2975-75e4-4f09-8b6d-1183b0c83762";
        public static Guid guidExtensibilityToolsPkg = new Guid(guidExtensibilityToolsPkgString);
        public static Guid guidExtensibilityToolsCmdSet = new Guid(guidExtensibilityToolsCmdSetString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int ProjectMenuGroup = 0x03E8;
        public const int cmdAddCustomTool = 0x0001;
        public const int cmdSignBinary = 0x0002;
        public const int cmdShowInformation = 0x0003;
        public const int cmdExportMoniker = 0x0004;
        public const int cmdSwatchesWindow = 0x0005;
    }
}
