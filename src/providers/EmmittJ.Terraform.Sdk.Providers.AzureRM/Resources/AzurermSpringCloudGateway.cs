using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for api_metadata in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayApiMetadataBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    [TerraformPropertyName("documentation_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DocumentationUrl { get; set; }

    /// <summary>
    /// The server_url attribute.
    /// </summary>
    [TerraformPropertyName("server_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServerUrl { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for client_authorization in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayClientAuthorizationBlock
{
    /// <summary>
    /// The certificate_ids attribute.
    /// </summary>
    [TerraformPropertyName("certificate_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? CertificateIds { get; set; }

    /// <summary>
    /// The verification_enabled attribute.
    /// </summary>
    [TerraformPropertyName("verification_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VerificationEnabled { get; set; }

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayCorsBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [TerraformPropertyName("allowed_headers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [TerraformPropertyName("allowed_methods")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origin_patterns attribute.
    /// </summary>
    [TerraformPropertyName("allowed_origin_patterns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowedOriginPatterns { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [TerraformPropertyName("allowed_origins")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    [TerraformPropertyName("credentials_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CredentialsAllowed { get; set; }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [TerraformPropertyName("exposed_headers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ExposedHeaders { get; set; }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    [TerraformPropertyName("max_age_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxAgeSeconds { get; set; }

}

/// <summary>
/// Block type for local_response_cache_per_instance in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Size { get; set; }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformPropertyName("time_to_live")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimeToLive { get; set; }

}

/// <summary>
/// Block type for local_response_cache_per_route in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Size { get; set; }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformPropertyName("time_to_live")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimeToLive { get; set; }

}

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayQuotaBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Cpu { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Memory { get; set; }

}

/// <summary>
/// Block type for sso in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewaySsoBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformPropertyName("client_secret")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientSecret { get; set; }

    /// <summary>
    /// The issuer_uri attribute.
    /// </summary>
    [TerraformPropertyName("issuer_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IssuerUri { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Scope { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudGatewayTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudGateway : TerraformResource
{
    public AzurermSpringCloudGateway(string name) : base("azurerm_spring_cloud_gateway", name)
    {
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    [TerraformPropertyName("application_performance_monitoring_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>
    /// The application_performance_monitoring_types attribute.
    /// </summary>
    [TerraformPropertyName("application_performance_monitoring_types")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ApplicationPerformanceMonitoringTypes { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformPropertyName("https_only")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The sensitive_environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("sensitive_environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? SensitiveEnvironmentVariables { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformPropertyName("spring_cloud_service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for api_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiMetadata block(s) allowed")]
    [TerraformPropertyName("api_metadata")]
    public TerraformList<TerraformBlock<AzurermSpringCloudGatewayApiMetadataBlock>>? ApiMetadata { get; set; }

    /// <summary>
    /// Block for client_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthorization block(s) allowed")]
    [TerraformPropertyName("client_authorization")]
    public TerraformList<TerraformBlock<AzurermSpringCloudGatewayClientAuthorizationBlock>>? ClientAuthorization { get; set; }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    [TerraformPropertyName("cors")]
    public TerraformList<TerraformBlock<AzurermSpringCloudGatewayCorsBlock>>? Cors { get; set; }

    /// <summary>
    /// Block for local_response_cache_per_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerInstance block(s) allowed")]
    [TerraformPropertyName("local_response_cache_per_instance")]
    public TerraformList<TerraformBlock<AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock>>? LocalResponseCachePerInstance { get; set; }

    /// <summary>
    /// Block for local_response_cache_per_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerRoute block(s) allowed")]
    [TerraformPropertyName("local_response_cache_per_route")]
    public TerraformList<TerraformBlock<AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock>>? LocalResponseCachePerRoute { get; set; }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformPropertyName("quota")]
    public TerraformList<TerraformBlock<AzurermSpringCloudGatewayQuotaBlock>>? Quota { get; set; }

    /// <summary>
    /// Block for sso.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    [TerraformPropertyName("sso")]
    public TerraformList<TerraformBlock<AzurermSpringCloudGatewaySsoBlock>>? Sso { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Url => new TerraformReference(this, "url");

}
