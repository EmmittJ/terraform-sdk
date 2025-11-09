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
    public TerraformProperty<string>? AccessPolicies
    {
        get => GetProperty<TerraformProperty<string>>("access_policies");
        set => this.WithProperty("access_policies", value);
    }

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public TerraformMapProperty<string>? AdvancedOptions
    {
        get => GetProperty<TerraformMapProperty<string>>("advanced_options");
        set => this.WithProperty("advanced_options", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The elasticsearch_version attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticsearchVersion
    {
        get => GetProperty<TerraformProperty<string>>("elasticsearch_version");
        set => this.WithProperty("elasticsearch_version", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
