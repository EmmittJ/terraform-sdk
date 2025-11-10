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
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<double>>("maximum_count");
        set => WithProperty("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumCount
    {
        get => GetProperty<TerraformProperty<double>>("minimum_count");
        set => WithProperty("minimum_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The workload_profile_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadProfileType is required")]
    public required TerraformProperty<string> WorkloadProfileType
    {
        get => GetProperty<TerraformProperty<string>>("workload_profile_type");
        set => WithProperty("workload_profile_type", value);
    }

}

/// <summary>
/// Manages a azurerm_container_app_environment resource.
/// </summary>
public class AzurermContainerAppEnvironment : TerraformResource
{
    public AzurermContainerAppEnvironment(string name) : base("azurerm_container_app_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_domain");
        this.DeclareOutput("docker_bridge_cidr");
        this.DeclareOutput("platform_reserved_cidr");
        this.DeclareOutput("platform_reserved_dns_ip_address");
        this.DeclareOutput("static_ip_address");
    }

    /// <summary>
    /// Application Insights connection string used by Dapr to export Service to Service communication telemetry.
    /// </summary>
    public TerraformProperty<string>? DaprApplicationInsightsConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("dapr_application_insights_connection_string");
        set => this.WithProperty("dapr_application_insights_connection_string", value);
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
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    public TerraformProperty<string>? InfrastructureResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("infrastructure_resource_group_name");
        set => this.WithProperty("infrastructure_resource_group_name", value);
    }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    public TerraformProperty<string>? InfrastructureSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("infrastructure_subnet_id");
        set => this.WithProperty("infrastructure_subnet_id", value);
    }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    public TerraformProperty<bool>? InternalLoadBalancerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internal_load_balancer_enabled");
        set => this.WithProperty("internal_load_balancer_enabled", value);
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
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    public TerraformProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The logs_destination attribute.
    /// </summary>
    public TerraformProperty<string>? LogsDestination
    {
        get => GetProperty<TerraformProperty<string>>("logs_destination");
        set => this.WithProperty("logs_destination", value);
    }

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    public TerraformProperty<bool>? MutualTlsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("mutual_tls_enabled");
        set => this.WithProperty("mutual_tls_enabled", value);
    }

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public network access setting for the Container App Environment.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
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
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundancyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundancy_enabled");
        set => this.WithProperty("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerAppEnvironmentIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermContainerAppEnvironmentIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerAppEnvironmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for workload_profile.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermContainerAppEnvironmentWorkloadProfileBlock>? WorkloadProfile
    {
        get => GetProperty<HashSet<AzurermContainerAppEnvironmentWorkloadProfileBlock>>("workload_profile");
        set => this.WithProperty("workload_profile", value);
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
