using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for management_network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermDedicatedHardwareSecurityModuleManagementNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// The network_interface_private_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfacePrivateIpAddresses is required")]
    public HashSet<TerraformProperty<string>>? NetworkInterfacePrivateIpAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("network_interface_private_ip_addresses");
        set => WithProperty("network_interface_private_ip_addresses", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermDedicatedHardwareSecurityModuleNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// The network_interface_private_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfacePrivateIpAddresses is required")]
    public HashSet<TerraformProperty<string>>? NetworkInterfacePrivateIpAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("network_interface_private_ip_addresses");
        set => WithProperty("network_interface_private_ip_addresses", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDedicatedHardwareSecurityModuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_dedicated_hardware_security_module resource.
/// </summary>
public class AzurermDedicatedHardwareSecurityModule : TerraformResource
{
    public AzurermDedicatedHardwareSecurityModule(string name) : base("azurerm_dedicated_hardware_security_module", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The stamp_id attribute.
    /// </summary>
    public TerraformProperty<string>? StampId
    {
        get => GetProperty<TerraformProperty<string>>("stamp_id");
        set => this.WithProperty("stamp_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for management_network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementNetworkProfile block(s) allowed")]
    public List<AzurermDedicatedHardwareSecurityModuleManagementNetworkProfileBlock>? ManagementNetworkProfile
    {
        get => GetProperty<List<AzurermDedicatedHardwareSecurityModuleManagementNetworkProfileBlock>>("management_network_profile");
        set => this.WithProperty("management_network_profile", value);
    }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public List<AzurermDedicatedHardwareSecurityModuleNetworkProfileBlock>? NetworkProfile
    {
        get => GetProperty<List<AzurermDedicatedHardwareSecurityModuleNetworkProfileBlock>>("network_profile");
        set => this.WithProperty("network_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDedicatedHardwareSecurityModuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDedicatedHardwareSecurityModuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
