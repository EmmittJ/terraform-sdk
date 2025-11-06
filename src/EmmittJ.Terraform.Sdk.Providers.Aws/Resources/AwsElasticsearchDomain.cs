using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_elasticsearch_domain resource.
/// </summary>
public class AwsElasticsearchDomain : TerraformResource
{
    public AwsElasticsearchDomain(string name) : base("aws_elasticsearch_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("domain_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("kibana_endpoint");
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    public string? AccessPolicies
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_policies")?.Value;
        set => this.WithProperty("access_policies", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public Dictionary<string, string>? AdvancedOptions
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("advanced_options")?.Value;
        set => this.WithProperty("advanced_options", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The elasticsearch_version attribute.
    /// </summary>
    public string? ElasticsearchVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("elasticsearch_version")?.Value;
        set => this.WithProperty("elasticsearch_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformExpression DomainId => this["domain_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The kibana_endpoint attribute.
    /// </summary>
    public TerraformExpression KibanaEndpoint => this["kibana_endpoint"];

}
