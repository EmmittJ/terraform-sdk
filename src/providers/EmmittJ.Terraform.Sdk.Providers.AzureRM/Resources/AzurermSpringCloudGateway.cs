using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for api_metadata in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudGatewayApiMetadataBlock : TerraformBlockBase
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    [TerraformProperty("documentation_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DocumentationUrl { get; set; }

    /// <summary>
    /// The server_url attribute.
    /// </summary>
    [TerraformProperty("server_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServerUrl { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformProperty("title")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for client_authorization in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudGatewayClientAuthorizationBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate_ids attribute.
    /// </summary>
    [TerraformProperty("certificate_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? CertificateIds { get; set; }

    /// <summary>
    /// The verification_enabled attribute.
    /// </summary>
    [TerraformProperty("verification_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VerificationEnabled { get; set; }

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudGatewayCorsBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [TerraformProperty("allowed_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [TerraformProperty("allowed_methods")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origin_patterns attribute.
    /// </summary>
    [TerraformProperty("allowed_origin_patterns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedOriginPatterns { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [TerraformProperty("allowed_origins")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    [TerraformProperty("credentials_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CredentialsAllowed { get; set; }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [TerraformProperty("exposed_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ExposedHeaders { get; set; }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    [TerraformProperty("max_age_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxAgeSeconds { get; set; }

}

/// <summary>
/// Block type for local_response_cache_per_instance in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock : TerraformBlockBase
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Size { get; set; }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformProperty("time_to_live")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeToLive { get; set; }

}

/// <summary>
/// Block type for local_response_cache_per_route in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock : TerraformBlockBase
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Size { get; set; }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformProperty("time_to_live")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeToLive { get; set; }

}

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudGatewayQuotaBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformProperty("cpu")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cpu { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformProperty("memory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Memory { get; set; }

}

/// <summary>
/// Block type for sso in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudGatewaySsoBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformProperty("client_secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientSecret { get; set; }

    /// <summary>
    /// The issuer_uri attribute.
    /// </summary>
    [TerraformProperty("issuer_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IssuerUri { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Scope { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudGatewayTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_spring_cloud_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudGateway : TerraformResource
{
    public AzurermSpringCloudGateway(string name) : base("azurerm_spring_cloud_gateway", name)
    {
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    [TerraformProperty("application_performance_monitoring_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>
    /// The application_performance_monitoring_types attribute.
    /// </summary>
    [TerraformProperty("application_performance_monitoring_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ApplicationPerformanceMonitoringTypes { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformProperty("https_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The sensitive_environment_variables attribute.
    /// </summary>
    [TerraformProperty("sensitive_environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? SensitiveEnvironmentVariables { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformProperty("spring_cloud_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for api_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiMetadata block(s) allowed")]
    [TerraformProperty("api_metadata")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudGatewayApiMetadataBlock>>? ApiMetadata { get; set; }

    /// <summary>
    /// Block for client_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthorization block(s) allowed")]
    [TerraformProperty("client_authorization")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudGatewayClientAuthorizationBlock>>? ClientAuthorization { get; set; }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    [TerraformProperty("cors")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudGatewayCorsBlock>>? Cors { get; set; }

    /// <summary>
    /// Block for local_response_cache_per_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerInstance block(s) allowed")]
    [TerraformProperty("local_response_cache_per_instance")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock>>? LocalResponseCachePerInstance { get; set; }

    /// <summary>
    /// Block for local_response_cache_per_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerRoute block(s) allowed")]
    [TerraformProperty("local_response_cache_per_route")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock>>? LocalResponseCachePerRoute { get; set; }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformProperty("quota")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudGatewayQuotaBlock>>? Quota { get; set; }

    /// <summary>
    /// Block for sso.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    [TerraformProperty("sso")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudGatewaySsoBlock>>? Sso { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSpringCloudGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
