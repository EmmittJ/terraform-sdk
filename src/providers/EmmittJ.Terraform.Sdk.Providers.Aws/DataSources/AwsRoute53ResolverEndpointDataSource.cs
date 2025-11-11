using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53ResolverEndpointDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_route53_resolver_endpoint.
/// </summary>
public class AwsRoute53ResolverEndpointDataSource : TerraformDataSource
{
    public AwsRoute53ResolverEndpointDataSource(string name) : base("aws_route53_resolver_endpoint", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resolver_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("resolver_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResolverEndpointId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsRoute53ResolverEndpointDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [TerraformPropertyName("direction")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Direction => new TerraformReference(this, "direction");

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> IpAddresses => new TerraformReference(this, "ip_addresses");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Protocols => new TerraformReference(this, "protocols");

    /// <summary>
    /// The resolver_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("resolver_endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResolverEndpointType => new TerraformReference(this, "resolver_endpoint_type");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

}
