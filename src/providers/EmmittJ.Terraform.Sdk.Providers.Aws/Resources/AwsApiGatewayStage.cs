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
        get => new TerraformReference<string>(this, "destination_arn");
        set => SetArgument("destination_arn", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
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
        get => new TerraformReference<string>(this, "deployment_id");
        set => SetArgument("deployment_id", value);
    }

    /// <summary>
    /// The percent_traffic attribute.
    /// </summary>
    public TerraformValue<double>? PercentTraffic
    {
        get => new TerraformReference<double>(this, "percent_traffic");
        set => SetArgument("percent_traffic", value);
    }

    /// <summary>
    /// The stage_variable_overrides attribute.
    /// </summary>
    public TerraformMap<string>? StageVariableOverrides
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "stage_variable_overrides").ResolveNodes(ctx));
        set => SetArgument("stage_variable_overrides", value);
    }

    /// <summary>
    /// The use_stage_cache attribute.
    /// </summary>
    public TerraformValue<bool>? UseStageCache
    {
        get => new TerraformReference<bool>(this, "use_stage_cache");
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
        get => new TerraformReference<bool>(this, "cache_cluster_enabled");
        set => SetArgument("cache_cluster_enabled", value);
    }

    /// <summary>
    /// The cache_cluster_size attribute.
    /// </summary>
    public TerraformValue<string>? CacheClusterSize
    {
        get => new TerraformReference<string>(this, "cache_cluster_size");
        set => SetArgument("cache_cluster_size", value);
    }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificateId
    {
        get => new TerraformReference<string>(this, "client_certificate_id");
        set => SetArgument("client_certificate_id", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    public required TerraformValue<string> DeploymentId
    {
        get => new TerraformReference<string>(this, "deployment_id");
        set => SetArgument("deployment_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The documentation_version attribute.
    /// </summary>
    public TerraformValue<string>? DocumentationVersion
    {
        get => new TerraformReference<string>(this, "documentation_version");
        set => SetArgument("documentation_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => new TerraformReference<string>(this, "rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformValue<string> StageName
    {
        get => new TerraformReference<string>(this, "stage_name");
        set => SetArgument("stage_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public TerraformMap<string>? Variables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "variables").ResolveNodes(ctx));
        set => SetArgument("variables", value);
    }

    /// <summary>
    /// The xray_tracing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? XrayTracingEnabled
    {
        get => new TerraformReference<bool>(this, "xray_tracing_enabled");
        set => SetArgument("xray_tracing_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
    {
        get => new TerraformReference<string>(this, "execution_arn");
    }

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    public TerraformValue<string> InvokeUrl
    {
        get => new TerraformReference<string>(this, "invoke_url");
    }

    /// <summary>
    /// The web_acl_arn attribute.
    /// </summary>
    public TerraformValue<string> WebAclArn
    {
        get => new TerraformReference<string>(this, "web_acl_arn");
    }

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
