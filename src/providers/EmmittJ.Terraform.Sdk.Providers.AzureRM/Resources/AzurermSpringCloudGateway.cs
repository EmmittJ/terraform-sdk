using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for api_metadata in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayApiMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_metadata";

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    [TerraformArgument("documentation_url")]
    public TerraformValue<string>? DocumentationUrl
    {
        get => new TerraformReference<string>(this, "documentation_url");
        set => SetArgument("documentation_url", value);
    }

    /// <summary>
    /// The server_url attribute.
    /// </summary>
    [TerraformArgument("server_url")]
    public TerraformValue<string>? ServerUrl
    {
        get => new TerraformReference<string>(this, "server_url");
        set => SetArgument("server_url", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformArgument("title")]
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for client_authorization in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayClientAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_authorization";

    /// <summary>
    /// The certificate_ids attribute.
    /// </summary>
    [TerraformArgument("certificate_ids")]
    public TerraformList<string>? CertificateIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "certificate_ids").ResolveNodes(ctx));
        set => SetArgument("certificate_ids", value);
    }

    /// <summary>
    /// The verification_enabled attribute.
    /// </summary>
    [TerraformArgument("verification_enabled")]
    public TerraformValue<bool>? VerificationEnabled
    {
        get => new TerraformReference<bool>(this, "verification_enabled");
        set => SetArgument("verification_enabled", value);
    }

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [TerraformArgument("allowed_headers")]
    public TerraformSet<string>? AllowedHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [TerraformArgument("allowed_methods")]
    public TerraformSet<string>? AllowedMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origin_patterns attribute.
    /// </summary>
    [TerraformArgument("allowed_origin_patterns")]
    public TerraformSet<string>? AllowedOriginPatterns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_origin_patterns").ResolveNodes(ctx));
        set => SetArgument("allowed_origin_patterns", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [TerraformArgument("allowed_origins")]
    public TerraformSet<string>? AllowedOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    [TerraformArgument("credentials_allowed")]
    public TerraformValue<bool>? CredentialsAllowed
    {
        get => new TerraformReference<bool>(this, "credentials_allowed");
        set => SetArgument("credentials_allowed", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [TerraformArgument("exposed_headers")]
    public TerraformSet<string>? ExposedHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "exposed_headers").ResolveNodes(ctx));
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    [TerraformArgument("max_age_seconds")]
    public TerraformValue<double>? MaxAgeSeconds
    {
        get => new TerraformReference<double>(this, "max_age_seconds");
        set => SetArgument("max_age_seconds", value);
    }

}

/// <summary>
/// Block type for local_response_cache_per_instance in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_response_cache_per_instance";

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformArgument("size")]
    public TerraformValue<string>? Size
    {
        get => new TerraformReference<string>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformArgument("time_to_live")]
    public TerraformValue<string>? TimeToLive
    {
        get => new TerraformReference<string>(this, "time_to_live");
        set => SetArgument("time_to_live", value);
    }

}

/// <summary>
/// Block type for local_response_cache_per_route in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_response_cache_per_route";

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformArgument("size")]
    public TerraformValue<string>? Size
    {
        get => new TerraformReference<string>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformArgument("time_to_live")]
    public TerraformValue<string>? TimeToLive
    {
        get => new TerraformReference<string>(this, "time_to_live");
        set => SetArgument("time_to_live", value);
    }

}

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayQuotaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quota";

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformArgument("cpu")]
    public TerraformValue<string>? Cpu
    {
        get => new TerraformReference<string>(this, "cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformArgument("memory")]
    public TerraformValue<string>? Memory
    {
        get => new TerraformReference<string>(this, "memory");
        set => SetArgument("memory", value);
    }

}

/// <summary>
/// Block type for sso in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewaySsoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sso";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformArgument("client_id")]
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformArgument("client_secret")]
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer_uri attribute.
    /// </summary>
    [TerraformArgument("issuer_uri")]
    public TerraformValue<string>? IssuerUri
    {
        get => new TerraformReference<string>(this, "issuer_uri");
        set => SetArgument("issuer_uri", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformArgument("scope")]
    public TerraformSet<string>? Scope
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scope").ResolveNodes(ctx));
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    [TerraformArgument("application_performance_monitoring_ids")]
    public TerraformList<string>? ApplicationPerformanceMonitoringIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "application_performance_monitoring_ids").ResolveNodes(ctx));
        set => SetArgument("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The application_performance_monitoring_types attribute.
    /// </summary>
    [TerraformArgument("application_performance_monitoring_types")]
    public TerraformList<string>? ApplicationPerformanceMonitoringTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "application_performance_monitoring_types").ResolveNodes(ctx));
        set => SetArgument("application_performance_monitoring_types", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformArgument("environment_variables")]
    public TerraformMap<string>? EnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment_variables").ResolveNodes(ctx));
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformArgument("https_only")]
    public TerraformValue<bool>? HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
        set => SetArgument("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformArgument("instance_count")]
    public TerraformValue<double>? InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The sensitive_environment_variables attribute.
    /// </summary>
    [TerraformArgument("sensitive_environment_variables")]
    public TerraformMap<string>? SensitiveEnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "sensitive_environment_variables").ResolveNodes(ctx));
        set => SetArgument("sensitive_environment_variables", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformArgument("spring_cloud_service_id")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => new TerraformReference<string>(this, "spring_cloud_service_id");
        set => SetArgument("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for api_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiMetadata block(s) allowed")]
    [TerraformArgument("api_metadata")]
    public TerraformList<AzurermSpringCloudGatewayApiMetadataBlock> ApiMetadata { get; set; } = new();

    /// <summary>
    /// Block for client_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthorization block(s) allowed")]
    [TerraformArgument("client_authorization")]
    public TerraformList<AzurermSpringCloudGatewayClientAuthorizationBlock> ClientAuthorization { get; set; } = new();

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    [TerraformArgument("cors")]
    public TerraformList<AzurermSpringCloudGatewayCorsBlock> Cors { get; set; } = new();

    /// <summary>
    /// Block for local_response_cache_per_instance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerInstance block(s) allowed")]
    [TerraformArgument("local_response_cache_per_instance")]
    public TerraformList<AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock> LocalResponseCachePerInstance { get; set; } = new();

    /// <summary>
    /// Block for local_response_cache_per_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerRoute block(s) allowed")]
    [TerraformArgument("local_response_cache_per_route")]
    public TerraformList<AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock> LocalResponseCachePerRoute { get; set; } = new();

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformArgument("quota")]
    public TerraformList<AzurermSpringCloudGatewayQuotaBlock> Quota { get; set; } = new();

    /// <summary>
    /// Block for sso.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    [TerraformArgument("sso")]
    public TerraformList<AzurermSpringCloudGatewaySsoBlock> Sso { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudGatewayTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
