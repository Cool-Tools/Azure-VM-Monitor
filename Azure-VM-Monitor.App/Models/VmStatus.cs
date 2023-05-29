namespace AzureVMMonitor.App.Models;

public class VmStatus
{
    public string ResourceGroup { get; init; }
    public string VirtualMachine { get; init; }
    public string? OsName { get; init; }
    public string? OsVersion { get; init; }
    public string? VmSize { get; init; }
    public string? VmOsDisk { get; init; }
    public string? VmOsImagePublisher { get; init; }
    public string? VmOsImageOffer { get; init; }
    public string? VmOsImageVersion { get; init; }
    public string? VmDataDisks { get; init; }
    public string? PowerState { get; init; }
}