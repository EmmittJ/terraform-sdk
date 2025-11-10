using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock : ITerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ip_address_type");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_networkfirewall_vpc_endpoint_association resource.
/// </summary>
public class AwsNetworkfirewallVpcEndpointAssociation : TerraformResource
{
    public AwsNetworkfirewallVpcEndpointAssociation(string name) : base("aws_networkfirewall_vpc_endpoint_association", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallArn is required")]
    [TerraformPropertyName("firewall_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FirewallArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcId { get; set; }

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("subnet_mapping")]
    public TerraformList<TerraformBlock<AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock>>? SubnetMapping { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The vpc_endpoint_association_arn attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_association_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcEndpointAssociationArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_endpoint_association_arn");

    /// <summary>
    /// The vpc_endpoint_association_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcEndpointAssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_endpoint_association_id");

    /// <summary>
    /// The vpc_endpoint_association_status attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_association_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpcEndpointAssociationStatus => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpc_endpoint_association_status");

}
