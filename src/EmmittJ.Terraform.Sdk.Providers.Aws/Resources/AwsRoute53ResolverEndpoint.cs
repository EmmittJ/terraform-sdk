using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_resolver_endpoint resource.
/// </summary>
public class AwsRoute53ResolverEndpoint : TerraformResource
{
    public AwsRoute53ResolverEndpoint(string name) : base("aws_route53_resolver_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("host_vpc_id");
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    public TerraformProperty<string>? Direction
    {
        get => GetProperty<TerraformProperty<string>>("direction");
        set => this.WithProperty("direction", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Protocols
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("protocols");
        set => this.WithProperty("protocols", value);
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
    /// The resolver_endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? ResolverEndpointType
    {
        get => GetProperty<TerraformProperty<string>>("resolver_endpoint_type");
        set => this.WithProperty("resolver_endpoint_type", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The host_vpc_id attribute.
    /// </summary>
    public TerraformExpression HostVpcId => this["host_vpc_id"];

}
