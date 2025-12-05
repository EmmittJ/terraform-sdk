using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_log_settings in AwsApigatewayv2Stage.
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2StageAccessLogSettingsBlock : TerraformBlock
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
/// Block type for default_route_settings in AwsApigatewayv2Stage.
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2StageDefaultRouteSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_route_settings";

    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DataTraceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("data_trace_enabled");
        set => SetArgument("data_trace_enabled", value);
    }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DetailedMetricsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("detailed_metrics_enabled");
        set => SetArgument("detailed_metrics_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformValue<string> LoggingLevel
    {
        get => GetArgument<TerraformValue<string>>("logging_level") ?? CreateReference("logging_level");
        set => SetArgument("logging_level", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformValue<double>? ThrottlingBurstLimit
    {
        get => GetArgument<TerraformValue<double>>("throttling_burst_limit");
        set => SetArgument("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformValue<double>? ThrottlingRateLimit
    {
        get => GetArgument<TerraformValue<double>>("throttling_rate_limit");
        set => SetArgument("throttling_rate_limit", value);
    }

}


/// <summary>
/// Block type for route_settings in AwsApigatewayv2Stage.
/// Nesting mode: set
/// </summary>
public class AwsApigatewayv2StageRouteSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_settings";

    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DataTraceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("data_trace_enabled");
        set => SetArgument("data_trace_enabled", value);
    }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DetailedMetricsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("detailed_metrics_enabled");
        set => SetArgument("detailed_metrics_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformValue<string> LoggingLevel
    {
        get => GetArgument<TerraformValue<string>>("logging_level") ?? CreateReference("logging_level");
        set => SetArgument("logging_level", value);
    }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    public required TerraformValue<string> RouteKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("route_key");
        set => SetArgument("route_key", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformValue<double>? ThrottlingBurstLimit
    {
        get => GetArgument<TerraformValue<double>>("throttling_burst_limit");
        set => SetArgument("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformValue<double>? ThrottlingRateLimit
    {
        get => GetArgument<TerraformValue<double>>("throttling_rate_limit");
        set => SetArgument("throttling_rate_limit", value);
    }

}


/// <summary>
/// Represents a aws_apigatewayv2_stage Terraform resource.
/// Manages a aws_apigatewayv2_stage resource.
/// </summary>
public partial class AwsApigatewayv2Stage(string name) : TerraformResource("aws_apigatewayv2_stage", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The auto_deploy attribute.
    /// </summary>
    public TerraformValue<bool>? AutoDeploy
    {
        get => GetArgument<TerraformValue<bool>>("auto_deploy");
        set => SetArgument("auto_deploy", value);
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
    public TerraformValue<string> DeploymentId
    {
        get => GetArgument<TerraformValue<string>>("deployment_id") ?? CreateReference("deployment_id");
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The stage_variables attribute.
    /// </summary>
    public TerraformMap<string>? StageVariables
    {
        get => GetArgument<TerraformMap<string>>("stage_variables");
        set => SetArgument("stage_variables", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
        => CreateReference("execution_arn");

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    public TerraformValue<string> InvokeUrl
        => CreateReference("invoke_url");

    /// <summary>
    /// AccessLogSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    public TerraformList<AwsApigatewayv2StageAccessLogSettingsBlock>? AccessLogSettings
    {
        get => GetArgument<TerraformList<AwsApigatewayv2StageAccessLogSettingsBlock>>("access_log_settings");
        set => SetArgument("access_log_settings", value);
    }

    /// <summary>
    /// DefaultRouteSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteSettings block(s) allowed")]
    public TerraformList<AwsApigatewayv2StageDefaultRouteSettingsBlock>? DefaultRouteSettings
    {
        get => GetArgument<TerraformList<AwsApigatewayv2StageDefaultRouteSettingsBlock>>("default_route_settings");
        set => SetArgument("default_route_settings", value);
    }

    /// <summary>
    /// RouteSettings block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsApigatewayv2StageRouteSettingsBlock>? RouteSettings
    {
        get => GetArgument<TerraformSet<AwsApigatewayv2StageRouteSettingsBlock>>("route_settings");
        set => SetArgument("route_settings", value);
    }

}
