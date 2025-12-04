using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermContainerAppEnvironment.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppEnvironmentIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermContainerAppEnvironment.
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for workload_profile in AzurermContainerAppEnvironment.
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppEnvironmentWorkloadProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workload_profile";

    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    public TerraformValue<double>? MaximumCount
    {
        get => GetArgument<TerraformValue<double>>("maximum_count");
        set => SetArgument("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    public TerraformValue<double>? MinimumCount
    {
        get => GetArgument<TerraformValue<double>>("minimum_count");
        set => SetArgument("minimum_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The workload_profile_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadProfileType is required")]
    public required TerraformValue<string> WorkloadProfileType
    {
        get => GetRequiredArgument<TerraformValue<string>>("workload_profile_type");
        set => SetArgument("workload_profile_type", value);
    }

}


/// <summary>
/// Represents a azurerm_container_app_environment Terraform resource.
/// Manages a azurerm_container_app_environment resource.
/// </summary>
public partial class AzurermContainerAppEnvironment(string name) : TerraformResource("azurerm_container_app_environment", name)
{
    /// <summary>
    /// Application Insights connection string used by Dapr to export Service to Service communication telemetry.
    /// </summary>
    public TerraformValue<string>? DaprApplicationInsightsConnectionString
    {
        get => GetArgument<TerraformValue<string>>("dapr_application_insights_connection_string");
        set => SetArgument("dapr_application_insights_connection_string", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    public TerraformValue<string>? InfrastructureResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("infrastructure_resource_group_name");
        set => SetArgument("infrastructure_resource_group_name", value);
    }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    public TerraformValue<string>? InfrastructureSubnetId
    {
        get => GetArgument<TerraformValue<string>>("infrastructure_subnet_id");
        set => SetArgument("infrastructure_subnet_id", value);
    }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    public TerraformValue<bool>? InternalLoadBalancerEnabled
    {
        get => GetArgument<TerraformValue<bool>>("internal_load_balancer_enabled");
        set => SetArgument("internal_load_balancer_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    public TerraformValue<string>? LogAnalyticsWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The logs_destination attribute.
    /// </summary>
    public TerraformValue<string> LogsDestination
    {
        get => GetArgument<TerraformValue<string>>("logs_destination") ?? AsReference("logs_destination");
        set => SetArgument("logs_destination", value);
    }

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    public TerraformValue<bool>? MutualTlsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("mutual_tls_enabled");
        set => SetArgument("mutual_tls_enabled", value);
    }

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public network access setting for the Container App Environment.
    /// </summary>
    public TerraformValue<string> PublicNetworkAccess
    {
        get => GetArgument<TerraformValue<string>>("public_network_access") ?? AsReference("public_network_access");
        set => SetArgument("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundancyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("zone_redundancy_enabled");
        set => SetArgument("zone_redundancy_enabled", value);
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
    /// The Static IP Address of the Environment.
    /// </summary>
    public TerraformValue<string> StaticIpAddress
        => AsReference("static_ip_address");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermContainerAppEnvironmentIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermContainerAppEnvironmentIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppEnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WorkloadProfile block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermContainerAppEnvironmentWorkloadProfileBlock>? WorkloadProfile
    {
        get => GetArgument<TerraformSet<AzurermContainerAppEnvironmentWorkloadProfileBlock>>("workload_profile");
        set => SetArgument("workload_profile", value);
    }

}
