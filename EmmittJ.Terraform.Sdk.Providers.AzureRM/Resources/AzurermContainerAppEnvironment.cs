using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public string? DaprApplicationInsightsConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dapr_application_insights_connection_string")?.Value;
        set => this.WithProperty("dapr_application_insights_connection_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    public string? InfrastructureResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("infrastructure_resource_group_name")?.Value;
        set => this.WithProperty("infrastructure_resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    public string? InfrastructureSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("infrastructure_subnet_id")?.Value;
        set => this.WithProperty("infrastructure_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    public bool? InternalLoadBalancerEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internal_load_balancer_enabled")?.Value;
        set => this.WithProperty("internal_load_balancer_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    public string? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id")?.Value;
        set => this.WithProperty("log_analytics_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The logs_destination attribute.
    /// </summary>
    public string? LogsDestination
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logs_destination")?.Value;
        set => this.WithProperty("logs_destination", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    public bool? MutualTlsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("mutual_tls_enabled")?.Value;
        set => this.WithProperty("mutual_tls_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public network access setting for the Container App Environment.
    /// </summary>
    public string? PublicNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_network_access")?.Value;
        set => this.WithProperty("public_network_access", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public bool? ZoneRedundancyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundancy_enabled")?.Value;
        set => this.WithProperty("zone_redundancy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
