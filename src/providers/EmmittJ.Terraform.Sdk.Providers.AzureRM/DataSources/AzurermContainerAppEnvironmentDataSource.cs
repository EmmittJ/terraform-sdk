using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppEnvironmentDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App Environment.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomainVerificationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain_verification_id");

    /// <summary>
    /// The default publicly resolvable name of this Container App Environment
    /// </summary>
    [TerraformPropertyName("default_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_domain");

    /// <summary>
    /// The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation.
    /// </summary>
    [TerraformPropertyName("docker_bridge_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DockerBridgeCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "docker_bridge_cidr");

    /// <summary>
    /// The existing Subnet in use by the Container Apps Control Plane.
    /// </summary>
    [TerraformPropertyName("infrastructure_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InfrastructureSubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "infrastructure_subnet_id");

    /// <summary>
    /// Does the Container Environment operate in Internal Load Balancing Mode?
    /// </summary>
    [TerraformPropertyName("internal_load_balancer_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> InternalLoadBalancerEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "internal_load_balancer_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The name of the Log Analytics Workspace this Container Apps Managed Environment is linked to.
    /// </summary>
    [TerraformPropertyName("log_analytics_workspace_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LogAnalyticsWorkspaceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "log_analytics_workspace_name");

    /// <summary>
    /// The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.
    /// </summary>
    [TerraformPropertyName("platform_reserved_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformReservedCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_reserved_cidr");

    /// <summary>
    /// The IP address from the IP range defined by `platform_reserved_cidr` that is reserved for the internal DNS server.
    /// </summary>
    [TerraformPropertyName("platform_reserved_dns_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformReservedDnsIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_reserved_dns_ip_address");

    /// <summary>
    /// The public network access setting for this Container App Environment.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicNetworkAccess => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_network_access");

    /// <summary>
    /// The Static IP Address of the Environment.
    /// </summary>
    [TerraformPropertyName("static_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StaticIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "static_ip_address");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
