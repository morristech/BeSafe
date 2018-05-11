namespace BeSafe.Components.Initializers.VirtualDrive
{
    interface IVirtualDrive
    {
        string MapDrive(string virtualPath);
        bool UnmapDrive(string driveLetter);
        string GetDriveMappingPath(string driveLetter);
    }
}