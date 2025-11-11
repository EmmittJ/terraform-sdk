using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppEnvironmentIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppEnvironmentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for workload_profile in .
/// Nesting mode: set
/// </summary>
public partial class AzurermContainerAppEnvironmentWorkloadProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [TerraformProperty("maximum_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumCount { get; set; }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [TerraformProperty("minimum_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinimumCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The workload_profile_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadProfileType is required")]
    [TerraformProperty("workload_profile_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkloadProfileType { get; set; }

}

/// <summary>
/// Manages a azurerm_container_app_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermContainerAppEnvironment : TerraformResource
{
    public AzurermContainerAppEnvironment(string name) : base("azurerm_container_app_environment", name)
    {
    }

    /// <summary>
    /// Application Insights connection string used by Dapr to export Service to Service communication telemetry.
    /// </summary>
    [TerraformProperty("dapr_application_insights_connection_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DaprApplicationInsightsConnectionString { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    [TerraformProperty("infrastructure_resource_group_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InfrastructureResourceGroupName { get; set; }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    [TerraformProperty("infrastructure_subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InfrastructureSubnetId { get; set; }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    [TerraformProperty("internal_load_balancer_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternalLoadBalancerEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    [TerraformProperty("log_analytics_workspace_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The logs_destination attribute.
    /// </summary>
    [TerraformProperty("logs_destination")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LogsDestination { get; set; }

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    [TerraformProperty("mutual_tls_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MutualTlsEnabled { get; set; }

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public network access setting for the Container App Environment.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PublicNetworkAccess { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformProperty("zone_redundancy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZoneRedundancyEnabled { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermContainerAppEnvironmentIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermContainerAppEnvironmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for workload_profile.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("workload_profile")]
    public partial TerraformSet<TerraformBlock<AzurermContainerAppEnvironmentWorkloadProfileBlock>>? WorkloadProfile { get; set; }

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
    /// The Static IP Address of the Environment.
    /// </summary>
    [TerraformProperty("static_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StaticIpAddress { get; }

}
