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
        set => SetProperty("destination_arn", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        set => SetProperty("format", value);
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
        set => SetProperty("data_trace_enabled", value);
    }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DetailedMetricsEnabled
    {
        set => SetProperty("detailed_metrics_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingLevel
    {
        set => SetProperty("logging_level", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingBurstLimit
    {
        set => SetProperty("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingRateLimit
    {
        set => SetProperty("throttling_rate_limit", value);
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
        set => SetProperty("data_trace_enabled", value);
    }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DetailedMetricsEnabled
    {
        set => SetProperty("detailed_metrics_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingLevel
    {
        set => SetProperty("logging_level", value);
    }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    public required TerraformProperty<string> RouteKey
    {
        set => SetProperty("route_key", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingBurstLimit
    {
        set => SetProperty("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingRateLimit
    {
        set => SetProperty("throttling_rate_limit", value);
    }

}

/// <summary>
/// Manages a aws_apigatewayv2_stage resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2Stage : TerraformResource
{
    public AwsApigatewayv2Stage(string name) : base("aws_apigatewayv2_stage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("execution_arn");
        SetOutput("invoke_url");
        SetOutput("api_id");
        SetOutput("auto_deploy");
        SetOutput("client_certificate_id");
        SetOutput("deployment_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("stage_variables");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The auto_deploy attribute.
    /// </summary>
    public TerraformProperty<bool> AutoDeploy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_deploy");
        set => SetProperty("auto_deploy", value);
    }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string> ClientCertificateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate_id");
        set => SetProperty("client_certificate_id", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public TerraformProperty<string> DeploymentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_id");
        set => SetProperty("deployment_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The stage_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> StageVariables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("stage_variables");
        set => SetProperty("stage_variables", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for access_log_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    public List<AwsApigatewayv2StageAccessLogSettingsBlock>? AccessLogSettings
    {
        set => SetProperty("access_log_settings", value);
    }

    /// <summary>
    /// Block for default_route_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteSettings block(s) allowed")]
    public List<AwsApigatewayv2StageDefaultRouteSettingsBlock>? DefaultRouteSettings
    {
        set => SetProperty("default_route_settings", value);
    }

    /// <summary>
    /// Block for route_settings.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsApigatewayv2StageRouteSettingsBlock>? RouteSettings
    {
        set => SetProperty("route_settings", value);
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
