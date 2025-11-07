using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_endpoint.
/// </summary>
public class AwsRoute53ResolverEndpointDataSource : TerraformDataSource
{
    public AwsRoute53ResolverEndpointDataSource(string name) : base("aws_route53_resolver_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("direction");
        this.DeclareOutput("ip_addresses");
        this.DeclareOutput("name");
        this.DeclareOutput("protocols");
        this.DeclareOutput("resolver_endpoint_type");
        this.DeclareOutput("status");
        this.DeclareOutput("vpc_id");
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
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResolverEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("resolver_endpoint_id");
        set => this.WithProperty("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The direction attribute.
    /// </summary>
    public TerraformExpression Direction => this["direction"];

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformExpression IpAddresses => this["ip_addresses"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformExpression Protocols => this["protocols"];

    /// <summary>
    /// The resolver_endpoint_type attribute.
    /// </summary>
    public TerraformExpression ResolverEndpointType => this["resolver_endpoint_type"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
