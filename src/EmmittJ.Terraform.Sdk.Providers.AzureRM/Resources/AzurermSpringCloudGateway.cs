using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for api_metadata in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayApiMetadataBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    public TerraformProperty<string>? DocumentationUrl
    {
        get => GetProperty<TerraformProperty<string>>("documentation_url");
        set => WithProperty("documentation_url", value);
    }

    /// <summary>
    /// The server_url attribute.
    /// </summary>
    public TerraformProperty<string>? ServerUrl
    {
        get => GetProperty<TerraformProperty<string>>("server_url");
        set => WithProperty("server_url", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => WithProperty("title", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for client_authorization in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayClientAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CertificateIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("certificate_ids");
        set => WithProperty("certificate_ids", value);
    }

    /// <summary>
    /// The verification_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VerificationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("verification_enabled");
        set => WithProperty("verification_enabled", value);
    }

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayCorsBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedHeaders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_headers");
        set => WithProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_methods");
        set => WithProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origin_patterns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedOriginPatterns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_origin_patterns");
        set => WithProperty("allowed_origin_patterns", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedOrigins
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_origins");
        set => WithProperty("allowed_origins", value);
    }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? CredentialsAllowed
    {
        get => GetProperty<TerraformProperty<bool>>("credentials_allowed");
        set => WithProperty("credentials_allowed", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExposedHeaders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("exposed_headers");
        set => WithProperty("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_age_seconds");
        set => WithProperty("max_age_seconds", value);
    }

}

/// <summary>
/// Block type for local_response_cache_per_instance in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock : TerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<string>? Size
    {
        get => GetProperty<TerraformProperty<string>>("size");
        set => WithProperty("size", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformProperty<string>? TimeToLive
    {
        get => GetProperty<TerraformProperty<string>>("time_to_live");
        set => WithProperty("time_to_live", value);
    }

}

/// <summary>
/// Block type for local_response_cache_per_route in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock : TerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<string>? Size
    {
        get => GetProperty<TerraformProperty<string>>("size");
        set => WithProperty("size", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformProperty<string>? TimeToLive
    {
        get => GetProperty<TerraformProperty<string>>("time_to_live");
        set => WithProperty("time_to_live", value);
    }

}

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayQuotaBlock : TerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformProperty<string>? Cpu
    {
        get => GetProperty<TerraformProperty<string>>("cpu");
        set => WithProperty("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        get => GetProperty<TerraformProperty<string>>("memory");
        set => WithProperty("memory", value);
    }

}

/// <summary>
/// Block type for sso in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewaySsoBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => WithProperty("client_secret", value);
    }

    /// <summary>
    /// The issuer_uri attribute.
    /// </summary>
    public TerraformProperty<string>? IssuerUri
    {
        get => GetProperty<TerraformProperty<string>>("issuer_uri");
        set => WithProperty("issuer_uri", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Scope
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("scope");
        set => WithProperty("scope", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudGatewayTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudGateway : TerraformResource
{
    public AzurermSpringCloudGateway(string name) : base("azurerm_spring_cloud_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ApplicationPerformanceMonitoringIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("application_performance_monitoring_ids");
        set => this.WithProperty("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The application_performance_monitoring_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ApplicationPerformanceMonitoringTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("application_performance_monitoring_types");
        set => this.WithProperty("application_performance_monitoring_types", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => this.WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("https_only");
        set => this.WithProperty("https_only", value);
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The sensitive_environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SensitiveEnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("sensitive_environment_variables");
        set => this.WithProperty("sensitive_environment_variables", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for api_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiMetadata block(s) allowed")]
    public List<AzurermSpringCloudGatewayApiMetadataBlock>? ApiMetadata
    {
        get => GetProperty<List<AzurermSpringCloudGatewayApiMetadataBlock>>("api_metadata");
        set => this.WithProperty("api_metadata", value);
    }

    /// <summary>
    /// Block for client_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthorization block(s) allowed")]
    public List<AzurermSpringCloudGatewayClientAuthorizationBlock>? ClientAuthorization
    {
        get => GetProperty<List<AzurermSpringCloudGatewayClientAuthorizationBlock>>("client_authorization");
        set => this.WithProperty("client_authorization", value);
    }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public List<AzurermSpringCloudGatewayCorsBlock>? Cors
    {
        get => GetProperty<List<AzurermSpringCloudGatewayCorsBlock>>("cors");
        set => this.WithProperty("cors", value);
    }

    /// <summary>
    /// Block for local_response_cache_per_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerInstance block(s) allowed")]
    public List<AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock>? LocalResponseCachePerInstance
    {
        get => GetProperty<List<AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock>>("local_response_cache_per_instance");
        set => this.WithProperty("local_response_cache_per_instance", value);
    }

    /// <summary>
    /// Block for local_response_cache_per_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerRoute block(s) allowed")]
    public List<AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock>? LocalResponseCachePerRoute
    {
        get => GetProperty<List<AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock>>("local_response_cache_per_route");
        set => this.WithProperty("local_response_cache_per_route", value);
    }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public List<AzurermSpringCloudGatewayQuotaBlock>? Quota
    {
        get => GetProperty<List<AzurermSpringCloudGatewayQuotaBlock>>("quota");
        set => this.WithProperty("quota", value);
    }

    /// <summary>
    /// Block for sso.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    public List<AzurermSpringCloudGatewaySsoBlock>? Sso
    {
        get => GetProperty<List<AzurermSpringCloudGatewaySsoBlock>>("sso");
        set => this.WithProperty("sso", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudGatewayTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudGatewayTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
