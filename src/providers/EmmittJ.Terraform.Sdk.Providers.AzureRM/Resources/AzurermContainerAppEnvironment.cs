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
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for workload_profile in .
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
    [TerraformArgument("maximum_count")]
    public TerraformValue<double>? MaximumCount
    {
        get => new TerraformReference<double>(this, "maximum_count");
        set => SetArgument("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [TerraformArgument("minimum_count")]
    public TerraformValue<double>? MinimumCount
    {
        get => new TerraformReference<double>(this, "minimum_count");
        set => SetArgument("minimum_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The workload_profile_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadProfileType is required")]
    [TerraformArgument("workload_profile_type")]
    public required TerraformValue<string> WorkloadProfileType
    {
        get => new TerraformReference<string>(this, "workload_profile_type");
        set => SetArgument("workload_profile_type", value);
    }

}

/// <summary>
/// Manages a azurerm_container_app_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerAppEnvironment : TerraformResource
{
    public AzurermContainerAppEnvironment(string name) : base("azurerm_container_app_environment", name)
    {
    }

    /// <summary>
    /// Application Insights connection string used by Dapr to export Service to Service communication telemetry.
    /// </summary>
    [TerraformArgument("dapr_application_insights_connection_string")]
    public TerraformValue<string>? DaprApplicationInsightsConnectionString
    {
        get => new TerraformReference<string>(this, "dapr_application_insights_connection_string");
        set => SetArgument("dapr_application_insights_connection_string", value);
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
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    [TerraformArgument("infrastructure_resource_group_name")]
    public TerraformValue<string>? InfrastructureResourceGroupName
    {
        get => new TerraformReference<string>(this, "infrastructure_resource_group_name");
        set => SetArgument("infrastructure_resource_group_name", value);
    }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    [TerraformArgument("infrastructure_subnet_id")]
    public TerraformValue<string>? InfrastructureSubnetId
    {
        get => new TerraformReference<string>(this, "infrastructure_subnet_id");
        set => SetArgument("infrastructure_subnet_id", value);
    }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    [TerraformArgument("internal_load_balancer_enabled")]
    public TerraformValue<bool>? InternalLoadBalancerEnabled
    {
        get => new TerraformReference<bool>(this, "internal_load_balancer_enabled");
        set => SetArgument("internal_load_balancer_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    [TerraformArgument("log_analytics_workspace_id")]
    public TerraformValue<string>? LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The logs_destination attribute.
    /// </summary>
    [TerraformArgument("logs_destination")]
    public TerraformValue<string> LogsDestination
    {
        get => new TerraformReference<string>(this, "logs_destination");
        set => SetArgument("logs_destination", value);
    }

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    [TerraformArgument("mutual_tls_enabled")]
    public TerraformValue<bool>? MutualTlsEnabled
    {
        get => new TerraformReference<bool>(this, "mutual_tls_enabled");
        set => SetArgument("mutual_tls_enabled", value);
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
    /// The public network access setting for the Container App Environment.
    /// </summary>
    [TerraformArgument("public_network_access")]
    public TerraformValue<string> PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
        set => SetArgument("public_network_access", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformArgument("zone_redundancy_enabled")]
    public TerraformValue<bool>? ZoneRedundancyEnabled
    {
        get => new TerraformReference<bool>(this, "zone_redundancy_enabled");
        set => SetArgument("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermContainerAppEnvironmentIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerAppEnvironmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for workload_profile.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("workload_profile")]
    public TerraformSet<AzurermContainerAppEnvironmentWorkloadProfileBlock> WorkloadProfile { get; set; } = new();

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
    /// The Static IP Address of the Environment.
    /// </summary>
    [TerraformArgument("static_ip_address")]
    public TerraformValue<string> StaticIpAddress
    {
        get => new TerraformReference<string>(this, "static_ip_address");
    }

}
