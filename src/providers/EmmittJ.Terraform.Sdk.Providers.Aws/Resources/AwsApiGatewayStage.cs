using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_log_settings in AwsApiGatewayStage.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayStageAccessLogSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_log_settings";

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformValue<string> DestinationArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_arn");
        set => SetArgument("destination_arn", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => GetRequiredArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

}


/// <summary>
/// Block type for canary_settings in AwsApiGatewayStage.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayStageCanarySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "canary_settings";

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    public required TerraformValue<string> DeploymentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("deployment_id");
        set => SetArgument("deployment_id", value);
    }

    /// <summary>
    /// The percent_traffic attribute.
    /// </summary>
    public TerraformValue<double>? PercentTraffic
    {
        get => GetArgument<TerraformValue<double>>("percent_traffic");
        set => SetArgument("percent_traffic", value);
    }

    /// <summary>
    /// The stage_variable_overrides attribute.
    /// </summary>
    public TerraformMap<string>? StageVariableOverrides
    {
        get => GetArgument<TerraformMap<string>>("stage_variable_overrides");
        set => SetArgument("stage_variable_overrides", value);
    }

    /// <summary>
    /// The use_stage_cache attribute.
    /// </summary>
    public TerraformValue<bool>? UseStageCache
    {
        get => GetArgument<TerraformValue<bool>>("use_stage_cache");
        set => SetArgument("use_stage_cache", value);
    }

}


/// <summary>
/// Represents a aws_api_gateway_stage Terraform resource.
/// Manages a aws_api_gateway_stage resource.
/// </summary>
public partial class AwsApiGatewayStage(string name) : TerraformResource("aws_api_gateway_stage", name)
{
    /// <summary>
    /// The cache_cluster_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CacheClusterEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cache_cluster_enabled");
        set => SetArgument("cache_cluster_enabled", value);
    }

    /// <summary>
    /// The cache_cluster_size attribute.
    /// </summary>
    public TerraformValue<string>? CacheClusterSize
    {
        get => GetArgument<TerraformValue<string>>("cache_cluster_size");
        set => SetArgument("cache_cluster_size", value);
    }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificateId
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_id");
        set => SetArgument("client_certificate_id", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    public required TerraformValue<string> DeploymentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("deployment_id");
        set => SetArgument("deployment_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The documentation_version attribute.
    /// </summary>
    public TerraformValue<string>? DocumentationVersion
    {
        get => GetArgument<TerraformValue<string>>("documentation_version");
        set => SetArgument("documentation_version", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => GetRequiredArgument<TerraformValue<string>>("rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformValue<string> StageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("stage_name");
        set => SetArgument("stage_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public TerraformMap<string>? Variables
    {
        get => GetArgument<TerraformMap<string>>("variables");
        set => SetArgument("variables", value);
    }

    /// <summary>
    /// The xray_tracing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? XrayTracingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("xray_tracing_enabled");
        set => SetArgument("xray_tracing_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
        => AsReference("execution_arn");

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    public TerraformValue<string> InvokeUrl
        => AsReference("invoke_url");

    /// <summary>
    /// The web_acl_arn attribute.
    /// </summary>
    public TerraformValue<string> WebAclArn
        => AsReference("web_acl_arn");

    /// <summary>
    /// AccessLogSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    public TerraformList<AwsApiGatewayStageAccessLogSettingsBlock>? AccessLogSettings
    {
        get => GetArgument<TerraformList<AwsApiGatewayStageAccessLogSettingsBlock>>("access_log_settings");
        set => SetArgument("access_log_settings", value);
    }

    /// <summary>
    /// CanarySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanarySettings block(s) allowed")]
    public TerraformList<AwsApiGatewayStageCanarySettingsBlock>? CanarySettings
    {
        get => GetArgument<TerraformList<AwsApiGatewayStageCanarySettingsBlock>>("canary_settings");
        set => SetArgument("canary_settings", value);
    }

}
