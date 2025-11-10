using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public class AzurermStackHciLogicalNetworkSubnetBlock : TerraformBlock
{
    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? AddressPrefix
    {
        get => GetProperty<TerraformProperty<string>>("address_prefix");
        set => WithProperty("address_prefix", value);
    }

    /// <summary>
    /// The ip_allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAllocationMethod is required")]
    public required TerraformProperty<string> IpAllocationMethod
    {
        get => GetProperty<TerraformProperty<string>>("ip_allocation_method");
        set => WithProperty("ip_allocation_method", value);
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public TerraformProperty<double>? VlanId
    {
        get => GetProperty<TerraformProperty<double>>("vlan_id");
        set => WithProperty("vlan_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciLogicalNetworkTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_stack_hci_logical_network resource.
/// </summary>
public class AzurermStackHciLogicalNetwork : TerraformResource
{
    public AzurermStackHciLogicalNetwork(string name) : base("azurerm_stack_hci_logical_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    public required TerraformProperty<string> CustomLocationId
    {
        get => GetProperty<TerraformProperty<string>>("custom_location_id");
        set => this.WithProperty("custom_location_id", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DnsServers
    {
        get => GetProperty<List<TerraformProperty<string>>>("dns_servers");
        set => this.WithProperty("dns_servers", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_switch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualSwitchName is required")]
    public required TerraformProperty<string> VirtualSwitchName
    {
        get => GetProperty<TerraformProperty<string>>("virtual_switch_name");
        set => this.WithProperty("virtual_switch_name", value);
    }

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subnet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subnet block(s) allowed")]
    public List<AzurermStackHciLogicalNetworkSubnetBlock>? Subnet
    {
        get => GetProperty<List<AzurermStackHciLogicalNetworkSubnetBlock>>("subnet");
        set => this.WithProperty("subnet", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStackHciLogicalNetworkTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStackHciLogicalNetworkTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
