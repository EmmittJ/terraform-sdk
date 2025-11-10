using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_log_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayStageAccessLogSettingsBlock : TerraformBlock
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
/// Block type for canary_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayStageCanarySettingsBlock : TerraformBlock
{
    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    public required TerraformProperty<string> DeploymentId
    {
        set => SetProperty("deployment_id", value);
    }

    /// <summary>
    /// The percent_traffic attribute.
    /// </summary>
    public TerraformProperty<double>? PercentTraffic
    {
        set => SetProperty("percent_traffic", value);
    }

    /// <summary>
    /// The stage_variable_overrides attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? StageVariableOverrides
    {
        set => SetProperty("stage_variable_overrides", value);
    }

    /// <summary>
    /// The use_stage_cache attribute.
    /// </summary>
    public TerraformProperty<bool>? UseStageCache
    {
        set => SetProperty("use_stage_cache", value);
    }

}

/// <summary>
/// Manages a aws_api_gateway_stage resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayStage : TerraformResource
{
    public AwsApiGatewayStage(string name) : base("aws_api_gateway_stage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("execution_arn");
        SetOutput("invoke_url");
        SetOutput("web_acl_arn");
        SetOutput("cache_cluster_enabled");
        SetOutput("cache_cluster_size");
        SetOutput("client_certificate_id");
        SetOutput("deployment_id");
        SetOutput("description");
        SetOutput("documentation_version");
        SetOutput("id");
        SetOutput("region");
        SetOutput("rest_api_id");
        SetOutput("stage_name");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("variables");
        SetOutput("xray_tracing_enabled");
    }

    /// <summary>
    /// The cache_cluster_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CacheClusterEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cache_cluster_enabled");
        set => SetProperty("cache_cluster_enabled", value);
    }

    /// <summary>
    /// The cache_cluster_size attribute.
    /// </summary>
    public TerraformProperty<string> CacheClusterSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cache_cluster_size");
        set => SetProperty("cache_cluster_size", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    public required TerraformProperty<string> DeploymentId
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
    /// The documentation_version attribute.
    /// </summary>
    public TerraformProperty<string> DocumentationVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("documentation_version");
        set => SetProperty("documentation_version", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rest_api_id");
        set => SetProperty("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformProperty<string> StageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stage_name");
        set => SetProperty("stage_name", value);
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
    /// The variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Variables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("variables");
        set => SetProperty("variables", value);
    }

    /// <summary>
    /// The xray_tracing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> XrayTracingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("xray_tracing_enabled");
        set => SetProperty("xray_tracing_enabled", value);
    }

    /// <summary>
    /// Block for access_log_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    public List<AwsApiGatewayStageAccessLogSettingsBlock>? AccessLogSettings
    {
        set => SetProperty("access_log_settings", value);
    }

    /// <summary>
    /// Block for canary_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanarySettings block(s) allowed")]
    public List<AwsApiGatewayStageCanarySettingsBlock>? CanarySettings
    {
        set => SetProperty("canary_settings", value);
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

    /// <summary>
    /// The web_acl_arn attribute.
    /// </summary>
    public TerraformExpression WebAclArn => this["web_acl_arn"];

}
