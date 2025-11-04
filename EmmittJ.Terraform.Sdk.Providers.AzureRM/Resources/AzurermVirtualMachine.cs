using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine resource.
/// </summary>
public class AzurermVirtualMachine : TerraformResource
{
    public AzurermVirtualMachine(string name) : base("azurerm_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    public string? AvailabilitySetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_set_id")?.Value;
        set => this.WithProperty("availability_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delete_data_disks_on_termination attribute.
    /// </summary>
    public bool? DeleteDataDisksOnTermination
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_data_disks_on_termination")?.Value;
        set => this.WithProperty("delete_data_disks_on_termination", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The delete_os_disk_on_termination attribute.
    /// </summary>
    public bool? DeleteOsDiskOnTermination
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_os_disk_on_termination")?.Value;
        set => this.WithProperty("delete_os_disk_on_termination", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public string? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type")?.Value;
        set => this.WithProperty("license_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public List<string>? NetworkInterfaceIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("network_interface_ids")?.Value;
        set => this.WithProperty("network_interface_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    public string? PrimaryNetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_network_interface_id")?.Value;
        set => this.WithProperty("primary_network_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public string? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proximity_placement_group_id")?.Value;
        set => this.WithProperty("proximity_placement_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public string? VmSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_size")?.Value;
        set => this.WithProperty("vm_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public List<string>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("zones")?.Value;
        set => this.WithProperty("zones", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
