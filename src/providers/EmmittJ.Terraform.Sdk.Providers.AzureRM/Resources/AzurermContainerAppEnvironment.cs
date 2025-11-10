using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppEnvironmentIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentTimeoutsBlock : TerraformBlock
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
/// Block type for workload_profile in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppEnvironmentWorkloadProfileBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumCount
    {
        set => SetProperty("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumCount
    {
        set => SetProperty("minimum_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The workload_profile_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadProfileType is required")]
    public required TerraformProperty<string> WorkloadProfileType
    {
        set => SetProperty("workload_profile_type", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("custom_domain_verification_id");
        SetOutput("default_domain");
        SetOutput("docker_bridge_cidr");
        SetOutput("platform_reserved_cidr");
        SetOutput("platform_reserved_dns_ip_address");
        SetOutput("static_ip_address");
        SetOutput("dapr_application_insights_connection_string");
        SetOutput("id");
        SetOutput("infrastructure_resource_group_name");
        SetOutput("infrastructure_subnet_id");
        SetOutput("internal_load_balancer_enabled");
        SetOutput("location");
        SetOutput("log_analytics_workspace_id");
        SetOutput("logs_destination");
        SetOutput("mutual_tls_enabled");
        SetOutput("name");
        SetOutput("public_network_access");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("zone_redundancy_enabled");
    }

    /// <summary>
    /// Application Insights connection string used by Dapr to export Service to Service communication telemetry.
    /// </summary>
    public TerraformProperty<string> DaprApplicationInsightsConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dapr_application_insights_connection_string");
        set => SetProperty("dapr_application_insights_connection_string", value);
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
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    public TerraformProperty<string> InfrastructureResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("infrastructure_resource_group_name");
        set => SetProperty("infrastructure_resource_group_name", value);
    }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    public TerraformProperty<string> InfrastructureSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("infrastructure_subnet_id");
        set => SetProperty("infrastructure_subnet_id", value);
    }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    public TerraformProperty<bool> InternalLoadBalancerEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internal_load_balancer_enabled");
        set => SetProperty("internal_load_balancer_enabled", value);
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
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    public TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The logs_destination attribute.
    /// </summary>
    public TerraformProperty<string> LogsDestination
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logs_destination");
        set => SetProperty("logs_destination", value);
    }

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    public TerraformProperty<bool> MutualTlsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("mutual_tls_enabled");
        set => SetProperty("mutual_tls_enabled", value);
    }

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public network access setting for the Container App Environment.
    /// </summary>
    public TerraformProperty<string> PublicNetworkAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_network_access");
        set => SetProperty("public_network_access", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneRedundancyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_redundancy_enabled");
        set => SetProperty("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerAppEnvironmentIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppEnvironmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for workload_profile.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermContainerAppEnvironmentWorkloadProfileBlock>? WorkloadProfile
    {
        set => SetProperty("workload_profile", value);
    }

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App Environment.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default publicly resolvable name of this Container App Environment
    /// </summary>
    public TerraformExpression DefaultDomain => this["default_domain"];

    /// <summary>
    /// The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation.
    /// </summary>
    public TerraformExpression DockerBridgeCidr => this["docker_bridge_cidr"];

    /// <summary>
    /// The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.
    /// </summary>
    public TerraformExpression PlatformReservedCidr => this["platform_reserved_cidr"];

    /// <summary>
    /// The IP address from the IP range defined by `platform_reserved_cidr` that is reserved for the internal DNS server.
    /// </summary>
    public TerraformExpression PlatformReservedDnsIpAddress => this["platform_reserved_dns_ip_address"];

    /// <summary>
    /// The Static IP Address of the Environment.
    /// </summary>
    public TerraformExpression StaticIpAddress => this["static_ip_address"];

}
