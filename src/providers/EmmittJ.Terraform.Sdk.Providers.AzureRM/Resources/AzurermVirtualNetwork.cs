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
        set => SetProperty("enable", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
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
        set => SetProperty("enforcement", value);
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
        set => SetProperty("allocated_ip_address_prefixes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    public required TerraformProperty<string> NumberOfIpAddresses
    {
        set => SetProperty("number_of_ip_addresses", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualNetwork : TerraformResource
{
    public AzurermVirtualNetwork(string name) : base("azurerm_virtual_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("guid");
        SetOutput("address_space");
        SetOutput("bgp_community");
        SetOutput("dns_servers");
        SetOutput("edge_zone");
        SetOutput("flow_timeout_in_minutes");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("private_endpoint_vnet_policies");
        SetOutput("resource_group_name");
        SetOutput("subnet");
        SetOutput("tags");
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AddressSpace
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("address_space");
        set => SetProperty("address_space", value);
    }

    /// <summary>
    /// The bgp_community attribute.
    /// </summary>
    public TerraformProperty<string> BgpCommunity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bgp_community");
        set => SetProperty("bgp_community", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>> DnsServers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("dns_servers");
        set => SetProperty("dns_servers", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string> EdgeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edge_zone");
        set => SetProperty("edge_zone", value);
    }

    /// <summary>
    /// The flow_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> FlowTimeoutInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("flow_timeout_in_minutes");
        set => SetProperty("flow_timeout_in_minutes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The private_endpoint_vnet_policies attribute.
    /// </summary>
    public TerraformProperty<string> PrivateEndpointVnetPolicies
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_endpoint_vnet_policies");
        set => SetProperty("private_endpoint_vnet_policies", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subnet attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>> Subnet
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<object>>>("subnet");
        set => SetProperty("subnet", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for ddos_protection_plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionPlan block(s) allowed")]
    public List<AzurermVirtualNetworkDdosProtectionPlanBlock>? DdosProtectionPlan
    {
        set => SetProperty("ddos_protection_plan", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<AzurermVirtualNetworkEncryptionBlock>? Encryption
    {
        set => SetProperty("encryption", value);
    }

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 IpAddressPool block(s) allowed")]
    public List<AzurermVirtualNetworkIpAddressPoolBlock>? IpAddressPool
    {
        set => SetProperty("ip_address_pool", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    public TerraformExpression Guid => this["guid"];

}
