using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_log_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2StageAccessLogSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformProperty<string> DestinationArn
    {
        get => GetProperty<TerraformProperty<string>>("destination_arn");
        set => WithProperty("destination_arn", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        get => GetProperty<TerraformProperty<string>>("format");
        set => WithProperty("format", value);
    }

}

/// <summary>
/// Block type for default_route_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2StageDefaultRouteSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataTraceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_trace_enabled");
        set => WithProperty("data_trace_enabled", value);
    }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DetailedMetricsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("detailed_metrics_enabled");
        set => WithProperty("detailed_metrics_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingLevel
    {
        get => GetProperty<TerraformProperty<string>>("logging_level");
        set => WithProperty("logging_level", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingBurstLimit
    {
        get => GetProperty<TerraformProperty<double>>("throttling_burst_limit");
        set => WithProperty("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingRateLimit
    {
        get => GetProperty<TerraformProperty<double>>("throttling_rate_limit");
        set => WithProperty("throttling_rate_limit", value);
    }

}

/// <summary>
/// Block type for route_settings in .
/// Nesting mode: set
/// </summary>
public class AwsApigatewayv2StageRouteSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataTraceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_trace_enabled");
        set => WithProperty("data_trace_enabled", value);
    }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DetailedMetricsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("detailed_metrics_enabled");
        set => WithProperty("detailed_metrics_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingLevel
    {
        get => GetProperty<TerraformProperty<string>>("logging_level");
        set => WithProperty("logging_level", value);
    }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    public required TerraformProperty<string> RouteKey
    {
        get => GetProperty<TerraformProperty<string>>("route_key");
        set => WithProperty("route_key", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingBurstLimit
    {
        get => GetProperty<TerraformProperty<double>>("throttling_burst_limit");
        set => WithProperty("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingRateLimit
    {
        get => GetProperty<TerraformProperty<double>>("throttling_rate_limit");
        set => WithProperty("throttling_rate_limit", value);
    }

}

/// <summary>
/// Manages a aws_apigatewayv2_stage resource.
/// </summary>
public class AwsApigatewayv2Stage : TerraformResource
{
    public AwsApigatewayv2Stage(string name) : base("aws_apigatewayv2_stage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("execution_arn");
        this.DeclareOutput("invoke_url");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The auto_deploy attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoDeploy
    {
        get => GetProperty<TerraformProperty<bool>>("auto_deploy");
        set => this.WithProperty("auto_deploy", value);
    }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_id");
        set => this.WithProperty("client_certificate_id", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentId
    {
        get => GetProperty<TerraformProperty<string>>("deployment_id");
        set => this.WithProperty("deployment_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The stage_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? StageVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("stage_variables");
        set => this.WithProperty("stage_variables", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for access_log_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    public List<AwsApigatewayv2StageAccessLogSettingsBlock>? AccessLogSettings
    {
        get => GetProperty<List<AwsApigatewayv2StageAccessLogSettingsBlock>>("access_log_settings");
        set => this.WithProperty("access_log_settings", value);
    }

    /// <summary>
    /// Block for default_route_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteSettings block(s) allowed")]
    public List<AwsApigatewayv2StageDefaultRouteSettingsBlock>? DefaultRouteSettings
    {
        get => GetProperty<List<AwsApigatewayv2StageDefaultRouteSettingsBlock>>("default_route_settings");
        set => this.WithProperty("default_route_settings", value);
    }

    /// <summary>
    /// Block for route_settings.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsApigatewayv2StageRouteSettingsBlock>? RouteSettings
    {
        get => GetProperty<HashSet<AwsApigatewayv2StageRouteSettingsBlock>>("route_settings");
        set => this.WithProperty("route_settings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionArn => this["execution_arn"];

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    public TerraformExpression InvokeUrl => this["invoke_url"];

}
