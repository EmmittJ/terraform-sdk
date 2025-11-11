using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppEnvironmentDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_container_app_environment.
/// </summary>
public partial class AzurermContainerAppEnvironmentDataSource : TerraformDataSource
{
    public AzurermContainerAppEnvironmentDataSource(string name) : base("azurerm_container_app_environment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermContainerAppEnvironmentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App Environment.
    /// </summary>
    [TerraformProperty("custom_domain_verification_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomDomainVerificationId { get; }

    /// <summary>
    /// The default publicly resolvable name of this Container App Environment
    /// </summary>
    [TerraformProperty("default_domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultDomain { get; }

    /// <summary>
    /// The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation.
    /// </summary>
    [TerraformProperty("docker_bridge_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DockerBridgeCidr { get; }

    /// <summary>
    /// The existing Subnet in use by the Container Apps Control Plane.
    /// </summary>
    [TerraformProperty("infrastructure_subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InfrastructureSubnetId { get; }

    /// <summary>
    /// Does the Container Environment operate in Internal Load Balancing Mode?
    /// </summary>
    [TerraformProperty("internal_load_balancer_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> InternalLoadBalancerEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The name of the Log Analytics Workspace this Container Apps Managed Environment is linked to.
    /// </summary>
    [TerraformProperty("log_analytics_workspace_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LogAnalyticsWorkspaceName { get; }

    /// <summary>
    /// The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.
    /// </summary>
    [TerraformProperty("platform_reserved_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlatformReservedCidr { get; }

    /// <summary>
    /// The IP address from the IP range defined by `platform_reserved_cidr` that is reserved for the internal DNS server.
    /// </summary>
    [TerraformProperty("platform_reserved_dns_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlatformReservedDnsIpAddress { get; }

    /// <summary>
    /// The public network access setting for this Container App Environment.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicNetworkAccess { get; }

    /// <summary>
    /// The Static IP Address of the Environment.
    /// </summary>
    [TerraformProperty("static_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StaticIpAddress { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
