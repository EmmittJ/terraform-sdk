using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_container_app_environment.
/// </summary>
public class AzurermContainerAppEnvironmentDataSource : TerraformDataSource
{
    public AzurermContainerAppEnvironmentDataSource(string name) : base("azurerm_container_app_environment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerAppEnvironmentDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App Environment.
    /// </summary>
    [TerraformArgument("custom_domain_verification_id")]
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The default publicly resolvable name of this Container App Environment
    /// </summary>
    [TerraformArgument("default_domain")]
    public TerraformValue<string> DefaultDomain
    {
        get => new TerraformReference<string>(this, "default_domain");
    }

    /// <summary>
    /// The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation.
    /// </summary>
    [TerraformArgument("docker_bridge_cidr")]
    public TerraformValue<string> DockerBridgeCidr
    {
        get => new TerraformReference<string>(this, "docker_bridge_cidr");
    }

    /// <summary>
    /// The existing Subnet in use by the Container Apps Control Plane.
    /// </summary>
    [TerraformArgument("infrastructure_subnet_id")]
    public TerraformValue<string> InfrastructureSubnetId
    {
        get => new TerraformReference<string>(this, "infrastructure_subnet_id");
    }

    /// <summary>
    /// Does the Container Environment operate in Internal Load Balancing Mode?
    /// </summary>
    [TerraformArgument("internal_load_balancer_enabled")]
    public TerraformValue<bool> InternalLoadBalancerEnabled
    {
        get => new TerraformReference<bool>(this, "internal_load_balancer_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The name of the Log Analytics Workspace this Container Apps Managed Environment is linked to.
    /// </summary>
    [TerraformArgument("log_analytics_workspace_name")]
    public TerraformValue<string> LogAnalyticsWorkspaceName
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_name");
    }

    /// <summary>
    /// The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.
    /// </summary>
    [TerraformArgument("platform_reserved_cidr")]
    public TerraformValue<string> PlatformReservedCidr
    {
        get => new TerraformReference<string>(this, "platform_reserved_cidr");
    }

    /// <summary>
    /// The IP address from the IP range defined by `platform_reserved_cidr` that is reserved for the internal DNS server.
    /// </summary>
    [TerraformArgument("platform_reserved_dns_ip_address")]
    public TerraformValue<string> PlatformReservedDnsIpAddress
    {
        get => new TerraformReference<string>(this, "platform_reserved_dns_ip_address");
    }

    /// <summary>
    /// The public network access setting for this Container App Environment.
    /// </summary>
    [TerraformArgument("public_network_access")]
    public TerraformValue<string> PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
    }

    /// <summary>
    /// The Static IP Address of the Environment.
    /// </summary>
    [TerraformArgument("static_ip_address")]
    public TerraformValue<string> StaticIpAddress
    {
        get => new TerraformReference<string>(this, "static_ip_address");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
