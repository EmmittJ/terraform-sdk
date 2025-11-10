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
        get => GetRequiredProperty<TerraformProperty<string>>("destination_arn");
        set => WithProperty("destination_arn", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        get => GetRequiredProperty<TerraformProperty<string>>("format");
        set => WithProperty("format", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("deployment_id");
        set => WithProperty("deployment_id", value);
    }

    /// <summary>
    /// The percent_traffic attribute.
    /// </summary>
    public TerraformProperty<double>? PercentTraffic
    {
        get => GetProperty<TerraformProperty<double>>("percent_traffic");
        set => WithProperty("percent_traffic", value);
    }

    /// <summary>
    /// The stage_variable_overrides attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? StageVariableOverrides
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("stage_variable_overrides");
        set => WithProperty("stage_variable_overrides", value);
    }

    /// <summary>
    /// The use_stage_cache attribute.
    /// </summary>
    public TerraformProperty<bool>? UseStageCache
    {
        get => GetProperty<TerraformProperty<bool>>("use_stage_cache");
        set => WithProperty("use_stage_cache", value);
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
        this.WithOutput("arn");
        this.WithOutput("execution_arn");
        this.WithOutput("invoke_url");
        this.WithOutput("web_acl_arn");
    }

    /// <summary>
    /// The cache_cluster_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CacheClusterEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cache_cluster_enabled");
        set => this.WithProperty("cache_cluster_enabled", value);
    }

    /// <summary>
    /// The cache_cluster_size attribute.
    /// </summary>
    public TerraformProperty<string>? CacheClusterSize
    {
        get => GetProperty<TerraformProperty<string>>("cache_cluster_size");
        set => this.WithProperty("cache_cluster_size", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    public required TerraformProperty<string> DeploymentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("deployment_id");
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
    /// The documentation_version attribute.
    /// </summary>
    public TerraformProperty<string>? DocumentationVersion
    {
        get => GetProperty<TerraformProperty<string>>("documentation_version");
        set => this.WithProperty("documentation_version", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformProperty<string> StageName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("stage_name");
        set => this.WithProperty("stage_name", value);
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
    /// The variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Variables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("variables");
        set => this.WithProperty("variables", value);
    }

    /// <summary>
    /// The xray_tracing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? XrayTracingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("xray_tracing_enabled");
        set => this.WithProperty("xray_tracing_enabled", value);
    }

    /// <summary>
    /// Block for access_log_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    public List<AwsApiGatewayStageAccessLogSettingsBlock>? AccessLogSettings
    {
        get => GetProperty<List<AwsApiGatewayStageAccessLogSettingsBlock>>("access_log_settings");
        set => this.WithProperty("access_log_settings", value);
    }

    /// <summary>
    /// Block for canary_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanarySettings block(s) allowed")]
    public List<AwsApiGatewayStageCanarySettingsBlock>? CanarySettings
    {
        get => GetProperty<List<AwsApiGatewayStageCanarySettingsBlock>>("canary_settings");
        set => this.WithProperty("canary_settings", value);
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
