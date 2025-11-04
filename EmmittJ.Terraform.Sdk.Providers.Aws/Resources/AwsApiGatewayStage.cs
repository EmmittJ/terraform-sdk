using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_stage resource.
/// </summary>
public class AwsApiGatewayStage : TerraformResource
{
    public AwsApiGatewayStage(string name) : base("aws_api_gateway_stage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("execution_arn");
        this.DeclareOutput("invoke_url");
        this.DeclareOutput("web_acl_arn");
    }

    /// <summary>
    /// The cache_cluster_enabled attribute.
    /// </summary>
    public bool? CacheClusterEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cache_cluster_enabled")?.Value;
        set => this.WithProperty("cache_cluster_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cache_cluster_size attribute.
    /// </summary>
    public string? CacheClusterSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_cluster_size")?.Value;
        set => this.WithProperty("cache_cluster_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    public string? ClientCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_id")?.Value;
        set => this.WithProperty("client_certificate_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public string? DeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_id")?.Value;
        set => this.WithProperty("deployment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The documentation_version attribute.
    /// </summary>
    public string? DocumentationVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("documentation_version")?.Value;
        set => this.WithProperty("documentation_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public string? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id")?.Value;
        set => this.WithProperty("rest_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public string? StageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage_name")?.Value;
        set => this.WithProperty("stage_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public Dictionary<string, string>? Variables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("variables")?.Value;
        set => this.WithProperty("variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The xray_tracing_enabled attribute.
    /// </summary>
    public bool? XrayTracingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("xray_tracing_enabled")?.Value;
        set => this.WithProperty("xray_tracing_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
