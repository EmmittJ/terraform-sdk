using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for api_metadata in AzurermSpringCloudGateway.
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
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    public TerraformValue<string>? DocumentationUrl
    {
        get => GetArgument<TerraformValue<string>>("documentation_url");
        set => SetArgument("documentation_url", value);
    }

    /// <summary>
    /// The server_url attribute.
    /// </summary>
    public TerraformValue<string>? ServerUrl
    {
        get => GetArgument<TerraformValue<string>>("server_url");
        set => SetArgument("server_url", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for client_authorization in AzurermSpringCloudGateway.
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
    public TerraformList<string>? CertificateIds
    {
        get => GetArgument<TerraformList<string>>("certificate_ids");
        set => SetArgument("certificate_ids", value);
    }

    /// <summary>
    /// The verification_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VerificationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("verification_enabled");
        set => SetArgument("verification_enabled", value);
    }

}


/// <summary>
/// Block type for cors in AzurermSpringCloudGateway.
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
    public TerraformSet<string>? AllowedHeaders
    {
        get => GetArgument<TerraformSet<string>>("allowed_headers");
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    public TerraformSet<string>? AllowedMethods
    {
        get => GetArgument<TerraformSet<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origin_patterns attribute.
    /// </summary>
    public TerraformSet<string>? AllowedOriginPatterns
    {
        get => GetArgument<TerraformSet<string>>("allowed_origin_patterns");
        set => SetArgument("allowed_origin_patterns", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    public TerraformSet<string>? AllowedOrigins
    {
        get => GetArgument<TerraformSet<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? CredentialsAllowed
    {
        get => GetArgument<TerraformValue<bool>>("credentials_allowed");
        set => SetArgument("credentials_allowed", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    public TerraformSet<string>? ExposedHeaders
    {
        get => GetArgument<TerraformSet<string>>("exposed_headers");
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxAgeSeconds
    {
        get => GetArgument<TerraformValue<double>>("max_age_seconds");
        set => SetArgument("max_age_seconds", value);
    }

}


/// <summary>
/// Block type for local_response_cache_per_instance in AzurermSpringCloudGateway.
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
    public TerraformValue<string>? Size
    {
        get => GetArgument<TerraformValue<string>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformValue<string>? TimeToLive
    {
        get => GetArgument<TerraformValue<string>>("time_to_live");
        set => SetArgument("time_to_live", value);
    }

}


/// <summary>
/// Block type for local_response_cache_per_route in AzurermSpringCloudGateway.
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
    public TerraformValue<string>? Size
    {
        get => GetArgument<TerraformValue<string>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformValue<string>? TimeToLive
    {
        get => GetArgument<TerraformValue<string>>("time_to_live");
        set => SetArgument("time_to_live", value);
    }

}


/// <summary>
/// Block type for quota in AzurermSpringCloudGateway.
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
    public TerraformValue<string>? Cpu
    {
        get => GetArgument<TerraformValue<string>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string>? Memory
    {
        get => GetArgument<TerraformValue<string>>("memory");
        set => SetArgument("memory", value);
    }

}


/// <summary>
/// Block type for sso in AzurermSpringCloudGateway.
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
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer_uri attribute.
    /// </summary>
    public TerraformValue<string>? IssuerUri
    {
        get => GetArgument<TerraformValue<string>>("issuer_uri");
        set => SetArgument("issuer_uri", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformSet<string>? Scope
    {
        get => GetArgument<TerraformSet<string>>("scope");
        set => SetArgument("scope", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudGateway.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_spring_cloud_gateway Terraform resource.
/// Manages a azurerm_spring_cloud_gateway resource.
/// </summary>
public partial class AzurermSpringCloudGateway(string name) : TerraformResource("azurerm_spring_cloud_gateway", name)
{
    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    public TerraformList<string>? ApplicationPerformanceMonitoringIds
    {
        get => GetArgument<TerraformList<string>>("application_performance_monitoring_ids");
        set => SetArgument("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The application_performance_monitoring_types attribute.
    /// </summary>
    public TerraformList<string>? ApplicationPerformanceMonitoringTypes
    {
        get => GetArgument<TerraformList<string>>("application_performance_monitoring_types");
        set => SetArgument("application_performance_monitoring_types", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnly
    {
        get => GetArgument<TerraformValue<bool>>("https_only");
        set => SetArgument("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => GetArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The sensitive_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? SensitiveEnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("sensitive_environment_variables");
        set => SetArgument("sensitive_environment_variables", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("spring_cloud_service_id");
        set => SetArgument("spring_cloud_service_id", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// ApiMetadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiMetadata block(s) allowed")]
    public TerraformList<AzurermSpringCloudGatewayApiMetadataBlock>? ApiMetadata
    {
        get => GetArgument<TerraformList<AzurermSpringCloudGatewayApiMetadataBlock>>("api_metadata");
        set => SetArgument("api_metadata", value);
    }

    /// <summary>
    /// ClientAuthorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthorization block(s) allowed")]
    public TerraformList<AzurermSpringCloudGatewayClientAuthorizationBlock>? ClientAuthorization
    {
        get => GetArgument<TerraformList<AzurermSpringCloudGatewayClientAuthorizationBlock>>("client_authorization");
        set => SetArgument("client_authorization", value);
    }

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermSpringCloudGatewayCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermSpringCloudGatewayCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

    /// <summary>
    /// LocalResponseCachePerInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerInstance block(s) allowed")]
    public TerraformList<AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock>? LocalResponseCachePerInstance
    {
        get => GetArgument<TerraformList<AzurermSpringCloudGatewayLocalResponseCachePerInstanceBlock>>("local_response_cache_per_instance");
        set => SetArgument("local_response_cache_per_instance", value);
    }

    /// <summary>
    /// LocalResponseCachePerRoute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalResponseCachePerRoute block(s) allowed")]
    public TerraformList<AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock>? LocalResponseCachePerRoute
    {
        get => GetArgument<TerraformList<AzurermSpringCloudGatewayLocalResponseCachePerRouteBlock>>("local_response_cache_per_route");
        set => SetArgument("local_response_cache_per_route", value);
    }

    /// <summary>
    /// Quota block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public TerraformList<AzurermSpringCloudGatewayQuotaBlock>? Quota
    {
        get => GetArgument<TerraformList<AzurermSpringCloudGatewayQuotaBlock>>("quota");
        set => SetArgument("quota", value);
    }

    /// <summary>
    /// Sso block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    public TerraformList<AzurermSpringCloudGatewaySsoBlock>? Sso
    {
        get => GetArgument<TerraformList<AzurermSpringCloudGatewaySsoBlock>>("sso");
        set => SetArgument("sso", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
