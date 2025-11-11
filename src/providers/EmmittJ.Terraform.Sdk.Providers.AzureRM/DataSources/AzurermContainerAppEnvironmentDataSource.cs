using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppEnvironmentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App Environment.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomDomainVerificationId => new TerraformReference(this, "custom_domain_verification_id");

    /// <summary>
    /// The default publicly resolvable name of this Container App Environment
    /// </summary>
    [TerraformPropertyName("default_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultDomain => new TerraformReference(this, "default_domain");

    /// <summary>
    /// The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation.
    /// </summary>
    [TerraformPropertyName("docker_bridge_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DockerBridgeCidr => new TerraformReference(this, "docker_bridge_cidr");

    /// <summary>
    /// The existing Subnet in use by the Container Apps Control Plane.
    /// </summary>
    [TerraformPropertyName("infrastructure_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InfrastructureSubnetId => new TerraformReference(this, "infrastructure_subnet_id");

    /// <summary>
    /// Does the Container Environment operate in Internal Load Balancing Mode?
    /// </summary>
    [TerraformPropertyName("internal_load_balancer_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> InternalLoadBalancerEnabled => new TerraformReference(this, "internal_load_balancer_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The name of the Log Analytics Workspace this Container Apps Managed Environment is linked to.
    /// </summary>
    [TerraformPropertyName("log_analytics_workspace_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LogAnalyticsWorkspaceName => new TerraformReference(this, "log_analytics_workspace_name");

    /// <summary>
    /// The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.
    /// </summary>
    [TerraformPropertyName("platform_reserved_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlatformReservedCidr => new TerraformReference(this, "platform_reserved_cidr");

    /// <summary>
    /// The IP address from the IP range defined by `platform_reserved_cidr` that is reserved for the internal DNS server.
    /// </summary>
    [TerraformPropertyName("platform_reserved_dns_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlatformReservedDnsIpAddress => new TerraformReference(this, "platform_reserved_dns_ip_address");

    /// <summary>
    /// The public network access setting for this Container App Environment.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicNetworkAccess => new TerraformReference(this, "public_network_access");

    /// <summary>
    /// The Static IP Address of the Environment.
    /// </summary>
    [TerraformPropertyName("static_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StaticIpAddress => new TerraformReference(this, "static_ip_address");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
