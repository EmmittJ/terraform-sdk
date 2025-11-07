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
    public TerraformProperty<string>? AvailabilitySetId
    {
        get => GetProperty<TerraformProperty<string>>("availability_set_id");
        set => this.WithProperty("availability_set_id", value);
    }

    /// <summary>
    /// The delete_data_disks_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteDataDisksOnTermination
    {
        get => GetProperty<TerraformProperty<bool>>("delete_data_disks_on_termination");
        set => this.WithProperty("delete_data_disks_on_termination", value);
    }

    /// <summary>
    /// The delete_os_disk_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOsDiskOnTermination
    {
        get => GetProperty<TerraformProperty<bool>>("delete_os_disk_on_termination");
        set => this.WithProperty("delete_os_disk_on_termination", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NetworkInterfaceIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("network_interface_ids");
        set => this.WithProperty("network_interface_ids", value);
    }

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryNetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("primary_network_interface_id");
        set => this.WithProperty("primary_network_interface_id", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("proximity_placement_group_id");
        set => this.WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformProperty<string>? VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => this.WithProperty("vm_size", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Zones
    {
        get => GetProperty<TerraformProperty<List<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

}
