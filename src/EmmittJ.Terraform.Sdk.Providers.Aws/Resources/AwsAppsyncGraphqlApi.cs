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
    public TerraformProperty<string>? ApiType
    {
        get => GetProperty<TerraformProperty<string>>("api_type");
        set => this.WithProperty("api_type", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
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
    /// The introspection_config attribute.
    /// </summary>
    public TerraformProperty<string>? IntrospectionConfig
    {
        get => GetProperty<TerraformProperty<string>>("introspection_config");
        set => this.WithProperty("introspection_config", value);
    }

    /// <summary>
    /// The merged_api_execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? MergedApiExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("merged_api_execution_role_arn");
        set => this.WithProperty("merged_api_execution_role_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query_depth_limit attribute.
    /// </summary>
    public TerraformProperty<double>? QueryDepthLimit
    {
        get => GetProperty<TerraformProperty<double>>("query_depth_limit");
        set => this.WithProperty("query_depth_limit", value);
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
    /// The resolver_count_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ResolverCountLimit
    {
        get => GetProperty<TerraformProperty<double>>("resolver_count_limit");
        set => this.WithProperty("resolver_count_limit", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformProperty<string>? Schema
    {
        get => GetProperty<TerraformProperty<string>>("schema");
        set => this.WithProperty("schema", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformProperty<string>? Visibility
    {
        get => GetProperty<TerraformProperty<string>>("visibility");
        set => this.WithProperty("visibility", value);
    }

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? XrayEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("xray_enabled");
        set => this.WithProperty("xray_enabled", value);
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
