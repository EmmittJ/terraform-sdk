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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public string? ResolverEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resolver_endpoint_id")?.Value;
        set => this.WithProperty("resolver_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
