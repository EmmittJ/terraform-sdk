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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? ResolverEndpointId
    {
        get => GetArgument<TerraformValue<string>>("resolver_endpoint_id");
        set => SetArgument("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The direction attribute.
    /// </summary>
    public TerraformValue<string> Direction
        => AsReference("direction");

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> IpAddresses
        => AsReference("ip_addresses");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformSet<string> Protocols
        => AsReference("protocols");

    /// <summary>
    /// The resolver_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> ResolverEndpointType
        => AsReference("resolver_endpoint_type");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53ResolverEndpointDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsRoute53ResolverEndpointDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
