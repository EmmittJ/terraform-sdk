using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_container_app_environment.
/// </summary>
public class AzurermContainerAppEnvironmentDataSource : TerraformDataSource
{
    public AzurermContainerAppEnvironmentDataSource(string name) : base("azurerm_container_app_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_domain");
        this.DeclareOutput("docker_bridge_cidr");
        this.DeclareOutput("infrastructure_subnet_id");
        this.DeclareOutput("internal_load_balancer_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("log_analytics_workspace_name");
        this.DeclareOutput("platform_reserved_cidr");
        this.DeclareOutput("platform_reserved_dns_ip_address");
        this.DeclareOutput("public_network_access");
        this.DeclareOutput("static_ip_address");
        this.DeclareOutput("tags");
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
    /// The name of the Container Apps Managed Environment.
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppEnvironmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerAppEnvironmentDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
    /// The existing Subnet in use by the Container Apps Control Plane.
    /// </summary>
    public TerraformExpression InfrastructureSubnetId => this["infrastructure_subnet_id"];

    /// <summary>
    /// Does the Container Environment operate in Internal Load Balancing Mode?
    /// </summary>
    public TerraformExpression InternalLoadBalancerEnabled => this["internal_load_balancer_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The name of the Log Analytics Workspace this Container Apps Managed Environment is linked to.
    /// </summary>
    public TerraformExpression LogAnalyticsWorkspaceName => this["log_analytics_workspace_name"];

    /// <summary>
    /// The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.
    /// </summary>
    public TerraformExpression PlatformReservedCidr => this["platform_reserved_cidr"];

    /// <summary>
    /// The IP address from the IP range defined by `platform_reserved_cidr` that is reserved for the internal DNS server.
    /// </summary>
    public TerraformExpression PlatformReservedDnsIpAddress => this["platform_reserved_dns_ip_address"];

    /// <summary>
    /// The public network access setting for this Container App Environment.
    /// </summary>
    public TerraformExpression PublicNetworkAccess => this["public_network_access"];

    /// <summary>
    /// The Static IP Address of the Environment.
    /// </summary>
    public TerraformExpression StaticIpAddress => this["static_ip_address"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
