using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsRoute53ResolverEndpointDataSource.
/// Nesting mode: set
/// </summary>
public class AwsRoute53ResolverEndpointDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_route53_resolver_endpoint Terraform data source.
/// Retrieves information about a aws_route53_resolver_endpoint.
/// </summary>
public partial class AwsRoute53ResolverEndpointDataSource(string name) : TerraformDataSource("aws_route53_resolver_endpoint", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? ResolverEndpointId
    {
        get => new TerraformReference<string>(this, "resolver_endpoint_id");
        set => SetArgument("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    public TerraformValue<string> Direction
    {
        get => new TerraformReference<string>(this, "direction");
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> IpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformSet<string> Protocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "protocols").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resolver_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> ResolverEndpointType
    {
        get => new TerraformReference<string>(this, "resolver_endpoint_type");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53ResolverEndpointDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsRoute53ResolverEndpointDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
