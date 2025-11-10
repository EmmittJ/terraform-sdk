using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppEnvironmentIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for workload_profile in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppEnvironmentWorkloadProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [TerraformPropertyName("maximum_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumCount { get; set; }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [TerraformPropertyName("minimum_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinimumCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The workload_profile_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadProfileType is required")]
    [TerraformPropertyName("workload_profile_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkloadProfileType { get; set; }

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
    [TerraformPropertyName("dapr_application_insights_connection_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DaprApplicationInsightsConnectionString { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    [TerraformPropertyName("infrastructure_resource_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InfrastructureResourceGroupName { get; set; }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    [TerraformPropertyName("infrastructure_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InfrastructureSubnetId { get; set; }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    [TerraformPropertyName("internal_load_balancer_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InternalLoadBalancerEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The logs_destination attribute.
    /// </summary>
    [TerraformPropertyName("logs_destination")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LogsDestination { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logs_destination");

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    [TerraformPropertyName("mutual_tls_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MutualTlsEnabled { get; set; }

    /// <summary>
    /// The name of the Container Apps Managed Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The public network access setting for the Container App Environment.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicNetworkAccess { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_network_access");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundancy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ZoneRedundancyEnabled { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermContainerAppEnvironmentIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppEnvironmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for workload_profile.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("workload_profile")]
    public TerraformSet<TerraformBlock<AzurermContainerAppEnvironmentWorkloadProfileBlock>>? WorkloadProfile { get; set; } = new();

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
    /// The Static IP Address of the Environment.
    /// </summary>
    [TerraformPropertyName("static_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StaticIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "static_ip_address");

}
