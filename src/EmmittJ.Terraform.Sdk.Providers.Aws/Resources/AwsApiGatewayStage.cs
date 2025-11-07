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
    public TerraformLiteralProperty<bool>? CacheClusterEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cache_cluster_enabled");
        set => this.WithProperty("cache_cluster_enabled", value);
    }

    /// <summary>
    /// The cache_cluster_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CacheClusterSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_cluster_size");
        set => this.WithProperty("cache_cluster_size", value);
    }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_id");
        set => this.WithProperty("client_certificate_id", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_id");
        set => this.WithProperty("deployment_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The documentation_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DocumentationVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("documentation_version");
        set => this.WithProperty("documentation_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage_name");
        set => this.WithProperty("stage_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Variables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("variables");
        set => this.WithProperty("variables", value);
    }

    /// <summary>
    /// The xray_tracing_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? XrayTracingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("xray_tracing_enabled");
        set => this.WithProperty("xray_tracing_enabled", value);
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
