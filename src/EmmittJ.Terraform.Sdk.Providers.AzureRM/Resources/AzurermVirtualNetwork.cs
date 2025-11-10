using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ddos_protection_plan in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkDdosProtectionPlanBlock : TerraformBlock
{
    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformProperty<bool> Enable
    {
        get => GetProperty<TerraformProperty<bool>>("enable");
        set => WithProperty("enable", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

}

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The enforcement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enforcement is required")]
    public required TerraformProperty<string> Enforcement
    {
        get => GetProperty<TerraformProperty<string>>("enforcement");
        set => WithProperty("enforcement", value);
    }

}

/// <summary>
/// Block type for ip_address_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkIpAddressPoolBlock : TerraformBlock
{
    /// <summary>
    /// The allocated_ip_address_prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AllocatedIpAddressPrefixes
    {
        get => GetProperty<List<TerraformProperty<string>>>("allocated_ip_address_prefixes");
        set => WithProperty("allocated_ip_address_prefixes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    public required TerraformProperty<string> NumberOfIpAddresses
    {
        get => GetProperty<TerraformProperty<string>>("number_of_ip_addresses");
        set => WithProperty("number_of_ip_addresses", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_network resource.
/// </summary>
public class AzurermVirtualNetwork : TerraformResource
{
    public AzurermVirtualNetwork(string name) : base("azurerm_virtual_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("guid");
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AddressSpace
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("address_space");
        set => this.WithProperty("address_space", value);
    }

    /// <summary>
    /// The bgp_community attribute.
    /// </summary>
    public TerraformProperty<string>? BgpCommunity
    {
        get => GetProperty<TerraformProperty<string>>("bgp_community");
        set => this.WithProperty("bgp_community", value);
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
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The flow_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? FlowTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("flow_timeout_in_minutes");
        set => this.WithProperty("flow_timeout_in_minutes", value);
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
    /// The private_endpoint_vnet_policies attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateEndpointVnetPolicies
    {
        get => GetProperty<TerraformProperty<string>>("private_endpoint_vnet_policies");
        set => this.WithProperty("private_endpoint_vnet_policies", value);
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
    /// The subnet attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? Subnet
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("subnet");
        set => this.WithProperty("subnet", value);
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
    /// Block for ddos_protection_plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionPlan block(s) allowed")]
    public List<AzurermVirtualNetworkDdosProtectionPlanBlock>? DdosProtectionPlan
    {
        get => GetProperty<List<AzurermVirtualNetworkDdosProtectionPlanBlock>>("ddos_protection_plan");
        set => this.WithProperty("ddos_protection_plan", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<AzurermVirtualNetworkEncryptionBlock>? Encryption
    {
        get => GetProperty<List<AzurermVirtualNetworkEncryptionBlock>>("encryption");
        set => this.WithProperty("encryption", value);
    }

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 IpAddressPool block(s) allowed")]
    public List<AzurermVirtualNetworkIpAddressPoolBlock>? IpAddressPool
    {
        get => GetProperty<List<AzurermVirtualNetworkIpAddressPoolBlock>>("ip_address_pool");
        set => this.WithProperty("ip_address_pool", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualNetworkTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    public TerraformExpression Guid => this["guid"];

}
