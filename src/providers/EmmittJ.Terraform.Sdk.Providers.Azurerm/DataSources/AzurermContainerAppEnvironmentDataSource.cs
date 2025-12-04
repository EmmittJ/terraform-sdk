using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerAppEnvironmentDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_container_app_environment Terraform data source.
/// Retrieves information about a azurerm_container_app_environment.
/// </summary>
public partial class AzurermContainerAppEnvironmentDataSource(string name) : TerraformDataSource("azurerm_container_app_environment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App Environment.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
        => AsReference("custom_domain_verification_id");

    /// <summary>
    /// The default publicly resolvable name of this Container App Environment
    /// </summary>
    public TerraformValue<string> DefaultDomain
        => AsReference("default_domain");

    /// <summary>
    /// The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation.
    /// </summary>
    public TerraformValue<string> DockerBridgeCidr
        => AsReference("docker_bridge_cidr");

    /// <summary>
    /// The existing Subnet in use by the Container Apps Control Plane.
    /// </summary>
    public TerraformValue<string> InfrastructureSubnetId
        => AsReference("infrastructure_subnet_id");

    /// <summary>
    /// Does the Container Environment operate in Internal Load Balancing Mode?
    /// </summary>
    public TerraformValue<bool> InternalLoadBalancerEnabled
        => AsReference("internal_load_balancer_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The name of the Log Analytics Workspace this Container Apps Managed Environment is linked to.
    /// </summary>
    public TerraformValue<string> LogAnalyticsWorkspaceName
        => AsReference("log_analytics_workspace_name");

    /// <summary>
    /// The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.
    /// </summary>
    public TerraformValue<string> PlatformReservedCidr
        => AsReference("platform_reserved_cidr");

    /// <summary>
    /// The IP address from the IP range defined by `platform_reserved_cidr` that is reserved for the internal DNS server.
    /// </summary>
    public TerraformValue<string> PlatformReservedDnsIpAddress
        => AsReference("platform_reserved_dns_ip_address");

    /// <summary>
    /// The public network access setting for this Container App Environment.
    /// </summary>
    public TerraformValue<string> PublicNetworkAccess
        => AsReference("public_network_access");

    /// <summary>
    /// The Static IP Address of the Environment.
    /// </summary>
    public TerraformValue<string> StaticIpAddress
        => AsReference("static_ip_address");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppEnvironmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppEnvironmentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
