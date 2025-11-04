using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_graphql_api resource.
/// </summary>
public class AwsAppsyncGraphqlApi : TerraformResource
{
    public AwsAppsyncGraphqlApi(string name) : base("aws_appsync_graphql_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("uris");
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    public string? ApiType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_type")?.Value;
        set => this.WithProperty("api_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public string? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type")?.Value;
        set => this.WithProperty("authentication_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The introspection_config attribute.
    /// </summary>
    public string? IntrospectionConfig
    {
        get => GetProperty<TerraformLiteralProperty<string>>("introspection_config")?.Value;
        set => this.WithProperty("introspection_config", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The merged_api_execution_role_arn attribute.
    /// </summary>
    public string? MergedApiExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("merged_api_execution_role_arn")?.Value;
        set => this.WithProperty("merged_api_execution_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_depth_limit attribute.
    /// </summary>
    public double? QueryDepthLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("query_depth_limit")?.Value;
        set => this.WithProperty("query_depth_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resolver_count_limit attribute.
    /// </summary>
    public double? ResolverCountLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("resolver_count_limit")?.Value;
        set => this.WithProperty("resolver_count_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public string? Schema
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema")?.Value;
        set => this.WithProperty("schema", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The visibility attribute.
    /// </summary>
    public string? Visibility
    {
        get => GetProperty<TerraformLiteralProperty<string>>("visibility")?.Value;
        set => this.WithProperty("visibility", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    public bool? XrayEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("xray_enabled")?.Value;
        set => this.WithProperty("xray_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uris attribute.
    /// </summary>
    public TerraformExpression Uris => this["uris"];

}
