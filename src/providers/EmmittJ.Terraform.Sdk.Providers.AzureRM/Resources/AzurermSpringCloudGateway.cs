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
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    public TerraformProperty<string>? DocumentationUrl
    {
        set => SetProperty("documentation_url", value);
    }

    /// <summary>
    /// The server_url attribute.
    /// </summary>
    public TerraformProperty<string>? ServerUrl
    {
        set => SetProperty("server_url", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        set => SetProperty("title", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
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
        set => SetProperty("certificate_ids", value);
    }

    /// <summary>
    /// The verification_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VerificationEnabled
    {
        set => SetProperty("verification_enabled", value);
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
        set => SetProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedMethods
    {
        set => SetProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origin_patterns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedOriginPatterns
    {
        set => SetProperty("allowed_origin_patterns", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedOrigins
    {
        set => SetProperty("allowed_origins", value);
    }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? CredentialsAllowed
    {
        set => SetProperty("credentials_allowed", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExposedHeaders
    {
        set => SetProperty("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeSeconds
    {
        set => SetProperty("max_age_seconds", value);
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
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformProperty<string>? TimeToLive
    {
        set => SetProperty("time_to_live", value);
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
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformProperty<string>? TimeToLive
    {
        set => SetProperty("time_to_live", value);
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
        set => SetProperty("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        set => SetProperty("memory", value);
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
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformProperty<string>? ClientSecret
    {
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// The issuer_uri attribute.
    /// </summary>
    public TerraformProperty<string>? IssuerUri
    {
        set => SetProperty("issuer_uri", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Scope
    {
        set => SetProperty("scope", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("url");
        SetOutput("application_performance_monitoring_ids");
        SetOutput("application_performance_monitoring_types");
        SetOutput("environment_variables");
        SetOutput("https_only");
        SetOutput("id");
        SetOutput("instance_count");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("sensitive_environment_variables");
        SetOutput("spring_cloud_service_id");
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> ApplicationPerformanceMonitoringIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("application_performance_monitoring_ids");
        set => SetProperty("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The application_performance_monitoring_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> ApplicationPerformanceMonitoringTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("application_performance_monitoring_types");
        set => SetProperty("application_performance_monitoring_types", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> EnvironmentVariables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformProperty<bool> HttpsOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("https_only");
        set => SetProperty("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double> InstanceCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("instance_count");
        set => SetProperty("instance_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The sensitive_environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> SensitiveEnvironmentVariables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("sensitive_environment_variables");
        set => SetProperty("sensitive_environment_variables", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_service_id");
        set => SetProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for api_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiMetadata block(s) allowed")]
    public List<AzurermSpringCloudGatewayApiMetadataBlock>? ApiMetadata
    {
        set => SetProperty("api_metadata", value);
    }

    /// <summary>
    /// Block for client_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthorization block(s) allowed")]
    public List<AzurermSpringCloudGatewayClientAuthorizationBlock>? ClientAuthorization
    {
        set => SetProperty("client_authorization", value);
    }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public List<AzurermSpringCloudGatewayCorsBlock>? Cors
    {
        set => SetProperty("cors", value);
    }

    /// <summary>
    /// Block for local_response_cache_per_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerInstance block(s) allowed")]
    public List<AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock>? LocalResponseCachePerInstance
    {
        set => SetProperty("local_response_cache_per_instance", value);
    }

    /// <summary>
    /// Block for local_response_cache_per_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerRoute block(s) allowed")]
    public List<AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock>? LocalResponseCachePerRoute
    {
        set => SetProperty("local_response_cache_per_route", value);
    }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public List<AzurermSpringCloudGatewayQuotaBlock>? Quota
    {
        set => SetProperty("quota", value);
    }

    /// <summary>
    /// Block for sso.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    public List<AzurermSpringCloudGatewaySsoBlock>? Sso
    {
        set => SetProperty("sso", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
